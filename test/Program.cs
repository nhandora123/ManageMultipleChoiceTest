using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    static class Program
    {
        ///Main
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DangNhap());
        }
        public static Student student = new Student();
        public static Teacher teacher = new Teacher();
        public class User
        {
            private string MSUser;
            private string Password;
            private string Name;

            public string MSUser1 { get => MSUser; set => MSUser = value; }
            public string Password1 { get => Password; set => Password = value; }
            public string Name1 { get => Name; set => Name = value; }

            public User()
            {

            }
            public User(string p_MSUser, string P_Password, string p_Name)
            {
                this.MSUser1 = p_MSUser;
                this.Password1 = P_Password;
                this.Name1 = p_Name;
            }
        }

        public class Student : User
        {
            private string Lop;
            public string Lop1 { get => Lop; set => Lop = value; }

            public Student()
            {

            }
            public Student(string p_MSUser, string P_Password, string p_Name, string p_Lop) : base(p_MSUser, P_Password, p_Name)
            {
                this.Lop1 = p_Lop;
            }

        }

        public class Teacher : User
        {
            public Teacher()
            {

            }
            public Teacher(string p_MSUser, string P_Password, string p_Name) : base(p_MSUser, P_Password, p_Name)
            {
            }
        }
    }
}
