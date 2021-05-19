using System.Collections.Generic;


namespace pokemon001.Models
{
    public class Region
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public ICollection<Pueblo> Pueblos { get; set; }
    }
}