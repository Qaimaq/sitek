using System.ComponentModel.DataAnnotations;
using System.Web;

namespace SITEK.Models
{
    public class SubcscribeModel
    {
        [Required(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "email2")]
        [EmailAddress(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "ContactEmailFormat")]
        public string FromEmail { get; set; }
    }
}