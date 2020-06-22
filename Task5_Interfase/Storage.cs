using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Interfase
{
    class Storage:IEntityService<BaseEntity>
    {
        private List<BaseEntity> baseEntities = new List<BaseEntity>();
        public void Add(BaseEntity ob)
        {
            baseEntities.Add(ob);
        } 
        public void Delete(BaseEntity en)
        {
            baseEntities.Remove(en);
        }
        public BaseEntity Find(int id)
        {
            return baseEntities.Find(delegate (BaseEntity entity)
            { return entity.Id == id; });
        }
        public BaseEntity[] GetAll()
        {
            BaseEntity[] bases = baseEntities.ToArray();
            return bases;
        }
    }

    public interface IEntityService<T>
    {
        T Find(int id);
        void Add(T ob);
        void Delete(T en);
        T[] GetAll();
    } 
}
