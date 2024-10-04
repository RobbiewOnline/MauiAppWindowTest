
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

```
TBD
```

## Logging when not working

### Debug

```
TBD
```

### Release

```
TBD - Can't sodding re-create, but this is the scenario I'm trying hard to re-create!
```

