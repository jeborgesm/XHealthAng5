using System;

namespace XHealthAng5.Models
{
    public class ExportHistory
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public int Accounts { get; set; }
        public double Balance { get; set; }
        public DateTime ExportDate { get; set; }
    }
}
