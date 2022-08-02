using Entities.Concrete;

namespace WebApi.Models
{
    public class ModelsRepository
    {
        public Guide Guide { get; set; }
        public List<Content> Contents { get; set; }
        public List<Document> Documents{ get; set; }
        public List<Routing> Routings { get; set; }
        public List<GuideKeyword> GuideKeywords{ get; set; }
        //public List<Keyword> Keywords{ get; set; }



    }
}
