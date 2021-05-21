using System;
using System.Collections.Generic;
using System.Text;

namespace RPSStore.Models
{
    public class Email
    {
        public bool IsChecked { get; set; }
        public String From { get; set; }
        public String To { get; set; }
        public String Subject { get; set; }
        public String Body { get; set; }
    }
}
