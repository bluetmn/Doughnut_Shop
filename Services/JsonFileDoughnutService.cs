using System.Collections.Generic;
using System.IO;
using System.Linq;
using RazorPagesDoughnuts.Models;
using Microsoft.AspNetCore.Hosting;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RazorPagesDoughnuts.Services
{
    public class JsonFileDoughnutService {

        public JsonFileDoughnutService(IWebHostEnvironment webHostEnv) {
            WebHostEnv = webHostEnv;
        }

        public IWebHostEnvironment WebHostEnv { get; }

        private string JsonFileName => Path.Combine(WebHostEnv.WebRootPath, "data", "doughnutdata.json")!; 


        public IEnumerable<Doughnut> GetProducts()
        {
            using var jsonFileReader = File.OpenText(JsonFileName);
            return JsonSerializer.Deserialize<Doughnut[]>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                })!;
        }
    }

}