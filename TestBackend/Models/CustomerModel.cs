namespace TestBackend.Models
{
    public class CustomerModel
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public string CarModel { get; set; }
        public string CarMake { get; set; }
        public string CarRego { get; set; }

        public IssueModel IssueModel { get; set; }  

    }
}
