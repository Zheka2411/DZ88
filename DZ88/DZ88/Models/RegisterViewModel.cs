
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc;

namespace RegisterValidationApp.Models
{
public class RegisterViewModel
{
[Required] public string FirstName {get;set;}
[Required] public string LastName {get;set;}

[StringLength(20)]
[RegularExpression(@"^[a-zA-Z0-9_]+$")]
[Remote(action:"VerifyUsername",controller:"Account")]
public string Username {get;set;}

[Required]
[StringLength(100)]
public string Password {get;set;}

[Required]
[StringLength(100)]
[Compare("Password")]
public string ConfirmPassword {get;set;}

[Required]
[EmailAddress]
public string Email {get;set;}

[Phone]
public string PhoneNumber {get;set;}

[Range(18,100)]
public int Age {get;set;}

[CreditCard]
public string CreditCardNumber {get;set;}

[Url]
public string Website {get;set;}

[ValidateNever]
public bool TermsOfService {get;set;}
}
}
