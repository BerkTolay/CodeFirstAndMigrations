using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Entities
{
    public class Country
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public IList<Team> Teams { get; set; }
    }
}