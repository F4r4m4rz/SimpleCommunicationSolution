using AibelDeelineInterface.Aibel_Deeline;
using AibelDeelineInterface.Common;
using AibelDeelineInterface.Deeline_Aibel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AibelDeelineInterface.Data
{
    public class AibelDeelineDbContext : DbContext
    {
        public AibelDeelineDbContext()
            :base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AibelDeelineDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {

        }

        public DbSet<CORelease> Releases { get; set; }
        public DbSet<DrawingRevision> Revisions { get; set; }
        public DbSet<DrawingExport> DrawingExports { get; set; }
        public DbSet<ModelUpdateRequest> UpdateRequests { get; set; }
        public DbSet<UdaMacro> UdaMacros { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
