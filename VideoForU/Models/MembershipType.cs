﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoForU.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public short MemberShipType { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
    }
}