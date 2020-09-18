﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VideoForU.Models;

namespace VideoForU.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter Customer's Name")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }


        public byte MembershipTypeId { get; set; }

        //Referencing to the Id of MembershipType table Id col , Datatype of both have to same,
        //otherwise EF will create another col in Database
        public DateTime Birthday { get; set; }
    }
}