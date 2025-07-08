using System;
using System.Collections;
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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();

            List<Resurce> people = new List<Resurce>
                {
                    new Resurce { Name = "Alice", Age = 30 },
                    new Resurce { Name = "Bob", Age = 25 },
                    new Resurce { Name = "Charlie", Age = 35 }
                };

            people.Sort(); // Sorts by Age due to CompareTo


            var numbers = Enumerable.Range(1, 1000000);
            // LINQ pipeline
            var result = numbers
                             .Select(n => n * 2)
                             .OrderByDescending(n => n)
                             .Select(n => n / 2)
                             .Where(n => n % 2 == 0)
                             .Take(10)
                             .ToArray();

        }

        public class Resurce : IComparable<Resurce>
        {
            public string Name { get; set; }
            public int Age { get; set; }

            // Natural sort order by Age
            public int CompareTo(Resurce other)
            {
                return this.Age.CompareTo(other.Age);
            }
        }
    }
}
