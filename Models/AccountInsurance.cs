namespace XHealthAng5.Models
{
    public class AccountInsurance
    {
        public int AccountInsuranceId { get; set; }
        public Account Account { get; set; }
        public Insurance Insurance { get; set; }
    }
}
