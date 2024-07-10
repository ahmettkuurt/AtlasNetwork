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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

		public void AddT(About t)
		{
			throw new NotImplementedException();
		}

		public void DeleteT(About t)
		{
			throw new NotImplementedException();
		}

		public List<About> GetAllList()
		{
			return _aboutDal.GetListAll();
		}

		public About GetTById(int id)
		{
			return _aboutDal.GetById(id);
		}


		public void UpdateT(About t)
		{
			_aboutDal.Update(t);
		}
	}
}
