using System;

namespace backend.Models.Response
{
    public class listanegrarequest
    {
          public int Id { get; set; }
        public string Nome { get; set; }
        public string Motivo { get; set; }
        public DateTime? Inclusao { get; set; }
    }
}