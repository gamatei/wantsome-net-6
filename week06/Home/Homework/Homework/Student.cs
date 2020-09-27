using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Home01
{
    public class Student:ICloneable,IComparable<Student>
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public string PermAddress { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public Speciality Speciality { get; set; }
        public University University { get; set; }
        public Faculty Faculty { get; set; }

        public Student(string FirstName, string MiddleName, string LastName, string SSN, string PermAddress, string PhoneNo, string Email, string Course, Speciality Speciality, University University,Faculty Faculty)
        {
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.LastName = LastName;
            this.SSN = SSN;
            this.PermAddress = PermAddress;
            this.PhoneNo = PhoneNo;
            this.Email = Email;
            this.Course = Course;
            this.Speciality = Speciality;
            this.University = University;
            this.Faculty = Faculty;
        }

        public object Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.PermAddress, this.PhoneNo,this.Email, this.Course, this.Speciality, this.University, this.Faculty);
        }

        

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{FirstName}");
            sb.AppendLine($"{MiddleName}");
            sb.AppendLine($"{LastName}");
            sb.AppendLine($"{SSN}");
            sb.AppendLine($"{PermAddress}");
            sb.AppendLine($"{PhoneNo}");
            sb.AppendLine($"{Email}");
            sb.AppendLine($"{Course}");
            sb.AppendLine($"{Speciality}");
            sb.AppendLine($"{University}");
            sb.AppendLine($"{Faculty}");

            return sb.ToString();
        }

        public int CompareTo([AllowNull] Student other)
        {
            throw new NotImplementedException();
        }
    }

    public enum Speciality
    {
        Management,
        Info,
        Stomatologie
    }
    public enum University
    {
        AICuza,
        GAsachi,
        GTPopa
    }

    public enum Faculty
    {
        AC,
        FEEA,
        Stomatologie
    }
    
}
