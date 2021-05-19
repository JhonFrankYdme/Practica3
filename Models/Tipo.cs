using System.Collections.Generic;

namespace pokemon001.Models
{
    public class Tipo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public ICollection<Pokemon> Pokemones { get; set; }
    }
}