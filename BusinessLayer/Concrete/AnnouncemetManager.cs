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
    public class AnnouncemetManager : IAnnouncemetService
    {
        //constructor oluşturmadan önce Daldan miras almak gerekir.
        IAnnouncemetDal _announcemetDal;

        public AnnouncemetManager(IAnnouncemetDal announcemetDal)
        {
            _announcemetDal = announcemetDal;
        }

        public void TAdd(Announcemet t)
        {
            _announcemetDal.Insert(t);
        }

        public void TDelete(Announcemet t)
        {
            _announcemetDal.Delete(t);
        }

        public Announcemet TGetByID(int id)
        {
            return _announcemetDal.GetByID(id);
        }

        public List<Announcemet> TGetList()
        {
            return _announcemetDal.GetList();
        }

        public List<Announcemet> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Announcemet t)
        {
            _announcemetDal.Update(t);
        }
    }
}
