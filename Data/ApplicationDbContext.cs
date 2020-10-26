using System;
using System.Collections.Generic;
using System.Text;
using CFClientList.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CFClientList.Data
{
    public class ApplicationDbContext : IdentityDbContext<CFUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
            //#region ContactSeed
            //modelBuilder.Entity<Contact>().HasData(
            //    new Contact() { FirstName = "James", LastName = "Howlett", Email = "", Phone = "", Address1 = "", Address2 = "", City = "", State = "", ZipCode = "", Status = true, Verified = true, DateAdded = DateTimeOffset.Now },
            //    new Contact() { FirstName = "Erik", LastName = "Lehnsherr", Email = "", Phone = "", Address1 = "", Address2 = "", City = "", State = "", ZipCode = "", Status = true, Verified = true, DateAdded = DateTimeOffset.Now },
            //    new Contact() { FirstName = "Steve", LastName = "Rogers", Email = "", Phone = "", Address1 = "", Address2 = "", City = "", State = "", ZipCode = "", Status = true, Verified = true, DateAdded = DateTimeOffset.Now },
            //    new Contact() { FirstName = "Carol", LastName = "Danvers", Email = "", Phone = "", Address1 = "", Address2 = "", City = "", State = "", ZipCode = "", Status = true, Verified = true, DateAdded = DateTimeOffset.Now },
            //    new Contact() { FirstName = "", LastName = "", Email = "", Phone = "", Address1 = "", Address2 = "", City = "", State = "", ZipCode = "", Status = true, Verified = true, DateAdded = DateTimeOffset.Now },
            //    new Contact() { FirstName = "", LastName = "", Email = "", Phone = "", Address1 = "", Address2 = "", City = "", State = "", ZipCode = "", Status = true, Verified = true, DateAdded = DateTimeOffset.Now },
            //    new Contact() { FirstName = "", LastName = "", Email = "", Phone = "", Address1 = "", Address2 = "", City = "", State = "", ZipCode = "", Status = true, Verified = true, DateAdded = DateTimeOffset.Now },
            //    new Contact() { FirstName = "", LastName = "", Email = "", Phone = "", Address1 = "", Address2 = "", City = "", State = "", ZipCode = "", Status = true, Verified = true, DateAdded = DateTimeOffset.Now },
            //    new Contact() { FirstName = "", LastName = "", Email = "", Phone = "", Address1 = "", Address2 = "", City = "", State = "", ZipCode = "", Status = true, Verified = true, DateAdded = DateTimeOffset.Now },
            //    new Contact() { FirstName = "", LastName = "", Email = "", Phone = "", Address1 = "", Address2 = "", City = "", State = "", ZipCode = "", Status = true, Verified = true, DateAdded = DateTimeOffset.Now },
            //    new Contact() { FirstName = "", LastName = "", Email = "", Phone = "", Address1 = "", Address2 = "", City = "", State = "", ZipCode = "", Status = true, Verified = true, DateAdded = DateTimeOffset.Now },
            //    new Contact() { FirstName = "", LastName = "", Email = "", Phone = "", Address1 = "", Address2 = "", City = "", State = "", ZipCode = "", Status = true, Verified = true, DateAdded = DateTimeOffset.Now },
            //    new Contact() { FirstName = "", LastName = "", Email = "", Phone = "", Address1 = "", Address2 = "", City = "", State = "", ZipCode = "", Status = true, Verified = true, DateAdded = DateTimeOffset.Now },
            //    new Contact() { FirstName = "", LastName = "", Email = "", Phone = "", Address1 = "", Address2 = "", City = "", State = "", ZipCode = "", Status = true, Verified = true, DateAdded = DateTimeOffset.Now },
            //    new Contact() { FirstName = "", LastName = "", Email = "", Phone = "", Address1 = "", Address2 = "", City = "", State = "", ZipCode = "", Status = true, Verified = true, DateAdded = DateTimeOffset.Now },
            //    new Contact() { FirstName = "", LastName = "", Email = "", Phone = "", Address1 = "", Address2 = "", City = "", State = "", ZipCode = "", Status = true, Verified = true, DateAdded = DateTimeOffset.Now },
            //    new Contact() { FirstName = "", LastName = "", Email = "", Phone = "", Address1 = "", Address2 = "", City = "", State = "", ZipCode = "", Status = true, Verified = true, DateAdded = DateTimeOffset.Now },
            //    new Contact() { FirstName = "", LastName = "", Email = "", Phone = "", Address1 = "", Address2 = "", City = "", State = "", ZipCode = "", Status = true, Verified = true, DateAdded = DateTimeOffset.Now },
            //    new Contact() { FirstName = "", LastName = "", Email = "", Phone = "", Address1 = "", Address2 = "", City = "", State = "", ZipCode = "", Status = true, Verified = true, DateAdded = DateTimeOffset.Now },
            //    new Contact() { FirstName = "", LastName = "", Email = "", Phone = "", Address1 = "", Address2 = "", City = "", State = "", ZipCode = "", Status = true, Verified = true, DateAdded = DateTimeOffset.Now });

            //#endregion

        //}
    }
}
