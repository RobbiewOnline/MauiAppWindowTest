# MauiAppWindowTest

## Problem

I'm finding that the 'new' way of using the Application.Current.Windows often returns an empty array after the app is backgrounded, likely due to requesting permissions from the user.

## How to re-create

 - Run the app (debug is fine)
 - The windows array is populated with one Window
 - Request the permission (the app is backgrounded)
 - When resuming the list of Windows is cleared

## Environment

- DotNet 9 RC 2 (9.0.100-rc.1.24452.12)
- Building using JAVA_HOME=/Library/Java/JavaVirtualMachines/microsoft-17.jdk/Contents/Home
- Device is 
  - Samsung Galaxy S21 5G
  - One UI Version 6.1
  - Android version 14


