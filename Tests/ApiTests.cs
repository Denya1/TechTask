using Newtonsoft.Json;
using NUnit.Framework;
using RequestBody;
using RestSharp;
using System.Net;
using System.Threading;
using static RequestBody.PostRequestBody;

namespace SeleniumTest.Tests
{
    [TestFixture]
    public class ApiTests
    {
        [Test]
        public void VerifyPostRequestPassed()
        {
            var postRequestBody = new PostRequestBody()
            {
                Welcome = new Welcome()
                {

                
                FormProperties = new FormProperties()
                {
                    FormId = "comp-jxd8gc7s",
                    FormName = "Contacts Form 2",
                },
                EmailConfig = new EmailConfig()
                {
                    SendToOwnerAndEmails = new SendToOwnerAndEmails()
                    {
                        EmailIds = new object[] {}

                    }
                },
                ViewMode = "Site",
                    LabelIds = new string[]
                    {
                        "contacts-contacted_me",
                        "0e84ae80-8bf1-43a6-ba05-8eefb8cbc86b",
                        "2f48386d-f13f-455f-a00f-9d697ef76de6"
                    }
                },
                
                Fields = new Field[]
               {
                  new Field()
                 {
                     FieldId = "comp-jxd8gc8n",
                     Label = "First Name",
                     FirstName = new FirstName()
                     {
                         Value ="кеке"
                     },

                 },
                   new Field()
                   {
                       FieldId = "comp-jxd8gc99" ,
                       Label = "Email",
                       Email = new Email()
                       {
                           Value = "Denya6461@gmail.com",
                           Tag = "main",
                       }
                   },


               },




            };

            IRestClient client = new RestClient("https://tarasmysko89.wixsite.com/_api/wix-forms/v1/");


            RestRequest request = new RestRequest("submit-form", Method.POST);

            postRequestBody.Fields[0].FieldId = "Test";

            var test = JsonConvert.SerializeObject(postRequestBody);

            request.AddJsonBody(test);

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "b8Ac4G_ssoIRdmu_45Raf11Mezo0HCwnZ091aHD88zU.eyJpbn" +
                              "N0YW5jZUlkIjoiNGEwMDU1ZjItNDIyYy00NDkxLTgxMDMtYjFiMTMzYTc5MjkxIiwiY" +
                              "XBwRGVmSWQiOiIxNGNlMTIxNC1iMjc4LWE3ZTQtMTM3My0wMGNlYmQxYmVmN2MiLCJtZ" +
                              "XRhU2l0ZUlkIjoiYzFkNjdlOTAtZmE1YS00ZjZiLTkyM2EtYWM4NGQ2NjBkNThhIiwic2" +
                              "lnbkRhdGUiOiIyMDIyLTAzLTE5VDExOjU0OjEyLjEyNVoiLCJkZW1vTW9kZSI6ZmFsc2Us" +
                              "Im9yaWdpbkluc3RhbmNlSWQiOiI5NTU3MjYxYi01N2I0LTRlMjItOTNjNy02MGIzYjZiM2U" +
                              "2MmUiLCJhaWQiOiJkN2ZhYTUxZS1jNWVlLTRkMjEtOGViOS02NDMxYWEwZGQ0YTEiLCJi" +
                              "aVRva2VuIjoiOGJkNjJiNjItYjg3Ni0wYmZhLTEzMzktMWQzNWU1Yzc0NzFiIiwic2l0Z" +
                              "U93bmVySWQiOiJjODNhMmJjMy05NjNlLTQzMmItOWM1MC1hOWM5YjhmMzFhMGQifQ");

            IRestResponse response = client.Execute(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Content.Contains("submissionId"));



        }

    }
}
