
using Microsoft.EntityFrameworkCore;
using StudentServiceModel.Model;
using System;



namespace StudentServiceModel
{
    public class StudentSeriviceDbContext :DbContext
    {
        public StudentSeriviceDbContext(DbContextOptions<StudentSeriviceDbContext> options) : base(options) 
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
    }
}
