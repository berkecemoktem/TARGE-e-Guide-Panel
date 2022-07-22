using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class RoutingManager : IRoutingService
    {

        IRoutingDal _routingDal = new EfRoutingDal();
        public List<Routing> GetRoutingByGuide(int guideId)
        {
            return _routingDal.GetList(p => p.GuideId == guideId);
        }
    }

}
