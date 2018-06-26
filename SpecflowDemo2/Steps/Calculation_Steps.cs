using System;
using TechTalk.SpecFlow;

namespace SpecflowDemo2.Steps
{
    [Binding]
    public class CalculationSteps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            ScenarioContext.Current.Add("FirstNumber", number);
        }
        
        [Given(@"I also have entered (.*) into the calculator")]
        public void GivenIAlsoHaveEnteredIntoTheCalculator(int number)
        {
            ScenarioContext.Current.Add("SecondNumber", number);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            var firstNumber = ScenarioContext.Current.Get<int>("FirstNumber");
            var secondNumber = ScenarioContext.Current.Get<int>("SecondNumber");
            ScenarioContext.Current.Add("Result", firstNumber + secondNumber);
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int result)
        {
            var actualResult = ScenarioContext.Current.Get<int>("Result");
            if (!actualResult.Equals(result))
            {
                throw new Exception("Total is not correct");
            }
            Console.Out.WriteLine("Test Passed");
        }
    }
}
