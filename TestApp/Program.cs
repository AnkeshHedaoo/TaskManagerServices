using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.BusinessLib;
using TaskManager.Entities;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                TaskBL obj = new TaskBL();
                obj.Add(new TaskManager.Entities.Task()
                {
                    TaskID = 2,
                    TaskName = "Task2",
                    Priority = 13,
                    SDate = DateTime.Now,
                    EDate = DateTime.Now
                });

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
