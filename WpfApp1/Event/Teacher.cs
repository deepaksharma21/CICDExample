using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1.Event
{
    public class Teacher
    {
        public delegate void ExamEventHaldeler(object sender, EventArgs c);

        public event ExamEventHaldeler ExamEvent;

        public void StartExam()
        {

        }

        public void OnExamStarted()
        {
            if (ExamEvent != null)
            {
                ExamEvent(this, EventArgs.Empty);
            }
        }
    }

    public class Student
    {

        private string name;
        public Student(string name)
        {
            this.name = name;


        }

        public void OnExamStarted(object sender, EventArgs args)
        {
            MessageBox.Show(name + " is opening question paper!!!");
        }
    }



    public class MyControl : Control
    {

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(MyControl), new PropertyMetadata("Default Title"));
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

    }

    public class MyControl1 : Control
    {
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(MyControl1), new PropertyMetadata("Default Title"));
    
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

    }




}
