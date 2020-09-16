using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VideoForU.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; } 

        //Referencing to the Id of MembershipType table Id col , Datatype of both have to same,
        //otherwise EF will create another col in Database
        [Display(Name = "Date Of Birth")]
        public DateTime Birthday { get; set; }
    }
}