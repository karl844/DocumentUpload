using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DocumentUploadTest.Models;
using Microsoft.AspNetCore.Http;

namespace DocumentUploadTest.Controllers
{
    public class HomeController : Controller
    {        
        [HttpGet]
        public IActionResult Index()
        {
            List<FileUpload> fileUploads = new List<FileUpload>
            {
                new FileUpload
                {
                    Id = 1,
                    Name = "PhotoId"
                },
                new FileUpload
                {
                    Id = 2,
                    Name = "Testimonial"
                },
                new FileUpload
                {
                    Id = 3,
                    Name = "Passport"
                }
            };

            return View(fileUploads);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(List<FileUpload> fileUploads)
        {
            int fileCnt = 0;

            ModelState.AddModelError($"[{fileCnt}].Files", "This is required");
                
            return View(fileUploads);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
