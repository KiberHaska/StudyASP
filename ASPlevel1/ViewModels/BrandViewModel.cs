﻿using AspLevel1.Domain.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPlevel1.ViewModels
{
    public class BrandViewModel : INamedEntity, IOrderedEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// Количество товаров бренда
        /// </summary>
        public int ProductsCount { get; set; }

        public int Order { get; set; }
    }
}
