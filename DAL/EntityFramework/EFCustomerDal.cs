using DAL.Abstract;
using DAL.Concrete;
using DAL.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFramework
{
    public class EFCustomerDal : GenericRepository<Customer>, ICustomerDal
    {
        public List<Customer> GetByIstanbul()
        {
            Context c = new Context();
            return c.Customers.Where(x => x.CustomerCity == "istanbul").ToList();
        }
    }
}
