using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStock.Models;

namespace BookStock.DAL
{
    public class EntityModel<T> where T: Entity, new()
    {
        private List<T> _Entities;

        public EntityModel()
        {
            if (_Entities == null)
            {
                _Entities = new List<T>();
            }

        }
        public void Add(T item)
        {
            item.Id = _Entities.Count + 1;
            _Entities.Add(item);

        }
        public void Remove(T item)
        {
            _Entities.Remove(item);

        }
        public List<T> GetAll()
        {
            return _Entities;

        }
    }
}

