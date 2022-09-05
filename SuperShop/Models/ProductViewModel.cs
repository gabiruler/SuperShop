using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using SuperShop.Data.Entities;

namespace SuperShop.Models
{
    public class ProductViewModel : Product
    {
        [Display(Name="Image")]
        public IFormFile ImageFile { get; set; }
    }
}
