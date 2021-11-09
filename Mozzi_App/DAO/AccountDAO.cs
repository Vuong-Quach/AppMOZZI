using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozzi_App.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance// get set
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }//contructor

        public bool Login(string userName, string passWord)// hàm check tt đang nhập  
        {
            string query = "SELECT * FROM dbo.TK_NV WHERE Email_NV = N'" + userName + "' AND Password_NV = N'" + passWord + "' ";//câu lệnh query truyền vào 

            DataTable result = DataProvider.Instance.ExecuteQuery(query);// chạy query

            return result.Rows.Count > 0;// return true nếu kết quả tìm đc >0 =>  tìm được account đăng nhập  
        }
    }

}
