using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Level2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Level2.Controllers
{
    public class ProductController : Controller
    {
        public List<Product> Index()
        {
            List<Product> product = new List<Product>();
            return product;
        }
    }
}