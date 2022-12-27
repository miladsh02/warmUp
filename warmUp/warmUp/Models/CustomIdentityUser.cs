using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;


public class CustomIdentityUser:IdentityUser
{

    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public Guid StudentId { get; set; } 


}