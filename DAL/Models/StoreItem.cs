﻿namespace DAL
{
    public class StoreItem
    {
        public int StoreId { get; set; }
        public Store Store { get; set; }

        public int ItemId { get; set; }
        public Item Item { get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}