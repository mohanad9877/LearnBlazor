﻿namespace LearnBlazor.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsAvailable { get; set; }
        public double Price { get; set; }
        public IEnumerable<Product_Prop> ProductProperties { get; set; }

    }
}
