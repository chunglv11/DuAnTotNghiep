﻿using BanMoHinh.API.Data;
using BanMoHinh.API.IServices;
using BanMoHinh.Share.Models;
using Microsoft.EntityFrameworkCore;

namespace BanMoHinh.API.Services
{
    public class RateService : IRateService
    {

        private readonly MyDbContext _dbContext;

        public RateService(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> Create(Rate item)
        {
            try
            {
                var rate = new Rate()
                {
                    OrderItemId = item.OrderItemId,
                    Content = item.Content,
                    ImageUrl = item.ImageUrl,
                    Reply = item.Reply,
                    Rating = item.Rating,
                };
                await _dbContext.Rate.AddAsync(rate);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public async Task<bool> Delete(Guid id,Guid orderid)
        {
            try
            {
                var item = await _dbContext.Rate.FirstOrDefaultAsync(c => c.Id == id&&c.OrderItemId == orderid);
                _dbContext.Remove(item);
                await _dbContext.SaveChangesAsync();
                return true;

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return false;
            }
        }

        public async Task<List<Rate>> GetAll()
        {
            return await _dbContext.Rate.ToListAsync();
        }

        public async Task<Rate> GetItem(Guid id)
        {
            return await _dbContext.Rate.FindAsync(id);
        }

        public async Task<List<Rate>> GetListRatebyorderId(Guid orderId)
        {
            var rates = await _dbContext.Rate.Where(rate => rate.OrderItemId == orderId).ToListAsync();
            return rates;
        }

        public async Task<bool> Update(Guid id,Guid orderid, Rate rate)
        {
            try
            {
                var rates = await _dbContext.Rate.FirstOrDefaultAsync(c => c.Id == id&&c.OrderItemId == orderid);

                rates.OrderItemId = orderid;
                rates.ImageUrl = rate.ImageUrl;
                rates.Reply = rate.Reply;
                rates.Content = rate.Content;
                rates.Rating = rate.Rating;
                _dbContext.Rate.Update(rates);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
