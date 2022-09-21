using BusinessLayer.Abstract;
using DAL.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void TDelete(Customer item)
        {
            _customerDal.Delete(item);
        }

        public Customer TGetByID(int id)
        {
            return _customerDal.GetByID(id);
        }

        public List<Customer> TGetByIstanbul()
        {
            return _customerDal.GetByIstanbul();
        }

        public List<Customer> TGetList()
        {
            return _customerDal.GetList();
        }

        public void TInsert(Customer item)
        {
            _customerDal.Insert(item);
        }

        public void TUpdate(Customer item)
        {
            _customerDal.Update(item);
        }
    }
}
