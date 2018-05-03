using System.ComponentModel.DataAnnotations.Schema;

namespace XHealthAng5.Models
{
    public class Insurance
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int InsuranceID { get; set; }
        public string PlanName { get; set; }
        public string Policy { get; set; }
        public string GroupNumber { get; set; }
    }
}
