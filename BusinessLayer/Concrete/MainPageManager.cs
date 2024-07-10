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
    public class MainPageManager : IMainPageService
    {
        IMainPageDal _mainPage;

        public MainPageManager(IMainPageDal mainPage)
        {
            _mainPage = mainPage;
        }

		public void AddT(MainPage t)
		{
            _mainPage.Insert(t);
        }

		public void DeleteT(MainPage t)
		{
			_mainPage.Delete(t);
        }

		public List<MainPage> GetAllList()
		{
			return _mainPage.GetListAll();
		}

		public MainPage GetTById(int id)
		{
			return _mainPage.GetById(id);
		}

		public void UpdateT(MainPage t)
		{
			_mainPage.Update(t);
		}
	}
}
