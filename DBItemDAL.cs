using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace S10
{
    class DBItemDAL<T> : IDBItemDAL<T> where T : IID
    {
        int counter = 1;
        public List<T> Items { get; set; }
        public DBItemDAL()
        {
            Items = new List<T>();
        }
        public void Add(T item)
        {
            item.Id = counter++;
            Items.Add(item);
        }
        public T GetById(int id)
        {
            T result = default(T);
            foreach (T item in Items)
            {
                if (item.Id == id)
                {
                    result = item;
                    break;
                }
            }
            return result;
        }
        public bool Delete(T item)
        {
            Items.Remove(item);
            return true;
        }
        public bool Update(T oldItem, T newItem)
        {
            int index = Items.IndexOf(oldItem);
            if (index >= 0)
            {
                Items[index] = newItem;
                return true;
            }
            return false;
        }
    }
}