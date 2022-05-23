using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralKnowledge.Test.App.Models
{
    public  class AssetDetails
    {
        [Key]
        public int AssetId { get; set; }
        public string Asset { get; set; }
        public string Country { get; set; }
        public string MimeType { get; set; }

        public string FileName { get; set; }

        public string CreatedBy { get; set; }

        public string Email { get; set; }

        public string Description { get; set; }

    }
}
