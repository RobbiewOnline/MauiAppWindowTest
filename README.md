
# MauiAppWindowTest

## Problem

 I noticed that whilst debugging the app starts successfully, but then when launched from the app icon (on the Android home screen), the dotnet purple background would appear but wouldn't display the first page.  If I quit & restart 3-4 times, then it starts working!

 The reason why I started this project was to try and re-create a problem I'm having in **release** mode on my app.  In my case the app behaves almost the same, the page isn't rendered but then eventually I get offered to close the app because it's not responding.  Occassionally when I launch the app it does proceed.

## How to re-create

 - Run in the debugger - it works, every time.
 - Quit 
 - Run from Android home screen
 - The app will launch, with dotnet purple background but will not show the initial page (set in App.xaml.cs in `return new Window(new MainPage());`)
 - Quit & restart x 3 - by now usually it starts working!

Note that whether you interactively click a button to transition to another page, or not, the app should transition to a blue-background page in 5 seconds.  When the app fails to transition it doesn't do this, but then the initial page isn't displayed either.  It's as though the call to `CreateWindow` doesn't happen, or constructing of the `MainPage` fails

## Environment

- DotNet 9 RC 1 (9.0.100-rc.1.24452.12)
- Building using JAVA_HOME=/Library/Java/JavaVirtualMachines/microsoft-17.jdk/Contents/Home
- Device is 
  - Samsung Galaxy S21 5G
  - One UI Version 6.1
  - Android version 14

## What about release mode?

This actually works fine, so in this re-production case it fails to launch unless the debugger is attached to the debug build (sometimes), but runs successfully in release mode.

In my actual project it launches in release, shows my initial page but refuses to transition to any other page. 

You can run in release via (change for your paths)

```
dotnet build -t:Run -p:Configuration=Release -f net9.0-android35.0 -p:AdbTarget=-s%20R5CR60D4ZPT -p:AndroidSdkDirectory="/Users/rob/Library/Android/sdk" -p:JavaSdkDirectory="/Library/Java/JavaVirtualMachines/microsoft-17.jdk/Contents/Home" /Users/rob/GitHub/MauiAppWindowTest/MauiAppWindowTest.csproj 
```

## Logging when working

(I press the button for red background whilst waiting for it to transition)

```
[DUMMY-PROJ] MainApplication - constructor hit
[DUMMY-PROJ] MainApplication - CreateMauiApp invoked
[DUMMY-PROJ] MauiProgram - CreateMauiApp creating builder..
[DUMMY-PROJ] MauiProgram - CreateMauiApp creating builder - adding debug
[DUMMY-PROJ] MauiProgram - CreateMauiApp creating builder - returning build
[DUMMY-PROJ] MainApplication - CreateMauiApp invoked - done
[DUMMY-PROJ] App - constructor
[DUMMY-PROJ] App - constructor - done
[DUMMY-PROJ] App - CreateWindow
[DUMMY-PROJ] MainPage - constructor
[DUMMY-PROJ] MainPage - constructor - starting background task
[DUMMY-PROJ] MainPage - constructor - starting background task - done
[DUMMY-PROJ] App - CreateWindow - target page prepped
[DUMMY-PROJ] MainPage - constructor - starting background task - waiting 5s
[DUMMY-PROJ] App - CreateWindow - window prepped, returning window
[DUMMY-PROJ] MainPage - RedPageViaWindowClicked, requesting transition on EDT
[DUMMY-PROJ] MainPage - ChangeRootPageOnEDT, requesting transition, ensuring on EDT
[DUMMY-PROJ] MainPage - ChangeRootPageOnEDT, now on EDT
[DUMMY-PROJ] MainPage - ChangeRootPageOnEDT, replacing window with page:MauiAppWindowTest.NextPage (colour:[Color: Red=1, Green=0, Blue=0, Alpha=1])
[DUMMY-PROJ] MainPage - ChangeRootPageOnEDT, transition done
[DUMMY-PROJ] MainPage - ChangeRootPageOnEDT - done
[DUMMY-PROJ] MainPage - RedPageViaWindowClicked, requesting transition on EDT - done
[DUMMY-PROJ] MainPage - constructor - on background task - creating new page
[DUMMY-PROJ] MainPage - constructor - on background task - requesting transition on EDT
[DUMMY-PROJ] MainPage - ChangeRootPageOnEDT, requesting transition, ensuring on EDT
[DUMMY-PROJ] MainPage - ChangeRootPageOnEDT - done
[DUMMY-PROJ] MainPage - constructor - on background task - requesting transition on EDT - done
[DUMMY-PROJ] MainPage - ChangeRootPageOnEDT, now on EDT
[DUMMY-PROJ] MainPage - ChangeRootPageOnEDT, replacing window with page:MauiAppWindowTest.NextPage (colour:[Color: Red=0, Green=0, Blue=1, Alpha=1])
[DUMMY-PROJ] MainPage - ChangeRootPageOnEDT, transition done
```

## Logging when not working

### Debug

Version running in DEBUG mode from VSCode...

```
10-04 16:55:28.711 16972 17020 I DUMMY-PROJ: MainPage - constructor - on background task - creating new page
10-04 16:55:28.745 16972 17062 D ProfileInstaller: Installing profile for com.companyname.mauiappwindowtest
10-04 16:55:28.746 16972 17020 I uiappwindowtest: Explicit concurrent copying GC freed 1247KB AllocSpace bytes, 4(144KB) LOS objects, 60% free, 4090KB/10234KB, paused 70us,20us total 18.300ms
10-04 16:55:28.750 16972 17020 I DUMMY-PROJ: MainPage - constructor - on background task - requesting transition on EDT
10-04 16:55:28.750 16972 17020 I DUMMY-PROJ: MainPage - ChangeRootPageOnEDT, requesting transition, ensuring on EDT
10-04 16:55:28.754 16972 17020 I DUMMY-PROJ: MainPage - ChangeRootPageOnEDT - done
10-04 16:55:28.754 16972 17020 I DUMMY-PROJ: MainPage - constructor - on background task - requesting transition on EDT - done
10-04 16:55:28.754 16972 16972 I DUMMY-PROJ: MainPage - ChangeRootPageOnEDT, now on EDT
10-04 16:55:28.760 16972 16972 I DUMMY-PROJ: MainPage - ChangeRootPageOnEDT, replacing window with page:MauiAppWindowTest.NextPage (colour:[Color: Red=0, Green=0, Blue=1, Alpha=1])
10-04 16:55:28.766 16972 16972 W WindowOnBackDispatcher: OnBackInvokedCallback is not enabled for the application.
10-04 16:55:28.766 16972 16972 W WindowOnBackDispatcher: Set 'android:enableOnBackInvokedCallback="true"' in the application manifest.
10-04 16:55:28.778  1073  1212 I VSyncReactor: Current= 60, Period= 60, hwcPeriod= 60
10-04 16:55:28.783 16972 16972 I DUMMY-PROJ: MainPage - ChangeRootPageOnEDT, transition done
```

Then I killed the app by OS menu, then swiping it away.

When I launched the app the splash screen appeared, but nothing transitioned and ***not one line*** of debugging was output!...

Instead here's the raw device [logcat logs](logcat.md) ...

### Release

```
TBD - Can't sodding re-create, but this is the scenario I'm trying hard to re-create!
```

