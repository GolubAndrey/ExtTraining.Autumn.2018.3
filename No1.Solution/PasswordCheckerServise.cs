using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public class PasswordCheckerServise
    {
        protected readonly IRepository repository;

        Func<string, bool> validator;

        public PasswordCheckerServise(IRepository repository)
        {
            if (repository==null)
            {
                throw new ArgumentNullException($"{nameof(repository)} can't be null");
            }
            this.repository = repository;
        }

        public (bool, string) VerifyPassword(string password,params Func<string,bool>[] validators)
        {
            if (validators.Length==0)
            {
                throw new ArgumentException($"{nameof(validators)} can't be null");
            }
            foreach(Func<string,bool> validator in validators)        
            {
                if (!validator(password))
                {
                    return (false, "Incorrect password");
                }
            }
            return (true, "Correct Password");
        }
    }
}
