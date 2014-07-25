using System;
using System.Runtime.InteropServices;

namespace Vfp.Mock
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class StaffForm
    {
        public string Name { get; set; }
        public string Caption { get; set; }

        public StaffForm()
        {
            Name = "Staff";
            Caption = "Old Caption";
        }
    }
}
