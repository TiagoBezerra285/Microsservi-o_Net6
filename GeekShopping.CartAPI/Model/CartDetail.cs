﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using GeekShopping.CartApi.Model;
using GeekShopping.CartApi.Model.Base;

namespace GeekShopping.CartAPI.Model
{
	[Table("cart_detail")]
	public class CartDetail : BaseEntity
	{
        public long CartHeaderId { get; set; }

        [ForeignKey("CartheaderId")]
        public virtual CartHeader CartHeader { get; set; }
        public long ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        [Column("count")]
        public int Count { get; set; }
    }
}

