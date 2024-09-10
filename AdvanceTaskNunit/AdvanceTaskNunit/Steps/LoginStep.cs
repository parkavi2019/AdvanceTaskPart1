using AdvanceTaskNunit.Pages;
using AdvanceTaskNunit.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskNunit.Steps
{
    public class LoginStep : CommonDriver
    {
        LoginPage loginPageObj;
        public LoginStep()
        {
            loginPageObj = new LoginPage();

        }
        public void doLoginStep()
        {
            loginPageObj.LoginSteps();
        }
    }
}
