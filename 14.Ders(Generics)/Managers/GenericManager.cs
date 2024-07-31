using _14.Ders_Generics_.Classes;
using _14.Ders_Generics_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Ders_Generics_.Managers
{
    internal class GenericManager<T> : IGeneric<T> where T : class, ITable, new()
    {
        private readonly List<T> _list;
        public GenericManager(List<T> list)
        {

            _list = list;

        }
        public void Add(T data)
        {
            _list.Add(data);
        }

        public void Delete(T data)
        {
            _list.Remove(data);
        }

        public T GetDataById(int Id)
        {

            foreach (var data in _list)
            {
                if (data.Id == Id)
                {
                    return data;
                }
            }
            return null;
         
        }

        public IEnumerable<T> GetList()
        {
            return _list;
        }
    }
}
