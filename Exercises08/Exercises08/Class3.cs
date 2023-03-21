using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises08
{
    //định nghĩa giao diện IPerson
    public interface IPerson
    {
        string FullName { get; set; }
        DateTime DateofBirth { get; set; }
    }
    //Thực thi giao diện
    public class PersonalIdentification : IPerson
    {
        private string _name;
        private DateTime _dob;

        public PersonalIdentification(string name)
        {
            _name = name;
            _dob = new DateTime(0);
        }

        public virtual string FullName
        {
            get { return _name; }
            set { _name = value; }
        }

        public DateTime DateofBirth
        {
            get { return _dob; }
            set
            {
                _dob = value;
            }
        }
    }
    //định nghĩa lớp Generic với ràng buộc là Personaldentification
    public class Employee<T> where T : PersonalIdentification
    {
        private T info;

        public Employee()
        {
        }

        public Employee(T record)
        {
            info = record;
        }

        public T Identification
        {
            get
            {
                return info;
            }

            set
            {
                info = value;
            }
        }
    }
}
