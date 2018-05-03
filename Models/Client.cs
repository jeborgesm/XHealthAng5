using System.ComponentModel.DataAnnotations.Schema;

namespace XHealthAng5.Models
{
    public class Client
    {
        public enum CustomFileType { CommaDelimited, PipeDelimited }

        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ClientID { get; set; }
        public string Name { get; set; }
        public CustomFileType FileType { get; set; }
    }
}
