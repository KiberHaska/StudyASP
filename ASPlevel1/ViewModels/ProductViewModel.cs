﻿using AspLevel1.Domain.Entities.Base.Interfaces;

namespace ASPlevel1.ViewModels
{
    public class ProductViewModel : INamedEntity, IOrderedEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public string Brand { get; set; }
        public string BrandName { get; set; }
    }
}