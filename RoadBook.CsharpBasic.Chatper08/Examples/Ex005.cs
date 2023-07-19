using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
    internal class Ex005
    {
        private readonly string currentDirectory = Environment.CurrentDirectory;
        private readonly string connectionStr =
            string.Format("Data Source={0},{1};" +
                "Initial Catalog ={2}; User ID={3};Password={4}", "127.0.0.1", 1433, "testdb", "sa", "asdf1212");

        public void Run()
        {
            CheckedDirectory();
            TryConnectToDataBase();

        }

        private void CheckedDirectory()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(currentDirectory + @"\data");

            if (!directoryInfo.Exists) { directoryInfo.Create(); }
        }

        private void TryConnectToDataBase()
        {
            SqlConnection connection = new SqlConnection(connectionStr);

            string fileName = string.Format(@"\data\db{0}.log", DateTime.Now.ToString("yyyyMMddHHmmss"));

            using (StreamWriter sw = new StreamWriter(currentDirectory + fileName, true))
            {
                sw.WriteLine("[{0}] 데이터베이스 연결시도....", DateTime.Now);
                connection.Open();
                sw.WriteLine("[{0}] 데이터베이스 연결 OK...", DateTime.Now);

                Model.User user = SetUser();
                string insertSQL = string.Format(" INSERT IN TO TB_USER (ID, NAME,AGE,JOB)VALUES ('{0}','{1}','{2}','{3}' )", user.userID, user.Name, user.Age, user.Job);

              
            }
        }

    }

}
