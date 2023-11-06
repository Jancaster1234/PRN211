using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;

namespace MeetMyLecturerWinApp
{
    public static class CurrentUser
    {
        public static User Current { get; private set; }

        public static void SetCurrentUser(User user)
        {
            Current = user;
        }

        public static void ClearCurrentUser()
        {
            Current = null;
        }
    }

}
