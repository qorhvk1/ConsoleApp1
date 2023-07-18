using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter09.Examples
{
    internal class EX021
    {
        public void Run()
        {
            using (UsersDataContext context = new UsersDataContext ())
            {
                var query = context.tb_user.Select(u => u);

                foreach (tb_user item in query)
                {
                    Console.WriteLine(item.NAME);
                }
            }
        }
    }
}
