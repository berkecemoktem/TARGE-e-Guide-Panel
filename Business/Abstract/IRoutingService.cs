using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IRoutingService
    {
        public List<Routing> GetRoutingByGuide(int guideId);
        public Routing GetRouting(Routing r);
        public List<Routing> GetAll();
        public string Add(Routing r);
    }

}
