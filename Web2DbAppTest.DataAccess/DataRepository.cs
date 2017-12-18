using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Web2DbAppTest.Entities;
using System.Threading.Tasks;

namespace Web2DbAppTest.DataAccess
{
    /// <summary>
    /// Handles all data in the database
    /// </summary>
    public class DataRepository
    {
        private Executor executor;

        public DataRepository()
        {
            Executor = new Executor();
        }

        public Executor Executor { get => executor; set => executor = value; }

        /// <summary>
        /// Gets all the Person(s) from your database
        /// </summary>
        /// <returns>returns a List<Person></returns>
        public List<Person> GetAll()
        {
            int i = 6;
            List<Person> persons = new List<Person>();
            string sql = "SELECT * FROM Persons";
            DataSet set = Executor.Execute(sql);
            DataTable table = set.Tables[0];
            foreach (DataRow row in table.Rows)
            {
                string firstname = (string)row["Firstname"];
                string lastname = (string)row["Lastname"];
                string title = (string)row["Title"];
                persons.Add(new Person(firstname, lastname, title));
            }
            return persons;
        }

        /// <summary>
        /// Creates SQLServer Insert Into statement, with List<Person> as parameter
        /// </summary>
        /// <param name="persons"></param>
        /// <returns>INSERT INTO string</returns>
        public string SqlCreater(List<Person> persons)
        {
            string sql = "INSERT INTO Persons VALUES";
            foreach (Person p in persons)
            {
                sql += $"('{p.Firstname}','{p.Lastname}','{p.TitelOfCourtesey}'),";
            }
            return sql.TrimEnd(',');
        }
    }
}
