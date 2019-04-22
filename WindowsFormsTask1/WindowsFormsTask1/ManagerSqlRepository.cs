using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace WindowsFormsTask1
{
    class ManagerSqlRepository:IRepository<Manager>
    {
        private DataContext db;

        public ManagerSqlRepository(DataContext db)
        {
            this.db = db;
        }

        public IEnumerable<Manager> GetList()
        {
            return db.GetTable<Manager>();
        }

        public Manager GetItem(int id)
        {
            foreach (var m in db.GetTable<Manager>())
                if (m.id == id)
                    return m;
            return null;
        }

        public void Add(Manager mng)
        {
            db.GetTable<Manager>().InsertOnSubmit(mng);
            db.SubmitChanges();
        }

       

        public void Delete(int id)
        {
            foreach (var m in db.GetTable<Manager>())
                if (m.id == id)
                {
                    db.GetTable<Manager>().DeleteOnSubmit(m);
                    db.SubmitChanges();
                }
        }

       

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

       public void Save()
        {
            db.SubmitChanges();
        }
    }
}
