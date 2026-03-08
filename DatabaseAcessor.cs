using Microsoft.EntityFrameworkCore;
using STUDENTS_REGISTRATION.Models;

namespace STUDENTS_REGISTRATION.Dat
{
    public class DatabaseAcessor : DbContext
    {
        public DatabaseAcessor(DbContextOptions<DatabaseAcessor> options): base(options)
        {
            
        }

        public DbSet<Students> MyStudents { get; set; }
    }
}
