using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
   public interface IGenericDal<T> where T: class
    {
        List<T> GetList();
        void Insert(T item);
        void Delete(T item);
        void Update(T item);
        T GetByID(int id);
    }
}
