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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            MyMethod();

            SPerson sPerson;
            sPerson.name = "deepak";

            MessageBox.Show(sPerson.name);

            //TestMethod();

            //Manager manager = new Manager();
            //Worker worker = new Worker();

            //worker.DoWork(manager.WorkedDoneCallBack);

            #region call Worker 
            //UI ui = new UI();
            //ui.LoadEvent();
            #endregion call Worker 

        }

        struct SPerson
        {
            public string name;
            public int age;

            //public SPerson(int age, string name)
            //{
            //    this.age = age;
            //    this.name = name;
            //}
        }


        #region CallBack Worker Example
        public delegate void ProgressUpdate(int progress);
        public class DataFetcher
        {
            public void FetchDataFRomDB(ProgressUpdate progress)
            {
                for (int i = 0; i < 100; i++)
                {
                    progress.Invoke(i);
                }
            }
        }

        public class UI
        {
            DataFetcher dataFetcher = new DataFetcher();
            public async void LoadEvent()
            {
                await Task.Run(() => dataFetcher.FetchDataFRomDB(UpdateUI));
            }

            public void UpdateUI(int progress)
            {
                MessageBox.Show(progress.ToString());
            }

        }

        #endregion CallBack Worker Example




        public delegate void Notify();

        public class Worker
        {
            public void DoWork(Notify callback)
            {
                callback();
            }
        }

        public class Manager
        {
            public void WorkedDoneCallBack()
            {
                MessageBox.Show("Worked done");
            }
        }


        public class Order
        {
            public int OrderId { get; set; }
            public string Customer { get; set; }
            public DateTime OrderDate { get; set; }
            public decimal Amount { get; set; }
        }

        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        private void TestMethod()
        {
            List<Order> orders = new List<Order>
                {
                    new Order { OrderId = 1, Customer = "A", OrderDate = DateTime.Now, Amount = 100 },
                    new Order { OrderId = 2, Customer = "A", OrderDate = DateTime.Now, Amount = 400 },
                    new Order { OrderId = 3, Customer = "A", OrderDate = DateTime.Now, Amount = 500 },
                    new Order { OrderId = 4, Customer = "A", OrderDate = DateTime.Now, Amount = 500 },

                    new Order { OrderId = 5, Customer = "B", OrderDate = DateTime.Now, Amount = 300 },
                    new Order { OrderId = 6, Customer = "B", OrderDate = DateTime.Now, Amount = 500 },
                    new Order { OrderId = 7, Customer = "B", OrderDate = DateTime.Now, Amount = 330 },
                    new Order { OrderId = 8, Customer = "B", OrderDate = DateTime.Now, Amount = 290 }
                };

            //var list = from student in orders
            //           group student by student.Customer;       


            var result = orders.GroupBy(x => x.Customer)
                            .Select(a => new { customer = a.Key, total = a.Sum(b => b.Amount) }).OrderByDescending(x => x.total).FirstOrDefault();



            //var list2 = from student in stuList
            //            orderby student.Name, student.Age
            //            select new { student.Name};

            //var list1 = stuList.OrderBy(a => a.Name).ThenByDescending(a => a.Age);
        }


        private void MyMethod()
        {
            try
            {
                List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David", "David" };
                //string name2 = names.Single(n => n == "David");
                //string name4 = names.SingleOrDefault(n => n == "David");

                var students = new List<Person>
                    {
                        new Person { FirstName = "Alice", Subjects = new List<string> { "Math", "English" } },
                        new Person { FirstName = "Bob", Subjects = new List<string> { "Science", "Math" } }
                    };

                var result = students.Select(x => x.Subjects);
                var result1 = students.SelectMany(x => x.Subjects);
                var result2 = students.Select(x => new { x.FirstName, x.Subjects });

                List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

                var result3 = numbers.Count(x => x > 30);

            }
            catch (Exception ex)
            {

            }
        }
    }
}
