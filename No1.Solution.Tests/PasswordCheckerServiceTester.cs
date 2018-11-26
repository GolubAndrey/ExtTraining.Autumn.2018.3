using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using No1.Solution;

namespace No1.Solution.Tests
{
    [TestFixture]
    public class PasswordCheckerServiceTester
    {
        [Test]
        public void PasswordCheckerService_NullRepository_ArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(()=>new AccountPasswordCheckerServise(null));
        }
        
        [Test]
        public void PasswordCheckerService_ValideString()
        {
            SqlRepository repository = new SqlRepository();
            PasswordCheckerServise passwordCheckerServise = new AccountPasswordCheckerServise(repository);

            Assert.True(passwordCheckerServise.VerifyPassword("a1dasdss").Item1);
        }

        [Test]
        public void PasswordCheckerService_InvalideString()
        {
            SqlRepository repository = new SqlRepository();
            PasswordCheckerServise passwordCheckerServise = new AccountPasswordCheckerServise(repository);

            Assert.False(passwordCheckerServise.VerifyPassword("a1d").Item1);
        }
    }
}
