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
    public class ReferenceManager : IReferencesService
    {
        IReferencesDal _referencesDal;

        public ReferenceManager(IReferencesDal referencesDal)
        {
            _referencesDal = referencesDal;
        }

		public void AddT(References t)
		{
			_referencesDal.Insert(t);
		}

		public void DeleteT(References t)
		{
			_referencesDal.Delete(t);
		}

		public List<References> GetAllList()
		{
			return _referencesDal.GetListAll();
		}

		public References GetTById(int id)
		{
			return _referencesDal.GetById(id);
		}

		public void UpdateT(References t)
		{
			_referencesDal.Update(t);
		}
	}
}
