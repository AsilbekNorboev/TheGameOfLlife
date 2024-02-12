using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TheGameOfLife.Models
{
    public class AppUser : IdentityUser
    {
        [Display(Name = "First Name")]
        [Required]
        public String FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        [Display(Name = "User Name:")]
        public String FullName
        {
            get { return FirstName + " " + LastName; }
        }

        [Phone]
        [Display(Name = "Phone Number")]
        public string? PhoneNumber { get; set; }

        public DateTime Birthday { get; set; }

        public String? Street { get; set; }

        public String? City { get; set; }


        [RegularExpression(@"^[0-9]{5}(?:-[0-9]{4})?$", ErrorMessage = "Invalid zip Code")]
        public String? ZipCode { get; set; }

        public Int32 PopcornPoints { get; set; } = 0;

        public DateTime DefaultTimeProperty { get; set; } = new DateTime(2023, 11, 25, 12, 0, 0);

        ////FOR EMPLOYEE:
        ////Navigation Props
        //public List<Review> Reviews { get; set; }

        //public List<Transaction> Transactions { get; set; }

        //public AppUser()
        //{
        //    if (Transactions == null)
        //    {
        //        Transactions = new List<Transaction>();
        //    }
        //    if (Reviews == null)
        //    {
        //        Reviews = new List<Review>();
        //    }
        //}
    }

}
