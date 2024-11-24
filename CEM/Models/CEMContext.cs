using System;
using Microsoft.EntityFrameworkCore;
using CEM.Models;

namespace CEM.Models
{
    public partial class CEMContext : DbContext
    {
      
            public CEMContext(DbContextOptions<CEMContext> options) : base(options) { }

            public DbSet<User> Users { get; set; }

            // Các DbSet khác
      



        

  
       
        
   
      
    }
}
