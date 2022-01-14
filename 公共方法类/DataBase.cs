using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace 学生选课系统
{
    public class DataBase
    {
         SqlConnection dataConnection = new SqlConnection();
         SqlDataAdapter dataAdapter;
         DataSet dataSet;
         SqlCommand command;
        //定义数据库连接字符串，随具体环境而定，应根据内容自行调整
        string connstr = "data source=;uid=sa;pwd=123456;database=SelectCourse";

        public DataSet GetDataFromDB(string sqlStr)
        {
            try
            {
                dataConnection.ConnectionString = connstr;
                dataConnection.Open();

                dataAdapter = new SqlDataAdapter(sqlStr, dataConnection);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet);        //填充数据集
                dataConnection.Close();           //关闭连接
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                dataConnection.Close();
            }
            if (dataSet.Tables[0].Rows.Count != 0)
            {
                return dataSet;                    //若找到相应的数据，则返回数据集
            }
            else
            {
                return null;                       //若没有找到相应的数据，返回空值
            }
        }
        public bool UpdateDB(string sqlStr)
        {
            try
            {
                dataConnection.ConnectionString = connstr;
                dataConnection.Open();
                command = new SqlCommand(sqlStr, dataConnection);
                command.ExecuteNonQuery();
                dataConnection.Close();           //关闭连接
                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}
