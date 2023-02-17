using Bussiness.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Entities
{
    public class Movie : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public string Language { get; set; }
        public DateTime ReleaseDate{ get; set; }
        public string Country { get; set; }
        public string Genre { get; set; }
        public string Image { get; set; }


        public List<MovieShow> MovieShows { get; set; }

    }
}
