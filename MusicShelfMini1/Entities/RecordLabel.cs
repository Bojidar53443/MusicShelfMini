using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShelfMini1.Entities
{
    public class RecordLabel
    {
       
        public int Id { get; set; }
        
        public string Name { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;

        public int FoundedYear { get; set; }

        public ICollection<Album> Albums { get; set; } = new List<Album>();
    }
}
