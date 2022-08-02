using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;


namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RepositoryController : Controller
    {
        GuidesController _guidesController;
        ContentsController _contentsController;
        DocumentsController _documentsController;
        RoutingsController _routingController;
        GuidesKeywordController _guideKeywordController;
        KeywordsController _keywordsController;

       public RepositoryController(GuidesController guidesController, ContentsController contentsController,
                                     DocumentsController documentsController, RoutingsController routingController,
                                         KeywordsController keywordsController, GuidesKeywordController guideKeywordController)
        {
            this._guidesController = guidesController;
            this._contentsController = contentsController;
            this._documentsController = documentsController;
            this._routingController = routingController;
            this._keywordsController = keywordsController;
            this._guideKeywordController = guideKeywordController;
        }

        //Bütün olarak gelen JSON verilerini karşılayıp db'ye kaydeden method.
        [HttpPost]
        [Route("/api/repocontroller/add")]
        public IActionResult Add([FromBody] ModelsRepository data)
        {
            //guide ekleme.

            var guide_result = _guidesController.AddedGuide(data.Guide);

            //content ekleme.
            foreach (Content c in data.Contents)
            {
                c.GuideId = guide_result.Data.GuideId;
                _contentsController.Add(c);
            }
            //document ekleme.
            foreach (Document d in data.Documents)
            {
                d.GuideId = guide_result.Data.GuideId;
                _documentsController.Add(d);
            }
            //routing ekleme.
            foreach (Routing r in data.Routings)
            {
                r.GuideId = guide_result.Data.GuideId;
                _routingController.Add(r);
            }

            /*keyword ekleme.
            foreach (Keyword k in data.Keywords)
            {
                _keywordsController.Add(k);
            }*/

            //guide keyword ekleme.
            foreach (GuideKeyword gk in data.GuideKeywords)
            {
                _guideKeywordController.Add(gk);
            }
            return Ok(guide_result);
        }


        //Entity'leri ayrı ayrı kaydedebilmek için test methodları;

        //Document ekleme için test methodu. Yukarıdaki methoda entegre edilecek.
        [HttpPost]
        [Route("/api/repocontroller/adddocument")]
        public IActionResult AddDocument([FromBody] ModelsRepository data)
        {
            var guide_result = _guidesController.AddedGuide(data.Guide);
            //document ekleme.
            foreach (Document d in data.Documents)
            {
                d.GuideId = guide_result.Data.GuideId;
                _documentsController.Add(d);
            }
            return Ok(guide_result);
        }

        //Routing ekleme için test methodu. Yukarıdaki methoda entegre edilecek.
        [HttpPost]
        [Route("/api/repocontroller/addrouting")]
        public IActionResult AddRouting([FromBody] ModelsRepository data)
        {
            //var guide_result = _guidesController.AddedGuide(data.Guide);
            //routing ekleme.
            foreach (Routing r in data.Routings)
            {
                r.GuideId = 1065;
                _routingController.Add(r);
            }
            return Ok();
        }

        //Keyword ekleme için test methodu. Yukarıdaki methoda entegre edilecek.
        [HttpPost]
        [Route("/api/repocontroller/addkeyword")]
        public IActionResult AddKeyword([FromBody] List<Keyword> keyword)
        {
            //keyword ekleme.
            foreach (Keyword k in keyword)
            { 
                _keywordsController.Add(k);
            }
            return Ok();
        }

        //GuideKeyword ekleme için test methodu. Yukarıdaki methoda entegre edilecek.
        [HttpPost]
        [Route("/api/repocontroller/addguidekeyword")]
        public IActionResult AddGuideKeyword([FromBody] List<GuideKeyword> GuideKeywords)
        {
            //guide keyword ekleme.
            foreach (GuideKeyword gk in GuideKeywords)
            {
                _guideKeywordController.Add(gk);
            }
            return Ok();
        }

    }
}
