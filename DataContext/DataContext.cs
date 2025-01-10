
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Student_List.Models;

namespace Student_List.DataContext
{
    // This class will act as a bridge from our C# Application to our Database.
    public class DataContext : DbContext
    {
        
        // DbContextOptions will configure the database connection and other settings
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        // We are setting a table in our database named students and it is of our StudentModel Type
        DbSet<StudentModel> Students {get; set;}


    }
}