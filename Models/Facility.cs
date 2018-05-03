using System.ComponentModel.DataAnnotations.Schema;

namespace XHealthAng5.Models
{
    public class Facility
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int FacilityID { get; set; }
        public string FacilityName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}
