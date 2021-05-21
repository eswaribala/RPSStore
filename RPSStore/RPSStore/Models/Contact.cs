using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;


namespace RPSStore.Models
{
    public class Contact
    {
        private string _firstName;
        [Display(Name = "First name")]
        [Required(ErrorMessage = "First Name cannot be empty!")]
        [RegularExpression(@"^[A-Za-z]{5,25}$", ErrorMessage = "First Name minimum 5 required")]
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
            }
        }
        [Required(ErrorMessage = "Last Name cannot be empty!")]
        [RegularExpression(@"^[A-Za-z]{5,25}$", ErrorMessage = "Last Name minimum 5 required")]

        private string _lastName;
        [Display(Name = "Last Name")]
        [Required]
        [StringLength(20)]
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
              
            }
        }


        private string _email;
        [Display(Name = "Email")]
        [Required]
      
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
              
            }
        }



        [Required]
        public String Gender { get; set; }
        [Required]
        public List<Boolean> ContactModes { get; set; }

        

   
        
    }
}
