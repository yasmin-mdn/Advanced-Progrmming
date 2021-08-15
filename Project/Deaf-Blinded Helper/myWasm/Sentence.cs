using System;
using System.ComponentModel.DataAnnotations;
namespace myWasm
{
public class Starship
{
    [Required]
    [RegularExpression(@"^[a-zA-Z]+[ a-zA-Z-_]*$", ErrorMessage = "Invalid Sentence! Use Characters only")]
    public string Sentence { get; set; }
}
}
