using System;
using TechTalk.SpecFlow;

namespace MobileRechargePtm
{
    [Binding]
    public class MobRCPtmSteps
    {
        IWebDriver driver = new ChromeDriver();

        
        [Given(@"I am paytm website rechage")]
        public void GivenIAmPaytmWebsiteRechage()
        {
           driver.Navigate().
        }
        
        [Given(@"I have entered Mobile number,Operator and the amount")]
        public void GivenIHaveEnteredMobileNumberOperatorAndTheAmount()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I Click on Proceed to Recharge")]
        public void WhenIClickOnProceedToRecharge()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be proceed to Proceed to Pay")]
        public void ThenTheResultShouldBeProceedToProceedToPay()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
