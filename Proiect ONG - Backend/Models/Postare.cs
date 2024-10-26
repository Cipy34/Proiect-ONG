using System.ComponentModel.DataAnnotations;

namespace Proiect_ONG___Backend.Models
{
    public class Postare
    {
        [Key]
        public int postareId { get; set; }
        public string titlu {  get; set; }
        public string descriere { get; set; }
        public string categorie { get; set; }
        public string poza { get; set; }
        public DateTime dataPostare {  get; set; }
        public int nrAprecieri { get; set; }
        public int nrComentarii { get; set; }
        public int tipPostare { get; set; }
        public int sumaNecesaraDonatie { get; set; }
        public int sumaActualaDonatie { get; set; }
        public double procentDonatie { get; set; }
        public int nrVoluntari { get; set; }
        public DateTime dataEveniment {  get; set; }

    }
}
