using AibelDeelineInterface.Aibel_Deeline;
using AibelDeelineInterface.Common;
using AibelDeelineInterface.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AibelDeelineTester
{
    class Program
    {
        static void Main(string[] args)
        {
            // make user
            MakeUser();

            //make Release
            //MakeRelease();

            // Update a release
            //UpdateRelease();
        }

        private static void UpdateRelease()
        {
            using (var repos = new COReleaseRepository(new AibelDeelineDbContext()))
            {
                var release = repos.GetFull(1);
            }
        }

        private static void MakeUser()
        {
            // User1
            User user1 = new User()
            {
                Id = "ofsfabo1",
                FirstName = "Faramarz",
                LastName = "Bodaghi",
                Email_Address = "faramarz.bodaghi@aibel.com",
                Location = LocationEnum.Aibel_ASI
            };

            // User2
            User user2 = new User()
            {
                Id = "ofsfabo2",
                FirstName = "Fara",
                LastName = "Boda",
                Email_Address = "fara.boda@aibel.com",
                Location = LocationEnum.Aibel_ATH
            };

            // User3
            User user3 = new User()
            {
                Id = "ofsfabo3",
                FirstName = "SomeName",
                LastName = "SomeFamilyName",
                Email_Address = "SomeName.SomeFamilyName@deeline.com",
                Location = LocationEnum.Deeline
            };

            using (var repos = new UserRepository(new AibelDeelineDbContext()))
            {
                repos.Add(user1);
                repos.Add(user2);
                repos.Add(user3);
            }
        }

        static void MakeRelease()
        {
            // Created by
            User user = null;
            using (var repos = new UserRepository(new AibelDeelineDbContext()))
            {
                user = repos.Get("ofsfabo1");
            }

            CORelease release = new CORelease(user, LocationEnum.Aibel_ASI, PriorityEnum.Critical, "S2");
            release.ControlObjects.Add(new ControlObject("111-20-0001"));
            release.ControlObjects.Add(new ControlObject("111-20-0002"));
            release.ControlObjects.Add(new ControlObject("111-20-0003"));

            using (var repos = new COReleaseRepository(new AibelDeelineDbContext()))
            {
                repos.Add(release);
            }
        }
    }
}
