using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Onboarding_Specflow.Utilities
{
    [Binding]
    public class Hooks : CommonDriver
    {

        [BeforeScenario]
        public void Setup()
        {
            BrowserSetup();
        }
        [AfterScenario]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
