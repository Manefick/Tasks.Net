using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Interfase
{
    abstract class BaseEntity
    {
        internal int Id { get; set; }
        internal string Name { get; set; }
        internal int Price { get; set; }

        public BaseEntity() { }
        public BaseEntity(int id, string name, int price)
        {
            Id = id;
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Поле не может быть пустым");
            Name = name;
            if (price < 0)
                throw new ArgumentException("Цена не может быть меньше 0");
            Price = price;
        }
        public override string ToString()
        {
            return $"Id:{Id}, Name: {Name}, Price:{Price}";
        }
    }


}
