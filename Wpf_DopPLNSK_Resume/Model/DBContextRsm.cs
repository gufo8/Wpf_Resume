using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_DopPLNSK_Resume.Model
{
    class DBContextRsm : DbContext
    {
        public DbSet<MdSeekerResume> SeekerSet { get; set; }      
        
        public DBContextRsm()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=SeekersRSMWPF;Trusted_Connection=True;");
        }
    }
}
