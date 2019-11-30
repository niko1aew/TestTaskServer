using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Common;
namespace TestTaskServer.Models
{
    public class BidContext : DbContext
    {
        public DbSet<Bid> Bids { get; set; }
    }
}