﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterUserManager : IWriterUserService
    {
        IWriterUserDal _writerUserDal;

        public WriterUserManager(IWriterUserDal writerUserDal)
        {
            _writerUserDal = writerUserDal;
        }

        public List<WriterUser> GetListReceiverMessage(string p)
        {
            throw new NotImplementedException();
        }

        public List<WriterUser> GetListSenderMessage(string p)
        {
            throw new NotImplementedException();
        }

        public void TAdd(WriterUser t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(WriterUser t)
        {
            throw new NotImplementedException();
        }

        public List<WriterUser> TGetList()
        {
            return _writerUserDal.GetList();
        }

        public List<WriterUser> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(WriterUser t)
        {
            throw new NotImplementedException();
        }

        WriterUser IGenericService<WriterUser>.TGetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
