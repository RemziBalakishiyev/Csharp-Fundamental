using _14.Ders_Generics_.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Ders_Generics_.Interfaces
{
    internal interface IGeneric<T>
    {
        void Add(T data);
        void Delete(T data);
        IEnumerable<T> GetList();
        //T GetDataById(int Id);
    }
}
