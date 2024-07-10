using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ServicesManager : IServicesService
    {
        IServicesDal _servicesDal;

        public ServicesManager(IServicesDal servicesDal)
        {
            _servicesDal = servicesDal;
        }

		public void AddT(Services t)
		{
			_servicesDal.Insert(t);
		}

		public void DeleteT(Services t)
		{
			_servicesDal.Delete(t);	
		}

		public List<Services> GetAllList()
		{
			return _servicesDal.GetListAll();
		}

		public Services GetTById(int id)
		{
			return _servicesDal.GetById(id);
		}

		public void UpdateT(Services t)
		{
			_servicesDal.Update(t);
		}
	}
}
