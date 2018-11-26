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
            Assert.Throws<ArgumentNullException>(()=>new PasswordCheckerServise(null));
        }
        
        [Test]
        public void PasswordCheckerService_ValideString()
        {
            SqlRepository repository = new SqlRepository();
            PasswordCheckerServise passwordCheckerServise = new PasswordCheckerServise(repository);

            Assert.True(passwordCheckerServise.VerifyPassword("asdasd", (string t) => t.Length > 5, (string t) => t.Length <7).Item1);
        }

        [Test]
        public void PasswordCheckerService_InvalideString()
        {
            SqlRepository repository = new SqlRepository();
            PasswordCheckerServise passwordCheckerServise = new PasswordCheckerServise(repository);

            Assert.False(passwordCheckerServise.VerifyPassword("asd",(string t)=>t.Length>5).Item1);
        }
    }
}
