using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace kelimeCalisma.Models.Siniflar
{
    public class context:DbContext
    {
        public DbSet<bilgiler> bilgilers { get; set; }
    }
}