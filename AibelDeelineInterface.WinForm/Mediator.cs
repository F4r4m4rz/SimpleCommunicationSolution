using AibelDeelineInterface.Common;
using AibelDeelineInterface.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AibelDeelineInterface.WinForm
{
    public static class Mediator
    {
        static Mediator()
        {
            var userid = Environment.UserName;
            using (var repos = new UserRepository(new AibelDeelineDbContext()))
            {
                CurrentUser = repos.Get(userid);
            }

            CurrentLocation = LocationEnum.Aibel_ATH;
        }

        public static User CurrentUser { get; set; }
        public static LocationEnum CurrentLocation { get; set; }
    }
}
