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

namespace PowerMeter
{
    public partial class Program : Gadgeteer.Program
    {
        // GTM.Module defintions
		Gadgeteer.Modules.Seeed.CurrentSensor currentSensor;

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
			currentSensor = new GTM.Seeed.CurrentSensor(9);

        }
    }
}
