﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WagenPark.Classes
{
    public class Dealer
    {
        [Key]
        public string dealerNr { get; set; }
        public string naam { get; set; }
    }
}