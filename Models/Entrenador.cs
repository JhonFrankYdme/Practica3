using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pokemon001.Models


{


public class Entrenador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Foto { get; set; }
        public Pueblo Pueblo { get; set; }


        public int PuebloId { get; set; }
        

[NotMapped]
    public String Respuesta { get; set; }



    }
}