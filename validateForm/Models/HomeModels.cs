using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Home.models
{
    public class User 
    {
        [Required]
        [MinLength(4)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(4)]
        public string LastName { get; set; }
        [Required]
        [RangeAttribute(0,150)]
        public int Age { get; set; }
        [Required]
        [EmailAddressAttribute]
        public string Email { get; set; }
        [RequiredAttribute]
        [DataTypeAttribute(DataType.Password)]
        [MinLengthAttribute(8)]
        public string Password { get; set; }
    }
}
