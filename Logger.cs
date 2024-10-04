using System;

namespace MauiAppWindowTest;

public class Logger
{

    public static void Log(string message)
    {
        #if ANDROID
        Android.Util.Log.Info("DUMMY-PROJ", message);
        #endif
    }
}
