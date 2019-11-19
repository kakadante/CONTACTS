using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CONTACTS.Models
{
    public class Gender
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Gender")]
        public string Gendername { get; set; }
    }
}