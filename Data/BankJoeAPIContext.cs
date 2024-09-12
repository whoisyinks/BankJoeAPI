using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BankJoeAPI.Model;

namespace BankJoeAPI.Data
{
    public class BankJoeAPIContext : DbContext
    {
        public BankJoeAPIContext (DbContextOptions<BankJoeAPIContext> options)
            : base(options)
        {
        }

        public DbSet<BankJoeAPI.Model.Country> Country { get; set; } = default!;
    }
}
