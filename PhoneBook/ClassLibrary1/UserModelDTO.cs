using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersModels
{
    public class UserModelDTO
    {
        public int Id { get; set; }
        //Required attribute is used to make sure that the field is not empty or null
        //and it is used to validate the data at the client side, not at the server side DB
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your email")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Please enter a valid email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Please enter valid phone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please enter your facebook name")]
        public string Facebook { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }
    }
}
