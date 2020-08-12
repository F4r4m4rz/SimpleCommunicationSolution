using AibelDeelineInterface.Deeline_Aibel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AibelDeelineInterface.Data
{
    public class DrawingExportRepository : IRepository<DrawingExport>
    {
        private readonly AibelDeelineDbContext db;

        public DrawingExportRepository(AibelDeelineDbContext db)
        {
            this.db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public void Add(DrawingExport item)
        {
            db.DrawingExports.Add(item);
        }

        public void Delete(DrawingExport item)
        {
            db.DrawingExports.Remove(item);
        }

        public DrawingExport Get(params object[] keys)
        {
            return db.DrawingExports.Find(keys);
        }

        public IEnumerable<DrawingExport> GetAll()
        {
            return db.DrawingExports.AsEnumerable();
        }

        public IEnumerable<DrawingExport> GetAll(Func<DrawingExport, bool> predicate)
        {
            return db.DrawingExports.Where(predicate).AsEnumerable();
        }

        public void Update(DrawingExport item)
        {
            db.DrawingExports.AddOrUpdate(item);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public DrawingExport GetFull(params object[] keys)
        {
            throw new NotImplementedException();
        }
    }
}
