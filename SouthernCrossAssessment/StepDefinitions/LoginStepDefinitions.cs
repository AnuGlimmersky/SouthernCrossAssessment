using SouthernCrossAssessment.Support;

namespace SouthernCrossAssessment.StepDefinitions
{
    [Binding]
    public sealed class LoginStepDefinitions
    {

        private List<UserData> userData = DataReader.ReadUserDataFromJsonFile("TestData/TestData.json");
  

    }
}