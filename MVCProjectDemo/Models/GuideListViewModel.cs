using Entities.ComplexTypes;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCProjectDemo.Models
{
    public class GuideListViewModel
    {
        public Content Guides { get; set; }
        public List<Content> GuideTitles { get; set; }
        public List<SelectListItem> Categories { get; set; }
        public List<SelectListItem> Languages { get; set; }

    }
}
