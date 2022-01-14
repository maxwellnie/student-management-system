using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 学生选课系统
{
    
    public class LoginUser
    {
        public static string _userName;
        public static string _userPassword;
        public static string _userPurview;
    }
    public class teacher
    {
        public static DataRowCollection teacherInfo;
    }
}

    public class ClassShared
    {
        public static string[] userInfo = new string[2];

    }
