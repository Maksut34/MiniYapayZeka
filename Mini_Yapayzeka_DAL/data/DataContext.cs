using Microsoft.EntityFrameworkCore;
using Mini_Yapayzeka_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Yapayzeka_DAL.data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=Maksut-OZDEMIR\SQLEXPRESS02; Database=MiniYapayZeka; Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

         public DbSet<Learning_Data> _Datas { get; set; }
    }

}
