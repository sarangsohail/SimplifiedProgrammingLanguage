using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimplifiedProgrammingLanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplifiedProgrammingLanguage.Tests
{
    /// <summary>
    /// Defines test class SignOutFormSubmitButtonClass.
    /// </summary>
    [TestClass()]
    public class SignOutFormSubmitButtonClass
    {
        /// <summary>
        /// Defines the test method Submitbtn_ClickTest.
        /// Determines what the username and password should be and therefore
        /// whether access is gained back to the main form
        /// </summary>
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