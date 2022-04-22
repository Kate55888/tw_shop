using Shop.BusinessLogic.Interfaces;

namespace Shop.BusinessLogic
{
    public class BussinesLogic
    {
        public ISession GetSessionBL()
        {
            return new SessionBL();
        }
    }
}
