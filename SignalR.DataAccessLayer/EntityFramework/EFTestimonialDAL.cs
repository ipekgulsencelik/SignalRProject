using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repository;
using SignalR.EntityLayer.Concrete;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EFTestimonialDAL : GenericRepository<Testimonial>, ITestimonialDAL
    {
        public EFTestimonialDAL(Context context) : base(context)
        {
        }
    }
}