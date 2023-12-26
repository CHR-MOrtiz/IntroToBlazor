using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace IntroToBlazor.Client.Models;

public class DeveloperModel()
{
    public int? Id { get; set; } = default(int);

    [Required]
    [StringLength(50, ErrorMessage ="First Name too long(50 charcter limit")]
    public string? FirstName { get; set; }

    [Required]
    [StringLength(50, ErrorMessage = "Last Name too long(50 charcter limit")]
    public string? LastName { get; set; }

    public string? Title { get; set; }

    public string? City { get; set; }
};

