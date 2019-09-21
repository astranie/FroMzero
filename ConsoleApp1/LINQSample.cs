using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpS
{
    class LINQSample
    {
       
    }

    internal class Major : EntityName
    {
        public Teacher Teacher { get; internal set; }
    }

    internal class EntityName
    {
        public string Name { get; set; }
    }
    internal class Student : EntityName
    {
        public List<Major> Majors { get; internal set; }
        public int Score { get; internal set; }
    }

    internal class Majors:EntityName
    {
    }
    internal class Teacher:EntityName
    {

    }
    
}
