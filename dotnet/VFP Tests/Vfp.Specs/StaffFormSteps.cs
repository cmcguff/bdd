using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Vfp.Mock;
using vfp_behaviour;

namespace Vfp.Specs
{
    [Binding]
    public class StaffFormSteps
    {
        public StaffBehaviour Vfp = new StaffBehaviour(); 
        public StaffForm Form = new StaffForm();

        [Given(@"The staff form has a caption of ""(.*)""")]
        public void GivenTheStaffFormHasACaptionOf(string p0)
        {
            Assert.NotNull(Vfp);
            Assert.AreEqual(p0, Form.Caption);
        }
        
        [When(@"I press the change caption button")]
        public void WhenIPressTheChangeCaptionButton()
        {
            Vfp.ChangeFormCaption(Form);
        }
        
        [Then(@"the caption should be changed to ""(.*)""")]
        public void ThenTheCaptionShouldBeChangedTo(string p0)
        {
            Assert.AreEqual(p0, Form.Caption);
        }
    }
}
