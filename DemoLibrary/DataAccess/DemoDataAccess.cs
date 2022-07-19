using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModel> peoples = new();
        public DemoDataAccess()
        {
            peoples.Add(new PersonModel { Id = 1, Firstname = "Tim", Lastname = "Correy" });
            peoples.Add(new PersonModel { Id = 2, Firstname = "Viktor", Lastname = "Zafirovski" });
            peoples.Add(new PersonModel { Id = 3, Firstname = "Katerina", Lastname = "Stoparevska" });
        }
        public List<PersonModel> Get()
        {
            return peoples;
        }
        public PersonModel Insert(string firstname, string lastname)
        {
            PersonModel p = new() { Firstname = firstname, Lastname = lastname };
            p.Id = peoples.Max(x => x.Id) + 1;
            peoples.Add(p);
            return p;
        }
    }
}
