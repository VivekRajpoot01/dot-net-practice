using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinDisconArchDemo
{
    public interface IRepo<T>
    {

        bool AddData(T Obj);
        bool UpdateData(int id, T Obj);
        bool DeleteData(int id);

        List<T> ShowAll();

        T SearchByID(int id);
    }


}
