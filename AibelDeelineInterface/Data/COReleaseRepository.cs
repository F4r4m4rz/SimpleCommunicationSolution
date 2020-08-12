using AibelDeelineInterface.Aibel_Deeline;
using AibelDeelineInterface.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AibelDeelineInterface.Data
{
    public class COReleaseRepository : IRepository<CORelease>
    {
        private readonly AibelDeelineDbContext db;

        public COReleaseRepository(AibelDeelineDbContext db)
        {
            this.db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public void Add(CORelease item)
        {
            db.Releases.Add(item);
            db.ChangeTracker.Entries().First(a => a.Entity.Equals(item.CreatedBy)).State = System.Data.Entity.EntityState.Unchanged;
            db.SaveChanges();
        }

        public void Delete(CORelease item)
        {
            db.Releases.Remove(item);
            db.SaveChanges();
        }

        public CORelease Get(params object[] keys)
        {
            return db.Releases.Find(keys);
        }

        public CORelease GetFull(params object[] keys)
        {
            var id = (int)keys[0];
            return db.Releases.Include(a => a.CreatedBy)
                              .Include(a => a.ControlObjects)
                              .First(a => a.Id == id);
        }

        public IEnumerable<CORelease> GetAll()
        {
            return db.Releases.AsEnumerable();
        }

        public IEnumerable<CORelease> GetAll(Func<CORelease, bool> predicate)
        {
            return db.Releases.Where(predicate).AsEnumerable();
        }

        public void Update(CORelease item)
        {
            db.Releases.AddOrUpdate(item);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
