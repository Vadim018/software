using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace S10
{
    internal interface IDBItemDAL<T> where T : IID
    {
        List<T> Items { get; set; }
        void Add(T item);
        T GetById(int id);
        bool Delete(T item);
        bool Update(T oldItem, T newItem);
    }
}