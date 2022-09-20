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


        // JsonSerializerOptions options = new JsonSerializerOptions();
        // JsonConverter enumconverter = new JsonStringEnumConverter();
        // options.Converters.Add(enumconverter);


        public IEnumerable<Doughnut> GetDoughnuts()
        {
            var serializeoptions = new JsonSerializerOptions() {
            PropertyNameCaseInsensitive = true,
            Converters = {
                new JsonStringEnumConverter()
            }
        };
            using var jsonFileReader = File.OpenText(JsonFileName);
            return JsonSerializer.Deserialize<Doughnut[]>(jsonFileReader.ReadToEnd(), serializeoptions)!;
        }
    }

}