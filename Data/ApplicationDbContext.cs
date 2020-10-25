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

        DbSet<Contact> Contacts { get; set; }
    }
}
