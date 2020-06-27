using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWeb.Domain.Entities
{
    public class Movie : BaseEntity
    {
        public string Name { get; set; }
        public string Image { get; set; }
    }
}
