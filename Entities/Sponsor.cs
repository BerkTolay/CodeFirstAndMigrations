using System.Collections.Generic;

namespace Entities
{
    public class Sponsor
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public virtual IList<Team> Teams { get; set; }
        //sponsor ile team arasında many to many ilişki olduğu için EF DB'ye SponsorTeam tablosu ekler
    }
}