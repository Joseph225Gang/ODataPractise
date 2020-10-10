﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OdatPractiseCoreApi.Models
{
    public class Product
    {
        [Key]
        public int EntityID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
