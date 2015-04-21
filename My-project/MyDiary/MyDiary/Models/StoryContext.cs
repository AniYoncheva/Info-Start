using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyDiary.Models
{
    public class StoryContext : DbContext
    {
        public DbSet<Story> Stories { get; set; }
    }
}