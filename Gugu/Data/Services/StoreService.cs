using Gugu.Data.Base;
using Gugu.Models;



namespace Gugu.Data.Services
{
    public class StoreService : EntityBaseRepository<Store>, IStoreService
    {
        public StoreService(AppDbContext context) : base(context)
        {
        }
    }
}
