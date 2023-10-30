﻿using BanMoHinh.Client.IServices;
using BanMoHinh.Share.Models;
using BanMoHinh.Share.ViewModels;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Security.Policy;

namespace BanMoHinh.Client.Services
{
    public class ProductDetailApiClient : IproductDetailApiClient
    {
        private HttpClient _httpClient;

        public ProductDetailApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> CreateProduct(ProductDetailVM request, Guid productId, Guid sizeId, Guid colorId, string edit)
        {
            string apiUrl = "https://localhost:7007/api/productDetail/create-productdetail";
            var requestContent = new MultipartFormDataContent();
            request.ProductId = productId;
            request.SizeId = sizeId;
            request.ColorId = colorId;
            request.Description = edit;
            requestContent.Add(new StringContent(request.ProductId.ToString()), "productid");
            requestContent.Add(new StringContent(request.ColorId.ToString()), "colorid");
            requestContent.Add(new StringContent(request.SizeId.ToString()), "sizeid");
            requestContent.Add(new StringContent(request.Quantity.ToString()), "quantity");
            requestContent.Add(new StringContent(request.Price.ToString()), "price");
            requestContent.Add(new StringContent(request.PriceSale.ToString()), "pricesale");
            requestContent.Add(new StringContent(request.Create_At.ToString()), "create_At");
            requestContent.Add(new StringContent(request.Update_At.ToString()), "update_At");
            requestContent.Add(new StringContent(request.Description.ToString()), "description");
            requestContent.Add(new StringContent(request.Status.ToString()), "status");
            foreach (var file in request.filecollection)
            {
                requestContent.Add(new StreamContent(file.OpenReadStream())
                {
                    Headers =
                     {
                       ContentLength = file.Length,
                       ContentType = new MediaTypeHeaderValue(file.ContentType)
                     }
                }, "filecollection", file.FileName);
            }
            var response = await _httpClient.PostAsync(apiUrl, requestContent);
            return response.IsSuccessStatusCode;
        }

        public async Task<List<Colors>> GetListColor()
        {
            string apiUrl = "https://localhost:7007/api/color/get-all-Color";
            var response = await _httpClient.GetAsync(apiUrl);
            response.EnsureSuccessStatusCode();
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<Colors>>(apiData);
            return result;
        }

        public async Task<List<ProductVM>> GetListProduct()
        {
            string apiUrl = "https://localhost:7007/api/product/get-all-product";
            var response = await _httpClient.GetAsync(apiUrl);
            response.EnsureSuccessStatusCode();
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<ProductVM>>(apiData);
            return result;
        }

        public async Task<List<SizeVM>> GetListSize()
        {
            string apiUrl = "https://localhost:7007/api/size/get-all-size";
            var response = await _httpClient.GetAsync(apiUrl);
            response.EnsureSuccessStatusCode();
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<SizeVM>>(apiData);
            return result;
        }
    }
}