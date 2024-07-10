using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;
        

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

		public void AddT(Contact t)
		{
			_contactDal.Insert(t);
		}

		public void DeleteT(Contact t)
		{
			_contactDal.Delete(t);
		}

		public List<Contact> GetAllList()
		{
			return _contactDal.GetListAll();
		}

		public Contact GetTById(int id)
		{
			return _contactDal.GetById(id);
		}

		public void UpdateT(Contact t)
		{
			_contactDal.Update(t);
		}
	}
}
