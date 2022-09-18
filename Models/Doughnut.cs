using System.ComponentModel.DataAnnotations;

namespace RazorPagesDoughnuts.Models;

public class Doughnut {
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }
    public DoughnutSize Size { get; set; }
    public bool HasGlaze { get; set; }

    [Range(0.01, 9999.99)]
    public decimal Price { get; set; }
}

public enum DoughnutSize { Regular, Super }
