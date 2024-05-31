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
        public class Contacts
        {
            public string PhoneNumber { get; set; }
            public string Email{ get; set; }
        }

        public class Person
        {
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string SecondName { get; set; }
            public Contacts Contacts{ get; set; }

            public string GetFullName()
            {
                return $"Фамилия: {SecondName??"нет данных"} | Имя: {FirstName ?? "нет данных"} | Отчество: {MiddleName ?? "нет данных"}";
            }

            public string GetPhoneNumber()
            {
                return $"PhoneNumber: {Contacts?.PhoneNumber ?? "нет данных"}";
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
                },
                new Person()
                {
                    FirstName = "Мартин",
                    MiddleName = "Ранш",
                    SecondName = "Фримен",
                    Contacts = new Contacts
                    {
                        PhoneNumber = "911"
                    }
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
                listBox1.Items.Add($"{person.GetFullName()} | {person.GetPhoneNumber()}");
            }
        }
    }
}
