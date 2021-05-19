using System;
using System.Collections.Generic;
using System.Text;

namespace RPSStore.Models
{
    public class Contact
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Gender { get; set; }
        public List<Boolean> ContactModes { get; set; }
    }
}
