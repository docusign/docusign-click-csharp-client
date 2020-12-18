using DocuSign.Click.Api;
using DocuSign.Click.Client;
using DocuSign.Click.Client.Auth;
using DocuSign.Click.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace SdkNetCoreTests
{
    [TestClass]
    public class JwtAuthNetCoreTests
    {
        TestConfig testConfig = new TestConfig();
        [TestInitialize()]
        [TestMethod]
        public void JwtLoginTest()
        {
            testConfig.ApiClient = new ApiClient(testConfig.Host);

            Assert.IsNotNull(testConfig.PrivateKey);

            byte[] privateKeyStream = Convert.FromBase64String(testConfig.PrivateKey);

            var scopes = new List<string>();
            scopes.Add("click.manage");
            scopes.Add("click.send");
            scopes.Add("signature");
            scopes.Add("impersonation");

            OAuth.OAuthToken tokenInfo = testConfig.ApiClient.RequestJWTUserToken(testConfig.IntegratorKey, testConfig.UserId, testConfig.OAuthBasePath, privateKeyStream, testConfig.ExpiresInHours, scopes);

            // the authentication api uses the apiClient (and X-DocuSign-Authentication header) that are set in Configuration object
            OAuth.UserInfo userInfo = testConfig.ApiClient.GetUserInfo(tokenInfo.access_token);

            Assert.IsNotNull(userInfo);
            Assert.IsNotNull(userInfo.Accounts);

            foreach (var item in userInfo.Accounts)
            {
                if (item.IsDefault == "true")
                {
                    testConfig.AccountId = item.AccountId;
                    //testConfig.ApiClient.SetBasePath(item.BaseUri + "/restapi");
                    break;
                }
            }

            Assert.IsNotNull(testConfig.AccountId);
        }

        [TestMethod]
        public void JwtGetClickwrapsTest()
        {
            // |EnvelopesApi| contains methods related to creating and sending Envelopes (aka signature requests)
            AccountsApi accountsApi = new AccountsApi(testConfig.ApiClient);
            ClickwrapVersionsResponse clickwrapVersionsResponse = accountsApi.GetClickwraps(testConfig.AccountId, new AccountsApi.GetClickwrapsOptions());

            Assert.IsNotNull(clickwrapVersionsResponse);
            Assert.IsNotNull(clickwrapVersionsResponse.Clickwraps);
            Assert.IsTrue(clickwrapVersionsResponse.Clickwraps.Count > 0);
        }
    }
}