﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenTicketSystem.Repositories
{
    interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        T GetById(int id);

        void Add(T addObject);

        void Delete(T deleteObject);

        void Delete(int objId);

        void Update(T obj);
    }
}
