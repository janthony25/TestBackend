using System.ComponentModel.DataAnnotations;

namespace TestBackend.Models
{
    public class tblCustomerList
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string CarModel { get; set; }
        [Required]
        public string CarMake { get; set; }
        [Required]
        public string CarRego { get; set; }

        public string Paid { get; set; }
        public string WorkStatus { get; set; }
        


        public ICollection<tblIssue> Issue { get; set; }

    }
}
