using Data.Models;
using NUnit.Framework;
using System.Threading;
using HomerEndpoints;
using Newtonsoft.Json;
using static HomerEndpoints.Utility.HttpCodes;

namespace NUnit_Homer
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void Test1()
        {
            var Unit = new Unit(new HomerDbContext());
            var user = new Users()
            {
                UserName = "Tobbiaspreet Singh",
                UserEmail = "Tobbiaspreet@pardhan.com"
            };

            var result = JsonConvert.DeserializeObject<ErrorModel<Users>>(Unit.CreateUser(user));

            Assert.AreEqual(Codes.Ok, result.Code);
        }
    }
}