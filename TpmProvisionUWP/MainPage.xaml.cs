using Microsoft.Devices.Tpm;
using Windows.UI.Xaml.Controls;

namespace TpmProvisionUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            TpmDevice myDevice = new TpmDevice(0);

            // The following strings should be replaced with the actual information from Azure Portal or using the DeviceExplorer:

            string primaryKey = "...";
            string hostname = "iot-open-house-demo.azure-devices.net";
            string deviceID = "humidity-sensor";

            myDevice.Provision(primaryKey, hostname, deviceID);
        }
    }
}
