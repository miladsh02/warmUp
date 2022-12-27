using System.ComponentModel.DataAnnotations;


public class FoodModel
{
    [Key]
    public Guid Id { get; set; } 
    public string? Name { get; set; } 
    public string? PictureAddress { get; set; }
    
}