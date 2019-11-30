using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestTaskServer.Models
{
    public class Bid
    {
        public int BidId { get; set; }
        public DateTime BidDate { get; set; }
        [Required]
        public string BidNumber { get; set; }
        [Required]
        public string OrganizationName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string UserPosition { get; set; }
        [Required]
        public string Email { get; set; }

    }
}