using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Lessons
    {
            public int Lesson_Id { get; set; }
            public string Name_Group { get; set; }
            public int All_students { get; set; }
            public int  Students_attended { set; get; }
        
    }
}