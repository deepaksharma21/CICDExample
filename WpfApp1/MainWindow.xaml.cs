using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Event;
using static WpfApp1.MainWindowViewModel;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public delegate void MyDelagate(string message);
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowViewModel();

            //ReverseAString("Deepak");
            //Factorial(3);

            //#region Logger
            //TREKLogger logger = TREKLogger.Instance;
            //logger.Log("");
            //#endregion Logger

            //#region Event example
            //Teacher teacher = new Teacher();
            //Student deepak = new Student("Deepak");
            //Student pankaj = new Student("Pankaj");

            ////subscribe the event
            //teacher.ExamEvent += deepak.OnExamStarted;
            //teacher.ExamEvent += pankaj.OnExamStarted;

            ////publish the event
            //teacher.OnExamStarted();
            //#endregion Event example

            // ReverseAString1("this is Deepak Sharma");

            //if (IsPrime(8))
            //{
            //    MessageBox.Show("this is prime number");
            //}
            //else
            //{
            //    MessageBox.Show("this is not a prime number");
            //}
            // SwapTwoNumber();

            //CountOccurence("programming");

            //Action<int, string, bool> myAction = (id, name, isActive) =>
            //{
            //    Console.WriteLine($"ID: {id}, Name: {name}, Active: {isActive}");
            //};

            //myAction(1, "Sharma Ji", true);          

            //Count("ramrrma");

            // EmployeeLinq();

            try
            {
                TryCatch();
            }
            catch(Exception ex)
            {

            }
        }

        public void EmployeeLinq()
        {
            List<Employee> employeeLst = new List<Employee>();
            employeeLst.Add(new Employee { Name = "Deepak", DepartMent = "HR", Salary = 2000, Subjects = new List<string> { "Maths, Hindi" } });
            employeeLst.Add(new Employee { Name = "Pawan", DepartMent = "HR", Salary = 3000, Subjects = new List<string> { "English, Science" } });
            //employeeLst.Add(new Employee { Name = "Ram", DepartMent = "HR" , Salary=5000});
            //employeeLst.Add(new Employee { Name = "Deepak", DepartMent = "HR", Salary = 2000 });


            //employeeLst.Add(new Employee { Name = "Sona", DepartMent = "Software", Salary=6000 });
            //employeeLst.Add(new Employee { Name = "Ranga", DepartMent = "Software", Salary=7000 });
            //employeeLst.Add(new Employee { Name = "Maian", DepartMent = "Software" });

            var lst = employeeLst.GroupBy(x => x.DepartMent)
                   .Select(x => new { Depart = x.Key, EmployeeCount = x.Count() });

            //foreach(var dept in lst)
            //{
            //    MessageBox.Show(dept.Depart+" "+ dept.EmployeeCount);
            //}

            var lst1 = employeeLst.OrderByDescending(x => x.Salary).Select(y => new { Employee = y.Name, Salary = y.Salary }).Distinct().Skip(1).FirstOrDefault();

            var list2 = employeeLst.Where(x => x.Name.StartsWith("D")).ToList();

            var list3 = employeeLst.GroupBy(x => x.DepartMent).Select(y => new { DepartMent = y.Key, HSal = y.Max(e => e.Salary) });

            var list4 = employeeLst.Select(x => x.Name).Distinct();

            var list5 = employeeLst.GroupBy(x => x.Name)
                       .Where(g => g.Count() > 1)
                       .Select(g => g.Key);

            var list6 = employeeLst.OrderByDescending(x => x.Salary).Take(2);

            var list7 = employeeLst.Select(x => x.Subjects).ToList();

            
        

        }


       public void TryCatch()
        {
            try
            {
                // Some error occurs
                CauseError();
            }
            catch (Exception ex)
            {
                // Logging or handling
                Console.WriteLine("Caught: " + ex.Message);              
                throw ;  // BAD: resets stack trace
            }
        }
        private void CauseError()
        {
            int x = 0;
            int y = 10 / x;  // <-- real origin of exception
        }


        public string ConvertString(string str)
        {

            string[] arr = str.Split(' ');

            StringBuilder bu = new StringBuilder();

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                var abc = arr[i].ToString();// This  Is  DEEPAK
                bu.Append(abc);
            }



            return bu.ToString();

        }


        public class Example
        {
            public void Show(string msg)
            {
                MessageBox.Show(msg + "Show");
            }

            public void Display(string msg)
            {
                MessageBox.Show(msg + "Display");
            }
        }

        public bool IsPrime(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;

        }




        public void SwapTwoNumber()
        {
            int a = 10;
            int b = 20;

            int temp;

            temp = a;
            a = b;
            b = temp;

            MessageBox.Show("a=" + a.ToString());
            MessageBox.Show("b=" + b.ToString());

        }

        //str="programming"
        public void CountOccurence(string str)
        {
            char[] myarray = str.ToCharArray();
            int count = 0;

            for (int i = 0; i <= myarray.Length - 1; i++)
            {
                for (int j = i + 1; j <= myarray.Length - 1; j++)
                {
                    if (myarray[i] == myarray[j])
                    {
                        count++;
                    }
                }
            }
        }

        public void Count(string str)//       Count("ramrrma");
        {
            char[] charArray = str.ToCharArray();
            int count = 1;
            bool[] visisted = new bool[charArray.Length];

            for (int i = 0; i <= charArray.Length - 1; i++)
            {
                count = 1;
                if (visisted[i])
                    continue;

                for (int j = i + 1; j <= charArray.Length - 1; j++)
                {
                    if (charArray[i] == charArray[j])
                    {
                        count++;
                        visisted[j] = true;
                    }
                }

                MessageBox.Show(charArray[i] + ": count " + count);
            }
        }



        public void ReverseAString1(string str)
        {
            char[] charArray = str.ToCharArray();
            StringBuilder builder = new StringBuilder();

            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                var val = charArray[i];
                builder.Append(val);
            }

            MessageBox.Show(builder.ToString());
        }

        public void Factorial(int num)
        {
            int fact = 1;
            for (int i = 1; i < num; i++)
            {
                fact = fact * i;
            }

            MessageBox.Show(fact.ToString());
        }

        public interface IFruit
        {
            string GetColor();
        }
        public class Apple : IFruit
        {
            public string GetColor()
            {
                return "Apple";
            }
        }
        public class Orange : IFruit
        {
            public string GetColor()
            {
                return "Orange";
            }
        }

        public class Fruit
        {
            public string GetColor()
            {
                return "Fruit Color";
            }
        }

        public class Lemon : Fruit
        {
            public new string GetColor()
            {
                return "Yellow";
            }
        }



    }
}
