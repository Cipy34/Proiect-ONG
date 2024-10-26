using System.ComponentModel.DataAnnotations;

namespace Proiect_ONG___Backend.Models
{
    public class Raspuns
    {
        [Key]
        public int raspunsId { get; set; }
        public string mesaj { get; set; }
        public int comentariuId { get; set; }
        public Comentariu comentariu { get; set; }
        public int ongId { get; set; }
        public Ong ong {  get; set; }
    }
}
