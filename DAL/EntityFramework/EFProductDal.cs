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
    public class EFProductDal : GenericRepository<Product>, IProductDal
    {
        public void ChangeStatusToFalse(int id)
        {
            //generic yapı dışındaki methodları kullanacağız.
        }

        
    }
}
