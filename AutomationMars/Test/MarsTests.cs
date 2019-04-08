using AutomationMars.Pages;
using NUnit.Framework;
using System;

namespace AutomationMars
{
    [TestFixture]
    public class MarsTests
    {
        class mytest : Global.Base
        {
            [Test]
            public void MessagesforFileds()
            {
                ShareSkillPage sp = new ShareSkillPage();
                sp.displayingMessages();
            }
            [Test]
            public void AddShareSkill()
            {
                ShareSkillPage sp = new ShareSkillPage();
                sp.bbtnShareSkill();
                sp.enterShareskill();
                sp.validationShareSkill();
            }
            [Test]
            public void ActivatedDeactivated()
            {
                ManageListingsPage mlp = new ManageListingsPage();
                mlp.chkSlider();
                mlp.verifyDeactivated();
                mlp.chkSlider();
            }
            [Test]
            public void updateProfile()
            {
                Profile pf = new Profile();
                pf.ProfileSteps();
            }
        }
        
    }
}
