using System;
using Sims3.Gameplay.Actors;
using Sims3.Gameplay.Utilities;
using Sims3.SimIFace;

//MODULE TEMPLATE - Free to use to make your own random Modules! 

//Requires The Core Module DLL: https://modthesims.info/d/668302/public-beta-the-randomizer-mod-reworked.html

/*			--===	HOW TO USE (Uncollapse me!):		===--
 *		
 *		[[ Preparing the CORE DLL reference: ]]
 *		
 *		1. First, download the Mod if you haven't.
 *		2. Open up the CORE module in S3PE
 *		3. Right click on the S3SA file and click "Export DLL"
 *		4. Save somewhere on your disk, where it will be save and easily to find.
 *		
 *		In this template (And Visual studio/Sharp Develop) do the following:
 *		
 *		5. Right click on "References", Then, "Add References..."
 *		6. Added the Core Module DLL to the references.
 *		7. Happy coding!
 */

/*		--===	Understanding the Template (Uncollapse me!) ===--
 *		
 *		[[ Description ]]:
 *			I've currently set up the bare basics of the module for you here. Of course, You'll need to edit it to your own liking.
 *			Make sure to read the comments given under each important line! It also gives you some insight on what to do with the Module Package that the template came with.
 *			
 *			The lifecycle of your module goes as followed:
 *				- First, we want to load in the XML on OnStartupApp with all your events.
 *				- We parse the XML (if valid) to the Core Module and it will do the rest for you!
 *				- Once one of your events in the XML are chosen, it will check this project for the test and normal function.
 */


// Rename the Username bit and the ModuleName. (For this cs. file you can go with something like "Username's base"
namespace Sims3.Gameplay.USERNAME.ModuleNameHere
{

	/* 
	 * ===============================================
	 * ||											||
	 * ||            XML/Event Loader				||
	 * ||											||
	 * ===============================================
	 */


	// Rename to appropiate name. This may be called simply something like "Username's Base class" or "Username's Module Loader"
	public class RenameMeModuleName
	{
		[Tunable] static bool init;
		
		static RenameMeModuleName()
		{
			World.sOnStartupAppEventHandler += new EventHandler(OnStartupApp);
		}

		public static void OnStartupApp(object sender, EventArgs e)
		{
			// Change the 0xB2D2AC269C47BF2A to your module XML instance!
			XmlDbData xmlNewModuleEvents = XmlDbData.ReadData(new ResourceKey(0xB2D2AC269C47BF2A, 0x0333406C, 0x00000000), false);
			if (xmlNewModuleEvents != null)
			{
				RandomizerCoreModule.ParseRandomizerDataFromXML(xmlNewModuleEvents);
			}
		}
	}



	/* 
	 * ===============================================
	 * ||											||
	 * ||            Event Tests					||
	 * ||											||
	 * ===============================================
	 * 
	 * 	[[ Description: ]]
	 *		Before triggering your event, the Core Module checks if there are any special tests for your event it needs to go through before being able to trigger.
	 *		For example:
	 *			For the "Plants growth spurth" event I did a check if there are any Plants on the lot to begin with. 
	 *			
	 *	[[ NOTE: ]] 
	 *		If you're making some random events for "Relationship" and "friendship" modules, 
	 *		then don't check if they have friends/partners!!! This is already handled in the Core framework.
	 *		
	 */


	// For good practise, put your Test Functions in a different class. Make sure to rename this class to something like "RandomizerModuleNameTests"
	public class MyRandomizerModulesTests
	{

		// Please see: https://github.com/Lyralei1/TheRandomizer-Core/blob/master/TheRandomizerCore/RandomizerFunctionCallback.cs#L31


		// With the current layout, we want to add 
		public static bool TestMyFunction(Sim actor, Sim target)
		{
			if("I'm fine!")
            {
				return true; // True = passed the test, can fire event
            }
			else
            {
				return false; // False = Did not pass the test. Ignore this event and try it later with a different sim.
            }
		}
	}








	/* 
	 * ===============================================
	 * ||											||
	 * ||            Event Functions				||
	 * ||											||
	 * ===============================================
	 * 
	 *	[[ Description: ]]
	 *		Use this class to tell the Core module what the event should do when triggered.
	 *		See this basically as the "Run()" Function of EA's Interactions, as this is the point your event will actually run & Function!
	 * 
	 */


	// For good practise, put your Regular Functions in a different class. Make sure to rename this class to something like "RandomizerModuleNameFunctions"
	public class MyRandomizerModulesFunctions
    {

		// Please see: https://github.com/Lyralei1/TheRandomizer-Core/blob/master/TheRandomizerCore/RandomizerFunctionCallback.cs#L24
		public static void HandleMyFunction(Sim actor, Sim target)
        {
			// Add your code here! What it should do, etc. See it as a "Run()" function of an interaction if you're familiar with that :)
        }


		public static void HandleButtonOne(Sim actor, Sim target)
		{
			// Add your code here! What it should do, etc. See it as a "Run()" function of an interaction if you're familiar with that :)
		}

		public static void HandleButtonTwo(Sim actor, Sim target)
		{
			// Add your code here! What it should do, etc. See it as a "Run()" function of an interaction if you're familiar with that :)
		}

		public static void HandleButtonThree(Sim actor, Sim target)
		{
			// Add your code here! What it should do, etc. See it as a "Run()" function of an interaction if you're familiar with that :)
		}
	}

}