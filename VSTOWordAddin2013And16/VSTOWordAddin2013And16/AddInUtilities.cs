using System.Runtime.InteropServices;
using System.Windows.Forms;
using VSTOWordAddin.Core.Interfaces;

namespace VSTOWordAddin2013And16
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class AddInUtilities : IAddInUtilities
    {
        public void DisplayMessage()
        {
            MessageBox.Show("Hello World!!!! this is an exposed method", "helloWorld");
        }
    }
}
