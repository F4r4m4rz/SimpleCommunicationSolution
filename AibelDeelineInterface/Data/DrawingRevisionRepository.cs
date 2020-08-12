using AibelDeelineInterface.Aibel_Deeline;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AibelDeelineInterface.Data
{
    public class DrawingRevisionRepository : IRepository<DrawingRevision>
    {
        private readonly AibelDeelineDbContext db;

        public DrawingRevisionRepository(AibelDeelineDbContext db)
        {
            this.db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public void Add(DrawingRevision item)
        {
            db.Revisions.Add(item);
            db.SaveChanges();
        }

        public void Delete(DrawingRevision item)
        {
            db.Revisions.Remove(item);
            db.SaveChanges();
        }

        public DrawingRevision Get(params object[] keys)
        {
            return db.Revisions.Find(keys);
        }

        public IEnumerable<DrawingRevision> GetAll()
        {
            return db.Revisions.AsEnumerable();
        }

        public IEnumerable<DrawingRevision> GetAll(Func<DrawingRevision, bool> predicate)
        {
            return db.Revisions.Where(predicate).AsEnumerable();
        }

        public void Update(DrawingRevision item)
        {
            db.Revisions.AddOrUpdate(item);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public DrawingRevision GetFull(params object[] keys)
        {
            throw new NotImplementedException();
        }
    }
}
