using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuissnesLayer.Models
{
    public class PhotoViewModel
    {
        [BindProperty]
        public IFormFile Image { get; set; }
        public string PhotoKey { get; set; }

    }
}
