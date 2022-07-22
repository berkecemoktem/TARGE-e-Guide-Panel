using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IRoutingService
    {
        public List<Routing> GetRoutingByGuide(int guideId);
    }

}
