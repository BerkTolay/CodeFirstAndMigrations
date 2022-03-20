using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class PlayerAdress
    {
        
        [ForeignKey("Player")]//one to one ilişki olduğu için PlayerAdressId identity olmamalı
        public int PlayerAdressId { get; set; }
        
        public string City { get; set; }

        public int Street { get; set; }

        public int PostCode { get; set; }

        public virtual Player Player { get; set; }
    }
}