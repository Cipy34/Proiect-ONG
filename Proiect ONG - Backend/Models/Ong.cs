using System.ComponentModel.DataAnnotations;

namespace Proiect_ONG___Backend.Models
{
    public class Ong
    {
        [Key]
        public int ongId { get; set; }
        public string denumire { get; set; }
        public string descriere { get; set; }
        public string categorie { get; set; }
        public string tara { get; set; }
        public string judet { get; set; }
        public string localitate { get; set; }
        public string adresa { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }
        public ICollection<Notificare> notificari { get; set; }
        public ICollection<Raspuns> raspunsuri { get; set; }
    }
}
