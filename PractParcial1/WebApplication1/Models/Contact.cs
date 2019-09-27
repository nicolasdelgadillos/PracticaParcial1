using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{


    public enum TypeContact
    {
        telephone,
        email,
        facebook
    }
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public TypeContact Type { get; set; }
        [Required]
        [Display(Description = "Contact")]
        public string ContactValue { get; set; }
    }
}