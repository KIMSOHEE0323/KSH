using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using static Autodesk.Revit.DB.SpecTypeId;

namespace KSH2
{
    [Transaction(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            string result = "Hello, Revit!";
            int count = 0;
            double sum = 0.0;
            bool isactive = true;

            //List<string> list = new List<string>();
            //list.Add("대한");
            //list.Add("민국");
            //list.Add("만세");


            for (int i = 1; i < 10; i+=2)
            {
                Debug.Print(i.ToString());
            }           


            //foreach (string a in list)
            //{
            //    foreach (string b in list)
            //    {
            //        Debug.Print(a + "@" + b);
            //    }
            //}

            //List<string> list1 = new List<string>();
            //list1.Add("대한AA");
            //list1.Add("민국BB");
            //list1.Add("만세CC");


            //string resultA = list[0] + list1[0];
            //string resultB = list[1] + list1[1];
            //string resultC = list[2] + list1[2];

            //Debug.Print(resultA);
            //Debug.Print(resultB);
            //Debug.Print(resultC);

            return Result.Succeeded;
        }
    }
}