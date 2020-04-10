using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace xmlserialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stobj = new Student();
            Student stobj1 = new Student();
            stobj1.stid = 61918;
            stobj1.stName = "Muhammad Moid";
            stobj1.stFatherName = "Shamsuddin";
            stobj1.stemail = "moidshams61918@gmail.com";
            university u = new university();
            u.stLst.Add(stobj);
            u.stLst.Add(stobj1);
            stobj.stid=61917;
            stobj.stName="Muhammad Siraj";
            stobj.stFatherName="AbdulKarim";
            stobj.stemail = "sirajkarim61917@gmail.com";
            
            XmlSerializer ser = new XmlSerializer(typeof(university));
            TextWriter tw = new StreamWriter("StudentData.xml");
            ser.Serialize(tw,u);
            tw.Close();
        }
    }
}
