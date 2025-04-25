using FATT_DP.Models;
using Microsoft.EntityFrameworkCore;

namespace FATT_DP.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Log> Logs { get; set; }
        public DbSet<Prediction> Predictions { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionInput> TransactionInputs { get; set; }
        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<TransactionInput>()
                .HasOne(ti => ti.Transaction)  
                .WithMany(t => t.TransactionInputs)  
                .HasForeignKey(ti => ti.TransactionId);  

            
            modelBuilder.Entity<TransactionInput>()
                .HasOne(ti => ti.Prediction)  
                .WithMany()  
                .HasForeignKey(ti => ti.PredictionId);  

            
            modelBuilder.Entity<Log>()
                .HasOne(l => l.User)  
                .WithMany()  
                .HasForeignKey(l => l.UserId);  

           
        }
    }

}

