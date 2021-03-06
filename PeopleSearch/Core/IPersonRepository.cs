﻿using PeopleSearch.Controllers.Resources;
using PeopleSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleSearch.Core
{
    public interface IPersonRepository
    {
        Task<List<Person>> GetPeople();

        Task<Person> GetPerson(int id);

        void Add(Person person);
    }
}
