﻿using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repository;
using SignalR.EntityLayer.Concrete;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EFFeatureDAL : GenericRepository<Feature>, IFeatureDAL
    {
        public EFFeatureDAL(Context context) : base(context)
        {
        }
    }
}