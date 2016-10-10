using VSTOWordAddin.Core.Models;
using System.Runtime.InteropServices;

namespace VSTOWordAddin.Core.Interfaces
{
    [ComVisible(true)]
    [Guid("B523844E-1A41-4118-A0F0-FDFA7BCD77C9")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IAddInUtilities
    {
        void GetPatientData(string PatData);

        Patient CurrentPatient { get; set; }
    }
}
