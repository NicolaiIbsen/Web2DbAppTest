using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web2DbAppTest.Entities
{
    /// <summary>Represents person.</summary>
    public class Person
    {
        #region Fields
        /// <summary>Firstname of the Person</summary>
        private string firstname;

        /// <summary>Lastname of the Person</summary>
        private string lastname;

        /// <summary>Title of courtesy of the Person</summary>
        private string titelOfCourtesey;
        #endregion


        #region Constructors
        /// <summary>
        /// Constructor of the person
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="titelOfCourtesey"></param>
        public Person(string firstname, string lastname, string titelOfCourtesey)
        {
            Firstname = firstname;
            Lastname = lastname;
            TitelOfCourtesey = titelOfCourtesey;
        }
        #endregion


        #region Properties
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string TitelOfCourtesey { get => titelOfCourtesey; set => titelOfCourtesey = value; }
        #endregion


        #region Methods
        /// <summary>
        /// Override ToString, displays all the values
        /// </summary>
        /// <returns>Returns a complete person as string</returns>
        public override string ToString()
        {
            return $"{titelOfCourtesey} {firstname} {lastname}";
        }
        #endregion
    }
}
