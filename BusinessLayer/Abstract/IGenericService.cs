using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        List<T> TGetList();
        void TInsert(T item);
        void TDelete(T item);
        void TUpdate(T item);
        T TGetByID(int id);
    }
}
