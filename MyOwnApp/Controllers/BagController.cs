﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyOwnApp.Data.Interfaces;
using MyOwnApp.Data.Models;
using MyOwnApp.Models;
using MyOwnApp.ViewModels;
using Newtonsoft.Json;

namespace MyOwnApp.Controllers
{
    public class BagController : Controller
    {
        private readonly IProducts _products;
        private readonly IProducers _producers;
        private readonly IProductModels _productModels;
        private readonly IProductImages _productImages;
        private readonly IMaterials _materials;
        private readonly IDimensions _dimensions;
        private readonly IOrders _orders;
        private readonly ITypeOfProducts _type;
        private readonly ISubCategories _subCategories;
        private readonly IProductOrders _productOrders;
        private readonly IDeliveries _deliveries;
        private readonly ILikes _likes;
        private readonly IDislikes _dislikes;


        public BagController(IDislikes dislikes, ILikes likes, IDeliveries deliveries, IProductOrders productOrders, ITypeOfProducts type, ISubCategories subCategories, IOrders orders, IDimensions dimensions, IProducts products, IProducers producers, IProductModels productModels, IProductImages productImages, IMaterials materials)
        {
            _products = products;
            _producers = producers;
            _productModels = productModels;
            _productImages = productImages;
            _materials = materials;
            _dimensions = dimensions;
            _orders = orders;
            _type = type;
            _subCategories = subCategories;
            _productOrders = productOrders;
            _deliveries = deliveries;
            _dislikes = dislikes;
            _likes = likes;
        }

        [HttpGet]
        public IActionResult Catalog()
        {
            CatalogModel obj = new CatalogModel();
            LayoutViewModel layoutModel = new LayoutViewModel();
            layoutModel.GetProducers = _producers.GetProducers.ToList();
            layoutModel.ProducersCount = _producers.GetProducers.Count();
            layoutModel.GetTypeOfProducts = _type.GetTypeOfProducts.ToList();
            layoutModel.TypeCount = _type.GetTypeOfProducts.Count();
            layoutModel.GetSubCategories = _subCategories.GetSubCategories.ToList();
            layoutModel.SubCategoriesCount = _subCategories.GetSubCategories.Count();
            obj.LayoutModel = layoutModel;
            obj.GetProducts = _products.GetProducts.ToList();
            obj.ProductsCount = _products.GetProducts.Count();
            obj.GetProductImages = _productImages.GetProductImages.ToList();
            obj.ProductImagesCount = _productImages.GetProductImages.Count();
            return View(obj);
        }
        [HttpGet]
        public IActionResult Cart()
        {
            var info = HttpContext.Session.GetString("SessionUser");
            if (info != null)
            {
                var result = JsonConvert.DeserializeObject<UserInfo>(info);

                CartModel obj = new CartModel();
                LayoutViewModel layoutModel = new LayoutViewModel();
                layoutModel.GetProducers = _producers.GetProducers.ToList();
                layoutModel.ProducersCount = _producers.GetProducers.Count();
                layoutModel.GetTypeOfProducts = _type.GetTypeOfProducts.ToList();
                layoutModel.TypeCount = _type.GetTypeOfProducts.Count();
                layoutModel.GetSubCategories = _subCategories.GetSubCategories.ToList();
                layoutModel.SubCategoriesCount = _subCategories.GetSubCategories.Count();
                obj.LayoutModel = layoutModel;
                var order = _orders.GetOrders.FirstOrDefault(o => o.UserId == result.UserId);
                obj.GetOrder = order;
                var prOr = _productOrders.GetProductOrders.Where(t => t.OrderId == order.Id).ToList();
                obj.GetProducts = _products.GetProducts.Where(p => prOr.All(p2 => p2.ProductId == p.Id)).ToList();
                obj.GetProductImages = _productImages.GetProductImages.ToList();
                obj.GetDeliveries = _deliveries.GetDeliveries.ToList();
                return View(obj);
            }
            return RedirectToAction("AccountAction", "Account");
        }
        [HttpGet]
        [Route("Bag/Product/{id}")]
        public IActionResult Product(int id)
        {
            var info = HttpContext.Session.GetString("SessionUser");
            if (info != null)
            {
                var result = JsonConvert.DeserializeObject<UserInfo>(info);

                ProductViewModel obj = new ProductViewModel();
                LayoutViewModel layoutModel = new LayoutViewModel();
                layoutModel.GetProducers = _producers.GetProducers.ToList();
                layoutModel.ProducersCount = _producers.GetProducers.Count();
                layoutModel.GetTypeOfProducts = _type.GetTypeOfProducts.ToList();
                layoutModel.TypeCount = _type.GetTypeOfProducts.Count();
                layoutModel.GetSubCategories = _subCategories.GetSubCategories.ToList();
                layoutModel.SubCategoriesCount = _subCategories.GetSubCategories.Count();
                obj.LayoutModel = layoutModel;
                var prod = _products.GetProducts.FirstOrDefault(p => p.Id == id);
                obj.GetProduct = prod;
                obj.GetProductImages = _productImages.GetProductImages.Where(t => t.ProductId == id).ToList();
                obj.Material = _materials.GetMaterials.FirstOrDefault(t => t.Products.Contains(prod));
                obj.Type = _type.GetTypeOfProducts.FirstOrDefault(t => t.Products.Contains(prod));
                obj.Dimension = _dimensions.GetDimensions.FirstOrDefault(t => t.ProductId == id);
                obj.Model = _productModels.GetModels.FirstOrDefault(t => t.Products.Contains(prod));
                obj.LikesCount = _likes.GetLikes.Where(t => t.ProductId == id).Count();
                obj.DislikesCount = _dislikes.GetDislikes.Where(t => t.ProductId == id).Count();
                var isLike = _likes.GetLikes.FirstOrDefault(t => t.ProductId == id && t.UserId == result.UserId);
                obj.AlreadyDisliked = false;
                obj.AlreadyLiked = false;
                if (isLike != null)
                    obj.AlreadyLiked = true;
                else
                {
                    var isDislike = _dislikes.GetDislikes.FirstOrDefault(t => t.ProductId == id && t.UserId == result.UserId);
                    if (isDislike != null)
                        obj.AlreadyDisliked = true;
                }
                return View(obj);
            }
            return RedirectToAction("AccountAction", "Account");
        }
        [HttpGet]
        [Route("Bag/Liked/{id}")]
        public IActionResult Liked(int id)
        {
            var info = HttpContext.Session.GetString("SessionUser");
            if (info != null)
            {
                var result = JsonConvert.DeserializeObject<UserInfo>(info);
                _likes.AddLike(new Likes { ProductId = id, UserId = result.UserId });
                return RedirectToAction("Product", "Bag", new { id = id });
            }
            return RedirectToAction("AccountAction", "Account");
        }
        [HttpGet]
        [Route("Bag/Disliked/{id}")]
        public IActionResult Disliked(int id)
        {
            var info = HttpContext.Session.GetString("SessionUser");
            if (info != null)
            {
                var result = JsonConvert.DeserializeObject<UserInfo>(info);
                _dislikes.AddDislike(new Dislikes { ProductId = id, UserId = result.UserId });
                return RedirectToAction("Product","Bag",new { id=id});
            }
            return RedirectToAction("AccountAction", "Account");
        }
    }
}