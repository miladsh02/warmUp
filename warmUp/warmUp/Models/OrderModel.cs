using System.ComponentModel.DataAnnotations;


public class OrderModel
{
    [Key]
    public Guid Id { get; set; }
    public CustomIdentityUser? Customer { get; set; } 
    public FoodProvidedModel? FoodProvided { get; set; } 

}