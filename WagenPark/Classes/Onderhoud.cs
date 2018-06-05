using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WagenPark.Classes
{
    public class Onderhoud
    {
        [Key]
        public string Onderhoudsdatum { get; set; }
        public string Kosten { get; set; }
        [Key]
        public string AutoKenteken { get; set; }
        public string werkplaats_werkplaatsnr { get; set; }
    }
}