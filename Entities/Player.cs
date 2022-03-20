using System;

namespace Entities
{
    public class Player
    {
        public int Id { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public DateTime DogumTarihi { get; set; }

        public int? Team_Id { get; set; }

        public virtual PlayerAdress Adress { get; set; }

        public virtual Team Team { get; set; }
    }
}