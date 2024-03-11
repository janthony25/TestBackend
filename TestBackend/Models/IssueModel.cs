using System.ComponentModel.DataAnnotations;

namespace TestBackend.Models
{
    public class IssueModel
    {
        [Key]
        public int IssueId { get; set; }
        [Required]
        public string Problem { get; set; }
        public string? PartsNeed { get; set; }
        public string? PartsPrice { get; set; }

        public CustomerModel CustomerModel { get; set; }

    }
}
