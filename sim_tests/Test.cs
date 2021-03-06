﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using Hats.SimWeather;
using Hats.Time;
using NUnit.Framework;
using Sim_Harness_GUI;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace sim_tests
{
[TestFixture]
public class Test
{
	[Test]
	[ExpectedException(typeof(ArgumentException))]
	public void CreatingTimeFrame()
	{
		var frame = new TimeFrame();
		frame.setTimeFrame(rate: -1.0);
	}

	[Test]
	public void TimeRate()
	{
		const Double SimRate = 2.0;
		var doubleTime = new TimeFrame();

		var then = DateTime.Now;
		var diff = Math.Abs((then - doubleTime.time(then)).TotalSeconds);
		Assert.Less(diff, 1e-3);

		doubleTime.setTimeFrame(rate: SimRate);

		then = DateTime.Now;
		Thread.Sleep(2000);
		var now = DateTime.Now;

		var simSpan = doubleTime.time(now) - doubleTime.time(then);
		var realSpan = now - then;

		var computedRate = simSpan.TotalSeconds / realSpan.TotalSeconds;
		diff = Math.Abs(computedRate - SimRate); 
		Assert.Less(diff, 0.01);
	}

	[Test]
	public void LinearWeather()
	{
		var frame = new TimeFrame();
		var linear = new LinearWeather(frame);

		Assert.IsNaN(linear.Temperature());

		const Double StartingTemp = 75.0;
		TemperatureSetPoint temp_a = new TemperatureSetPoint(DateTime.Now, StartingTemp);
		linear.Add(temp_a);

		Assert.AreEqual(StartingTemp, linear.Temperature());
		Assert.AreEqual(1, linear.SetPoints().Count);
		linear.ClearSetPoints();
		Assert.AreEqual(0, linear.SetPoints().Count);

		var start = DateTime.Now;
		List<TemperatureSetPoint> temps = new List<TemperatureSetPoint>
		{
			new TemperatureSetPoint(start, 0),
			new TemperatureSetPoint(start + new TimeSpan(0, 0, 10), 10),
			new TemperatureSetPoint(start + new TimeSpan(0, 0, 20), 20),
			new TemperatureSetPoint(start + new TimeSpan(0, 0, 30), 10)
		};

		linear.AddRange(temps);
		Assert.AreEqual(temps.Count, linear.SetPoints().Count);

		Assert.AreEqual(temps[0].Temp, linear.Temperature(start));
		Assert.AreEqual(5, linear.Temperature(start + new TimeSpan(0, 0, 5)));
		Assert.AreEqual(15, linear.Temperature(start + new TimeSpan(0, 0, 25)));
	}

	//[Test]
	/*public void InstanceManagerWorkingHouse()
	{
		InstanceManager manager = new InstanceManager();

		//Assert.AreEqual(0, manager.getNumberHouses());
		Assert.AreEqual(0, manager.getNumberApps());

		string pathToHouse = Directory.GetCurrentDirectory();

		// get path to the dummyHouseAppWorkingProperly
		pathToHouse += "/../../../dummyHouseAppWorkingProperly/bin/Debug/dummyHouseAppWorkingProperly.exe";

		string pathToApp = pathToHouse;


		string jsonBlob = Directory.GetCurrentDirectory();
		jsonBlob += "/../../../scenarios/example1.json";
		jsonBlob = File.ReadAllText(jsonBlob);
		jsonBlob = jsonBlob.Replace("\n", "");
		jsonBlob = jsonBlob.Replace("\t", "");

		TimeFrame tf = new TimeFrame(DateTime.Now, DateTime.Now, 2.0);
		string tfString = JsonConvert.SerializeObject(tf);

		// Test for working HouseApp
		bool start = manager.startGeneratorProcesses(pathToApp, pathToHouse, tfString, jsonBlob);
		Assert.AreEqual(true, start);
		Assert.AreEqual(1, manager.getNumberHouses());
		Assert.AreEqual(0, manager.getNumberApps());

		manager.killGeneratorProcesses();
		Assert.AreEqual(0, manager.getNumberHouses());
		Assert.AreEqual(0, manager.getNumberApps());

	}*/

	//[Test]
	/*public void InstanceManagerInvalidHouseExe()
	{
		InstanceManager manager = new InstanceManager();

		Assert.AreEqual(0, manager.getNumberHouses());
		Assert.AreEqual(0, manager.getNumberApps());

		string pathToHouse = Directory.GetCurrentDirectory();

		// get path to the dummyHouseAppWorkingProperly
		pathToHouse += "/../../../dummyHouseAppWorkingProperly/bin/Debug/dummyHouseAppWorkingProperl";

		string pathToApp = pathToHouse;


		string jsonBlob = Directory.GetCurrentDirectory();
		jsonBlob += "/../../../scenarios/example1.json";
		jsonBlob = File.ReadAllText(jsonBlob);
		jsonBlob = jsonBlob.Replace("\n", "");

		TimeFrame tf = new TimeFrame(DateTime.Now, DateTime.Now, 2.0);
		string tfString = JsonConvert.SerializeObject(tf);

		// Test for working HouseApp
		bool start = manager.startGeneratorProcesses(pathToApp, pathToHouse, tfString, jsonBlob);
		Assert.AreEqual(false, start);
		Assert.AreEqual(0, manager.getNumberHouses());
		Assert.AreEqual(0, manager.getNumberApps());
	}*/

	//[Test]
	/*public void InstanceManagerErrorHouse()
	{
		InstanceManager manager = new InstanceManager();

		Assert.AreEqual(0, manager.getNumberHouses());
		Assert.AreEqual(0, manager.getNumberApps());

		string pathToHouse = Directory.GetCurrentDirectory();

		// get path to the dummyHouseAppWorkingProperly
		pathToHouse += "/../../../dummyHouseAppError/bin/Debug/dummyHouseAppError.exe";

		string pathToApp = pathToHouse;


		string jsonBlob = Directory.GetCurrentDirectory();
		jsonBlob += "/../../../scenarios/example1.json";
		jsonBlob = File.ReadAllText(jsonBlob);
		jsonBlob = jsonBlob.Replace("\n", "");
		jsonBlob = jsonBlob.Replace("\t", "");

		TimeFrame tf = new TimeFrame(DateTime.Now, DateTime.Now, 2.0);
		string tfString = JsonConvert.SerializeObject(tf);

		// Test for working HouseApp
		bool start = manager.startGeneratorProcesses(pathToApp, pathToHouse, tfString, jsonBlob);
		Assert.AreEqual(false, start);
		Assert.AreEqual(0, manager.getNumberHouses());
		Assert.AreEqual(0, manager.getNumberApps());
		manager.killGeneratorProcesses();

	}*/

	[Test]
	public void startOneApp_TestInputArgs(){
		string test_output = "";
		string apk_dir_test = @"input\file\location\test.apk";
		string jsonblob_test = "testjsonblob";
		InstanceManager manager = new InstanceManager();
		test_output = manager.startOneApp(apk_dir_test, jsonblob_test);
		
		Assert.AreEqual(test_output, "Process started successfully");

	}

	public void ServerTest()
	{
		//yay server
		Server s = new Server("http://requestb.in/tfykibtf");
		Assert.AreEqual("http://requestb.in/tfykibtf", s.URL);

		string response = s.postMessage("Hello");
		Assert.AreEqual("ok", response);

		//faulty server
		s.URL = "http://requestb.in/1eh1";
		Assert.AreEqual("http://requestb.in/1eh1", s.URL);

		string response2 = s.postMessage("Hello");
		Assert.AreNotEqual("ok", response2);*/

	}

	[Test]
	public void testJsonHouse()
	{
		// Valid house
		string houseJSON = "{     \"houses\": [     {       \"name\": \"house1\",  \"id\": 0,     \"port\": 8081,       \"devices\": [         {           \"name\": \"light1\",           \"class\": \"LightSwitch\",           \"type\": \"Simulated\",           \"startState\": false         },         {            \"name\": \"Kitchen Ceiling Fan\",            \"class\": \"CeilingFan\",            \"type\": \"Simulated\",            \"Enabled\": false,            \"State\": 0         }       ],       \"rooms\": [         {           \"name\": \"Kitchen\",           \"dimensions\": {             \"x\": 100,             \"y\": 200           },           \"roomLevel\": 1,           \"doors\":           [             {               \"x\": 20,               \"y\": 200,               \"connectingRoom\": 1             }           ],           \"devices\":           [             1           ]         },         {           \"name\": \"Family Room\",           \"dimensions\": {             \"x\": 300,             \"y\": 200           },           \"roomLevel\": 1,           \"doors\":           [             {               \"x\": 20,               \"y\": 0,               \"connectingRoom\": 0             }           ],           \"devices\":           [             0           ]         }       ],       \"weather\":       [         {           \"Time\": \"2015-04-08T13:25:21.803833-04:00\",            \"Temp\": 50         },         {            \"Time\": \"2015-04-08T13:25:21.803833-04:00\",            \"Temp\": 30         }       ]     }   ]   }";

		JObject info = null;
		try
		{
			info = JObject.Parse(houseJSON);
		}
		catch(JsonException ex)
		{
			var error = String.Format("Scenario parsing error: {0}", ex.Message);
			Console.WriteLine(error);
			return;
		}

		JToken house_list;
		JsonHouse newHouse = null;
		// Get all houses
		if(info.TryGetValue("houses", out house_list))
		{
			IJEnumerable<JToken> houses = house_list.Children();

			foreach(JToken house in houses)
			{
				newHouse = new JsonHouse(house);
			}
		}

		Assert.AreEqual(0, newHouse.Id);
		Assert.AreEqual(false, newHouse.Error);
		Assert.AreEqual("house1", newHouse.Name);

		Console.WriteLine(newHouse.serverInfo());

		// No ID
		houseJSON = "{     \"houses\": [     {       \"name\": \"house1\",     \"port\": 8081,       \"devices\": [         {           \"name\": \"light1\",           \"class\": \"LightSwitch\",           \"type\": \"Simulated\",           \"startState\": false         },         {            \"name\": \"Kitchen Ceiling Fan\",            \"class\": \"CeilingFan\",            \"type\": \"Simulated\",            \"Enabled\": false,            \"State\": 0         }       ],       \"rooms\": [         {           \"name\": \"Kitchen\",           \"dimensions\": {             \"x\": 100,             \"y\": 200           },           \"roomLevel\": 1,           \"doors\":           [             {               \"x\": 20,               \"y\": 200,               \"connectingRoom\": 1             }           ],           \"devices\":           [             1           ]         },         {           \"name\": \"Family Room\",           \"dimensions\": {             \"x\": 300,             \"y\": 200           },           \"roomLevel\": 1,           \"doors\":           [             {               \"x\": 20,               \"y\": 0,               \"connectingRoom\": 0             }           ],           \"devices\":           [             0           ]         }       ],       \"weather\":       [         {           \"Time\": \"2015-04-08T13:25:21.803833-04:00\",            \"Temp\": 50         },         {            \"Time\": \"2015-04-08T13:25:21.803833-04:00\",            \"Temp\": 30         }       ]     }   ]   }";

		info = null;
		try
		{
			info = JObject.Parse(houseJSON);
		}
		catch(JsonException ex)
		{
			var error = String.Format("Scenario parsing error: {0}", ex.Message);
			Console.WriteLine(error);
			return;
		}
			
		// Get all houses
		if(info.TryGetValue("houses", out house_list))
		{
			IJEnumerable<JToken> houses = house_list.Children();

			foreach(JToken house in houses)
			{
				newHouse = new JsonHouse(house);
			}
		}

		Assert.AreEqual(0, newHouse.Id);
		Assert.AreEqual(true, newHouse.Error);
		Assert.AreEqual("house1", newHouse.Name);

		// No name
		houseJSON = "{     \"houses\": [     {           \"port\": 8081,       \"devices\": [         {           \"name\": \"light1\",           \"class\": \"LightSwitch\",           \"type\": \"Simulated\",           \"startState\": false         },         {            \"name\": \"Kitchen Ceiling Fan\",            \"class\": \"CeilingFan\",            \"type\": \"Simulated\",            \"Enabled\": false,            \"State\": 0         }       ],       \"rooms\": [         {           \"name\": \"Kitchen\",           \"dimensions\": {             \"x\": 100,             \"y\": 200           },           \"roomLevel\": 1,           \"doors\":           [             {               \"x\": 20,               \"y\": 200,               \"connectingRoom\": 1             }           ],           \"devices\":           [             1           ]         },         {           \"name\": \"Family Room\",           \"dimensions\": {             \"x\": 300,             \"y\": 200           },           \"roomLevel\": 1,           \"doors\":           [             {               \"x\": 20,               \"y\": 0,               \"connectingRoom\": 0             }           ],           \"devices\":           [             0           ]         }       ],       \"weather\":       [         {           \"Time\": \"2015-04-08T13:25:21.803833-04:00\",            \"Temp\": 50         },         {            \"Time\": \"2015-04-08T13:25:21.803833-04:00\",            \"Temp\": 30         }       ]     }   ]   }";

		info = null;
		try
		{
			info = JObject.Parse(houseJSON);
		}
		catch(JsonException ex)
		{
			var error = String.Format("Scenario parsing error: {0}", ex.Message);
			Console.WriteLine(error);
			return;
		}

		// Get all houses
		if(info.TryGetValue("houses", out house_list))
		{
			IJEnumerable<JToken> houses = house_list.Children();

			foreach(JToken house in houses)
			{
				newHouse = new JsonHouse(house);
			}
		}

		Assert.AreEqual(0, newHouse.Id);
		Assert.AreEqual(true, newHouse.Error);
		Assert.AreEqual("", newHouse.Name);


	}
		
	[Test]
	public void testJsonUser()
	{
		// Valid user
		string userJSON = "{      \"users\": [       {           \"Username\":\"User1\",           \"UserID\": \"0\",           \"Password\": \"thePassword\",           \"Coordinates\":           {               \"x\":\"1234\",               \"y\":\"4321\",               \"z\":\"6789\"           }       }       ]   }";

		JObject info = null;
		try
		{
			info = JObject.Parse(userJSON);
		}
		catch(JsonException ex)
		{
			var error = String.Format("Scenario parsing error: {0}", ex.Message);
			Console.WriteLine(error);
			return;
		}

		JToken user_list;
		JsonUser newUser = null;
		// Get all houses
		if(info.TryGetValue("users", out user_list))
		{
			IJEnumerable<JToken> users = user_list.Children();

			foreach(JToken user in users)
			{
				newUser = new JsonUser(user);
			}
		}

		Assert.AreEqual(0, newUser.Id);
		Assert.AreEqual(false, newUser.Error);
		Assert.AreEqual("User1", newUser.Name);
		Assert.AreEqual("thePassword", newUser.Password);

		Console.WriteLine(newUser.serverInfo());

		// No ID
		userJSON = "{      \"users\": [       {           \"Username\":\"User1\",        \"Password\": \"thePassword\",           \"Coordinates\":           {               \"x\":\"1234\",               \"y\":\"4321\",               \"z\":\"6789\"           }       }       ]   }";
		info = null;
		try
		{
			info = JObject.Parse(userJSON);
		}
		catch(JsonException ex)
		{
			var error = String.Format("Scenario parsing error: {0}", ex.Message);
			Console.WriteLine(error);
			return;
		}

		if(info.TryGetValue("users", out user_list))
		{
			IJEnumerable<JToken> users = user_list.Children();

			foreach(JToken user in users)
			{
				newUser = new JsonUser(user);
			}
		}

		Assert.AreEqual(0, newUser.Id);
		Assert.AreEqual(true, newUser.Error);
		Assert.AreEqual("User1", newUser.Name);
		Assert.AreEqual("thePassword", newUser.Password);


		// No name
		userJSON = "{      \"users\": [       {                \"UserID\": \"0\",           \"Password\": \"thePassword\",           \"Coordinates\":           {               \"x\":\"1234\",               \"y\":\"4321\",               \"z\":\"6789\"           }       }       ]   }";
		info = null;
		try
		{
			info = JObject.Parse(userJSON);
		}
		catch(JsonException ex)
		{
			var error = String.Format("Scenario parsing error: {0}", ex.Message);
			Console.WriteLine(error);
			return;
		}


		if(info.TryGetValue("users", out user_list))
		{
			IJEnumerable<JToken> users = user_list.Children();

			foreach(JToken user in users)
			{
				newUser = new JsonUser(user);
			}
		}

		Assert.AreEqual(0, newUser.Id);
		Assert.AreEqual(true, newUser.Error);
		Assert.AreEqual("", newUser.Name);
		Assert.AreEqual("thePassword", newUser.Password);


		// No Password
		userJSON = "{      \"users\": [       {           \"Username\":\"User1\",           \"UserID\": \"0\",           \"Coordinates\":           {               \"x\":\"1234\",               \"y\":\"4321\",               \"z\":\"6789\"           }       }       ]   }";
	
		try
		{
			info = JObject.Parse(userJSON);
		}
		catch(JsonException ex)
		{
			var error = String.Format("Scenario parsing error: {0}", ex.Message);
			Console.WriteLine(error);
			return;
		}

		// Get all houses
		if(info.TryGetValue("users", out user_list))
		{
			IJEnumerable<JToken> users = user_list.Children();

			foreach(JToken user in users)
			{
				newUser = new JsonUser(user);
			}
		}

		Assert.AreEqual(0, newUser.Id);
		Assert.AreEqual(true, newUser.Error);
		Assert.AreEqual("User1", newUser.Name);
		Assert.AreEqual("", newUser.Password);
	}

	[Test]
	public void testJsonFile()
	{
		// Valid string
		string jsonString = "{     \"storageLocation\": \"54.152.190.217\",     \"serverLocation\": \"52.5.95.215\",         \"users\": [         {             \"Username\":\"User1\",             \"UserID\": \"0\",             \"Password\": \"thePassword\",             \"Coordinates\":             {                 \"x\":\"1234\",                 \"y\":\"4321\",                 \"z\":\"6789\"             }          },         {             \"Username\": \"User2\",             \"UserID\": \"1\",             \"Password\": \"secondPassword\",             \"Coordinates\":             {                 \"x\":\"1234\",                 \"y\":\"4321\",                 \"z\":\"6789\"             }         }     ],     \"houses\": [     {       \"name\": \"house1\",       \"port\": 8081,       \"id\": 0,       \"devices\": [         {           \"name\": \"light1\",           \"class\": \"LightSwitch\",           \"type\": \"Simulated\",           \"startState\": false         },         {            \"name\": \"Kitchen Ceiling Fan\",            \"class\": \"CeilingFan\",            \"type\": \"Simulated\",            \"Enabled\": false,            \"State\": 0         }       ],       \"rooms\": [         {           \"name\": \"Kitchen\",           \"dimensions\": {             \"x\": 100,             \"y\": 200           },           \"roomLevel\": 1,           \"doors\":           [             {               \"x\": 20,               \"y\": 200,               \"connectingRoom\": 1             }           ],           \"devices\":           [             1           ]         },         {           \"name\": \"Family Room\",           \"dimensions\": {             \"x\": 300,             \"y\": 200           },           \"roomLevel\": 1,           \"doors\":           [             {               \"x\": 20,               \"y\": 0,               \"connectingRoom\": 0             }           ],           \"devices\":           [             0           ]         }       ],       \"weather\":       [         {           \"Time\": \"2015-04-08T13:25:21.803833-04:00\",            \"Temp\": 50         },         {            \"Time\": \"2015-04-08T13:25:21.803833-04:00\",            \"Temp\": 30         }       ]     }   ] }";
		JsonFile jsonFile = new JsonFile(jsonString);

		Assert.AreEqual(1, jsonFile.Houses.Count);
		Assert.AreEqual(false, jsonFile.Error);
		Assert.AreEqual(2, jsonFile.Users.Count);

		// Invalid user
		jsonString = "{     \"storageLocation\": \"54.152.190.217\",     \"serverLocation\": \"52.5.95.215\",         \"users\": [         {             \"Username\":\"User1\",             \"UserID\": \"0\",                \"Coordinates\":             {                 \"x\":\"1234\",                 \"y\":\"4321\",                 \"z\":\"6789\"             }          },         {             \"Username\": \"User2\",             \"UserID\": \"1\",             \"Password\": \"secondPassword\",             \"Coordinates\":             {                 \"x\":\"1234\",                 \"y\":\"4321\",                 \"z\":\"6789\"             }         }     ],     \"houses\": [     {       \"name\": \"house1\",       \"port\": 8081,       \"id\": 0,       \"devices\": [         {           \"name\": \"light1\",           \"class\": \"LightSwitch\",           \"type\": \"Simulated\",           \"startState\": false         },         {            \"name\": \"Kitchen Ceiling Fan\",            \"class\": \"CeilingFan\",            \"type\": \"Simulated\",            \"Enabled\": false,            \"State\": 0         }       ],       \"rooms\": [         {           \"name\": \"Kitchen\",           \"dimensions\": {             \"x\": 100,             \"y\": 200           },           \"roomLevel\": 1,           \"doors\":           [             {               \"x\": 20,               \"y\": 200,               \"connectingRoom\": 1             }           ],           \"devices\":           [             1           ]         },         {           \"name\": \"Family Room\",           \"dimensions\": {             \"x\": 300,             \"y\": 200           },           \"roomLevel\": 1,           \"doors\":           [             {               \"x\": 20,               \"y\": 0,               \"connectingRoom\": 0             }           ],           \"devices\":           [             0           ]         }       ],       \"weather\":       [         {           \"Time\": \"2015-04-08T13:25:21.803833-04:00\",            \"Temp\": 50         },         {            \"Time\": \"2015-04-08T13:25:21.803833-04:00\",            \"Temp\": 30         }       ]     }   ] }";
		jsonFile = new JsonFile(jsonString);

		Assert.AreEqual(1, jsonFile.Houses.Count);
		Assert.AreEqual(true, jsonFile.Error);
		Assert.AreEqual(2, jsonFile.Users.Count);

		// Invalid House
		jsonString = "{     \"storageLocation\": \"54.152.190.217\",     \"serverLocation\": \"52.5.95.215\",         \"users\": [         {             \"Username\":\"User1\",             \"UserID\": \"0\",             \"Password\": \"thePassword\",             \"Coordinates\":             {                 \"x\":\"1234\",                 \"y\":\"4321\",                 \"z\":\"6789\"             }          },         {             \"Username\": \"User2\",             \"UserID\": \"1\",             \"Password\": \"secondPassword\",             \"Coordinates\":             {                 \"x\":\"1234\",                 \"y\":\"4321\",                 \"z\":\"6789\"             }         }     ],     \"houses\": [     {      \"port\": 8081,       \"id\": 0,       \"devices\": [         {           \"name\": \"light1\",           \"class\": \"LightSwitch\",           \"type\": \"Simulated\",           \"startState\": false         },         {            \"name\": \"Kitchen Ceiling Fan\",            \"class\": \"CeilingFan\",            \"type\": \"Simulated\",            \"Enabled\": false,            \"State\": 0         }       ],       \"rooms\": [         {           \"name\": \"Kitchen\",           \"dimensions\": {             \"x\": 100,             \"y\": 200           },           \"roomLevel\": 1,           \"doors\":           [             {               \"x\": 20,               \"y\": 200,               \"connectingRoom\": 1             }           ],           \"devices\":           [             1           ]         },         {           \"name\": \"Family Room\",           \"dimensions\": {             \"x\": 300,             \"y\": 200           },           \"roomLevel\": 1,           \"doors\":           [             {               \"x\": 20,               \"y\": 0,               \"connectingRoom\": 0             }           ],           \"devices\":           [             0           ]         }       ],       \"weather\":       [         {           \"Time\": \"2015-04-08T13:25:21.803833-04:00\",            \"Temp\": 50         },         {            \"Time\": \"2015-04-08T13:25:21.803833-04:00\",            \"Temp\": 30         }       ]     }   ] }";
		jsonFile = new JsonFile(jsonString);

		Assert.AreEqual(1, jsonFile.Houses.Count);
		Assert.AreEqual(true, jsonFile.Error);
		Assert.AreEqual(2, jsonFile.Users.Count);

		// Invalid jsonFile
		jsonString = "     \"storageLocation\": \"54.152.190.217\",     \"serverLocation\": \"52.5.95.215\",         \"users\": [         {             \"Username\":\"User1\",             \"UserID\": \"0\",             \"Password\": \"thePassword\",             \"Coordinates\":             {                 \"x\":\"1234\",                 \"y\":\"4321\",                 \"z\":\"6789\"             }          },         {             \"Username\": \"User2\",             \"UserID\": \"1\",             \"Password\": \"secondPassword\",             \"Coordinates\":             {                 \"x\":\"1234\",                 \"y\":\"4321\",                 \"z\":\"6789\"             }         }     ],     \"houses\": [     {      \"port\": 8081,       \"id\": 0,       \"devices\": [         {           \"name\": \"light1\",           \"class\": \"LightSwitch\",           \"type\": \"Simulated\",           \"startState\": false         },         {            \"name\": \"Kitchen Ceiling Fan\",            \"class\": \"CeilingFan\",            \"type\": \"Simulated\",            \"Enabled\": false,            \"State\": 0         }       ],       \"rooms\": [         {           \"name\": \"Kitchen\",           \"dimensions\": {             \"x\": 100,             \"y\": 200           },           \"roomLevel\": 1,           \"doors\":           [             {               \"x\": 20,               \"y\": 200,               \"connectingRoom\": 1             }           ],           \"devices\":           [             1           ]         },         {           \"name\": \"Family Room\",           \"dimensions\": {             \"x\": 300,             \"y\": 200           },           \"roomLevel\": 1,           \"doors\":           [             {               \"x\": 20,               \"y\": 0,               \"connectingRoom\": 0             }           ],           \"devices\":           [             0           ]         }       ],       \"weather\":       [         {           \"Time\": \"2015-04-08T13:25:21.803833-04:00\",            \"Temp\": 50         },         {            \"Time\": \"2015-04-08T13:25:21.803833-04:00\",            \"Temp\": 30         }       ]     }   ] }";
		jsonFile = new JsonFile(jsonString);

		Assert.AreEqual(0, jsonFile.Houses.Count);
		Assert.AreEqual(true, jsonFile.Error);
		Assert.AreEqual(0, jsonFile.Users.Count);


	}

	/* 
	 * unit test
	 * verify that the program is able to start multiple house processes 
	*/
	[Test]
	public void multipleHouses() {
		InstanceManager manager = new InstanceManager();
		Assert.AreEqual(manager.getNumberHouses(), 0);
		/* Path below need to be changed to pass unit test on a different computer */
		const string app_path = "/Users/ningli/Desktop/5574G/Assignment7/ECE4574-SimHarnessExes/com.homeAutomationApp.apk";
		const string house_path = "/Users/ningli/Desktop/Automation_System/Devices/House/bin/Debug/House.exe";
		const string time_blob = "{\"WallEpoch\":\"2015-05-04T22:56:24.475282-04:00\",\"SimEpoch\":\"2015-05-04T01:59:00-04:00\",\"Rate\":4.0}";
		/* 
		 * read from a json blob that contains 2 houses 
		 * file path need to be changed to pass unit test on a different computer
		 */
		string json_blob = System.IO.File.ReadAllText(@"/Users/ningli/Desktop/5574G/Assignment7/sim_harness/scenarios/multipleHouse.json");
		manager.startGeneratorProcesses(app_path, house_path, time_blob, json_blob);
		/* verify that there are 2 process for houses */
		Assert.AreEqual(manager.getNumberHouses(), 2);
		/* kill all house processes */
		manager.killGeneratorProcesses();
		/* verify that there are no more houses */
		Assert.AreEqual(manager.getNumberHouses(), 0);
	}


	/*
	 * unit test
	 * verify that the program is able to handle invalid server url without crashing
	 */
	[Test]
	public void invalidServerURL() {
		/* invalid server url */
		const string url_bad = "www.invalidserver.net";
		Server server = new Server(url_bad);
		/* verify that when post message, results will be invalid */
		string msg = "{\"WallEpoch\":\"2015-05-04T22:56:24.475282-04:00\",\"SimEpoch\":\"2015-05-04T01:59:00-04:00\",\"Rate\":4.0}";
		Assert.AreEqual(server.postMessage(msg), "Invalid Server");
		/* good server url */
		const string url_good = "http://serverapi1.azurewebsites.net";
		Server server2 = new Server(url_good);
		/* verify that when post message, server will return 200 */
		Assert.AreEqual(server2.postMessage(msg), "OK");
	}

	/*
	 * unit test
	 * verify that when terminated, house process will update its status
	 */
	[Test]
	public void killHouse() {
		/* 
		 * read from a json blob that contains 2 houses 
		 * file path need to be changed to pass unit test on a different computer
		 */
		string json_blob = System.IO.File.ReadAllText(@"/Users/ningli/Desktop/5574G/Assignment7/sim_harness/scenarios/multipleHouse.json");
		const string house_path = "/Users/ningli/Desktop/Automation_System/Devices/House/bin/Debug/House.exe";

		Hats.Sim.SimHouse sh1 = new Hats.Sim.SimHouse(json_blob, house_path, "house 1");
		Hats.Sim.SimHouse sh2 = new Hats.Sim.SimHouse(json_blob, house_path, "house 2");
		sh1.Start();
		sh2.Start();
		/* verify that both process are running */
		Assert.AreEqual(sh1.isRunning(), true);
		Assert.AreEqual(sh2.isRunning(), true);
		/* kill one hosue process, verify that the process has stoped */
		sh1.Kill();
		/* verify that both process are running */
		Assert.AreEqual(sh1.isRunning(), false);
		Assert.AreEqual(sh2.isRunning(), true);
	}

}
}
