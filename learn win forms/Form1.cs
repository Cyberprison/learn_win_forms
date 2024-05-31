using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learn_win_forms
{
    public partial class Form1 : Form
    {
        class Person
        {
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string SecondName { get; set; }

            public string GetFullName()
            {
                return $"Фамилия: {SecondName} | Имя: {FirstName} | Отчество: {MiddleName}";
            }
        }

        private List<Person> GetPersons()
        {
            return new List<Person>()
            {
                new Person()
                {
                    FirstName = "Джеймс",
                    MiddleName = "Эдвард",
                    SecondName = "Вудс"
                },
                new Person()
                {
                    FirstName = "Кэтрин",
                    MiddleName = "Элизабет",
                    SecondName = "Кэмпбелл"
                },
                new Person()
                {
                    FirstName = "Кристофер",
                    MiddleName = "Джеймс",
                    SecondName = "Роу"
                }
            };
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var persons = GetPersons();
            foreach (var person in persons)
            {
                listBox1.Items.Add(person.GetFullName());
            }
        }
    }
}
