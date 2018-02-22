using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace StudentAssignment
{
    class IntroDbContext : DbContext
    {
        public IntroDbContext() : base()  //default constructor for my class : inheriting the db context constructor
        { }
        public virtual DbSet<NameOfStudent> Name { get; set; }
        public virtual DbSet<CollegeOfStudent> College { get; set; }
        
    }
}
