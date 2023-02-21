namespace Hierarchy
{
    public class Devices
    {
        class ProcessorInfo
        {
            public string platformName, CPUMicroarchitectur, graphicAccelerator;
            public int clockFrequency, quantity, manufacturingProcess;
        }

        class InteractionInterfaceGeneral
        {
            public string bluetooth, wiFi;
            public bool NFC, HDMI;

        }

        class InteractionInterfaceAdditional : InteractionInterfaceGeneral
        {
            public bool LAN, fireWireIEEE1394;
        }

        class Notepad : InteractionInterfaceAdditional
        {
            string[] usb, USBTypeCAlternateModes;
            bool cellular, VGA;
            int maximumUSBTransferRate;

            public ProcessorInfo processor;
        }

        class Camera : InteractionInterfaceAdditional
        {
            public bool USB, or3G4G, remoteControl, compositeVideoOut;
            public ProcessorInfo processor;
        }

        class Smartphone : InteractionInterfaceGeneral
        {
            public string audioOut;
            public string connectionConnector;
            public ProcessorInfo processor;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}