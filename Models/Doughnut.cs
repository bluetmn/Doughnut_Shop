using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace RazorPagesDoughnuts.Models;

public class Doughnut {
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [Required]
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("size")]
    public DoughnutSize Size { get; set; }

    [JsonPropertyName("glazed")]
    public bool HasGlaze { get; set; }

    [Range(0.01, 9999.99)]
    [JsonPropertyName("price")]
    public decimal Price { get; set; }

    public override string ToString() => JsonSerializer.Serialize<Doughnut>(this);
}

public enum DoughnutSize { Regular, Super }
