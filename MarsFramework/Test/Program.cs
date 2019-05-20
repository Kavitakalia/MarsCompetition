using MarsFramework.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class Tenant : Global.Base
        {

            [Test]
            public void UserAccount()
            {
                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Search for a Property");

                // Create an class and object to call the method
                Profile obj = new Profile();
                obj.EditProfile();

            }
            [Test]
            public void ShareSkill()
            {
                test = extent.StartTest("Search Share SKill");

                ShareSkills skill = new ShareSkills();
                skill.EditSkill();
            }

            [Test]
            public void ManageListings()
            {
                test = extent.StartTest("Search Manage Listings");
                ManageListing listing = new ManageListing();
                listing.Listings();
            }
        }
    }
}