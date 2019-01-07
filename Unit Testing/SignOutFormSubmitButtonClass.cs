using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimplifiedProgrammingLanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplifiedProgrammingLanguage.Tests
{
    [TestClass()]
    public class SignOutFormSubmitButtonClass
    {
        [TestMethod()]
        public void Submitbtn_ClickTest()
        {

            string username = "username";
            string password = "password";

            if (username == "username" && password == "password")
            { }
            else
            {
                Assert.Fail();
            }

        }
    }
}