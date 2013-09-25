using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Xamarin.Web.BarcodeSample.Models
{
    public class PromoModel
    {
        [Required]
        public string PromoCode { get; set; }
    }
}