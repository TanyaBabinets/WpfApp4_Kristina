using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4_Kristina.Models
{
    internal class Controller
    {
        BD db = new BD();

        public void AddPerson(string n, int a)
        {
            db.Add(new Person(n, a));
        }
        public List<Person> GetAllPerson()
        {
            return db.GetPeople();
        }
        public void Delete(Person a)
        {
            db.DeletePerson(a);
        }

        public List<Person> GetSearch(string name)
        {
            return db.SearchName(name);
        }

    }
}
