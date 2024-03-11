using System.ComponentModel.DataAnnotations;

namespace TestBackend.Models
{
    public class tblIssue
    {
        [Key]
        public int IssueId { get; set; }
        [Required]
        public string Problem { get; set; }
        public string? PartsNeed { get; set; }
        public string? PartsPrice { get; set; }
        public string? Description { get; set; }

        public tblCustomerList CustomerModel { get; set; }

    }
}
