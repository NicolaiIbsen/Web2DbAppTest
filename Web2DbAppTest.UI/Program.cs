using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web2DbAppTest.DataAccess;
using Web2DbAppTest.Entities;
using Web2DbAppTest.Services;

namespace Web2DbAppTest.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            MockDataProvider dataProvider = new MockDataProvider();
            DataRepository repo = new DataRepository();
            repo.Executor.Execute("dbo.MyProcedure1", repo.SqlCreater(dataProvider.GetPeople(5)));


            foreach (Person p in repo.GetAll())
            {
                Console.WriteLine(p);
            }
            Console.ReadKey();
        }
    }
}
