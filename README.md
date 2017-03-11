# HS.Logging

[![NuGet](https://img.shields.io/nuget/v/HS.Logging.svg)](https://www.nuget.org/packages/HS.Logging/)

Easy logging for C# in the form of a NUGET package. Code credit to HDT/HearthSim.

# Usage:

Choose a directory to be used for logs, and a name for your logs. Log files can end with .txt, .log, etc.

## Initializing log

```c#
var LogDir = Directory.GetCurrentDirectory();
var LogName = "TestLog.log";
Log.Initialize(LogDir, LogName);
```

If logName does not have an extension, it will have .txt appended to it.


## Logging 

Log.Inintialize MUST be called before doing anything. Recommended to put it in your startup code.

Using in a file:

```c#
using HS.Logging;
```

### Logging messages

code:

```c#
Log.Info("Info Text");
Log.Debug("Debug Text");
Log.Warn("Warn Text");
Log.Error("Error Text, manual");
Log.Error((Exception)ex);
```

Output Text:

```
11:35:13 PM|Info|Namespace.MethodName >> Info Text Here
11:35:18 PM|Debug|Namespace.MethodName >> Info Text Here
11:35:18 PM|Warn|Namespace.MethodName >> Info Text Here
11:35:18 PM|Error|Namespace.MethodName >> Info Text Here
11:36:05 PM|Error|PluginWrapper.Unload >> Collection Tracker:System.NullReferenceException: Object reference not set to an instance of an object.
   at Hearthstone_Collection_Tracker.HearthstoneCollectionTrackerPlugin.OnUnload()
   at Hearthstone_Deck_Tracker.Plugins.PluginWrapper.Unload() in C:\Users\hunte\Documents\Github\Judge2020-alt\Hearthstone-Deck-Tracker\Hearthstone Deck Tracker\Plugins\PluginWrapper.cs:line 157
```

