using System;
using System.Web.Mvc;
using NUnit.Framework;
using Rhino.Mocks;
using Web.Mobile.Controllers;

namespace Web.Mobile.Tests
{
    [TestFixture]
    public class SponsorControllerTestFixture
    {
        [Test]
        public void LoggedInUserWithSponsorship()
        {
            var userRepository = MockRepository.GenerateMock<IUserRepository>();
            userRepository.Expect(u => u.IsCurrentSponsor(Arg<string>.Is.Anything)).Return(true);
            //userRepository.Expect(u => u.GetSponsorshipFor(Arg<string>.Is.Anything)).Return()
            var controller = new SponsorController { UserRepository = userRepository };
            var result = controller.Index() as ViewResult;
            Assert.That(result.ViewName, Is.EqualTo("SponsorshipOverview"));

            userRepository.VerifyAllExpectations();
        }

        [Test]
        public void LoggedInUserNoSponsorship()
        {
            var userRepository = MockRepository.GenerateMock<IUserRepository>();
            userRepository.Expect(u => u.IsCurrentSponsor(Arg<string>.Is.Anything)).Return(false);
            var controller = new SponsorController { UserRepository = userRepository };
            var result = controller.Index() as ViewResult;
            Assert.That(result.ViewName, Is.EqualTo("NoSponsorshipOverview"));

            userRepository.VerifyAllExpectations();
            
        }

        [Test]
        public void NotLoggedIn()
        {
            var userRepository = MockRepository.GenerateMock<IUserRepository>();
            var userNotFoundException = new Exception("User not found");
            userRepository.Expect(u => u.IsCurrentSponsor(Arg<string>.Is.Anything)).Throw(userNotFoundException);
            var controller = new SponsorController { UserRepository = userRepository };
            var result = controller.Index() as ViewResult;
            Assert.That(result.ViewName, Is.EqualTo("Login"));

            userRepository.VerifyAllExpectations();
        }
    }
}
