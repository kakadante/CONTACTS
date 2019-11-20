using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CONTACTS.Models
{
    public class AllGender
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("GENDER")]
        public string Gendername { get; set; }
    }
}