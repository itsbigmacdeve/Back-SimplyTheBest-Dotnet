using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimplyTheBest.Interfaces;

namespace SimplyTheBest.Data
{
    public class UnitOfWork : IUnitOfWork
    {

        public UnitOfWork()
        {
            
        }
        public IUserRepository _UserRepository => throw new NotImplementedException();
    }
}