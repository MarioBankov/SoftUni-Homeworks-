using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using test.Models;

namespace test.Controllers
{
    public class CatsController:Controller
    {
        public IActionResult All(int total)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < total; i++)
            {
                list.Add(i + 1);
            }
            return View(list);
        }
    }
}
