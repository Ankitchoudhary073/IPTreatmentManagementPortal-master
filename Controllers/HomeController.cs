using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IPTreatmentManagementPortal.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Text;

namespace IPTreatmentManagementPortal.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            
            return RedirectToAction("Login");

        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            string token = GetToken("http://localhost:53093/api/Token", user);
            if (token != null)
            {
                return RedirectToAction("Index", "Admin", new { name = token });       
            }
            else
            {
                ViewBag.invalid = "UserId or Password invalid";
                return View();
            }
        }
        static string GetToken(string url,User user)
        {
         
            var json = JsonConvert.SerializeObject(user);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                var response = client.PostAsync(url, data).Result;
                string name = response.Content.ReadAsStringAsync().Result;
                dynamic details = JObject.Parse(name);
                return details.token;
            }
        }

       

    }
}
