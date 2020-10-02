using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;//Added for validation

namespace MSF.UI.MVC.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "* Name is Required")]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Subject { get; set; }
        [Required(ErrorMessage = "* Message is Required")]
        [UIHint("MultilineText")]//Changes from single line textbox to multiline
        public string Message { get; set; }
    }
}