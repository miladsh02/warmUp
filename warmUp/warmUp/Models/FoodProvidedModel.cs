using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


public class FoodProvidedModel
{
    [Key]
    public Guid Id { get; set; } 
    public decimal Price { get; set;}
    public int Capacity { get; set; } 
    public FoodStatus FoodStatus { get; set; }
    public DateTimeOffset FoodServingDay { get; set; }
    public FoodModel? Food { get; set; }
}