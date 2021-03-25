using System.ComponentModel.DataAnnotations;

public class Person
{
    public int Id{get; set;}

    [Required(ErrorMessage="We need FirstName")]
    [Display(Name = "Brand Name")]
    public string BrandName{get; set;}

    [Required(ErrorMessage="We need LastName")]
    [Display(Name = "Price")]

    public string Price{get; set;}

    public string Feature{get; set;}

    
    

}