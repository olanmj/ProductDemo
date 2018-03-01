using System.ComponentModel.DataAnnotations;

namespace ProductDemo.Models
{
    public class Company
    {
        public int CompanyID { get; set; }

        [Display(Name="Supplier")]
        public string Name { get; set; }

        [Display(Name = "Location")]
        public string City { get; set; }
    }
}