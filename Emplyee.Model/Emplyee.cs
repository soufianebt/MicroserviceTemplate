namespace Emplyee.Model
{
    public class Emplyee
    {
        public Guid id { get; set; } 
        public string? ID_adherent { get; set; }
        public string? newImmatriculatedId { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? immatriculationNumber { get; set; }
        public string? cin { get; set; }
        public string? passportNumber { get; set; }
        public string? residenceNumber { get; set; }
        public DateTime creationDate { get; set; }
        public string? demandMode { get; set; }
        public string? affiliateName { get; set; }
        public string? affiliateNumber { get; set; }
        public string? demandState { get; set; }

    }
}
