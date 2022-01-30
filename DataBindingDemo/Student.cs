using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingDemo
{
    class Student
    {
        public string StudentName { get; set; }
        public bool IsEnrolled { get; set; }
    }

    class StudentList:ObservableCollection<Student>
    {

    }


}
