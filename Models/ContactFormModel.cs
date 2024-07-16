using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrchardSite.Models;
public class Contact
{
    public int Id { get; set; }
    [Required]
    [Display(Name = "first name")]
    public string FirstName { get; set; }
    [Required]
    [Display(Name = "last name")]
    public string LastName { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Phone]
    [Display(Name = "phone number")]
    public string PhoneNumber { get; set; }
    [Required]
    public string Message { get; set; }
    public DateTime TimeSubmitted { get; set; }

    public Contact()
    {
        TimeSubmitted = DateTime.UtcNow;
    }

}