﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellSwap.Shared.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StatusId { get; set; }
        public virtual ProductStatus? ProductStatus { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; } 
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
        public int UserId { get; set; }
        public virtual User? User { get; set; }
        public virtual List<Favourite>? Favourites { get; set; }
    }
}