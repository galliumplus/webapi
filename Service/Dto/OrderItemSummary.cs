﻿using GalliumPlus.WebApi.Core;
using GalliumPlus.WebApi.Core.Data;
using GalliumPlus.WebApi.Core.Sales;
using System.ComponentModel.DataAnnotations;

namespace GalliumPlus.WebApi.Dto
{
    public class OrderItemSummary
    {
        [Required] public int? Product { get; set; }
        [Required] public int? Quantity { get; set; }

        public class Mapper : Mapper<OrderItem, OrderItemSummary, IProductDao>
        {
            public override OrderItemSummary FromModel(OrderItem model)
            {
                // ne sort jamais du serveur !
                throw new NotImplementedException();
            }

            public override OrderItem ToModel(OrderItemSummary dto, IProductDao dao)
            {
                if (dto.Quantity!.Value <= 0)
                {
                    throw new InvalidItemException("La quantité d'un produit doit être supérieure à zéro.");
                }

                return new OrderItem(dao.Read(dto.Product!.Value), dto.Quantity!.Value);
            }
        }
    }
}