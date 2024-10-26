namespace Proiect_ONG___Backend.Models.DTOs
{
    public class PostareDTO
    {
        public string titlu {  get; set; }
        public string descriere { get; set; }
        public string categorie { get; set; }
        public string poza {  get; set; }
        public DateTime dataPostare { get; set; }
        public int nrAprecieri { get; set; }
        public int nrComentarii { get; set; }
        public string tipPostare {  get; set; }
        public string? sumaNecesaraDonatie { get; set; }
        public string? sumaActualaDonatie { get; set; }
        public double? procentDonatie {  get; set; }
        public int? nrVoluntariNecesari { get; set; }
        public int? nrVoluntariActuali {  get; set; }
        public DateTime? dataEveniment { get; set; }
        public int ongId { get; set; }

    }
}
