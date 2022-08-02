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

        public string Add(Routing r)
        {
            try
            {
                _routingDal.Add(r);
            }
            catch (System.Exception e)
            {
                return e.Message;
            }
            return "ekleme basarili";
        }

        public List<Routing> GetAll()
        {
           return  _routingDal.GetList();
        }

        public Routing GetRouting(Routing r)
        {
           return _routingDal.Get();
        }

        public List<Routing> GetRoutingByGuide(int guideId)
        {
            return _routingDal.GetList(p => p.GuideId == guideId);
        }
    }

}
