using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Entities
{
    public class Team
    {
        public int Id { get; set; }

        public short KurulusYili { get; set; }

        public string Ad { get; set; }
        public virtual IList<Player> Players { get; set; }
        public virtual IList<Sponsor> Sponsors { get; set; }
        public IList<Country> Countries { get; set; }
    }
}
