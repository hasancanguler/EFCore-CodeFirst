using EFCoreDAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace EFCoreDAL
{
    public partial class TDContext : DbContext
    {
        public virtual DbSet<TDTask> TDTask { get; set; }
        public virtual DbSet<TDSteep> TDSteep { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),options => options.EnableRetryOnFailure());
        }


        

    }   
    

}
