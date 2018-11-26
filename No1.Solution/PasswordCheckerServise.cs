using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public abstract class PasswordCheckerServise
    {
        protected readonly IRepository repository;

        public PasswordCheckerServise(IRepository repository)
        {
            if (repository==null)
            {
                throw new ArgumentNullException($"{nameof(repository)} can't be null");
            }
            this.repository = repository;
        }

        public abstract (bool, string) VerifyPassword(string password);
    }
}
