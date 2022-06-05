﻿using OnlineShopWebApplication.Models;
using System.Linq;

namespace OnlineShopWebApplication
{
    public class CartsInMemoryRepository : ICartsRepository
    {
        private List<Cart> carts = new List<Cart>();

        public Cart TryGetByUserId(string userId)
        {
            return carts.FirstOrDefault(x => x.UserId == userId);
        }

        public void Add(Product product, string userId)
        {
            var existingCard = TryGetByUserId(userId);
            if (existingCard == null)
            {
                var newCart = new Cart
                {
                    Id = Guid.NewGuid(),
                    UserId = userId,
                    Items = new List<CartItem>
                    {
                        new CartItem
                        {
                            Id = Guid.NewGuid(),
                            Amount = 1,
                            Product = product
                        }
                    }
                };
                carts.Add(newCart);
            }
            else
            {
                var existingCardItem = existingCard.Items.FirstOrDefault(x => x.Product.Id == product.Id);
                if (existingCardItem != null)
                {
                    existingCardItem.Amount += 1;
                }
                else
                {
                    existingCard.Items.Add(new CartItem
                    {
                        Id = Guid.NewGuid(),
                        Amount = 1,
                        Product = product
                    });
                }
            }
        }
    }
}
