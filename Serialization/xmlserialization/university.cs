using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xmlserialization
{
    public class university:Student
    {
       public  List<Student> stLst = new List<Student>();
       public int total;
    }
}
