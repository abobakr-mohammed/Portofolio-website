﻿using Core.Interfaces;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private readonly DataContext _context;
        IGenericRepository<T> _repository;  

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }
        public IGenericRepository<T> repository
        {
          get
            {
                return _repository?? (_repository = new GenericRepository<T>(_context));
            }
        }
        

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
