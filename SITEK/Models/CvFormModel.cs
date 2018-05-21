using System.ComponentModel.DataAnnotations;
using System.Web;

namespace SITEK.Models
{
    public class CvFormModel
    {
        [Required(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "name1")]
        public string FromName { get; set; }
        [Required(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "email2")]
        [EmailAddress(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "ContactEmailFormat")]
        public string FromEmail { get; set; }
        [Required(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "ContactMessageVal")]
        public string Message { get; set; }
        [Required(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "ContactFileVal")]
        public HttpPostedFileBase Upload { get; set; }
    }
}