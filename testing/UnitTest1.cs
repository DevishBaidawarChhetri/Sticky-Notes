using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp3;

namespace testing
{
    [TestClass]
    public class UnitTest1
    {
        WindowsFormsApp3.login_class log = new WindowsFormsApp3.login_class();
        [TestMethod]
        public void test()
        {
            try
            {
                bool ActualResult = true;
                bool ExpectResult = true;
                Assert.AreEqual(ActualResult, ExpectResult);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
             }
        }

        WindowsFormsApp3.login_class login = new WindowsFormsApp3.login_class();
        [TestMethod]
        public void login_test()
        {
           
            {
                  bool ActualResult = login.checkUser();
                string ExpectResult = "Hari";
               Assert.AreEqual(ActualResult, ExpectResult);
            }
      }
        WindowsFormsApp3.login_class login11 = new WindowsFormsApp3.login_class();
     [TestMethod]
        public void logintesting()
    {
        string username = "mamata";
        string password = "mamata";
        WindowsFormsApp3.login_class checkLogin =   new WindowsFormsApp3.login_class();
                     
         
        checkLogin._username = username;
        checkLogin._password = password;

        bool actualResult = checkLogin.checkUser();
        bool expectedResult = true;
        Assert.AreEqual(actualResult,expectedResult);

    }
   }
 }

                
    


