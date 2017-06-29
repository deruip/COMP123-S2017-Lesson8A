using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2017_Lesson8A
{
    class Student : Person
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS)
        private string _studentID;

        // PUBLIC PROPERTIES

        public string StudentID
        {
            get
            {
                return this._studentID;
            }
            set
            {
                this._studentID = value;
            }
        }

        /// <summary>
        /// This is the constructor for the Student Class. It takes three arguments
        /// name (string) - age (int) and studentID (string)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="studentID"></param>
        public Student(string name, int age, string studentID)
            : base(name, age)
        {
            this.StudentID = studentID;
        }

        // PUBLIC METHODS ------------------------------------
        /// <summary>
        /// This is the Studies method. Takes no arguments
        /// </summary>
        public void Studies()
        {
            Console.WriteLine(this.Name + " is studying!");
        }
    }
}
