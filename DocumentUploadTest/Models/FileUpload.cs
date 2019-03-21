using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentUploadTest.Models
{
    public class FileUpload
    {
        public FileUpload()
        {
            Files = new List<IFormFile>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public List<IFormFile> Files { get; set; }
    }
}
