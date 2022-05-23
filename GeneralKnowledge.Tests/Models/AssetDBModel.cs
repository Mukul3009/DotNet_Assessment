using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralKnowledge.Test.App.Models
{
    public class AssetDBModel : DbContext
    {
        public DbSet<AssetDetails> AssetDetails { get; set; }
    }
}
