﻿using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Concrete;

namespace SignalR.BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDAL _aboutDAL;

        public AboutManager(IAboutDAL aboutDAL)
        {
            _aboutDAL = aboutDAL;
        }

        public void TAdd(About entity)
        {
            _aboutDAL.Add(entity);
        }

        public void TDelete(About entity)
        {
            _aboutDAL.Delete(entity);
        }

        public About TGetByID(int id)
        {
            return _aboutDAL.GetByID(id);
        }

        public List<About> TGetListAll()
        {
            return _aboutDAL.GetListAll();
        }

        public void TUpdate(About entity)
        {
            _aboutDAL.Update(entity);
        }
    }
}