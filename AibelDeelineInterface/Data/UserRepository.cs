using AibelDeelineInterface.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AibelDeelineInterface.Data
{
    public class UserRepository : IRepository<User>
    {
        private readonly AibelDeelineDbContext db;

        public UserRepository(AibelDeelineDbContext db)
        {
            this.db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public void Add(User item)
        {
            db.Users.Add(item);
            db.SaveChanges();
        }

        public void Delete(User item)
        {
            db.Users.Remove(item);
            db.SaveChanges();
        }

        public User Get(params object[] keys)
        {
            return db.Users.Find(keys);
        }

        public IEnumerable<User> GetAll()
        {
            return db.Users.AsEnumerable();
        }

        public IEnumerable<User> GetAll(Func<User, bool> predicate)
        {
            return db.Users.Where(predicate).AsEnumerable();
        }

        public void Update(User item)
        {
            db.Users.AddOrUpdate(item);
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public User GetFull(params object[] keys)
        {
            throw new NotImplementedException();
        }
    }
}
