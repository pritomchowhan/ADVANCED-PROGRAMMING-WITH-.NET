﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZeroHunger.DTO
{
    public class addFoodDTO
    {
        [Required]
        public string type { get; set; }
        [Required]
        public int quantity { get; set; }
    }
}