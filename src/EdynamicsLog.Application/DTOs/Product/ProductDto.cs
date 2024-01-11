using EdynamicsLog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using EdynamicsLog.Domain.Common;

namespace EdynamicsLog.Application.DTOs.Product
{
    public class ProductSingleResponseDto
    {
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }

}
