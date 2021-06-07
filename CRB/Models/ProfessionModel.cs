using System.ComponentModel.DataAnnotations;

namespace CRB.Models
{
    public class ProfessionModel
    {
        [Display(Name = "ItemCode")]
        public int ItemCode { get; set; }
        
        [Display(Name = "ItemValue")]
        public string ItemValue { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}