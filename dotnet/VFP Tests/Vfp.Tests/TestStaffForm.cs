using vfp_behaviour;
using NUnit.Framework;
using Vfp.Mock;

namespace Vfp.Tests
{
    [TestFixture]
    public class TestStaffForm
    {
        [TestCase]
        public void TestScreenCaption()
        {
            var vfp = new vfp_behaviour.StaffBehaviour();
            var form = new StaffForm();
            Assert.NotNull(vfp);
            Assert.AreEqual("Old Caption", form.Caption);
            vfp.ChangeFormCaption(form);
            Assert.AreEqual("New Form Caption", form.Caption);
        }
    }
}