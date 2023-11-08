using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repository;
using SignalR.EntityLayer.Concrete;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EFSocialMediaDAL : GenericRepository<SocialMedia>, ISocialMediaDAL
    {
        public EFSocialMediaDAL(Context context) : base(context)
        {
        }
    }
}