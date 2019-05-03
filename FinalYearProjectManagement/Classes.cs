using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalYearProjectManagement
{
    class Person
    {
        string FName;
        string LName;
        string contact;
        string email;
        DateTime dob;
        string gender;


        public Person()
        {
            FName = null;
            LName = null;
            contact = null;
            email = null;
            dob = DateTime.Now;
            gender = null;
        }

        public String fname
        {
            set
            {
                foreach (char c in value)
                {
                    if (!char.IsLetter(c))
                    {
                        throw new ArgumentException();
                    }
                }

                FName = value;
            }
            get
            {
                return FName;
            }
        }
        public String lname
        {
            set
            {
                foreach (char c in value)
                {
                    if ((!char.IsLetter(c) && (!char.IsWhiteSpace(c))))
                    {
                        throw new ArgumentException();
                    }
                }

                LName = value;
            }
            get
            {
                return LName;
            }
        }
        public String Contact
        {
            set
            {
                if (value.Length != 11)
                {
                    throw new ArgumentException();
                }
                foreach (char c in value)
                {
                    if (!char.IsDigit(c))
                    {
                        throw new ArgumentException();
                    }
                }

                contact = value;
            }
            get
            {
                return contact;
            }
        }
        public String Email
        {
            set
            {
                new System.Net.Mail.MailAddress(value);
                email = value;
            }
            get
            {
                return email;
            }
        }
        public DateTime DOB
        {
            set
            {
                if ((DateTime.Now.Year - value.Year) < 18)
                {
                    throw new ArgumentException();
                }
                dob = value;
            }
            get
            {
                return dob;
            }
        }
        public String Gender
        {
            set
            {
                if ((value != "Male") && (value != "Female"))
                {
                    throw new ArgumentException();
                }
                gender = value;
            }
            get
            {
                return gender;
            }
        }

    }
    class Student : Person
    {
        string RegNo;

        public String regNo
        {
            set
            {
                if (value.Length > 11 || value.Length < 10)
                {
                    throw new ArgumentException();
                }
                for (int i = 0; i == 3; i++)
                {
                    if (!char.IsDigit(value[i]))
                    {
                        throw new ArgumentException();
                    }
                }
                if ((value[4] != '-') || (value[7] != '-'))
                {
                    throw new ArgumentException();
                }
                if ((!char.IsLetter(value[5])) && (!char.IsLetter(value[6])))
                {
                    throw new ArgumentException();
                }
                for (int i = 8; i == 10; i++)
                {
                    if (!char.IsDigit(value[i]))
                    {
                        throw new ArgumentException();
                    }
                }

                RegNo = value;
            }
            get
            {
                return RegNo;
            }
        }
    }
    class Advisor : Person
    {
        string Designation;
        string Salary;

        public Advisor()
        {
            Designation = null;
            Salary = null;
        }

        public string designation
        {
            set
            {
                if (value != "Professor" && value != "Associate Professor" && value != "Assisstant Professor" && value != "Lecturer" && value != "Industry Professional")
                {
                    throw new ArgumentException();
                }
                Designation = value;
            }
            get
            {
                return Designation;
            }
        }

        public string salary
        {
            set
            {
                foreach (char c in value)
                {
                    if (!char.IsDigit(c))
                    {
                        throw new ArgumentException();
                    }
                }
                Salary = value;
            }
            get
            {
                return Salary;
            }
        }

    }

    class Project
    {
        string Description { get; set; }
        string Title { get; set; }
    }

    class Evaluation
    {
        string name;
        string marks;
        string totalWeightage;

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
  

        public string Marks
        {
            set
            {
                foreach (char c in value)
                {
                    if (!char.IsDigit(c))
                    {
                        throw new ArgumentException();
                    }
                }
                marks = value;
            }
            get
            {
                return marks;
            }

        }

        public string TotalWeightage
        {
            set
            {
                foreach (char c in value)
                {
                    if (!char.IsDigit(c))
                    {
                        throw new ArgumentException();
                    }
                }
                totalWeightage = value;
            }
            get
            {
                return totalWeightage;
            }
        }
    }
}
