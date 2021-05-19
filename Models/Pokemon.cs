using System.Collections.Generic;

namespace pokemon001.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public ICollection<Tipo> Tipos { get; set; }
    }
}