using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using RoadBook.CsharpBasic.Chapter10.Model;

namespace RoadBook.CsharpBasic.Chapter10.Manager
{
    public interface IDatabaseManager
    {
        void Open(DatabaseInfo dbInfo);
        DataTable Select(string sql);
        int Insert(string sql);
        int Update(string sql); 
        int Delete(string sql);
        void Close();
    }
}
