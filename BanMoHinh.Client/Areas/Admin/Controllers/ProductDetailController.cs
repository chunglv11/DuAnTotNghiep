﻿using BanMoHinh.Client.IServices;
using BanMoHinh.Share.Models;
using BanMoHinh.Share.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Net.Http;

namespace BanMoHinh.Client.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductDetailController : Controller
    {
        private IproductDetailApiClient _apiClient;
        private HttpClient _httpClient;
        public ProductDetailController(IproductDetailApiClient iproductDetail, HttpClient httpClient)
        {
            _apiClient = iproductDetail;
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Show()
        {
            var response = await _apiClient.GetAllProductDetail();
            
            return View(response);

        }
        public async Task<IActionResult> Create(Guid productId, Guid sizeId, Guid colorId)
        {
            var productprops = _apiClient.GetListProduct();
            ViewBag.ProductProp = productprops.Result.Select(x => new SelectListItem()
            {
                Text = x.ProductName,
                Value = x.Id.ToString(),
                Selected = productId.ToString() == x.Id.ToString()
            });
            var sizes = _apiClient.GetListSize();
            ViewBag.Size = sizes.Result.Select(x => new SelectListItem()
            {
                Text = x.SizeName,
                Value = x.Id.ToString(),
                Selected = sizeId.ToString() == x.Id.ToString()
            });
            var colors = _apiClient.GetListColor();
            ViewBag.Color = colors.Result.Select(x => new SelectListItem()
            {
                Text = x.ColorName,
                Value = x.ColorId.ToString(),
                Selected = colorId.ToString() == x.ColorId.ToString()
            });
            return View();
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Create([FromForm] ProductDetailVM product, Guid productId, Guid sizeId, Guid colorId)
        {
            if (!ModelState.IsValid)
            {
                return View(ModelState);
            }
            var productprops = _apiClient.GetListProduct();
            ViewBag.ProductProp = productprops.Result.Select(x => new SelectListItem()
            {
                Text = x.ProductName,
                Value = x.Id.ToString(),
                Selected = productId.ToString() == x.Id.ToString()
            });
            var sizes = _apiClient.GetListSize();
            ViewBag.Size = sizes.Result.Select(x => new SelectListItem()
            {
                Text = x.SizeName,
                Value = x.Id.ToString(),
                Selected = sizeId.ToString() == x.Id.ToString()
            });
            var colors = _apiClient.GetListColor();
            ViewBag.Color = colors.Result.Select(x => new SelectListItem()
            {
                Text = x.ColorName,
                Value = x.ColorId.ToString(),
                Selected = colorId.ToString() == x.ColorId.ToString()
            });
            product.Status = true;
            product.Create_At = DateTime.Now;
            var result = await _apiClient.CreateProduct(product, productId, sizeId, colorId);
            if (result)
            {
                return Json(new { success = true, message = "Tạo sản phẩm thành công!" });
            }
            return Json(new { success = true, message = "Tạo sản phẩm thất bại!" });

        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid id, Guid sizeId, Guid colorId)
        {
            var sizes = _apiClient.GetListSize();
            ViewBag.Size = sizes.Result.Select(x => new SelectListItem()
            {
                Text = x.SizeName,
                Value = x.Id.ToString(),
                Selected = sizeId.ToString() == x.Id.ToString()
            });
            var colors = _apiClient.GetListColor();
            ViewBag.Color = colors.Result.Select(x => new SelectListItem()
            {
                Text = x.ColorName,
                Value = x.ColorId.ToString(),
                Selected = colorId.ToString() == x.ColorId.ToString()
            });
            var response = await _apiClient.GetByIdProductDetail(id);
            //var producti = await _httpClient.GetFromJsonAsync<List<ProductImage>>("https://localhost:7007/api/productimage/get-all-productimage");
            var productImages = await _apiClient.GetListProI();
            ViewBag.ProductImages = productImages;
            return View(response);
        }

        public async Task<IActionResult> Update(ProductDetailVM create, Guid sizeId, Guid colorId)
        {
            try
            {
                var sizes = _apiClient.GetListSize();
                ViewBag.Size = sizes.Result.Select(x => new SelectListItem()
                {
                    Text = x.SizeName,
                    Value = x.Id.ToString(),
                    Selected = sizeId.ToString() == x.Id.ToString()
                });
                var colors = _apiClient.GetListColor();
                ViewBag.Color = colors.Result.Select(x => new SelectListItem()
                {
                    Text = x.ColorName,
                    Value = x.ColorId.ToString(),
                    Selected = colorId.ToString() == x.ColorId.ToString()
                });
                //var producti = await _apiClient.GetListProI();
                //ViewData["productImage"] = producti;
                var productImages = await _apiClient.GetListProI();
                ViewBag.ProductImages = productImages;
                var response = await _apiClient.UpdateProduct(create, sizeId, colorId);
                
                if (response)
                {
                    return RedirectToAction("Show");
                }
                else
                {
                    ModelState.AddModelError("", "Cập nhật sản phẩm thất bại");
                    return View(create);
                }

            }
            catch (Exception)
            {
                return View();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid Id)
        {

            var result = await _apiClient.GetByIdProductDetail(Id);
            return View(result);
        }
        [HttpGet]
        public async Task<IActionResult> Remove(Guid Id)
        {
            var response = await _apiClient.DeleteProductDetail(Id);

            if (response)
            {
                return RedirectToAction("Show");
            }
            else
            {
                return BadRequest();
            }
        }
        
        public async Task<IActionResult> RemoveProI(Guid Id)
        {
        
            var response = await _httpClient.DeleteAsync($"https://localhost:7007/api/productimage/delete-productimage-{Id}");

            if (response.IsSuccessStatusCode)
            {
                return Json(new { success = true, message = "Xoá ảnh thành công!" });
            }
            else
            {
                return Json(new { success = false, message = "Xoá ảnh thất bại!" });
            }
        }

    }
}
