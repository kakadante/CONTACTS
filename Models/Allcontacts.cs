using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CONTACTS.Models
{
    public class Allcontacts
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("NAME")]
        public string Name { get; set; }

        [DisplayName("PHONE NUMBER")]
        public string Phone_Number { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }


        public Gender Gender { get; set; }
        public int GenderId { get; set; }
    }
}