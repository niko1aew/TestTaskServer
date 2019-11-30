using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestTaskServer.Models
{
    public class DBInitializer : CreateDatabaseIfNotExists<BidContext>
    {
        protected override void Seed(BidContext context)
        {
            context.Bids.Add(new Bid() {BidDate=DateTime.Now.Date, BidNumber="121", UserName = "Nikolaev V.V.", Email = "valetmail@gmail.com", OrganizationName = "Freelance", UserPosition = "Programmer" });
            context.Bids.Add(new Bid() { BidDate = DateTime.Now.Date, BidNumber = "131", UserName = "Ivanov V.A.", Email = "ivanov@gmail.com", OrganizationName = "Google", UserPosition = "Programmer" });
            context.Bids.Add(new Bid() { BidDate = DateTime.Now.Date, BidNumber = "161", UserName = "Petrov F.S.", Email = "petrov@mail.ru", OrganizationName = "Mail.RU", UserPosition = "Director" });
            base.Seed(context);
        }
    }
}