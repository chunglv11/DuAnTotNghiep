﻿using BanMoHinh.Share.Models;
using BanMoHinh.Share.ViewModels;

namespace BanMoHinh.API.IServices
{
    public interface IProductDetailService
    {
        public Task<bool> Create(ProductDetailVM item);

        public Task<bool> CreateMany(List<ProductDetailVM> items);

        public Task<bool> Delete(Guid id);

        //public Task<bool> DeleteMany(List<> items);

        public Task<IEnumerable<ProductDetailVM>> GetAll();

        public Task<ProductDetailVM> GetItem(Guid id);
        public  Task<bool> UpdateQuantity(Guid ID, int  quantity);

        public Task<bool> Update(ProductDetailVM item);
        public decimal GetPriceForProductDetail(Guid sizeId, Guid colorId, Guid productId);
    }
}
