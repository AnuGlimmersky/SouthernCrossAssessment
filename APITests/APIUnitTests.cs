using Microsoft.VisualStudio.TestTools.UnitTesting;
using SouthernCrossAssessment.Helper;
using SouthernCrossAssessment.Helpers;
using System;

namespace APITests
{
    [TestClass]
    public class APIUnitTests
    {
        APIHelper apiHelper;

        [TestMethod]
        public void VerifyRegisterAPIForInvalidPasswordWithoutSymbols()
        {
            apiHelper = new APIHelper();
            string responseBody = apiHelper.ExecutePostAPIRequest(APIRequestBody.registerRequestBody);

            Assert.AreEqual(responseBody, Resources.InvalidPasswordMissingSymbol);
        }

    }
}
