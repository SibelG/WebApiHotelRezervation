﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;
        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void TDelete(Contact t)
        {
            throw new NotImplementedException();
        }

        public Contact TGetById(int id)
        {
            return _contactDal.TGetById(id);
        }

        public int TGetContactCount()
        {
            return _contactDal.GetContactCount();
        }

        public List<Contact> TGetList()
        {
            return _contactDal.GetList();
        }

        public void TInsert(Contact t)
        {
            _contactDal.Insert(t);
        }

        public void TUpdate(Contact t)
        {
            throw new NotImplementedException();
        }
    }
}
