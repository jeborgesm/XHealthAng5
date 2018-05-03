using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace XHealthAng5.Models
{
    public class Account
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int AccountID { get; set; }
        public Client Client { get; set; }
        public string AccountNumber { get; set; }
        public double Balance { get; set; }
        public Facility Facility { get; set; }
        public DateTime AdmitDate { get; set; }
        public DateTime DischargeDate { get; set; }
        public Patient Patient { get; set; }
    }
}
