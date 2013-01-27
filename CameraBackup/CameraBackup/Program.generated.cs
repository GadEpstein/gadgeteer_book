﻿
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Gadgeteer Designer.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Gadgeteer;
using GTM = Gadgeteer.Modules;

namespace CameraBackup
{
    public partial class Program : Gadgeteer.Program
    {
        // GTM.Module defintions
		Gadgeteer.Modules.GHIElectronics.UsbHost usbHost;
		Gadgeteer.Modules.GHIElectronics.SDCard sdCard;
		Gadgeteer.Modules.GHIElectronics.MulticolorLed ledSD;
		Gadgeteer.Modules.GHIElectronics.MulticolorLed ledUSB;

		public static void Main()
        {
			//Important to initialize the Mainboard first
            Mainboard = new GHIElectronics.Gadgeteer.FEZSpider();			

            Program program = new Program();
			program.InitializeModules();
            program.ProgramStarted();
            program.Run(); // Starts Dispatcher
        }

        private void InitializeModules()
        {   
			// Initialize GTM.Modules and event handlers here.		
			usbHost = new GTM.GHIElectronics.UsbHost(3);
		
			ledSD = new GTM.GHIElectronics.MulticolorLed(4);
		
			ledUSB = new GTM.GHIElectronics.MulticolorLed(ledSD.DaisyLinkSocketNumber);
		
			sdCard = new GTM.GHIElectronics.SDCard(5);

        }
    }
}