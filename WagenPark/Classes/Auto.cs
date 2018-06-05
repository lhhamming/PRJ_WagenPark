using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WagenPark.Classes
{
    public class Auto
    {
        [Key]
        public string Kenteken { get; set; }
        public string Merk { get; set; }
        public string Type { get; set; }
    }
}