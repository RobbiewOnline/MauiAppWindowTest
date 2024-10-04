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

When I launched the app the splash screen appeared, but nothing transitioned and not one line of debugging was output!...

```
10-04 16:55:28.821  1073  1073 I HWComposer: [4633128672291735937] ActiveConfigToHWC, ID : 0
10-04 16:55:28.821   975  1036 I display : Set Affinity config for fps(120) : 0, cpuIDs : 255
10-04 16:55:28.821   975  1036 I display : Set Affinity CPU ID : 0
10-04 16:55:28.821   975  1036 I display : Set Affinity CPU ID : 1
10-04 16:55:28.821   975  1036 I display : Set Affinity CPU ID : 2
10-04 16:55:28.821   975  1036 I display : Set Affinity CPU ID : 3
10-04 16:55:28.821   975  1036 I display : Set Affinity CPU ID : 4
10-04 16:55:28.821   975  1036 I display : Set Affinity CPU ID : 5
10-04 16:55:28.822   975  1036 I display : Set Affinity CPU ID : 6
10-04 16:55:28.822   975  1036 I display : Set Affinity CPU ID : 7
10-04 16:55:28.822   975  1036 I display : Set affinity HWC : 975
10-04 16:55:28.822   975  1036 I display : CPU set : Cluster(0), min_clock(0)
10-04 16:55:28.822   975  1036 I display : CPU set : Cluster(1), min_clock(0)
10-04 16:55:28.822   975  1036 I display : CPU set : Cluster(2), min_clock(0)
10-04 16:55:28.823  1073  1073 I LayerHistory: com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity$_16972#5551 Max (can't resolve refresh rate)
10-04 16:55:28.823  1073  1073 I SurfaceFlinger: scored - choose 120.00 Hz
10-04 16:55:28.828   975  1033 I display : doDisplayConfigPostProcess needSetActiveConfig is true - mDesiredConfig: 0
10-04 16:55:28.828   975  1033 I display : setActiveConfig(config=0)
10-04 16:55:28.828   975  1033 I display : next config(0): width=1080 height=2400 period=8333333 Xdpi=422030 Ydpi=423333 groupId=0
10-04 16:55:28.828   975  1033 I display : Current VRR MODE is 3
10-04 16:55:28.828  1073  1212 I VSyncReactor: Current= 60, Period= 120, hwcPeriod= 60
10-04 16:55:28.845  1073  1212 I VSyncReactor: Current= 60, Period= 120, hwcPeriod= 120
10-04 16:55:29.076  1073  1073 I HWComposer: [4633128672291735937] ActiveConfigToHWC, ID : 2
10-04 16:55:29.077   975  1036 I display : Set Affinity config for fps(60) : 2, cpuIDs : 255
10-04 16:55:29.077   975  1036 I display : Set Affinity CPU ID : 0
10-04 16:55:29.077   975  1036 I display : Set Affinity CPU ID : 1
10-04 16:55:29.077   975  1036 I display : Set Affinity CPU ID : 2
10-04 16:55:29.077   975  1036 I display : Set Affinity CPU ID : 3
10-04 16:55:29.077   975  1036 I display : Set Affinity CPU ID : 4
10-04 16:55:29.077   975  1036 I display : Set Affinity CPU ID : 5
10-04 16:55:29.077   975  1036 I display : Set Affinity CPU ID : 6
10-04 16:55:29.078   975  1036 I display : Set Affinity CPU ID : 7
10-04 16:55:29.078   975  1036 I display : Set affinity HWC : 975
10-04 16:55:29.078   975  1036 I display : CPU set : Cluster(0), min_clock(0)
10-04 16:55:29.078   975  1036 I display : CPU set : Cluster(1), min_clock(0)
10-04 16:55:29.078   975  1036 I display : CPU set : Cluster(2), min_clock(0)
10-04 16:55:29.079  1073  1073 I LayerHistory: com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity$_16972#5551 Max (can't resolve refresh rate)
10-04 16:55:29.079  1073  1073 I SurfaceFlinger: Idle - choose 60.00 Hz
10-04 16:55:29.082   975  1033 I display : doDisplayConfigPostProcess needSetActiveConfig is true - mDesiredConfig: 2
10-04 16:55:29.082   975  1033 I display : setActiveConfig(config=2)
10-04 16:55:29.082   975  1033 I display : next config(2): width=1080 height=2400 period=16666666 Xdpi=422030 Ydpi=423333 groupId=0
10-04 16:55:29.082   975  1033 I display : Current VRR MODE is 3
10-04 16:55:29.082  1073  1212 I VSyncReactor: Current= 120, Period= 60, hwcPeriod= 120
10-04 16:55:29.087  1073  1212 I VSyncReactor: Current= 120, Period= 60, hwcPeriod= 60
10-04 16:55:29.969  3956 16894 I NearbyMediums: No BLE Fast/GATT advertisements found in the latest cycle.
10-04 16:55:29.977  1427  3647 D SemWifiUsabilityStatsMonitor: onWifiUsabilityStats - seqNum 23123, isSameBssidAndFreq true
10-04 16:55:29.980  2042  2042 D StatusBarIconController: ignoring old pipeline callback because the new wifi icon is enabled
10-04 16:55:29.991  1073  1212 I VSyncReactor: Current= 60, Period= 60, hwcPeriod= 60
10-04 16:55:30.007  1073  1212 I VSyncReactor: Current= 60, Period= 120, hwcPeriod= 60
10-04 16:55:30.017  1073  1073 I HWComposer: [4633128672291735937] ActiveConfigToHWC, ID : 0
10-04 16:55:30.018   975  1036 I display : Set Affinity config for fps(120) : 0, cpuIDs : 255
10-04 16:55:30.018   975  1036 I display : Set Affinity CPU ID : 0
10-04 16:55:30.018   975  1036 I display : Set Affinity CPU ID : 1
10-04 16:55:30.018   975  1036 I display : Set Affinity CPU ID : 2
10-04 16:55:30.018   975  1036 I display : Set Affinity CPU ID : 3
10-04 16:55:30.018   975  1036 I display : Set Affinity CPU ID : 4
10-04 16:55:30.018   975  1036 I display : Set Affinity CPU ID : 5
10-04 16:55:30.018   975  1036 I display : Set Affinity CPU ID : 6
10-04 16:55:30.018   975  1036 I display : Set Affinity CPU ID : 7
10-04 16:55:30.018   975  1036 I display : Set affinity HWC : 975
10-04 16:55:30.018   975  1036 I display : CPU set : Cluster(0), min_clock(0)
10-04 16:55:30.018   975  1036 I display : CPU set : Cluster(1), min_clock(0)
10-04 16:55:30.018   975  1036 I display : CPU set : Cluster(2), min_clock(0)
10-04 16:55:30.019  1073  1073 I LayerHistory: StatusBar$_2042#89 voted 0, 0.00 fps
10-04 16:55:30.019  1073  1073 I LayerHistory: com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity$_16972#5551 Max (can't resolve refresh rate)
10-04 16:55:30.019  1073  1073 I SurfaceFlinger: scored - choose 120.00 Hz
10-04 16:55:30.023   975  1033 I display : doDisplayConfigPostProcess needSetActiveConfig is true - mDesiredConfig: 0
10-04 16:55:30.024   975  1033 I display : setActiveConfig(config=0)
10-04 16:55:30.024   975  1033 I display : next config(0): width=1080 height=2400 period=8333333 Xdpi=422030 Ydpi=423333 groupId=0
10-04 16:55:30.024   975  1033 I display : Current VRR MODE is 3
10-04 16:55:30.024  1073  1212 I VSyncReactor: Current= 60, Period= 120, hwcPeriod= 60
10-04 16:55:30.041  1073  1212 I VSyncReactor: Current= 60, Period= 120, hwcPeriod= 120
10-04 16:55:30.262  1073  1073 I HWComposer: [4633128672291735937] ActiveConfigToHWC, ID : 2
10-04 16:55:30.263   975  1036 I display : Set Affinity config for fps(60) : 2, cpuIDs : 255
10-04 16:55:30.264   975  1036 I display : Set Affinity CPU ID : 0
10-04 16:55:30.264   975  1036 I display : Set Affinity CPU ID : 1
10-04 16:55:30.264   975  1036 I display : Set Affinity CPU ID : 2
10-04 16:55:30.264   975  1036 I display : Set Affinity CPU ID : 3
10-04 16:55:30.264   975  1036 I display : Set Affinity CPU ID : 4
10-04 16:55:30.264   975  1036 I display : Set Affinity CPU ID : 5
10-04 16:55:30.264   975  1036 I display : Set Affinity CPU ID : 6
10-04 16:55:30.264   975  1036 I display : Set Affinity CPU ID : 7
10-04 16:55:30.264   975  1036 I display : Set affinity HWC : 975
10-04 16:55:30.264   975  1036 I display : CPU set : Cluster(0), min_clock(0)
10-04 16:55:30.265   975  1036 I display : CPU set : Cluster(1), min_clock(0)
10-04 16:55:30.265   975  1036 I display : CPU set : Cluster(2), min_clock(0)
10-04 16:55:30.265  1073  1073 I LayerHistory: StatusBar$_2042#89 voted 0, 0.00 fps
10-04 16:55:30.265  1073  1073 I SurfaceFlinger: Idle - choose 60.00 Hz
10-04 16:55:30.267   975  1033 I display : doDisplayConfigPostProcess needSetActiveConfig is true - mDesiredConfig: 2
10-04 16:55:30.267   975  1033 I display : setActiveConfig(config=2)
10-04 16:55:30.267   975  1033 I display : next config(2): width=1080 height=2400 period=16666666 Xdpi=422030 Ydpi=423333 groupId=0
10-04 16:55:30.267   975  1033 I display : Current VRR MODE is 3
10-04 16:55:30.268  1073  1212 I VSyncReactor: Current= 120, Period= 60, hwcPeriod= 120
10-04 16:55:30.276  1073  1212 I VSyncReactor: Current= 120, Period= 60, hwcPeriod= 60
10-04 16:55:30.463  3993  3993 D BoundBrokerSvc: onBind: Intent { act=com.google.android.gms.safetynet.service.START pkg=com.google.android.gms }
10-04 16:55:30.463  3993  3993 D BoundBrokerSvc: Loading bound service for intent: Intent { act=com.google.android.gms.safetynet.service.START pkg=com.google.android.gms }
--------- beginning of system
10-04 16:55:30.576  3946  3946 I SDHMS:LOAD: type: LoadsFreqs, value: 0:24:0:1312739:2912000:0:1392559:2808000:0:12:403:0
10-04 16:55:31.033  1427  2275 E KernelCpuUidFullTimeReader: Negative delta from freq time for uid: 90000, delta: -15
10-04 16:55:31.033  1427  2275 E KernelCpuUidFullTimeReader: Negative delta from freq time for uid: 90001, delta: -16
10-04 16:55:31.033  1427  2275 D CustomizedBinderCallsStatsInternal: reportCpuUsage() : 0%
10-04 16:55:31.033  1427  1587 I BinderCallsStats: Collected cpu time : 0us, collected call count : 0 for 156068342 ms
10-04 16:55:31.314  1052  1241 I EDEN    : [Exynos][EDEN][v1.6.23][SERVICE] processAliveMointorMain:253: Try to check pid=(1004)...
10-04 16:55:31.658   986   986 I Sensors : batch(19) - light_cct_sensor try to batching with 200000000
10-04 16:55:31.662   986   986 I Sensors : LightCCT_Sensor old sensor_state 16896, new sensor_state : 1550332870017536 en : 1
10-04 16:55:31.664   986   986 I Sensors : enable:: light_cct_sensor(19)
10-04 16:55:31.665  1427  1872 D SensorManager: registerListener :: 33, TMD4912 Light CCT, 200000, 0, com.samsung.android.displaysolution.EyeComfortSolutionService$2@8da8bbd
10-04 16:55:31.703   986  1743 I Sensors : lux = 122, CCT = 0, r = 3201, g = 376, b = 3419, c = 585, atime = 350, again = 512, lux_raw = 123, brightness = 100, time = 156085555042847
10-04 16:55:31.706   986   986 I Sensors : LightCCT_Sensor old sensor_state 16896, new sensor_state : 1550328575050240 en : 0
10-04 16:55:31.710   986   986 I Sensors : disable:: light_cct_sensor(19)
10-04 16:55:31.711  1427  1872 D SensorManager: unregisterListener :: com.samsung.android.displaysolution.EyeComfortSolutionService$2@8da8bbd
10-04 16:55:31.798   676   676 D io_stats: !@   8,0 r 706545 27994032 w 792633 17793696 d 216544 120716844 f 0 0 iot 796776 0 th 0 0 0 pt 0 inp 0 0 89540.266
10-04 16:55:31.798   676   676 D io_stats: !@ Write_top(KB): system_server(1427) 256
10-04 16:55:32.849   937   937 E audit   : type=1400 audit(1728057332.843:15502): avc:  denied  { ioctl } for  pid=3956 comm="lowpool[510]" path="/data/data/com.google.android.gms/databases/rmq.db" dev="dm-52" ino=7655 ioctlcmd=0xf522 scontext=u:r:gmscore_app:s0:c512,c768 tcontext=u:object_r:privapp_data_file:s0:c512,c768 tclass=file permissive=0 SEPF_SM-G991B_12_0001 audit_filtered
10-04 16:55:32.849   937   937 E audit   : type=1300 audit(1728057332.843:15502): arch=c00000b7 syscall=29 success=no exit=-13 a0=67 a1=f522 a2=7ad33c1868 a3=b40000794d4297c0 items=0 ppid=959 pid=3956 auid=4294967295 uid=10227 gid=10227 euid=10227 suid=10227 fsuid=10227 egid=10227 sgid=10227 fsgid=10227 tty=(none) ses=4294967295 comm="lowpool[510]" exe="/system/bin/app_process64" subj=u:r:gmscore_app:s0:c512,c768 key=(null)
10-04 16:55:32.849   937   937 E audit   : type=1327 audit(1728057332.843:15502): proctitle="com.google.android.gms.persistent"
10-04 16:55:32.860  3956 16895 D ConnectivityManager: StackLog: [android.net.ConnectivityManager.reportNetworkConnectivity(ConnectivityManager.java:3665)] [bcfy.a(:com.google.android.gms@243834030@24.38.34 (190408-681941525):15)] [bcie.o(:com.google.android.gms@243834030@24.38.34 (190408-681941525):6)] [bchs.run(:com.google.android.gms@243834030@24.38.34 (190408-681941525):590)] [bcim.run(:com.google.android.gms@243834030@24.38.34 (190408-681941525):5)] [esgc.run(:com.google.android.gms@243834030@24.38.34 (190408-681941525):21)] [anih.c(:com.google.android.gms@243834030@24.38.34 (190408-681941525):50)] [anih.run(:com.google.android.gms@243834030@24.38.34 (190408-681941525):76)] [java.util.concurrent.ThreadPoolExecutor.runWorker(ThreadPoolExecutor.java:1145)] [java.util.concurrent.ThreadPoolExecutor$Worker.run(ThreadPoolExecutor.java:644)] [anns.run(:com.google.android.gms@243834030@24.38.34 (190408-681941525):8)] [java.lang.Thread.run(Thread.java:1012)]
10-04 16:55:32.869  3956 16895 I AlarmManager: setExactAndAllowWhileIdle [name: GCM_HB_ALARM type: 2 triggerAtMillis: 157816728]
10-04 16:55:32.870  1427  2275 D AlarmManager: force change alarm method to setWindow() callingUid=10227, sourcePackage=com.google.android.gms, action=com.google.android.gms.gcm.HEARTBEAT_ALARM, origTriggerAtTime=157816728, triggerAtTime=156951728, windowLength=865000
10-04 16:55:32.870  1427  2275 D CompatibilityChangeReporter: Compat change id reported: 171306433; UID 10227; state: ENABLED
10-04 16:55:32.903  3956 15067 I AlarmManager: setExactAndAllowWhileIdle [name: FcmRetry type: 2 triggerAtMillis: 156206753]
10-04 16:55:32.903  1427  2275 D CompatibilityChangeReporter: Compat change id reported: 218533173; UID 10227; state: ENABLED
10-04 16:55:32.905  3956 16895 I AlarmManager: setExactAndAllowWhileIdle [name: GCM_HB_ALARM type: 2 triggerAtMillis: 157816764]
10-04 16:55:32.905  1427  1472 D AlarmManager: force change alarm method to setWindow() callingUid=10227, sourcePackage=com.google.android.gms, action=com.google.android.gms.gcm.HEARTBEAT_ALARM, origTriggerAtTime=157816764, triggerAtTime=156951764, windowLength=865000
10-04 16:55:32.918  7973  7973 I GnpSdk  : (REDACTED) Intent received for action [%s] package [%s].
10-04 16:55:32.918  7973  7973 I GnpSdk  : Phenotype initialized.
10-04 16:55:32.919  7973  7973 I GnpSdk  : BroadcastReceiver disabled by host app in GnpConfig
10-04 16:55:32.919  1427  1588 W ProcessStats: Tracking association SourceState{b71e49e com.google.android.googlequicksearchbox:search/10237 Receivr #85075} whose proc state 10 is better than process ProcessState{cc2ff62 com.google.android.adservices.api/10263 pkg=com.google.android.adservices.api} proc state 14 (16 skipped)
10-04 16:55:32.922   937   937 E audit   : type=1400 audit(1728057332.915:15503): avc:  denied  { ioctl } for  pid=3956 comm="lowpool[497]" path="/data/data/com.google.android.gms/databases/phenotype.db" dev="dm-52" ino=3663 ioctlcmd=0xf522 scontext=u:r:gmscore_app:s0:c512,c768 tcontext=u:object_r:privapp_data_file:s0:c512,c768 tclass=file permissive=0 SEPF_SM-G991B_12_0001 audit_filtered
10-04 16:55:32.922   937   937 E audit   : type=1300 audit(1728057332.915:15503): arch=c00000b7 syscall=29 success=no exit=-13 a0=7a a1=f522 a2=7ad33c1868 a3=b40000794d40b4c0 items=0 ppid=959 pid=3956 auid=4294967295 uid=10227 gid=10227 euid=10227 suid=10227 fsuid=10227 egid=10227 sgid=10227 fsgid=10227 tty=(none) ses=4294967295 comm="lowpool[497]" exe="/system/bin/app_process64" subj=u:r:gmscore_app:s0:c512,c768 key=(null)
10-04 16:55:32.927  7973 17094 E FirebaseMessaging: Default FirebaseApp has not been initialized. Skip logging event to GA.
10-04 16:55:32.927  7973 17094 I FirebaseMessaging: FirebaseApp has not being initialized. Device might be in direct boot mode. Skip exporting delivery metrics to Big Query
10-04 16:55:32.966  7973 17097 I A       : Chime Filter is invoked.
10-04 16:55:32.973  7973  8005 I A       : Notification was not filtered.
10-04 16:55:32.980  7973 17097 I GnpSdk  : (REDACTED) Setting channel Id: '%s'
10-04 16:55:33.000  7973 17097 I GnpSdk  : (REDACTED) Setting channel Id: '%s'
10-04 16:55:33.005  7973 17097 I NotificationManager: com.google.android.googlequicksearchbox: notify(0, 161924996::SUMMARY::wx, Notification(channel=71 shortcut=null contentView=null vibrate=null sound=null defaults=0x0 flags=0x200 color=0x00000000 groupKey=161924996::SUMMARY::wx vis=PRIVATE publicVersion=Notification(channel=null shortcut=null contentView=null vibrate=null sound=null defaults=0x0 flags=0x0 color=0x00000000 vis=PRIVATE semFlags=0x0 semPriority=0 semMissedCount=0) semFlags=0x0 semPriority=0 semMissedCount=0)) as user
10-04 16:55:33.009  7973 17097 I NotificationManager: com.google.android.googlequicksearchbox: notify(0, 161924996::a:snotification:[0x394,wx.f,NOTIFICATION], Notification(channel=71 shortcut=null contentView=null vibrate=null sound=null tick defaults=0x0 flags=0x8 color=0x00000000 groupKey=161924996::SUMMARY::wx vis=PRIVATE semFlags=0x0 semPriority=0 semMissedCount=0)) as user
10-04 16:55:33.021  1427  3647 D SemWifiUsabilityStatsMonitor: onWifiUsabilityStats - seqNum 23124, isSameBssidAndFreq true
10-04 16:55:33.030  7973 17094 I GnpSdk  : Message handled by GNP Firebase handler.
10-04 16:55:33.049  7973  8005 I TngGcmBroadcastReceiver: #onReceiveInternal: Received GNP payload, returning.
10-04 16:55:33.131  2118  2118 I EPDG -- SIM1 [EpdgIntfCont]: Not Mobile Interface. Ignoring Event
10-04 16:55:33.131  2118  2118 I EPDG -- SIM1 [EpdgIntfCont]: Not Mobile Interface. Ignoring Event
10-04 16:55:33.131  2118  2118 I EPDG -- SIM0 [EpdgIntfCont]: Not Mobile Interface. Ignoring Event
10-04 16:55:33.131  2118  2118 I EPDG -- SIM0 [EpdgIntfCont]: Not Mobile Interface. Ignoring Event
10-04 16:55:33.213  1427  1427 I Telecom:SamsungTelecomServiceImpl: isInManagedCall - callingPackage : android / callingUser : UserHandle{0} / hasCrossUserAccess : true
10-04 16:55:33.220  1427  1427 I Telecom:SamsungTelecomServiceImpl: isInManagedCall - callingPackage : android / callingUser : UserHandle{0} / hasCrossUserAccess : true
10-04 16:55:33.229  2453  2453 I HoneySpace.NotificationListener: onNotificationPosted com.google.android.googlequicksearchbox: 0|com.google.android.googlequicksearchbox|0|161924996::SUMMARY::wx|10237: 0
10-04 16:55:33.229  2453  2453 I HoneySpace.NotificationListener: invalid notification: com.google.android.googlequicksearchbox UserHandle{0}: canShowBadge is false
10-04 16:55:33.230  2453 15403 I HoneySpace.PackageEventOperator: [AbsFolderViewModel|7] badge count is updated. com.google.android.googlequicksearchbox/.SearchActivity#UserHandle{0}|8 : 0
10-04 16:55:33.230  2453 15946 I HoneySpace.PackageEventOperator: [AbsFolderViewModel|53] badge count is updated. com.google.android.googlequicksearchbox/.SearchActivity#UserHandle{0}|54 : 0
10-04 16:55:33.230  2453 15403 I HoneySpace.PackageEventOperator: [WorkspaceViewModel] badge count is updated. com.google.android.googlequicksearchbox/.SearchActivity#UserHandle{0}|8 : 0
10-04 16:55:33.230  2453 15946 I HoneySpace.PackageEventOperator: [ApplistViewModel] badge count is updated. com.google.android.googlequicksearchbox/.SearchActivity#UserHandle{0}|54 : 0
10-04 16:55:33.230  2453 15403 I HoneySpace.BadgeDataSourceImpl: Get notification count. PackageKey(packageName=com.google.android.gm, user=UserHandle{0}) - forceBadgeCount: false, notification listener: 1, badge provider: 0
10-04 16:55:33.230  2453 15946 I HoneySpace.BadgeDataSourceImpl: Get notification count. PackageKey(packageName=com.google.android.gm, user=UserHandle{0}) - forceBadgeCount: false, notification listener: 1, badge provider: 0
10-04 16:55:33.233  2453  2453 I HoneySpace.NotificationListener: onNotificationPosted com.google.android.googlequicksearchbox: 0|com.google.android.googlequicksearchbox|0|161924996::a:snotification:[0x394,wx.f,NOTIFICATION]|10237: 0
10-04 16:55:33.233  2453  2453 I HoneySpace.NotificationListener: invalid notification: com.google.android.googlequicksearchbox UserHandle{0}: canShowBadge is false
10-04 16:55:33.233  2453 12442 I HoneySpace.PackageEventOperator: [AbsFolderViewModel|7] badge count is updated. com.google.android.googlequicksearchbox/.SearchActivity#UserHandle{0}|8 : 0
10-04 16:55:33.233  2453 15967 I HoneySpace.PackageEventOperator: [AbsFolderViewModel|53] badge count is updated. com.google.android.googlequicksearchbox/.SearchActivity#UserHandle{0}|54 : 0
10-04 16:55:33.233  2453 15946 I HoneySpace.PackageEventOperator: [WorkspaceViewModel] badge count is updated. com.google.android.googlequicksearchbox/.SearchActivity#UserHandle{0}|8 : 0
10-04 16:55:33.233  2453 15946 I HoneySpace.BadgeDataSourceImpl: Get notification count. PackageKey(packageName=com.google.android.gm, user=UserHandle{0}) - forceBadgeCount: false, notification listener: 1, badge provider: 0
10-04 16:55:33.233  2453 12442 I HoneySpace.PackageEventOperator: [ApplistViewModel] badge count is updated. com.google.android.googlequicksearchbox/.SearchActivity#UserHandle{0}|54 : 0
10-04 16:55:33.233  2453 12442 I HoneySpace.BadgeDataSourceImpl: Get notification count. PackageKey(packageName=com.google.android.gm, user=UserHandle{0}) - forceBadgeCount: false, notification listener: 1, badge provider: 0
10-04 16:55:33.246  2042  2042 I AODNotificationManager: updateNotification() 
10-04 16:55:33.252  1073  1212 I VSyncReactor: Current= 60, Period= 60, hwcPeriod= 60
10-04 16:55:33.254  1427  1581 D LocalDisplayAdapter: updateActiveModeLocked for d=4633128672291735937, mActiveModeId=3, mActiveSfDisplayMode=DisplayMode{id=2, width=1080, height=2400, xDpi=422.03, yDpi=423.333, refreshRate=60.000004, appVsyncOffsetNanos=0, presentationDeadlineNanos=17666666, supportedHdrTypes=[2, 3, 4], group=0}
10-04 16:55:33.255  1427  1581 I DisplayDeviceRepository: Display device changed: DisplayDeviceInfo{"Built-in Screen": uniqueId="local:4633128672291735937", 1080 x 2400, modeId 3, renderFrameRate 60.000004, defaultModeId 3, supportedModes [{id=1, width=1080, height=2400, fps=120.00001, alternativeRefreshRates=[48.000004, 60.000004, 96.00001], supportedHdrTypes=[2, 3, 4]}, {id=2, width=1080, height=2400, fps=96.00001, alternativeRefreshRates=[48.000004, 60.000004, 120.00001], supportedHdrTypes=[2, 3, 4]}, {id=3, width=1080, height=2400, fps=60.000004, alternativeRefreshRates=[48.000004, 96.00001, 120.00001], supportedHdrTypes=[2, 3, 4]}, {id=4, width=1080, height=2400, fps=48.000004, alternativeRefreshRates=[60.000004, 96.00001, 120.00001], supportedHdrTypes=[2, 3, 4]}], colorMode 0, supportedColorModes [0, 6, 7], hdrCapabilities HdrCapabilities{mSupportedHdrTypes=[2, 3, 4], mMaxLuminance=450.0, mMaxAverageLuminance=120.0, mMinLuminance=5.0E-4}, allmSupported false, gameContentTypeSupported false, density 480, 422.03 x 423.333 dpi, appVsyncOff 0, presDeadline 17666666, cutout DisplayCutout{insets=Rect(0, 80 - 0, 0) waterfall=Insets{left=0, top=0, right=0, bottom=0} boundingRect={Bounds=[Rect(0, 0 - 0, 0), Rect(510, 0 - 570, 80), Rect(0, 0 - 0, 0), Rect(0, 0 - 0, 0)]} cutoutPathParserInfo={CutoutPathParserInfo{displayWidth=1080 displayHeight=2400 physicalDisplayWidth=1080 physicalDisplayHeight=2400 density={3.0} cutoutSpec={M 0,0 H -10 V 26.66666666666667 H 10 V 0 H 0 Z @dp} rotation={0} scale={1.0} physicalPixelDisplaySizeRatio={1.0}}}}, touch INTERNAL, rotation 0, type INTERNAL, address {port=129, model=0x404c2dfae6a049}, deviceProductInfo DeviceProductInfo{name=samsung lcd  , manufacturerPnpId=SAM, productId=0, modelYear=null, manufactureDate=ManufactureDate{week=16, year=2020}, connectionToSinkType=0}, state ON, committedState ON, frameRateOverride , brightnessMinimum 0.0, brightnessMaximum 1.0, brightnessDefault 0.5019608, hdrSdrRatio NaN, roundedCorners RoundedCorners{[RoundedCorner{position=TopLeft, radius=90, center=Point(90, 90)}, RoundedCorner{position=TopRight, radius=90, center=Point(990, 90)}, RoundedCorner{position=BottomRight, radius=90, center=Point(990, 2310)}, RoundedCorner{position=BottomLeft, radius=90, center=Point(90, 2310)}]}, FLAG_ALLOWED_TO_BE_DEFAULT_DISPLAY, FLAG_ROTATES_WITH_CONTENT, FLAG_SECURE, FLAG_SUPPORTS_PROTECTED_BUFFERS, FLAG_TRUSTED, installOrientation 0, displayShape DisplayShape{ spec=-311912193 displayWidth=1080 displayHeight=2400 physicalPixelDisplaySizeRatio=1.0 rotation=0 offsetX=0 offsetY=0 scale=1.0}}
10-04 16:55:33.258  1073  1073 I SurfaceFlinger: SFWD update time=89541727363491
10-04 16:55:33.259  1427  3269 D LiftUpHandler: [LTW] Stopped already.
10-04 16:55:33.260  1427  1427 D SGM:GameManager: onDisplayChanged. displyId: 0, state: 2
10-04 16:55:33.260  1427  1807 D SGM:FgCheckThread: onLooperPrepared(), msg: MSG_LCD_ON
10-04 16:55:33.260  1427  1427 D MotionRecognitionService: [DisplayListener] getRefreshRate 60.000004
10-04 16:55:33.260  1427  1427 D AODManagerService: requestReCalToTSP IsSingleTouchMode = falserequestedReCalToTSP = false / previousDisplayState = ON
10-04 16:55:33.261  1427  1828 D MotionRecognitionService: Inject RefreshRate: 60
10-04 16:55:33.261  1427  1828 D SensorService: setSContextDataLocked ints length 3 , byte length 8
10-04 16:55:33.261  1427  1828 D SensorService: setSContextDataLocked 100048c1
10-04 16:55:33.262   986   986 D Sensors : c1 48 00 10 3c 00 00 00  
10-04 16:55:33.262   986   986 E Sensors : inject_scontext_data: New ssp_data_injection_fd(44)
10-04 16:55:33.263   986   986 D Sensors : SContext Data Injection return 8
10-04 16:55:33.263  2042  2247 D StackScroller: onDisplayChanged for predraw skip to 2
10-04 16:55:33.263  2042  2164 I ViewRootImpl@e11db90[ShellDropTarget]: onDisplayChanged oldDisplayState=2 newDisplayState=2
10-04 16:55:33.264  2042  3044 I ViewRootImpl@3eb5874[ScreenDecorOverlay]: onDisplayChanged oldDisplayState=2 newDisplayState=2
10-04 16:55:33.264  2042  3044 I ViewRootImpl@403463c[ScreenDecorOverlayBottom]: onDisplayChanged oldDisplayState=2 newDisplayState=2
10-04 16:55:33.264  1427  1581 D DisplayManagerService: Ignore redundant display event 0/2 to 10251/5386
10-04 16:55:33.264  1427  1581 D DisplayManagerService: Ignore redundant display event 0/2 to 10273/10149
10-04 16:55:33.264  1427  1581 D DisplayManagerService: Ignore redundant display event 0/2 to 10235/10150
10-04 16:55:33.266  2453  2453 I ViewRootImpl@93f9b16[LauncherActivity]: onDisplayChanged oldDisplayState=2 newDisplayState=2
10-04 16:55:33.266  2453  2453 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: onDisplayChanged oldDisplayState=2 newDisplayState=2
10-04 16:55:33.266  2453  2453 I ViewRootImpl@1f7ce54[RecentsActivity]: onDisplayChanged oldDisplayState=2 newDisplayState=2
10-04 16:55:33.266  2453  2453 I ViewRootImpl@4145d62[CocktailBarService]: onDisplayChanged oldDisplayState=2 newDisplayState=2
10-04 16:55:33.267  5004  5004 I ViewRootImpl@66715da[InputMethod]: onDisplayChanged oldDisplayState=2 newDisplayState=2
10-04 16:55:33.267  7973  7973 I ViewRootImpl@12a5813[0 fl=}]: onDisplayChanged oldDisplayState=2 newDisplayState=2
10-04 16:55:33.267  2453 15403 I HoneySpace.RefreshRateSource: singleFrameMs 16
10-04 16:55:33.267  1427  2275 D CompatibilityChangeReporter: Compat change id reported: 170503758; UID 10384; state: ENABLED
10-04 16:55:33.268 16972 16972 I ViewRootImpl@56e8b21[MainActivity]: onDisplayChanged oldDisplayState=2 newDisplayState=2
10-04 16:55:33.269  1427  1581 D RefreshRateModeManager: updateDefaultDisplayToken: android.os.BinderProxy@98275e5, isChanged: false
10-04 16:55:33.271  2042  2042 D DisplayLifecycle: updateDisplay id = 0
10-04 16:55:33.271  2042  2042 I ViewRootImpl@3eae354[LockscreenShortcutBlur]: onDisplayChanged oldDisplayState=2 newDisplayState=2
10-04 16:55:33.271  2042  2042 I ViewRootImpl@141c4ca[NavigationBar0]: onDisplayChanged oldDisplayState=2 newDisplayState=2
10-04 16:55:33.271  2042  2042 I ViewRootImpl@b9445ae[NotificationShade]: onDisplayChanged oldDisplayState=2 newDisplayState=2
10-04 16:55:33.271  2042  2042 I ViewRootImpl@16e3a3f[StatusBar]: onDisplayChanged oldDisplayState=2 newDisplayState=2
10-04 16:55:33.271  2042  2042 I ViewRootImpl@5f21614[Bouncer]: onDisplayChanged oldDisplayState=2 newDisplayState=2
10-04 16:55:33.271  2042  2042 I ViewRootImpl@810f88a[KeyguardBiometricToastView]: onDisplayChanged oldDisplayState=2 newDisplayState=2
10-04 16:55:33.337  7973  7979 W earchbox:search: ApkAssets: Deleting an ApkAssets object '<empty> and /data/app/~~3R7dbyNRQlg3BaQ5yZXKBQ==/com.android.chrome-yS3a_jLK1ZC1fAJnewxsuQ==/base.apk' with 1 weak references
10-04 16:55:33.338  7973  7979 W earchbox:search: ApkAssets: Deleting an ApkAssets object '<empty> and /data/app/~~3R7dbyNRQlg3BaQ5yZXKBQ==/com.android.chrome-yS3a_jLK1ZC1fAJnewxsuQ==/split_auxiliary_search.apk' with 1 weak references
10-04 16:55:33.338  7973  7979 W earchbox:search: ApkAssets: Deleting an ApkAssets object '<empty> and /data/app/~~3R7dbyNRQlg3BaQ5yZXKBQ==/com.android.chrome-yS3a_jLK1ZC1fAJnewxsuQ==/split_cablev2_authenticator.apk' with 1 weak references
10-04 16:55:33.338  7973  7979 W earchbox:search: ApkAssets: Deleting an ApkAssets object '<empty> and /data/app/~~3R7dbyNRQlg3BaQ5yZXKBQ==/com.android.chrome-yS3a_jLK1ZC1fAJnewxsuQ==/split_chrome.apk' with 1 weak references
10-04 16:55:33.338  7973  7979 W earchbox:search: ApkAssets: Deleting an ApkAssets object '<empty> and /data/app/~~3R7dbyNRQlg3BaQ5yZXKBQ==/com.android.chrome-yS3a_jLK1ZC1fAJnewxsuQ==/split_config.en.apk' with 1 weak references
10-04 16:55:33.338  7973  7979 W earchbox:search: ApkAssets: Deleting an ApkAssets object '<empty> and /data/app/~~3R7dbyNRQlg3BaQ5yZXKBQ==/com.android.chrome-yS3a_jLK1ZC1fAJnewxsuQ==/split_dev_ui.apk' with 1 weak references
10-04 16:55:33.338  7973  7979 W earchbox:search: ApkAssets: Deleting an ApkAssets object '<empty> and /data/app/~~3R7dbyNRQlg3BaQ5yZXKBQ==/com.android.chrome-yS3a_jLK1ZC1fAJnewxsuQ==/split_feedv2.apk' with 1 weak references
10-04 16:55:33.339  7973  7979 W earchbox:search: ApkAssets: Deleting an ApkAssets object '<empty> and /data/app/~~3R7dbyNRQlg3BaQ5yZXKBQ==/com.android.chrome-yS3a_jLK1ZC1fAJnewxsuQ==/split_read_aloud_playback.apk' with 1 weak references
10-04 16:55:33.339  7973  7979 W earchbox:search: ApkAssets: Deleting an ApkAssets object '<empty> and /data/app/~~3R7dbyNRQlg3BaQ5yZXKBQ==/com.android.chrome-yS3a_jLK1ZC1fAJnewxsuQ==/split_stack_unwinder.apk' with 1 weak references
10-04 16:55:33.339  7973  7979 W earchbox:search: ApkAssets: Deleting an ApkAssets object '<empty> and /data/app/~~3R7dbyNRQlg3BaQ5yZXKBQ==/com.android.chrome-yS3a_jLK1ZC1fAJnewxsuQ==/split_survey.apk' with 1 weak references
10-04 16:55:33.339  7973  7979 W earchbox:search: ApkAssets: Deleting an ApkAssets object '<empty> and /data/app/~~3R7dbyNRQlg3BaQ5yZXKBQ==/com.android.chrome-yS3a_jLK1ZC1fAJnewxsuQ==/split_test_dummy.apk' with 1 weak references
10-04 16:55:33.339  7973  7979 W earchbox:search: ApkAssets: Deleting an ApkAssets object '<empty> and /data/app/~~tvDIXE7vfg-xz8vzQecZPQ==/com.google.android.trichromelibrary_666808133-D8qNzW6NGoWgv5ZPxUxxAQ==/base.apk' with 1 weak references
10-04 16:55:33.340  7973  7979 W earchbox:search: ApkAssets: Deleting an ApkAssets object '<empty> and /data/app/~~5Dp3SGKALtAGn8kB8ntLZw==/com.google.android.youtube-E_NuDkPor0nFAXHi10UDLQ==/base.apk' with 1 weak references
10-04 16:55:33.341  7973  7979 W earchbox:search: ApkAssets: Deleting an ApkAssets object '<empty> and /data/app/~~5Dp3SGKALtAGn8kB8ntLZw==/com.google.android.youtube-E_NuDkPor0nFAXHi10UDLQ==/split_config.arm64_v8a.apk' with 1 weak references
10-04 16:55:33.341  7973  7979 W earchbox:search: ApkAssets: Deleting an ApkAssets object '<empty> and /data/app/~~5Dp3SGKALtAGn8kB8ntLZw==/com.google.android.youtube-E_NuDkPor0nFAXHi10UDLQ==/split_config.en.apk' with 1 weak references
10-04 16:55:33.341  7973  7979 W earchbox:search: ApkAssets: Deleting an ApkAssets object '<empty> and /data/app/~~5Dp3SGKALtAGn8kB8ntLZw==/com.google.android.youtube-E_NuDkPor0nFAXHi10UDLQ==/split_config.xxhdpi.apk' with 1 weak references
10-04 16:55:33.342  7973  7979 W earchbox:search: ApkAssets: Deleting an ApkAssets object '<empty> and /data/app/~~0fsaRZB5ne4Bhy07QHjX5Q==/com.google.android.apps.youtube.music-YkU0tNSdk9UxN780Q2FhPA==/base.apk' with 1 weak references
10-04 16:55:33.342  7973  7979 W earchbox:search: ApkAssets: Deleting an ApkAssets object '<empty> and /data/app/~~0fsaRZB5ne4Bhy07QHjX5Q==/com.google.android.apps.youtube.music-YkU0tNSdk9UxN780Q2FhPA==/split_config.en.apk' with 1 weak references
10-04 16:55:33.355  1427  1791 D InputReader: Btn_touch(11): value=1 when=89541.823781
10-04 16:55:33.355  1427  1791 I InputReader: Touch event's action is 0x0 (id=3, t=0) [pCnt=1, s=0.694 ] when=89541.823781
10-04 16:55:33.357  1427  1790 I InputDispatcher: Delivering touch to (2042): action: 0x0, f=0x0, d=0, 'e6bbee6', t=1 +(0,-2256)
10-04 16:55:33.357  1427  1790 D PowerManagerService: [api] userActivityFromNative : touch displayId=0 eventTime=89541823
10-04 16:55:33.357  2042  2042 I ViewRootImpl@141c4ca[NavigationBar0]: ViewPostIme pointer 0
10-04 16:55:33.358  1427  1790 D PowerManagerService: UserActivityStateListenerState: 1
10-04 16:55:33.358  1427  1579 I GestureDetector: obtain mCurrentDownEvent. id: 252693429 caller: com.android.server.wm.SystemGesturesPointerEventListener.onPointerEvent:204 com.android.server.wm.PointerEventDispatcher.onInputEvent:53 android.view.InputEventReceiver.dispatchInputEvent:337 
10-04 16:55:33.358  1427  1579 I GestureDetector: obtain mCurrentDownEvent. id: 252693429 caller: com.android.server.wm.SystemPerformancePointerEventListener.onPointerEvent:89 com.android.server.wm.PointerEventDispatcher.onInputEvent:53 android.view.InputEventReceiver.dispatchInputEvent:337 
10-04 16:55:33.359  2042  2323 I KeyButtonView: injectInputEvent - 187
10-04 16:55:33.360  1073  1073 I HWComposer: [4633128672291735937] ActiveConfigToHWC, ID : 0
10-04 16:55:33.360  2042  2042 V Vibrator: semGetSupportedVibrationType: ret=3
10-04 16:55:33.360   975  1036 I display : Set Affinity config for fps(120) : 0, cpuIDs : 255
10-04 16:55:33.360   975  1036 I display : Set Affinity CPU ID : 0
10-04 16:55:33.360   975  1036 I display : Set Affinity CPU ID : 1
10-04 16:55:33.360   975  1036 I display : Set Affinity CPU ID : 2
10-04 16:55:33.360   975  1036 I display : Set Affinity CPU ID : 3
10-04 16:55:33.360   975  1036 I display : Set Affinity CPU ID : 4
10-04 16:55:33.360   975  1036 I display : Set Affinity CPU ID : 5
10-04 16:55:33.360   975  1036 I display : Set Affinity CPU ID : 6
10-04 16:55:33.360   975  1036 I display : Set Affinity CPU ID : 7
10-04 16:55:33.360  1427  2275 D InputDispatcher: Inject key (2042/10043): action=0, f=0x48, d=0, time=89541827000000
10-04 16:55:33.360   975  1036 I display : Set affinity HWC : 975
10-04 16:55:33.360  1427  2275 D WindowManager: interceptKeyTq keycode=187 interactive=true keyguardActive=false policyFlags=2b000002
10-04 16:55:33.360  2042  2042 D SearcleGestureHandler: allowGesture: false
10-04 16:55:33.360   975  1036 I display : CPU set : Cluster(0), min_clock(0)
10-04 16:55:33.360   975  1036 I display : CPU set : Cluster(1), min_clock(0)
10-04 16:55:33.360   975  1036 I display : CPU set : Cluster(2), min_clock(0)
10-04 16:55:33.361  1427  2275 D PhoneWindowManagerExt: setScreenshotEnabled, screenOnFully=true
10-04 16:55:33.361  1073  1073 I LayerHistory: StatusBar$_2042#89 voted 0, 0.00 fps
10-04 16:55:33.361  1427  2275 D SingleKeyGesture: interceptKeyDown, info : KeyCode=KEYCODE_UNKNOWN, size=0
10-04 16:55:33.361  1073  1073 I SurfaceFlinger: Touch Boost - choose 120.00 Hz
10-04 16:55:33.361  1427  2275 D PhoneWindowManagerExt: interceptKeyTq code=187 down=true repeatCount=0 displayId=0 interactive=true
10-04 16:55:33.361  1427  2275 D WindowManager: interceptKeyTq interceptKeyResult=1
10-04 16:55:33.361  1427  2275 D PhoneWindowManagerExt: f.b. a=false id=1 he=true ksno=false uid=1000 callingPackage=android reason=Virtual Key - Press Caller=com.android.server.policy.PhoneWindowManager.performHapticFeedback:7290 com.android.server.policy.PhoneWindowManager.performHapticFeedback:7276 com.android.server.policy.PhoneWindowManager.interceptKeyBeforeQueueing:5593 com.android.server.wm.InputManagerCallback.interceptKeyBeforeQueueing:163 com.android.server.input.InputManagerService.interceptKeyBeforeQueueing:3514 
10-04 16:55:33.361  1427  2275 D VibratorManagerService: vibrate - uid: 1000, opPkg: android, effect: Mono{mEffect=Composed{segments=[SemHaptic{mType=50038, mMagnitude=-1}], repeat=-1, mMagnitudeType=TYPE_TOUCH}}, attrs: VibrationAttributes: Usage=TOUCH Audio Usage= USAGE_UNKNOWN tags= Flags=0, reason: Virtual Key - Press, token: android.os.Binder@4833a84
10-04 16:55:33.361  1427  2275 D VibratorManagerService: converted usage = TOUCH(18)
10-04 16:55:33.362  1427  2275 D VibratorManagerService: semColorfulVibrate : EFFECT_HEAVY_CLICK(14), repeat: -1, usage: TOUCH(18), magnitude: 4000
10-04 16:55:33.362  1427  2275 D VibratorManagerService: Starting vibrate for vibration 312
10-04 16:55:33.363  1427  1775 D SemHapticStep: sepIndex=14, intensity=4000, repeat=false, duration=230
10-04 16:55:33.363  1427  1775 D SemHapticStep: Turning on vibrator 0 for 230ms
10-04 16:55:33.363  1427  1775 D VibratorController: performHapticEngine packetCnt (1).
10-04 16:55:33.363  1427  1790 D WindowManager: interceptKeyTi keyCode=187 down=true repeatCount=0 keyguardOn=false canceled=false
10-04 16:55:33.363  1427  1790 D PhoneWindowManagerExt: interceptKeyTi code=187 down=true repeatCount=0 displayId=0 interactive=true
10-04 16:55:33.364  1427  1579 I GestureDetector: obtain mCurrentMotionEventRaw. action: 2 id: 790244211
10-04 16:55:33.364  1427  1579 I GestureDetector: obtain mCurrentMotionEventRaw. action: 2 id: 790244211
10-04 16:55:33.366  1044  1044 E SecVibrator-HAL-AIDL-EXT: V_3_0: performHapticEngine
10-04 16:55:33.366  1044  1044 E SecVibrator-HAL-AIDL-EXT: V_3_0: performHapticEngine amplitude : 4000
10-04 16:55:33.366  1044  1044 E SecVibrator-HAL-AIDL-EXT: V_3_0: performHapticEngine packet_cnt : 1
10-04 16:55:33.366  1044  1044 E SecVibrator-HAL-AIDL-EXT: V_3_0: performHapticEngine total_size : 4
10-04 16:55:33.366  1044  1044 E SecVibrator-HAL-AIDL-EXT: V_3_0: performHapticEngine : 4 7 4000 2000 1
10-04 16:55:33.366  1044  1044 E SecVibrator-HAL-AIDL-CORE: HW_API: do_on for timeoutMs: 1
10-04 16:55:33.366  1044  1044 E SecVibrator-HAL-AIDL-CORE: HW_API: >> writeNode node:/timed_output/vibrator/enable val:1
10-04 16:55:33.366  1427  1581 D LocalDisplayAdapter: updateActiveModeLocked for d=4633128672291735937, mActiveModeId=1, mActiveSfDisplayMode=DisplayMode{id=0, width=1080, height=2400, xDpi=422.03, yDpi=423.333, refreshRate=120.00001, appVsyncOffsetNanos=0, presentationDeadlineNanos=9333333, supportedHdrTypes=[2, 3, 4], group=0}
10-04 16:55:33.367  1427  1581 I DisplayDeviceRepository: Display device changed: DisplayDeviceInfo{"Built-in Screen": uniqueId="local:4633128672291735937", 1080 x 2400, modeId 1, renderFrameRate 120.00001, defaultModeId 3, supportedModes [{id=1, width=1080, height=2400, fps=120.00001, alternativeRefreshRates=[48.000004, 60.000004, 96.00001], supportedHdrTypes=[2, 3, 4]}, {id=2, width=1080, height=2400, fps=96.00001, alternativeRefreshRates=[48.000004, 60.000004, 120.00001], supportedHdrTypes=[2, 3, 4]}, {id=3, width=1080, height=2400, fps=60.000004, alternativeRefreshRates=[48.000004, 96.00001, 120.00001], supportedHdrTypes=[2, 3, 4]}, {id=4, width=1080, height=2400, fps=48.000004, alternativeRefreshRates=[60.000004, 96.00001, 120.00001], supportedHdrTypes=[2, 3, 4]}], colorMode 0, supportedColorModes [0, 6, 7], hdrCapabilities HdrCapabilities{mSupportedHdrTypes=[2, 3, 4], mMaxLuminance=450.0, mMaxAverageLuminance=120.0, mMinLuminance=5.0E-4}, allmSupported false, gameContentTypeSupported false, density 480, 422.03 x 423.333 dpi, appVsyncOff 0, presDeadline 9333333, cutout DisplayCutout{insets=Rect(0, 80 - 0, 0) waterfall=Insets{left=0, top=0, right=0, bottom=0} boundingRect={Bounds=[Rect(0, 0 - 0, 0), Rect(510, 0 - 570, 80), Rect(0, 0 - 0, 0), Rect(0, 0 - 0, 0)]} cutoutPathParserInfo={CutoutPathParserInfo{displayWidth=1080 displayHeight=2400 physicalDisplayWidth=1080 physicalDisplayHeight=2400 density={3.0} cutoutSpec={M 0,0 H -10 V 26.66666666666667 H 10 V 0 H 0 Z @dp} rotation={0} scale={1.0} physicalPixelDisplaySizeRatio={1.0}}}}, touch INTERNAL, rotation 0, type INTERNAL, address {port=129, model=0x404c2dfae6a049}, deviceProductInfo DeviceProductInfo{name=samsung lcd  , manufacturerPnpId=SAM, productId=0, modelYear=null, manufactureDate=ManufactureDate{week=16, year=2020}, connectionToSinkType=0}, state ON, committedState ON, frameRateOverride , brightnessMinimum 0.0, brightnessMaximum 1.0, brightnessDefault 0.5019608, hdrSdrRatio NaN, roundedCorners RoundedCorners{[RoundedCorner{position=TopLeft, radius=90, center=Point(90, 90)}, RoundedCorner{position=TopRight, radius=90, center=Point(990, 90)}, RoundedCorner{position=BottomRight, radius=90, center=Point(990, 2310)}, RoundedCorner{position=BottomLeft, radius=90, center=Point(90, 2310)}]}, FLAG_ALLOWED_TO_BE_DEFAULT_DISPLAY, FLAG_ROTATES_WITH_CONTENT, FLAG_SECURE, FLAG_SUPPORTS_PROTECTED_BUFFERS, FLAG_TRUSTED, installOrientation 0, displayShape DisplayShape{ spec=-311912193 displayWidth=1080 displayHeight=2400 physicalPixelDisplaySizeRatio=1.0 rotation=0 offsetX=0 offsetY=0 scale=1.0}}
10-04 16:55:33.368  1044  1044 E SecVibrator-HAL-AIDL-CORE: HW_API: << writeNode node OK : 2
10-04 16:55:33.368  1044  1044 E SecVibrator-HAL-AIDL-EXT: V_3_0: performHapticEngine OK
10-04 16:55:33.369   975  1033 I display : doDisplayConfigPostProcess needSetActiveConfig is true - mDesiredConfig: 0
10-04 16:55:33.369   975  1033 I display : setActiveConfig(config=0)
10-04 16:55:33.369   975  1033 I display : next config(0): width=1080 height=2400 period=8333333 Xdpi=422030 Ydpi=423333 groupId=0
10-04 16:55:33.369   975  1033 I display : Current VRR MODE is 3
10-04 16:55:33.369  1073  1212 I VSyncReactor: Current= 60, Period= 120, hwcPeriod= 60
10-04 16:55:33.372  1427  1427 D SGM:GameManager: onDisplayChanged. displyId: 0, state: 2
10-04 16:55:33.372  1427  1427 D MotionRecognitionService: [DisplayListener] getRefreshRate 120.00001
10-04 16:55:33.372  1427  1807 D SGM:FgCheckThread: onLooperPrepared(), msg: MSG_LCD_ON
10-04 16:55:33.372  1427  3269 D LiftUpHandler: [LTW] Stopped already.
10-04 16:55:33.373  1427  1581 D DisplayManagerService: Ignore redundant display event 0/2 to 10251/5386
10-04 16:55:33.373  1427  1828 D MotionRecognitionService: Inject RefreshRate: 120
10-04 16:55:33.373  1427  1581 D DisplayManagerService: Ignore redundant display event 0/2 to 10273/10149
10-04 16:55:33.373  1427  1581 D DisplayManagerService: Ignore redundant display event 0/2 to 10235/10150
10-04 16:55:33.373  2042  2164 I ViewRootImpl@e11db90[ShellDropTarget]: onDisplayChanged oldDisplayState=2 newDisplayState=2
10-04 16:55:33.373  1427  1828 D SensorService: setSContextDataLocked ints length 3 , byte length 8
10-04 16:55:33.373  1427  1828 D SensorService: setSContextDataLocked 100048c1
10-04 16:55:33.373  2042  3044 I ViewRootImpl@3eb5874[ScreenDecorOverlay]: onDisplayChanged oldDisplayState=2 newDisplayState=2
10-04 16:55:33.373  2042  3044 I ViewRootImpl@403463c[ScreenDecorOverlayBottom]: onDisplayChanged oldDisplayState=2 newDisplayState=2
10-04 16:55:33.373   986   986 D Sensors : c1 48 00 10 78 00 00 00  
10-04 16:55:33.373   986   986 E Sensors : inject_scontext_data: New ssp_data_injection_fd(44)
10-04 16:55:33.374  2453  2453 I ViewRootImpl@93f9b16[LauncherActivity]: onDisplayChanged oldDisplayState=2 newDisplayState=2
10-04 16:55:33.374  2453  2453 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: onDisplayChanged oldDisplayState=2 newDisplayState=2
10-04 16:55:33.374  2453  2453 I ViewRootImpl@1f7ce54[RecentsActivity]: onDisplayChanged oldDisplayState=2 newDisplayState=2
10-04 16:55:33.374  2453  2453 I ViewRootImpl@4145d62[CocktailBarService]: onDisplayChanged oldDisplayState=2 newDisplayState=2
10-04 16:55:33.375   986   986 D Sensors : SContext Data Injection return 8
10-04 16:55:33.375  2453 12445 I HoneySpace.RefreshRateSource: singleFrameMs 8
10-04 16:55:33.375  5004  5004 I ViewRootImpl@66715da[InputMethod]: onDisplayChanged oldDisplayState=2 newDisplayState=2
10-04 16:55:33.375  1427  1581 D RefreshRateModeManager: updateDefaultDisplayToken: android.os.BinderProxy@98275e5, isChanged: false
10-04 16:55:33.376  1427  1427 D AODManagerService: requestReCalToTSP IsSingleTouchMode = falserequestedReCalToTSP = false / previousDisplayState = ON
10-04 16:55:33.377  7973  7973 I ViewRootImpl@12a5813[0 fl=}]: onDisplayChanged oldDisplayState=2 newDisplayState=2
10-04 16:55:33.378  2042  2042 D DisplayLifecycle: updateDisplay id = 0
10-04 16:55:33.378  2042  2042 I ViewRootImpl@3eae354[LockscreenShortcutBlur]: onDisplayChanged oldDisplayState=2 newDisplayState=2
10-04 16:55:33.378  2042  2042 I ViewRootImpl@141c4ca[NavigationBar0]: onDisplayChanged oldDisplayState=2 newDisplayState=2
10-04 16:55:33.378  2042  2042 I ViewRootImpl@b9445ae[NotificationShade]: onDisplayChanged oldDisplayState=2 newDisplayState=2
10-04 16:55:33.378  2042  2042 I ViewRootImpl@16e3a3f[StatusBar]: onDisplayChanged oldDisplayState=2 newDisplayState=2
10-04 16:55:33.378  2042  2042 I ViewRootImpl@5f21614[Bouncer]: onDisplayChanged oldDisplayState=2 newDisplayState=2
10-04 16:55:33.378  2042  2042 I ViewRootImpl@810f88a[KeyguardBiometricToastView]: onDisplayChanged oldDisplayState=2 newDisplayState=2
10-04 16:55:33.378 16972 16972 I ViewRootImpl@56e8b21[MainActivity]: onDisplayChanged oldDisplayState=2 newDisplayState=2
10-04 16:55:33.378  2042  2247 D StackScroller: onDisplayChanged for predraw skip to 2
10-04 16:55:33.385   975  1033 I display : config 16666666, desired 8333333
10-04 16:55:33.385  1073  1212 I VSyncReactor: Current= 60, Period= 120, hwcPeriod= 60
10-04 16:55:33.402  1073  1212 I VSyncReactor: Current= 60, Period= 120, hwcPeriod= 60
10-04 16:55:33.418  1073  1212 I VSyncReactor: Current= 60, Period= 120, hwcPeriod= 120
10-04 16:55:33.421  1427  1791 D InputReader: Btn_touch(11): value=0 when=89541.890496
10-04 16:55:33.421  1427  1791 I InputReader: Touch event's action is 0x1 (id=3, t=0) [pCnt=1, s=] when=89541.890496
10-04 16:55:33.422  2042  2042 I ViewRootImpl@141c4ca[NavigationBar0]: ViewPostIme pointer 1
10-04 16:55:33.422  1427  1790 I InputDispatcher: Delivering touch to (2042): action: 0x1, f=0x0, d=0, 'e6bbee6', t=1 +(0,-2256)
10-04 16:55:33.423  2042  2323 I KeyButtonView: injectInputEvent - 187
10-04 16:55:33.423  1427  7972 D InputDispatcher: Inject key (2042/10043): action=1, f=0x48, d=0, time=89541891000000
10-04 16:55:33.423  1427  7972 D WindowManager: interceptKeyTq keycode=187 interactive=true keyguardActive=false policyFlags=2b000002
10-04 16:55:33.424  1427  7972 D SingleKeyGesture: interceptKeyUp, longPress=false info : KeyCode=KEYCODE_UNKNOWN, size=0
10-04 16:55:33.424  1427  7972 D SingleKeyGesture: interceptKeyUp, mActiveRule is null
10-04 16:55:33.424  1427  7972 D PhoneWindowManagerExt: interceptKeyTq code=187 down=false repeatCount=0 displayId=0 interactive=true
10-04 16:55:33.424  1427  7972 D WindowManager: interceptKeyTq interceptKeyResult=1
10-04 16:55:33.424  1427  1790 D WindowManager: interceptKeyTi keyCode=187 down=false repeatCount=0 keyguardOn=false canceled=false
10-04 16:55:33.424  1427  1790 D PhoneWindowManagerExt: interceptKeyTi code=187 down=false repeatCount=0 displayId=0 interactive=true
10-04 16:55:33.424  1427  1790 D WindowManager: toggleRecentApps displayId=0
10-04 16:55:33.425  2453  7396 I HoneySpace.TISBinder: onOverviewToggle
10-04 16:55:33.425  2453  2585 I HoneySpace.TISBinder: onOverviewToggle - invoke event
10-04 16:55:33.425  2453 15403 I HoneySpace.OverviewEventHandler: OverviewToggleEvent: false / true
10-04 16:55:33.427  2453 15403 I HoneySpace.OverviewEventHandler: closeSystemWindow
10-04 16:55:33.427  2453 15403 I HoneySpace.OverviewEventHandler: send RecentsToggleEvent : true false
10-04 16:55:33.427  2453  2453 I HoneySpace.TaskListViewModel: updateHomeIsOnTop: false
10-04 16:55:33.427  2453  2453 I HoneySpace.GestureRecentViewControllerImpl: loadTaskList() childCount: 0
10-04 16:55:33.427  2453  2453 I HoneySpace.GestureInputHandler: RecentsToggleEvent
10-04 16:55:33.427  2453  2453 I HoneySpace.GestureInputHandler: toggleRecents() called
10-04 16:55:33.430  2453 12442 I HoneySpace.TaskListViewModel: registerSensorListener: sensor = {Sensor name="AutoRotation Sensor", vendor="Samsung Electronics", version=16, type=27, maxRange=255.0, resolution=1.0, power=0.001, minDelay=0}
10-04 16:55:33.432  3928  3928 W ContextImpl: Calling a method in the system process without a qualified user: android.app.ContextImpl.startService:1960 android.content.ContextWrapper.startService:842 android.content.ContextWrapper.startService:842 com.sec.android.diagmonagent.sa.receiver.CFLogReceiver.a:17 com.sec.android.diagmonagent.sa.receiver.CFLogReceiver.onReceive:40 
10-04 16:55:33.433  2042  2042 D BubblesManager: onEntryUpdated : shouldBubbleUp=false ,key=0|com.google.android.googlequicksearchbox|0|161924996::SUMMARY::wx|10237
10-04 16:55:33.434  2042  2042 D InterruptionStateProvider:  no Heads up : edgelighting enabled app. 0|com.google.android.googlequicksearchbox|0|161924996::SUMMARY::wx|10237
10-04 16:55:33.434  2042  2042 D BubblesManager: onEntryUpdated : shouldBubbleUp=false ,key=0|com.google.android.googlequicksearchbox|0|161924996::a:snotification:[0x394,wx.f,NOTIFICATION]|10237
10-04 16:55:33.437  2453  2453 I HoneySpace.PhoneIconStyleFactory: init densityDpi=480, adjustedDpi=480
10-04 16:55:33.437  2453  2453 I HoneySpace.PhoneIconStyleFactory: getNearGridOption, Point(4, 5) -> Point(4, 5)
10-04 16:55:33.438  2453  2453 I HoneySpace.RecentStyler: context = android.window.WindowContext@385f453, styleData = RecentStyleData(windowBounds=WindowBounds width=1080 height=2400, bounds=Rect(0, 0 - 1080, 2400) insets=Insets{left=0, top=80, right=0, bottom=144}, systemInsets=Insets{left=0, top=80, right=0, bottom=144}cutout=Rect(0, 80 - 0, 0), gestureInsets=Insets{left=0, top=116, right=0, bottom=144}, gestureActionInsets=Insets{left=0, top=116, right=0, bottom=144}, insetsIgnoreCutout=Insets{left=0, top=80, right=0, bottom=144}, baseScreenSize=Point(1080, 2256)screenSizeInGesture=Point(1080, 2256), screenSizeIncludeCutout: Point(1080, 2256), iconSize=175, iconGravity=1, iconStarMargin=0, sceneScale=PointF(0.6, 0.6), sceneCoordinate=RectF(216.0, 386.4, 864.0, 1692.0001), sceneTopMargin=87, taskViewCoordinate=RectF(216.0, 299.4, 864.0, 1692.0001), sceneFullyScale=PointF(1.6666666, 1.8382351), gridExtraGap=0.0, sceneRadius=45.0, deviceRadius=-32.0, mwRadius=(30.0, 51.0), curveEffectScale=0.135, pageSpacing=16, pageSideMargin=0, sceneStartMargin=0, circularListGap=0, topTaskCount=0, bottomTaskCount=0, taskLockIconSize=168, listSceneScale=PointF(0.6, 0.6), listSceneSize=RectF(0.0, 0.0, 648.0, 1305.6001), listSceneRadius=45.0)
10-04 16:55:33.438  2453  2453 I HoneySpace.AnimationSession: open
10-04 16:55:33.438  2453  2453 I HoneySpace.AnimationSession: doAction(195854736) called with: event = StartRecentsToggle(taskId=148, displaySize=Point(1080, 2400))
10-04 16:55:33.438  2453  2453 I HoneySpace.AnimationSession: toggleRecentView() called with: displaySize = Point(1080, 2400), taskId = 148
10-04 16:55:33.438  2453  2453 I HoneySpace.AnimationSession: taskListView appeared : true
10-04 16:55:33.438  2453  2453 I HoneySpace.AnimationSession: controlByView with taskListView true
10-04 16:55:33.438  2042  2042 D InterruptionStateProvider:  no Heads up : edgelighting enabled app. 0|com.google.android.googlequicksearchbox|0|161924996::a:snotification:[0x394,wx.f,NOTIFICATION]|10237
10-04 16:55:33.439  2453  2453 I HoneySpace.TaskListRepository: fetchTaskList duration : 995.539us
10-04 16:55:33.439  2453  2453 I HoneySpace.AnimationSession: toggleRecentsView taskList updated
10-04 16:55:33.439  2453  2453 I HoneySpace.RecentsAnimationManager: start
10-04 16:55:33.439  2453  2453 I HoneySpace.DvfsManager: HOME_GESTURE_BOOSTER acquire
10-04 16:55:33.439  2453  2453 I HoneySpace.RecentsAnimationManager: init
10-04 16:55:33.439  2453  2453 I HoneySpace.RecentsAnimationManager: initStateCallbacks
10-04 16:55:33.439  2453  2453 I HoneySpace.MultiStateCallback: [223165065] Adding [STATE_GESTURE_START_BYKEY (16384)] to [ (0)]
10-04 16:55:33.439  2453  2453 I HoneySpace.RecentsAnimationManager: startGestureTransition, byKey: true
10-04 16:55:33.439  2453  2453 I HoneySpace.ShellTransitionManager: startGestureTransition homeIsOnTop: false
10-04 16:55:33.439  2453  2453 I HoneySpace.ShellTransitionManager: set restRunnableList: null
10-04 16:55:33.440  2453  2453 I HoneySpace.MultiStateCallback: [223165065] Adding [STATE_START_RECENTS_TRANSITION (4)] to [STATE_GESTURE_START_BYKEY (16384)]
10-04 16:55:33.440  2453  2453 I HoneySpace.RecentsAnimationManager: startRecentsScreen
10-04 16:55:33.440  2453  2453 I HoneySpace.MultiStateCallback: [223165065] Adding [STATE_GESTURE_START_RECENTS_SCREEN (256)] to [STATE_START_RECENTS_TRANSITION, STATE_GESTURE_START_BYKEY (16388)]
10-04 16:55:33.440  2453  2453 I HoneySpace.RecentInteraction: sendRecentsAnimationEvent. isStarted: true
10-04 16:55:33.440  2453  6740 I SemDvfsHyPerManager: acquire hyper - RECENTS_GESTURE_BOOSTER/2453@0, type = -999
10-04 16:55:33.440  2453  2453 I HoneySpace.GestureTaskListView: addViewList 1
10-04 16:55:33.440  2453  6740 I HoneySpace.CustomFrequencyManager: enableGpisHint: true
10-04 16:55:33.440  2042  2164 V ShellRecents: RecentsTransitionHandler.startRecentsTransition
10-04 16:55:33.440  2042  2164 V WindowManagerShell: Directly starting a new transition type=3 wct=WindowContainerTransaction { changes = {} hops = [{PendingIntent: options=Bundle[mParcelledData.dataSize=1496]}] errorCallbackToken=null taskFragmentOrganizer=null } handler=com.android.wm.shell.recents.RecentsTransitionHandler@2cc40a3
10-04 16:55:33.440  2042  2164 I WindowOrganizer: startNewTransition, type=3, t=WindowContainerTransaction { changes = {} hops = [{PendingIntent: options=Bundle[mParcelledData.dataSize=1496]}] errorCallbackToken=null taskFragmentOrganizer=null }, caller=com.android.wm.shell.transition.Transitions.startTransition:43 com.android.wm.shell.recents.RecentsTransitionHandler.startRecentsTransition:81 com.android.wm.shell.recents.RecentTasksController$IRecentTasksImpl$$ExternalSyntheticLambda4.accept:15 com.android.wm.shell.common.ExecutorUtils$$ExternalSyntheticLambda0.run:11 android.os.Handler.handleCallback:958 
10-04 16:55:33.440   994  1071 I HYPER-HAL: [RequestManager.cpp]acquire(): Acquired ID : 3009831  [2453 / 0]    HINT : RECENTS_GESTURE_BOOSTER    list : 
10-04 16:55:33.442  1427  7972 D WindowManager: Transition is created, t=TransitionRecord{e22f8cd id=-1 type=TO_FRONT flags=0x0}, caller=com.android.server.wm.WindowOrganizerController.startTransition:343 com.android.server.wm.WindowOrganizerController.startNewTransition:307 android.window.IWindowOrganizerController$Stub.onTransact:245 com.android.server.wm.WindowOrganizerController.onTransact:217 android.os.Binder.execTransactInternal:1380 
10-04 16:55:33.442  1427  7972 V WindowManager: Starting a Recents transition which can be parallel.
10-04 16:55:33.442  1427  7972 D WindowManager: SyncGroup is created, id=428, name=Transition, caller=com.android.server.wm.BLASTSyncEngine$SyncGroup.<init>:0 com.android.server.wm.BLASTSyncEngine.prepareSyncSet:513 com.android.server.wm.BLASTSyncEngine.startSyncSet:518 com.android.server.wm.Transition.startCollecting:710 com.android.server.wm.TransitionController.moveToCollecting:360 com.android.server.wm.TransitionController.startCollectOrQueue:1727 com.android.server.wm.WindowOrganizerController.startTransition:354 
10-04 16:55:33.442  1427  7972 W WindowManager: setSyncMethod, id=428, method=0, caller=com.android.server.wm.Transition.startCollecting:712 com.android.server.wm.TransitionController.moveToCollecting:360 com.android.server.wm.TransitionController.startCollectOrQueue:1727 
10-04 16:55:33.442  1427  7972 V WindowManager: Start collecting in Transition: TransitionRecord{e22f8cd id=428 type=TO_FRONT flags=0x0}, caller=com.android.server.wm.TransitionController.startCollectOrQueue:1727 com.android.server.wm.WindowOrganizerController.startTransition:354 com.android.server.wm.WindowOrganizerController.startNewTransition:307 android.window.IWindowOrganizerController$Stub.onTransact:245 com.android.server.wm.WindowOrganizerController.onTransact:217 
10-04 16:55:33.442  1427  7972 V WindowManager: Starting Transition 428, caller=com.android.server.wm.WindowOrganizerController.lambda$startTransition$4:356 com.android.server.wm.WindowOrganizerController.$r8$lambda$Bc2VOa5xBetACk_GAvygz0fAMB4:0 com.android.server.wm.WindowOrganizerController$$ExternalSyntheticLambda3.onCollectStarted:0 
10-04 16:55:33.442  1427  7972 V Transition:  allReady query: used=false, override=false, defer=0, states=
10-04 16:55:33.444  1427  7972 V WindowManager: Transition 428: Set Task{3a7474e #148 type=standard A=10384:com.companyname.mauiappwindowtest} as transient-hidden-task, caller=com.android.server.wm.Transition.$r8$lambda$CjoHzkGzNeU_fFxE5qPacUPUYJY:0 com.android.server.wm.Transition$$ExternalSyntheticLambda1.test:0 com.android.server.wm.Task.forAllTasks:4047 
10-04 16:55:33.444  1427  7972 V WindowManager: Collecting in transition 428: Task{3a7474e #148 type=standard A=10384:com.companyname.mauiappwindowtest}, caller=com.android.server.wm.Transition.collect:759 com.android.server.wm.Transition.lambda$setTransientLaunch$0:462 com.android.server.wm.Transition.$r8$lambda$CjoHzkGzNeU_fFxE5qPacUPUYJY:0 com.android.server.wm.Transition$$ExternalSyntheticLambda1.test:0 com.android.server.wm.Task.forAllTasks:4047 
10-04 16:55:33.444   994  1071 I HYPER-HAL: [ResourceManager.cpp]updateResource(): [CPUMinFreq] UpdateResource Request ID : 3009831    Value : 2288000
10-04 16:55:33.444  1427  7972 V WindowManager: Collecting in transition 428: TransientLaunchOverlayToken{fb49392 token=android.os.BinderProxy@2aee51d}, caller=com.android.server.wm.Transition.collect:759 com.android.server.wm.TransientLaunchOverlayToken.setVisibility:79 com.android.server.wm.Transition.setTransientLaunch:480 com.android.server.wm.TransitionController.setTransientLaunch:1592 com.android.server.wm.ActivityStartController.startExistingRecents:789 
10-04 16:55:33.444  1427  7972 I TransientLaunchOverlayToken: setVisibility, visible=true, t=TransientLaunchOverlayToken{fb49392 token=android.os.BinderProxy@2aee51d}, caller=com.android.server.wm.Transition.setTransientLaunch:480 com.android.server.wm.TransitionController.setTransientLaunch:1592 com.android.server.wm.ActivityStartController.startExistingRecents:789 
10-04 16:55:33.444  1427  7972 V WindowManager: Transition 428: Set ActivityRecord{38c4e65 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity t7} as transient-launch, caller=com.android.server.wm.TransitionController.setTransientLaunch:1592 com.android.server.wm.ActivityStartController.startExistingRecents:789 com.android.server.wm.ActivityStartController.startExistingRecentsIfPossible:735 
10-04 16:55:33.444  1427  7972 D ActivityTaskManager: setCanAffectSystemUiFlags: false for Task{9be573a #7 type=recents I=com.sec.android.app.launcher/com.android.quickstep.RecentsActivity} from com.android.server.wm.TransitionController.setTransientLaunch:1602 com.android.server.wm.ActivityStartController.startExistingRecents:789 com.android.server.wm.ActivityStartController.startExistingRecentsIfPossible:735 com.android.server.wm.WindowOrganizerController.applyHierarchyOp:1302 com.android.server.wm.WindowOrganizerController.applyTransaction:787 com.android.server.wm.WindowOrganizerController.applyTransaction:535 com.android.server.wm.WindowOrganizerController.applyTransaction:552 com.android.server.wm.WindowOrganizerController.lambda$startTransition$4:358 com.android.server.wm.WindowOrganizerController.$r8$lambda$Bc2VOa5xBetACk_GAvygz0fAMB4:0 com.android.server.wm.WindowOrganizerController$$ExternalSyntheticLambda3.onCollectStarted:0 
10-04 16:55:33.446  1427  7972 D ActivityTaskManager: scheduleTopResumedActivityChanged, onTop=false, r=ActivityRecord{7496249 u0 com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity t148}, caller=com.android.server.wm.ActivityTaskSupervisor.updateTopResumedActivityIfNeeded:2826 com.android.server.wm.TaskDisplayArea.positionChildTaskAt:567 com.android.server.wm.TaskDisplayArea.positionChildAt:483 com.android.server.wm.Task.moveToFront:6077 com.android.server.wm.Task.moveToFront:5951 com.android.server.wm.ActivityStartController.startExistingRecents:791 
10-04 16:55:33.447  1427  7972 I SemDvfsHyPerManager: acquire hyper - AMS_ACT_RESUME/1427@16, type = -999
10-04 16:55:33.447  1427  7972 D ActivityManagerPerformance: AMP_acquire() ACT_RESUME
10-04 16:55:33.447   994  1071 I HYPER-HAL: [RequestManager.cpp]acquire(): Acquired ID : 1041862  [1427 / 16]    HINT : AMS_ACT_RESUME    list : 
10-04 16:55:33.447  1427  7972 V WindowManager: Collecting in transition 428: ActivityRecord{38c4e65 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity t7}, caller=com.android.server.wm.Transition.collect:759 com.android.server.wm.TransitionController.collect:935 com.android.server.wm.ActivityRecord.setVisibility:6348 com.android.server.wm.ActivityRecord.setVisibility:6300 com.android.server.wm.TaskFragment.resumeTopActivity:1731 
10-04 16:55:33.447  1427  7972 D WindowManager: prepareSync <SYNC_STATE_WAITING_FOR_DRAW>, mPrepareSyncSeqId=0, win=Window{e458a32 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity}
10-04 16:55:33.447  1427  7972 V WindowManager: Setting visibility of Window{e458a32 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity}: true, caller=com.android.server.wm.WindowContainer.sendAppVisibilityToClients:1301 com.android.server.wm.WindowToken.setClientVisible:446 com.android.server.wm.ActivityRecord.setClientVisible:8121 com.android.server.wm.ActivityRecord.setVisibility:6451 com.android.server.wm.ActivityRecord.setVisibility:6300 
10-04 16:55:33.447  2042  2042 V WindowManagerShell: Receive android.intent.action.CLOSE_SYSTEM_DIALOGS
10-04 16:55:33.447  2042  2042 D PopupUI.PopupUI: PopupUIReceiver.onReceive() action : android.intent.action.CLOSE_SYSTEM_DIALOGS
10-04 16:55:33.448  1427  7972 V WindowManager: rotationForOrientation(orient=SCREEN_ORIENTATION_LOCKED (14), last=ROTATION_0 (0)); user=ROTATION_0 (0) 
10-04 16:55:33.448  1427  7972 D WindowManager: rotationForOrientation, orientationSource=ActivityRecord{38c4e65 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity t7}
10-04 16:55:33.448  1427  7972 V WindowManager: Computed rotation=ROTATION_0 (0) for display id=0 based on lastOrientation=SCREEN_ORIENTATION_LOCKED (14) and oldRotation=ROTATION_0 (0), caller=com.android.server.wm.DisplayRotation.updateOrientation:517 com.android.server.wm.DisplayContent.updateOrientation:2176 com.android.server.wm.DisplayContent.updateOrientation:2092 com.android.server.wm.RootWindowContainer.ensureVisibilityAndConfig:2091 com.android.server.wm.TaskFragment.resumeTopActivity:1769 com.android.server.wm.TaskFragment.resumeTopActivity:1386 
10-04 16:55:33.448  2042  2042 D SimTrayProtectionViewModel: dismiss : isFoldedState()falseisRemoveSimtray() : true
10-04 16:55:33.448   994  1071 I HYPER-HAL: [ResourceManager.cpp]updateResource(): [CPUMinFreq] UpdateResource Request ID : 1041862    Value : 1664000
10-04 16:55:33.448  2042  2042 D LocationControllerImpl: onReceive() = android.intent.action.CLOSE_SYSTEM_DIALOGS
10-04 16:55:33.448  2042  2042 D QSButtonsContainer: action:android.intent.action.CLOSE_SYSTEM_DIALOGS
10-04 16:55:33.448  2042  2042 D SecVolume.VolumePanelStore: dispatch [ACTION_DISMISS_REQUESTED with [STATE_NO_DISPATCH], currentAction={isFromOutside : true}, currentState={activeStream=3, stream=-1, isVoiceCapable : true, isCaptionComponentEnabled : true, isSetupWizardComplete : true, isHasVibrator : true, isMediaDefaultEnabled : true, cutoutHeight : 60, timeOutControls : 0, timeOutControlsText : 0, earProtectLevel : 909, pinDevice : 0, activeStream : 3, ringerModeInternal : 2, timeOut : 3000, systemTimeNow : 53072148}
10-04 16:55:33.448  2042  2042 D SecVolume.VolumePanelStore:   > New State : [STATE_NO_DISPATCH]
10-04 16:55:33.448  1427  7972 V WindowManager: Collecting in transition 428: ActivityRecord{38c4e65 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity t7}, caller=com.android.server.wm.Transition.collect:759 com.android.server.wm.TransitionController.collect:935 com.android.server.wm.ActivityRecord.setVisibility:6348 com.android.server.wm.ActivityRecord.setVisibility:6300 com.android.server.wm.ActivityRecord.completeResumeLocked:7395 
10-04 16:55:33.448  1427  7972 V Transition:  allReady query: used=true, override=false, defer=0, states=Display{#0 state=ON size=1080x2400 ROTATION_0}:true
10-04 16:55:33.448  1427  7972 D WindowManagerServiceExt: notifyOccludeChangeNotice: reset caller=com.android.server.wm.ActivityRecord.completeResumeLocked:7452 com.android.server.wm.TaskFragment.resumeTopActivity:1866 com.android.server.wm.TaskFragment.resumeTopActivity:1386 com.android.server.wm.ActivityStartController.startExistingRecents:793 com.android.server.wm.ActivityStartController.startExistingRecentsIfPossible:735 
10-04 16:55:33.449  1427  7972 I SemDvfsHyPerManager: acquire hyper - AMS_APP_LAUNCH/1427@18, type = -999
10-04 16:55:33.449  1427  7972 V WindowManager: Collecting in transition 428: WallpaperWindowToken{1f6c5ec token=android.os.Binder@a0f609f}, caller=com.android.server.wm.Transition.collect:759 com.android.server.wm.TransitionController.collect:935 com.android.server.wm.WallpaperWindowToken.setVisibility:208 com.android.server.wm.WallpaperWindowToken.updateWallpaperWindows:155 com.android.server.wm.WallpaperController.updateWallpaperTokens:940 
10-04 16:55:33.449  1427  7972 V WindowManager: Setting visibility of Window{7fa477f u0 com.android.systemui.wallpapers.ImageWallpaper_system}: true, caller=com.android.server.wm.WindowContainer.sendAppVisibilityToClients:1301 com.android.server.wm.WindowToken.setClientVisible:446 com.android.server.wm.WallpaperWindowToken.setVisible:192 com.android.server.wm.WallpaperWindowToken.commitVisibility:243 com.android.server.wm.WallpaperWindowToken.setVisibility:228 
10-04 16:55:33.449  2042 14123 I WallpaperService: dispatchAppVisibility: system, visible=true
10-04 16:55:33.449  2042  2331 I WallpaperService: updateSurface system forceRelayout=false forceReport=false redrawNeeded=false myWidth=2400 myHeight=2400 fixedSize=true x = 0 y = 0 mWidth=2400 mHeight=2400
10-04 16:55:33.449  2042  2331 I WallpaperService: reportVisibility: visibility changed. visible=true
10-04 16:55:33.449  2042  2331 I ImageWallpaper[CanvasEngine_d0_w1]:  onVisibilityChanged: visible=true , displayId=0
10-04 16:55:33.449  1427  7972 D FreeformController: beginPostLayoutPolicyLw: forceHideRequester changed, old=null, new=Window{9c58163 u0 RecentsTransitionOverlay}
10-04 16:55:33.449  1427  7972 D FreeformController: setBlockToAddForceHideFreeformTasks: blockToAddForceHide=true, Caller=com.android.server.wm.FreeformController.finishPostLayoutPolicyLw:894
10-04 16:55:33.450  1427  7972 D WindowManager: Deferring tryFinish, activeSyncs=[428]
10-04 16:55:33.450  1427  7972 V Transition:  allReady query: used=true, override=true, defer=0, states=Display{#0 state=ON size=1080x2400 ROTATION_0}:true
10-04 16:55:33.450  2453  7396 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: Resizing android.view.ViewRootImpl@233dbc0: frame = [539,2399][540,2400] reportDraw = false forceLayout = false syncSeqId = -1
10-04 16:55:33.451  2042  2164 I ShellTransitions: startTransition done, active=android.os.BinderProxy@f2d2013@-1
10-04 16:55:33.451  1427  1472 D ActivityTaskManager: scheduleTopResumedActivityChanged, onTop=true, r=ActivityRecord{38c4e65 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity t7}, caller=com.android.server.wm.ActivityTaskSupervisor.scheduleTopResumedActivityStateIfNeeded:2857 com.android.server.wm.ActivityTaskSupervisor.handleTopResumedStateReleased:2886 com.android.server.wm.ActivityClientController.activityTopResumedStateLost:272 android.app.IActivityClientController$Stub.onTransact:678 com.android.server.wm.ActivityClientController.onTransact:186 android.os.Binder.execTransactInternal:1375 
10-04 16:55:33.451  2042  2164 V ShellRecents: [44710043] RecentsController.setTransition: id=android.os.BinderProxy@f2d2013
10-04 16:55:33.451  2042  2164 V WindowManagerShell: Do not update drop target window visibility: window is already set to 4.
10-04 16:55:33.452  1073  1073 I Layer   : Layer [com.android.systemui.wallpapers.ImageWallpaper_system$_2042#84] hidden!! flag(0)
10-04 16:55:33.452  1073  1073 I Layer   : Layer [RecentsTransitionOverlay$_2453#132] hidden!! flag(0)
10-04 16:55:33.452  1073  1073 I BpBinder: onLastStrongRef automatically unlinking death recipients: 
10-04 16:55:33.452  1427  1902 I CocktailBarManagerServiceContainer: handleMessage: entry what = 5
10-04 16:55:33.453  2453  2453 I HoneySpace.LeashOverlayWindowImpl: createAndAddGestureView : com.honeyspace.gesture.presentation.GestureTaskListView{a8026bc V.ED..... ......I. 0,0-0,0}
10-04 16:55:33.453  2453  2453 I HoneySpace.GestureTaskListView: AppearTaskList, without animation
10-04 16:55:33.453  2453  2453 I HoneySpace.GestureTaskListView: AppearTaskList, without animation
10-04 16:55:33.453  1427  1581 D SGM:FgCheckThread: noteResumeComponent(), received pkgName: com.sec.android.app.launcher, userId: 0
10-04 16:55:33.453  2453  2453 I HoneySpace.PhoneIconStyleFactory: init densityDpi=480, adjustedDpi=480
10-04 16:55:33.453  2453  2453 I HoneySpace.PhoneIconStyleFactory: getNearGridOption, Point(4, 5) -> Point(4, 5)
10-04 16:55:33.453  3946  3946 I SDHMS:LOAD: type: LoadsFreqs, value: 0:0:0:0:0:0:0:0:0:0:0:0
10-04 16:55:33.454  2453  2453 I HoneySpace.RecentStyler: context = android.window.WindowContext@5c5f645, styleData = RecentStyleData(windowBounds=WindowBounds width=1080 height=2400, bounds=Rect(0, 0 - 1080, 2400) insets=Insets{left=0, top=80, right=0, bottom=144}, systemInsets=Insets{left=0, top=80, right=0, bottom=144}cutout=Rect(0, 80 - 0, 0), gestureInsets=Insets{left=0, top=116, right=0, bottom=144}, gestureActionInsets=Insets{left=0, top=116, right=0, bottom=144}, insetsIgnoreCutout=Insets{left=0, top=80, right=0, bottom=144}, baseScreenSize=Point(1080, 2256)screenSizeInGesture=Point(1080, 2256), screenSizeIncludeCutout: Point(1080, 2256), iconSize=175, iconGravity=1, iconStarMargin=0, sceneScale=PointF(0.6, 0.6), sceneCoordinate=RectF(216.0, 386.4, 864.0, 1692.0001), sceneTopMargin=87, taskViewCoordinate=RectF(216.0, 299.4, 864.0, 1692.0001), sceneFullyScale=PointF(1.6666666, 1.8382351), gridExtraGap=0.0, sceneRadius=45.0, deviceRadius=-32.0, mwRadius=(30.0, 51.0), curveEffectScale=0.135, pageSpacing=16, pageSideMargin=0, sceneStartMargin=0, circularListGap=0, topTaskCount=0, bottomTaskCount=0, taskLockIconSize=168, listSceneScale=PointF(0.6, 0.6), listSceneSize=RectF(0.0, 0.0, 648.0, 1305.6001), listSceneRadius=45.0)
10-04 16:55:33.454  2453  2453 I HoneySpace.GestureTaskListView: refresh
10-04 16:55:33.454  2453  2453 I HoneySpace.WindowBounds: updateNavigationMode? BUTTON
10-04 16:55:33.454  2453  2453 I HoneySpace.WindowBounds: immersiveNavigation? false
10-04 16:55:33.454  2453  2453 I HoneySpace.WindowBounds: setInsetAndCutout, Bounds=Rect(0, 0 - 1080, 2400), AppBounds=Rect(0, 80 - 1080, 2256)
10-04 16:55:33.454  2453  2453 I HoneySpace.WindowBounds: update window bounds, name = android.window.WindowContext, context = android.window.WindowContext, call from {com.honeyspace.gesture.presentation.GestureTaskListView$refresh$1.invokeSuspend(Unknown Source:29)}
10-04 16:55:33.454  2453  2453 I HoneySpace.WindowBounds: WindowBounds width=1080 height=2400, bounds=Rect(0, 0 - 1080, 2400) insets=Insets{left=0, top=80, right=0, bottom=144}, systemInsets=Insets{left=0, top=80, right=0, bottom=144}cutout=Rect(0, 80 - 0, 0), gestureInsets=Insets{left=0, top=116, right=0, bottom=144}, gestureActionInsets=Insets{left=0, top=116, right=0, bottom=144}, insetsIgnoreCutout=Insets{left=0, top=80, right=0, bottom=144}, baseScreenSize=Point(1080, 2256)screenSizeInGesture=Point(1080, 2256), screenSizeIncludeCutout: Point(1080, 2256)
10-04 16:55:33.454  1427  1581 D SGM:GameManager: identifyGamePackage. com.sec.android.app.launcher, mCurrentUserId: 0, callerUserId: 0, callingMethodInfo: com.samsung.android.game.SemGameManager.isGamePackage(SemGameManager.java:109)
10-04 16:55:33.454  1427  1581 D SGM:PkgDataHelper: getGamePkgData(). com.sec.android.app.launcher
10-04 16:55:33.454  2453  2453 I HoneySpace.AnimationSession: toggleRecents - wait recents activity started
10-04 16:55:33.454  1427  1581 D SGM:SemGameManager: isGamePackage(), pkgName=com.sec.android.app.launcher, ret=false
10-04 16:55:33.454  2453  2453 I HoneySpace.AnimationSession: toggleRecents recentsActivityStarted: false
10-04 16:55:33.454  2453  2453 I HoneySpace.GestureRecentViewControllerImpl: collect leashRunningTaskId : 148
10-04 16:55:33.455  2453  2453 I HoneySpace.PhoneIconStyleFactory: init densityDpi=480, adjustedDpi=480
10-04 16:55:33.455  2453  2453 I HoneySpace.PhoneIconStyleFactory: getNearGridOption, Point(4, 5) -> Point(4, 5)
10-04 16:55:33.455  2453  2453 I HoneySpace.RecentStyler: context = android.window.WindowContext@5c5f645, styleData = RecentStyleData(windowBounds=WindowBounds width=1080 height=2400, bounds=Rect(0, 0 - 1080, 2400) insets=Insets{left=0, top=80, right=0, bottom=144}, systemInsets=Insets{left=0, top=80, right=0, bottom=144}cutout=Rect(0, 80 - 0, 0), gestureInsets=Insets{left=0, top=116, right=0, bottom=144}, gestureActionInsets=Insets{left=0, top=116, right=0, bottom=144}, insetsIgnoreCutout=Insets{left=0, top=80, right=0, bottom=144}, baseScreenSize=Point(1080, 2256)screenSizeInGesture=Point(1080, 2256), screenSizeIncludeCutout: Point(1080, 2256), iconSize=175, iconGravity=1, iconStarMargin=0, sceneScale=PointF(0.6, 0.6), sceneCoordinate=RectF(216.0, 386.4, 864.0, 1692.0001), sceneTopMargin=87, taskViewCoordinate=RectF(216.0, 299.4, 864.0, 1692.0001), sceneFullyScale=PointF(1.6666666, 1.8382351), gridExtraGap=0.0, sceneRadius=45.0, deviceRadius=-32.0, mwRadius=(30.0, 51.0), curveEffectScale=0.135, pageSpacing=16, pageSideMargin=0, sceneStartMargin=0, circularListGap=0, topTaskCount=0, bottomTaskCount=0, taskLockIconSize=168, listSceneScale=PointF(0.6, 0.6), listSceneSize=RectF(0.0, 0.0, 648.0, 1305.6001), listSceneRadius=45.0)
10-04 16:55:33.455  2453  2453 I HoneySpace.TaskListViewModel: rotationChanged
10-04 16:55:33.455  2453  2453 I HoneySpace.TaskListViewModel: prevRotation: -1, newRotation: 2
10-04 16:55:33.455  2453  2453 I HoneySpace.TaskBooster: boost TASK_BOOST: 2453
10-04 16:55:33.455  2453  2453 I HoneySpace.TaskListViewModel: GroupTask [
10-04 16:55:33.455  2453  2453 I HoneySpace.TaskListViewModel:  Task1 : [id=148 windowingMode=1 user=0 lastActiveTime=156074121] null, isCoverLauncherTask = false, isLocked = false - com.companyname.mauiappwindowtest]
10-04 16:55:33.455  2453  2453 I HoneySpace.TaskListViewModel: applyTaskListData: 1
10-04 16:55:33.455  2453  2453 I ViewRootImpl@1f7ce54[RecentsActivity]: handleAppVisibility mAppVisible = false visible = true
10-04 16:55:33.456  2453  2453 I ViewRootImpl@1f7ce54[RecentsActivity]: stopped(false) old = true
10-04 16:55:33.456  2453  2453 I HoneySpace.RecentsActivity: !@Boot_EBS_D: RecentsActivity.onResume()
10-04 16:55:33.456  2453  2453 I HoneySpace.RecentscreenPot: onResume() called
10-04 16:55:33.456  2453  2453 I HoneySpace.SPayHandler: currentIndex : 0, defaultIndex : 0
10-04 16:55:33.456  2453  2453 I HoneySpace.TaskListPot: onResume() called
10-04 16:55:33.456  2453  2453 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: handleResized, msg = 4 frames=ClientWindowFrames{frame=[539,2399][540,2400] display=[0,0][1080,2400] parentFrame=[0,0][0,0]} forceNextWindowRelayout=false displayId=0 dragResizing=false compatScale=1.0 frameChanged=false attachedFrameChanged=false configChanged=false displayChanged=false compatScaleChanged=false
10-04 16:55:33.456  1427  1581 I GameSDK@LifeCycle: noteResumeComponent(): package name  : com.sec.android.app.launcher
10-04 16:55:33.456  2453  2453 I HoneySpace.TaskListViewModel: isClearAll: 1, 0, false
10-04 16:55:33.456  2453  2453 I HoneySpace.TaskListPot: emptyMessageEnabled : false 1
10-04 16:55:33.456  2453  2453 I HoneySpace.TaskListPot: applyLoadPlans() => tasks: 1 / 1
10-04 16:55:33.456  2453  2586 I HoneySpace.TopTaskSource: onTaskMovedToFront : taskId = 7
10-04 16:55:33.456  1427  1581 I ActivityManager: Changes in 10137 5 to 2, 56 to 63
10-04 16:55:33.457  2453 15403 I HoneySpace.OneUiSpace: received close system dialog reason=recentapps
10-04 16:55:33.458  1427  1579 D NetworkPolicy: already checked 10137
10-04 16:55:33.459  2453  2588 I HoneySpace.TopTaskUseCase: topTasks 7 ComponentInfo{com.sec.android.app.launcher/com.android.quickstep.RecentsActivity}
10-04 16:55:33.459  2042  2042 I AODNotificationManager: updateNotification() 
10-04 16:55:33.460  2453 15400 I HoneySpace.SPayHandler: updateSpayHandler, show = false, defaultPage = true
10-04 16:55:33.460  1427  1579 D PkgPredictorService-SecIpmManagerServiceImpl: onForegroundActivitiesChanged pid:2453 uid:10137
10-04 16:55:33.460  1427  3057 V PkgPredictorService-SecIpmManagerServiceImpl: discard foreground app:com.sec.android.app.launcher 1|true
10-04 16:55:33.461  1427  7972 V WindowManager: Relayout Window{9c58163 u0 RecentsTransitionOverlay}: viewVisibility=0 req=1x1 ty=2632 d0
10-04 16:55:33.462  1427  7972 V WindowManager: SyncGroup 428: Finished!
10-04 16:55:33.462  1427  7972 D ChangeTransitionController: onTransactionReady: TransitionRecord{e22f8cd id=428 type=TO_FRONT flags=0x80}
10-04 16:55:33.462  1427  7972 V WindowManager: Start calculating TransitionInfo based on participants: {WallpaperWindowToken{1f6c5ec token=android.os.Binder@a0f609f}, ActivityRecord{38c4e65 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity t7}, Task{3a7474e #148 type=standard A=10384:com.companyname.mauiappwindowtest}, Task{9be573a #7 type=recents I=com.sec.android.app.launcher/com.android.quickstep.RecentsActivity}, TransientLaunchOverlayToken{fb49392 token=android.os.BinderProxy@2aee51d}}
10-04 16:55:33.462  1427  7972 V WindowManager:   Final targets: [TransientLaunchOverlayToken{fb49392 token=android.os.BinderProxy@2aee51d}, Task{9be573a #7 type=recents I=com.sec.android.app.launcher/com.android.quickstep.RecentsActivity}, Task{3a7474e #148 type=standard A=10384:com.companyname.mauiappwindowtest}]
10-04 16:55:33.463  1073  2909 I SurfaceFlinger: id=5556 createSurf, flag=84004, Transition Root: Task=7#5556
10-04 16:55:33.464  1427  7972 I SurfaceControl: show, t=StartTransaction_SyncId<428>, sc=Surface(name=ActivityRecord{38c4e65 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity t7})/@0x1799e32, caller=com.android.server.wm.Transition.onTransactionReady:1992 com.android.server.wm.BLASTSyncEngine$SyncGroup.finishNow:315 com.android.server.wm.BLASTSyncEngine$SyncGroup.tryFinish:242 com.android.server.wm.BLASTSyncEngine$SyncGroup.-$$Nest$mtryFinish:0 com.android.server.wm.BLASTSyncEngine.onSurfacePlacement:675 com.android.server.wm.RootWindowContainer.performSurfacePlacementNoTrace:990 
10-04 16:55:33.464  1427  7972 I SurfaceControl: hide, t=FinishTransaction_SyncId<428>, sc=Surface(name=TransientLaunchOverlayToken{fb49392 token=android.os.BinderProxy@2aee51d})/@0x97b939, caller=com.android.server.wm.Transition.buildFinishTransaction:1195 com.android.server.wm.Transition.onTransactionReady:2057 com.android.server.wm.BLASTSyncEngine$SyncGroup.finishNow:315 com.android.server.wm.BLASTSyncEngine$SyncGroup.tryFinish:242 com.android.server.wm.BLASTSyncEngine$SyncGroup.-$$Nest$mtryFinish:0 com.android.server.wm.BLASTSyncEngine.onSurfacePlacement:675 
10-04 16:55:33.464  1427  7972 V WindowManager: Calling onTransitionReady: {id=428 t=TO_FRONT f=0x80 trk=0 r=[0@Point(0, 0)] c=[
10-04 16:55:33.464  1427  7972 V WindowManager:         {null m=TO_FRONT f=TRANSLUCENT|FLAG_IS_SYSTEM_WINDOW|TRANSIENT_LAUNCH_OVERLAY leash=Surface(name=TransientLaunchOverlayToken{fb49392 token=android.os.BinderProxy@2aee51d})/@0x97b939 sb=Rect(0, 0 - 1080, 2400) eb=Rect(0, 0 - 1080, 2400) d=0 inset=Rect(0, 0 - 0, 0)},
10-04 16:55:33.464  1427  7972 V WindowManager:         {WCT{RemoteToken{f9558df Task{9be573a #7 type=recents I=com.sec.android.app.launcher/com.android.quickstep.RecentsActivity}}} m=TO_FRONT f=SHOW_WALLPAPER|MOVE_TO_TOP|EDGE_EXTENSION_RESTRICTION leash=Surface(name=Task=7)/@0x78c0d00 sb=Rect(0, 0 - 1080, 2400) eb=Rect(0, 0 - 1080, 2400) d=0 inset=Rect(0, 80 - 0, 144)},
10-04 16:55:33.464  1427  7972 V WindowManager:         {WCT{RemoteToken{cd3e59d Task{3a7474e #148 type=standard A=10384:com.companyname.mauiappwindowtest}}} m=TO_BACK f= leash=Surface(name=Task=148)/@0x9847b86 sb=Rect(0, 0 - 1080, 2400) eb=Rect(0, 0 - 1080, 2400) d=0 dim=true inset=Rect(0, 80 - 0, 144)}
10-04 16:55:33.464  1427  7972 V WindowManager:     ]}
10-04 16:55:33.465  1247  2211 I CameraService: onUidStateChanged: uid=10043, procState is changed. (0 -> 1)
10-04 16:55:33.467  1427  1578 V WindowManager: Sent Transition #428 createdAt=10-04 16:55:33.442
10-04 16:55:33.467  1427  1578 V WindowManager:     startWCT=WindowContainerTransaction { changes = {} hops = [{PendingIntent: options=Bundle[{android.activity.splashScreenStyle=-1, android.activity.sourceInfo=android.app.ActivityOptions$SourceInfo@d77b5fc, android:activity.isMlLaunch=-1, android.activity.splitTaskDeferResume=false, android:activity.isActiveLaunch=false, android.activity.forceLaunchTaskOnHome=false, android.activity.launchTypeDnD=false, android:activity.startedFromWindowTypeLauncher=false, android:activity.launchInFocusedStageRoot=false, android:activity.dismissSplitBeforeLaunch=false, android:activity.applyBigFreeformSize=false, android.activity.enterPipWhileLaunching=false, android.activity.splitPosition=0, android.activity.preserveTaskWindowingMode=false, android:activity.enterSplitSideWithAdjacentFlag=0, android.activity.transientLaunch=true}]}] errorCallbackToken=null taskFragmentOrganizer=null }
10-04 16:55:33.467  1427  1578 V WindowManager:     info={id=428 t=TO_FRONT f=0x80 trk=0 r=[0@Point(0, 0)] c=[
10-04 16:55:33.467  1427  1578 V WindowManager:         {null m=TO_FRONT f=TRANSLUCENT|FLAG_IS_SYSTEM_WINDOW|TRANSIENT_LAUNCH_OVERLAY leash=Surface(name=TransientLaunchOverlayToken{fb49392 token=android.os.BinderProxy@2aee51d})/@0x97b939 sb=Rect(0, 0 - 1080, 2400) eb=Rect(0, 0 - 1080, 2400) d=0 inset=Rect(0, 0 - 0, 0)},
10-04 16:55:33.467  1427  1578 V WindowManager:         {WCT{RemoteToken{f9558df Task{9be573a #7 type=recents I=com.sec.android.app.launcher/com.android.quickstep.RecentsActivity}}} m=TO_FRONT f=SHOW_WALLPAPER|MOVE_TO_TOP|EDGE_EXTENSION_RESTRICTION leash=Surface(name=Task=7)/@0x78c0d00 sb=Rect(0, 0 - 1080, 2400) eb=Rect(0, 0 - 1080, 2400) d=0 inset=Rect(0, 80 - 0, 144)},
10-04 16:55:33.467  1427  1578 V WindowManager:         {WCT{RemoteToken{cd3e59d Task{3a7474e #148 type=standard A=10384:com.companyname.mauiappwindowtest}}} m=TO_BACK f= leash=Surface(name=Task=148)/@0x9847b86 sb=Rect(0, 0 - 1080, 2400) eb=Rect(0, 0 - 1080, 2400) d=0 dim=true inset=Rect(0, 80 - 0, 144)}
10-04 16:55:33.467  1427  1578 V WindowManager:     ]}
10-04 16:55:33.467  2042  2164 V WindowManagerShell: onTransitionReady android.os.BinderProxy@f2d2013: {id=428 t=TO_FRONT f=0x80 trk=0 r=[0@Point(0, 0)] c=[{null m=TO_FRONT f=TRANSLUCENT|FLAG_IS_SYSTEM_WINDOW|TRANSIENT_LAUNCH_OVERLAY leash=Surface(name=TransientLaunchOverlayToken{fb49392 token=android.os.BinderProxy@2aee51d})/@0x9146b68 sb=Rect(0, 0 - 1080, 2400) eb=Rect(0, 0 - 1080, 2400) d=0 inset=Rect(0, 0 - 0, 0)},{WCT{android.window.IWindowContainerToken$Stub$Proxy@678d614} m=TO_FRONT f=SHOW_WALLPAPER|MOVE_TO_TOP|EDGE_EXTENSION_RESTRICTION leash=Surface(name=Task=7)/@0xdb9b81 sb=Rect(0, 0 - 1080, 2400) eb=Rect(0, 0 - 1080, 2400) d=0 inset=Rect(0, 80 - 0, 144)},{WCT{android.window.IWindowContainerToken$Stub$Proxy@a256ebd} m=TO_BACK f= leash=Surface(name=Task=148)/@0xda8b426 sb=Rect(0, 0 - 1080, 2400) eb=Rect(0, 0 - 1080, 2400) d=0 dim=true inset=Rect(0, 80 - 0, 144)}]}
10-04 16:55:33.468  2042  2164 I SurfaceControl: hide, t=FinishTransaction_SyncId<428>, sc=Surface(name=Task=148)/@0xda8b426, caller=com.android.wm.shell.transition.Transitions.dispatchReady:681 com.android.wm.shell.transition.Transitions.onTransitionReady:118 com.android.wm.shell.transition.Transitions$TransitionPlayerImpl$$ExternalSyntheticLambda0.run:13 android.os.Handler.handleCallback:958 android.os.Handler.dispatchMessage:99 android.os.Looper.loopOnce:230 
10-04 16:55:33.468  2042  2164 I SurfaceControl: show, t=StartTransaction_SyncId<428>, sc=Surface(name=Task=7)/@0xdb9b81, caller=com.android.wm.shell.transition.Transitions.dispatchReady:686 com.android.wm.shell.transition.Transitions.onTransitionReady:118 com.android.wm.shell.transition.Transitions$TransitionPlayerImpl$$ExternalSyntheticLambda0.run:13 android.os.Handler.handleCallback:958 android.os.Handler.dispatchMessage:99 android.os.Looper.loopOnce:230 
10-04 16:55:33.468  2042  2164 I SurfaceControl: show, t=FinishTransaction_SyncId<428>, sc=Surface(name=Task=7)/@0xdb9b81, caller=com.android.wm.shell.transition.Transitions.dispatchReady:743 com.android.wm.shell.transition.Transitions.onTransitionReady:118 com.android.wm.shell.transition.Transitions$TransitionPlayerImpl$$ExternalSyntheticLambda0.run:13 android.os.Handler.handleCallback:958 android.os.Handler.dispatchMessage:99 android.os.Looper.loopOnce:230 
10-04 16:55:33.468  2042  2164 V WindowManagerShell: Playing animation for (#428)android.os.BinderProxy@f2d2013@0
10-04 16:55:33.468  2042  2164 I SurfaceControl: show, t=StartTransaction_SyncId<428>, sc=Surface(name=Transition Root: Task=7)/@0x31c7867, caller=com.android.wm.shell.transition.Transitions.playTransition:80 com.android.wm.shell.transition.Transitions.processReadyQueue:195 com.android.wm.shell.transition.Transitions.dispatchReady:761 com.android.wm.shell.transition.Transitions.onTransitionReady:118 com.android.wm.shell.transition.Transitions$TransitionPlayerImpl$$ExternalSyntheticLambda0.run:13 android.os.Handler.handleCallback:958 
10-04 16:55:33.468  2042  2164 V WindowManagerShell:  try firstHandler com.android.wm.shell.recents.RecentsTransitionHandler@2cc40a3
10-04 16:55:33.468  2042  2164 V ShellRecents: [44710043] RecentsController.start
10-04 16:55:33.468  1073  2909 I SurfaceFlinger: id=5557 createSurf, flag=84000, Surface(name=TransientLaunchOverlayToken{fb49392 token=android.os.BinderProxy@2aee51d})/@0x9146b68_transition-leash#5557
10-04 16:55:33.468  2042  2164 I SurfaceControl: show, t=StartTransaction_SyncId<428>, sc=Surface(name=TransientLaunchOverlayToken{fb49392 token=android.os.BinderProxy@2aee51d})/@0x9146b68, caller=com.android.wm.shell.util.TransitionUtil.createLeash:353 com.android.wm.shell.util.TransitionUtil.newTarget:1 com.android.wm.shell.recents.RecentsTransitionHandler.startAnimation:1349 com.android.wm.shell.transition.Transitions.playTransition:734 com.android.wm.shell.transition.Transitions.processReadyQueue:195 com.android.wm.shell.transition.Transitions.dispatchReady:761 
10-04 16:55:33.468  1073  2909 I SurfaceFlinger: id=5558 createSurf, flag=84000, Surface(name=Task=7)/@0xdb9b81_transition-leash#5558
10-04 16:55:33.469  2042  2164 I SurfaceControl: show, t=StartTransaction_SyncId<428>, sc=Surface(name=Task=7)/@0xdb9b81, caller=com.android.wm.shell.util.TransitionUtil.createLeash:353 com.android.wm.shell.recents.RecentsTransitionHandler.startAnimation:926 com.android.wm.shell.transition.Transitions.playTransition:734 com.android.wm.shell.transition.Transitions.processReadyQueue:195 com.android.wm.shell.transition.Transitions.dispatchReady:761 com.android.wm.shell.transition.Transitions.onTransitionReady:118 
10-04 16:55:33.469  2042  2164 V ShellRecents:   setting recents activity layer=5
10-04 16:55:33.469  1073  2909 I SurfaceFlinger: id=5559 createSurf, flag=84000, Surface(name=Task=148)/@0xda8b426_transition-leash#5559
10-04 16:55:33.469  2042  2164 I SurfaceControl: show, t=StartTransaction_SyncId<428>, sc=Surface(name=Task=148)/@0xda8b426, caller=com.android.wm.shell.util.TransitionUtil.createLeash:353 com.android.wm.shell.recents.RecentsTransitionHandler.startAnimation:926 com.android.wm.shell.transition.Transitions.playTransition:734 com.android.wm.shell.transition.Transitions.processReadyQueue:195 com.android.wm.shell.transition.Transitions.dispatchReady:761 com.android.wm.shell.transition.Transitions.onTransitionReady:118 
10-04 16:55:33.469  2042  2164 V ShellRecents:   adding pausing leaf taskId=148 at layer=7
10-04 16:55:33.469  2042  2164 I SurfaceControl: apply is called, name=StartTransaction_SyncId<428>, caller=android.view.SurfaceControl$Transaction.apply:2921 com.android.wm.shell.recents.RecentsTransitionHandler.startAnimation:1398 com.android.wm.shell.transition.Transitions.playTransition:734 com.android.wm.shell.transition.Transitions.processReadyQueue:195 com.android.wm.shell.transition.Transitions.dispatchReady:761 com.android.wm.shell.transition.Transitions.onTransitionReady:118 
10-04 16:55:33.470  2042  2164 V ShellRecents: [44710043] RecentsController.start: calling onAnimationStart
10-04 16:55:33.470  2453 10484 I HoneySpace.RecentTasks: onAnimationStateChanged() called with: running = true
10-04 16:55:33.470  2453 29799 I HoneySpace.ShellTransitionManager: startGestureTransition, onAnimationStart, scope:CoroutineScope(coroutineContext=[SupervisorJobImpl{Active}@38940f9, Dispatchers.Default])
10-04 16:55:33.471  2042  2164 V WindowManagerShell:  animated by firstHandler
10-04 16:55:33.471  2453  7396 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: Resizing android.view.ViewRootImpl@233dbc0: frame = [0,0][1080,2400] reportDraw = false forceLayout = false syncSeqId = -1
10-04 16:55:33.473  1427  7972 V WindowManager: Relayout hash=9c58163, pid=2453, syncId=-1: mAttrs={(0,0)(fillxfill) gr=BOTTOM CENTER_VERTICAL sim={adjust=pan} layoutInDisplayCutoutMode=always ty=TRANSIENT_LAUNCH_OVERLAY fmt=TRANSLUCENT if=INPUT_FEATURE_NO_INPUT_CHANNEL
10-04 16:55:33.473  1427  7972 V WindowManager:   fl=118
10-04 16:55:33.473  1427  7972 V WindowManager:   pfl=12000000
10-04 16:55:33.473  1427  7972 V WindowManager:   bhv=DEFAULT naviIconColor=0
10-04 16:55:33.473  1427  7972 V WindowManager:   sfl=4020000}
10-04 16:55:33.473  2453  2453 I BLASTBufferQueue_Java: update, w= 1080 h= 2400 mName = ViewRootImpl@ec6b24c[RecentsTransitionOverlay] mNativeObject= 0xb4000078cd40ddd0 sc.mNativeObject= 0xb400007a2d4062d0 format= -3 caller= android.view.ViewRootImpl.updateBlastSurfaceIfNeeded:3017 android.view.ViewRootImpl.relayoutWindow:10131 android.view.ViewRootImpl.performTraversals:4110 android.view.ViewRootImpl.doTraversal:3288 android.view.ViewRootImpl$TraversalRunnable.run:11344 android.view.Choreographer$CallbackRecord.run:1689 
10-04 16:55:33.473  2453  2453 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: Relayout returned: old=(539,2399,540,2400) new=(0,0,1080,2400) relayoutAsync=false req=(1,1)0 dur=12 res=0x0 s={true 0xb40000781d441ce0} ch=false seqId=0
10-04 16:55:33.474  2453  2453 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: registerCallbackForPendingTransactions
10-04 16:55:33.474  2453  4618 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d48fd30 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3587 mRenderHdrSdrRatio=1.0 caller= android.view.ViewRootImpl$6.onFrameDraw:5635 android.view.ViewRootImpl$2.onFrameDraw:2146 android.view.ThreadedRenderer$1.onFrameDraw:792 
10-04 16:55:33.475  1427  7972 V WindowManager: Relayout Window{e458a32 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity}: viewVisibility=0 req=1080x2400 ty=1 d0
10-04 16:55:33.475  1427  7972 D RestrictionPolicy: isScreenCaptureEnabled : ret=true userId=0
10-04 16:55:33.475  1073  2909 I SurfaceFlinger: id=5560 createSurf, flag=44004, com.sec.android.app.launcher/com.android.quickstep.RecentsActivity$_2453#5560
10-04 16:55:33.476  1427  7972 D WindowManager: makeSurface duration=1 name=com.sec.android.app.launcher/com.android.quickstep.RecentsActivity$_2453
10-04 16:55:33.477  1427  7972 V WindowManager: Relayout hash=e458a32, pid=2453, syncId=-1: mAttrs={(0,0)(fillxfill) sim={adjust=resize forwardNavigation} layoutInDisplayCutoutMode=shortEdges ty=BASE_APPLICATION fmt=TRANSPARENT wanim=0x10302f2
10-04 16:55:33.477  1427  7972 V WindowManager:   fl=81910100
10-04 16:55:33.477  1427  7972 V WindowManager:   pfl=12008040
10-04 16:55:33.477  1427  7972 V WindowManager:   bhv=DEFAULT
10-04 16:55:33.477  1427  7972 V WindowManager:   fitSides= naviIconColor=0}
10-04 16:55:33.478  1073  1073 I Layer   : Layer [TransientLaunchOverlayToken{fb49392 token=android.os.BinderProxy@2aee51d}#127] hidden!! flag(0)
10-04 16:55:33.478  1073  1073 I Layer   : Layer [Task=7#125] hidden!! flag(0)
10-04 16:55:33.478  1073  1073 I Layer   : Layer [Transition Root: Task=7#5556] hidden!! flag(0)
10-04 16:55:33.478  1073  1073 I Layer   : Layer [ActivityRecord{38c4e65 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity t7}#126] hidden!! flag(0)
10-04 16:55:33.478  1073  1073 I Layer   : Layer [Input Consumer recents_animation_input_consumer#124] hidden!! flag(0)
10-04 16:55:33.479  2453  2453 I BLASTBufferQueue_Java: new BLASTBufferQueue, mName= ViewRootImpl@1f7ce54[RecentsActivity] mNativeObject= 0xb4000078cd442350 sc.mNativeObject= 0xb400007a2d415510 caller= android.view.ViewRootImpl.updateBlastSurfaceIfNeeded:3028 android.view.ViewRootImpl.relayoutWindow:10131 android.view.ViewRootImpl.performTraversals:4110 android.view.ViewRootImpl.doTraversal:3288 android.view.ViewRootImpl$TraversalRunnable.run:11344 android.view.Choreographer$CallbackRecord.run:1689 android.view.Choreographer$CallbackRecord.run:1698 android.view.Choreographer.doCallbacks:1153 android.view.Choreographer.doFrame:1079 android.view.Choreographer$FrameDisplayEventReceiver.run:1646 
10-04 16:55:33.480  2453  2453 I BLASTBufferQueue_Java: update, w= 1080 h= 2400 mName = ViewRootImpl@1f7ce54[RecentsActivity] mNativeObject= 0xb4000078cd442350 sc.mNativeObject= 0xb400007a2d415510 format= -2 caller= android.graphics.BLASTBufferQueue.<init>:89 android.view.ViewRootImpl.updateBlastSurfaceIfNeeded:3028 android.view.ViewRootImpl.relayoutWindow:10131 android.view.ViewRootImpl.performTraversals:4110 android.view.ViewRootImpl.doTraversal:3288 android.view.ViewRootImpl$TraversalRunnable.run:11344 
10-04 16:55:33.480  2453  2453 I ViewRootImpl@1f7ce54[RecentsActivity]: Relayout returned: old=(0,0,1080,2400) new=(0,0,1080,2400) relayoutAsync=false req=(1080,2400)0 dur=4 res=0x403 s={true 0xb40000781d541460} ch=true seqId=0
10-04 16:55:33.480  2453  2453 I HoneySpace.TaskView: bindTaskView, tasks = [[id=148 windowingMode=1 user=0 lastActiveTime=156074121] null], view: b505933
10-04 16:55:33.480  2453  2453 I HoneySpace.TaskAdapter: attach [position: 0], taskData size: 1, item: ComponentInfo{com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity}, animReady: 2, firstBindingComplete: 3, view: b505933
10-04 16:55:33.480  2453  2453 I HoneySpace.TaskListPot: onTaskViewEnterAnimReady
10-04 16:55:33.480  2453  2453 I HoneySpace.GestureRecentViewControllerImpl: startAppToRecents, enterWith: 1, homeIsOnTop: false, runningTaskId: 148
10-04 16:55:33.480  2453  2453 I HoneySpace.TaskListViewModel: setGestureActive, active = true
10-04 16:55:33.480  2453  2453 I HoneySpace.BaseRecentsView: startPropertyOnTaskAnimation, needAnim = false
10-04 16:55:33.480  2453 15403 I HoneySpace.TaskViewModel: updateThumbnail with gesture screenshotTask
10-04 16:55:33.480  2453  2453 I HoneySpace.TaskListViewModel: updateRunningTaskId: 148
10-04 16:55:33.480  2453 12445 I HoneySpace.TaskDataRepositoryImpl: Request icon and label, id=148, iconAndLabel: IconAndLabel(icon=android.graphics.Bitmap@496cd99, label=MauiAppWindowTest), componentKey: com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity#UserHandle{0}
10-04 16:55:33.481  2453  2453 I HoneySpace.GestureRecentViewControllerImpl: onTaskViewAddComplete ENTER_WITH_TOGGLE
10-04 16:55:33.481  2453  2453 I HoneySpace.TaskListPot: onTaskViewAddComplete() => homeIsOnTop: false, enterWith: 1, initScrollAfterAddComplete: false
10-04 16:55:33.481  2453  2453 I HoneySpace.TouchControllerImpl: reset
10-04 16:55:33.481  2453  2453 I ViewRootImpl@1f7ce54[RecentsActivity]: Setup new sync=wmsSync-ViewRootImpl@1f7ce54[RecentsActivity]#68
10-04 16:55:33.481  2453  2453 I ViewRootImpl@1f7ce54[RecentsActivity]: Creating new active sync group ViewRootImpl@1f7ce54[RecentsActivity]#69
10-04 16:55:33.481  1247  2211 I CameraService: onUidStateChanged: uid=10043, procState is changed. (1 -> 0)
10-04 16:55:33.483  2453  2453 I ViewRootImpl@1f7ce54[RecentsActivity]: registerCallbacksForSync syncBuffer=false
10-04 16:55:33.484  2453  2562 I HoneySpace.SALoggingUtils: SA Logging screenID: 500 eventId: 5160 detail: {det=com.companyname.mauiappwindowtest} value: -1
10-04 16:55:33.484  2453  4617 I ViewRootImpl@1f7ce54[RecentsActivity]: Received frameDrawingCallback syncResult=0 frameNum=1.
10-04 16:55:33.484  2453  4617 I ViewRootImpl@1f7ce54[RecentsActivity]: mWNT: t=0xb40000786d499730 mBlastBufferQueue=0xb4000078cd442350 fn= 1 mRenderHdrSdrRatio=1.0 caller= android.view.ViewRootImpl$8.onFrameDraw:13841 android.view.ThreadedRenderer$1.onFrameDraw:792 <bottom of call stack> 
10-04 16:55:33.484  2453  4617 I ViewRootImpl@1f7ce54[RecentsActivity]: Setting up sync and frameCommitCallback
10-04 16:55:33.485  2453  4470 I BLASTBufferQueue: [ViewRootImpl@1f7ce54[RecentsActivity]#231](f:0,a:0,s:0) onFrameAvailable the first frame is available
10-04 16:55:33.485  2453  4470 I ViewRootImpl@1f7ce54[RecentsActivity]: Received frameCommittedCallback lastAttemptedDrawFrameNum=1 didProduceBuffer=true
10-04 16:55:33.485  2453  2453 I ViewRootImpl@1f7ce54[RecentsActivity]: reportDrawFinished seqId=0
10-04 16:55:33.485  1427  7972 D WindowManager: finishDrawingWindow: Window{e458a32 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity} mDrawState=DRAW_PENDING seqId=0
10-04 16:55:33.486  2453  2453 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: handleResized, msg = 4 frames=ClientWindowFrames{frame=[0,0][1080,2400] display=[0,0][1080,2400] parentFrame=[0,0][0,0]} forceNextWindowRelayout=false displayId=0 dragResizing=false compatScale=1.0 frameChanged=false attachedFrameChanged=false configChanged=false displayChanged=false compatScaleChanged=false
10-04 16:55:33.486  2453  2453 I HoneySpace.ListTaskViewHolder: loadThumbnail: tasks = [[id=148 windowingMode=1 user=0 lastActiveTime=156074121] null], 
10-04 16:55:33.486  2453  2453 I HoneySpace.ListTaskViewHolder:  position = 0, taskView = b505933, currentIds: [148], requestedIds: [148]
10-04 16:55:33.486  2453  2453 I HoneySpace.TaskSceneView: thumbnail.size = 0, task.size = 1
10-04 16:55:33.486  2453  2453 I HoneySpace.ListTaskViewHolder: loadIconAndLabel: tasks = [[id=148 windowingMode=1 user=0 lastActiveTime=156074121] null],
10-04 16:55:33.486  2453  2453 I HoneySpace.ListTaskViewHolder:  position = 0, taskView = b505933, currentIds: [148], requestedIds: [148]
10-04 16:55:33.486  2453  2453 I Edge.ActivityUtils: HomePackage : com.sec.android.app.launcher, resumePackageName : com.sec.android.app.launcher
10-04 16:55:33.486  2453  2453 I HoneySpace.RecentsAnimationController: start, isRecentsStarted: true
10-04 16:55:33.486  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions RecentsActivity$_2453#5560 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=3.000, rect=[0, 0, 1080, 2400]
10-04 16:55:33.486  2453  2453 I HoneySpace.RecentsAnimationManager: onAnimationStart
10-04 16:55:33.486  1073  1073 D SurfaceFlinger: GPIS:: requestGpisForBlur
10-04 16:55:33.486  1073  3020 D NativeSemDvfsManager: acquire:: timeout = 2000 mIsAcquired = 1  mTagName : SurfaceFlinger 
10-04 16:55:33.486  1427  1582 D ActivityManagerPerformance: AMP_release() ACT_RESUME
10-04 16:55:33.486  1073  3020 E NativeCustomFrequencyManager: [NativeCFMS] BpCustomFrequencyManager::acquire()
10-04 16:55:33.486  1427  1582 V WindowManager: performShowLocked: mDrawState=HAS_DRAWN in Window{e458a32 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity}
10-04 16:55:33.487   994  1071 I HYPER-HAL: [ResourceManager.cpp]removeResource(): [CPUMinFreq] RemoveResource Request ID : 1041862
10-04 16:55:33.487   994  1071 I HYPER-HAL: [RequestManager.cpp]releaseLocked(): Released ID : 1041862
10-04 16:55:33.487   994  1071 I HYPER-HAL: [RequestManager.cpp]acquire(): Acquired ID : 2150701  [1073 / 1000]    HINT : SF_GPU_MINLOCK    list : [TIMEOUT / 2000] 
10-04 16:55:33.489  1427  1578 D [secipm]: mSecIpmManager report to nap
10-04 16:55:33.490  1427  1578 I PkgPredictorService-SecIpmManagerServiceImpl: reportToNAP uid:10137 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity thisTime:42
10-04 16:55:33.490  1427  1578 D PkgPredictorService-SecIpmManagerServiceImpl: reportToNAP: mHeavyLaunchCounter is false
10-04 16:55:33.490  1427  3057 D PkgPredictorService-SecIpmManagerServiceImpl: ACTION_FOREGROUND_FINISH_EVENT sCurForegroundApp :com.sec.android.app.launcher
10-04 16:55:33.492  2453  2453 I HoneySpace.WindowBounds: updateNavigationMode? BUTTON
10-04 16:55:33.492  2453  2453 I HoneySpace.WindowBounds: immersiveNavigation? false
10-04 16:55:33.492  2453  2453 I HoneySpace.WindowBounds: setInsetAndCutout, Bounds=Rect(0, 0 - 1080, 2400), AppBounds=Rect(0, 80 - 1080, 2256)
10-04 16:55:33.492  2453  2453 I HoneySpace.WindowBounds: update window bounds, name = android.window.WindowContext, context = android.window.WindowContext, call from {com.honeyspace.gesture.recentsanimation.RecentsAnimationManager.onAnimationStart(Unknown Source:148)}
10-04 16:55:33.492  2453  2453 I HoneySpace.WindowBounds: WindowBounds width=1080 height=2400, bounds=Rect(0, 0 - 1080, 2400) insets=Insets{left=0, top=80, right=0, bottom=144}, systemInsets=Insets{left=0, top=80, right=0, bottom=144}cutout=Rect(0, 80 - 0, 0), gestureInsets=Insets{left=0, top=116, right=0, bottom=144}, gestureActionInsets=Insets{left=0, top=116, right=0, bottom=144}, insetsIgnoreCutout=Insets{left=0, top=80, right=0, bottom=144}, baseScreenSize=Point(1080, 2256)screenSizeInGesture=Point(1080, 2256), screenSizeIncludeCutout: Point(1080, 2256)
10-04 16:55:33.492  2453  2453 I HoneySpace.PhoneIconStyleFactory: init densityDpi=480, adjustedDpi=480
10-04 16:55:33.492  2453  2453 I HoneySpace.PhoneIconStyleFactory: getNearGridOption, Point(4, 5) -> Point(4, 5)
10-04 16:55:33.492  2453  2453 I HoneySpace.RecentStyler: context = android.window.WindowContext@e6f03a2, styleData = RecentStyleData(windowBounds=WindowBounds width=1080 height=2400, bounds=Rect(0, 0 - 1080, 2400) insets=Insets{left=0, top=80, right=0, bottom=144}, systemInsets=Insets{left=0, top=80, right=0, bottom=144}cutout=Rect(0, 80 - 0, 0), gestureInsets=Insets{left=0, top=116, right=0, bottom=144}, gestureActionInsets=Insets{left=0, top=116, right=0, bottom=144}, insetsIgnoreCutout=Insets{left=0, top=80, right=0, bottom=144}, baseScreenSize=Point(1080, 2256)screenSizeInGesture=Point(1080, 2256), screenSizeIncludeCutout: Point(1080, 2256), iconSize=175, iconGravity=1, iconStarMargin=0, sceneScale=PointF(0.6, 0.6), sceneCoordinate=RectF(216.0, 386.4, 864.0, 1692.0001), sceneTopMargin=87, taskViewCoordinate=RectF(216.0, 299.4, 864.0, 1692.0001), sceneFullyScale=PointF(1.6666666, 1.8382351), gridExtraGap=0.0, sceneRadius=45.0, deviceRadius=-32.0, mwRadius=(30.0, 51.0), curveEffectScale=0.135, pageSpacing=16, pageSideMargin=0, sceneStartMargin=0, circularListGap=0, topTaskCount=0, bottomTaskCount=0, taskLockIconSize=168, listSceneScale=PointF(0.6, 0.6), listSceneSize=RectF(0.0, 0.0, 648.0, 1305.6001), listSceneRadius=45.0)
10-04 16:55:33.493  2453  2453 I HoneySpace.WallpaperAnimator: isOpen: false, from: 1.2, to: 1.0
10-04 16:55:33.493  2453  2453 I HoneySpace.WallpaperAnimator: wallpaper animation start
10-04 16:55:33.493  2453  2453 I HoneySpace.LeashUpdater: showRecentTarget, show leash : Surface(name=Surface(name=Task=7)/@0xdb9b81_transition-leash)/@0x9ac1833, targetView: DecorView@5c2b943[RecentsActivity]
10-04 16:55:33.493  2453  2453 I HoneySpace.LeashUpdater: showAppearedLeashOverlayTarget
10-04 16:55:33.493  2453  2453 I HoneySpace.MultiStateCallback: [223165065] Adding [STATE_RECENT_APPEARED (32768)] to [STATE_START_RECENTS_TRANSITION, STATE_GESTURE_START_RECENTS_SCREEN, STATE_GESTURE_START_BYKEY (16644)]
10-04 16:55:33.493  2453  2453 I HoneySpace.AnimationSession: toggleRecents recentsActivityStarted: true
10-04 16:55:33.493  2453  2453 I HoneySpace.RecentInteraction: sendRequestTaskViewPositionEvent. true, 0
10-04 16:55:33.493  2453  2453 I HoneySpace.GestureEventController: gotoRecents : true
10-04 16:55:33.493  2453  2453 I HoneySpace.GestureEventController: scrollInitComplete: false, addComplete: true
10-04 16:55:33.493  2453  2453 I HoneySpace.GestureRecentViewControllerImpl: initScroll() => canScrollToNext: false, itemCount: 1, targetPosition: 0
10-04 16:55:33.493  2453  2453 I HoneySpace.MultiStateCallback: [223165065] Adding [STATE_RECENTS_ANIMATION_STARTED (16)] to [STATE_START_RECENTS_TRANSITION, STATE_GESTURE_START_RECENTS_SCREEN, STATE_GESTURE_START_BYKEY, STATE_RECENT_APPEARED (49412)]
10-04 16:55:33.493  2453  2453 I HoneySpace.RecentsAnimationManager: startRecentEntering
10-04 16:55:33.493  2042  2042 I AODNotificationManager: updateNotification() 
10-04 16:55:33.494  1073  1073 I Layer   : Layer [com.sec.android.app.launcher/com.android.quickstep.RecentsActivity$_2453#5560] hidden!! flag(0)
10-04 16:55:33.494  2453  2453 I HoneySpace.RecentsActivity: onApplyWindowInsets, Insets{left=0, top=80, right=0, bottom=144} -> Insets{left=0, top=80, right=0, bottom=144}
10-04 16:55:33.495  2453  2453 I BLASTBufferQueue_Java: update, w= 1080 h= 2400 mName = ViewRootImpl@1f7ce54[RecentsActivity] mNativeObject= 0xb4000078cd442350 sc.mNativeObject= 0xb400007a2d415510 format= -2 caller= android.view.ViewRootImpl.updateBlastSurfaceIfNeeded:3017 android.view.ViewRootImpl.relayoutWindow:10131 android.view.ViewRootImpl.performTraversals:4110 android.view.ViewRootImpl.doTraversal:3288 android.view.ViewRootImpl$TraversalRunnable.run:11344 android.view.Choreographer$CallbackRecord.run:1689 
10-04 16:55:33.495  2453  2453 I ViewRootImpl@1f7ce54[RecentsActivity]: Relayout returned: old=(0,0,1080,2400) new=(0,0,1080,2400) relayoutAsync=true req=(1080,2400)0 dur=0 res=0x0 s={true 0xb40000781d541460} ch=false seqId=0
10-04 16:55:33.495  2453  6740 I HoneySpace.RecentsAnimationController: enableInputConsumer
10-04 16:55:33.495  1427  4443 V WindowManager: Relayout Window{e458a32 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity}: viewVisibility=0 req=1080x2400 ty=1 d0
10-04 16:55:33.495  2453  2453 I ViewRootImpl@1f7ce54[RecentsActivity]: registerCallbackForPendingTransactions
10-04 16:55:33.495  2453  2453 I HoneySpace.GestureEventController: scrollInitComplete: true, addComplete: true
10-04 16:55:33.495  2453  2453 I HoneySpace.GestureRecentViewControllerImpl: sendTaskViewRect: [Rect(216, 386 - 864, 1692)], key: [148], alpha: [1.0]
10-04 16:55:33.495  2453  2453 I HoneySpace.TaskListViewModel: openRecents : false
10-04 16:55:33.495  2453  4618 I ViewRootImpl@1f7ce54[RecentsActivity]: mWNT: t=0xb40000786d490af0 mBlastBufferQueue=0xb4000078cd442350 fn= 2 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.495  2453  4618 I ViewRootImpl@1f7ce54[RecentsActivity]: mWNT: t=0xb40000786d480b30 mBlastBufferQueue=0xb4000078cd442350 fn= 2 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.496  2453  4618 I ViewRootImpl@1f7ce54[RecentsActivity]: mWNT: t=0xb40000786d49dd50 mBlastBufferQueue=0xb4000078cd442350 fn= 2 mRenderHdrSdrRatio=1.0 caller= android.view.ViewRootImpl$6.onFrameDraw:5635 android.view.ViewRootImpl$2.onFrameDraw:2146 android.view.ThreadedRenderer$1.onFrameDraw:792 
10-04 16:55:33.496  2453  2453 I HoneySpace.SuggestedAppsViewModel: loadItems()
10-04 16:55:33.496  2453  2453 I HoneySpace.RecentInteraction: Receive taskViewRects, Leash and TaskList will go to TaskViewInfo(taskIdList=[148], viewRectList=[Rect(216, 386 - 864, 1692)], viewAlphaList=[1.0], sceneColorFilter=[0.0], recentEnterAnimation=RecentEnterAnimation(recentEnterAnimator=ValueAnimator@b8db31c
10-04 16:55:33.496  2453  2453 I HoneySpace.RecentInteraction:     :  1.0  0.0  , recentEnterAnimationEndListener=ie.q@b8ffb25))
10-04 16:55:33.496  2453  2453 I HoneySpace.TaskViewInteraction: startRecentEnterAnimation TaskViewInfo(taskIdList=[148], viewRectList=[Rect(216, 386 - 864, 1692)], viewAlphaList=[1.0], sceneColorFilter=[0.0], recentEnterAnimation=RecentEnterAnimation(recentEnterAnimator=ValueAnimator@b8db31c
10-04 16:55:33.496  2453  2453 I HoneySpace.TaskViewInteraction:     :  1.0  0.0  , recentEnterAnimationEndListener=ie.q@b8ffb25))
10-04 16:55:33.496  2453  2453 I HoneySpace.GestureTaskListView: animateToRecentViewPosition : [148]
10-04 16:55:33.496  2453 15403 I HoneySpace.SuggestedAppsRepositoryImpl: fetchSuggestedApps()
10-04 16:55:33.496  2453  2453 I HoneySpace.GestureTaskListView: animateToRecents : [148], loadCompleteCount : 0
10-04 16:55:33.496  2042  2164 V ShellRecents: [44710043] RecentsController.setInputConsumerEnabled: set focus to recents
10-04 16:55:33.496  2453 15403 I HoneySpace.SuggestedAppsRepositoryImpl: getTaskListData() collected: 1
10-04 16:55:33.496  2453 15403 I HoneySpace.SuggestedItemsFacade: updateTaskList : 1
10-04 16:55:33.496  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(0, 0 - 1080, 2400)
10-04 16:55:33.496  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(0, 0 - 1080, 2400)
10-04 16:55:33.496  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(0, 0 - 1080, 2400)
10-04 16:55:33.497  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=-32.0, targetRect=Rect(0, 0 - 1080, 2400), animationProgress=0.0, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.497  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(0.0, 0.0, 1080.0, 2400.0)
10-04 16:55:33.497  1427  1472 D SGM:FgCheckThread: TaskStackListener.onTaskFocusChanged(), taskId=148, focused=false
10-04 16:55:33.497  1427  1472 D SGM:FgCheckThread: TaskStackListener.onTaskFocusChanged(), taskId=7, focused=true
10-04 16:55:33.497  1427  4443 V WindowManager: Relayout hash=e458a32, pid=0, syncId=-1: mAttrs={(0,0)(fillxfill) sim={adjust=resize} layoutInDisplayCutoutMode=shortEdges ty=BASE_APPLICATION fmt=TRANSPARENT wanim=0x10302f2
10-04 16:55:33.497  1427  4443 V WindowManager:   fl=81910100
10-04 16:55:33.497  1427  4443 V WindowManager:   pfl=12008040
10-04 16:55:33.497  1427  4443 V WindowManager:   bhv=DEFAULT
10-04 16:55:33.497  1427  4443 V WindowManager:   fitSides= naviIconColor=0
10-04 16:55:33.497  1427  4443 V WindowManager:   sfl=4000000}
10-04 16:55:33.497  1427  1472 D SGM:FgCheckThread:   sendRunningComponentFocus(), pkgName: com.sec.android.app.launcher, userId: 0
10-04 16:55:33.497  1427  1807 D SGM:FgCheckThread: onLooperPrepared(), msg: MSG_TASK_FOCUSED, pkgName: com.sec.android.app.launcher, userId: 0
10-04 16:55:33.497  1427  1807 D SGM:FgCheckThread: handleTaskFocused().
10-04 16:55:33.498  1427  1807 D SGM:FgCheckThread: sendFocusOutConditionally() - mPrevNotiPkg: (unknown), userId: 0
10-04 16:55:33.498  1427  1807 D SGM:FgCheckThread:   handleTaskFocused(), pkgName: com.sec.android.app.launcher, userID:0
10-04 16:55:33.498  1427  1807 D SGM:FgCheckThread: handleResume().
10-04 16:55:33.498  1427  1807 D SGM:FgCheckThread: sendFocusOutConditionally() - mPrevNotiPkg: (unknown), userId: 0
10-04 16:55:33.498  1427  1472 D InputDispatcher: Focused application(0): ActivityRecord{38c4e65 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity t7}
10-04 16:55:33.498  1427  1807 D SGM:FgCheckThread:   handleResume(). pkgName: com.sec.android.app.launcher, userId: 0, isTunableApp: null
10-04 16:55:33.498  1427  1807 D SGM:FgCheckThread: notifyFocusInOut(). of pkg: com.sec.android.app.launcher, type: 4, isTunableApp: false, userId: 0
10-04 16:55:33.498  1427  1807 D SGM:FgCheckThread:   notifyFocusInOut(). unexpected mPrevNotiType: -1
10-04 16:55:33.498  1427  1807 D SGM:SystemHelper: callReleaseBlock needReleaseBlock:false
10-04 16:55:33.498  1427  1472 V WindowManager: Changing focus from Window{344fe1b u0 com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity} to Window{e458a32 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity} displayId=0 Callers=com.android.server.wm.RootWindowContainer.updateFocusedWindowLocked:578 com.android.server.wm.WindowManagerService.updateFocusedWindowLocked:6881 com.android.server.wm.ActivityTaskManagerService.setLastResumedActivityUncheckLocked:6118 com.android.server.wm.ActivityTaskManagerService.setFocusedTask:2769 
10-04 16:55:33.498  1427  1472 I WindowManager: Cancelling animation restarting=true, leash=Surface(name=Surface(name=3d202b3 StatusBar)/@0x8456cea - animation-leash of insets_animation)/@0x2c971cd
10-04 16:55:33.498  1427  1472 I WindowManager: Reparenting to original parent: Surface(name=WindowToken{4280822 type=2000 android.os.BinderProxy@5344804})/@0x3badbdb, destroy=false, surface=Surface(name=3d202b3 StatusBar)/@0x8456cea
10-04 16:55:33.498  1427  1472 I WindowManager: Reparenting to leash, surface=Surface(name=3d202b3 StatusBar)/@0x8456cea, leashParent=Surface(name=WindowToken{4280822 type=2000 android.os.BinderProxy@5344804})/@0x3badbdb
10-04 16:55:33.498  1427  1878 D AS.MultiSoundManager: mForegroundUid = 10137
10-04 16:55:33.498  1073  1124 I SurfaceFlinger: id=5561 createSurf, flag=24000, Surface(name=3d202b3 StatusBar)/@0x8456cea - animation-leash of insets_animation#5561
10-04 16:55:33.498  2453 15403 I HoneySpace.BadgeDataSourceImpl: Get notification count. PackageKey(packageName=com.google.android.gm, user=UserHandle{0}) - forceBadgeCount: false, notification listener: 1, badge provider: 0
10-04 16:55:33.499  2453 15403 I HoneySpace.SuggestedAppsRepositoryImpl: getDPSData() collected: 9
10-04 16:55:33.499  2453 15403 I HoneySpace.SuggestedItemsFacade: updateItems :  9
10-04 16:55:33.499  2453 15403 I HoneySpace.SuggestedItemsFacade: DPS items : MauiAppWindowTest, com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity#UserHandle{0}
10-04 16:55:33.499  2453 15403 I HoneySpace.SuggestedItemsFacade: DPS items : Play Store, com.android.vending/.AssetBrowserActivity#UserHandle{0}
10-04 16:55:33.499  2453 15403 I HoneySpace.SuggestedItemsFacade: DPS items : Gmail, com.google.android.gm/.ConversationListActivityGmail#UserHandle{0}
10-04 16:55:33.499  2453 15403 I HoneySpace.SuggestedItemsFacade: DPS items : REDACTED, com.devology.REDACTED.app/crc6476373cd892f338a7.MainActivity#UserHandle{0}
10-04 16:55:33.499  2453 15403 I HoneySpace.SuggestedItemsFacade: DPS items : Netflix, com.netflix.mediaclient/.ui.launch.UIWebViewActivity#UserHandle{0}
10-04 16:55:33.499  2453 15403 I HoneySpace.SuggestedItemsFacade: DPS items : REDACTED, com.jvelimited.REDACTED/crc64d420c6e2cb69fcc9.MainActivity#UserHandle{0}
10-04 16:55:33.499  2453 15403 I HoneySpace.SuggestedItemsFacade: DPS items : Camera, com.sec.android.app.camera/.Camera#UserHandle{0}
10-04 16:55:33.499  2453 15403 I HoneySpace.SuggestedItemsFacade: DPS items : Maps, com.google.android.apps.maps/com.google.android.maps.MapsActivity#UserHandle{0}
10-04 16:55:33.499  2453 15403 I HoneySpace.SuggestedItemsFacade: DPS items : Phone, com.samsung.android.dialer/.DialtactsActivity#UserHandle{0}
10-04 16:55:33.499  2453 15403 I HoneySpace.FilteredItemProvider: filtered 1 from j
10-04 16:55:33.499  2453 15403 I HoneySpace.FilteredItemProvider: filtered 1 from a
10-04 16:55:33.499  2453 15403 I HoneySpace.FilteredItemProvider: filtered 0 from c
10-04 16:55:33.499  2453 15403 I HoneySpace.SuggestedItemsFacade: filteredItem : com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity#UserHandle{0}
10-04 16:55:33.499  1427  1472 D WindowManager: makeSurface duration=1 leash=Surface(name=Surface(name=3d202b3 StatusBar)/@0x8456cea - animation-leash of insets_animation)/@0xf9ec894
10-04 16:55:33.499  2453 15403 I HoneySpace.SuggestedItemsFacade: item removed by filter - com.companyname.mauiappwindowtest
10-04 16:55:33.499  2453 15403 I HoneySpace.SuggestedItemsFacade: filteredItem : com.samsung.android.appseparation/.view.launcher.LauncherActivity#UserHandle{0}
10-04 16:55:33.499  2453 15403 I HoneySpace.BadgeDataSourceImpl: Get notification count. PackageKey(packageName=com.google.android.gm, user=UserHandle{0}) - forceBadgeCount: false, notification listener: 1, badge provider: 0
10-04 16:55:33.499  2453 15403 I HoneySpace.SuggestedItemsFacade: after getFilteredDPSItems: 4 / max: 4
10-04 16:55:33.499  2453 15403 I HoneySpace.SuggestedItemsFacade: getFinalItems() : 4 / 4, 4
10-04 16:55:33.499  2453 15403 I HoneySpace.SuggestedItemsFacade: getFinalItems : Play Store, com.android.vending/.AssetBrowserActivity#UserHandle{0}
10-04 16:55:33.499  2453 15403 I HoneySpace.SuggestedItemsFacade: getFinalItems : Gmail, com.google.android.gm/.ConversationListActivityGmail#UserHandle{0}
10-04 16:55:33.499  1427  1472 D InsetsSourceProvider: updateControlForTarget: control=InsetsSourceControl: {765e0000 mType=statusBars initiallyVisible mSurfacePosition=Point(0, 0) mInsetsHint=Insets{left=0, top=80, right=0, bottom=0}}, target=Window{e458a32 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity}, from=com.android.server.wm.InsetsStateController.onControlTargetChanged:358 com.android.server.wm.InsetsStateController.onBarControlTargetChanged:324 com.android.server.wm.InsetsPolicy.updateBarControlTarget:173 com.android.server.wm.InsetsPolicy.updateSystemBars:805 com.android.server.wm.DisplayPolicy.updateSystemBarsLw:3425 
10-04 16:55:33.499  2453 15403 I HoneySpace.SuggestedItemsFacade: getFinalItems : REDACTED, com.devology.REDACTED.app/crc6476373cd892f338a7.MainActivity#UserHandle{0}
10-04 16:55:33.499  2453 15403 I HoneySpace.SuggestedItemsFacade: getFinalItems : Netflix, com.netflix.mediaclient/.ui.launch.UIWebViewActivity#UserHandle{0}
10-04 16:55:33.499  2453 15403 I HoneySpace.SuggestedAppsRepositoryImpl: fetchSuggestedApps() end: 4, isDPSAvailable: true
10-04 16:55:33.499  1427  1472 I WindowManager: Cancelling animation restarting=true, leash=Surface(name=Surface(name=e6bbee6 NavigationBar0)/@0xd856db6 - animation-leash of insets_animation)/@0x4ab1593
10-04 16:55:33.499  1427  1472 I WindowManager: Reparenting to original parent: Surface(name=WindowToken{27ee5c5 type=2019 android.os.BinderProxy@9a062f})/@0xa015ab7, destroy=false, surface=Surface(name=e6bbee6 NavigationBar0)/@0xd856db6
10-04 16:55:33.499  2453  2453 I HoneySpace.SuggestedAppsViewModel: loadItems() collected : 4
10-04 16:55:33.499  1427  1472 I WindowManager: Reparenting to leash, surface=Surface(name=e6bbee6 NavigationBar0)/@0xd856db6, leashParent=Surface(name=WindowToken{27ee5c5 type=2019 android.os.BinderProxy@9a062f})/@0xa015ab7
10-04 16:55:33.499  2453  2453 I HoneySpace.SuggestedAppsAdapter: setCellLayoutItems : position = 0
10-04 16:55:33.499  2453  2453 I HoneySpace.SuggestedAppsAdapter: setCellLayoutItems : position = 1
10-04 16:55:33.500  2453  2453 I HoneySpace.SuggestedAppsAdapter: setCellLayoutItems : position = 2
10-04 16:55:33.500  2453  2453 I HoneySpace.SuggestedAppsAdapter: setCellLayoutItems : position = 3
10-04 16:55:33.500  2453  2453 I HoneySpace.SuggestedAppsPot: startAnimation show: true, startDelay: true
10-04 16:55:33.500  2453  2562 I HoneySpace.SALoggingUtils: SA Logging screenID: 500 eventId: 5108 detail: {det=com.android.vending com.google.android.gm com.devology.REDACTED.app com.netflix.mediaclient } value: -1
10-04 16:55:33.500  1073  1124 I SurfaceFlinger: id=5562 createSurf, flag=24000, Surface(name=e6bbee6 NavigationBar0)/@0xd856db6 - animation-leash of insets_animation#5562
10-04 16:55:33.501  1427  1472 D WindowManager: makeSurface duration=1 leash=Surface(name=Surface(name=e6bbee6 NavigationBar0)/@0xd856db6 - animation-leash of insets_animation)/@0x64d6332
10-04 16:55:33.501  1427  1472 D InsetsSourceProvider: updateControlForTarget: control=InsetsSourceControl: {a1c30001 mType=navigationBars initiallyVisible mSurfacePosition=Point(0, 2256) mInsetsHint=Insets{left=0, top=0, right=0, bottom=144}}, target=Window{e458a32 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity}, from=com.android.server.wm.InsetsStateController.onControlTargetChanged:358 com.android.server.wm.InsetsStateController.onBarControlTargetChanged:327 com.android.server.wm.InsetsPolicy.updateBarControlTarget:173 com.android.server.wm.InsetsPolicy.updateSystemBars:805 com.android.server.wm.DisplayPolicy.updateSystemBarsLw:3425 
10-04 16:55:33.501  1427  1472 D WindowManager: updateSystemBarAttributes: displayId=0, win=Window{e458a32 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity}, navColorWin=Window{344fe1b u0 com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity}, focusedCanBeNavColorWin=false, behavior=1, appearance=16, statusBarAppearanceRegions=[AppearanceRegion{ bounds=[0,0][1080,2400]}], requestedVisibilities=-9, from=com.android.server.wm.DisplayPolicy.focusChangedLw:2947 com.android.server.wm.DisplayContent.updateFocusedWindowLocked:4894 com.android.server.wm.RootWindowContainer.updateFocusedWindowLocked:578 
10-04 16:55:33.501  1427  1472 D SGM:FgCheckThread: TaskStackListener.onTaskFocusChanged(), taskId=148, focused=false
10-04 16:55:33.501  1427  1472 D SGM:FgCheckThread: TaskStackListener.onTaskFocusChanged(), taskId=7, focused=true
10-04 16:55:33.501  1427  1472 D SGM:FgCheckThread:   sendRunningComponentFocus(), pkgName: com.sec.android.app.launcher, userId: 0
10-04 16:55:33.502  1427  1878 D AS.MultiSoundManager: mForegroundUid = 10137
10-04 16:55:33.502  1427  7972 I WindowManager: Reparenting to leash, surface=Surface(name=RemoteWallpaperAnim:1:1)/@0x4ac17f2, leashParent=Surface(name=OneHanded:0:14)/@0x3be1e43
10-04 16:55:33.502  1427  1807 D SGM:FgCheckThread: onLooperPrepared(), msg: MSG_TASK_FOCUSED, pkgName: com.sec.android.app.launcher, userId: 0
10-04 16:55:33.502  1427  1807 D SGM:FgCheckThread: handleTaskFocused().
10-04 16:55:33.502  1427  1807 D SGM:FgCheckThread:   handleTaskFocused(), pkgName: com.sec.android.app.launcher, userID:0
10-04 16:55:33.502  1427  1807 D SGM:FgCheckThread: handleResume().
10-04 16:55:33.502  1427  1807 D SGM:FgCheckThread: sendFocusOutConditionally() - mPrevNotiPkg: (unknown), userId: 0
10-04 16:55:33.502  1427  1807 D SGM:FgCheckThread:   handleResume(). pkgName: com.sec.android.app.launcher, userId: 0, isTunableApp: null
10-04 16:55:33.502  1427  1807 D SGM:FgCheckThread: notifyFocusInOut(). of pkg: com.sec.android.app.launcher, type: 4, isTunableApp: false, userId: 0
10-04 16:55:33.502  1427  1807 D SGM:FgCheckThread:   notifyFocusInOut(). unexpected mPrevNotiType: -1
10-04 16:55:33.502  1427  1807 D SGM:SystemHelper: callReleaseBlock needReleaseBlock:false
10-04 16:55:33.502  1073  1124 I SurfaceFlinger: id=5563 createSurf, flag=24000, Surface(name=RemoteWallpaperAnim:1:1)/@0x4ac17f2 - animation-leash of remote_wallpaper#5563
10-04 16:55:33.502  2042  2042 D NavigationModeController: getCurrentUserContext: contextUser=0 currentUser=0
10-04 16:55:33.503  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions RecentsActivity$_2453#5560 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=3.000, rect=[0, 0, 1080, 2400]
10-04 16:55:33.503  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(0, 0 - 1080, 2400)
10-04 16:55:33.503  2453  2453 I HoneySpace.RecentsAnimationManager: setWindowBoundsInsets = Insets{left=0, top=80, right=0, bottom=144}
10-04 16:55:33.503  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.503  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.504  2042  2042 D NavigationModeController: getCurrentUserContext: contextUser=0 currentUser=0
10-04 16:55:33.505  1427  7972 D WindowManager: makeSurface duration=3 leash=Surface(name=Surface(name=RemoteWallpaperAnim:1:1)/@0x4ac17f2 - animation-leash of remote_wallpaper)/@0xdd8a883
10-04 16:55:33.505  1427  7972 D WindowManager: startAnimation for remote wallpaper, leash=Surface(name=Surface(name=RemoteWallpaperAnim:1:1)/@0x4ac17f2 - animation-leash of remote_wallpaper)/@0xdd8a883
10-04 16:55:33.506  1427  7972 D WindowManager: startRemoteWallpaperAnimation, d=0, leash=Surface(name=Surface(name=RemoteWallpaperAnim:1:1)/@0x4ac17f2 - animation-leash of remote_wallpaper)/@0xdd8a883
10-04 16:55:33.506  2453  2586 I HoneySpace.TopTaskSource: onTaskFocusChanged(): taskId = 7
10-04 16:55:33.506  2453  2586 I HoneySpace.TopTaskSource: onTaskFocusChanged(): taskId = 7
10-04 16:55:33.506  2453  2586 I HoneySpace.TopTaskSource: onTaskMovedToFront : taskId = 7
10-04 16:55:33.506  2453  2586 I HoneySpace.TopTaskSource: onTaskMovedToFront : taskId = 7
10-04 16:55:33.507  2453  4618 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d48ce70 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3588 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.507  2042  2042 D NavigationModeController: getCurrentUserContext: contextUser=0 currentUser=0
10-04 16:55:33.507  2453  2453 I InsetsSourceConsumer: applyRequestedVisibilityToControl: visible=true, type=statusBars, host=com.sec.android.app.launcher/com.android.quickstep.RecentsActivity
10-04 16:55:33.508  2453  2453 I InsetsSourceConsumer: applyRequestedVisibilityToControl: visible=true, type=navigationBars, host=com.sec.android.app.launcher/com.android.quickstep.RecentsActivity
10-04 16:55:33.509  2042  2042 D NavigationModeController: getCurrentUserContext: contextUser=0 currentUser=0
10-04 16:55:33.510  2042  2042 D NavigationModeController: getCurrentUserContext: contextUser=0 currentUser=0
10-04 16:55:33.511  1073  1073 I Layer   : id=5553 removeFromCurrentState Surface(name=e6bbee6 NavigationBar0)/@0xd856db6 - animation-leash of insets_animation#5553 (127)
10-04 16:55:33.511  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(17, 30 - 1063, 2344)
10-04 16:55:33.511  1073  1073 I Layer   : id=73 removeFromCurrentState e6bbee6 NavigationBar0#73 (127)
10-04 16:55:33.511  1073  1073 I Layer   : id=82 removeFromCurrentState NavigationBar0$_2042#82 (127)
10-04 16:55:33.511  1073  1073 I Layer   : id=5552 removeFromCurrentState Surface(name=3d202b3 StatusBar)/@0x8456cea - animation-leash of insets_animation#5552 (127)
10-04 16:55:33.511  1073  1073 I Layer   : id=73 addToCurrentState e6bbee6 NavigationBar0#73 (127)
10-04 16:55:33.511  1073  1073 I Layer   : id=82 addToCurrentState NavigationBar0$_2042#82 (127)
10-04 16:55:33.511  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=-23.666245, targetRect=Rect(17, 30 - 1063, 2344), animationProgress=0.07788557, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.511  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(17.0, 30.0, 1063.0, 2344.0)
10-04 16:55:33.511  1073  1073 I SurfaceFlinger: id=5552 Removed Surface(name=3d202b3 StatusBar)/@0x8456cea - animation-leash of insets_animation#5552 (127)
10-04 16:55:33.511  1073  1073 I SurfaceFlinger: id=5553 Removed Surface(name=e6bbee6 NavigationBar0)/@0xd856db6 - animation-leash of insets_animation#5553 (127)
10-04 16:55:33.511  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.511  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.512  2042  2042 I BLASTBufferQueue_Java: update, w= 1080 h= 144 mName = ViewRootImpl@141c4ca[NavigationBar0] mNativeObject= 0xb4000078cd42b290 sc.mNativeObject= 0xb400007a2d40c090 format= -3 caller= android.view.ViewRootImpl.updateBlastSurfaceIfNeeded:3017 android.view.ViewRootImpl.relayoutWindow:10131 android.view.ViewRootImpl.performTraversals:4110 android.view.ViewRootImpl.doTraversal:3288 android.view.ViewRootImpl$TraversalRunnable.run:11344 android.view.Choreographer$CallbackRecord.run:1689 
10-04 16:55:33.512  2042  2042 I ViewRootImpl@141c4ca[NavigationBar0]: Relayout returned: old=(0,2256,1080,2400) new=(0,2256,1080,2400) relayoutAsync=true req=(1080,144)0 dur=0 res=0x0 s={true 0xb40000781d4195b0} ch=false seqId=0
10-04 16:55:33.512  2042  2042 I ViewRootImpl@141c4ca[NavigationBar0]: registerCallbackForPendingTransactions
10-04 16:55:33.512  1427  7159 V WindowManager: Relayout Window{e6bbee6 u0 NavigationBar0}: viewVisibility=0 req=1080x144 ty=2019 d0
10-04 16:55:33.513  1427  7972 D InputDispatcher: Focus left window (0): 344fe1b com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity
10-04 16:55:33.513  2042  2783 I ViewRootImpl@141c4ca[NavigationBar0]: mWNT: t=0xb40000786d45a750 mBlastBufferQueue=0xb4000078cd42b290 fn= 10656 mRenderHdrSdrRatio=1.0 caller= android.view.ViewRootImpl$6.onFrameDraw:5635 android.view.ViewRootImpl$2.onFrameDraw:2146 android.view.ThreadedRenderer$1.onFrameDraw:792 
10-04 16:55:33.513  1427  7972 D InputDispatcher: Focus entered window (0): recents_animation_input_consumer
10-04 16:55:33.513  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d4ab950 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3589 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.516 16972 16972 I ViewRootImpl@56e8b21[MainActivity]: handleWindowFocusChanged: 0 0 call from android.view.ViewRootImpl.-$$Nest$mhandleWindowFocusChanged:0
10-04 16:55:33.516 16972 16972 I ImeFocusController: onPreWindowFocus: skipped, hasWindowFocus=false mHasImeFocus=true
10-04 16:55:33.516 16972 16972 I ImeFocusController: onPostWindowFocus: skipped, hasWindowFocus=false mHasImeFocus=true
10-04 16:55:33.517  1427  7159 V WindowManager: Relayout hash=e6bbee6, pid=0, syncId=-1: mAttrs={(0,0)(fillx144) gr=BOTTOM CENTER_VERTICAL sim={adjust=pan} layoutInDisplayCutoutMode=always ty=NAVIGATION_BAR fmt=TRANSLUCENT
10-04 16:55:33.517  1427  7159 V WindowManager:   fl=20840028
10-04 16:55:33.517  1427  7159 V WindowManager:   pfl=33001000
10-04 16:55:33.517  1427  7159 V WindowManager:   bhv=DEFAULT
10-04 16:55:33.517  1427  7159 V WindowManager:   providedInsets:
10-04 16:55:33.517  1427  7159 V WindowManager:     InsetsFrameProvider: {id=#a1c30001, index=0, type=navigationBars, source=FRAME, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=144}, insetsSizeOverrides=[TypedInsetsSize: {windowType=INPUT_METHOD, insetsSize=null}]}
10-04 16:55:33.517  1427  7159 V WindowManager:     InsetsFrameProvider: {id=#a1c30006, index=0, type=tappableElement, source=FRAME, flags=[]}
10-04 16:55:33.517  1427  7159 V WindowManager:     InsetsFrameProvider: {id=#a1c30005, index=0, type=mandatorySystemGestures, source=FRAME, flags=[]}
10-04 16:55:33.517  1427  7159 V WindowManager:     InsetsFrameProvider: {id=#a1c30004, index=0, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}}
10-04 16:55:33.517  1427  7159 V WindowManager:     InsetsFrameProvider: {id=#a1c30024, index=1, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}}
10-04 16:55:33.517  1427  7159 V WindowManager:   paramsForRotation:
10-04 16:55:33.517  1427  7159 V WindowManager:     ROTATION_0={(0,0)(fillx144) gr=BOTTOM CENTER_VERTICAL layoutInDisplayCutoutMode=always ty=NAVIGATION_BAR fmt=TRANSLUCENT
10-04 16:55:33.517  1427  7159 V WindowManager:       fl=20840028
10-04 16:55:33.517  1427  7159 V WindowManager:       pfl=31001000
10-04 16:55:33.517  1427  7159 V WindowManager:       bhv=DEFAULT
10-04 16:55:33.517  1427  7159 V WindowManager:       providedInsets:
10-04 16:55:33.517  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30001, index=0, type=navigationBars, source=FRAME, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=144}, insetsSizeOverrides=[TypedInsetsSize: {windowType=INPUT_METHOD, insetsSize=null}]}
10-04 16:55:33.517  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30006, index=0, type=tappableElement, source=FRAME, flags=[]}
10-04 16:55:33.517  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30005, index=0, type=mandatorySystemGestures, source=FRAME, flags=[]}
10-04 16:55:33.517  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30004, index=0, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}}
10-04 16:55:33.517  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30024, index=1, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}} naviIconColor=0}
10-04 16:55:33.517  1427  7159 V WindowManager:     ROTATION_90={(0,0)(144xfill) gr=RIGHT CENTER_HORIZONTAL layoutInDisplayCutoutMode=always ty=NAVIGATION_BAR fmt=TRANSLUCENT
10-04 16:55:33.517  1427  7159 V WindowManager:       fl=20840028
10-04 16:55:33.517  1427  7159 V WindowManager:       pfl=31001000
10-04 16:55:33.517  1427  7159 V WindowManager:       bhv=DEFAULT
10-04 16:55:33.517  1427  7159 V WindowManager:       providedInsets:
10-04 16:55:33.517  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30001, index=0, type=navigationBars, source=FRAME, flags=[], insetsSizeOverrides=[TypedInsetsSize: {windowType=INPUT_METHOD, insetsSize=null}]}
10-04 16:55:33.517  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30006, index=0, type=tappableElement, source=FRAME, flags=[]}
10-04 16:55:33.517  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30005, index=0, type=mandatorySystemGestures, source=FRAME, flags=[]}
10-04 16:55:33.517  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30004, index=0, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}}
10-04 16:55:33.517  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30024, index=1, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}} naviIconColor=0}
10-04 16:55:33.517  1427  7159 V WindowManager:     ROTATION_180={(0,0)(fillx144) gr=BOTTOM CENTER_VERTICAL layoutInDisplayCutoutMode=always ty=NAVIGATION_BAR fmt=TRANSLUCENT
10-04 16:55:33.517  1427  7159 V WindowManager:       fl=20840028
10-04 16:55:33.517  1427  7159 V WindowManager:       pfl=31001000
10-04 16:55:33.517  1427  7159 V WindowManager:       bhv=DEFAULT
10-04 16:55:33.517  1427  7159 V WindowManager:       providedInsets:
10-04 16:55:33.517  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30001, index=0, type=navigationBars, source=FRAME, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=144}, insetsSizeOverrides=[TypedInsetsSize: {windowType=INPUT_METHOD, insetsSize=null}]}
10-04 16:55:33.517  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30006, index=0, type=tappableElement, source=FRAME, flags=[]}
10-04 16:55:33.517  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30005, index=0, type=mandatorySystemGestures, source=FRAME, flags=[]}
10-04 16:55:33.517  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30004, index=0, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}}
10-04 16:55:33.517  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30024, index=1, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}} naviIconColor=0}
10-04 16:55:33.517  1427  7159 V WindowManager:     ROTATION_270={(0,0)(144xfill) gr=LEFT CENTER_HORIZONTAL layoutInDisplayCutoutMode=always ty=NAVIGATION_BAR fmt=TRANSLUCENT
10-04 16:55:33.517  1427  7159 V WindowManager:       fl=20840028
10-04 16:55:33.517  1427  7159 V WindowManager:       pfl=31001000
10-04 16:55:33.517  1427  7159 V WindowManager:       bhv=DEFAULT
10-04 16:55:33.517  1427  7159 V WindowManager:       providedInsets:
10-04 16:55:33.517  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30001, index=0, type=navigationBars, source=FRAME, flags=[], insetsSizeOverrides=[TypedInsetsSize: {windowType=INPUT_METHOD, insetsSize=null}]}
10-04 16:55:33.517  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30006, index=0, type=tappableElement, source=FRAME, flags=[]}
10-04 16:55:33.517  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30005, index=0, type=mandatorySystemGestures, source=FRAME, flags=[]}
10-04 16:55:33.517  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30004, index=0, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}}
10-04 16:55:33.517  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30024, index=1, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}} naviIconColor=0} naviIconColor=0}
10-04 16:55:33.519  1073  1073 I Layer   : id=5552 Destroyed Surface(name=3d202b3 StatusBar)/@0x8456cea - animation-leash of insets_animation#5552
10-04 16:55:33.519  1073  1073 I Layer   : id=5553 Destroyed Surface(name=e6bbee6 NavigationBar0)/@0xd856db6 - animation-leash of insets_animation#5553
10-04 16:55:33.520  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(35, 62 - 1045, 2286)
10-04 16:55:33.520  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=-14.821297, targetRect=Rect(35, 62 - 1045, 2286), animationProgress=0.16054863, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.520  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(35.0, 62.0, 1045.0, 2286.0)
10-04 16:55:33.520  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.520  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.522  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d492670 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3590 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.524  1073  1073 D SurfaceFlinger: Display 4633128672291735937 HWC layers:
10-04 16:55:33.524  1073  1073 D SurfaceFlinger:      CLIENT | 0xb400007784fa1a50 | 0100 | RGBA_8888    |  748.0  197.0 1652.0 2203.0 |    0    0 1080 2400 | Wallpaper BBQ wrapper 5_system#85
10-04 16:55:33.524  1073  1073 D SurfaceFlinger:      CLIENT | 0xb400007784ff5dd0 | 0100 | RGBA_8888    |    0.0    0.0 1080.0 2400.0 |    0    0 1080 2400 | com.sec.android.app.launcher/com.and[...]ntsActivity$_2453#5560 (blurRegions)
10-04 16:55:33.524  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784ff09d0 | 0100 | RGBA_8888    |    0.0    0.0 1080.0 2400.0 |    0    0 1080 2400 | RecentsTransitionOverlay$_2453#132
10-04 16:55:33.524  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784fc2050 | 0102 | RGBA_8888    |    0.0    6.0 1080.0 2388.0 |    6   11 1074 2379 | com.companyname.mauiappwindowtest/cr[...]0fbbd3bbed6.MainActivity$_16972#5551
10-04 16:55:33.524  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784fa6210 | 0100 | RGBA_8888    |    0.0    0.0 1080.0   80.0 |    0    0 1080   80 | StatusBar$_2042#89
10-04 16:55:33.524  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784fe2110 | 0100 | RGBA_8888    |    0.0    0.0   67.0  342.0 | 1013  623 1080  965 | com.sec.android.app.launcher/com.sam[...]e.edge.CocktailBarService$_2453#2631
10-04 16:55:33.524  1073  1073 D SurfaceFlinger:      DE
10-04 16:55:33.524  1073  1073 D SurfaceFlinger: VICE | 0xb400007784fa94d0 | 0100 | RGBA_8888    |    0.0    0.0 1080.0  144.0 |    0 2256 1080 2400 | NavigationBar0$_2042#82
10-04 16:55:33.524  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784fb6510 | 0140 | RGBA_8888    |    0.0    0.0 1080.0   80.0 |    0    0 1080   80 | ScreenDecorOverlay$_2042#99
10-04 16:55:33.524  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784fd5ed0 | 0140 | RGBA_8888    |    0.0    0.0 1080.0   80.0 |    0 2320 1080 2400 | ScreenDecorOverlayBottom$_2042#100
10-04 16:55:33.524  1073  1073 D SurfaceFlinger: 
10-04 16:55:33.528  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(50, 89 - 1030, 2237)
10-04 16:55:33.528  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=-7.4172497, targetRect=Rect(50, 89 - 1030, 2237), animationProgress=0.22974533, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.528  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(50.0, 89.0, 1030.0, 2237.0)
10-04 16:55:33.528  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.528  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.529  2453 15403 I HoneySpace.RecentsAnimationController: setWillFinishToHome true
10-04 16:55:33.532  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d4a1c90 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3591 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.536  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(64, 114 - 1016, 2191)
10-04 16:55:33.536  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=-0.43167496, targetRect=Rect(64, 114 - 1016, 2191), animationProgress=0.29503107, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.536  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(64.0, 114.0, 1016.0, 2191.0)
10-04 16:55:33.536  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.538  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.540  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d406ab0 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3592 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.545  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(79, 140 - 1001, 2141)
10-04 16:55:33.545  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=6.942009, targetRect=Rect(79, 140 - 1001, 2141), animationProgress=0.363944, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.545  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(79.0, 140.0, 1001.0, 2141.0)
10-04 16:55:33.545  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.545  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.549  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d477810 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3593 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.553  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(91, 163 - 989, 2102)
10-04 16:55:33.553  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=13.078709, targetRect=Rect(91, 163 - 989, 2102), animationProgress=0.42129636, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.553  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(91.0, 163.0, 989.0, 2102.0)
10-04 16:55:33.553  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.553  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.557  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d434d10 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3594 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.561  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(103, 183 - 977, 2063)
10-04 16:55:33.561  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=18.834953, targetRect=Rect(103, 183 - 977, 2063), animationProgress=0.475093, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.564  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(103.0, 183.0, 977.0, 2063.0)
10-04 16:55:33.564  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.564  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.566  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d4aa1f0 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3595 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.569  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(115, 205 - 965, 2023)
10-04 16:55:33.569  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=24.871147, targetRect=Rect(115, 205 - 965, 2023), animationProgress=0.53150606, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.570  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(115.0, 205.0, 965.0, 2023.0)
10-04 16:55:33.570  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.572  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.573  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d431090 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3596 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.578  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(125, 223 - 955, 1990)
10-04 16:55:33.578  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=29.859375, targetRect=Rect(125, 223 - 955, 1990), animationProgress=0.578125, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.578  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(125.0, 223.0, 955.0, 1990.0)
10-04 16:55:33.581  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.581  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.582  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d47e770 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3597 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.586  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(135, 242 - 944, 1956)
10-04 16:55:33.586  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=35.06247, targetRect=Rect(135, 242 - 944, 1956), animationProgress=0.626752, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.586  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(135.0, 242.0, 944.0, 1956.0)
10-04 16:55:33.588  1427  1870 D MdnieScenarioControlService:  packageName : com.sec.android.app.launcher    className : com.android.quickstep.RecentsActivity
10-04 16:55:33.589  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.589  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.589  1427  1870 V MdnieScenarioControlService: setUIMode from UI function(3)
10-04 16:55:33.591  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d49a650 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3598 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.593  1427  1775 D VibratorManagerService: Vibration 312 finished with EndInfo{status=FINISHED, endedBy=null}
10-04 16:55:33.593  1427  1775 D VibratorManagerService: Reporting vibration 312 finished with EndInfo{status=FINISHED, endedBy=null}
10-04 16:55:33.593  1427  1775 D VibratorManagerService: Vibration for uid=1000 and with attrs=VibrationAttributes: Usage=TOUCH Audio Usage= USAGE_UNKNOWN tags= Flags=0 ended with status FINISHED
10-04 16:55:33.593  1044  1044 E SecVibrator-HAL-AIDL-CORE: V_1_0: Vibrator off
10-04 16:55:33.593  1044  1044 E SecVibrator-HAL-AIDL-CORE: HW_API: >> writeNode node:/timed_output/vibrator/enable val:0
10-04 16:55:33.595  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(144, 257 - 935, 1927)
10-04 16:55:33.595  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=39.337646, targetRect=Rect(144, 257 - 935, 1927), animationProgress=0.666707, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.595  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(144.0, 257.0, 935.0, 1927.0)
10-04 16:55:33.595  1044  1044 E SecVibrator-HAL-AIDL-CORE: HW_API: << writeNode node OK : 2
10-04 16:55:33.598  1427  1775 D VibratorManagerService: VibrationThread released after finished vibration
10-04 16:55:33.598  1427  1775 D VibratorManagerService: Processing VibrationThread released callback
10-04 16:55:33.598  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.598  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.599  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d4a66d0 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3599 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.603  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(152, 272 - 928, 1902)
10-04 16:55:33.603  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=43.296303, targetRect=Rect(152, 272 - 928, 1902), animationProgress=0.70370376, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.603  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(152.0, 272.0, 928.0, 1902.0)
10-04 16:55:33.606  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.606  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.608  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d49bdb0 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3600 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.611  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(160, 286 - 919, 1874)
10-04 16:55:33.611  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=47.38659, targetRect=Rect(160, 286 - 919, 1874), animationProgress=0.7419307, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.611  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(160.0, 286.0, 919.0, 1874.0)
10-04 16:55:33.614  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.614  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.616  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d492d50 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3601 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.620  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(167, 298 - 913, 1852)
10-04 16:55:33.620  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=50.713028, targetRect=Rect(167, 298 - 913, 1852), animationProgress=0.77301896, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.620  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(167.0, 298.0, 913.0, 1852.0)
10-04 16:55:33.622  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.622  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.624  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d4a92d0 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3602 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.628  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(173, 309 - 906, 1832)
10-04 16:55:33.628  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=53.760994, targetRect=Rect(173, 309 - 906, 1832), animationProgress=0.8015046, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.628  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(173.0, 309.0, 906.0, 1832.0)
10-04 16:55:33.631  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.631  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.633  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d4a1450 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3603 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.636  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(179, 321 - 900, 1812)
10-04 16:55:33.636  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=56.87223, targetRect=Rect(179, 321 - 900, 1812), animationProgress=0.8305816, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.636  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(179.0, 321.0, 900.0, 1812.0)
10-04 16:55:33.637  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.637  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.641  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d4abd70 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3604 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.645  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(184, 330 - 895, 1795)
10-04 16:55:33.645  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=59.368835, targetRect=Rect(184, 330 - 895, 1795), animationProgress=0.8539144, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.645  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(184.0, 330.0, 895.0, 1795.0)
10-04 16:55:33.648  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.648  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.650  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d4a0110 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3605 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.653  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(189, 338 - 891, 1780)
10-04 16:55:33.653  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=61.625, targetRect=Rect(189, 338 - 891, 1780), animationProgress=0.875, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.653  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(189.0, 338.0, 891.0, 1780.0)
10-04 16:55:33.655  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.655  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.658  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d48b710 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3606 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.658  1427  1466 I system_server: Background concurrent copying GC freed 15MB AllocSpace bytes, 429(8580KB) LOS objects, 24% free, 73MB/97MB, paused 168us,202us total 145.291ms
10-04 16:55:33.659  1427  1427 I GestureDetector: handleMessage TAP
10-04 16:55:33.659  1427  1579 I GestureDetector: handleMessage TAP
10-04 16:55:33.661  1427  1468 W System  : A resource failed to call close. 
10-04 16:55:33.662  1427  1468 W System  : A resource failed to call release. 
10-04 16:55:33.662  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(194, 346 - 886, 1765)
10-04 16:55:33.662  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=63.890938, targetRect=Rect(194, 346 - 886, 1765), animationProgress=0.896177, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.662  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(194.0, 346.0, 886.0, 1765.0)
10-04 16:55:33.663  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.663  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.665  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d4a99b0 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3607 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.670  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(197, 352 - 882, 1753)
10-04 16:55:33.670  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=65.67658, targetRect=Rect(197, 352 - 882, 1753), animationProgress=0.9128653, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.670  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(197.0, 352.0, 882.0, 1753.0)
10-04 16:55:33.670  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.670  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.672  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d4868b0 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3608 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.678  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(201, 359 - 879, 1742)
10-04 16:55:33.678  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=67.44412, targetRect=Rect(201, 359 - 879, 1742), animationProgress=0.9293843, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.678  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(201.0, 359.0, 879.0, 1742.0)
10-04 16:55:33.679  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.679  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.681  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d4ad630 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3609 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.686  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(204, 364 - 876, 1733)
10-04 16:55:33.687  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=68.814224, targetRect=Rect(204, 364 - 876, 1733), animationProgress=0.94218904, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.687  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(204.0, 364.0, 876.0, 1733.0)
10-04 16:55:33.687  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.687  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.690  1427  1870 V MdnieScenarioControlService: mAclOffEnabled : false
10-04 16:55:33.690  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d484ff0 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3610 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.695  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(206, 368 - 874, 1725)
10-04 16:55:33.695  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=70.007805, targetRect=Rect(206, 368 - 874, 1725), animationProgress=0.953344, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.695  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(206.0, 368.0, 874.0, 1725.0)
10-04 16:55:33.696  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.696  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.698  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d451c70 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3611 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.703  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(208, 372 - 871, 1717)
10-04 16:55:33.703  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=71.15474, targetRect=Rect(208, 372 - 871, 1717), animationProgress=0.964063, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.703  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(208.0, 372.0, 871.0, 1717.0)
10-04 16:55:33.704  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.704  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.706  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d4ac9d0 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3612 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.712  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(210, 375 - 870, 1711)
10-04 16:55:33.712  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=72.013626, targetRect=Rect(210, 375 - 870, 1711), animationProgress=0.97208995, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.712  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(210.0, 375.0, 870.0, 1711.0)
10-04 16:55:33.712  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.712  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.715  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d4920f0 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3613 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.720  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(211, 378 - 868, 1707)
10-04 16:55:33.720  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=72.73403, targetRect=Rect(211, 378 - 868, 1707), animationProgress=0.9788227, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.720  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(211.0, 378.0, 868.0, 1707.0)
10-04 16:55:33.720  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.720  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.722  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d42f930 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3614 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.728  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(213, 380 - 867, 1702)
10-04 16:55:33.728  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=73.39411, targetRect=Rect(213, 380 - 867, 1702), animationProgress=0.9849917, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.728  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(213.0, 380.0, 867.0, 1702.0)
10-04 16:55:33.729  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.729  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.732  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d404850 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3615 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.737  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(214, 382 - 866, 1699)
10-04 16:55:33.737  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=73.860664, targetRect=Rect(214, 382 - 866, 1699), animationProgress=0.989352, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.737  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(214.0, 382.0, 866.0, 1699.0)
10-04 16:55:33.737  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.737  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.740  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d4a4050 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3616 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.745  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(214, 383 - 865, 1696)
10-04 16:55:33.745  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=74.22678, targetRect=Rect(214, 383 - 865, 1696), animationProgress=0.99277365, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.745  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(214.0, 383.0, 865.0, 1696.0)
10-04 16:55:33.745  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.745  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.748  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d47cbf0 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3617 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.753  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(215, 384 - 864, 1694)
10-04 16:55:33.753  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=74.53376, targetRect=Rect(215, 384 - 864, 1694), animationProgress=0.9956426, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.754  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(215.0, 384.0, 864.0, 1694.0)
10-04 16:55:33.754  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.754  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.756  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d4953d0 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3618 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.762  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(215, 385 - 864, 1693)
10-04 16:55:33.762  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=74.72687, targetRect=Rect(215, 385 - 864, 1693), animationProgress=0.9974474, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.762  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(215.0, 385.0, 864.0, 1693.0)
10-04 16:55:33.762  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.762  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.765  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d47bcd0 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3619 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.770  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(216, 386 - 864, 1693)
10-04 16:55:33.770  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=74.87014, targetRect=Rect(216, 386 - 864, 1693), animationProgress=0.9987864, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.770  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(216.0, 386.0, 864.0, 1693.0)
10-04 16:55:33.770  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.770  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.773  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d401db0 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3620 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.778  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(216, 386 - 864, 1692)
10-04 16:55:33.779  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=74.94521, targetRect=Rect(216, 386 - 864, 1692), animationProgress=0.999488, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.779  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(216.0, 386.0, 864.0, 1692.0)
10-04 16:55:33.779  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.779  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.781  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d42cbd0 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3621 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.787  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(216, 386 - 864, 1692)
10-04 16:55:33.787  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=74.98377, targetRect=Rect(216, 386 - 864, 1692), animationProgress=0.9998483, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.787  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(216.0, 386.0, 864.0, 1692.0)
10-04 16:55:33.787  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.787  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.791  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d4a4cb0 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3622 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.795  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(216, 386 - 864, 1692)
10-04 16:55:33.795  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=74.99864, targetRect=Rect(216, 386 - 864, 1692), animationProgress=0.9999873, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.795  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(216.0, 386.0, 864.0, 1692.0)
10-04 16:55:33.796  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.796  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.796  2453  2453 I HoneySpace.RectFAnimation: animation ended
10-04 16:55:33.799  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d496710 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3623 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.799   676   676 D io_stats: !@   8,0 r 706552 27994060 w 792789 17794444 d 216628 120718488 f 0 0 iot 796872 0 th 0 0 0 pt 0 inp 0 0 89542.268
10-04 16:55:33.804  2453  2453 I HoneySpace.TaskViewInteraction: recents taskPosition Rect(216, 386 - 864, 1692)
10-04 16:55:33.804  2453  2453 I HoneySpace.AnimationSession: collect taskPosition LeashTask(targetView=com.honeyspace.ui.common.taskScene.GestureTaskSceneView{9eef795 I.ED..... ......ID 0,0-1080,2400}, cornerRadius=75.0, targetRect=Rect(216, 386 - 864, 1692), animationProgress=1.0, fullScreenProgress=-0.0, canHidden=false)
10-04 16:55:33.804  2453  2453 I HoneySpace.RectFAnimation: animateToFinalPosition RectF(216.0, 386.0, 864.0, 1692.0)
10-04 16:55:33.804  2453  2453 I HoneySpace.GestureRecentViewControllerImpl: doOnEnd RecentEnterAnimator getRecentEnterAnimation
10-04 16:55:33.804  2453  2453 I HoneySpace.GestureRecentViewControllerImpl: onEnterAnimationCompleted.
10-04 16:55:33.804  2453  2453 I HoneySpace.TaskListViewModel: setGestureActive, active = false
10-04 16:55:33.804  2453  2453 I HoneySpace.BaseRecentsView: startPropertyOnTaskAnimation, needAnim = true
10-04 16:55:33.804  2453  2453 I HoneySpace.LeashUpdater: hideAppearedLeashOverlayTarget
10-04 16:55:33.805  2453  4618 I ViewRootImpl@1f7ce54[RecentsActivity]: mWNT: t=0xb40000786d3fbc10 mBlastBufferQueue=0xb4000078cd442350 fn= 38 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.805  2453  6740 I HoneySpace.RecentsAnimationController: getScreenshotTask, taskId = 148
10-04 16:55:33.805  2042  2769 V ShellRecents: [44710043] RecentsController.screenshotTask: taskId=148
10-04 16:55:33.806  1427  7972 D RestrictionPolicy: isScreenCaptureEnabled : ret=true userId=0
10-04 16:55:33.806  1427  7972 D RestrictionPolicy: isScreenCaptureEnabled : ret=true userId=0
10-04 16:55:33.808  1427  7972 D ScreenCapture: [Capture_TEST] : setIsScreenShotBySystem false
10-04 16:55:33.809  1073  1073 I Layer   : id=5564 Destroyed Screenshot Parent#5564
10-04 16:55:33.809  1073  1127 D RenderEngine: [SEC_GC_CMN_SF_EFFECTS] drawLayersInternal,1284, Rendering layer  at index 0
10-04 16:55:33.809  1073  1127 D RenderEngine: [SEC_GC_CMN_SF_EFFECTS] drawLayersInternal,1284, Rendering layer com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity$_16972#5551 at index 1
10-04 16:55:33.811  2453  2453 I HoneySpace.GestureRecentViewControllerImpl: taskIdList = [148], taskView = b505933
10-04 16:55:33.811  2453  2453 I HoneySpace.TaskSceneView: thumbnail.size = 1, task.size = 1
10-04 16:55:33.811  2453  2453 I HoneySpace.TaskSceneView: windowingMode = [1]
10-04 16:55:33.812  2453  2453 I HoneySpace.TaskSceneView: deltaRotation = 0, sceneType = SingleType, fitType = [AutoFitType], fitScale = [1.0]
10-04 16:55:33.812  2453  2453 I HoneySpace.TaskSceneView: sceneBoundInfo = sceneRatio : (vertical=1.0, horizontal=1.0), dividerRatio : (vertical=0.0, horizontal=0.0)
10-04 16:55:33.812  2453  2453 I HoneySpace.TaskSceneView: hasStage = false
10-04 16:55:33.812  2453  2453 W HoneySpace.TaskSceneView: sceneStateInfo = SceneStateInfo(launchSrcBounds=[RectF(0.0, 0.0, 648.0, 1306.0)], launchDestBounds=[RectF(0.0, 0.0, 1080.0, 2400.0)], launchClipInsets=[RectF(0.0, 80.0, 1.2207031E-4, 144.0)], srcShrinkCropBounds=[RectF(1.0, 81.0, 1078.9999, 2255.0)], srcFullCropBounds=[RectF(0.0, 0.0, 1080.0, 2400.0)], destShrinkCropBounds=[RectF(0.0, 0.0, 648.0, 1306.0)], destFullCropBounds=[RectF(0.0, 0.0, 648.0, 1306.0)], destShrinkBgCropBounds=[RectF(1.0, 1.0, 647.0, 1305.0)], destFullBgCropBounds=[RectF(0.0, 0.0, 648.0, 1306.0)], destStageCropBounds=RectF(0.0, 0.0, 0.0, 0.0), shrinkCornerRadius=interface um.a, fullCornerRadii=[[F@61e75a6], stageCornerRadius=-32.0, shrinkProgress=1.0, fullProgress=0.9066667)
10-04 16:55:33.812  1073  1073 I Layer   : Layer [Surface(name=TransientLaunchOverlayToken{fb49392 token=android.os.BinderProxy@2aee51d})/@0x9146b68_transition-leash#5557] hidden!! flag(1)
10-04 16:55:33.812  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.812  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.815  2453  4618 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d488430 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3624 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.816  1073  1073 D SurfaceFlinger: Display 4633128672291735937 HWC layers:
10-04 16:55:33.816  1073  1073 D SurfaceFlinger:      CLIENT | 0xb400007784fa1a50 | 0100 | RGBA_8888    |  681.0   48.0 1719.0 2352.0 |    0    0 1080 2400 | Wallpaper BBQ wrapper 5_system#85
10-04 16:55:33.816  1073  1073 D SurfaceFlinger:      CLIENT | 0xb400007784fbf810 | 0100 | RGBA_8888    |    0.0    0.0 1080.0 2400.0 |    0    0 1080 2400 | com.sec.android.app.launcher/com.and[...]ntsActivity$_2453#5560 (blurRegions)
10-04 16:55:33.816  1073  1073 D SurfaceFlinger:      CLIENT | 0xb400007784fc2050 | 0102 | RGBA_8888    |    0.0   79.0 1079.0 2256.0 |  216  385  863 1692 | com.companyname.mauiappwindowtest/cr[...]0fbbd3bbed6.MainActivity$_16972#5551
10-04 16:55:33.816  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784fa6210 | 0100 | RGBA_8888    |    0.0    0.0 1080.0   80.0 |    0    0 1080   80 | StatusBar$_2042#89
10-04 16:55:33.816  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784fe2110 | 0100 | RGBA_8888    |    0.0    0.0   67.0  342.0 | 1013  623 1080  965 | com.sec.android.app.launcher/com.sam[...]e.edge.CocktailBarService$_2453#2631
10-04 16:55:33.816  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784fab610 | 0100 | RGBA_8888    |    0.0    0.0 1080.0  144.0 |    0 2256 1080 2400 | NavigationBar0$_2042#82
10-04 16:55:33.816  1073  1073 D SurfaceFlinger:      DEVICE | 0xb4
10-04 16:55:33.816  1073  1073 D SurfaceFlinger: 00007784fb6510 | 0140 | RGBA_8888    |    0.0    0.0 1080.0   80.0 |    0    0 1080   80 | ScreenDecorOverlay$_2042#99
10-04 16:55:33.816  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784fd5ed0 | 0140 | RGBA_8888    |    0.0    0.0 1080.0   80.0 |    0 2320 1080 2400 | ScreenDecorOverlayBottom$_2042#100
10-04 16:55:33.816  1073  1073 D SurfaceFlinger: 
10-04 16:55:33.820  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.820  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.820  2453  2453 I HoneySpace.RectFAnimation: animation ended
10-04 16:55:33.823  2453  4618 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d4aa350 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3625 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:33.823  2453  2453 I HoneySpace.GestureEventController: notifyFinishHomeToRecentAnimation
10-04 16:55:33.824  2453  2453 I HoneySpace.AnimationSession: requestFinishRecentAnimation()
10-04 16:55:33.824  2453  2453 I HoneySpace.AnimationSession: taskListView appeared : false
10-04 16:55:33.824  2453  2453 I HoneySpace.RecentsAnimationManager: finish
10-04 16:55:33.824  2453  2453 I HoneySpace.MultiStateCallback: [223165065] Adding [STATE_GESTURE_END (2)] to [STATE_START_RECENTS_TRANSITION, STATE_RECENTS_ANIMATION_STARTED, STATE_GESTURE_START_RECENTS_SCREEN, STATE_GESTURE_START_BYKEY, STATE_RECENT_APPEARED (49428)]
10-04 16:55:33.824  2453  2453 I HoneySpace.RecentsAnimationManager: onGestureEnd: com.honeyspace.gesture.recentsanimation.GestureEndTarget$Companion$RECENTS$1@d6fddde
10-04 16:55:33.824  2453  2453 I HoneySpace.RecentsAnimationManager: finishController() toHome = true, sendUserLeaveHint = false
10-04 16:55:33.824  2453  2453 I HoneySpace.RecentsAnimationController: setWillFinishToHome true
10-04 16:55:33.824  2453  2453 I HoneySpace.ShellTransitionManager: finishGestureTransition
10-04 16:55:33.824  2453  2453 I HoneySpace.RecentsAnimationController: finish, toHome = true, sendUserLeaveHint = false
10-04 16:55:33.824  2453  2453 I HoneySpace.MultiStateCallback: [223165065] Adding [STATE_RECENTS_ANIMATION_FINISHED, STATE_HANDLER_INVALIDATED (65600)] to [STATE_GESTURE_END, STATE_START_RECENTS_TRANSITION, STATE_RECENTS_ANIMATION_STARTED, STATE_GESTURE_START_RECENTS_SCREEN, STATE_GESTURE_START_BYKEY, STATE_RECENT_APPEARED (49430)]
10-04 16:55:33.824  2453  2453 I HoneySpace.RecentsAnimationManager: invalidate
10-04 16:55:33.824  2453  2453 I HoneySpace.InputConsumerProxy: end
10-04 16:55:33.824  2453  2453 I HoneySpace.RectFAnimation: skipToEnd
10-04 16:55:33.824  2453  2453 I HoneySpace.LeashOverlayWindowImpl: removeGestureTaskListView : com.honeyspace.gesture.presentation.GestureTaskListView{a8026bc V.ED..... ........ 0,0-1080,2400}
10-04 16:55:33.824  2453  2453 I HoneySpace.GestureTaskListView: clear
10-04 16:55:33.824  2453  2453 I HoneySpace.RecentInteraction: onFinishRecentAnimation.
10-04 16:55:33.824  2453  2453 I HoneySpace.AnimationSession: close
10-04 16:55:33.824  2453  2453 I HoneySpace.DvfsManager: HOME_GESTURE_BOOSTER release
10-04 16:55:33.824  2453  2453 I HoneySpace.RecentInteraction: sendRecentsAnimationEvent. isStarted: false
10-04 16:55:33.825  2042  2164 V ShellRecents: [44710043] RecentsController.finishInner: toHome=true userLeave=false willFinishToHome=true state=0
10-04 16:55:33.825  2042  2164 V ShellRecents:   normal finish
10-04 16:55:33.825  2453  2453 I HoneySpace.GestureRecentViewControllerImpl: collect leashRunningTaskId : -1
10-04 16:55:33.825  2453 15403 I HoneySpace.OverviewEventHandler: onRecentAnimationFinishCallback: false
10-04 16:55:33.825  2453  2453 I HoneySpace.GestureEventController: RecentsAnimationFinished.
10-04 16:55:33.825  2042  2164 I SurfaceControl: hide, t=FinishTransaction_SyncId<428>, sc=Surface(name=Task=148)/@0xda8b426, caller=com.android.wm.shell.recents.RecentsTransitionHandler$RecentsController.finishInner:488 com.android.wm.shell.recents.RecentsTransitionHandler$RecentsController$$ExternalSyntheticLambda2.run:7 android.os.Handler.handleCallback:958 android.os.Handler.dispatchMessage:99 android.os.Looper.loopOnce:230 android.os.Looper.loop:319 
10-04 16:55:33.825  2042  2164 V ShellRecents: [44710043] RecentsController.cleanup
10-04 16:55:33.825  2453  2453 I HoneySpace.RunnableList: executeAllAndClear() called
10-04 16:55:33.825  1073  1124 I SurfaceFlinger: id=5558 Removed Surface(name=Task=7)/@0xdb9b81_transition-leash#5558 (125)
10-04 16:55:33.825  1073  1124 I SurfaceFlinger: id=5557 Removed Surface(name=TransientLaunchOverlayToken{fb49392 token=android.os.BinderProxy@2aee51d})/@0x9146b68_transition-leash#5557 (125)
10-04 16:55:33.825  2453 10484 I HoneySpace.RecentTasks: onAnimationStateChanged() called with: running = false
10-04 16:55:33.825  2042  2164 V WindowManagerShell: Transition animation finished (aborted=false), notifying core (#428)android.os.BinderProxy@f2d2013@0
10-04 16:55:33.825  2042  2164 I SurfaceControl: apply is called, name=FinishTransaction_SyncId<428>, caller=android.view.SurfaceControl$Transaction.apply:2921 com.android.wm.shell.transition.Transitions.onFinish:302 com.android.wm.shell.transition.Transitions$$ExternalSyntheticLambda6.onTransitionFinished:11 com.android.wm.shell.recents.RecentsTransitionHandler$RecentsController.finishInner:548 com.android.wm.shell.recents.RecentsTransitionHandler$RecentsController$$ExternalSyntheticLambda2.run:7 android.os.Handler.handleCallback:958 
10-04 16:55:33.825  2453  6740 I HoneySpace.ShellTransitionManager: transitionRunning END! : false
10-04 16:55:33.826  1427  7159 V WindowManager: Finish Transition: TransitionRecord{e22f8cd id=428 type=TO_FRONT flags=0x80}, caller=com.android.server.wm.WindowOrganizerController.finishTransition:454 android.window.IWindowOrganizerController$Stub.onTransact:286 com.android.server.wm.WindowOrganizerController.onTransact:217 
10-04 16:55:33.826   994  1071 I HYPER-HAL: [ResourceManager.cpp]removeResource(): [CPUMinFreq] RemoveResource Request ID : 3009831
10-04 16:55:33.826  1427  1578 V WindowManager: Finish Transition #428: created at 10-04 16:55:33.442 collect-started=0.335ms started=0.483ms ready=6.455ms sent=22.526ms finished=384.055ms
10-04 16:55:33.826   994  1071 I HYPER-HAL: [RequestManager.cpp]releaseLocked(): Released ID : 3009831
10-04 16:55:33.827  1427  7159 V WindowManager: Setting visibility of Window{344fe1b u0 com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity}: false, caller=com.android.server.wm.WindowContainer.sendAppVisibilityToClients:1301 com.android.server.wm.WindowToken.setClientVisible:446 com.android.server.wm.ActivityRecord.setClientVisible:8121 com.android.server.wm.ActivityRecord.postApplyAnimation:6685 com.android.server.wm.ActivityRecord.commitVisibility:6628 
10-04 16:55:33.827  1427  7159 I TransientLaunchOverlayToken: setVisibility, visible=false, t=TransientLaunchOverlayToken{fb49392 token=android.os.BinderProxy@2aee51d}, caller=com.android.server.wm.Transition.finishTransition:1507 com.android.server.wm.TransitionController.finishTransition:1113 com.android.server.wm.WindowOrganizerController.finishTransition:454 
10-04 16:55:33.827 16972 16972 I ViewRootImpl@56e8b21[MainActivity]: handleAppVisibility mAppVisible = true visible = false
10-04 16:55:33.828  1427  7159 D ActivityTaskManager: setCanAffectSystemUiFlags: true for Task{9be573a #7 type=recents I=com.sec.android.app.launcher/com.android.quickstep.RecentsActivity} from com.android.server.wm.Transition.finishTransition:1632 com.android.server.wm.TransitionController.finishTransition:1113 com.android.server.wm.WindowOrganizerController.finishTransition:454 android.window.IWindowOrganizerController$Stub.onTransact:286 com.android.server.wm.WindowOrganizerController.onTransact:217 android.os.Binder.execTransactInternal:1380 android.os.Binder.execTransact:1311 <bottom of call stack> <bottom of call stack> <bottom of call stack> 
10-04 16:55:33.829  2042  2164 V WindowManagerShell: Track 0 became idle
10-04 16:55:33.829  2042  2164 V WindowManagerShell: All active transition animations finished
10-04 16:55:33.829  1073  1073 I Layer   : Layer [Task=148#5542] hidden!! flag(1)
10-04 16:55:33.829  1073  1073 I Layer   : id=5556 removeFromCurrentState Transition Root: Task=7#5556 (125)
10-04 16:55:33.829  1073  1073 I Layer   : id=5558 removeFromCurrentState Surface(name=Task=7)/@0xdb9b81_transition-leash#5558 (125)
10-04 16:55:33.829  1073  1073 I Layer   : id=125 removeFromCurrentState Task=7#125 (125)
10-04 16:55:33.829  1073  1073 I Layer   : id=126 removeFromCurrentState ActivityRecord{38c4e65 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity t7}#126 (125)
10-04 16:55:33.829  1073  1073 I Layer   : id=439 removeFromCurrentState bc64b5c ActivityRecordInputSink com.sec.android.app.launcher/com.android.quickstep.RecentsActivity#439 (125)
10-04 16:55:33.829  1073  1073 I Layer   : id=135 removeFromCurrentState e458a32 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity#135 (125)
10-04 16:55:33.829  1073  1073 I Layer   : id=5560 removeFromCurrentState com.sec.android.app.launcher/com.android.quickstep.RecentsActivity$_2453#5560 (125)
10-04 16:55:33.829  1073  1073 I Layer   : id=5557 removeFromCurrentState Surface(name=TransientLaunchOverlayToken{fb49392 token=android.os.BinderProxy@2aee51d})/@0x9146b68_transition-leash#5557 (125)
10-04 16:55:33.829  1073  1073 I Layer   : id=127 removeFromCurrentState TransientLaunchOverlayToken{fb49392 token=android.os.BinderProxy@2aee51d}#127 (125)
10-04 16:55:33.829  1073  1073 I Layer   : id=128 removeFromCurrentState 9c58163 RecentsTransitionOverlay#128 (125)
10-04 16:55:33.829  1073  1073 I Layer   : id=132 removeFromCurrentState RecentsTransitionOverlay$_2453#132 (125)
10-04 16:55:33.829  1073  1073 I Layer   : id=5559 removeFromCurrentState Surface(name=Task=148)/@0xda8b426_transition-leash#5559 (125)
10-04 16:55:33.829  1073  1073 I Layer   : id=125 addToCurrentState Task=7#125 (125)
10-04 16:55:33.829  1073  1073 I Layer   : id=126 addToCurrentState ActivityRecord{38c4e65 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity t7}#126 (125)
10-04 16:55:33.829  1073  1073 I Layer   : id=439 addToCurrentState bc64b5c ActivityRecordInputSink com.sec.android.app.launcher/com.android.quickstep.RecentsActivity#439 (125)
10-04 16:55:33.829  1073  1073 I Layer   : id=135 addToCurrentState e458a32 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity#135 (125)
10-04 16:55:33.829  1073  1073 I Layer   : id=5560 addToCurrentState com.sec.android.app.launcher/com.android.quickstep.RecentsActivity$_2453#5560 (125)
10-04 16:55:33.829  1073  1073 I Layer   : Layer [TransientLaunchOverlayToken{fb49392 token=android.os.BinderProxy@2aee51d}#127] hidden!! flag(1)
10-04 16:55:33.829  1073  1073 I Layer   : id=127 addToCurrentState TransientLaunchOverlayToken{fb49392 token=android.os.BinderProxy@2aee51d}#127 (125)
10-04 16:55:33.829  1073  1073 I Layer   : id=128 addToCurrentState 9c58163 RecentsTransitionOverlay#128 (125)
10-04 16:55:33.829  1073  1073 I Layer   : id=132 addToCurrentState RecentsTransitionOverlay$_2453#132 (125)
10-04 16:55:33.829  1073  1073 I Layer   : id=5556 removeFromCurrentState Transition Root: Task=7#5556 (125)
10-04 16:55:33.829  1073  1073 I Layer   : id=5558 removeFromCurrentState Surface(name=Task=7)/@0xdb9b81_transition-leash#5558 (125)
10-04 16:55:33.829  1073  1073 I Layer   : id=5557 removeFromCurrentState Surface(name=TransientLaunchOverlayToken{fb49392 token=android.os.BinderProxy@2aee51d})/@0x9146b68_transition-leash#5557 (125)
10-04 16:55:33.829  1073  1073 I Layer   : id=5559 removeFromCurrentState Surface(name=Task=148)/@0xda8b426_transition-leash#5559 (125)
10-04 16:55:33.829  1073  1073 I SurfaceFlinger: id=5556 Removed Transition Root: Task=7#5556 (125)
10-04 16:55:33.830  1427  4443 D InputDispatcher: Focus left window (0): recents_animation_input_consumer
10-04 16:55:33.830  1427  1582 D FreeformController: beginPostLayoutPolicyLw: forceHideRequester changed, old=Window{9c58163 u0 RecentsTransitionOverlay}, new=Window{e458a32 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity}
10-04 16:55:33.831  1427  1582 D FreeformController: setBlockToAddForceHideFreeformTasks: blockToAddForceHide=false, Caller=com.android.server.wm.FreeformController.beginPostLayoutPolicyLw:839
10-04 16:55:33.831  1427  1582 D WindowManager: updateSystemBarAttributes: displayId=0, win=Window{e458a32 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity}, navColorWin=Window{e458a32 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity}, focusedCanBeNavColorWin=false, behavior=1, appearance=0, statusBarAppearanceRegions=[AppearanceRegion{ bounds=[0,0][1080,2400]}], requestedVisibilities=-9, from=com.android.server.wm.DisplayPolicy.finishPostLayoutPolicyLw:2320 com.android.server.wm.DisplayContent.applySurfaceChangesTransaction:6130 com.android.server.wm.RootWindowContainer.applySurfaceChangesTransaction:1180 
10-04 16:55:33.831  1427  1582 D FreeformController: setBlockToAddForceHideFreeformTasks: blockToAddForceHide=true, Caller=com.android.server.wm.FreeformController.finishPostLayoutPolicyLw:894
10-04 16:55:33.832 16972 16972 I ViewRootImpl@56e8b21[MainActivity]: destroyHardwareResources: Callers=android.view.ViewRootImpl.performTraversals:3932 android.view.ViewRootImpl.doTraversal:3288 android.view.ViewRootImpl$TraversalRunnable.run:11344 android.view.Choreographer$CallbackRecord.run:1689 android.view.Choreographer$CallbackRecord.run:1698 android.view.Choreographer.doCallbacks:1153 android.view.Choreographer.doFrame:1079 android.view.Choreographer$FrameDisplayEventReceiver.run:1646 android.os.Handler.handleCallback:958 android.os.Handler.dispatchMessage:99 
10-04 16:55:33.833  1073  1073 D SurfaceFlinger: Display 4633128672291735937 HWC layers:
10-04 16:55:33.833  1073  1073 D SurfaceFlinger:      CLIENT | 0xb400007784fa1a50 | 0100 | RGBA_8888    |  678.0   40.0 1722.0 2360.0 |    0    0 1080 2400 | Wallpaper BBQ wrapper 5_system#85
10-04 16:55:33.833  1073  1073 D SurfaceFlinger:      CLIENT | 0xb400007784faefd0 | 0100 | RGBA_8888    |    0.0    0.0 1080.0 2400.0 |    0    0 1080 2400 | com.sec.android.app.launcher/com.and[...]ntsActivity$_2453#5560 (blurRegions)
10-04 16:55:33.833  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784fa6210 | 0100 | RGBA_8888    |    0.0    0.0 1080.0   80.0 |    0    0 1080   80 | StatusBar$_2042#89
10-04 16:55:33.833  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784fe2110 | 0100 | RGBA_8888    |    0.0    0.0   67.0  342.0 | 1013  623 1080  965 | com.sec.android.app.launcher/com.sam[...]e.edge.CocktailBarService$_2453#2631
10-04 16:55:33.833  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784f9db50 | 0100 | RGBA_8888    |    0.0    0.0 1080.0  144.0 |    0 2256 1080 2400 | NavigationBar0$_2042#82
10-04 16:55:33.833  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784fb6510 | 0140 | RGBA_8888    |    0.0    0.0 1080.0   80.0 |    0    0 1080   80 | ScreenDecorOverlay$_2042#99
10-04 16:55:33.833  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784fd5ed0 | 0140 | RGBA_8888    |    0.0    0
10-04 16:55:33.833  1073  1073 D SurfaceFlinger: .0 1080.0   80.0 |    0 2320 1080 2400 | ScreenDecorOverlayBottom$_2042#100
10-04 16:55:33.833  1073  1073 D SurfaceFlinger: 
10-04 16:55:33.834  2042  2042 D SamsungStatusBarGrayIconHelper: isGrayAppearance=false
10-04 16:55:33.834  2042  2042 D NavigationBar: onSystemBarAttributesChanged() -  displayId:0, appearance:0, packageName: com.sec.android.app.launcher, navbarColorManagedByIme:false
10-04 16:55:33.835  2042  2042 D SamsungLightBarControlHelper: updateNavigationBar (WHITE button) isLightOpaque:false, hasLightNavigationBarFlag:false, packageName:com.sec.android.app.launcher, DirectReplying:false, NavBarColorMangedByIme:false, ForceDarkForScrim:false, QsCustomizing:false, PanelHasWhiteBg:true
10-04 16:55:33.835 16972 17010 D OpenGLRenderer: CacheManager::trimMemory(20)
10-04 16:55:33.837  1073  1073 I Layer   : Layer [RecentsTransitionOverlay$_2453#132] hidden!! flag(1)
10-04 16:55:33.837  1073  1073 I Layer   : Layer [com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity$_16972#5551] hidden!! flag(1)
10-04 16:55:33.837  1073  1073 I Layer   : Layer [Input Consumer recents_animation_input_consumer#124] hidden!! flag(1)
10-04 16:55:33.837  1073  1073 I Layer   : Layer [ActivityRecord{7496249 u0 com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity t148}#5543] hidden!! flag(1)
10-04 16:55:33.837  1073  1073 I Layer   : id=5556 Destroyed Transition Root: Task=7#5556
10-04 16:55:33.837  1073  1073 I Layer   : id=5558 Destroyed Surface(name=Task=7)/@0xdb9b81_transition-leash#5558
10-04 16:55:33.837  1073  1073 I Layer   : id=5557 Destroyed Surface(name=TransientLaunchOverlayToken{fb49392 token=android.os.BinderProxy@2aee51d})/@0x9146b68_transition-leash#5557
10-04 16:55:33.838  1427  1472 D InputDispatcher: Focus entered window (0): e458a32 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity
10-04 16:55:33.839  1073  1370 I SurfaceFlinger: id=5559 Removed Surface(name=Task=148)/@0xda8b426_transition-leash#5559 (122)
10-04 16:55:33.839  2042  2042 D NavigationModeController: getCurrentUserContext: contextUser=0 currentUser=0
10-04 16:55:33.839  1427  7159 V WindowManager: Relayout Window{344fe1b u0 com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity}: viewVisibility=8 req=1080x2400 ty=1 d0
10-04 16:55:33.842  1427  1581 I ActivityManager: Changes in 10384 2 to 15, 63 to 0
10-04 16:55:33.843  2362  2362 D HidDeviceService: handleMessage(): msg.what=8
10-04 16:55:33.845  1427  7972 V WindowManager: Relayout Window{9c58163 u0 RecentsTransitionOverlay}: viewVisibility=0 req=1x1 ty=2632 d0
10-04 16:55:33.845  1073  1073 I Layer   : id=5559 Destroyed Surface(name=Task=148)/@0xda8b426_transition-leash#5559
10-04 16:55:33.847  1427  7159 V WindowManager: Relayout hash=344fe1b, pid=16972, syncId=-1: mAttrs={(0,0)(fillxfill) sim={adjust=pan forwardNavigation} ty=BASE_APPLICATION wanim=0x1030303
10-04 16:55:33.847  1427  7159 V WindowManager:   fl=81810100
10-04 16:55:33.847  1427  7159 V WindowManager:   pfl=12008040
10-04 16:55:33.847  1427  7159 V WindowManager:   apr=LIGHT_NAVIGATION_BARS
10-04 16:55:33.847  1427  7159 V WindowManager:   bhv=DEFAULT
10-04 16:55:33.847  1427  7159 V WindowManager:   fitSides= naviIconColor=0
10-04 16:55:33.847  1427  7159 V WindowManager:   sfl=100000}
10-04 16:55:33.848  1427  7972 V WindowManager: Relayout hash=9c58163, pid=2453, syncId=-1: mAttrs={(0,0)(1x1) gr=BOTTOM CENTER_VERTICAL sim={adjust=pan} layoutInDisplayCutoutMode=always ty=TRANSIENT_LAUNCH_OVERLAY fmt=TRANSLUCENT if=INPUT_FEATURE_NO_INPUT_CHANNEL
10-04 16:55:33.848  1427  7972 V WindowManager:   fl=118
10-04 16:55:33.848  1427  7972 V WindowManager:   pfl=12000000
10-04 16:55:33.848  1427  7972 V WindowManager:   bhv=DEFAULT naviIconColor=0
10-04 16:55:33.848  1427  7972 V WindowManager:   sfl=4020000}
10-04 16:55:33.848  2042  2042 D NavigationModeController: getCurrentUserContext: contextUser=0 currentUser=0
10-04 16:55:33.848  1427  1748 D CompatibilityChangeReporter: Compat change id reported: 265195908; UID 10384; state: ENABLED
10-04 16:55:33.848  1427  1581 V WindowManager: Unknown focus tokens, dropping reportFocusChanged
10-04 16:55:33.849  2453  2453 I BLASTBufferQueue_Java: update, w= 1 h= 1 mName = ViewRootImpl@ec6b24c[RecentsTransitionOverlay] mNativeObject= 0xb4000078cd40ddd0 sc.mNativeObject= 0xb400007a2d4119d0 format= -3 caller= android.view.ViewRootImpl.updateBlastSurfaceIfNeeded:3017 android.view.ViewRootImpl.relayoutWindow:10131 android.view.ViewRootImpl.performTraversals:4110 android.view.ViewRootImpl.doTraversal:3288 android.view.ViewRootImpl$TraversalRunnable.run:11344 android.view.Choreographer$CallbackRecord.run:1689 
10-04 16:55:33.849  2453  2453 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: Relayout returned: old=(0,0,1080,2400) new=(539,2399,540,2400) relayoutAsync=false req=(1,1)0 dur=19 res=0x1 s={true 0xb40000781d441ce0} ch=false seqId=0
10-04 16:55:33.849  2453  2453 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: Setup new sync=wmsSync-ViewRootImpl@ec6b24c[RecentsTransitionOverlay]#70
10-04 16:55:33.849  2453  2453 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: Creating new active sync group ViewRootImpl@ec6b24c[RecentsTransitionOverlay]#71
10-04 16:55:33.850  2453  2453 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: registerCallbacksForSync syncBuffer=false
10-04 16:55:33.850  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: Received frameDrawingCallback syncResult=0 frameNum=3626.
10-04 16:55:33.850  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: mWNT: t=0xb40000786d445d50 mBlastBufferQueue=0xb4000078cd40ddd0 fn= 3626 mRenderHdrSdrRatio=1.0 caller= android.view.ViewRootImpl$8.onFrameDraw:13841 android.view.ThreadedRenderer$1.onFrameDraw:792 <bottom of call stack> 
10-04 16:55:33.850  2453  4617 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: Setting up sync and frameCommitCallback
10-04 16:55:33.851 16972 16972 I ViewRootImpl@56e8b21[MainActivity]: Relayout returned: old=(0,0,1080,2400) new=(0,0,1080,2400) relayoutAsync=false req=(1080,2400)8 dur=14 res=0x402 s={false 0x0} ch=true seqId=0
10-04 16:55:33.851  2453  4470 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: Received frameCommittedCallback lastAttemptedDrawFrameNum=3626 didProduceBuffer=true
10-04 16:55:33.851  2453  2453 I ViewRootImpl@ec6b24c[RecentsTransitionOverlay]: reportDrawFinished seqId=0
10-04 16:55:33.852  1427  7159 D WindowManager: finishDrawingWindow: Window{9c58163 u0 RecentsTransitionOverlay} mDrawState=HAS_DRAWN seqId=0
10-04 16:55:33.853  2042  2042 D NavigationModeController: getCurrentUserContext: contextUser=0 currentUser=0
10-04 16:55:33.856  2042  2042 D NavigationModeController: getCurrentUserContext: contextUser=0 currentUser=0
10-04 16:55:33.857  2453  2453 I HoneySpace.HoneyScreenManagerImpl: updateBackground, state: com.honeyspace.sdk.RecentScreen$Normal@31c8f3b
10-04 16:55:33.857  2453  2453 I HoneySpace.RecentscreenPot: changeState : com.honeyspace.sdk.RecentScreen$Normal@31c8f3b
10-04 16:55:33.857  2453  2453 I HoneySpace.RecentscreenPot: recent screenAlphaWhileGesture, alpah 1
10-04 16:55:33.857  2453  2453 I HoneySpace.BackgroundManagerImpl: updateProperties[ch=204279839], com.honeyspace.sdk.RecentScreen$Normal@31c8f3b, true
10-04 16:55:33.857  2453  2453 I HoneySpace.BackgroundManagerImpl: updateDimColor[ch=204279839]
10-04 16:55:33.857  2453  2453 I HoneySpace.BackgroundManagerImpl: updated the scrimView's end color : com.honeyspace.sdk.RecentScreen$Normal@31c8f3b
10-04 16:55:33.857  2453  2453 I HoneySpace.BackgroundManagerImpl: updateLastDimAndBlur[ch=204279839]dim[0.0 -> 0.0] ,wBlur[1.0 -> 1.0
10-04 16:55:33.857  2453  2453 I HoneySpace.BackgroundManagerImpl: updateLastState[204279839]: com.honeyspace.sdk.RecentScreen$Normal@31c8f3b -> com.honeyspace.sdk.RecentScreen$Normal@31c8f3b
10-04 16:55:33.857  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgress: com.honeyspace.sdk.RecentScreen$Normal@31c8f3b, p=1.0, ch=204279839, open=true
10-04 16:55:33.857  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToScrimView[ch=204279839]: progress = 1.0, dim = 0.0, currentDimAlpha={204279839=0.0, 194873307=0.0}
10-04 16:55:33.857  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:33.857  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToBlurView[ch=204279839, st =  com.honeyspace.sdk.RecentScreen$Normal@31c8f3b, progress = 1.0, wb= 1.0]
10-04 16:55:33.859  2042  2042 D NavigationModeController: getCurrentUserContext: contextUser=0 currentUser=0
10-04 16:55:33.859  2453  2453 I ViewRootImpl@1f7ce54[RecentsActivity]: handleWindowFocusChanged: 1 0 call from android.view.ViewRootImpl.-$$Nest$mhandleWindowFocusChanged:0
10-04 16:55:33.860  2453  2453 I InputMethodManager: startInputInner - IInputMethodManagerGlobalInvoker.startInputOrWindowGainedFocus
10-04 16:55:33.860  1427  7972 D InputMethodManagerService: setWindowStateInner, windowToken=android.os.BinderProxy@de5123d, state=ImeTargetWindowState{ imeToken null imeFocusChanged true hasEditorFocused false requestedImeVisible false imeDisplayId 0 softInputModeState STATE_UNSPECIFIED|ADJUST_RESIZE isStartInputByGainFocus true}
10-04 16:55:33.860  1427  7972 V InputMethodManagerService: Unspecified window will hide input
10-04 16:55:33.860  1427  7972 V InputMethodManagerService: applyImeVisibility state=6
10-04 16:55:33.860  1427  7972 I ImeTracker: com.sec.android.app.launcher:67bb9a09: onRequestHide at ORIGIN_SERVER_HIDE_INPUT reason HIDE_UNSPECIFIED_WINDOW
10-04 16:55:33.860  1427  7972 D InputMethodManagerService: setWindowStateInner, windowToken=android.os.BinderProxy@de5123d, state=ImeTargetWindowState{ imeToken android.os.Binder@16c1ff0 imeFocusChanged true hasEditorFocused false requestedImeVisible false imeDisplayId 0 softInputModeState STATE_UNSPECIFIED|ADJUST_RESIZE isStartInputByGainFocus true}
10-04 16:55:33.860  1427  7972 I ImeTracker: com.sec.android.app.launcher:67bb9a09: onCancelled at PHASE_SERVER_SHOULD_HIDE
10-04 16:55:33.860  1427  7972 V InputMethodManagerService: hideCurrentInputLocked : canceled, shouldHideSoftInput=false, mInputShown=false, mImeWindowVis=0
10-04 16:55:33.861  1427  7972 D InputMethodManagerService: DESKTOP MODE! : 2
10-04 16:55:33.861  1427  7972 D InputMethodManagerService: NOT IN KNOX DESKTOP MODE!
10-04 16:55:33.861  1427  7972 V InputMethodManagerService: getDisplayIdOfInputMethodWindowToBeAdded: displayId=0
10-04 16:55:33.861  2042  2042 I BLASTBufferQueue_Java: update, w= 1080 h= 144 mName = ViewRootImpl@141c4ca[NavigationBar0] mNativeObject= 0xb4000078cd42b290 sc.mNativeObject= 0xb400007a2d40c090 format= -3 caller= android.view.ViewRootImpl.updateBlastSurfaceIfNeeded:3017 android.view.ViewRootImpl.relayoutWindow:10131 android.view.ViewRootImpl.performTraversals:4110 android.view.ViewRootImpl.doTraversal:3288 android.view.ViewRootImpl$TraversalRunnable.run:11344 android.view.Choreographer$CallbackRecord.run:1689 
10-04 16:55:33.861  2042  2042 I ViewRootImpl@141c4ca[NavigationBar0]: Relayout returned: old=(0,2256,1080,2400) new=(0,2256,1080,2400) relayoutAsync=true req=(1080,144)0 dur=0 res=0x0 s={true 0xb40000781d4195b0} ch=false seqId=0
10-04 16:55:33.861  1427  7159 V WindowManager: Relayout Window{e6bbee6 u0 NavigationBar0}: viewVisibility=0 req=1080x144 ty=2019 d0
10-04 16:55:33.862  2042  2042 I ViewRootImpl@141c4ca[NavigationBar0]: registerCallbackForPendingTransactions
10-04 16:55:33.862  1427  7972 D InputMethodManagerService: isImeSwitcherDisabledPackage : false
10-04 16:55:33.862  2042  2784 I ViewRootImpl@141c4ca[NavigationBar0]: mWNT: t=0xb40000786d4729b0 mBlastBufferQueue=0xb4000078cd42b290 fn= 10698 mRenderHdrSdrRatio=1.0 caller= android.view.ViewRootImpl$6.onFrameDraw:5635 android.view.ViewRootImpl$2.onFrameDraw:2146 android.view.ThreadedRenderer$1.onFrameDraw:792 
10-04 16:55:33.862  1427  7972 D InputMethodManagerService: checkDisplayOfStartInputAndUpdateKeyboard: displayId=0, mFocusedDisplayId=0
10-04 16:55:33.862  1427  7972 D InputTransport: Input channel constructed: 'ClientS', fd=800
10-04 16:55:33.862  1427  7972 D InputTransport: Input channel destroyed: 'ClientS', fd=800
10-04 16:55:33.865  1427  7972 D RestrictionPolicy: isScreenCaptureEnabled : ret=true userId=0
10-04 16:55:33.866  1427  7972 I WindowManager: Cancelling animation restarting=true, leash=Surface(name=Surface(name=f319ab4 InputMethod)/@0xcb81495 - animation-leash of insets_animation)/@0xed08e9a
10-04 16:55:33.866  1427  7972 I WindowManager: Reparenting to original parent: Surface(name=WindowToken{1909d62 type=2011 android.os.Binder@2d0b42d})/@0xc779cd0, destroy=false, surface=Surface(name=f319ab4 InputMethod)/@0xcb81495
10-04 16:55:33.866  1427  7972 I WindowManager: Reparenting to leash, surface=Surface(name=f319ab4 InputMethod)/@0xcb81495, leashParent=Surface(name=WindowToken{1909d62 type=2011 android.os.Binder@2d0b42d})/@0xc779cd0
10-04 16:55:33.866  5004  5004 I HBD     : HoneyBoardService onFinishInput 
10-04 16:55:33.866  5004  5004 I HBD     : a IC have been unbinding,  RemoteInputConnection{idHash=#7b2c67e}
10-04 16:55:33.866  5004  5004 I HBD     : HoneyBoardService [PF_CL][onFinishInput]  0 ms 
10-04 16:55:33.866  5004  5004 I HBD     : HoneyBoardService [IMI] onStartInput - caller pid : 2453 , caller uid : 10137 
10-04 16:55:33.866  5004  5004 I HBD     : k updateConfigs 
10-04 16:55:33.866  5004  5004 I HBD     : k isEnabledNightMode : false 
10-04 16:55:33.866  5004  5004 I HBD     : a IC have been binding, RemoteInputConnection{idHash=#f534c2c} 
10-04 16:55:33.866  5004  5004 I HBD     : h [EditorInputType]setPrivateImeOptionsToTable privateImeOptions ( null )
10-04 16:55:33.866  5004  5004 I HBD     : b incognitoMode : false 
10-04 16:55:33.866  5004  5004 I HBD     : b needOff = true , isForceOff = false, isNullInputClass : true 
10-04 16:55:33.866  5004  5004 I HBD     : h getDefaultInputRange : UNKNOWN 
10-04 16:55:33.866  5004  5004 I HBD     : h getDefaultInputRange : UNKNOWN 
10-04 16:55:33.866  5004  5004 I HBD     : h getDefaultInputRange : UNKNOWN 
10-04 16:55:33.867  1073  1370 I SurfaceFlinger: id=5565 createSurf, flag=24004, Surface(name=f319ab4 InputMethod)/@0xcb81495 - animation-leash of insets_animation#5565
10-04 16:55:33.867  1427  7972 D WindowManager: makeSurface duration=1 leash=Surface(name=Surface(name=f319ab4 InputMethod)/@0xcb81495 - animation-leash of insets_animation)/@0x81afc8f
10-04 16:55:33.867  1427  7972 D InsetsSourceProvider: updateControlForTarget: control=InsetsSourceControl: {3 mType=ime mSurfacePosition=Point(0, 80) mInsetsHint=Insets{left=0, top=0, right=0, bottom=1026}}, target=Window{e458a32 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity}, from=com.android.server.wm.ImeInsetsSourceProvider.updateControlForTarget:165 com.android.server.wm.InsetsStateController.onControlTargetChanged:358 com.android.server.wm.InsetsStateController.onImeControlTargetChanged:302 com.android.server.wm.DisplayContent.updateImeControlTarget:5727 com.android.server.wm.DisplayContent.updateImeInputAndControlTarget:5687 
10-04 16:55:33.868 16972 17010 D OpenGLRenderer: CacheManager::trimMemory(20)
10-04 16:55:33.870  1427  7159 V WindowManager: Relayout hash=e6bbee6, pid=0, syncId=-1: mAttrs={(0,0)(fillx144) gr=BOTTOM CENTER_VERTICAL sim={adjust=pan} layoutInDisplayCutoutMode=always ty=NAVIGATION_BAR fmt=TRANSLUCENT
10-04 16:55:33.870  1427  7159 V WindowManager:   fl=20840028
10-04 16:55:33.870  1427  7159 V WindowManager:   pfl=33001000
10-04 16:55:33.870  1427  7159 V WindowManager:   bhv=DEFAULT
10-04 16:55:33.870  1427  7159 V WindowManager:   providedInsets:
10-04 16:55:33.870  1427  7159 V WindowManager:     InsetsFrameProvider: {id=#a1c30001, index=0, type=navigationBars, source=FRAME, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=144}, insetsSizeOverrides=[TypedInsetsSize: {windowType=INPUT_METHOD, insetsSize=null}]}
10-04 16:55:33.870  1427  7159 V WindowManager:     InsetsFrameProvider: {id=#a1c30006, index=0, type=tappableElement, source=FRAME, flags=[]}
10-04 16:55:33.870  1427  7159 V WindowManager:     InsetsFrameProvider: {id=#a1c30005, index=0, type=mandatorySystemGestures, source=FRAME, flags=[]}
10-04 16:55:33.870  1427  7159 V WindowManager:     InsetsFrameProvider: {id=#a1c30004, index=0, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}}
10-04 16:55:33.870  1427  7159 V WindowManager:     InsetsFrameProvider: {id=#a1c30024, index=1, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}}
10-04 16:55:33.870  1427  7159 V WindowManager:   paramsForRotation:
10-04 16:55:33.870  1427  7159 V WindowManager:     ROTATION_0={(0,0)(fillx144) gr=BOTTOM CENTER_VERTICAL layoutInDisplayCutoutMode=always ty=NAVIGATION_BAR fmt=TRANSLUCENT
10-04 16:55:33.870  1427  7159 V WindowManager:       fl=20840028
10-04 16:55:33.870  1427  7159 V WindowManager:       pfl=31001000
10-04 16:55:33.870  1427  7159 V WindowManager:       bhv=DEFAULT
10-04 16:55:33.870  1427  7159 V WindowManager:       providedInsets:
10-04 16:55:33.870  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30001, index=0, type=navigationBars, source=FRAME, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=144}, insetsSizeOverrides=[TypedInsetsSize: {windowType=INPUT_METHOD, insetsSize=null}]}
10-04 16:55:33.870  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30006, index=0, type=tappableElement, source=FRAME, flags=[]}
10-04 16:55:33.870  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30005, index=0, type=mandatorySystemGestures, source=FRAME, flags=[]}
10-04 16:55:33.870  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30004, index=0, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}}
10-04 16:55:33.870  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30024, index=1, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}} naviIconColor=0}
10-04 16:55:33.870  1427  7159 V WindowManager:     ROTATION_90={(0,0)(144xfill) gr=RIGHT CENTER_HORIZONTAL layoutInDisplayCutoutMode=always ty=NAVIGATION_BAR fmt=TRANSLUCENT
10-04 16:55:33.870  1427  7159 V WindowManager:       fl=20840028
10-04 16:55:33.870  1427  7159 V WindowManager:       pfl=31001000
10-04 16:55:33.870  1427  7159 V WindowManager:       bhv=DEFAULT
10-04 16:55:33.870  1427  7159 V WindowManager:       providedInsets:
10-04 16:55:33.870  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30001, index=0, type=navigationBars, source=FRAME, flags=[], insetsSizeOverrides=[TypedInsetsSize: {windowType=INPUT_METHOD, insetsSize=null}]}
10-04 16:55:33.870  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30006, index=0, type=tappableElement, source=FRAME, flags=[]}
10-04 16:55:33.870  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30005, index=0, type=mandatorySystemGestures, source=FRAME, flags=[]}
10-04 16:55:33.870  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30004, index=0, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}}
10-04 16:55:33.870  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30024, index=1, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}} naviIconColor=0}
10-04 16:55:33.870  1427  7159 V WindowManager:     ROTATION_180={(0,0)(fillx144) gr=BOTTOM CENTER_VERTICAL layoutInDisplayCutoutMode=always ty=NAVIGATION_BAR fmt=TRANSLUCENT
10-04 16:55:33.870  1427  7159 V WindowManager:       fl=20840028
10-04 16:55:33.870  1427  7159 V WindowManager:       pfl=31001000
10-04 16:55:33.870  1427  7159 V WindowManager:       bhv=DEFAULT
10-04 16:55:33.870  1427  7159 V WindowManager:       providedInsets:
10-04 16:55:33.870  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30001, index=0, type=navigationBars, source=FRAME, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=144}, insetsSizeOverrides=[TypedInsetsSize: {windowType=INPUT_METHOD, insetsSize=null}]}
10-04 16:55:33.870  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30006, index=0, type=tappableElement, source=FRAME, flags=[]}
10-04 16:55:33.870  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30005, index=0, type=mandatorySystemGestures, source=FRAME, flags=[]}
10-04 16:55:33.870  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30004, index=0, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}}
10-04 16:55:33.870  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30024, index=1, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}} naviIconColor=0}
10-04 16:55:33.870  1427  7159 V WindowManager:     ROTATION_270={(0,0)(144xfill) gr=LEFT CENTER_HORIZONTAL layoutInDisplayCutoutMode=always ty=NAVIGATION_BAR fmt=TRANSLUCENT
10-04 16:55:33.870  1427  7159 V WindowManager:       fl=20840028
10-04 16:55:33.870  1427  7159 V WindowManager:       pfl=31001000
10-04 16:55:33.870  1427  7159 V WindowManager:       bhv=DEFAULT
10-04 16:55:33.870  1427  7159 V WindowManager:       providedInsets:
10-04 16:55:33.870  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30001, index=0, type=navigationBars, source=FRAME, flags=[], insetsSizeOverrides=[TypedInsetsSize: {windowType=INPUT_METHOD, insetsSize=null}]}
10-04 16:55:33.870  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30006, index=0, type=tappableElement, source=FRAME, flags=[]}
10-04 16:55:33.870  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30005, index=0, type=mandatorySystemGestures, source=FRAME, flags=[]}
10-04 16:55:33.870  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30004, index=0, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}}
10-04 16:55:33.870  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30024, index=1, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}} naviIconColor=0} naviIconColor=0}
10-04 16:55:33.870  1073  1073 I Layer   : id=5555 removeFromCurrentState Surface(name=f319ab4 InputMethod)/@0xcb81495 - animation-leash of insets_animation#5555 (122)
10-04 16:55:33.871  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions RecentsActivity$_2453#5560 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=3.000, rect=[0, 0, 1080, 2400]
10-04 16:55:33.872  5004  5004 I HBD     : b needOff = true , isForceOff = false, isNullInputClass : true 
10-04 16:55:33.872  5004  5004 I HBD     : b update cached prediction status : false 
10-04 16:55:33.872  5004  5004 I HBD     : h getDefaultInputRange : UNKNOWN 
10-04 16:55:33.872  5004  5004 I HBD     : a currentState : 0 
10-04 16:55:33.872  5004  5004 I HBD     : a [UpdatePolicy] [post] a: 0 cl: 65538 kit: [0/0] vt: 0 ir: 1 
10-04 16:55:33.873  2453  2453 I InsetsSourceConsumer: applyRequestedVisibilityToControl: visible=false, type=ime, host=com.sec.android.app.launcher/com.android.quickstep.RecentsActivity
10-04 16:55:33.874  2453 10484 I ViewRootImpl@4145d62[CocktailBarService]: Resizing android.view.ViewRootImpl@d3e24c5: frame = [1013,623][1080,965] reportDraw = false forceLayout = false syncSeqId = -1
10-04 16:55:33.874  2042  2303 I ViewRootImpl@3eb5874[ScreenDecorOverlay]: Resizing android.view.ViewRootImpl@b239360: frame = [0,0][1080,80] reportDraw = false forceLayout = false syncSeqId = -1
10-04 16:55:33.874  1427  7159 D InputMethodManagerService: isImeSwitcherDisabledPackage : false
10-04 16:55:33.874  2042  9413 I ViewRootImpl@403463c[ScreenDecorOverlayBottom]: Resizing android.view.ViewRootImpl@49ccc1e: frame = [0,2320][1080,2400] reportDraw = false forceLayout = false syncSeqId = -1
10-04 16:55:33.874  2042  3044 I ViewRootImpl@3eb5874[ScreenDecorOverlay]: handleResized, msg = 4 frames=ClientWindowFrames{frame=[0,0][1080,80] display=[0,0][1080,2400] parentFrame=[0,0][0,0]} forceNextWindowRelayout=false displayId=0 dragResizing=false compatScale=1.0 frameChanged=false attachedFrameChanged=false configChanged=false displayChanged=false compatScaleChanged=false
10-04 16:55:33.874  2042  3044 I ViewRootImpl@403463c[ScreenDecorOverlayBottom]: handleResized, msg = 4 frames=ClientWindowFrames{frame=[0,2320][1080,2400] display=[0,0][1080,2400] parentFrame=[0,0][0,0]} forceNextWindowRelayout=false displayId=0 dragResizing=false compatScale=1.0 frameChanged=false attachedFrameChanged=false configChanged=false displayChanged=false compatScaleChanged=false
10-04 16:55:33.876  2042 14123 I ViewRootImpl@16e3a3f[StatusBar]: Resizing android.view.ViewRootImpl@a2ae18: frame = [0,0][1080,80] reportDraw = false forceLayout = false syncSeqId = -1
10-04 16:55:33.877  2453  7396 I ViewRootImpl@1f7ce54[RecentsActivity]: Resizing android.view.ViewRootImpl@76c0cbc: frame = [0,0][1080,2400] reportDraw = false forceLayout = false syncSeqId = -1
10-04 16:55:33.877  2042  4610 I ViewRootImpl@141c4ca[NavigationBar0]: Resizing android.view.ViewRootImpl@5ffbf13: frame = [0,2256][1080,2400] reportDraw = false forceLayout = false syncSeqId = -1
10-04 16:55:33.877  2042  2093 I WallpaperService: resized: system, syncSeqId=-1
10-04 16:55:33.877  2042  2331 I WallpaperService: handleResized: which=5, reportDraw=false
10-04 16:55:33.878  2042  2331 I WallpaperService: updateSurface system forceRelayout=true forceReport=false redrawNeeded=false myWidth=2400 myHeight=2400 fixedSize=true x = 0 y = 0 mWidth=2400 mHeight=2400
10-04 16:55:33.878  2042  2042 I ViewRootImpl@16e3a3f[StatusBar]: handleResized, msg = 4 frames=ClientWindowFrames{frame=[0,0][1080,80] display=[0,0][1080,2400] parentFrame=[0,0][0,0]} forceNextWindowRelayout=false displayId=0 dragResizing=false compatScale=1.0 frameChanged=false attachedFrameChanged=false configChanged=false displayChanged=false compatScaleChanged=false
10-04 16:55:33.878  2042  2331 I WallpaperService: maxBounds : Rect(0, 0 - 1080, 2400) , mDeviceHeight : 2400, mDeviceWidth : 1080,mDeviceRotation  : 0
10-04 16:55:33.878  2042  2331 I WallpaperService: updateSurface: invoke Session.relayout
10-04 16:55:33.878  1427  4443 V WindowManager: Relayout Window{7fa477f u0 com.android.systemui.wallpapers.ImageWallpaper_system}: viewVisibility=0 req=2400x2400 ty=2013 d0
10-04 16:55:33.880  5004  5004 I HBD     : a [NRIC] resetNoResponseState 
10-04 16:55:33.880  5004  5004 I HBD     : b needOff = true , isForceOff = false, isNullInputClass : true 
10-04 16:55:33.880  5004  5004 I HBD     : b update cached prediction status : false 
10-04 16:55:33.880  5004  5004 I HBD     : b [AiWriter] setContact : com.sec.android.app.launcher
10-04 16:55:33.880  5004  5004 I HBD     : m0 EBD si S 0 
10-04 16:55:33.880  5004  5004 I HBD     : m updateContactDBLanguage : 65538 
10-04 16:55:33.880  5004  5004 I HBD     : g isCoverDisplay : false, cached selected json info : SelectedLanguageInfo(languageVersion=4.1, currentLanguageOrder=0, selectedLanguageList=[SelectedLanguage(id=65538, isUsed=true, engName=English, inputType=qwerty, activeOptionList=[auto_replace, auto_spacing, writing_assistant])]) 
10-04 16:55:33.880  5004  5004 I HBD     : g updateSelectedLanguageCache is succeeded. English 
10-04 16:55:33.881  2453  2453 I ViewRootImpl@4145d62[CocktailBarService]: handleResized, msg = 4 frames=ClientWindowFrames{frame=[1013,623][1080,965] display=[0,0][1080,2256] parentFrame=[0,0][0,0]} forceNextWindowRelayout=false displayId=0 dragResizing=false compatScale=1.0 frameChanged=false attachedFrameChanged=false configChanged=false displayChanged=false compatScaleChanged=false
10-04 16:55:33.881  2453  2453 I ViewRootImpl@1f7ce54[RecentsActivity]: handleResized, msg = 4 frames=ClientWindowFrames{frame=[0,0][1080,2400] display=[0,0][1080,2400] parentFrame=[0,0][0,0]} forceNextWindowRelayout=false displayId=0 dragResizing=false compatScale=1.0 frameChanged=false attachedFrameChanged=false configChanged=false displayChanged=false compatScaleChanged=false
10-04 16:55:33.883  1427  4443 V WindowManager: Relayout hash=7fa477f, pid=2042, syncId=-1: mAttrs={(0,0)(2400x2400) gr=TOP START CENTER layoutInDisplayCutoutMode=always ty=WALLPAPER fmt=RGBX_8888 wanim=0x1030314
10-04 16:55:33.883  1427  4443 V WindowManager:   fl=14318
10-04 16:55:33.883  1427  4443 V WindowManager:   pfl=2000014
10-04 16:55:33.883  1427  4443 V WindowManager:   bhv=DEFAULT naviIconColor=0
10-04 16:55:33.883  1427  4443 V WindowManager:   sfl=8}
10-04 16:55:33.883  5004  5004 I HBD     : l writeToFile path : /data/user/0/com.samsung.android.honeyboard/files/selected.json 
10-04 16:55:33.883  5004  5004 I HBD     : l writeToFile json : {"version":"4.1","currentLanguageOrder":0,"selected":[{"activeOptionList":["auto_replace","auto_spacing","writing_assistant"],"engName":"English","id":65538,"inputType":"qwerty","isUsed":true}]} 
10-04 16:55:33.878  2042  2042 I ViewRootImpl@141c4ca[NavigationBar0]: handleResized, msg = 4 frames=ClientWindowFrames{frame=[0,2256][1080,2400] display=[0,0][1080,2400] parentFrame=[0,0][0,0]} forceNextWindowRelayout=false displayId=0 dragResizing=false compatScale=1.0 frameChanged=false attachedFrameChanged=false configChanged=false displayChanged=false compatScaleChanged=false
10-04 16:55:33.884  2042  2331 I BLASTBufferQueue_Java: update, w= 2400 h= 2400 mName = Wallpaper mNativeObject= 0xb4000078cd3f9bf0 sc.mNativeObject= 0xb400007a2d3f6610 format= 2 caller= android.service.wallpaper.WallpaperService$Engine.getOrCreateBLASTSurface:2827 android.service.wallpaper.WallpaperService$Engine.updateSurface:1623 android.service.wallpaper.WallpaperService$IWallpaperEngineWrapper.handleResized:3323 android.service.wallpaper.WallpaperService$IWallpaperEngineWrapper.executeMessage:3242 com.android.internal.os.HandlerCaller$MyHandler.handleMessage:44 android.os.Handler.dispatchMessage:106 
10-04 16:55:33.884  2042  2042 D NavigationBar: setImeWindowStatus displayId=0 vis=0 backDisposition=0 showImeSwitcher=false imeShown=false
10-04 16:55:33.885  5004  5004 I HBD     : l writeToFile complete 
10-04 16:55:33.885  5004 17116 I HBD     : l Write selected lang for DE  
10-04 16:55:33.885  5004 17116 I HBD     : l writeToFile path : /data/user_de/0/com.samsung.android.honeyboard/files/selected.json 
10-04 16:55:33.885  5004 17116 I HBD     : l writeToFile json : {"version":"4.1","currentLanguageOrder":0,"selected":[{"activeOptionList":["auto_replace","auto_spacing","writing_assistant"],"engName":"English","id":65538,"inputType":"qwerty","isUsed":true}]} 
10-04 16:55:33.885  5004  5004 I HBD     : g isCoverDisplay : false, cached selected json info : SelectedLanguageInfo(languageVersion=4.1, currentLanguageOrder=0, selectedLanguageList=[SelectedLanguage(id=65538, isUsed=true, engName=English, inputType=qwerty, activeOptionList=[auto_replace, auto_spacing, writing_assistant])]) 
10-04 16:55:33.885  5004  5004 I HBD     : n updateActionOptionFromPreference  
10-04 16:55:33.885  5004  5004 I HBD     : n before lang.activeOptionList =  [Ljava.lang.String;@45548a6 
10-04 16:55:33.885  5004  5004 I HBD     : n after lang.activeOptionList = [Ljava.lang.String;@a5552fb 
10-04 16:55:33.886  5004  5004 I HBD     : l writeToFile path : /data/user/0/com.samsung.android.honeyboard/files/selected.json 
10-04 16:55:33.886  5004  5004 I HBD     : l writeToFile json : {"version":"4.1","currentLanguageOrder":0,"selected":[{"activeOptionList":["auto_replace","auto_spacing","writing_assistant"],"engName":"English","id":65538,"inputType":"qwerty","isUsed":true}]} 
10-04 16:55:33.886  5004 17116 I HBD     : l writeToFile complete 
10-04 16:55:33.886  5004  5004 I HBD     : l writeToFile complete 
10-04 16:55:33.886  5004 17117 I HBD     : l Write selected lang for DE  
10-04 16:55:33.887  5004 17117 I HBD     : l writeToFile path : /data/user_de/0/com.samsung.android.honeyboard/files/selected.json 
10-04 16:55:33.887  5004 17117 I HBD     : l writeToFile json : {"version":"4.1","currentLanguageOrder":0,"selected":[{"activeOptionList":["auto_replace","auto_spacing","writing_assistant"],"engName":"English","id":65538,"inputType":"qwerty","isUsed":true}]} 
10-04 16:55:33.887  5004  5004 I HBD     : m normal : updateLanguage : English 
10-04 16:55:33.887  5004  5004 I HBD     : g isCoverDisplay : false, cached selected json info : SelectedLanguageInfo(languageVersion=4.1, currentLanguageOrder=0, selectedLanguageList=[SelectedLanguage(id=65538, isUsed=true, engName=English, inputType=qwerty, activeOptionList=[auto_replace, auto_spacing, writing_assistant])]) 
10-04 16:55:33.887  5004  5004 I HBD     : g isCoverDisplay : false, cached selected json info : SelectedLanguageInfo(languageVersion=4.1, currentLanguageOrder=0, selectedLanguageList=[SelectedLanguage(id=65538, isUsed=true, engName=English, inputType=qwerty, activeOptionList=[auto_replace, auto_spacing, writing_assistant])]) 
10-04 16:55:33.887  5004  5004 I HBD     : n updateActionOptionFromPreference  
10-04 16:55:33.887  5004  5004 I HBD     : n before lang.activeOptionList =  [Ljava.lang.String;@a5552fb 
10-04 16:55:33.887  5004  5004 I HBD     : n after lang.activeOptionList = [Ljava.lang.String;@61c23d7 
10-04 16:55:33.887  5004 17117 I HBD     : l writeToFile complete 
10-04 16:55:33.889  5004  5004 I HBD     : l writeToFile path : /data/user/0/com.samsung.android.honeyboard/files/selected.json 
10-04 16:55:33.889  5004  5004 I HBD     : l writeToFile json : {"version":"4.1","currentLanguageOrder":0,"selected":[{"activeOptionList":["auto_replace","auto_spacing","writing_assistant"],"engName":"English","id":65538,"inputType":"qwerty","isUsed":true}]} 
10-04 16:55:33.889 16972 16972 I ViewRootImpl@56e8b21[MainActivity]: stopped(true) old = false
10-04 16:55:33.889 16972 16972 D ViewRootImpl@56e8b21[MainActivity]: WindowStopped on com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity set to true
10-04 16:55:33.889 16972 17010 D OpenGLRenderer: CacheManager::trimMemory(20)
10-04 16:55:33.891  5004  5004 I HBD     : l writeToFile complete 
10-04 16:55:33.891  5004 17118 I HBD     : l Write selected lang for DE  
10-04 16:55:33.892  5004 17118 I HBD     : l writeToFile path : /data/user_de/0/com.samsung.android.honeyboard/files/selected.json 
10-04 16:55:33.892  5004 17118 I HBD     : l writeToFile json : {"version":"4.1","currentLanguageOrder":0,"selected":[{"activeOptionList":["auto_replace","auto_spacing","writing_assistant"],"engName":"English","id":65538,"inputType":"qwerty","isUsed":true}]} 
10-04 16:55:33.892  5004  5004 I HBD     : m normal : updateLanguage : English 
10-04 16:55:33.892  5004  5004 I HBD     : g isCoverDisplay : false, cached selected json info : SelectedLanguageInfo(languageVersion=4.1, currentLanguageOrder=0, selectedLanguageList=[SelectedLanguage(id=65538, isUsed=true, engName=English, inputType=qwerty, activeOptionList=[auto_replace, auto_spacing, writing_assistant])]) 
10-04 16:55:33.892  5004  5004 I HBD     : g isCoverDisplay : false, cached selected json info : SelectedLanguageInfo(languageVersion=4.1, currentLanguageOrder=0, selectedLanguageList=[SelectedLanguage(id=65538, isUsed=true, engName=English, inputType=qwerty, activeOptionList=[auto_replace, auto_spacing, writing_assistant])]) 
10-04 16:55:33.892  5004  5004 I HBD     : g updateSelectedLanguageCache is succeeded. English 
10-04 16:55:33.892  5004  5004 I HBD     : l writeToFile path : /data/user/0/com.samsung.android.honeyboard/files/selected.json 
10-04 16:55:33.892  5004  5004 I HBD     : l writeToFile json : {"version":"4.1","currentLanguageOrder":0,"selected":[{"activeOptionList":["auto_replace","auto_spacing","writing_assistant"],"engName":"English","id":65538,"inputType":"qwerty","isUsed":true}]} 
10-04 16:55:33.893  5004 17118 I HBD     : l writeToFile complete 
10-04 16:55:33.893  5004  5004 I HBD     : l writeToFile complete 
10-04 16:55:33.893  5004 17119 I HBD     : l Write selected lang for DE  
10-04 16:55:33.893  5004 17119 I HBD     : l writeToFile path : /data/user_de/0/com.samsung.android.honeyboard/files/selected.json 
10-04 16:55:33.893  5004 17119 I HBD     : l writeToFile json : {"version":"4.1","currentLanguageOrder":0,"selected":[{"activeOptionList":["auto_replace","auto_spacing","writing_assistant"],"engName":"English","id":65538,"inputType":"qwerty","isUsed":true}]} 
10-04 16:55:33.893  5004  5004 I HBD     : g isCoverDisplay : false, cached selected json info : SelectedLanguageInfo(languageVersion=4.1, currentLanguageOrder=0, selectedLanguageList=[SelectedLanguage(id=65538, isUsed=true, engName=English, inputType=qwerty, activeOptionList=[auto_replace, auto_spacing, writing_assistant])]) 
10-04 16:55:33.893  5004  5004 I HBD     : g updateSelectedLanguageCache is succeeded. English 
10-04 16:55:33.893  5004 17119 I HBD     : l writeToFile complete 
10-04 16:55:33.894  5004  5004 I HBD     : l writeToFile path : /data/user/0/com.samsung.android.honeyboard/files/selected.json 
10-04 16:55:33.894  5004  5004 I HBD     : l writeToFile json : {"version":"4.1","currentLanguageOrder":0,"selected":[{"activeOptionList":["auto_replace","auto_spacing","writing_assistant"],"engName":"English","id":65538,"inputType":"qwerty","isUsed":true}]} 
10-04 16:55:33.894  5004  5004 I HBD     : l writeToFile complete 
10-04 16:55:33.894  5004 17120 I HBD     : l Write selected lang for DE  
10-04 16:55:33.894  5004 17120 I HBD     : l writeToFile path : /data/user_de/0/com.samsung.android.honeyboard/files/selected.json 
10-04 16:55:33.894  1427  7972 D KNOX_MDM_SettingsProvider: isChangeAllowed() : name = enabled_input_methods
10-04 16:55:33.894  5004 17120 I HBD     : l writeToFile json : {"version":"4.1","currentLanguageOrder":0,"selected":[{"activeOptionList":["auto_replace","auto_spacing","writing_assistant"],"engName":"English","id":65538,"inputType":"qwerty","isUsed":true}]} 
10-04 16:55:33.894  1427  7972 D KNOX_MDM_SettingsProvider: edmUri: content://com.sec.knox.provider/RestrictionPolicy3
10-04 16:55:33.894  1427  7972 D KNOX_MDM_SettingsProvider: projectionArgs: isSettingsChangesAllowed
10-04 16:55:33.894  1427  7972 D KNOX_MDM_SettingsProvider: selectionArgs: false
10-04 16:55:33.894  1427  7972 D KNOX_MDM_SettingsProvider: selectionArgs: 10147
10-04 16:55:33.894  1427  7972 D SecContentProvider: query(), uri = 17 selection = isSettingsChangesAllowed
10-04 16:55:33.894  1427  7972 D SecContentProvider: called from android.uid.honeyboard:10147
10-04 16:55:33.894  5004  5004 I HBD     : a [UpdatePolicy] [post] a: 32 cl: 65538 kit: [0/0] vt: 0 ir: 1 
10-04 16:55:33.894  1427  7972 D RestrictionPolicy: isSettingsChangesAllowedAsUser, userId 0 : true
10-04 16:55:33.895  1427  7972 D KNOX_MDM_SettingsProvider: ret = 1
10-04 16:55:33.895  5004  5004 I HBD     : HoneyBoardService [PF_OP][onStartInput]  29 ms 
10-04 16:55:33.895  1427  7159 D KNOX_MDM_SettingsProvider: isChangeAllowed() : name = enabled_input_methods
10-04 16:55:33.895  1427  7159 D KNOX_MDM_SettingsProvider: edmUri: content://com.sec.knox.provider/RestrictionPolicy3
10-04 16:55:33.895  1427  7159 D KNOX_MDM_SettingsProvider: projectionArgs: isSettingsChangesAllowed
10-04 16:55:33.895  1427  7159 D KNOX_MDM_SettingsProvider: selectionArgs: false
10-04 16:55:33.895  1427  7159 D KNOX_MDM_SettingsProvider: selectionArgs: 10147
10-04 16:55:33.895  5004  5004 I InputMethodService: scheduleImeSurfaceRemoval: removeImeSurface is posted.
10-04 16:55:33.895  1427  7159 D SecContentProvider: query(), uri = 17 selection = isSettingsChangesAllowed
10-04 16:55:33.895  1427  7159 D SecContentProvider: called from android.uid.honeyboard:10147
10-04 16:55:33.895  1427  7159 D RestrictionPolicy: isSettingsChangesAllowedAsUser, userId 0 : true
10-04 16:55:33.895  1427  7159 D KNOX_MDM_SettingsProvider: ret = 1
10-04 16:55:33.895  1427  4443 D KNOX_MDM_SettingsProvider: isChangeAllowed() : name = default_input_method
10-04 16:55:33.895  1427  4443 D KNOX_MDM_SettingsProvider: edmUri: content://com.sec.knox.provider/RestrictionPolicy3
10-04 16:55:33.895  1427  4443 D KNOX_MDM_SettingsProvider: projectionArgs: isSettingsChangesAllowed
10-04 16:55:33.895  1427  4443 D KNOX_MDM_SettingsProvider: selectionArgs: false
10-04 16:55:33.895  1427  4443 D KNOX_MDM_SettingsProvider: selectionArgs: 10147
10-04 16:55:33.895  1427  7972 D KNOX_MDM_SettingsProvider: isChangeAllowed() : name = default_input_method
10-04 16:55:33.895  1427  7972 D KNOX_MDM_SettingsProvider: edmUri: content://com.sec.knox.provider/RestrictionPolicy3
10-04 16:55:33.895  1427  7972 D KNOX_MDM_SettingsProvider: projectionArgs: isSettingsChangesAllowed
10-04 16:55:33.895  1427  7972 D KNOX_MDM_SettingsProvider: selectionArgs: false
10-04 16:55:33.895  1427  7972 D KNOX_MDM_SettingsProvider: selectionArgs: 10147
10-04 16:55:33.895  1427  4443 D SecContentProvider: query(), uri = 17 selection = isSettingsChangesAllowed
10-04 16:55:33.895  1427  7972 D SecContentProvider: query(), uri = 17 selection = isSettingsChangesAllowed
10-04 16:55:33.895  1427  4443 D SecContentProvider: called from android.uid.honeyboard:10147
10-04 16:55:33.898  1427  4443 D RestrictionPolicy: isSettingsChangesAllowedAsUser, userId 0 : true
10-04 16:55:33.898  1427  4443 D KNOX_MDM_SettingsProvider: ret = 1
10-04 16:55:33.899  5004 17120 I HBD     : l writeToFile complete 
10-04 16:55:33.900  5004  5206 I HBD     : p updated Sub Types. English 
10-04 16:55:33.900  1427  7972 D SecContentProvider: called from android.uid.honeyboard:10147
10-04 16:55:33.900  1427  7972 D RestrictionPolicy: isSettingsChangesAllowedAsUser, userId 0 : true
10-04 16:55:33.901  1427  7972 D KNOX_MDM_SettingsProvider: ret = 1
10-04 16:55:33.901  5004  5252 I HBD     : p updated Sub Types. English 
10-04 16:55:33.902  5004 17122 I HBD     : b InputMethodSubtype is set as local:en_GB 
10-04 16:55:33.903  1427  1427 I InputMethodManagerService: subtype state: oldSubtype = android.view.inputmethod.InputMethodSubtype@10002 newSubtype = android.view.inputmethod.InputMethodSubtype@10002 force = false, intent received : false
10-04 16:55:33.903  1427  1427 I InputMethodManagerService: subtype state: oldSubtype = android.view.inputmethod.InputMethodSubtype@10002 newSubtype = android.view.inputmethod.InputMethodSubtype@10002 force = false, intent received : false
10-04 16:55:33.903  5004 17123 I HBD     : b InputMethodSubtype is set as local:en_GB 
10-04 16:55:33.923 16972 16972 D InputTransport: Input channel destroyed: 'ClientS', fd=121
10-04 16:55:33.924  1073  1370 I SurfaceFlinger: id=5555 Removed Surface(name=f319ab4 InputMethod)/@0xcb81495 - animation-leash of insets_animation#5555 (122)
10-04 16:55:33.926  1427  4443 E WindowManager: win=Window{344fe1b u0 com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity} destroySurfaces: appStopped=true cleanupOnResume=false win.mWindowRemovalAllowed=false win.mRemoveOnExit=false win.mViewVisibility=8 caller=com.android.server.wm.ActivityRecord.destroySurfaces:6952 com.android.server.wm.ActivityRecord.destroySurfaces:6933 com.android.server.wm.ActivityRecord.activityStopped:7633 com.android.server.wm.ActivityClientController.activityStopped:321 android.app.IActivityClientController$Stub.onTransact:702 com.android.server.wm.ActivityClientController.onTransact:186 android.os.Binder.execTransactInternal:1380 
10-04 16:55:33.926  1427  4443 I WindowManager: Destroying surface Surface(name=com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity$_16972)/@0xac21dd called by com.android.server.wm.WindowStateAnimator.destroySurface:799 com.android.server.wm.WindowStateAnimator.destroySurfaceLocked:472 com.android.server.wm.WindowState.destroySurfaceUnchecked:4201 com.android.server.wm.WindowState.destroySurface:4175 com.android.server.wm.ActivityRecord.destroySurfaces:6952 com.android.server.wm.ActivityRecord.destroySurfaces:6933 com.android.server.wm.ActivityRecord.activityStopped:7633 com.android.server.wm.ActivityClientController.activityStopped:321 
10-04 16:55:33.927  1427  1579 D ScreenCurtainController: onForegroundActivitiesChanged: com.sec.android.app.launcher
10-04 16:55:33.928  1427  1579 D PkgPredictorService-SecIpmManagerServiceImpl: bg information pid:16972 uid:10384 pkgName:com.companyname.mauiappwindowtest
10-04 16:55:33.929  1073  1073 I Layer   : id=5551 removeFromCurrentState com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity$_16972#5551 (122)
10-04 16:55:33.929  1073  1073 I Layer   : id=5555 Destroyed Surface(name=f319ab4 InputMethod)/@0xcb81495 - animation-leash of insets_animation#5555
10-04 16:55:33.929  1073  1073 I SurfaceFlinger: id=5551 Removed com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity$_16972#5551 (121)
10-04 16:55:33.937  1073  1073 I Layer   : id=5551 Destroyed com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity$_16972#5551
10-04 16:55:33.988  1073  1073 D SurfaceFlinger: GPIS:: requestGPISForClientComposition
10-04 16:55:34.058  1427  1870 D MdnieScenarioControlService:  packageName : com.sec.android.app.launcher    className : com.android.quickstep.RecentsActivity
10-04 16:55:34.059  1427  1870 V MdnieScenarioControlService: setUIMode from UI function(3)
10-04 16:55:34.159  1427  1870 V MdnieScenarioControlService: mAclOffEnabled : false
10-04 16:55:34.327  1427  1791 D InputReader: Btn_touch(11): value=1 when=89542.795694
10-04 16:55:34.327  1427  1791 I InputReader: Touch event's action is 0x0 (id=3, t=0) [pCnt=1, s=0.695 ] when=89542.795694
10-04 16:55:34.331  1427  1790 I InputDispatcher: Delivering touch to (2042): action: 0x4, f=0x0, d=0, 'e6bbee6', t=1 
10-04 16:55:34.331  1427  1790 I InputDispatcher: Delivering touch to (2453): action: 0x0, f=0x0, d=0, 'e458a32', t=1 
10-04 16:55:34.332  2453  2453 I ViewRootImpl@1f7ce54[RecentsActivity]: ViewPostIme pointer 0
10-04 16:55:34.333  1427  1579 I GestureDetector: obtain mCurrentDownEvent. id: 816929274 caller: com.android.server.wm.SystemGesturesPointerEventListener.onPointerEvent:204 com.android.server.wm.PointerEventDispatcher.onInputEvent:53 android.view.InputEventReceiver.dispatchInputEvent:337 
10-04 16:55:34.333  1427  1579 I GestureDetector: obtain mCurrentDownEvent. id: 816929274 caller: com.android.server.wm.SystemPerformancePointerEventListener.onPointerEvent:89 com.android.server.wm.PointerEventDispatcher.onInputEvent:53 android.view.InputEventReceiver.dispatchInputEvent:337 
10-04 16:55:34.334  2042  2042 D SearcleGestureHandler: allowGesture: false
10-04 16:55:34.351  1427  1579 I GestureDetector: obtain mCurrentMotionEventRaw. action: 2 id: 339514531
10-04 16:55:34.352  1427  1579 I GestureDetector: obtain mCurrentMotionEventRaw. action: 2 id: 339514531
10-04 16:55:34.368  1427 17128 D SemInputDeviceManager: setProperty: (0) CMD,GRIP_DATA,1,45,7,24,720,24,2400
10-04 16:55:34.369  1427 17128 D TspStateManager: wrote command: cmd=1,45,7,24,720,24,2400, type=1
10-04 16:55:34.369  1427  1800 D SemInputDevice:TSP: SetPropertyTask: CMD,set_grip_data,1,45,7,24,720,24,2400 [10-04 16:55:34.368]
10-04 16:55:34.370  1039  1039 I sysinput:Touch: writeInformation:249, OK
10-04 16:55:34.371  1427  1800 D SysinputHAL_V1_3(V1_2): runTspCmdNoRead(TSP(1)): set_grip_data,1,45,7,24,720,24,2400 ret=0
10-04 16:55:34.396  5004  5004 I InputMethodService: removeImeSurface
10-04 16:55:34.396  5004  5004 I InputMethodService: cancelImeSurfaceRemoval: removeCallbacks
10-04 16:55:34.431  2453  2453 I HoneySpace.TouchControllerImpl: Swipe started: b505933
10-04 16:55:34.431  2453  2453 I HoneySpace.TouchControllerImpl: taskSwiping = true
10-04 16:55:34.432  2453  2453 I HoneySpace.SwipeAnimator: targetIdx = 0, centerIdx = 0, posOnScreen = 1, animType = 0, scrollDir = 1, layoutType = 0, isRTL = false
10-04 16:55:34.432  2453  2453 I HoneySpace.SwipeAnimator: init() => isSwipeDown: false, isSwipeDownBlocked: false, targetView: b505933
10-04 16:55:34.434  1427  1790 D PowerManagerService: [api] userActivityFromNative : touch displayId=0 eventTime=89542902
10-04 16:55:34.456  1073  1212 I VSyncReactor: Current= 120, Period= 120, hwcPeriod= 120
10-04 16:55:34.489  1073  1073 D SurfaceFlinger: GPIS:: requestGPISForClientComposition
10-04 16:55:34.635  2273  2273 I wpa_supplicant: Heartbeat 8919
10-04 16:55:34.652  1427  7159 D VibratorManagerService: vibrate - uid: 10137, opPkg: com.sec.android.app.launcher, effect: Mono{mEffect=Composed{segments=[SemHaptic{mType=50065, mMagnitude=-1}], repeat=-1, mMagnitudeType=TYPE_TOUCH}}, attrs: VibrationAttributes: Usage=TOUCH Audio Usage= USAGE_ASSISTANCE_SONIFICATION tags= Flags=0, reason: null, token: android.os.BinderProxy@b1bbf81
10-04 16:55:34.653  1427  7159 D VibratorManagerService: converted usage = TOUCH(18)
10-04 16:55:34.653  1427  7159 D VibratorManagerService: semColorfulVibrate : EFFECT_TICK(41), repeat: -1, usage: TOUCH(18), magnitude: 4000
10-04 16:55:34.653  1427  7159 D VibratorManagerService: Starting vibrate for vibration 313
10-04 16:55:34.655  1427  1775 D SemHapticStep: sepIndex=41, intensity=4000, repeat=false, duration=210
10-04 16:55:34.655  1427  1775 D SemHapticStep: Turning on vibrator 0 for 210ms
10-04 16:55:34.655  1427  1775 D VibratorController: performHapticEngine packetCnt (1).
10-04 16:55:34.656  1044  1044 E SecVibrator-HAL-AIDL-EXT: V_3_0: performHapticEngine
10-04 16:55:34.656  1044  1044 E SecVibrator-HAL-AIDL-EXT: V_3_0: performHapticEngine amplitude : 4000
10-04 16:55:34.656  1044  1044 E SecVibrator-HAL-AIDL-EXT: V_3_0: performHapticEngine packet_cnt : 1
10-04 16:55:34.656  1044  1044 E SecVibrator-HAL-AIDL-EXT: V_3_0: performHapticEngine total_size : 4
10-04 16:55:34.656  1044  1044 E SecVibrator-HAL-AIDL-EXT: V_3_0: performHapticEngine : 4 7 2000 2050 0
10-04 16:55:34.656  1044  1044 E SecVibrator-HAL-AIDL-CORE: HW_API: do_on for timeoutMs: 1
10-04 16:55:34.656  1044  1044 E SecVibrator-HAL-AIDL-CORE: HW_API: >> writeNode node:/timed_output/vibrator/enable val:1
10-04 16:55:34.658  1044  1044 E SecVibrator-HAL-AIDL-CORE: HW_API: << writeNode node OK : 2
10-04 16:55:34.658  1044  1044 E SecVibrator-HAL-AIDL-EXT: V_3_0: performHapticEngine OK
10-04 16:55:34.700  2453  2453 I HoneySpace.WallpaperAnimator: wallpaper animation end
10-04 16:55:34.702  1427  7159 I WindowManager: Cancelling animation restarting=false, leash=Surface(name=Surface(name=RemoteWallpaperAnim:1:1)/@0x4ac17f2 - animation-leash of remote_wallpaper)/@0xdd8a883
10-04 16:55:34.702  1427  7159 I WindowManager: Reparenting to original parent: Surface(name=OneHanded:0:14)/@0x3be1e43, destroy=false, surface=Surface(name=RemoteWallpaperAnim:1:1)/@0x4ac17f2
10-04 16:55:34.702  1427  7159 D WindowManager: finishRemoteWallpaperAnimation, success=true
10-04 16:55:34.710  1427  1791 D InputReader: Btn_touch(11): value=0 when=89543.178988
10-04 16:55:34.710  1427  1791 I InputReader: Touch event's action is 0x1 (id=3, t=0) [pCnt=1, s=] when=89543.178988
10-04 16:55:34.710  1427  1790 I InputDispatcher: Delivering touch to (2453): action: 0x1, f=0x0, d=0, 'e458a32', t=1 
10-04 16:55:34.711  2453  2453 I ViewRootImpl@1f7ce54[RecentsActivity]: ViewPostIme pointer 1
10-04 16:55:34.711  2453  2453 I HoneySpace.SwipeAnimator: onDragEnd() => isSwipeDown: false, dirChanged: false, velocity: -7053.1104, threshold: 696.5, delta: -1094.0, currentProgress: 0.0
10-04 16:55:34.711  1427  1427 I SemDvfsHyPerManager: acquire hyper - GESTURE_DETECTED_HRR/1427@29, type = -999
10-04 16:55:34.711  2453  2453 I HoneySpace.SwipeAnimator: dismiss animation start
10-04 16:55:34.711  1427  1427 I SemDvfsHyPerManager: acquire hyper - SMOOTH_SCROLL/1427@23, type = -999
10-04 16:55:34.711  1427  1427 I SemDvfsHyPerManager: acquire hyper - GESTURE_DETECTED_HRR/1427@29, type = -999
10-04 16:55:34.711  2453  2562 I HoneySpace.SALoggingUtils: SA Logging screenID: 500 eventId: 5105 detail: {det=0} value: -1
10-04 16:55:34.712   994  1071 I HYPER-HAL: [RequestManager.cpp]acquire(): Acquired ID : 1060725  [1427 / 29]    HINT : GESTURE_DETECTED_HRR    list : [TIMEOUT / 1865] 
10-04 16:55:34.713   994  1071 I HYPER-HAL: [ResourceManager.cpp]updateResource(): [CPUMinFreq] UpdateResource Request ID : 1060725    Value : 1248000
10-04 16:55:34.713   994  1071 I HYPER-HAL: [RequestManager.cpp]acquire(): Acquired ID : 1051998  [1427 / 23]    HINT : SMOOTH_SCROLL    list : 
10-04 16:55:34.713   994  1071 I HYPER-HAL: [ResourceManager.cpp]updateResource(): [CPUMinFreq] UpdateResource Request ID : 1051998    Value : 1352000
10-04 16:55:34.713   994  1071 I HYPER-HAL: [ResourceManager.cpp]removeResource(): [CPUMinFreq] RemoveResource Request ID : 1051998
10-04 16:55:34.714   994  1071 I HYPER-HAL: [RequestManager.cpp]releaseLocked(): Released ID : 1051998
10-04 16:55:34.714   994  1071 I HYPER-HAL: [RequestManager.cpp]acquire(): Acquired ID : 1060725  [1427 / 29]    HINT : GESTURE_DETECTED_HRR    list : [TIMEOUT / 1865] 
10-04 16:55:34.714   994  1071 I HYPER-HAL: [ResourceManager.cpp]updateResource(): [CPUMinFreq] UpdateResource Request ID : 1060725    Value : 1248000
10-04 16:55:34.716  1073  1073 I Layer   : id=5563 removeFromCurrentState Surface(name=RemoteWallpaperAnim:1:1)/@0x4ac17f2 - animation-leash of remote_wallpaper#5563 (120)
10-04 16:55:34.716  1073  1073 I SurfaceFlinger: id=5563 Removed Surface(name=RemoteWallpaperAnim:1:1)/@0x4ac17f2 - animation-leash of remote_wallpaper#5563 (120)
10-04 16:55:34.724  1073  1073 I Layer   : id=5563 Destroyed Surface(name=RemoteWallpaperAnim:1:1)/@0x4ac17f2 - animation-leash of remote_wallpaper#5563
10-04 16:55:34.783  2453  2453 I HoneySpace.TaskListViewModel: updateRunningTaskId: -1
10-04 16:55:34.783  2453 15403 I HoneySpace.TaskListViewModel: ActivityManagerService.removeTask, taskId = 148
10-04 16:55:34.783  2453  2453 I HoneySpace.TaskListViewModel: startHome : true
10-04 16:55:34.783  2453  2453 I HoneySpace.TaskListViewModel: updateRunningTaskId: -1
10-04 16:55:34.783  2453  2453 I HoneySpace.HomescreenPot: handleTransitionState, alpha 1
10-04 16:55:34.783  2453  2453 I HoneySpace.HomescreenPot: changeState, com.honeyspace.sdk.HomeScreen$Normal@2cd2db2, cancelOpen: false reapplyState: false
10-04 16:55:34.783  2453  2453 I HoneySpace.HomescreenPot: updateChangeState? false, changedState = com.honeyspace.sdk.HomeScreen$Normal@2cd2db2
10-04 16:55:34.783  2453  2453 I HoneySpace.BackgroundManagerImpl: checkAndUpdateBackgroundEffect: com.honeyspace.sdk.HomeScreen$Normal@2cd2db2, ch=194873307, forceApply=false
10-04 16:55:34.784  2453  2453 I HoneySpace.RecentscreenPot: startHome
10-04 16:55:34.787  1427  1581 I ActivityManager: Killing 16972:com.companyname.mauiappwindowtest/u0a384 (adj 900): remove task
10-04 16:55:34.787  1427  1581 D ActivityManager: [SD] user menu kill listen remove action name:com.companyname.mauiappwindowtest uid:10384
10-04 16:55:34.788  2453 12445 I HoneySpace.RecentTasks: onRecentTasksChanged
10-04 16:55:34.789  1427  7972 D ActivityTaskManager: startActivityAsUser: callingPid=2453, callingUid=10137, caller=com.android.server.wm.ActivityTaskManagerService.startActivityAsUser:1844 com.android.server.wm.ActivityTaskManagerService.startActivity:1818 android.app.IActivityTaskManager$Stub.onTransact:1353 com.android.server.wm.ActivityTaskManagerService.onTransact:6972 android.os.Binder.execTransactInternal:1375 android.os.Binder.execTransact:1311 <bottom of call stack> 
10-04 16:55:34.789  1427  1581 I ChimeraSystemEventListener: Not an effective intent: Intent { act=android.intent.action.MAIN cat=[android.intent.category.HOME] flg=0x10000000 (has extras) }
10-04 16:55:34.790  1427  3950 E TaskPersister: File error accessing recents directory (directory doesn't exist?).
10-04 16:55:34.792  1427  7972 D WindowManager: Transition is created, t=TransitionRecord{c4480b2 id=-1 type=OPEN flags=0x0}, caller=com.android.server.wm.TransitionController.createAndStartCollecting:1765 com.android.server.wm.ActivityStarter.startActivityUnchecked:2360 com.android.server.wm.ActivityStarter.executeRequest:1953 com.android.server.wm.ActivityStarter.execute:1093 com.android.server.wm.ActivityTaskManagerService.startActivityAsUser:1985 
10-04 16:55:34.792  1427  7972 D WindowManager: SyncGroup is created, id=429, name=Transition, caller=com.android.server.wm.BLASTSyncEngine$SyncGroup.<init>:0 com.android.server.wm.BLASTSyncEngine.prepareSyncSet:513 com.android.server.wm.BLASTSyncEngine.startSyncSet:518 com.android.server.wm.Transition.startCollecting:710 com.android.server.wm.TransitionController.moveToCollecting:360 com.android.server.wm.TransitionController.createAndStartCollecting:1766 com.android.server.wm.ActivityStarter.startActivityUnchecked:2360 
10-04 16:55:34.792  1427  7972 W WindowManager: setSyncMethod, id=429, method=0, caller=com.android.server.wm.Transition.startCollecting:712 com.android.server.wm.TransitionController.moveToCollecting:360 com.android.server.wm.TransitionController.createAndStartCollecting:1766 
10-04 16:55:34.792  1427  7972 V WindowManager: Start collecting in Transition: TransitionRecord{c4480b2 id=429 type=OPEN flags=0x0}, caller=com.android.server.wm.TransitionController.createAndStartCollecting:1766 com.android.server.wm.ActivityStarter.startActivityUnchecked:2360 com.android.server.wm.ActivityStarter.executeRequest:1953 com.android.server.wm.ActivityStarter.execute:1093 com.android.server.wm.ActivityTaskManagerService.startActivityAsUser:1985 
10-04 16:55:34.792  1427  7972 V WindowManager: Collecting in transition 429: ActivityRecord{40d3803 u0 com.sec.android.app.launcher/.activities.LauncherActivity, caller=com.android.server.wm.Transition.collect:759 com.android.server.wm.TransitionController.collect:935 com.android.server.wm.ActivityStarter.startActivityUnchecked:2376 com.android.server.wm.ActivityStarter.executeRequest:1953 com.android.server.wm.ActivityStarter.execute:1093 
10-04 16:55:34.792  1427  7972 D ActivityTaskManager: TaskLaunchParamsModifier:task=null activity=ActivityRecord{40d3803 u0 com.sec.android.app.launcher/.activities.LauncherActivity t-1} display-from-option=0 display-id=0 task-display-area-windowing-mode=1 suggested-display-area=DefaultTaskDisplayArea_d0@36679575
10-04 16:55:34.792  1427  7972 D ActivityTaskManager: TaskLaunchParamsModifier:task=Task{38abbdb #6 type=home I=com.sec.android.app.launcher/.activities.LauncherActivity} activity=ActivityRecord{40d3803 u0 com.sec.android.app.launcher/.activities.LauncherActivity t-1} display-from-option=0 display-id=0 task-display-area-windowing-mode=1 suggested-display-area=DefaultTaskDisplayArea_d0@36679575 inherit-from-task=fullscreen non-freeform-task-display-area display-area=DefaultTaskDisplayArea_d0@36679575 default-portrait freeform-size-mismatch=Rect(81, 568 - 999, 1768)
10-04 16:55:34.793  1427  7972 I SemDvfsHyPerManager: acquire hyper - AMS_APP_HOME/1427@31, type = -999
10-04 16:55:34.793  3946  3946 I SemDvfsHyPerManager: acquire hyper - APP_START_HOME/3946@15, type = -999
10-04 16:55:34.793   994  1071 I HYPER-HAL: [RequestManager.cpp]acquire(): Acquired ID : 1063642  [1427 / 31]    HINT : AMS_APP_HOME    list : 
10-04 16:55:34.794  1427  7972 D ActivityManagerPerformance: AMP_acquire() HOME
10-04 16:55:34.794  1427  7972 D ActivityTaskManager: scheduleTopResumedActivityChanged, onTop=false, r=ActivityRecord{38c4e65 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity t7}, caller=com.android.server.wm.ActivityTaskSupervisor.updateTopResumedActivityIfNeeded:2826 com.android.server.wm.TaskDisplayArea.positionChildTaskAt:567 com.android.server.wm.TaskDisplayArea.positionChildAt:483 com.android.server.wm.WindowContainer.positionChildAt:989 com.android.server.wm.Task.positionChildAt:3318 com.android.server.wm.Task.moveToFront:6077 
10-04 16:55:34.795  1427  7972 D SGM:FgCheckThread: TaskStackListener.onTaskFocusChanged(), taskId=7, focused=false
10-04 16:55:34.795  1427  7972 D SGM:FgCheckThread: TaskStackListener.onTaskFocusChanged(), taskId=6, focused=true
10-04 16:55:34.795  1427  7972 D SGM:FgCheckThread:   sendRunningComponentFocus(), pkgName: com.sec.android.app.launcher, userId: 0
10-04 16:55:34.795  1427  7972 D InputDispatcher: Focused application(0): ActivityRecord{bc89e32 u0 com.sec.android.app.launcher/.activities.LauncherActivity t6}
10-04 16:55:34.795  1427  1807 D SGM:FgCheckThread: onLooperPrepared(), msg: MSG_TASK_FOCUSED, pkgName: com.sec.android.app.launcher, userId: 0
10-04 16:55:34.795  1427  1807 D SGM:FgCheckThread: handleTaskFocused().
10-04 16:55:34.795  1427  1807 D SGM:FgCheckThread:   handleTaskFocused(), pkgName: com.sec.android.app.launcher, userID:0
10-04 16:55:34.795  1427  1807 D SGM:FgCheckThread: handleResume().
10-04 16:55:34.795  1427  1807 D SGM:FgCheckThread: sendFocusOutConditionally() - mPrevNotiPkg: (unknown), userId: 0
10-04 16:55:34.795  1427  1807 D SGM:FgCheckThread:   handleResume(). pkgName: com.sec.android.app.launcher, userId: 0, isTunableApp: null
10-04 16:55:34.795  1427  1807 D SGM:FgCheckThread: notifyFocusInOut(). of pkg: com.sec.android.app.launcher, type: 4, isTunableApp: false, userId: 0
10-04 16:55:34.796  1427  1807 D SGM:FgCheckThread:   notifyFocusInOut(). unexpected mPrevNotiType: -1
10-04 16:55:34.796  1427  1807 D SGM:SystemHelper: callReleaseBlock needReleaseBlock:false
10-04 16:55:34.796  1427  7972 V WindowManager: Changing focus from Window{e458a32 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity} to null displayId=0 Callers=com.android.server.wm.RootWindowContainer.updateFocusedWindowLocked:578 com.android.server.wm.WindowManagerService.updateFocusedWindowLocked:6881 com.android.server.wm.ActivityTaskManagerService.setLastResumedActivityUncheckLocked:6118 com.android.server.wm.ActivityRecord.moveFocusableActivityToTop:4115 
10-04 16:55:34.796  1427  1878 D AS.MultiSoundManager: mForegroundUid = 10137
10-04 16:55:34.796  1427  7972 D SGM:FgCheckThread: TaskStackListener.onTaskFocusChanged(), taskId=7, focused=false
10-04 16:55:34.796  1427  7972 D SGM:FgCheckThread: TaskStackListener.onTaskFocusChanged(), taskId=6, focused=true
10-04 16:55:34.796  1427  7972 D SGM:FgCheckThread:   sendRunningComponentFocus(), pkgName: com.sec.android.app.launcher, userId: 0
10-04 16:55:34.797  1427  7972 V WindowManager: Checking theme of starting window: 0x7f1403ac
10-04 16:55:34.797  1427  7972 V WindowManager: Translucent=false Floating=false ShowWallpaper=true Disable=false
10-04 16:55:34.798  1427  1878 D AS.MultiSoundManager: mForegroundUid = 10137
10-04 16:55:34.798  1427  7972 V WindowManager: Collecting in transition 429: ActivityRecord{38c4e65 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity t7}, caller=com.android.server.wm.Transition.collect:759 com.android.server.wm.TransitionController.collect:935 com.android.server.wm.ActivityRecord.setVisibility:6348 com.android.server.wm.ActivityRecord.setVisibility:6300 com.android.server.wm.ActivityRecord.makeInvisible:7137 
10-04 16:55:34.798  1427  7972 D WindowManager: prepareSync <SYNC_STATE_WAITING_FOR_DRAW>, mPrepareSyncSeqId=0, win=Window{e458a32 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity}
10-04 16:55:34.798  1427  7972 V WindowManager: Collecting in transition 429: WallpaperWindowToken{1f6c5ec token=android.os.Binder@a0f609f}, caller=com.android.server.wm.Transition.collect:759 com.android.server.wm.Transition.collect:847 com.android.server.wm.Transition.collect:759 com.android.server.wm.TransitionController.collect:935 com.android.server.wm.ActivityRecord.setVisibility:6348 
10-04 16:55:34.799   994  1071 I HYPER-HAL: [ResourceManager.cpp]updateResource(): [CPUMinFreq] UpdateResource Request ID : 1063642    Value : 2912000
10-04 16:55:34.799  1427  7972 D WindowManager: VisibleRequested updated, r=ActivityRecord{38c4e65 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity t7}
10-04 16:55:34.799  1427  7972 V WindowManager: Collecting in transition 429: ActivityRecord{bc89e32 u0 com.sec.android.app.launcher/.activities.LauncherActivity t6}, caller=com.android.server.wm.Transition.collect:759 com.android.server.wm.TransitionController.collect:935 com.android.server.wm.ActivityRecord.setVisibility:6348 com.android.server.wm.ActivityRecord.setVisibility:6300 com.android.server.wm.TaskFragment.resumeTopActivity:1731 
10-04 16:55:34.799  1427  7972 D WindowManager: prepareSync <SYNC_STATE_WAITING_FOR_DRAW>, mPrepareSyncSeqId=0, win=Window{ee28167 u0 (1-1)-Window{99bf2c6 alpha=1.0 fl=}}
10-04 16:55:34.799  1427  7972 D WindowManager: prepareSync <SYNC_STATE_WAITING_FOR_DRAW>, mPrepareSyncSeqId=0, win=Window{fbdaee8 u0 com.sec.android.app.launcher/com.sec.android.app.launcher.activities.LauncherActivity}
10-04 16:55:34.799  1427  1807 D SGM:FgCheckThread: onLooperPrepared(), msg: MSG_TASK_FOCUSED, pkgName: com.sec.android.app.launcher, userId: 0
10-04 16:55:34.799  1427  1807 D SGM:FgCheckThread: handleTaskFocused().
10-04 16:55:34.800  1427  1807 D SGM:FgCheckThread:   handleTaskFocused(), pkgName: com.sec.android.app.launcher, userID:0
10-04 16:55:34.800  1427  1807 D SGM:FgCheckThread: handleResume().
10-04 16:55:34.800  1427  1807 D SGM:FgCheckThread: sendFocusOutConditionally() - mPrevNotiPkg: (unknown), userId: 0
10-04 16:55:34.800  1427  1807 D SGM:FgCheckThread:   handleResume(). pkgName: com.sec.android.app.launcher, userId: 0, isTunableApp: null
10-04 16:55:34.800  1427  1807 D SGM:FgCheckThread: notifyFocusInOut(). of pkg: com.sec.android.app.launcher, type: 4, isTunableApp: false, userId: 0
10-04 16:55:34.800  1427  1807 D SGM:FgCheckThread:   notifyFocusInOut(). unexpected mPrevNotiType: -1
10-04 16:55:34.800  1427  1807 D SGM:SystemHelper: callReleaseBlock needReleaseBlock:false
10-04 16:55:34.800  1427  7972 V WindowManager: Setting visibility of Window{ee28167 u0 (1-1)-Window{99bf2c6 alpha=1.0 fl=}}: true, caller=com.android.server.wm.WindowContainer.sendAppVisibilityToClients:1301 com.android.server.wm.WindowToken.setClientVisible:446 com.android.server.wm.ActivityRecord.setClientVisible:8121 com.android.server.wm.ActivityRecord.setVisibility:6451 com.android.server.wm.ActivityRecord.setVisibility:6300 
10-04 16:55:34.800  1427  7972 V WindowManager: Setting visibility of Window{fbdaee8 u0 com.sec.android.app.launcher/com.sec.android.app.launcher.activities.LauncherActivity}: true, caller=com.android.server.wm.WindowContainer.sendAppVisibilityToClients:1301 com.android.server.wm.WindowToken.setClientVisible:446 com.android.server.wm.ActivityRecord.setClientVisible:8121 com.android.server.wm.ActivityRecord.setVisibility:6451 com.android.server.wm.ActivityRecord.setVisibility:6300 
10-04 16:55:34.800  7973  7973 I ViewRootImpl@12a5813[0 fl=}]: handleAppVisibility mAppVisible = false visible = true
10-04 16:55:34.800  1427  7972 V WindowManager: rotationForOrientation(orient=SCREEN_ORIENTATION_NOSENSOR (5), last=ROTATION_0 (0)); user=ROTATION_0 (0) 
10-04 16:55:34.801  1427  7972 D WindowManager: rotationForOrientation, orientationSource=ActivityRecord{bc89e32 u0 com.sec.android.app.launcher/.activities.LauncherActivity t6}
10-04 16:55:34.801  1427  7972 V WindowManager: Computed rotation=ROTATION_0 (0) for display id=0 based on lastOrientation=SCREEN_ORIENTATION_NOSENSOR (5) and oldRotation=ROTATION_0 (0), caller=com.android.server.wm.DisplayRotation.updateOrientation:517 com.android.server.wm.DisplayContent.updateOrientation:2176 com.android.server.wm.DisplayContent.updateOrientation:2092 com.android.server.wm.RootWindowContainer.ensureVisibilityAndConfig:2091 com.android.server.wm.TaskFragment.resumeTopActivity:1769 com.android.server.wm.TaskFragment.resumeTopActivity:1386 
10-04 16:55:34.801  1427  7972 V WindowManager: Collecting in transition 429: ActivityRecord{bc89e32 u0 com.sec.android.app.launcher/.activities.LauncherActivity t6}, caller=com.android.server.wm.Transition.collect:759 com.android.server.wm.TransitionController.collect:935 com.android.server.wm.ActivityRecord.setVisibility:6348 com.android.server.wm.ActivityRecord.setVisibility:6300 com.android.server.wm.ActivityRecord.completeResumeLocked:7395 
10-04 16:55:34.802  1427  7972 V WindowManager: Collecting in transition 429: ActivityRecord{40d3803 u0 com.sec.android.app.launcher/.activities.LauncherActivity t-1}, caller=com.android.server.wm.Transition.collect:759 com.android.server.wm.Transition.collectExistenceChange:942 com.android.server.wm.TransitionController.collectExistenceChange:985 com.android.server.wm.ActivityStarter.handleStartResult:2557 com.android.server.wm.ActivityStarter.startActivityUnchecked:2384 
10-04 16:55:34.802  1427  7972 V WindowManager: Requesting StartTransition: TransitionRecord{c4480b2 id=429 type=OPEN flags=0x0}, caller=com.android.server.wm.ActivityStarter.handleStartResult:2591 com.android.server.wm.ActivityStarter.startActivityUnchecked:2384 com.android.server.wm.ActivityStarter.executeRequest:1953 com.android.server.wm.ActivityStarter.execute:1093 com.android.server.wm.ActivityTaskManagerService.startActivityAsUser:1985 
10-04 16:55:34.802  1427  7972 D FreeformController: beginPostLayoutPolicyLw: forceHideRequester changed, old=Window{e458a32 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity}, new=null
10-04 16:55:34.802  1427  7972 D FreeformController: setBlockToAddForceHideFreeformTasks: blockToAddForceHide=false, Caller=com.android.server.wm.FreeformController.beginPostLayoutPolicyLw:839
10-04 16:55:34.803  2042  2164 V WindowManagerShell: Transition requested: android.os.BinderProxy@b60ee74 TransitionRequestInfo { type = OPEN, triggerTask = TaskInfo{userId=0 taskId=6 displayId=0 isRunning=true baseIntent=Intent { act=android.intent.action.MAIN cat=[android.intent.category.HOME] flg=0x10000100 cmp=com.sec.android.app.launcher/.activities.LauncherActivity } baseActivity=ComponentInfo{com.sec.android.app.launcher/com.sec.android.app.launcher.Launcher} topActivity=ComponentInfo{com.sec.android.app.launcher/com.sec.android.app.launcher.Launcher} origActivity=ComponentInfo{com.sec.android.app.launcher/com.sec.android.app.launcher.activities.LauncherActivity} realActivity=ComponentInfo{com.sec.android.app.launcher/com.sec.android.app.launcher.Launcher} numActivities=1 lastActiveTime=156088659 supportsMultiWindow=true resizeMode=2 isResizeable=true minWidth=-1 minHeight=-1 maxWidth=-1 maxHeight=-1 defaultMinSize=220 token=WCT{android.window.IWindowContainerToken$Stub$Proxy@2a50f9d} topActivityType=2 pictureInPictureParams=null shouldDockBigOverlays=false launchIntoPipHostTaskId=-1 lastParentTaskIdBeforePip=-1 displayCutoutSafeInsets=null topActivityInfo=ActivityInfo{b77ac12 com.sec.android.app.launcher.activities.LauncherActivity} launchCookies=[android.os.BinderProxy@4defe3] positionInParent=Point(0, 0) parentTaskId=-1 isFocused=true isVisible=false isVisibleRequested=true isSleeping=false topActivityInSizeCompat=false topActivityEligibleForLetterboxEducation= false topActivityLetterboxed= false isFromDoubleTap= false topActivityLetterboxVerticalPosition= -1 topActivityLetterboxHorizontalPosition= -1 topActivityLetterboxWidth=-1 topActivityLetterboxHeight=-1 locusId=null displayAreaFeatureId=1 cameraCompatControlState=hidden originallySupportedMultiWindow=true hasWallpaper=false topActivityInFixedAspectRatio=false rootAffinity=null topActivityInDisplayCompat=false topActivityInBoundsCompat=false topActivityBounds=null singleTapFromLetterbox=false isTopTaskInStage=false topActivityUiMode=17 CoverLauncherWidgetTask=false CoverScreenTask=false isAllowedSeamlessRotation=false isTopTransparentActivity=true hasPopOver=false}, remoteTransition = RemoteTransition { remoteTransition = android.window.IRemoteTransition$Stub$Proxy@cd87de0, appThread = android.app.IApplicationThread$Stub$Proxy@9c80899, debugName = QuickstepLaunch }, displayChange = null }
10-04 16:55:34.804  1427  7159 D KNOX_MDM_SettingsProvider: isChangeAllowed() : name = desktop_mode
10-04 16:55:34.804  1427  7159 D KNOX_MDM_SettingsProvider: edmUri: content://com.sec.knox.provider/RestrictionPolicy3
10-04 16:55:34.804  1427  7159 D KNOX_MDM_SettingsProvider: projectionArgs: isSettingsChangesAllowed
10-04 16:55:34.804  1427  7159 D KNOX_MDM_SettingsProvider: selectionArgs: false
10-04 16:55:34.804  1427  7159 D KNOX_MDM_SettingsProvider: selectionArgs: 10043
10-04 16:55:34.804  1427  7159 D SecContentProvider: query(), uri = 17 selection = isSettingsChangesAllowed
10-04 16:55:34.804  1427  7159 D SecContentProvider: called from android.uid.systemui:10043
10-04 16:55:34.804  1427  7159 D RestrictionPolicy: isSettingsChangesAllowedAsUser, userId 0 : true
10-04 16:55:34.804  1427  7159 D KNOX_MDM_SettingsProvider: ret = 1
10-04 16:55:34.804  1427  7972 I ActivityTaskManager: START u0 {act=android.intent.action.MAIN cat=[android.intent.category.HOME] flg=0x10000000 cmp=com.sec.android.app.launcher/.activities.LauncherActivity (has extras)} with LAUNCH_SINGLE_TASK from uid 10137 (BAL_ALLOW_ALLOWLISTED_COMPONENT) result code=2
10-04 16:55:34.804  2042  2164 V WindowManagerShell: RemoteTransition directly requested for android.os.BinderProxy@b60ee74: RemoteTransition { remoteTransition = android.window.IRemoteTransition$Stub$Proxy@cd87de0, appThread = android.app.IApplicationThread$Stub$Proxy@9c80899, debugName = QuickstepLaunch }
10-04 16:55:34.804  1427  7972 I Pageboost: stop alp
10-04 16:55:34.804  1427  1590 I libprocessgroup: Successfully killed process cgroup uid 10384 pid 16972 in 16ms
10-04 16:55:34.805  2453  2453 I HoneySpace.SuggestedAppsPot: startAnimation show: false, startDelay: false
10-04 16:55:34.805  2453  2453 I HoneySpace.ShellTransitionManager: open start
10-04 16:55:34.805  1427  1581 D SGM:FgCheckThread: notePauseComponent(), received pkgName: com.sec.android.app.launcher, userId: 0
10-04 16:55:34.805  2453  2453 I HoneySpace.SwipeAnimator: resetViewAndValues
10-04 16:55:34.806  2453  2453 I HoneySpace.SwipeAnimator: clickBlocked = false
10-04 16:55:34.806  3227  3227 E pageboostd: Received HALT command code 2
10-04 16:55:34.806  2453  2453 I BLASTBufferQueue_Java: update, w= 1080 h= 2400 mName = ViewRootImpl@1f7ce54[RecentsActivity] mNativeObject= 0xb4000078cd442350 sc.mNativeObject= 0xb400007a2d415510 format= -2 caller= android.view.ViewRootImpl.updateBlastSurfaceIfNeeded:3017 android.view.ViewRootImpl.relayoutWindow:10131 android.view.ViewRootImpl.performTraversals:4110 android.view.ViewRootImpl.doTraversal:3288 android.view.ViewRootImpl$TraversalRunnable.run:11344 android.view.Choreographer$CallbackRecord.run:1689 
10-04 16:55:34.806  1427  1902 I CocktailBarManagerServiceContainer: handleMessage: entry what = 6
10-04 16:55:34.806  2453  2453 I ViewRootImpl@1f7ce54[RecentsActivity]: Relayout returned: old=(0,0,1080,2400) new=(0,0,1080,2400) relayoutAsync=true req=(1080,2400)0 dur=0 res=0x0 s={true 0xb40000781d541460} ch=false seqId=0
10-04 16:55:34.806  2453  2453 I ViewRootImpl@1f7ce54[RecentsActivity]: registerCallbackForPendingTransactions
10-04 16:55:34.807  2453  4617 I ViewRootImpl@1f7ce54[RecentsActivity]: mWNT: t=0xb40000786d49b410 mBlastBufferQueue=0xb4000078cd442350 fn= 96 mRenderHdrSdrRatio=1.0 caller= android.view.ViewRootImpl$6.onFrameDraw:5635 android.view.ViewRootImpl$2.onFrameDraw:2146 android.view.ThreadedRenderer$1.onFrameDraw:792 
10-04 16:55:34.807   994  1071 I HYPER-HAL: [RequestManager.cpp]acquire(): Acquired ID : 7846756  [3946 / 15]    HINT : APP_START    list : [KERNEL_APP_START_NOTIFY / 0] [TIMEOUT / 1500] 
10-04 16:55:34.807   994  1071 I HYPER-HAL: [ResourceManager.cpp]updateResource(): [CPUMaxFreq] UpdateResource Request ID : 7846756    Value : 2912000
10-04 16:55:34.808  1427  2275 D InputDispatcher: Focus request (0): <null> but waiting because NO_WINDOW
10-04 16:55:34.808  1427  2275 D InputDispatcher: Focus left window (0): e458a32 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity
10-04 16:55:34.808  1427  7972 V WindowManager: Relayout Window{e458a32 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity}: viewVisibility=0 req=1080x2400 ty=1 d0
10-04 16:55:34.810  1427  4443 D ActivityTaskManager: scheduleTopResumedActivityChanged, onTop=true, r=ActivityRecord{bc89e32 u0 com.sec.android.app.launcher/.activities.LauncherActivity t6}, caller=com.android.server.wm.ActivityTaskSupervisor.scheduleTopResumedActivityStateIfNeeded:2857 com.android.server.wm.ActivityTaskSupervisor.handleTopResumedStateReleased:2886 com.android.server.wm.ActivityClientController.activityTopResumedStateLost:272 android.app.IActivityClientController$Stub.onTransact:678 com.android.server.wm.ActivityClientController.onTransact:186 android.os.Binder.execTransactInternal:1375 
10-04 16:55:34.810  1427  7159 V WindowManager: Starting Transition 429, caller=com.android.server.wm.WindowOrganizerController.startTransition:382 com.android.server.wm.WindowOrganizerController.startTransition:313 android.window.IWindowOrganizerController$Stub.onTransact:257 
10-04 16:55:34.810  1427  7159 V Transition:  allReady query: used=true, override=false, defer=0, states=Display{#0 state=ON size=1080x2400 ROTATION_0}:true
10-04 16:55:34.810  2453  2453 I HoneySpace.TaskListPot: onPause() called
10-04 16:55:34.810  2453  2453 I HoneySpace.RecentscreenPot: onPause() called
10-04 16:55:34.810  2453  2453 I HoneySpace.RecentsActivity: !@Boot_EBS_D: RecentsActivity.onPause()
10-04 16:55:34.810  2453  2586 I HoneySpace.TopTaskSource: update by recents showing
10-04 16:55:34.810  1427  9415 V WindowManager: Relayout Window{ee28167 u0 (1-1)-Window{99bf2c6 alpha=1.0 fl=}}: viewVisibility=0 req=1080x2400 ty=4 d0
10-04 16:55:34.810  2453  2453 I ViewRootImpl@93f9b16[LauncherActivity]: stopped(false) old = true
10-04 16:55:34.810  1427  9415 D RestrictionPolicy: isScreenCaptureEnabled : ret=true userId=0
10-04 16:55:34.810  1427  7972 V WindowManager: Relayout hash=e458a32, pid=0, syncId=-1: mAttrs={(0,0)(fillxfill) sim={adjust=resize} layoutInDisplayCutoutMode=shortEdges ty=BASE_APPLICATION fmt=TRANSPARENT wanim=0x10302f2
10-04 16:55:34.810  1427  7972 V WindowManager:   fl=81910100
10-04 16:55:34.810  1427  7972 V WindowManager:   pfl=12008040
10-04 16:55:34.810  1427  7972 V WindowManager:   bhv=DEFAULT
10-04 16:55:34.810  1427  7972 V WindowManager:   fitSides= naviIconColor=0}
10-04 16:55:34.810  2453  2453 I HoneySpace.Launcher: !@Boot_EBS_D: Launcher.onStart()
10-04 16:55:34.810  1073  1124 I SurfaceFlinger: id=5566 createSurf, flag=44004, (1-1)-Window{99bf2c6 alpha=1.0 fl=}$_7973#5566
10-04 16:55:34.811  2453  2453 I HoneySpace.OneUiSpace: onNewIntent() intent: Intent { act=android.intent.action.MAIN cat=[android.intent.category.HOME] flg=0x10400000 cmp=com.sec.android.app.launcher/.activities.LauncherActivity (has extras) }
10-04 16:55:34.811  2453  2453 I HoneySpace.OneUiSpace: isLaunchAllAppsAction() action: null, isHomeOnly: false, currentHoneyScreen: HOME
10-04 16:55:34.811  2453  2453 I HoneySpace.Launcher: !@Boot_EBS_D: Launcher.onResume()
10-04 16:55:34.811  1427  9415 D WindowManager: makeSurface duration=1 name=(1-1)-Window{99bf2c6 alpha=1.0 fl=}$_7973
10-04 16:55:34.811  2453  2453 I HoneySpace.Launcher: updateLauncherShowing false -> true
10-04 16:55:34.811  2453 15403 I HoneySpace.PredictionDataSourceImpl: requestPredictionUpdate 0 true
10-04 16:55:34.811  2453  2453 I HoneySpace.ScreenOffTimeout: RETURN setScreenOffDimDuration - com.android.internal.policy.PhoneWindow@fd9c278, {(0,0)(fillxfill) sim={adjust=nothing} layoutInDisplayCutoutMode=shortEdges ty=BASE_APPLICATION fmt=TRANSPARENT wanim=0x10302f2
10-04 16:55:34.811  2453  2453 I HoneySpace.ScreenOffTimeout:   fl=81910100
10-04 16:55:34.811  2453  2453 I HoneySpace.ScreenOffTimeout:   pfl=10008040
10-04 16:55:34.811  2453  2453 I HoneySpace.ScreenOffTimeout:   bhv=DEFAULT
10-04 16:55:34.811  2453  2453 I HoneySpace.ScreenOffTimeout:   fitSides= screenDimDuration=200000 naviIconColor=0}, 200000
10-04 16:55:34.811  2453  2453 I HoneySpace.ShellTransitionManager: myHomeResumed
10-04 16:55:34.811  2453 15403 I HoneySpace.PredictionDataSourceImpl: requestPredictionUpdate 1 true
10-04 16:55:34.811  1427  7972 I AppWidgetServiceImpl: startListening callbacks : com.android.internal.appwidget.IAppWidgetHost$Stub$Proxy@603f380
10-04 16:55:34.811  1427  9415 D WindowManager: SyncGroup 429:  Unfinished container: ActivityRecord{bc89e32 u0 com.sec.android.app.launcher/.activities.LauncherActivity t6} mSyncState=2
10-04 16:55:34.812  2453  2453 I SearchHoneyPot: onViewCreated: onResume
10-04 16:55:34.812  2453 15403 I HoneySpace.SPayHandler: currentIndex : 0, defaultIndex : 0
10-04 16:55:34.812  2453  2453 I ViewRootImpl@93f9b16[LauncherActivity]: handleAppVisibility mAppVisible = false visible = true
10-04 16:55:34.812  2453  2453 I HoneySpace.ListSnapScrollHelper: return false : childCount 0
10-04 16:55:34.812  2453 15403 I HoneySpace.SPayHandler: updateSpayHandler, show = true, defaultPage = true
10-04 16:55:34.813  1427  9415 V WindowManager: Relayout hash=ee28167, pid=7973, syncId=-1: mAttrs={(0,0)(fillxfill) gr=LEFT CENTER_HORIZONTAL sim={adjust=resize} layoutInDisplayCutoutMode=always ty=DRAWN_APPLICATION fmt=TRANSPARENT wanim=0x10302f2 alpha=0.0
10-04 16:55:34.813  1427  9415 V WindowManager:   fl=81850118
10-04 16:55:34.813  1427  9415 V WindowManager:   pfl=16008040
10-04 16:55:34.813  1427  9415 V WindowManager:   vsysui=2010
10-04 16:55:34.813  1427  9415 V WindowManager:   bhv=DEFAULT
10-04 16:55:34.813  1427  9415 V WindowManager:   fitSides=
10-04 16:55:34.813  1427  9415 V WindowManager:  dimAmount=0.0 screenDimDuration=200000 naviIconColor=0}
10-04 16:55:34.813  1427  1582 D WindowManager: SyncGroup 429:  Unfinished container: ActivityRecord{bc89e32 u0 com.sec.android.app.launcher/.activities.LauncherActivity t6} mSyncState=2
10-04 16:55:34.813  1427  4443 V WindowManager: Relayout Window{fbdaee8 u0 com.sec.android.app.launcher/com.sec.android.app.launcher.activities.LauncherActivity}: viewVisibility=0 req=1080x2400 ty=1 d0
10-04 16:55:34.813  1427  1902 I CocktailBarManagerServiceContainer: handleMessage: entry what = 5
10-04 16:55:34.813  1427  4443 D RestrictionPolicy: isScreenCaptureEnabled : ret=true userId=0
10-04 16:55:34.814  1073  1370 I SurfaceFlinger: id=5567 createSurf, flag=44004, com.sec.android.app.launcher/com.sec.android.app.launcher.activities.LauncherActivity$_2453#5567
10-04 16:55:34.814  7973  7973 I BLASTBufferQueue_Java: new BLASTBufferQueue, mName= ViewRootImpl@12a5813[0 fl=}] mNativeObject= 0xb4000078cd436190 sc.mNativeObject= 0xb400007a2d402910 caller= android.view.ViewRootImpl.updateBlastSurfaceIfNeeded:3028 android.view.ViewRootImpl.relayoutWindow:10131 android.view.ViewRootImpl.performTraversals:4110 android.view.ViewRootImpl.doTraversal:3288 android.view.ViewRootImpl$TraversalRunnable.run:11344 android.view.Choreographer$CallbackRecord.run:1689 android.view.Choreographer$CallbackRecord.run:1698 android.view.Choreographer.doCallbacks:1153 android.view.Choreographer.doFrame:1079 android.view.Choreographer$FrameDisplayEventReceiver.run:1646 
10-04 16:55:34.814  1427  4443 D WindowManager: makeSurface duration=1 name=com.sec.android.app.launcher/com.sec.android.app.launcher.activities.LauncherActivity$_2453
10-04 16:55:34.814  7973  7973 I BLASTBufferQueue_Java: update, w= 1080 h= 2400 mName = ViewRootImpl@12a5813[0 fl=}] mNativeObject= 0xb4000078cd436190 sc.mNativeObject= 0xb400007a2d402910 format= -2 caller= android.graphics.BLASTBufferQueue.<init>:89 android.view.ViewRootImpl.updateBlastSurfaceIfNeeded:3028 android.view.ViewRootImpl.relayoutWindow:10131 android.view.ViewRootImpl.performTraversals:4110 android.view.ViewRootImpl.doTraversal:3288 android.view.ViewRootImpl$TraversalRunnable.run:11344 
10-04 16:55:34.815  7973  7973 I ViewRootImpl@12a5813[0 fl=}]: Relayout returned: old=(0,0,1080,2400) new=(0,0,1080,2400) relayoutAsync=false req=(1080,2400)0 dur=6 res=0x403 s={true 0xb40000781d430c60} ch=true seqId=0
10-04 16:55:34.815  1427  4443 D WindowManager: SyncGroup 429:  Unfinished container: ActivityRecord{bc89e32 u0 com.sec.android.app.launcher/.activities.LauncherActivity t6} mSyncState=2
10-04 16:55:34.815  7973  7973 D ViewRootImpl@12a5813[0 fl=}]: mThreadedRenderer.initialize() mSurface={isValid=true 0xb40000781d430c60} hwInitialized=true
10-04 16:55:34.815  1427  4443 V WindowManager: Changing focus from null to Window{fbdaee8 u0 com.sec.android.app.launcher/com.sec.android.app.launcher.activities.LauncherActivity} displayId=0 Callers=com.android.server.wm.RootWindowContainer.updateFocusedWindowLocked:578 com.android.server.wm.WindowManagerService.updateFocusedWindowLocked:6881 com.android.server.wm.WindowManagerService.relayoutWindow:2755 com.android.server.wm.Session.relayout:282 
10-04 16:55:34.815  1427  4443 I WindowManager: Cancelling animation restarting=true, leash=Surface(name=Surface(name=3d202b3 StatusBar)/@0x8456cea - animation-leash of insets_animation)/@0xf9ec894
10-04 16:55:34.815  1427  1581 D SGM:FgCheckThread: noteResumeComponent(), received pkgName: com.sec.android.app.launcher, userId: 0
10-04 16:55:34.815  1427  1807 D SGM:FgCheckThread: onLooperPrepared(), msg: MSG_APP_RESUME, pkgName: com.sec.android.app.launcher, userid: 0
10-04 16:55:34.815  1427  1807 D SGM:FgCheckThread: handleResume().
10-04 16:55:34.815  1427  4443 I WindowManager: Reparenting to original parent: Surface(name=WindowToken{4280822 type=2000 android.os.BinderProxy@5344804})/@0x3badbdb, destroy=false, surface=Surface(name=3d202b3 StatusBar)/@0x8456cea
10-04 16:55:34.815  1427  1807 D SGM:FgCheckThread: sendFocusOutConditionally() - mPrevNotiPkg: (unknown), userId: 0
10-04 16:55:34.815  1427  1807 D SGM:FgCheckThread:   handleResume(). pkgName: com.sec.android.app.launcher, userId: 0, isTunableApp: null
10-04 16:55:34.815  1427  1807 D SGM:FgCheckThread: notifyFocusInOut(). of pkg: com.sec.android.app.launcher, type: 4, isTunableApp: false, userId: 0
10-04 16:55:34.815  1427  4443 I WindowManager: Reparenting to leash, surface=Surface(name=3d202b3 StatusBar)/@0x8456cea, leashParent=Surface(name=WindowToken{4280822 type=2000 android.os.BinderProxy@5344804})/@0x3badbdb
10-04 16:55:34.815  1427  1807 D SGM:FgCheckThread:   notifyFocusInOut(). unexpected mPrevNotiType: -1
10-04 16:55:34.815  1427  1807 D SGM:SystemHelper: callReleaseBlock needReleaseBlock:false
10-04 16:55:34.815  1073  1124 I SurfaceFlinger: id=5568 createSurf, flag=24000, Surface(name=3d202b3 StatusBar)/@0x8456cea - animation-leash of insets_animation#5568
10-04 16:55:34.815  7973  7973 D ViewRootImpl@12a5813[0 fl=}]: reportNextDraw android.view.ViewRootImpl.performTraversals:4718 android.view.ViewRootImpl.doTraversal:3288 android.view.ViewRootImpl$TraversalRunnable.run:11344 android.view.Choreographer$CallbackRecord.run:1689 android.view.Choreographer$CallbackRecord.run:1698 
10-04 16:55:34.815  7973  7973 I ViewRootImpl@12a5813[0 fl=}]: Setup new sync=wmsSync-ViewRootImpl@12a5813[0 fl=}]#52
10-04 16:55:34.815  7973  7973 I ViewRootImpl@12a5813[0 fl=}]: Creating new active sync group ViewRootImpl@12a5813[0 fl=}]#53
10-04 16:55:34.816  1427  4443 D WindowManager: makeSurface duration=0 leash=Surface(name=Surface(name=3d202b3 StatusBar)/@0x8456cea - animation-leash of insets_animation)/@0x2f5f5fe
10-04 16:55:34.816  1427  4443 D InsetsSourceProvider: updateControlForTarget: control=InsetsSourceControl: {765e0000 mType=statusBars initiallyVisible mSurfacePosition=Point(0, 0) mInsetsHint=Insets{left=0, top=80, right=0, bottom=0}}, target=Window{fbdaee8 u0 com.sec.android.app.launcher/com.sec.android.app.launcher.activities.LauncherActivity}, from=com.android.server.wm.InsetsStateController.onControlTargetChanged:358 com.android.server.wm.InsetsStateController.onBarControlTargetChanged:324 com.android.server.wm.InsetsPolicy.updateBarControlTarget:173 com.android.server.wm.InsetsPolicy.updateSystemBars:805 com.android.server.wm.DisplayPolicy.updateSystemBarsLw:3425 
10-04 16:55:34.816  1427  4443 I WindowManager: Cancelling animation restarting=true, leash=Surface(name=Surface(name=e6bbee6 NavigationBar0)/@0xd856db6 - animation-leash of insets_animation)/@0x64d6332
10-04 16:55:34.816  1427  4443 I WindowManager: Reparenting to original parent: Surface(name=WindowToken{27ee5c5 type=2019 android.os.BinderProxy@9a062f})/@0xa015ab7, destroy=false, surface=Surface(name=e6bbee6 NavigationBar0)/@0xd856db6
10-04 16:55:34.816  1427  4443 I WindowManager: Reparenting to leash, surface=Surface(name=e6bbee6 NavigationBar0)/@0xd856db6, leashParent=Surface(name=WindowToken{27ee5c5 type=2019 android.os.BinderProxy@9a062f})/@0xa015ab7
10-04 16:55:34.816  7973  7973 I ViewRootImpl@12a5813[0 fl=}]: registerCallbacksForSync syncBuffer=false
10-04 16:55:34.816  1073  1370 I SurfaceFlinger: id=5569 createSurf, flag=24000, Surface(name=e6bbee6 NavigationBar0)/@0xd856db6 - animation-leash of insets_animation#5569
10-04 16:55:34.816  1073  1073 I BpBinder: onLastStrongRef automatically unlinking death recipients: 
10-04 16:55:34.816  1427  4443 D WindowManager: makeSurface duration=0 leash=Surface(name=Surface(name=e6bbee6 NavigationBar0)/@0xd856db6 - animation-leash of insets_animation)/@0x774c7ac
10-04 16:55:34.816  1427  4443 D InsetsSourceProvider: updateControlForTarget: control=InsetsSourceControl: {a1c30001 mType=navigationBars initiallyVisible mSurfacePosition=Point(0, 2256) mInsetsHint=Insets{left=0, top=0, right=0, bottom=144}}, target=Window{fbdaee8 u0 com.sec.android.app.launcher/com.sec.android.app.launcher.activities.LauncherActivity}, from=com.android.server.wm.InsetsStateController.onControlTargetChanged:358 com.android.server.wm.InsetsStateController.onBarControlTargetChanged:327 com.android.server.wm.InsetsPolicy.updateBarControlTarget:173 com.android.server.wm.InsetsPolicy.updateSystemBars:805 com.android.server.wm.DisplayPolicy.updateSystemBarsLw:3425 
10-04 16:55:34.817  1427  4443 D WindowManager: updateSystemBarAttributes: displayId=0, win=Window{fbdaee8 u0 com.sec.android.app.launcher/com.sec.android.app.launcher.activities.LauncherActivity}, navColorWin=Window{e458a32 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity}, focusedCanBeNavColorWin=false, behavior=2, appearance=0, statusBarAppearanceRegions=[AppearanceRegion{ bounds=[0,0][1080,2400]}], requestedVisibilities=-9, from=com.android.server.wm.DisplayPolicy.focusChangedLw:2947 com.android.server.wm.DisplayContent.updateFocusedWindowLocked:4894 com.android.server.wm.RootWindowContainer.updateFocusedWindowLocked:578 
10-04 16:55:34.817  1427  4443 V WindowManager: Relayout hash=fbdaee8, pid=2453, syncId=-1: mAttrs={(0,0)(fillxfill) sim={adjust=nothing forwardNavigation} layoutInDisplayCutoutMode=shortEdges ty=BASE_APPLICATION fmt=TRANSPARENT wanim=0x10302f2
10-04 16:55:34.817  1427  4443 V WindowManager:   fl=81910100
10-04 16:55:34.817  1427  4443 V WindowManager:   pfl=1e008040
10-04 16:55:34.817  1427  4443 V WindowManager:   bhv=SHOW_TRANSIENT_BARS_BY_SWIPE
10-04 16:55:34.817  1427  4443 V WindowManager:   fitSides= screenDimDuration=200000 naviIconColor=0}
10-04 16:55:34.817  7973  8662 I ViewRootImpl@12a5813[0 fl=}]: Received frameDrawingCallback syncResult=0 frameNum=1.
10-04 16:55:34.817  7973  8662 I ViewRootImpl@12a5813[0 fl=}]: mWNT: t=0xb40000786d43fa50 mBlastBufferQueue=0xb4000078cd436190 fn= 1 mRenderHdrSdrRatio=1.0 caller= android.view.ViewRootImpl$8.onFrameDraw:13841 android.view.ThreadedRenderer$1.onFrameDraw:792 <bottom of call stack> 
10-04 16:55:34.817  7973  8662 I ViewRootImpl@12a5813[0 fl=}]: Setting up sync and frameCommitCallback
10-04 16:55:34.818  2453  2453 I BLASTBufferQueue_Java: new BLASTBufferQueue, mName= ViewRootImpl@93f9b16[LauncherActivity] mNativeObject= 0xb4000078cd47f250 sc.mNativeObject= 0xb400007a2d3ff550 caller= android.view.ViewRootImpl.updateBlastSurfaceIfNeeded:3028 android.view.ViewRootImpl.relayoutWindow:10131 android.view.ViewRootImpl.performTraversals:4110 android.view.ViewRootImpl.doTraversal:3288 android.view.ViewRootImpl$TraversalRunnable.run:11344 android.view.Choreographer$CallbackRecord.run:1689 android.view.Choreographer$CallbackRecord.run:1698 android.view.Choreographer.doCallbacks:1153 android.view.Choreographer.doFrame:1079 android.view.Choreographer$FrameDisplayEventReceiver.run:1646 
10-04 16:55:34.818  2453  2453 I BLASTBufferQueue_Java: update, w= 1080 h= 2400 mName = ViewRootImpl@93f9b16[LauncherActivity] mNativeObject= 0xb4000078cd47f250 sc.mNativeObject= 0xb400007a2d3ff550 format= -2 caller= android.graphics.BLASTBufferQueue.<init>:89 android.view.ViewRootImpl.updateBlastSurfaceIfNeeded:3028 android.view.ViewRootImpl.relayoutWindow:10131 android.view.ViewRootImpl.performTraversals:4110 android.view.ViewRootImpl.doTraversal:3288 android.view.ViewRootImpl$TraversalRunnable.run:11344 
10-04 16:55:34.818  2453  2453 I ViewRootImpl@93f9b16[LauncherActivity]: Relayout returned: old=(0,0,1080,2400) new=(0,0,1080,2400) relayoutAsync=false req=(1080,2400)0 dur=5 res=0x403 s={true 0xb40000781d490930} ch=true seqId=0
10-04 16:55:34.818  2042  2042 D SysUiState: SysUiState changed: old=0x10020000 new=0x10000000
10-04 16:55:34.818  2453  2453 I ViewRootImpl@93f9b16[LauncherActivity]: Setup new sync=wmsSync-ViewRootImpl@93f9b16[LauncherActivity]#72
10-04 16:55:34.818  2453  2453 I ViewRootImpl@93f9b16[LauncherActivity]: Creating new active sync group ViewRootImpl@93f9b16[LauncherActivity]#73
10-04 16:55:34.818  2453  2588 I HoneySpace.TopTaskUseCase: topTasks 6 ComponentInfo{com.sec.android.app.launcher/com.sec.android.app.launcher.Launcher}
10-04 16:55:34.818  2453  2453 I ViewRootImpl@93f9b16[LauncherActivity]: registerCallbacksForSync syncBuffer=false
10-04 16:55:34.818  2453 12442 I HoneySpace.SystemUiRepository: systemUiFlags: awake
10-04 16:55:34.819  7973  8590 I BLASTBufferQueue: [ViewRootImpl@12a5813[0 fl=}]#107](f:0,a:0,s:0) onFrameAvailable the first frame is available
10-04 16:55:34.819  2042  2042 D NavigationModeController: getCurrentUserContext: contextUser=0 currentUser=0
10-04 16:55:34.819  7973  8590 I ViewRootImpl@12a5813[0 fl=}]: Received frameCommittedCallback lastAttemptedDrawFrameNum=1 didProduceBuffer=true
10-04 16:55:34.819  2453  2586 I HoneySpace.TopTaskSource: update by launcher showing
10-04 16:55:34.820  2453  4617 I ViewRootImpl@93f9b16[LauncherActivity]: Received frameDrawingCallback syncResult=0 frameNum=1.
10-04 16:55:34.820  2453  4617 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d403930 mBlastBufferQueue=0xb4000078cd47f250 fn= 1 mRenderHdrSdrRatio=1.0 caller= android.view.ViewRootImpl$8.onFrameDraw:13841 android.view.ThreadedRenderer$1.onFrameDraw:792 <bottom of call stack> 
10-04 16:55:34.820  2453  4617 I ViewRootImpl@93f9b16[LauncherActivity]: Setting up sync and frameCommitCallback
10-04 16:55:34.820  2042  2042 D NavigationModeController: getCurrentUserContext: contextUser=0 currentUser=0
10-04 16:55:34.820  7973  7973 I ViewRootImpl@12a5813[0 fl=}]: reportDrawFinished seqId=0
10-04 16:55:34.821  2453  4470 I BLASTBufferQueue: [ViewRootImpl@93f9b16[LauncherActivity]#232](f:0,a:0,s:0) onFrameAvailable the first frame is available
10-04 16:55:34.821  2453  4470 I ViewRootImpl@93f9b16[LauncherActivity]: Received frameCommittedCallback lastAttemptedDrawFrameNum=1 didProduceBuffer=true
10-04 16:55:34.821  7973  7973 I A       : onStart
10-04 16:55:34.821  1427  1582 D WindowManager: SyncGroup 429:  Unfinished container: ActivityRecord{bc89e32 u0 com.sec.android.app.launcher/.activities.LauncherActivity t6} mSyncState=2
10-04 16:55:34.821  2453  2453 I ViewRootImpl@93f9b16[LauncherActivity]: reportDrawFinished seqId=0
10-04 16:55:34.821  2453  2453 I ViewRootImpl@1f7ce54[RecentsActivity]: handleWindowFocusChanged: 0 0 call from android.view.ViewRootImpl.-$$Nest$mhandleWindowFocusChanged:0
10-04 16:55:34.822  2453  2453 I ImeFocusController: onPreWindowFocus: skipped, hasWindowFocus=false mHasImeFocus=true
10-04 16:55:34.822  2453  2453 I ImeFocusController: onPostWindowFocus: skipped, hasWindowFocus=false mHasImeFocus=true
10-04 16:55:34.822  1427  1472 D WindowManager: finishDrawingWindow: Window{ee28167 u0 (1-1)-Window{99bf2c6 alpha=1.0 fl=}} mDrawState=DRAW_PENDING seqId=0
10-04 16:55:34.823  1427  7159 I ActivityManager: Changes in 10263 19 to 3, 0 to 56
10-04 16:55:34.824  1427  1582 D WindowManager: SyncGroup 429:  Unfinished container: ActivityRecord{bc89e32 u0 com.sec.android.app.launcher/.activities.LauncherActivity t6} mSyncState=2
10-04 16:55:34.824  1427  7972 D WindowManager: finishDrawingWindow: Window{fbdaee8 u0 com.sec.android.app.launcher/com.sec.android.app.launcher.activities.LauncherActivity} mDrawState=DRAW_PENDING seqId=0
10-04 16:55:34.824  2362  2362 D HidDeviceService: handleMessage(): msg.what=8
10-04 16:55:34.824  1073  1073 I Layer   : id=5561 removeFromCurrentState Surface(name=3d202b3 StatusBar)/@0x8456cea - animation-leash of insets_animation#5561 (123)
10-04 16:55:34.824  1073  1073 I Layer   : id=5562 removeFromCurrentState Surface(name=e6bbee6 NavigationBar0)/@0xd856db6 - animation-leash of insets_animation#5562 (123)
10-04 16:55:34.825  2453  2586 I HoneySpace.TopTaskSource: onTaskMovedToFront : taskId = 6
10-04 16:55:34.825  2453  2586 I HoneySpace.TopTaskSource: onTaskFocusChanged(): taskId = 6
10-04 16:55:34.825  2453  2586 I HoneySpace.TopTaskSource: onTaskFocusChanged(): taskId = 6
10-04 16:55:34.825  2453  2586 I HoneySpace.TopTaskSource: onTaskMovedToFront : taskId = 6
10-04 16:55:34.825  2453  2586 I HoneySpace.TopTaskSource: onTaskMovedToFront : taskId = 6
10-04 16:55:34.825  1427  7972 D InputDispatcher: Focus request (0): fbdaee8 com.sec.android.app.launcher/com.sec.android.app.launcher.activities.LauncherActivity but waiting because NOT_VISIBLE
10-04 16:55:34.825  1427  1582 V WindowManager: SyncGroup 429: Finished!
10-04 16:55:34.826  1427  1582 V WindowManager: performShowLocked: mDrawState=HAS_DRAWN in Window{ee28167 u0 (1-1)-Window{99bf2c6 alpha=1.0 fl=}}
10-04 16:55:34.826  1427  1582 V WindowManager: performShowLocked: mDrawState=HAS_DRAWN in Window{fbdaee8 u0 com.sec.android.app.launcher/com.sec.android.app.launcher.activities.LauncherActivity}
10-04 16:55:34.826  1427  1582 D ChangeTransitionController: onTransactionReady: TransitionRecord{c4480b2 id=429 type=OPEN flags=0x0}
10-04 16:55:34.826  1427  1582 V WindowManager: Start calculating TransitionInfo based on participants: {WallpaperWindowToken{1f6c5ec token=android.os.Binder@a0f609f}, Task{38abbdb #6 type=home I=com.sec.android.app.launcher/.activities.LauncherActivity}, ActivityRecord{38c4e65 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity t7}, ActivityRecord{40d3803 u0 com.sec.android.app.launcher/.activities.LauncherActivity t-1}, ActivityRecord{bc89e32 u0 com.sec.android.app.launcher/.activities.LauncherActivity t6}, Task{d25c7b4 #1 type=home}}
10-04 16:55:34.826  1427  1582 V WindowManager:   Final targets: [Task{d25c7b4 #1 type=home}, Task{9be573a #7 type=recents I=com.sec.android.app.launcher/com.android.quickstep.RecentsActivity}]
10-04 16:55:34.826  2453  2588 I HoneySpace.TopTaskUseCase: topTasks 6 ComponentInfo{com.sec.android.app.launcher/com.sec.android.app.launcher.Launcher}
10-04 16:55:34.826  1073  2470 I SurfaceFlinger: id=5570 createSurf, flag=84004, Transition Root: Task=1#5570
10-04 16:55:34.826  7973  7973 I A       : onResume
10-04 16:55:34.827  1427  1582 I SurfaceControl: show, t=StartTransaction_SyncId<429>, sc=Surface(name=ActivityRecord{bc89e32 u0 com.sec.android.app.launcher/.activities.LauncherActivity t6})/@0x3520c29, caller=com.android.server.wm.Transition.onTransactionReady:1992 com.android.server.wm.BLASTSyncEngine$SyncGroup.finishNow:315 com.android.server.wm.BLASTSyncEngine$SyncGroup.tryFinish:242 com.android.server.wm.BLASTSyncEngine$SyncGroup.-$$Nest$mtryFinish:0 com.android.server.wm.BLASTSyncEngine.onSurfacePlacement:675 com.android.server.wm.RootWindowContainer.performSurfacePlacementNoTrace:990 
10-04 16:55:34.827  1427  1582 I SurfaceControl: show, t=StartTransaction_SyncId<429>, sc=Surface(name=Task=6)/@0xa59dbae, caller=com.android.server.wm.Transition.onTransactionReady:2009 com.android.server.wm.BLASTSyncEngine$SyncGroup.finishNow:315 com.android.server.wm.BLASTSyncEngine$SyncGroup.tryFinish:242 com.android.server.wm.BLASTSyncEngine$SyncGroup.-$$Nest$mtryFinish:0 com.android.server.wm.BLASTSyncEngine.onSurfacePlacement:675 com.android.server.wm.RootWindowContainer.performSurfacePlacementNoTrace:990 
10-04 16:55:34.827  2453  2585 I HoneySpace.TaskbarEventTracker: invokeEvent() called with: event = SystemUiStateChanged(stateFlags=268435456)
10-04 16:55:34.827  2453  2453 I InsetsSourceConsumer: applyRequestedVisibilityToControl: visible=true, type=statusBars, host=com.sec.android.app.launcher/com.sec.android.app.launcher.activities.LauncherActivity
10-04 16:55:34.827  1427  1582 V WindowManager: Calling onTransitionReady: {id=429 t=OPEN f=0x0 trk=0 r=[0@Point(0, 0)] c=[
10-04 16:55:34.827  1427  1582 V WindowManager:         {WCT{RemoteToken{a964ae4 Task{d25c7b4 #1 type=home}}} m=TO_FRONT f=SHOW_WALLPAPER|MOVE_TO_TOP|EDGE_EXTENSION_RESTRICTION leash=Surface(name=Task=1)/@0x310faab sb=Rect(0, 0 - 1080, 2400) eb=Rect(0, 0 - 1080, 2400) d=0 inset=Rect(0, 80 - 0, 144)},
10-04 16:55:34.827  1427  1582 V WindowManager:         {WCT{RemoteToken{f9558df Task{9be573a #7 type=recents I=com.sec.android.app.launcher/com.android.quickstep.RecentsActivity}}} m=TO_BACK f=SHOW_WALLPAPER|EDGE_EXTENSION_RESTRICTION leash=Surface(name=Task=7)/@0x78c0d00 sb=Rect(0, 0 - 1080, 2400) eb=Rect(0, 0 - 1080, 2400) d=0 inset=Rect(0, 80 - 0, 144)}
10-04 16:55:34.827  1427  1582 V WindowManager:     ]}
10-04 16:55:34.827  2453  2453 I InsetsSourceConsumer: applyRequestedVisibilityToControl: visible=true, type=navigationBars, host=com.sec.android.app.launcher/com.sec.android.app.launcher.activities.LauncherActivity
10-04 16:55:34.828  2453  2453 I Edge.ActivityUtils: HomePackage : com.sec.android.app.launcher, resumePackageName : com.sec.android.app.launcher
10-04 16:55:34.828  1073  2909 I SurfaceFlinger: id=5561 Removed Surface(name=3d202b3 StatusBar)/@0x8456cea - animation-leash of insets_animation#5561 (124)
10-04 16:55:34.828  1073  2909 I SurfaceFlinger: id=5562 Removed Surface(name=e6bbee6 NavigationBar0)/@0xd856db6 - animation-leash of insets_animation#5562 (124)
10-04 16:55:34.828  2453  4693 I HoneySpace.PredictionDataSourceImpl: TYPE_SUGGESTED_APPS updated: 9
10-04 16:55:34.829  1427  1578 V WindowManager: Sent Transition #429 createdAt=10-04 16:55:34.792 via request=TransitionRequestInfo { type = OPEN, triggerTask = TaskInfo{userId=0 taskId=6 displayId=0 isRunning=true baseIntent=Intent { act=android.intent.action.MAIN cat=[android.intent.category.HOME] flg=0x10000100 cmp=com.sec.android.app.launcher/.activities.LauncherActivity } baseActivity=ComponentInfo{com.sec.android.app.launcher/com.sec.android.app.launcher.Launcher} topActivity=ComponentInfo{com.sec.android.app.launcher/com.sec.android.app.launcher.Launcher} origActivity=ComponentInfo{com.sec.android.app.launcher/com.sec.android.app.launcher.activities.LauncherActivity} realActivity=ComponentInfo{com.sec.android.app.launcher/com.sec.android.app.launcher.Launcher} numActivities=1 lastActiveTime=156088659 supportsMultiWindow=true resizeMode=2 isResizeable=true minWidth=-1 minHeight=-1 maxWidth=-1 maxHeight=-1 defaultMinSize=220 token=WCT{RemoteToken{f9dcdc Task{38abbdb #6 type=home I=com.sec.android.app.launcher/.activities.LauncherActivity}}} topActivityType=2 pictureInPictureParams=null shouldDockBigOverlays=false launchIntoPipHostTaskId=-1 lastParentTaskIdBeforePip=-1 displayCutoutSafeInsets=null topActivityInfo=ActivityInfo{de2353b com.sec.android.app.launcher.activities.LauncherActivity} launchCookies=[android.os.BinderProxy@966044] positionInParent=Point(0, 0) parentTaskId=-1 isFocused=true isVisible=false isVisibleRequested=true isSleeping=false topActivityInSizeCompat=false topActivityEligibleForLetterboxEducation= false topActivityLetterboxed= false isFromDoubleTap= false topActivityLetterboxVerticalPosition= -1 topActivityLetterboxHorizontalPosition= -1 topActivityLetterboxWidth=-1 topActivityLetterboxHeight=-1 locusId=null displayAreaFeatureId=1 cameraCompatControlState=hidden originallySupportedMultiWindow=true hasWallpaper=false topActivityInFixedAspectRatio=false rootAffinity=null topActivityInDisplayCompat=false topActivityInBoundsCompat=false topActivityBounds=null singleTapFromLetterbox=false isTopTaskInStage=false topActivityUiMode=17 CoverLauncherWidgetTask=false CoverScreenTask=false isAllowedSeamlessRotation=false isTopTransparentActivity=true hasPopOver=false}, remoteTransition = RemoteTransition { remoteTransition = android.window.IRemoteTransition$Stub$Proxy@9f3e52d, appThread = android.app.IApplicationThread$Stub$Proxy@a7a7a62, debugName = QuickstepLaunch }, displayChange = null }
10-04 16:55:34.829  1427  1578 V WindowManager:     startWCT=WindowContainerTransaction { changes = {} hops = [] errorCallbackToken=null taskFragmentOrganizer=null }
10-04 16:55:34.829  1427  1578 V WindowManager:     info={id=429 t=OPEN f=0x0 trk=0 r=[0@Point(0, 0)] c=[
10-04 16:55:34.829  1427  1578 V WindowManager:         {WCT{RemoteToken{a964ae4 Task{d25c7b4 #1 type=home}}} m=TO_FRONT f=SHOW_WALLPAPER|MOVE_TO_TOP|EDGE_EXTENSION_RESTRICTION leash=Surface(name=Task=1)/@0x310faab sb=Rect(0, 0 - 1080, 2400) eb=Rect(0, 0 - 1080, 2400) d=0 inset=Rect(0, 80 - 0, 144)},
10-04 16:55:34.829  1427  1578 V WindowManager:         {WCT{RemoteToken{f9558df Task{9be573a #7 type=recents I=com.sec.android.app.launcher/com.android.quickstep.RecentsActivity}}} m=TO_BACK f=SHOW_WALLPAPER|EDGE_EXTENSION_RESTRICTION leash=Surface(name=Task=7)/@0x78c0d00 sb=Rect(0, 0 - 1080, 2400) eb=Rect(0, 0 - 1080, 2400) d=0 inset=Rect(0, 80 - 0, 144)}
10-04 16:55:34.829  1427  1578 V WindowManager:     ]}
10-04 16:55:34.829  2453  4695 I HoneySpace.PredictionDataSourceImpl: TYPE_RECOMMENDED_WIDGETS updated: 16
10-04 16:55:34.829  2042  2042 D NavigationModeController: getCurrentUserContext: contextUser=0 currentUser=0
10-04 16:55:34.829  2042  2164 V WindowManagerShell: onTransitionReady android.os.BinderProxy@b60ee74: {id=429 t=OPEN f=0x0 trk=0 r=[0@Point(0, 0)] c=[{WCT{android.window.IWindowContainerToken$Stub$Proxy@50c28f8} m=TO_FRONT f=SHOW_WALLPAPER|MOVE_TO_TOP|EDGE_EXTENSION_RESTRICTION leash=Surface(name=Task=1)/@0xa879555 sb=Rect(0, 0 - 1080, 2400) eb=Rect(0, 0 - 1080, 2400) d=0 inset=Rect(0, 80 - 0, 144)},{WCT{android.window.IWindowContainerToken$Stub$Proxy@27931d1} m=TO_BACK f=SHOW_WALLPAPER|EDGE_EXTENSION_RESTRICTION leash=Surface(name=Task=7)/@0xff8ab6a sb=Rect(0, 0 - 1080, 2400) eb=Rect(0, 0 - 1080, 2400) d=0 inset=Rect(0, 80 - 0, 144)}]}
10-04 16:55:34.829  2042  2164 I SurfaceControl: hide, t=FinishTransaction_SyncId<429>, sc=Surface(name=Task=7)/@0xff8ab6a, caller=com.android.wm.shell.transition.Transitions.dispatchReady:681 com.android.wm.shell.transition.Transitions.onTransitionReady:118 com.android.wm.shell.transition.Transitions$TransitionPlayerImpl$$ExternalSyntheticLambda0.run:13 android.os.Handler.handleCallback:958 android.os.Handler.dispatchMessage:99 android.os.Looper.loopOnce:230 
10-04 16:55:34.830  2042  2164 I SurfaceControl: show, t=StartTransaction_SyncId<429>, sc=Surface(name=Task=1)/@0xa879555, caller=com.android.wm.shell.transition.Transitions.dispatchReady:686 com.android.wm.shell.transition.Transitions.onTransitionReady:118 com.android.wm.shell.transition.Transitions$TransitionPlayerImpl$$ExternalSyntheticLambda0.run:13 android.os.Handler.handleCallback:958 android.os.Handler.dispatchMessage:99 android.os.Looper.loopOnce:230 
10-04 16:55:34.830  2042  2164 I SurfaceControl: show, t=FinishTransaction_SyncId<429>, sc=Surface(name=Task=1)/@0xa879555, caller=com.android.wm.shell.transition.Transitions.dispatchReady:743 com.android.wm.shell.transition.Transitions.onTransitionReady:118 com.android.wm.shell.transition.Transitions$TransitionPlayerImpl$$ExternalSyntheticLambda0.run:13 android.os.Handler.handleCallback:958 android.os.Handler.dispatchMessage:99 android.os.Looper.loopOnce:230 
10-04 16:55:34.830  2042  2164 V WindowManagerShell: Playing animation for (#429)android.os.BinderProxy@b60ee74@0
10-04 16:55:34.830  2042  2164 I SurfaceControl: show, t=StartTransaction_SyncId<429>, sc=Surface(name=Transition Root: Task=1)/@0xf17785b, caller=com.android.wm.shell.transition.Transitions.playTransition:80 com.android.wm.shell.transition.Transitions.processReadyQueue:195 com.android.wm.shell.transition.Transitions.dispatchReady:761 com.android.wm.shell.transition.Transitions.onTransitionReady:118 com.android.wm.shell.transition.Transitions$TransitionPlayerImpl$$ExternalSyntheticLambda0.run:13 android.os.Handler.handleCallback:958 
10-04 16:55:34.830  2042  2164 V WindowManagerShell:  try firstHandler com.android.wm.shell.transition.RemoteTransitionHandler@7d843ff
10-04 16:55:34.830  2042  2164 V WindowManagerShell:  Delegate animation for #429 to RemoteTransition { remoteTransition = android.window.IRemoteTransition$Stub$Proxy@cd87de0, appThread = android.app.IApplicationThread$Stub$Proxy@9c80899, debugName = QuickstepLaunch }
10-04 16:55:34.830  1427  1581 I GameSDK@LifeCycle: noteResumeComponent(): package name  : com.sec.android.app.launcher
10-04 16:55:34.830  2042  2164 V WindowManagerShell:  animated by firstHandler
10-04 16:55:34.830  1073  1370 I SurfaceFlinger: id=5571 createSurf, flag=84000, Surface(name=Task=1)/@0x242869_transition-leash#5571
10-04 16:55:34.831  2453  7396 I SurfaceControl: show, t=StartTransaction_SyncId<429>, sc=Surface(name=Task=1)/@0x242869, caller=com.android.wm.shell.util.TransitionUtil.createLeash:127 com.android.wm.shell.util.TransitionUtil.newTarget:2 com.android.wm.shell.util.TransitionUtil.newTarget:1 com.android.systemui.shared.system.RemoteAnimationTargetCompat.wrap:48 com.android.systemui.shared.system.RemoteAnimationTargetCompat.wrapApps:5 com.android.systemui.shared.system.RemoteAnimationRunnerCompat$1.startAnimation:19 
10-04 16:55:34.831  1073  1370 I SurfaceFlinger: id=5572 createSurf, flag=84000, Surface(name=Task=7)/@0x771d38f_transition-leash#5572
10-04 16:55:34.831  2042  2164 D WindowManagerShell: onActivityRestartAttempt: ComponentInfo{com.sec.android.app.launcher/com.sec.android.app.launcher.Launcher}
10-04 16:55:34.831  2453  7396 I SurfaceControl: show, t=StartTransaction_SyncId<429>, sc=Surface(name=Task=7)/@0x771d38f, caller=com.android.wm.shell.util.TransitionUtil.createLeash:127 com.android.wm.shell.util.TransitionUtil.newTarget:2 com.android.wm.shell.util.TransitionUtil.newTarget:1 com.android.systemui.shared.system.RemoteAnimationTargetCompat.wrap:48 com.android.systemui.shared.system.RemoteAnimationTargetCompat.wrapApps:5 com.android.systemui.shared.system.RemoteAnimationRunnerCompat$1.startAnimation:19 
10-04 16:55:34.831  2453  7396 I SurfaceControl: apply is called, name=StartTransaction_SyncId<429>, caller=android.view.SurfaceControl$Transaction.apply:2921 com.android.systemui.shared.system.RemoteAnimationRunnerCompat$1.startAnimation:658 android.window.IRemoteTransition$Stub.onTransact:131 android.os.Binder.execTransactInternal:1380 android.os.Binder.execTransact:1311 <bottom of call stack> 
10-04 16:55:34.832  2453  7396 I HoneySpace.ShellAnimationRunner: [onAnimationStart] appTarget(0) : taskId-1, mode-0
10-04 16:55:34.832  2453  7396 I HoneySpace.ShellAnimationRunner: [onAnimationStart] appTarget(1) : taskId-7, mode-1
10-04 16:55:34.832  2453  2453 I HoneySpace.ShellTransitionManager: open animation start
10-04 16:55:34.832  2453  2453 I HoneySpace.ShellAnimationRunner: finishExistingAnimation, null
10-04 16:55:34.832  2453  2453 I HoneySpace.ContentsAnimator: from : 0.0
10-04 16:55:34.832  2453  2453 I HoneySpace.HoneyScreenManagerImpl: Close floating task bar
10-04 16:55:34.832  2453  2453 I HoneySpace.ContentsAnimator: ContentsAnimator start
10-04 16:55:34.832  2453  2453 I HoneySpace.AnimationResult: setAnimation, animation: false
10-04 16:55:34.833  1073  1073 I Layer   : Layer [Task=6#121] hidden!! flag(0)
10-04 16:55:34.833  1073  1073 I Layer   : Layer [Task=1#52] hidden!! flag(0)
10-04 16:55:34.833  1073  1073 I Layer   : Layer [com.sec.android.app.launcher/com.sec.android.app.launcher.activities.LauncherActivity$_2453#5567] hidden!! flag(0)
10-04 16:55:34.833  1073  1073 I Layer   : Layer [Transition Root: Task=1#5570] hidden!! flag(0)
10-04 16:55:34.833  1073  1073 I Layer   : Layer [ActivityRecord{bc89e32 u0 com.sec.android.app.launcher/.activities.LauncherActivity t6}#122] hidden!! flag(0)
10-04 16:55:34.833  1073  1073 I Layer   : Layer [(1-1)-Window{99bf2c6 alpha=1.0 fl=}$_7973#5566] hidden!! flag(0)
10-04 16:55:34.833  1073  1073 I Layer   : id=5562 Destroyed Surface(name=e6bbee6 NavigationBar0)/@0xd856db6 - animation-leash of insets_animation#5562
10-04 16:55:34.833  1073  1073 I Layer   : id=5561 Destroyed Surface(name=3d202b3 StatusBar)/@0x8456cea - animation-leash of insets_animation#5561
10-04 16:55:34.835  2042  2042 D NavigationModeController: getCurrentUserContext: contextUser=0 currentUser=0
10-04 16:55:34.836  2042  2042 D NavigationModeController: getCurrentUserContext: contextUser=0 currentUser=0
10-04 16:55:34.837  1427  1581 D PowerManagerService: [api] setScreenDimDurationOverrideFromWindowManagerInternal: timeoutMillis: 200000
10-04 16:55:34.837  1247 10309 I CameraService: onUidStateChanged: uid=10043, procState is changed. (0 -> 1)
10-04 16:55:34.839  1247 10309 I CameraService: onUidStateChanged: uid=10043, procState is changed. (1 -> 0)
10-04 16:55:34.842  2042  2042 I BLASTBufferQueue_Java: update, w= 1080 h= 144 mName = ViewRootImpl@141c4ca[NavigationBar0] mNativeObject= 0xb4000078cd42b290 sc.mNativeObject= 0xb400007a2d40c090 format= -3 caller= android.view.ViewRootImpl.updateBlastSurfaceIfNeeded:3017 android.view.ViewRootImpl.relayoutWindow:10131 android.view.ViewRootImpl.performTraversals:4110 android.view.ViewRootImpl.doTraversal:3288 android.view.ViewRootImpl$TraversalRunnable.run:11344 android.view.Choreographer$CallbackRecord.run:1689 
10-04 16:55:34.842  2042  2042 I ViewRootImpl@141c4ca[NavigationBar0]: Relayout returned: old=(0,2256,1080,2400) new=(0,2256,1080,2400) relayoutAsync=true req=(1080,144)0 dur=0 res=0x0 s={true 0xb40000781d4195b0} ch=false seqId=0
10-04 16:55:34.842  1427  7159 V WindowManager: Relayout Window{e6bbee6 u0 NavigationBar0}: viewVisibility=0 req=1080x144 ty=2019 d0
10-04 16:55:34.843  2042  2042 I ViewRootImpl@141c4ca[NavigationBar0]: registerCallbackForPendingTransactions
10-04 16:55:34.843  2042  2783 I ViewRootImpl@141c4ca[NavigationBar0]: mWNT: t=0xb40000786d419250 mBlastBufferQueue=0xb4000078cd42b290 fn= 10713 mRenderHdrSdrRatio=1.0 caller= android.view.ViewRootImpl$6.onFrameDraw:5635 android.view.ViewRootImpl$2.onFrameDraw:2146 android.view.ThreadedRenderer$1.onFrameDraw:792 
10-04 16:55:34.845  1427  7159 V WindowManager: Relayout hash=e6bbee6, pid=0, syncId=-1: mAttrs={(0,0)(fillx144) gr=BOTTOM CENTER_VERTICAL sim={adjust=pan} layoutInDisplayCutoutMode=always ty=NAVIGATION_BAR fmt=TRANSLUCENT
10-04 16:55:34.845  1427  7159 V WindowManager:   fl=20840028
10-04 16:55:34.845  1427  7159 V WindowManager:   pfl=33001000
10-04 16:55:34.845  1427  7159 V WindowManager:   bhv=DEFAULT
10-04 16:55:34.845  1427  7159 V WindowManager:   providedInsets:
10-04 16:55:34.845  1427  7159 V WindowManager:     InsetsFrameProvider: {id=#a1c30001, index=0, type=navigationBars, source=FRAME, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=144}, insetsSizeOverrides=[TypedInsetsSize: {windowType=INPUT_METHOD, insetsSize=null}]}
10-04 16:55:34.845  1427  7159 V WindowManager:     InsetsFrameProvider: {id=#a1c30006, index=0, type=tappableElement, source=FRAME, flags=[]}
10-04 16:55:34.845  1427  7159 V WindowManager:     InsetsFrameProvider: {id=#a1c30005, index=0, type=mandatorySystemGestures, source=FRAME, flags=[]}
10-04 16:55:34.845  1427  7159 V WindowManager:     InsetsFrameProvider: {id=#a1c30004, index=0, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}}
10-04 16:55:34.845  1427  7159 V WindowManager:     InsetsFrameProvider: {id=#a1c30024, index=1, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}}
10-04 16:55:34.845  1427  7159 V WindowManager:   paramsForRotation:
10-04 16:55:34.845  1427  7159 V WindowManager:     ROTATION_0={(0,0)(fillx144) gr=BOTTOM CENTER_VERTICAL layoutInDisplayCutoutMode=always ty=NAVIGATION_BAR fmt=TRANSLUCENT
10-04 16:55:34.845  1427  7159 V WindowManager:       fl=20840028
10-04 16:55:34.845  1427  7159 V WindowManager:       pfl=31001000
10-04 16:55:34.845  1427  7159 V WindowManager:       bhv=DEFAULT
10-04 16:55:34.845  1427  7159 V WindowManager:       providedInsets:
10-04 16:55:34.845  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30001, index=0, type=navigationBars, source=FRAME, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=144}, insetsSizeOverrides=[TypedInsetsSize: {windowType=INPUT_METHOD, insetsSize=null}]}
10-04 16:55:34.845  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30006, index=0, type=tappableElement, source=FRAME, flags=[]}
10-04 16:55:34.845  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30005, index=0, type=mandatorySystemGestures, source=FRAME, flags=[]}
10-04 16:55:34.845  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30004, index=0, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}}
10-04 16:55:34.845  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30024, index=1, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}} naviIconColor=0}
10-04 16:55:34.845  1427  7159 V WindowManager:     ROTATION_90={(0,0)(144xfill) gr=RIGHT CENTER_HORIZONTAL layoutInDisplayCutoutMode=always ty=NAVIGATION_BAR fmt=TRANSLUCENT
10-04 16:55:34.845  1427  7159 V WindowManager:       fl=20840028
10-04 16:55:34.845  1427  7159 V WindowManager:       pfl=31001000
10-04 16:55:34.845  1427  7159 V WindowManager:       bhv=DEFAULT
10-04 16:55:34.845  1427  7159 V WindowManager:       providedInsets:
10-04 16:55:34.845  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30001, index=0, type=navigationBars, source=FRAME, flags=[], insetsSizeOverrides=[TypedInsetsSize: {windowType=INPUT_METHOD, insetsSize=null}]}
10-04 16:55:34.845  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30006, index=0, type=tappableElement, source=FRAME, flags=[]}
10-04 16:55:34.845  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30005, index=0, type=mandatorySystemGestures, source=FRAME, flags=[]}
10-04 16:55:34.845  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30004, index=0, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}}
10-04 16:55:34.845  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30024, index=1, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}} naviIconColor=0}
10-04 16:55:34.845  1427  7159 V WindowManager:     ROTATION_180={(0,0)(fillx144) gr=BOTTOM CENTER_VERTICAL layoutInDisplayCutoutMode=always ty=NAVIGATION_BAR fmt=TRANSLUCENT
10-04 16:55:34.845  1427  7159 V WindowManager:       fl=20840028
10-04 16:55:34.845  1427  7159 V WindowManager:       pfl=31001000
10-04 16:55:34.845  1427  7159 V WindowManager:       bhv=DEFAULT
10-04 16:55:34.845  1427  7159 V WindowManager:       providedInsets:
10-04 16:55:34.845  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30001, index=0, type=navigationBars, source=FRAME, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=144}, insetsSizeOverrides=[TypedInsetsSize: {windowType=INPUT_METHOD, insetsSize=null}]}
10-04 16:55:34.845  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30006, index=0, type=tappableElement, source=FRAME, flags=[]}
10-04 16:55:34.845  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30005, index=0, type=mandatorySystemGestures, source=FRAME, flags=[]}
10-04 16:55:34.845  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30004, index=0, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}}
10-04 16:55:34.845  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30024, index=1, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}} naviIconColor=0}
10-04 16:55:34.845  1427  7159 V WindowManager:     ROTATION_270={(0,0)(144xfill) gr=LEFT CENTER_HORIZONTAL layoutInDisplayCutoutMode=always ty=NAVIGATION_BAR fmt=TRANSLUCENT
10-04 16:55:34.845  1427  7159 V WindowManager:       fl=20840028
10-04 16:55:34.845  1427  7159 V WindowManager:       pfl=31001000
10-04 16:55:34.845  1427  7159 V WindowManager:       bhv=DEFAULT
10-04 16:55:34.845  1427  7159 V WindowManager:       providedInsets:
10-04 16:55:34.845  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30001, index=0, type=navigationBars, source=FRAME, flags=[], insetsSizeOverrides=[TypedInsetsSize: {windowType=INPUT_METHOD, insetsSize=null}]}
10-04 16:55:34.845  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30006, index=0, type=tappableElement, source=FRAME, flags=[]}
10-04 16:55:34.845  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30005, index=0, type=mandatorySystemGestures, source=FRAME, flags=[]}
10-04 16:55:34.845  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30004, index=0, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}}
10-04 16:55:34.845  1427  7159 V WindowManager:         InsetsFrameProvider: {id=#a1c30024, index=1, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}} naviIconColor=0} naviIconColor=0}
10-04 16:55:34.850  1427  7159 D InputDispatcher: Focus entered window (0): fbdaee8 com.sec.android.app.launcher/com.sec.android.app.launcher.activities.LauncherActivity
10-04 16:55:34.851  1073  1073 D SurfaceFlinger: Display 4633128672291735937 HWC layers:
10-04 16:55:34.851  1073  1073 D SurfaceFlinger:      CLIENT | 0xb400007784fa1a50 | 0100 | RGBA_8888    |  660.0    0.0 1740.0 2400.0 |    0    0 1080 2400 | Wallpaper BBQ wrapper 5_system#85
10-04 16:55:34.851  1073  1073 D SurfaceFlinger:      CLIENT | 0xb400007784faefd0 | 0100 | RGBA_8888    |    0.0    0.0 1080.0 2400.0 |    0    0 1080 2400 | com.sec.android.app.launcher/com.and[...]ntsActivity$_2453#5560 (blurRegions)
10-04 16:55:34.851  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784fbb590 | 0100 | RGBA_8888    |    0.0    0.0 1080.0 2400.0 |    0    0 1080 2400 | com.sec.android.app.launcher/com.sec[...]tivities.LauncherActivity$_2453#5567
10-04 16:55:34.851  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784fa6210 | 0100 | RGBA_8888    |    0.0    0.0 1080.0   80.0 |    0    0 1080   80 | StatusBar$_2042#89
10-04 16:55:34.851  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784fe2110 | 0100 | RGBA_8888    |    0.0    0.0   67.0  342.0 | 1013  623 1080  965 | com.sec.android.app.launcher/com.sam[...]e.edge.CocktailBarService$_2453#2631
10-04 16:55:34.851  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784fa5b10 | 0100 | RGBA_8888    |    0.0    0.0 1080.0  144.0 |    0 2256 1080 2400 | NavigationBar0$_2042#82
10-04 16:55:34.851  1073  1073 D SurfaceFlinger:      DEVICE | 0xb4
10-04 16:55:34.851  1073  1073 D SurfaceFlinger: 00007784fb6510 | 0140 | RGBA_8888    |    0.0    0.0 1080.0   80.0 |    0    0 1080   80 | ScreenDecorOverlay$_2042#99
10-04 16:55:34.851  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784fd5ed0 | 0140 | RGBA_8888    |    0.0    0.0 1080.0   80.0 |    0 2320 1080 2400 | ScreenDecorOverlayBottom$_2042#100
10-04 16:55:34.851  1073  1073 D SurfaceFlinger: 
10-04 16:55:34.852  2453  2453 I ViewRootImpl@93f9b16[LauncherActivity]: handleWindowFocusChanged: 1 0 call from android.view.ViewRootImpl.-$$Nest$mhandleWindowFocusChanged:0
10-04 16:55:34.852  2453  2453 I InputMethodManager: startInputInner - IInputMethodManagerGlobalInvoker.startInputOrWindowGainedFocus
10-04 16:55:34.853  1427  7159 D InputMethodManagerService: setWindowStateInner, windowToken=android.os.BinderProxy@784a00b, state=ImeTargetWindowState{ imeToken null imeFocusChanged true hasEditorFocused false requestedImeVisible false imeDisplayId 0 softInputModeState STATE_UNSPECIFIED|ADJUST_NOTHING|IS_FORWARD_NAVIGATION isStartInputByGainFocus true}
10-04 16:55:34.853  1427  7159 V InputMethodManagerService: Unspecified window will hide input
10-04 16:55:34.853  1427  7159 V InputMethodManagerService: applyImeVisibility state=6
10-04 16:55:34.853  1427  7159 I ImeTracker: com.sec.android.app.launcher:880ae769: onRequestHide at ORIGIN_SERVER_HIDE_INPUT reason HIDE_UNSPECIFIED_WINDOW
10-04 16:55:34.853  1427  7159 D InputMethodManagerService: setWindowStateInner, windowToken=android.os.BinderProxy@784a00b, state=ImeTargetWindowState{ imeToken android.os.Binder@8d47fb3 imeFocusChanged true hasEditorFocused false requestedImeVisible false imeDisplayId 0 softInputModeState STATE_UNSPECIFIED|ADJUST_NOTHING|IS_FORWARD_NAVIGATION isStartInputByGainFocus true}
10-04 16:55:34.853  1427  7159 I ImeTracker: com.sec.android.app.launcher:880ae769: onCancelled at PHASE_SERVER_SHOULD_HIDE
10-04 16:55:34.853  1427  7159 V InputMethodManagerService: hideCurrentInputLocked : canceled, shouldHideSoftInput=false, mInputShown=false, mImeWindowVis=0
10-04 16:55:34.853  1427  7159 D InputMethodManagerService: DESKTOP MODE! : 2
10-04 16:55:34.853  1427  7159 D InputMethodManagerService: NOT IN KNOX DESKTOP MODE!
10-04 16:55:34.853  1427  7159 V InputMethodManagerService: getDisplayIdOfInputMethodWindowToBeAdded: displayId=0
10-04 16:55:34.853  1427  7159 D InputMethodManagerService: isImeSwitcherDisabledPackage : false
10-04 16:55:34.853  1427  7159 D InputMethodManagerService: checkDisplayOfStartInputAndUpdateKeyboard: displayId=0, mFocusedDisplayId=0
10-04 16:55:34.853  1427  7159 D InputTransport: Input channel constructed: 'ClientS', fd=800
10-04 16:55:34.853  1427  7159 D InputTransport: Input channel destroyed: 'ClientS', fd=800
10-04 16:55:34.853  5004  5004 I HBD     : HoneyBoardService onFinishInput 
10-04 16:55:34.853  5004  5004 I HBD     : a IC have been unbinding,  RemoteInputConnection{idHash=#f534c2c}
10-04 16:55:34.853  5004  5004 I HBD     : HoneyBoardService [PF_CL][onFinishInput]  0 ms 
10-04 16:55:34.853  1427  4443 D RestrictionPolicy: isScreenCaptureEnabled : ret=true userId=0
10-04 16:55:34.854  5004  5004 I HBD     : HoneyBoardService [IMI] onStartInput - caller pid : 2453 , caller uid : 10137 
10-04 16:55:34.854  5004  5004 I HBD     : k updateConfigs 
10-04 16:55:34.854  5004  5004 I HBD     : k isEnabledNightMode : false 
10-04 16:55:34.854  5004  5004 I HBD     : a IC have been binding, RemoteInputConnection{idHash=#f534c2c} 
10-04 16:55:34.854  5004  5004 I HBD     : h [EditorInputType]setPrivateImeOptionsToTable privateImeOptions ( null )
10-04 16:55:34.854  5004  5004 I HBD     : b incognitoMode : false 
10-04 16:55:34.854  5004  5004 I HBD     : b needOff = true , isForceOff = false, isNullInputClass : true 
10-04 16:55:34.854  5004  5004 I HBD     : h getDefaultInputRange : UNKNOWN 
10-04 16:55:34.854  1427  4443 I WindowManager: Cancelling animation restarting=true, leash=Surface(name=Surface(name=f319ab4 InputMethod)/@0xcb81495 - animation-leash of insets_animation)/@0x81afc8f
10-04 16:55:34.854  5004  5004 I HBD     : h getDefaultInputRange : UNKNOWN 
10-04 16:55:34.854  1427  4443 I WindowManager: Reparenting to original parent: Surface(name=WindowToken{1909d62 type=2011 android.os.Binder@2d0b42d})/@0xc779cd0, destroy=false, surface=Surface(name=f319ab4 InputMethod)/@0xcb81495
10-04 16:55:34.854  5004  5004 I HBD     : h getDefaultInputRange : UNKNOWN 
10-04 16:55:34.854  1427  4443 I WindowManager: Reparenting to leash, surface=Surface(name=f319ab4 InputMethod)/@0xcb81495, leashParent=Surface(name=WindowToken{1909d62 type=2011 android.os.Binder@2d0b42d})/@0xc779cd0
10-04 16:55:34.854  1073  1370 I SurfaceFlinger: id=5573 createSurf, flag=24004, Surface(name=f319ab4 InputMethod)/@0xcb81495 - animation-leash of insets_animation#5573
10-04 16:55:34.854  1427  4443 D WindowManager: makeSurface duration=0 leash=Surface(name=Surface(name=f319ab4 InputMethod)/@0xcb81495 - animation-leash of insets_animation)/@0xd70e56e
10-04 16:55:34.854  5004  5004 I HBD     : b needOff = true , isForceOff = false, isNullInputClass : true 
10-04 16:55:34.854  5004  5004 I HBD     : b update cached prediction status : false 
10-04 16:55:34.854  5004  5004 I HBD     : h getDefaultInputRange : UNKNOWN 
10-04 16:55:34.854  5004  5004 I HBD     : a currentState : 0 
10-04 16:55:34.854  1427  4443 D InsetsSourceProvider: updateControlForTarget: control=InsetsSourceControl: {3 mType=ime mSurfacePosition=Point(0, 80) mInsetsHint=Insets{left=0, top=0, right=0, bottom=1026}}, target=Window{fbdaee8 u0 com.sec.android.app.launcher/com.sec.android.app.launcher.activities.LauncherActivity}, from=com.android.server.wm.ImeInsetsSourceProvider.updateControlForTarget:165 com.android.server.wm.InsetsStateController.onControlTargetChanged:358 com.android.server.wm.InsetsStateController.onImeControlTargetChanged:302 com.android.server.wm.DisplayContent.updateImeControlTarget:5727 com.android.server.wm.DisplayContent.updateImeInputAndControlTarget:5687 
10-04 16:55:34.854  5004  5004 I HBD     : a [UpdatePolicy] [post] a: 0 cl: 65538 kit: [0/0] vt: 0 ir: 1 
10-04 16:55:34.855  5004  5004 I HBD     : a [NRIC] resetNoResponseState 
10-04 16:55:34.855  5004  5004 I HBD     : b needOff = true , isForceOff = false, isNullInputClass : true 
10-04 16:55:34.855  5004  5004 I HBD     : b update cached prediction status : false 
10-04 16:55:34.855  5004  5004 I HBD     : b [AiWriter] setContact : com.sec.android.app.launcher
10-04 16:55:34.855  5004  5004 I HBD     : HoneyBoardService [PF_OP][onStartInput]  1 ms 
10-04 16:55:34.856  2453  2453 I InsetsSourceConsumer: applyRequestedVisibilityToControl: visible=false, type=ime, host=com.sec.android.app.launcher/com.sec.android.app.launcher.activities.LauncherActivity
10-04 16:55:34.856  1427  7972 D InputMethodManagerService: isImeSwitcherDisabledPackage : false
10-04 16:55:34.856  2042  2042 D NavigationBar: setImeWindowStatus displayId=0 vis=0 backDisposition=0 showImeSwitcher=false imeShown=false
10-04 16:55:34.856  5004  5004 I InputMethodService: scheduleImeSurfaceRemoval: removeImeSurface is posted.
10-04 16:55:34.857  2042  2303 I WallpaperService: resized: system, syncSeqId=-1
10-04 16:55:34.857  2453  7396 I ViewRootImpl@93f9b16[LauncherActivity]: Resizing android.view.ViewRootImpl@6d260ec: frame = [0,0][1080,2400] reportDraw = false forceLayout = false syncSeqId = -1
10-04 16:55:34.857  2453  7396 I ViewRootImpl@4145d62[CocktailBarService]: Resizing android.view.ViewRootImpl@d3e24c5: frame = [1013,623][1080,965] reportDraw = false forceLayout = false syncSeqId = -1
10-04 16:55:34.857  7973  8985 I ViewRootImpl@12a5813[0 fl=}]: Resizing android.view.ViewRootImpl@51a32d4: frame = [0,0][1080,2400] reportDraw = false forceLayout = false syncSeqId = -1
10-04 16:55:34.857  2042  2303 I ViewRootImpl@141c4ca[NavigationBar0]: Resizing android.view.ViewRootImpl@5ffbf13: frame = [0,2256][1080,2400] reportDraw = false forceLayout = false syncSeqId = -1
10-04 16:55:34.857  2042  4610 I ViewRootImpl@3eb5874[ScreenDecorOverlay]: Resizing android.view.ViewRootImpl@b239360: frame = [0,0][1080,80] reportDraw = false forceLayout = false syncSeqId = -1
10-04 16:55:34.857  2453  2453 I ViewRootImpl@93f9b16[LauncherActivity]: handleResized, msg = 4 frames=ClientWindowFrames{frame=[0,0][1080,2400] display=[0,0][1080,2400] parentFrame=[0,0][0,0]} forceNextWindowRelayout=false displayId=0 dragResizing=false compatScale=1.0 frameChanged=false attachedFrameChanged=false configChanged=false displayChanged=false compatScaleChanged=false
10-04 16:55:34.857  7973  7973 I ViewRootImpl@12a5813[0 fl=}]: handleResized, msg = 4 frames=ClientWindowFrames{frame=[0,0][1080,2400] display=[0,0][1080,2400] parentFrame=[0,0][0,0]} forceNextWindowRelayout=false displayId=0 dragResizing=false compatScale=1.0 frameChanged=false attachedFrameChanged=false configChanged=false displayChanged=false compatScaleChanged=false
10-04 16:55:34.857  2453  2453 I ViewRootImpl@4145d62[CocktailBarService]: handleResized, msg = 4 frames=ClientWindowFrames{frame=[1013,623][1080,965] display=[0,0][1080,2256] parentFrame=[0,0][0,0]} forceNextWindowRelayout=false displayId=0 dragResizing=false compatScale=1.0 frameChanged=false attachedFrameChanged=false configChanged=false displayChanged=false compatScaleChanged=false
10-04 16:55:34.857  2042  2331 I WallpaperService: handleResized: which=5, reportDraw=false
10-04 16:55:34.857  2042  3044 I ViewRootImpl@3eb5874[ScreenDecorOverlay]: handleResized, msg = 4 frames=ClientWindowFrames{frame=[0,0][1080,80] display=[0,0][1080,2400] parentFrame=[0,0][0,0]} forceNextWindowRelayout=false displayId=0 dragResizing=false compatScale=1.0 frameChanged=false attachedFrameChanged=false configChanged=false displayChanged=false compatScaleChanged=false
10-04 16:55:34.857  2042  2042 I ViewRootImpl@141c4ca[NavigationBar0]: handleResized, msg = 4 frames=ClientWindowFrames{frame=[0,2256][1080,2400] display=[0,0][1080,2400] parentFrame=[0,0][0,0]} forceNextWindowRelayout=false displayId=0 dragResizing=false compatScale=1.0 frameChanged=false attachedFrameChanged=false configChanged=false displayChanged=false compatScaleChanged=false
10-04 16:55:34.857  2042  2331 I WallpaperService: updateSurface system forceRelayout=true forceReport=false redrawNeeded=false myWidth=2400 myHeight=2400 fixedSize=true x = 0 y = 0 mWidth=2400 mHeight=2400
10-04 16:55:34.857  2042  4610 I ViewRootImpl@403463c[ScreenDecorOverlayBottom]: Resizing android.view.ViewRootImpl@49ccc1e: frame = [0,2320][1080,2400] reportDraw = false forceLayout = false syncSeqId = -1
10-04 16:55:34.857  2042  3044 I ViewRootImpl@403463c[ScreenDecorOverlayBottom]: handleResized, msg = 4 frames=ClientWindowFrames{frame=[0,2320][1080,2400] display=[0,0][1080,2400] parentFrame=[0,0][0,0]} forceNextWindowRelayout=false displayId=0 dragResizing=false compatScale=1.0 frameChanged=false attachedFrameChanged=false configChanged=false displayChanged=false compatScaleChanged=false
10-04 16:55:34.857  2042  9413 I ViewRootImpl@16e3a3f[StatusBar]: Resizing android.view.ViewRootImpl@a2ae18: frame = [0,0][1080,80] reportDraw = false forceLayout = false syncSeqId = -1
10-04 16:55:34.857  2042  2042 I ViewRootImpl@16e3a3f[StatusBar]: handleResized, msg = 4 frames=ClientWindowFrames{frame=[0,0][1080,80] display=[0,0][1080,2400] parentFrame=[0,0][0,0]} forceNextWindowRelayout=false displayId=0 dragResizing=false compatScale=1.0 frameChanged=false attachedFrameChanged=false configChanged=false displayChanged=false compatScaleChanged=false
10-04 16:55:34.857  2042  2331 I WallpaperService: maxBounds : Rect(0, 0 - 1080, 2400) , mDeviceHeight : 2400, mDeviceWidth : 1080,mDeviceRotation  : 0
10-04 16:55:34.858  2042  2331 I WallpaperService: updateSurface: invoke Session.relayout
10-04 16:55:34.858  1073  1073 I Layer   : id=5565 removeFromCurrentState Surface(name=f319ab4 InputMethod)/@0xcb81495 - animation-leash of insets_animation#5565 (125)
10-04 16:55:34.858  1427  7972 V WindowManager: Relayout Window{7fa477f u0 com.android.systemui.wallpapers.ImageWallpaper_system}: viewVisibility=0 req=2400x2400 ty=2013 d0
10-04 16:55:34.858  1073  1073 I SurfaceFlinger: id=5565 Removed Surface(name=f319ab4 InputMethod)/@0xcb81495 - animation-leash of insets_animation#5565 (125)
10-04 16:55:34.859  1427  7972 V WindowManager: Relayout hash=7fa477f, pid=2042, syncId=-1: mAttrs={(0,0)(2400x2400) gr=TOP START CENTER layoutInDisplayCutoutMode=always ty=WALLPAPER fmt=RGBX_8888 wanim=0x1030314
10-04 16:55:34.859  1427  7972 V WindowManager:   fl=14318
10-04 16:55:34.859  1427  7972 V WindowManager:   pfl=2000014
10-04 16:55:34.859  1427  7972 V WindowManager:   bhv=DEFAULT naviIconColor=0
10-04 16:55:34.859  1427  7972 V WindowManager:   sfl=8}
10-04 16:55:34.860  2042  2331 I BLASTBufferQueue_Java: update, w= 2400 h= 2400 mName = Wallpaper mNativeObject= 0xb4000078cd3f9bf0 sc.mNativeObject= 0xb400007a2d3f6610 format= 2 caller= android.service.wallpaper.WallpaperService$Engine.getOrCreateBLASTSurface:2827 android.service.wallpaper.WallpaperService$Engine.updateSurface:1623 android.service.wallpaper.WallpaperService$IWallpaperEngineWrapper.handleResized:3323 android.service.wallpaper.WallpaperService$IWallpaperEngineWrapper.executeMessage:3242 com.android.internal.os.HandlerCaller$MyHandler.handleMessage:44 android.os.Handler.dispatchMessage:106 
10-04 16:55:34.863 14526 14526 I adbd    : Remote process closed the socket (on MSG_PEEK)
10-04 16:55:34.863  1427  4395 D InputMethodManagerService: removeClient
10-04 16:55:34.863  1427  9415 I WindowManager: WIN DEATH: Window{344fe1b u0 com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity}
10-04 16:55:34.864  1427  4395 D InputTransport: Input channel destroyed: 'ClientS', fd=918
10-04 16:55:34.864  1427  9415 D InputTransport: Input channel destroyed: '344fe1b', fd=868
10-04 16:55:34.864  1427  9415 W InputManager-JNI: Input channel object '344fe1b com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity (client)' was disposed without first being removed with the input manager!
10-04 16:55:34.864  1427  9415 D InputTransport: Input channel destroyed: '344fe1b', fd=884
10-04 16:55:34.864  1427  9415 V WindowManager: Remove Window{344fe1b u0 com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity}: mSurfaceController=null mAnimatingExit=false mRemoveOnExit=false mHasSurface=false surfaceShowing=false animating=false app-animation=false mDisplayFrozen=false callers=com.android.server.wm.WindowState$DeathRecipient.binderDied:3686 android.os.IBinder$DeathRecipient.binderDied:325 android.os.BinderProxy.sendDeathNotice:781 <bottom of call stack> <bottom of call stack> <bottom of call stack> 
10-04 16:55:34.864  1427  9415 D RestrictionPolicy: isScreenCaptureEnabled : ret=true userId=0
10-04 16:55:34.864  1427  1775 D VibratorManagerService: Vibration 313 finished with EndInfo{status=FINISHED, endedBy=null}
10-04 16:55:34.864  1427  1775 D VibratorManagerService: Reporting vibration 313 finished with EndInfo{status=FINISHED, endedBy=null}
10-04 16:55:34.864  1427  1775 D VibratorManagerService: Vibration for uid=10137 and with attrs=VibrationAttributes: Usage=TOUCH Audio Usage= USAGE_ASSISTANCE_SONIFICATION tags= Flags=0 ended with status FINISHED
10-04 16:55:34.864  1044  1044 E SecVibrator-HAL-AIDL-CORE: V_1_0: Vibrator off
10-04 16:55:34.865  1044  1044 E SecVibrator-HAL-AIDL-CORE: HW_API: >> writeNode node:/timed_output/vibrator/enable val:0
10-04 16:55:34.866  1044  1044 E SecVibrator-HAL-AIDL-CORE: HW_API: << writeNode node OK : 2
10-04 16:55:34.866  1427  1775 D VibratorManagerService: VibrationThread released after finished vibration
10-04 16:55:34.866  1427  1775 D VibratorManagerService: Processing VibrationThread released callback
10-04 16:55:34.866  1073  1073 I Layer   : id=5565 Destroyed Surface(name=f319ab4 InputMethod)/@0xcb81495 - animation-leash of insets_animation#5565
10-04 16:55:34.867   959   959 I Zygote  : Process 16972 exited due to signal 9 (Killed)
10-04 16:55:34.869  1427  1427 I WALLPAPER_SVC:SemWallpaperManagerService: isHomeActivityVisible : true 
10-04 16:55:34.869  1427  1579 D DisplayManagerService: Drop pending events for gone uid 10384
10-04 16:55:34.869  1427  1427 D WALLPAPER_SVC:WallpaperManagerService: dispatchHomeVisibilityChanged: visible = true, connection = com.android.server.wallpaper.WallpaperManagerService$WallpaperConnection@99a56e8, systemWallpaper = WallpaperData@48ce4f1, id: 3, which: 5, file mod: 0, info: null, engine(s): Proxy@81367bb, type = 0, userId = 0, uri= null, wallpaperComponent = ComponentInfo{com.android.systemui/com.android.systemui.wallpapers.ImageWallpaper}, nextWallpaperComponent = ComponentInfo{com.android.systemui/com.android.systemui.wallpapers.ImageWallpaper} 
10-04 16:55:34.869  2362  2362 D HidDeviceService: handleMessage(): msg.what=8
10-04 16:55:34.869  1073  1370 I SurfaceFlinger: id=5549 Removed 2666613 ActivityRecordInputSink com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity#5549 (124)
10-04 16:55:34.870  1073  2470 I SurfaceFlinger: id=5574 createSurf, flag=24004, Task=148#5574
10-04 16:55:34.872  2453 15403 I HoneySpace.RecentTasks: onRecentTasksChanged
10-04 16:55:34.873  1427  1581 W ActivityManager: setHasOverlayUi called on unknown pid: 16972
10-04 16:55:34.873  1427  1587 W UsageStatsService: Unexpected activity event reported! (com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity event : 23 instanceId : 172445807)
10-04 16:55:34.873  2453  2453 I HoneySpace.TaskListViewModel: onTaskRemoved : 148
10-04 16:55:34.873  2453  2453 I HoneySpace.BaseRecentsView: INVALID_TASK_POSITION 148
10-04 16:55:34.873  2453  2453 I HoneySpace.TaskListViewModel: onTaskRemoved : 148
10-04 16:55:34.873  2453  2453 I HoneySpace.BaseRecentsView: INVALID_TASK_POSITION 148
10-04 16:55:34.873  2453  2586 I HoneySpace.TopTaskSource: onTaskRemoved: 148
10-04 16:55:34.874  2453  2586 I HoneySpace.TopTaskSource: onTaskRemoved: 148
10-04 16:55:34.874  1073  1073 I Layer   : id=5550 removeFromCurrentState 344fe1b com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity#5550 (125)
10-04 16:55:34.874  1073  1073 I Layer   : id=5543 removeFromCurrentState ActivityRecord{7496249 u0 com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity t148}#5543 (125)
10-04 16:55:34.874  1073  1073 I Layer   : id=5549 removeFromCurrentState 2666613 ActivityRecordInputSink com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity#5549 (125)
10-04 16:55:34.874  1073  1073 I Layer   : id=5542 removeFromCurrentState Task=148#5542 (125)
10-04 16:55:34.874  1073  1073 I Layer   : id=5574 removeFromCurrentState Task=148#5574 (125)
10-04 16:55:34.875  1073  1073 I SurfaceFlinger: id=5574 Removed Task=148#5574 (125)
10-04 16:55:34.875  1073  1073 I SurfaceFlinger: id=5543 Removed ActivityRecord{7496249 u0 com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity t148}#5543 (125)
10-04 16:55:34.875  1073  1073 I SurfaceFlinger: id=5550 Removed 344fe1b com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity#5550 (125)
10-04 16:55:34.883  1073  1073 I Layer   : id=5550 Destroyed 344fe1b com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity#5550
10-04 16:55:34.883  1073  1073 I Layer   : id=5574 Destroyed Task=148#5574
10-04 16:55:34.883  1073  1073 I Layer   : id=5543 Destroyed ActivityRecord{7496249 u0 com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity t148}#5543
10-04 16:55:34.883  1073  1073 I Layer   : id=5549 Destroyed 2666613 ActivityRecordInputSink com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity#5549
10-04 16:55:34.899  3946 11450 I SDHMS:l : onTaskStackChanged
10-04 16:55:34.900  2453 15403 I HoneySpace.RecentTasks: onRecentTasksChanged
10-04 16:55:34.987  2042  2042 D MobileSignalTransitionManager: updateSignalTransition
10-04 16:55:34.992  1073  1073 D SurfaceFlinger: GPIS:: requestGPISForClientComposition
10-04 16:55:34.993  1073  3020 D NativeSemDvfsManager: acquire:: timeout = 2000 mIsAcquired = 1  mTagName : SurfaceFlinger 
10-04 16:55:34.993  1073  3020 E NativeCustomFrequencyManager: [NativeCFMS] BpCustomFrequencyManager::acquire()
10-04 16:55:34.993   994  1071 I HYPER-HAL: [RequestManager.cpp]acquire(): Acquired ID : 2150701  [1073 / 1000]    HINT : SF_GPU_MINLOCK    list : [TIMEOUT / 2000] 
10-04 16:55:35.084  2453  2453 I HoneySpace.HomescreenPot: playContentAnimator end, skip alpha: false
10-04 16:55:35.084  2453  2453 I HoneySpace.HoneyScreenManagerImpl: transitionAnimator is ended, onCancel: false
10-04 16:55:35.084  2453  2453 I HoneySpace.ContentsAnimator: ContentsAnimator end
10-04 16:55:35.084  2453  2453 I HoneySpace.RecentsCloseAnimationDelegate: onAnimationEnd
10-04 16:55:35.084  2453  2453 I HoneySpace.RunnableList: executeAllAndClear() called
10-04 16:55:35.084  2453  2453 I HoneySpace.AnimationResult: finish, false
10-04 16:55:35.085  2042  2164 V WindowManagerShell: Transition animation finished (aborted=false), notifying core (#429)android.os.BinderProxy@b60ee74@0
10-04 16:55:35.085  2042  2164 I SurfaceControl: apply is called, name=FinishTransaction_SyncId<429>, caller=android.view.SurfaceControl$Transaction.apply:2921 com.android.wm.shell.transition.Transitions.onFinish:302 com.android.wm.shell.transition.Transitions$$ExternalSyntheticLambda6.onTransitionFinished:11 com.android.wm.shell.transition.RemoteTransitionHandler$1$$ExternalSyntheticLambda0.run:118 android.os.Handler.handleCallback:958 android.os.Handler.dispatchMessage:99 
10-04 16:55:35.085  2453  6740 I HoneySpace.AnimationResult: asyncFinishRunnable run
10-04 16:55:35.086  2453  2453 I HoneySpace.ShellTransitionManager: open normal end
10-04 16:55:35.086  2453  2453 I HoneySpace.AnimationResult: completeCallback run
10-04 16:55:35.086  1427  4443 V WindowManager: Finish Transition: TransitionRecord{c4480b2 id=429 type=OPEN flags=0x0}, caller=com.android.server.wm.WindowOrganizerController.finishTransition:454 android.window.IWindowOrganizerController$Stub.onTransact:286 com.android.server.wm.WindowOrganizerController.onTransact:217 
10-04 16:55:35.086  1427  1578 V WindowManager: Finish Transition #429: created at 10-04 16:55:34.792 collect-started=0.225ms request-sent=10.071ms started=18.141ms ready=18.128ms sent=35.395ms finished=294.098ms
10-04 16:55:35.086  1427  4443 V WindowManager: Setting visibility of Window{e458a32 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity}: false, caller=com.android.server.wm.WindowContainer.sendAppVisibilityToClients:1301 com.android.server.wm.WindowToken.setClientVisible:446 com.android.server.wm.ActivityRecord.setClientVisible:8121 com.android.server.wm.ActivityRecord.postApplyAnimation:6685 com.android.server.wm.ActivityRecord.commitVisibility:6628 
10-04 16:55:35.087  2453  2453 I ViewRootImpl@1f7ce54[RecentsActivity]: handleAppVisibility mAppVisible = true visible = false
10-04 16:55:35.087  2042  2164 V WindowManagerShell: Track 0 became idle
10-04 16:55:35.087  2042  2164 V WindowManagerShell: All active transition animations finished
10-04 16:55:35.092  1073  1073 I Layer   : id=5570 removeFromCurrentState Transition Root: Task=1#5570 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=5572 removeFromCurrentState Surface(name=Task=7)/@0x771d38f_transition-leash#5572 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=125 removeFromCurrentState Task=7#125 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=126 removeFromCurrentState ActivityRecord{38c4e65 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity t7}#126 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=439 removeFromCurrentState bc64b5c ActivityRecordInputSink com.sec.android.app.launcher/com.android.quickstep.RecentsActivity#439 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=135 removeFromCurrentState e458a32 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity#135 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=5560 removeFromCurrentState com.sec.android.app.launcher/com.android.quickstep.RecentsActivity$_2453#5560 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=5571 removeFromCurrentState Surface(name=Task=1)/@0x242869_transition-leash#5571 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=52 removeFromCurrentState Task=1#52 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=121 removeFromCurrentState Task=6#121 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=122 removeFromCurrentState ActivityRecord{bc89e32 u0 com.sec.android.app.launcher/.activities.LauncherActivity t6}#122 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=134 removeFromCurrentState dbc4bc9 ActivityRecordInputSink com.sec.android.app.launcher/.Launcher#134 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=123 removeFromCurrentState fbdaee8 com.sec.android.app.launcher/com.sec.android.app.launcher.activities.LauncherActivity#123 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=5567 removeFromCurrentState com.sec.android.app.launcher/com.sec.android.app.launcher.activities.LauncherActivity$_2453#5567 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=17 removeFromCurrentState ImeContainer#17 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=117 removeFromCurrentState WindowToken{1909d62 type=2011 android.os.Binder@2d0b42d}#117 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=5573 removeFromCurrentState Surface(name=f319ab4 InputMethod)/@0xcb81495 - animation-leash of insets_animation#5573 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=140 removeFromCurrentState f319ab4 InputMethod#140 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=1378 removeFromCurrentState ee28167 (1-1)-Window{99bf2c6 alpha=1.0 fl=}#1378 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=5566 removeFromCurrentState (1-1)-Window{99bf2c6 alpha=1.0 fl=}$_7973#5566 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=52 addToCurrentState Task=1#52 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=121 addToCurrentState Task=6#121 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=122 addToCurrentState ActivityRecord{bc89e32 u0 com.sec.android.app.launcher/.activities.LauncherActivity t6}#122 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=134 addToCurrentState dbc4bc9 ActivityRecordInputSink com.sec.android.app.launcher/.Launcher#134 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=123 addToCurrentState fbdaee8 com.sec.android.app.launcher/com.sec.android.app.launcher.activities.LauncherActivity#123 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=5567 addToCurrentState com.sec.android.app.launcher/com.sec.android.app.launcher.activities.LauncherActivity$_2453#5567 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=17 addToCurrentState ImeContainer#17 (121)
10-04 16:55:35.092  2453  2453 I ViewRootImpl@1f7ce54[RecentsActivity]: destroyHardwareResources: Callers=android.view.ViewRootImpl.performTraversals:3932 android.view.ViewRootImpl.doTraversal:3288 android.view.ViewRootImpl$TraversalRunnable.run:11344 android.view.Choreographer$CallbackRecord.run:1689 android.view.Choreographer$CallbackRecord.run:1698 android.view.Choreographer.doCallbacks:1153 android.view.Choreographer.doFrame:1079 android.view.Choreographer$FrameDisplayEventReceiver.run:1646 android.os.Handler.handleCallback:958 android.os.Handler.dispatchMessage:99 
10-04 16:55:35.092  1073  1073 I Layer   : id=117 addToCurrentState WindowToken{1909d62 type=2011 android.os.Binder@2d0b42d}#117 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=5573 addToCurrentState Surface(name=f319ab4 InputMethod)/@0xcb81495 - animation-leash of insets_animation#5573 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=140 addToCurrentState f319ab4 InputMethod#140 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=1378 addToCurrentState ee28167 (1-1)-Window{99bf2c6 alpha=1.0 fl=}#1378 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=5566 addToCurrentState (1-1)-Window{99bf2c6 alpha=1.0 fl=}$_7973#5566 (121)
10-04 16:55:35.092  1073  1073 I Layer   : Layer [Task=7#125] hidden!! flag(1)
10-04 16:55:35.092  1073  1073 I Layer   : id=125 addToCurrentState Task=7#125 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=126 addToCurrentState ActivityRecord{38c4e65 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity t7}#126 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=439 addToCurrentState bc64b5c ActivityRecordInputSink com.sec.android.app.launcher/com.android.quickstep.RecentsActivity#439 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=135 addToCurrentState e458a32 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity#135 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=5560 addToCurrentState com.sec.android.app.launcher/com.android.quickstep.RecentsActivity$_2453#5560 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=5570 removeFromCurrentState Transition Root: Task=1#5570 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=5572 removeFromCurrentState Surface(name=Task=7)/@0x771d38f_transition-leash#5572 (121)
10-04 16:55:35.092  1073  1073 I Layer   : id=5571 removeFromCurrentState Surface(name=Task=1)/@0x242869_transition-leash#5571 (121)
10-04 16:55:35.092  1073  1073 I Layer   : Layer [com.sec.android.app.launcher/com.android.quickstep.RecentsActivity$_2453#5560] hidden!! flag(1)
10-04 16:55:35.092  1073  1073 I Layer   : Layer [ActivityRecord{38c4e65 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity t7}#126] hidden!! flag(1)
10-04 16:55:35.093  1073  1073 I SurfaceFlinger: id=5570 Removed Transition Root: Task=1#5570 (121)
10-04 16:55:35.093  1073  1073 I SurfaceFlinger: id=5572 Removed Surface(name=Task=7)/@0x771d38f_transition-leash#5572 (121)
10-04 16:55:35.093  1073  1073 I SurfaceFlinger: id=5571 Removed Surface(name=Task=1)/@0x242869_transition-leash#5571 (121)
10-04 16:55:35.094  1427  9415 V WindowManager: Relayout Window{e458a32 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity}: viewVisibility=8 req=1080x2400 ty=1 d0
10-04 16:55:35.094  1073  1073 D SurfaceFlinger: Display 4633128672291735937 HWC layers:
10-04 16:55:35.094  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784fa1a50 | 0100 | RGBA_8888    |  660.0    0.0 1740.0 2400.0 |    0    0 1080 2400 | Wallpaper BBQ wrapper 5_system#85
10-04 16:55:35.094  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784fce610 | 0100 | RGBA_8888    |    0.0    0.0 1080.0 2400.0 |    0    0 1080 2400 | com.sec.android.app.launcher/com.sec[...]tivities.LauncherActivity$_2453#5567
10-04 16:55:35.094  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784faccd0 | 0100 | RGBA_8888    |    0.0    0.0 1080.0   80.0 |    0    0 1080   80 | StatusBar$_2042#89
10-04 16:55:35.094  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784fe2110 | 0100 | RGBA_8888    |    0.0    0.0   67.0  342.0 | 1013  623 1080  965 | com.sec.android.app.launcher/com.sam[...]e.edge.CocktailBarService$_2453#2631
10-04 16:55:35.094  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784fa5b10 | 0100 | RGBA_8888    |    0.0    0.0 1080.0  144.0 |    0 2256 1080 2400 | NavigationBar0$_2042#82
10-04 16:55:35.094  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784fb6510 | 0140 | RGBA_8888    |    0.0    0.0 1080.0   80.0 |    0    0 1080   80 | ScreenDecorOverlay$_2042#99
10-04 16:55:35.094  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784fd5ed0 | 0140 | RGBA_8888    |    0.0    0
10-04 16:55:35.094  1073  1073 D SurfaceFlinger: .0 1080.0   80.0 |    0 2320 1080 2400 | ScreenDecorOverlayBottom$_2042#100
10-04 16:55:35.094  1073  1073 D SurfaceFlinger: 
10-04 16:55:35.095  1427  9415 V WindowManager: Relayout hash=e458a32, pid=2453, syncId=-1: mAttrs={(0,0)(fillxfill) sim={adjust=resize} layoutInDisplayCutoutMode=shortEdges ty=BASE_APPLICATION fmt=TRANSPARENT wanim=0x10302f2
10-04 16:55:35.095  1427  9415 V WindowManager:   fl=81910100
10-04 16:55:35.095  1427  9415 V WindowManager:   pfl=12008040
10-04 16:55:35.095  1427  9415 V WindowManager:   bhv=DEFAULT
10-04 16:55:35.095  1427  9415 V WindowManager:   fitSides= naviIconColor=0}
10-04 16:55:35.095  2453  2453 I ViewRootImpl@1f7ce54[RecentsActivity]: Relayout returned: old=(0,0,1080,2400) new=(0,0,1080,2400) relayoutAsync=false req=(1080,2400)8 dur=1 res=0x402 s={false 0x0} ch=true seqId=0
10-04 16:55:35.095  2453  2453 I HoneySpace.Launcher: onEnterAnimationComplete
10-04 16:55:35.095  2453  2453 I HoneySpace.TaskListPot: onStop() called
10-04 16:55:35.095  2453  2453 I HoneySpace.TaskListViewModel: isClearAll: 0, 0, false
10-04 16:55:35.095  2453  2453 I HoneySpace.TaskListPot: emptyMessageEnabled : true 0
10-04 16:55:35.095  2453  2453 I HoneySpace.GestureEventController: notifyFinishHomeToRecentAnimation
10-04 16:55:35.095  2453  2453 I HoneySpace.AnimationSession: requestFinishRecentAnimation()
10-04 16:55:35.095  2453  2453 I HoneySpace.AnimationSession: taskListView appeared : false
10-04 16:55:35.095  2453  2453 I HoneySpace.RecentInteraction: sendRecentsAnimationEvent. isStarted: false
10-04 16:55:35.096  2453  2453 I HoneySpace.TaskListViewModel: keepPrevOrientation
10-04 16:55:35.096  2453 15403 I HoneySpace.OverviewEventHandler: onRecentAnimationFinishCallback: false
10-04 16:55:35.096  2453 15403 I HoneySpace.TaskListViewModel: unregisterSensorListener: sensor = {Sensor name="AutoRotation Sensor", vendor="Samsung Electronics", version=16, type=27, maxRange=255.0, resolution=1.0, power=0.001, minDelay=0}
10-04 16:55:35.096   986   986 D Sensors : M requested delay = 20000000, modified delay = 0
10-04 16:55:35.096   986   986 I Sensors : batch(33) - autorotation try to batching with 0
10-04 16:55:35.096  2453  2453 I ViewRootImpl@1f7ce54[RecentsActivity]: stopped(true) old = false
10-04 16:55:35.096  2453  2453 I HoneySpace.RecentsActivity: !@Boot_EBS_D: RecentsActivity.onStop()
10-04 16:55:35.100  1073  1073 I Layer   : id=5570 Destroyed Transition Root: Task=1#5570
10-04 16:55:35.101  1073  1073 I Layer   : id=5572 Destroyed Surface(name=Task=7)/@0x771d38f_transition-leash#5572
10-04 16:55:35.101  1073  1073 I Layer   : id=5571 Destroyed Surface(name=Task=1)/@0x242869_transition-leash#5571
10-04 16:55:35.101  1427  4443 V WindowManager: Relayout Window{e458a32 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity}: viewVisibility=8 req=1080x2400 ty=1 d0
10-04 16:55:35.102  1427  4443 V WindowManager: Relayout hash=e458a32, pid=2453, syncId=-1: mAttrs={(0,0)(fillxfill) sim={adjust=pan} layoutInDisplayCutoutMode=shortEdges ty=BASE_APPLICATION fmt=TRANSPARENT wanim=0x10302f2
10-04 16:55:35.102  1427  4443 V WindowManager:   fl=81910100
10-04 16:55:35.102  1427  4443 V WindowManager:   pfl=12008040
10-04 16:55:35.102  1427  4443 V WindowManager:   bhv=DEFAULT
10-04 16:55:35.102  1427  4443 V WindowManager:   fitSides= naviIconColor=0}
10-04 16:55:35.102  2453  2453 I ViewRootImpl@1f7ce54[RecentsActivity]: Relayout returned: old=(0,0,1080,2400) new=(0,0,1080,2400) relayoutAsync=false req=(1080,2400)8 dur=1 res=0x402 s={false 0x0} ch=false seqId=0
10-04 16:55:35.102  1427  4443 E WindowManager: win=Window{e458a32 u0 com.sec.android.app.launcher/com.android.quickstep.RecentsActivity} destroySurfaces: appStopped=true cleanupOnResume=false win.mWindowRemovalAllowed=false win.mRemoveOnExit=false win.mViewVisibility=8 caller=com.android.server.wm.ActivityRecord.destroySurfaces:6952 com.android.server.wm.ActivityRecord.destroySurfaces:6933 com.android.server.wm.ActivityRecord.activityStopped:7633 com.android.server.wm.ActivityClientController.activityStopped:321 android.app.IActivityClientController$Stub.onTransact:702 com.android.server.wm.ActivityClientController.onTransact:186 android.os.Binder.execTransactInternal:1380 
10-04 16:55:35.103  1427  4443 I WindowManager: Destroying surface Surface(name=com.sec.android.app.launcher/com.android.quickstep.RecentsActivity$_2453)/@0x25841c4 called by com.android.server.wm.WindowStateAnimator.destroySurface:799 com.android.server.wm.WindowStateAnimator.destroySurfaceLocked:472 com.android.server.wm.WindowState.destroySurfaceUnchecked:4201 com.android.server.wm.WindowState.destroySurface:4175 com.android.server.wm.ActivityRecord.destroySurfaces:6952 com.android.server.wm.ActivityRecord.destroySurfaces:6933 com.android.server.wm.ActivityRecord.activityStopped:7633 com.android.server.wm.ActivityClientController.activityStopped:321 
10-04 16:55:35.109  1073  1073 I Layer   : id=5560 removeFromCurrentState com.sec.android.app.launcher/com.android.quickstep.RecentsActivity$_2453#5560 (118)
10-04 16:55:35.109  1073  1073 I SurfaceFlinger: id=5560 Removed com.sec.android.app.launcher/com.android.quickstep.RecentsActivity$_2453#5560 (118)
10-04 16:55:35.117  1073  1073 I Layer   : id=5560 Destroyed com.sec.android.app.launcher/com.android.quickstep.RecentsActivity$_2453#5560
10-04 16:55:35.357  5004  5004 I InputMethodService: removeImeSurface
10-04 16:55:35.357  5004  5004 I InputMethodService: cancelImeSurfaceRemoval: removeCallbacks
10-04 16:55:35.372  1073  1073 I HWComposer: [4633128672291735937] ActiveConfigToHWC, ID : 2
10-04 16:55:35.372   975  1036 I display : Set Affinity config for fps(60) : 2, cpuIDs : 255
10-04 16:55:35.372   975  1036 I display : Set Affinity CPU ID : 0
10-04 16:55:35.372   975  1036 I display : Set Affinity CPU ID : 1
10-04 16:55:35.372   975  1036 I display : Set Affinity CPU ID : 2
10-04 16:55:35.372   975  1036 I display : Set Affinity CPU ID : 3
10-04 16:55:35.372   975  1036 I display : Set Affinity CPU ID : 4
10-04 16:55:35.372   975  1036 I display : Set Affinity CPU ID : 5
10-04 16:55:35.372   975  1036 I display : Set Affinity CPU ID : 6
10-04 16:55:35.372   975  1036 I display : Set Affinity CPU ID : 7
10-04 16:55:35.372   975  1036 I display : Set affinity HWC : 975
10-04 16:55:35.372   975  1036 I display : CPU set : Cluster(0), min_clock(0)
10-04 16:55:35.372   975  1036 I display : CPU set : Cluster(1), min_clock(0)
10-04 16:55:35.372   975  1036 I display : CPU set : Cluster(2), min_clock(0)
10-04 16:55:35.373  1073  1073 I LayerHistory: com.sec.android.app.launcher/com.sec.android.app.launcher.activities.LauncherActivity$_2453#5567 Max (can't resolve refresh rate)
10-04 16:55:35.373  1073  1073 I LayerHistory: StatusBar$_2042#89 voted 0, 0.00 fps
10-04 16:55:35.373  1073  1073 I LayerHistory: NavigationBar0$_2042#82 Max (can't resolve refresh rate)
10-04 16:55:35.373  1073  1073 I SurfaceFlinger: Idle - choose 60.00 Hz
10-04 16:55:35.376   975  1033 I display : doDisplayConfigPostProcess needSetActiveConfig is true - mDesiredConfig: 2
10-04 16:55:35.376   975  1033 I display : setActiveConfig(config=2)
10-04 16:55:35.376   975  1033 I display : next config(2): width=1080 height=2400 period=16666666 Xdpi=422030 Ydpi=423333 groupId=0
10-04 16:55:35.376   975  1033 I display : Current VRR MODE is 3
10-04 16:55:35.377  1073  1212 I VSyncReactor: Current= 120, Period= 60, hwcPeriod= 120
10-04 16:55:35.385  1073  1212 I VSyncReactor: Current= 120, Period= 60, hwcPeriod= 60
10-04 16:55:35.461  1427  1913 I ChimeraAggressivePolicyHandler: executePolicy() - triggerSource: TRIGGER_SOURCE_HOME_IDLE
10-04 16:55:35.462  1427  1913 I ChimeraAggressivePolicyHandler: available memory: 3728756, free memory target: 1894400, quit chimera
10-04 16:55:35.607   994 17131 I HYPER-HAL: [ResourceManager.cpp]removeResource(): [CPUMinFreq] RemoveResource Request ID : 1063642
10-04 16:55:35.613   994 17131 I HYPER-HAL: [RequestManager.cpp]releaseLocked(): Released ID : 1063642
10-04 16:55:35.800   676   676 D io_stats: !@   8,0 r 706552 27994060 w 792823 17794584 d 216628 120718488 f 0 0 iot 796924 0 th 0 0 0 pt 0 inp 0 0 89544.268
10-04 16:55:35.800   676   676 D io_stats: !@ Read_top(KB): earchbox:search(7973) 24 .gms.persistent(3956) 4
10-04 16:55:35.800   676   676 D io_stats: !@ Write_top(KB): earchbox:search(7973) 260 id.diagmonagent(3928) 100 roid.honeyboard(5004) 80
10-04 16:55:35.829  1427  4443 D ActivityManager: force stop from com.android.server.am.ActivityManagerService.forceStopPackage:4564 com.android.server.am.ActivityManagerShellCommand.runForceStop:1710 
10-04 16:55:35.829  1427  4443 I ActivityManager: Force stopping com.companyname.mauiappwindowtest appid=10384 user=0: from pid 17144
10-04 16:55:35.840  1427  4443 I AppsFilter: interaction: PackageSetting{e2d038c com.jvelimited.REDACTED/10364} -> PackageSetting{20943bb com.companyname.mauiappwindowtest/10384} BLOCKED
10-04 16:55:35.840  1427  4443 I AppsFilter: interaction: PackageSetting{f0cc2ea com.devology.REDACTED.app/10378} -> PackageSetting{20943bb com.companyname.mauiappwindowtest/10384} BLOCKED
10-04 16:55:35.840  1427  4443 I AppsFilter: interaction: PackageSetting{c038754 com.sample.crossshoveplugin/10365} -> PackageSetting{20943bb com.companyname.mauiappwindowtest/10384} BLOCKED
10-04 16:55:35.840  1427  4443 I AppsFilter: interaction: PackageSetting{c7f5cc4 com.companyname.virginmaui/10372} -> PackageSetting{20943bb com.companyname.mauiappwindowtest/10384} BLOCKED
10-04 16:55:35.848  1998  1998 D CarrierSvcBindHelper: onHandleForceStop: [com.companyname.mauiappwindowtest]
10-04 16:55:35.848  1998  2036 D EuiccConnector: handleMessage: E msg.what=1
10-04 16:55:35.848  1998  2036 D EuiccConnector: processMsg: AvailableState
10-04 16:55:35.848  1998  2036 D EuiccConnector: processMsg: UnavailableState
10-04 16:55:35.849  1998  1998 D CarrierSvcBindHelper: No carrier app for: 0
10-04 16:55:35.849  1998  2036 D EuiccConnector: transitionTo: destState=AvailableState
10-04 16:55:35.849  1998  1998 D CarrierSvcBindHelper: No carrier app for: 1
10-04 16:55:35.850  1427  1578 D LocationManagerService: package com.companyname.mauiappwindowtest reset
10-04 16:55:35.852  1998  2036 D EuiccConnector: handleMessage: new destination call exit/enter
10-04 16:55:35.852  1998  2036 D EuiccConnector: setupTempStateStackWithStatesToEnter: X mTempStateStackCount=1,curStateInfo: state=UnavailableState,active=true,parent=null
10-04 16:55:35.852  1998  2036 D EuiccConnector: invokeExitMethods: AvailableState
10-04 16:55:35.852  1998  2036 D EuiccConnector: moveTempStackToStateStack: i=0,j=1
10-04 16:55:35.852  1998  2036 D EuiccConnector: moveTempStackToStateStack: X mStateStackTop=1,startingIndex=1,Top=AvailableState
10-04 16:55:35.852  1998  2036 D EuiccConnector: invokeEnterMethods: AvailableState
10-04 16:55:35.852  1998  2036 D EuiccConnector: handleMessage: X
10-04 16:55:35.853  2391  2391 D RegisteredNfcFServicesCache: Service unchanged, not updating
10-04 16:55:36.114  1427  3647 D SemWifiUsabilityStatsMonitor: onWifiUsabilityStats - seqNum 23125, isSameBssidAndFreq true
10-04 16:55:36.114  1427  1930 I SemWifiLinkQualityMonitor: Link stat: 698 / 113 / 1.00 (14) / 1080 / -39.0 || 100.0 : 1080.00 / 0.5 : 1.00 / 0.55 : 0.16 / G (G) || 0.09 ms / 85.73 Mbps / N || 0 / N / 0 Y / 0 Y
10-04 16:55:36.308   994 17132 I HYPER-HAL: [ResourceManager.cpp]removeResource(): [CPUMaxFreq] RemoveResource Request ID : 7846756
10-04 16:55:36.308   994 17132 I HYPER-HAL: [RequestManager.cpp]releaseLocked(): Released ID : 7846756
10-04 16:55:36.315  1052  1241 I EDEN    : [Exynos][EDEN][v1.6.23][SERVICE] processAliveMointorMain:253: Try to check pid=(1004)...
10-04 16:55:36.432  1427  1584 E Watchdog: !@Sync: 2984 heap: 86 / 97 FD: 1028 [2024-10-04 16:55:36.432]
10-04 16:55:36.452  1427  7433 I AfterimageCompensationService: AfcThread mLuminance : 128 , AfpcPeriodCount : 2409 , rotation : 0 , AOD : false
10-04 16:55:36.457  1073  1127 D RenderEngine: [SEC_GC_CMN_SF_EFFECTS] drawLayersInternal,1284, Rendering layer  at index 0
10-04 16:55:36.457  1073  1127 D RenderEngine: [SEC_GC_CMN_SF_EFFECTS] drawLayersInternal,1284, Rendering layer Wallpaper BBQ wrapper 5_system#85 at index 1
10-04 16:55:36.458  1073  1127 D RenderEngine: [SEC_GC_CMN_SF_EFFECTS] drawLayersInternal,1284, Rendering layer com.sec.android.app.launcher/com.sec.android.app.launcher.activities.LauncherActivity$_2453#5567 at index 2
10-04 16:55:36.458  1073  1127 D RenderEngine: [SEC_GC_CMN_SF_EFFECTS] drawLayersInternal,1284, Rendering layer StatusBar$_2042#89 at index 3
10-04 16:55:36.458  1073  1127 D RenderEngine: [SEC_GC_CMN_SF_EFFECTS] drawLayersInternal,1284, Rendering layer com.sec.android.app.launcher/com.samsung.app.honeyspace.edge.CocktailBarService$_2453#2631 at index 4
10-04 16:55:36.458  1073  1127 D RenderEngine: [SEC_GC_CMN_SF_EFFECTS] drawLayersInternal,1284, Rendering layer NavigationBar0$_2042#82 at index 5
10-04 16:55:36.464  1427  7433 D system_server: mAFPC_Read - w = 1080, h = 2400, s = 8, f = 4, s_size = 10444800, luminance = 128, count = 2409, captureOrientation = 0
10-04 16:55:36.479  1427  1890 D UsbStatsMonitor: 0 0 0 0 0 0 0 0 0 0 0 0 2 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 26822070763546
10-04 16:55:36.582   994 17129 I HYPER-HAL: [ResourceManager.cpp]removeResource(): [CPUMinFreq] RemoveResource Request ID : 1060725
10-04 16:55:36.586   994 17129 I HYPER-HAL: [RequestManager.cpp]releaseLocked(): Released ID : 1060725
10-04 16:55:36.990  1427  1791 D InputReader: Btn_touch(11): value=1 when=89545.457884
10-04 16:55:36.990  1427  1791 I InputReader: Touch event's action is 0x0 (id=3, t=0) [pCnt=1, s=0.696 ] when=89545.457884
10-04 16:55:36.991  1427  1790 I InputDispatcher: Delivering touch to (2042): action: 0x4, f=0x0, d=0, 'e6bbee6', t=1 
10-04 16:55:36.992  1427  1790 I InputDispatcher: Delivering touch to (7973): action: 0x4, f=0x0, d=0, 'ee28167', t=1 
10-04 16:55:36.992  1427  1790 I InputDispatcher: Delivering touch to (2453): action: 0x0, f=0x0, d=0, 'fbdaee8', t=1 
10-04 16:55:36.992  1427  1790 D PowerManagerService: [api] userActivityFromNative : touch displayId=0 eventTime=89545457
10-04 16:55:36.993  2042  2042 D SearcleGestureHandler: allowGesture: false
10-04 16:55:36.994  1427  1579 I GestureDetector: obtain mCurrentDownEvent. id: 836209586 caller: com.android.server.wm.SystemGesturesPointerEventListener.onPointerEvent:204 com.android.server.wm.PointerEventDispatcher.onInputEvent:53 android.view.InputEventReceiver.dispatchInputEvent:337 
10-04 16:55:36.994  1427  1579 I GestureDetector: obtain mCurrentDownEvent. id: 836209586 caller: com.android.server.wm.SystemPerformancePointerEventListener.onPointerEvent:89 com.android.server.wm.PointerEventDispatcher.onInputEvent:53 android.view.InputEventReceiver.dispatchInputEvent:337 
10-04 16:55:36.994  2453  2453 I ViewRootImpl@93f9b16[LauncherActivity]: ViewPostIme pointer 0
10-04 16:55:36.995   994 17115 I HYPER-HAL: [RequestManager.cpp]releaseLocked(): Released ID : 2150701
10-04 16:55:36.995  2453  2453 I GestureDetector: obtain mCurrentDownEvent. id: 836209586 caller: com.honeyspace.ui.honeypots.homescreen.presentation.HomeView.dispatchTouchEvent:234 android.view.ViewGroup.dispatchTransformedTouchEvent:3328 android.view.ViewGroup.dispatchTouchEvent:2939 
10-04 16:55:36.995  2453  2453 I HoneySpace.QuickOptionUtil: QuickOption Touch_Event state = -1, eventY = 1329.4922, eventX =470.6543 window Bounds = 2256 containerTouch = null
10-04 16:55:36.995  2453  2453 I HoneySpace.QuickOptionUtil: resetDrag
10-04 16:55:36.995  2453  2453 I HoneySpace.HomeView: findControllerToHandleTouch ev = 0
10-04 16:55:36.995  2453  2453 I HoneySpace.StatusBarTouchController: canInterceptTouch showNotificationPanel : true systemUiProxy.isActive() = true honeyScreenManager.currentHoneyScreen : HOME honeyScreen.currentHoneyState : com.honeyspace.sdk.HomeScreen$Normal@2cd2db2 isChildScrolling.invoke() : false
10-04 16:55:36.996  2453  2453 I HoneySpace.StatusBarTouchController: canInterceptTouch showNotificationPanel : true systemUiProxy.isActive() = true honeyScreenManager.currentHoneyScreen : HOME honeyScreen.currentHoneyState : com.honeyspace.sdk.HomeScreen$Normal@2cd2db2 isChildScrolling.invoke() : false
10-04 16:55:36.996  2453  2453 I HoneySpace.FinderTouchController: onControllerInterceptTouchEvent :: canInterceptTouch() = false, QuickOptionUtil.isShowQuickOption() : false QuickOptionUtil.isDragging : false
10-04 16:55:36.996  2453  2453 I HoneySpace.PageEditTouchController: onControllerInterceptTouchEvent, isInProgress = false
10-04 16:55:36.996  2453  2453 I HoneySpace.WorkspaceFastRecyclerView: dispatchTouchEvent() event.action=0
10-04 16:55:37.001  1073  1073 I HWComposer: [4633128672291735937] ActiveConfigToHWC, ID : 0
10-04 16:55:37.001   975  1036 I display : Set Affinity config for fps(120) : 0, cpuIDs : 255
10-04 16:55:37.001   975  1036 I display : Set Affinity CPU ID : 0
10-04 16:55:37.001   975  1036 I display : Set Affinity CPU ID : 1
10-04 16:55:37.001   975  1036 I display : Set Affinity CPU ID : 2
10-04 16:55:37.001   975  1036 I display : Set Affinity CPU ID : 3
10-04 16:55:37.002   975  1036 I display : Set Affinity CPU ID : 4
10-04 16:55:37.002   975  1036 I display : Set Affinity CPU ID : 5
10-04 16:55:37.002   975  1036 I display : Set Affinity CPU ID : 6
10-04 16:55:37.002   975  1036 I display : Set Affinity CPU ID : 7
10-04 16:55:37.002   975  1036 I display : Set affinity HWC : 975
10-04 16:55:37.002   975  1036 I display : CPU set : Cluster(0), min_clock(0)
10-04 16:55:37.002   975  1036 I display : CPU set : Cluster(1), min_clock(0)
10-04 16:55:37.002   975  1036 I display : CPU set : Cluster(2), min_clock(0)
10-04 16:55:37.002  1073  1073 I SurfaceFlinger: Touch Boost - choose 120.00 Hz
10-04 16:55:37.008   975  1033 I display : doDisplayConfigPostProcess needSetActiveConfig is true - mDesiredConfig: 0
10-04 16:55:37.008   975  1033 I display : setActiveConfig(config=0)
10-04 16:55:37.008   975  1033 I display : next config(0): width=1080 height=2400 period=8333333 Xdpi=422030 Ydpi=423333 groupId=0
10-04 16:55:37.008   975  1033 I display : Current VRR MODE is 3
10-04 16:55:37.008  1073  1212 I VSyncReactor: Current= 60, Period= 120, hwcPeriod= 60
10-04 16:55:37.011  1427  1579 I GestureDetector: obtain mCurrentMotionEventRaw. action: 2 id: 140735680
10-04 16:55:37.012  1427  1579 I GestureDetector: obtain mCurrentMotionEventRaw. action: 2 id: 140735680
10-04 16:55:37.024   975  1033 I display : config 16666666, desired 8333333
10-04 16:55:37.024  1073  1212 I VSyncReactor: Current= 60, Period= 120, hwcPeriod= 60
10-04 16:55:37.036  2453  2453 I GestureDetector: obtain mCurrentMotionEventRaw. action: 2 id: 140735680
10-04 16:55:37.036  2453  2453 I HoneySpace.HomeView: findControllerToHandleTouch ev = 2
10-04 16:55:37.036  2453  2453 I HoneySpace.StatusBarTouchController: canInterceptTouch showNotificationPanel : true systemUiProxy.isActive() = true honeyScreenManager.currentHoneyScreen : HOME honeyScreen.currentHoneyState : com.honeyspace.sdk.HomeScreen$Normal@2cd2db2 isChildScrolling.invoke() : false
10-04 16:55:37.036  2453  2453 I HoneySpace.FinderTouchController: onControllerInterceptTouchEvent :: canInterceptTouch() = false, QuickOptionUtil.isShowQuickOption() : false QuickOptionUtil.isDragging : false
10-04 16:55:37.036  2453  2453 I HoneySpace.PageEditTouchController: onControllerInterceptTouchEvent, isInProgress = false
10-04 16:55:37.041  1073  1212 I VSyncReactor: Current= 60, Period= 120, hwcPeriod= 120
10-04 16:55:37.050  2453  2453 I HoneySpace.HomeView: findControllerToHandleTouch ev = 2
10-04 16:55:37.050  2453  2453 I HoneySpace.StatusBarTouchController: canInterceptTouch showNotificationPanel : true systemUiProxy.isActive() = true honeyScreenManager.currentHoneyScreen : HOME honeyScreen.currentHoneyState : com.honeyspace.sdk.HomeScreen$Normal@2cd2db2 isChildScrolling.invoke() : false
10-04 16:55:37.050  2453  2453 I HoneySpace.FinderTouchController: onControllerInterceptTouchEvent :: canInterceptTouch() = false, QuickOptionUtil.isShowQuickOption() : false QuickOptionUtil.isDragging : false
10-04 16:55:37.050  2453  2453 I HoneySpace.PageEditTouchController: onControllerInterceptTouchEvent, isInProgress = false
10-04 16:55:37.058  2453  2453 I HoneySpace.HomeView: findControllerToHandleTouch ev = 2
10-04 16:55:37.058  2453  2453 I HoneySpace.StatusBarTouchController: canInterceptTouch showNotificationPanel : true systemUiProxy.isActive() = true honeyScreenManager.currentHoneyScreen : HOME honeyScreen.currentHoneyState : com.honeyspace.sdk.HomeScreen$Normal@2cd2db2 isChildScrolling.invoke() : false
10-04 16:55:37.058  2453  2453 I HoneySpace.FinderTouchController: onControllerInterceptTouchEvent :: canInterceptTouch() = false, QuickOptionUtil.isShowQuickOption() : false QuickOptionUtil.isDragging : false
10-04 16:55:37.058  2453  2453 I HoneySpace.PageEditTouchController: onControllerInterceptTouchEvent, isInProgress = false
10-04 16:55:37.066  2453  2453 I HoneySpace.HomeView: findControllerToHandleTouch ev = 2
10-04 16:55:37.066  2453  2453 I HoneySpace.StatusBarTouchController: canInterceptTouch showNotificationPanel : true systemUiProxy.isActive() = true honeyScreenManager.currentHoneyScreen : HOME honeyScreen.currentHoneyState : com.honeyspace.sdk.HomeScreen$Normal@2cd2db2 isChildScrolling.invoke() : false
10-04 16:55:37.066  2453  2453 I HoneySpace.FinderTouchController: onControllerInterceptTouchEvent :: canInterceptTouch() = false, QuickOptionUtil.isShowQuickOption() : false QuickOptionUtil.isDragging : false
10-04 16:55:37.066  2453  2453 I HoneySpace.TouchDirectionDetector: displacementComponent = -28.710938
10-04 16:55:37.066  2453  2453 I HoneySpace.TouchDirectionDetector: canScrollNegative direction = true
10-04 16:55:37.066  2453  2453 I HoneySpace.TouchDirectionDetector: direction.isNegative(displacement) = false
10-04 16:55:37.066  2453  2453 I HoneySpace.TouchDirectionDetector: canScrollPositive direction = true
10-04 16:55:37.066  2453  2453 I HoneySpace.TouchDirectionDetector: direction.isPositive(displacement) = true
10-04 16:55:37.066  2453  2453 I HoneySpace.HomeAppsTouchController: initVelocityTracker
10-04 16:55:37.067  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.067  2453  2453 I HoneySpace.BackgroundManagerImpl: updateProperties[ch=194873307], com.honeyspace.sdk.AppScreen$Normal@5a322a3, true
10-04 16:55:37.067  2453  2453 I HoneySpace.BackgroundManagerImpl: updateDimColor[ch=194873307]
10-04 16:55:37.067  2453  2453 I HoneySpace.BackgroundManagerImpl: updated the scrimView's end color : com.honeyspace.sdk.AppScreen$Normal@5a322a3
10-04 16:55:37.067  2453  2453 I HoneySpace.BackgroundManagerImpl: updateLastDimAndBlur[ch=194873307]dim[0.0 -> 0.0] ,wBlur[2.0 -> 0.0
10-04 16:55:37.067  2453  2453 I HoneySpace.BackgroundManagerImpl: updateLastState[194873307]: com.honeyspace.sdk.HomeScreen$Normal@2cd2db2 -> com.honeyspace.sdk.AppScreen$Normal@5a322a3
10-04 16:55:37.067  2453  2453 I HoneySpace.AppscreenPot: onPlayStarted com.honeyspace.sdk.AppScreen$Normal@5a322a3
10-04 16:55:37.067  2453  2453 I HoneySpace.HoneyScreenManagerImpl: start state transition: ra.g0@b64a855
10-04 16:55:37.067  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.068  2453  2453 I HoneySpace.AppscreenPot: hideFreeFormButton()
10-04 16:55:37.068  2453  2453 I HoneySpace.WhiteBgColorUpdater: changeWhiteBgSystemUIColor, DecorView@5240b42[LauncherActivity], type = 2,supportWhiteBg = false, forced = false, fromHoneyType = appscreen
10-04 16:55:37.068  2453  2453 I HoneySpace.WhiteBgColorChanger: changeStatusBarColor, view = DecorView@5240b42[LauncherActivity], false
10-04 16:55:37.068  2453  2453 I HoneySpace.WhiteBgColorUpdater: changeWhiteBgSystemUIColor, DecorView@5240b42[LauncherActivity], type = 3,supportWhiteBg = false, forced = false, fromHoneyType = appscreen
10-04 16:55:37.068  2453  2453 I HoneySpace.WhiteBgColorChanger: changeNavigationBarColor, view = DecorView@5240b42[LauncherActivity], false
10-04 16:55:37.068  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 10, maxY = 241.1958
10-04 16:55:37.069  2453  2453 I HoneySpace.HomeView: founded touch controller : zb.c@c48cf64
10-04 16:55:37.069  2453  2453 I HoneySpace.WorkspaceFastRecyclerView: dispatchTouchEvent() screenManager.isOnStateTransition=true, suppressLayout=false
10-04 16:55:37.069  2453  2453 I HoneySpace.WorkspaceFastRecyclerView: onInterceptTouchEvent() return by isOnStateTransition
10-04 16:55:37.074  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.075  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.075  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.075  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 14, maxY = 239.96396
10-04 16:55:37.083  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.083  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=10, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=0.212, rect=[0, 0, 1080, 2400]
10-04 16:55:37.083  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.083  1073  1073 D SurfaceFlinger: GPIS:: requestGpisForBlur
10-04 16:55:37.083  1073  3020 D NativeSemDvfsManager: acquire:: timeout = 2000 mIsAcquired = 1  mTagName : SurfaceFlinger 
10-04 16:55:37.083  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.083  1073  3020 E NativeCustomFrequencyManager: [NativeCFMS] BpCustomFrequencyManager::acquire()
10-04 16:55:37.084   994  1071 I HYPER-HAL: [RequestManager.cpp]acquire(): Acquired ID : 2150701  [1073 / 1000]    HINT : SF_GPU_MINLOCK    list : [TIMEOUT / 2000] 
10-04 16:55:37.084  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 18, maxY = 238.32013
10-04 16:55:37.091  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=14, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=0.282, rect=[0, 0, 1080, 2400]
10-04 16:55:37.091  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.092  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.092  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.092  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 24, maxY = 236.30405
10-04 16:55:37.099  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=18, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=0.376, rect=[0, 0, 1080, 2400]
10-04 16:55:37.100  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.100  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.100  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.100  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 31, maxY = 233.96394
10-04 16:55:37.108  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=24, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=0.490, rect=[0, 0, 1080, 2400]
10-04 16:55:37.108  2453  2453 W Choreographer: Frame time is 0.030424 ms in the future!  Check that graphics HAL is generating vsync timestamps using the correct timebase.
10-04 16:55:37.108  2042  2042 W Choreographer: Frame time is 0.020308 ms in the future!  Check that graphics HAL is generating vsync timestamps using the correct timebase.
10-04 16:55:37.108  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.108  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.109  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.109  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 38, maxY = 231.25027
10-04 16:55:37.116  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=31, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=0.624, rect=[0, 0, 1080, 2400]
10-04 16:55:37.117  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.117  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.117  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.117  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 46, maxY = 228.49055
10-04 16:55:37.125  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=38, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=0.776, rect=[0, 0, 1080, 2400]
10-04 16:55:37.125  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.125  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.126  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.126  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 55, maxY = 225.3121
10-04 16:55:37.133  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=46, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=0.933, rect=[0, 0, 1080, 2400]
10-04 16:55:37.133  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.134  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.134  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.135  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 64, maxY = 222.28271
10-04 16:55:37.142  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=55, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=1.114, rect=[0, 0, 1080, 2400]
10-04 16:55:37.142  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.142  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.142  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.143  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 72, maxY = 219.4086
10-04 16:55:37.150  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=64, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=1.282, rect=[0, 0, 1080, 2400]
10-04 16:55:37.150  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.150  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.151  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.151  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 81, maxY = 216.30547
10-04 16:55:37.158  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=72, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=1.447, rect=[0, 0, 1080, 2400]
10-04 16:55:37.159  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.159  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.161  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.162  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 89, maxY = 213.43057
10-04 16:55:37.167  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=81, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=1.624, rect=[0, 0, 1080, 2400]
10-04 16:55:37.167  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.167  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.167  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.167  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 97, maxY = 210.4043
10-04 16:55:37.175  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=89, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=1.784, rect=[0, 0, 1080, 2400]
10-04 16:55:37.175  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.176  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.176  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.176  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 106, maxY = 207.37646
10-04 16:55:37.183  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=97, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=1.957, rect=[0, 0, 1080, 2400]
10-04 16:55:37.184  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.184  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.184  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.184  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 115, maxY = 204.27177
10-04 16:55:37.192  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=106, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=2.129, rect=[0, 0, 1080, 2400]
10-04 16:55:37.192  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.192  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.193  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.193  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 123, maxY = 201.32004
10-04 16:55:37.200  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=115, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=2.302, rect=[0, 0, 1080, 2400]
10-04 16:55:37.200  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.201  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.201  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.201  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 132, maxY = 198.0624
10-04 16:55:37.208  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=123, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=2.471, rect=[0, 0, 1080, 2400]
10-04 16:55:37.209  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.209  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.209  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.209  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 141, maxY = 195.03223
10-04 16:55:37.217  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=132, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=2.655, rect=[0, 0, 1080, 2400]
10-04 16:55:37.217  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.217  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.218  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.218  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 149, maxY = 192.08127
10-04 16:55:37.225  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=141, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=2.827, rect=[0, 0, 1080, 2400]
10-04 16:55:37.225  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.226  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.226  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.226  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.234  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=149, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=2.992, rect=[0, 0, 1080, 2400]
10-04 16:55:37.234  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.234  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.234  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.235  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.242  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=3.173, rect=[0, 0, 1080, 2400]
10-04 16:55:37.242  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.242  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.245  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.245  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.250  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=3.345, rect=[0, 0, 1080, 2400]
10-04 16:55:37.251  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.251  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.251  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.251  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.259  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=3.514, rect=[0, 0, 1080, 2400]
10-04 16:55:37.259  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.259  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.260  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.260  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.267  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=3.682, rect=[0, 0, 1080, 2400]
10-04 16:55:37.267  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.267  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.268  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.268  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.275  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=3.859, rect=[0, 0, 1080, 2400]
10-04 16:55:37.276  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.276  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.277  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.277  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.284  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=4.031, rect=[0, 0, 1080, 2400]
10-04 16:55:37.284  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.284  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.285  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.285  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.292  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=4.208, rect=[0, 0, 1080, 2400]
10-04 16:55:37.292  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.293  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.293  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.293  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.301  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=4.373, rect=[0, 0, 1080, 2400]
10-04 16:55:37.301  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.301  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.301  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.302  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.309  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=4.537, rect=[0, 0, 1080, 2400]
10-04 16:55:37.309  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.309  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.310  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.310  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.317  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=4.694, rect=[0, 0, 1080, 2400]
10-04 16:55:37.317  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.318  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.318  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.318  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.326  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=4.855, rect=[0, 0, 1080, 2400]
10-04 16:55:37.326  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.326  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.326  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.327  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.334  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=5.000, rect=[0, 0, 1080, 2400]
10-04 16:55:37.334  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.334  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.335  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.335  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.342  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=5.141, rect=[0, 0, 1080, 2400]
10-04 16:55:37.343  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.343  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.343  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.344  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.351  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=5.286, rect=[0, 0, 1080, 2400]
10-04 16:55:37.351  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.351  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.351  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.352  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.359  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=5.420, rect=[0, 0, 1080, 2400]
10-04 16:55:37.359  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.360  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.360  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.360  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.367  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=5.545, rect=[0, 0, 1080, 2400]
10-04 16:55:37.368  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.368  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.368  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.369  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.376  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=5.663, rect=[0, 0, 1080, 2400]
10-04 16:55:37.376  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.376  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.377  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.377  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.384  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=5.784, rect=[0, 0, 1080, 2400]
10-04 16:55:37.384  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.385  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.385  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.385  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgress: com.honeyspace.sdk.AppScreen$Normal@5a322a3, p=1.0, ch=194873307, open=true
10-04 16:55:37.385  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToScrimView[ch=194873307]: progress = 1.0, dim = 0.0, currentDimAlpha={204279839=0.0, 194873307=0.0}
10-04 16:55:37.386  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.386  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToBlurView[ch=194873307, st =  com.honeyspace.sdk.AppScreen$Normal@5a322a3, progress = 1.0, wb= 2.0]
10-04 16:55:37.392  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=5.922, rect=[0, 0, 1080, 2400]
10-04 16:55:37.393  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.393  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.394  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.394  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgress: com.honeyspace.sdk.AppScreen$Normal@5a322a3, p=1.0, ch=194873307, open=true
10-04 16:55:37.394  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToScrimView[ch=194873307]: progress = 1.0, dim = 0.0, currentDimAlpha={204279839=0.0, 194873307=0.0}
10-04 16:55:37.394  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.394  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToBlurView[ch=194873307, st =  com.honeyspace.sdk.AppScreen$Normal@5a322a3, progress = 1.0, wb= 2.0]
10-04 16:55:37.401  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=6.000, rect=[0, 0, 1080, 2400]
10-04 16:55:37.401  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.401  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.402  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.402  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgress: com.honeyspace.sdk.AppScreen$Normal@5a322a3, p=1.0, ch=194873307, open=true
10-04 16:55:37.402  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToScrimView[ch=194873307]: progress = 1.0, dim = 0.0, currentDimAlpha={204279839=0.0, 194873307=0.0}
10-04 16:55:37.402  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.402  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToBlurView[ch=194873307, st =  com.honeyspace.sdk.AppScreen$Normal@5a322a3, progress = 1.0, wb= 2.0]
10-04 16:55:37.404  1427  1791 D InputReader: Btn_touch(11): value=0 when=89545.872920
10-04 16:55:37.404  1427  1791 I InputReader: Touch event's action is 0x1 (id=3, t=0) [pCnt=1, s=] when=89545.872920
10-04 16:55:37.404  1427  1790 I InputDispatcher: Delivering touch to (2453): action: 0x1, f=0x0, d=0, 'fbdaee8', t=1 
10-04 16:55:37.404  2453  2453 I HoneySpace.HomeView: onTouch event = 2, Touch controller: zb.c@c48cf64
10-04 16:55:37.404  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.405  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.405  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgress: com.honeyspace.sdk.AppScreen$Normal@5a322a3, p=1.0, ch=194873307, open=true
10-04 16:55:37.405  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToScrimView[ch=194873307]: progress = 1.0, dim = 0.0, currentDimAlpha={204279839=0.0, 194873307=0.0}
10-04 16:55:37.405  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.405  1427  1427 I SemDvfsHyPerManager: acquire hyper - SMOOTH_SCROLL/1427@23, type = -999
10-04 16:55:37.405  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToBlurView[ch=194873307, st =  com.honeyspace.sdk.AppScreen$Normal@5a322a3, progress = 1.0, wb= 2.0]
10-04 16:55:37.405  2453  2453 I ViewRootImpl@93f9b16[LauncherActivity]: ViewPostIme pointer 1
10-04 16:55:37.405  2453  2453 I HoneySpace.HomeView: onTouch event = 1, Touch controller: zb.c@c48cf64
10-04 16:55:37.405  2453  2453 I HoneySpace.HomeAppsTouchController: Swipe Pos(HomeAppsTouchController) : (0.035889, 0)-(0.047510, 9)-(0.063018, 8)-(0.082037, 9)-(0.104114, 8)-(0.129714, 9)-(0.155750, 8)-(0.185735, 8)-(0.214314, 9)-(0.241428, 8)-(0.270703, 9)-(0.297825, 8)-(0.326375, 8)-(0.354939, 9)-(0.384229, 8)-(0.412075, 8)-(0.442808, 9)-(0.471394, 8)-(0.499233, 8)-(0.529241, 9)-(0.557820, 8)-(0.585659, 9)-(0.614216, 8)-(0.643506, 8)-(0.672078, 9)-(0.701367, 8)-(0.729214, 8)-(0.756321, 9)-(0.782695, 8)-(0.809788, 8)-(0.833987, 9)-(0.857432, 8)-(0.881594, 9)-(0.903589, 8)-(0.924836, 8)-(0.944337, 9)-(0.964104, 8)-(0.987401, 8)-(1.000000, 9)-(1.000000, 8)-(1.000000, 8)-(1.000000, 4)-End
10-04 16:55:37.405  2453  2453 I HoneySpace.HoneyScreenManagerImpl: cancel transitionAnimator
10-04 16:55:37.406  2453  2453 I HoneySpace.AppscreenPot: show() honeyState: com.honeyspace.sdk.AppScreen$Normal@5a322a3, r8.n.gotoScreenWithAnimation(Unknown Source:397)
10-04 16:55:37.406  2453  2453 I HoneySpace.SPayHandler: currentIndex : 0, defaultIndex : 0
10-04 16:55:37.406  1427  1427 I SemDvfsHyPerManager: acquire hyper - GESTURE_DETECTED_HRR/1427@29, type = -999
10-04 16:55:37.406   994  1071 I HYPER-HAL: [RequestManager.cpp]acquire(): Acquired ID : 1051998  [1427 / 23]    HINT : SMOOTH_SCROLL    list : 
10-04 16:55:37.406  2453  2453 I HoneySpace.HoneyScreenManagerImpl: show APPS
10-04 16:55:37.406  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgress: com.honeyspace.sdk.AppScreen$Normal@5a322a3, p=1.0, ch=194873307, open=true
10-04 16:55:37.406  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToScrimView[ch=194873307]: progress = 1.0, dim = 0.0, currentDimAlpha={204279839=0.0, 194873307=0.0}
10-04 16:55:37.406  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.406  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToBlurView[ch=194873307, st =  com.honeyspace.sdk.AppScreen$Normal@5a322a3, progress = 1.0, wb= 2.0]
10-04 16:55:37.406  1427  1427 I SemDvfsHyPerManager: acquire hyper - GESTURE_DETECTED_HRR/1427@29, type = -999
10-04 16:55:37.406  2453  2453 I HoneySpace.HomeAppsTouchController: recycleVelocityTracker
10-04 16:55:37.406   994  1071 I HYPER-HAL: [ResourceManager.cpp]updateResource(): [CPUMinFreq] UpdateResource Request ID : 1051998    Value : 1352000
10-04 16:55:37.406  2453  2562 I HoneySpace.SALoggingUtils: SA Logging screenID: 101 eventId: 1010 detail: {det=0} value: -1
10-04 16:55:37.406  2453 15403 I HoneySpace.SPayHandler: updateSpayHandler, show = false, defaultPage = true
10-04 16:55:37.407   994  1071 I HYPER-HAL: [ResourceManager.cpp]removeResource(): [CPUMinFreq] RemoveResource Request ID : 1051998
10-04 16:55:37.407   994  1071 I HYPER-HAL: [RequestManager.cpp]releaseLocked(): Released ID : 1051998
10-04 16:55:37.407   994  1071 I HYPER-HAL: [RequestManager.cpp]acquire(): Acquired ID : 1060725  [1427 / 29]    HINT : GESTURE_DETECTED_HRR    list : [TIMEOUT / 1235] 
10-04 16:55:37.408   994  1071 I HYPER-HAL: [ResourceManager.cpp]updateResource(): [CPUMinFreq] UpdateResource Request ID : 1060725    Value : 1248000
10-04 16:55:37.408   994  1071 I HYPER-HAL: [RequestManager.cpp]acquire(): Acquired ID : 1060725  [1427 / 29]    HINT : GESTURE_DETECTED_HRR    list : [TIMEOUT / 1235] 
10-04 16:55:37.408   994  1071 I HYPER-HAL: [ResourceManager.cpp]updateResource(): [CPUMinFreq] UpdateResource Request ID : 1060725    Value : 1248000
10-04 16:55:37.409  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=6.000, rect=[0, 0, 1080, 2400]
10-04 16:55:37.410  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgress: com.honeyspace.sdk.AppScreen$Normal@5a322a3, p=1.0, ch=194873307, open=true
10-04 16:55:37.410  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToScrimView[ch=194873307]: progress = 1.0, dim = 0.0, currentDimAlpha={204279839=0.0, 194873307=0.0}
10-04 16:55:37.410  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.410  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToBlurView[ch=194873307, st =  com.honeyspace.sdk.AppScreen$Normal@5a322a3, progress = 1.0, wb= 2.0]
10-04 16:55:37.418  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=6.000, rect=[0, 0, 1080, 2400]
10-04 16:55:37.418  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgress: com.honeyspace.sdk.AppScreen$Normal@5a322a3, p=1.0, ch=194873307, open=true
10-04 16:55:37.418  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToScrimView[ch=194873307]: progress = 1.0, dim = 0.0, currentDimAlpha={204279839=0.0, 194873307=0.0}
10-04 16:55:37.418  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.418  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToBlurView[ch=194873307, st =  com.honeyspace.sdk.AppScreen$Normal@5a322a3, progress = 1.0, wb= 2.0]
10-04 16:55:37.426  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=6.000, rect=[0, 0, 1080, 2400]
10-04 16:55:37.426  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgress: com.honeyspace.sdk.AppScreen$Normal@5a322a3, p=1.0, ch=194873307, open=true
10-04 16:55:37.426  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToScrimView[ch=194873307]: progress = 1.0, dim = 0.0, currentDimAlpha={204279839=0.0, 194873307=0.0}
10-04 16:55:37.426  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.427  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToBlurView[ch=194873307, st =  com.honeyspace.sdk.AppScreen$Normal@5a322a3, progress = 1.0, wb= 2.0]
10-04 16:55:37.434  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=6.000, rect=[0, 0, 1080, 2400]
10-04 16:55:37.435  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgress: com.honeyspace.sdk.AppScreen$Normal@5a322a3, p=1.0, ch=194873307, open=true
10-04 16:55:37.435  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToScrimView[ch=194873307]: progress = 1.0, dim = 0.0, currentDimAlpha={204279839=0.0, 194873307=0.0}
10-04 16:55:37.435  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.435  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToBlurView[ch=194873307, st =  com.honeyspace.sdk.AppScreen$Normal@5a322a3, progress = 1.0, wb= 2.0]
10-04 16:55:37.443  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=6.000, rect=[0, 0, 1080, 2400]
10-04 16:55:37.443  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgress: com.honeyspace.sdk.AppScreen$Normal@5a322a3, p=1.0, ch=194873307, open=true
10-04 16:55:37.443  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToScrimView[ch=194873307]: progress = 1.0, dim = 0.0, currentDimAlpha={204279839=0.0, 194873307=0.0}
10-04 16:55:37.443  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.443  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToBlurView[ch=194873307, st =  com.honeyspace.sdk.AppScreen$Normal@5a322a3, progress = 1.0, wb= 2.0]
10-04 16:55:37.451  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=6.000, rect=[0, 0, 1080, 2400]
10-04 16:55:37.451  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgress: com.honeyspace.sdk.AppScreen$Normal@5a322a3, p=1.0, ch=194873307, open=true
10-04 16:55:37.451  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToScrimView[ch=194873307]: progress = 1.0, dim = 0.0, currentDimAlpha={204279839=0.0, 194873307=0.0}
10-04 16:55:37.451  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.452  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToBlurView[ch=194873307, st =  com.honeyspace.sdk.AppScreen$Normal@5a322a3, progress = 1.0, wb= 2.0]
10-04 16:55:37.459  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=6.000, rect=[0, 0, 1080, 2400]
10-04 16:55:37.460  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgress: com.honeyspace.sdk.AppScreen$Normal@5a322a3, p=1.0, ch=194873307, open=true
10-04 16:55:37.460  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToScrimView[ch=194873307]: progress = 1.0, dim = 0.0, currentDimAlpha={204279839=0.0, 194873307=0.0}
10-04 16:55:37.460  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.460  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToBlurView[ch=194873307, st =  com.honeyspace.sdk.AppScreen$Normal@5a322a3, progress = 1.0, wb= 2.0]
10-04 16:55:37.468  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=6.000, rect=[0, 0, 1080, 2400]
10-04 16:55:37.468  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgress: com.honeyspace.sdk.AppScreen$Normal@5a322a3, p=1.0, ch=194873307, open=true
10-04 16:55:37.468  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToScrimView[ch=194873307]: progress = 1.0, dim = 0.0, currentDimAlpha={204279839=0.0, 194873307=0.0}
10-04 16:55:37.468  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.468  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToBlurView[ch=194873307, st =  com.honeyspace.sdk.AppScreen$Normal@5a322a3, progress = 1.0, wb= 2.0]
10-04 16:55:37.476  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=6.000, rect=[0, 0, 1080, 2400]
10-04 16:55:37.476  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgress: com.honeyspace.sdk.AppScreen$Normal@5a322a3, p=1.0, ch=194873307, open=true
10-04 16:55:37.477  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToScrimView[ch=194873307]: progress = 1.0, dim = 0.0, currentDimAlpha={204279839=0.0, 194873307=0.0}
10-04 16:55:37.477  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.478  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToBlurView[ch=194873307, st =  com.honeyspace.sdk.AppScreen$Normal@5a322a3, progress = 1.0, wb= 2.0]
10-04 16:55:37.484  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=6.000, rect=[0, 0, 1080, 2400]
10-04 16:55:37.485  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgress: com.honeyspace.sdk.AppScreen$Normal@5a322a3, p=1.0, ch=194873307, open=true
10-04 16:55:37.485  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToScrimView[ch=194873307]: progress = 1.0, dim = 0.0, currentDimAlpha={204279839=0.0, 194873307=0.0}
10-04 16:55:37.485  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.486  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToBlurView[ch=194873307, st =  com.honeyspace.sdk.AppScreen$Normal@5a322a3, progress = 1.0, wb= 2.0]
10-04 16:55:37.493  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=6.000, rect=[0, 0, 1080, 2400]
10-04 16:55:37.493  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgress: com.honeyspace.sdk.AppScreen$Normal@5a322a3, p=1.0, ch=194873307, open=true
10-04 16:55:37.493  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToScrimView[ch=194873307]: progress = 1.0, dim = 0.0, currentDimAlpha={204279839=0.0, 194873307=0.0}
10-04 16:55:37.493  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.495  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToBlurView[ch=194873307, st =  com.honeyspace.sdk.AppScreen$Normal@5a322a3, progress = 1.0, wb= 2.0]
10-04 16:55:37.501  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=6.000, rect=[0, 0, 1080, 2400]
10-04 16:55:37.502  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgress: com.honeyspace.sdk.AppScreen$Normal@5a322a3, p=1.0, ch=194873307, open=true
10-04 16:55:37.502  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToScrimView[ch=194873307]: progress = 1.0, dim = 0.0, currentDimAlpha={204279839=0.0, 194873307=0.0}
10-04 16:55:37.502  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.502  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToBlurView[ch=194873307, st =  com.honeyspace.sdk.AppScreen$Normal@5a322a3, progress = 1.0, wb= 2.0]
10-04 16:55:37.510  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=6.000, rect=[0, 0, 1080, 2400]
10-04 16:55:37.510  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgress: com.honeyspace.sdk.AppScreen$Normal@5a322a3, p=1.0, ch=194873307, open=true
10-04 16:55:37.510  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToScrimView[ch=194873307]: progress = 1.0, dim = 0.0, currentDimAlpha={204279839=0.0, 194873307=0.0}
10-04 16:55:37.510  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.510  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToBlurView[ch=194873307, st =  com.honeyspace.sdk.AppScreen$Normal@5a322a3, progress = 1.0, wb= 2.0]
10-04 16:55:37.518  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=6.000, rect=[0, 0, 1080, 2400]
10-04 16:55:37.518  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgress: com.honeyspace.sdk.AppScreen$Normal@5a322a3, p=1.0, ch=194873307, open=true
10-04 16:55:37.518  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToScrimView[ch=194873307]: progress = 1.0, dim = 0.0, currentDimAlpha={204279839=0.0, 194873307=0.0}
10-04 16:55:37.518  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.519  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToBlurView[ch=194873307, st =  com.honeyspace.sdk.AppScreen$Normal@5a322a3, progress = 1.0, wb= 2.0]
10-04 16:55:37.526  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=6.000, rect=[0, 0, 1080, 2400]
10-04 16:55:37.527  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgress: com.honeyspace.sdk.AppScreen$Normal@5a322a3, p=1.0, ch=194873307, open=true
10-04 16:55:37.527  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToScrimView[ch=194873307]: progress = 1.0, dim = 0.0, currentDimAlpha={204279839=0.0, 194873307=0.0}
10-04 16:55:37.527  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.527  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToBlurView[ch=194873307, st =  com.honeyspace.sdk.AppScreen$Normal@5a322a3, progress = 1.0, wb= 2.0]
10-04 16:55:37.535  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=6.000, rect=[0, 0, 1080, 2400]
10-04 16:55:37.535  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgress: com.honeyspace.sdk.AppScreen$Normal@5a322a3, p=1.0, ch=194873307, open=true
10-04 16:55:37.535  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToScrimView[ch=194873307]: progress = 1.0, dim = 0.0, currentDimAlpha={204279839=0.0, 194873307=0.0}
10-04 16:55:37.535  2453  2453 I HoneySpace.WallpaperBlurView: apply(): radius = 150, maxY = 192.0
10-04 16:55:37.535  2453  2453 I HoneySpace.BackgroundManagerImpl: setProgressToBlurView[ch=194873307, st =  com.honeyspace.sdk.AppScreen$Normal@5a322a3, progress = 1.0, wb= 2.0]
10-04 16:55:37.536  2453  2453 I HoneySpace.HoneyScreenManagerImpl: gotoScreenWithAnimation shouldOpen doOnEnd: APPS
10-04 16:55:37.536  2453  2453 I HoneySpace.HoneyScreenManagerImpl: Hide HOME
10-04 16:55:37.536  2453  2453 I HoneySpace.ContentsAnimator: end call
10-04 16:55:37.536  2453  2453 I HoneySpace.HomescreenPot: hide screenShow: true
10-04 16:55:37.536  2453  2453 I HoneySpace.WorkspaceFastRecyclerView: setCurrentPage() currentPage: 0, xb.n0.hide(Unknown Source:88)
10-04 16:55:37.536  2453  2453 I HoneySpace.WorkspaceFastRecyclerViewModel: updateNextPage 0
10-04 16:55:37.536  2453  2453 I HoneySpace.SPayHandler: same state show=false currentDefaultPage=true
10-04 16:55:37.536  2453  2453 I HoneySpace.BackgroundManagerImpl: checkAndUpdateBackgroundEffect: com.honeyspace.sdk.AppScreen$Normal@5a322a3, ch=194873307, forceApply=false
10-04 16:55:37.543  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=6.000, rect=[0, 0, 1080, 2400]
10-04 16:55:37.551  1073  1073 D Layer   : [SEC_SF_EFFECTS] setBlurRegions LauncherActivity$_2453#5567 ## {radius=150, cornerRadii=[0.000, 0.000, 0.000, 0.000], alpha=6.000, rect=[0, 0, 1080, 2400]
10-04 16:55:37.801   676   676 D io_stats: !@   8,0 r 706554 27994068 w 792853 17795104 d 216628 120718488 f 0 0 iot 796948 0 th 0 0 0 pt 0 inp 0 0 89546.270
10-04 16:55:37.808  1073  1073 I HWComposer: [4633128672291735937] ActiveConfigToHWC, ID : 2
10-04 16:55:37.808   975  1036 I display : Set Affinity config for fps(60) : 2, cpuIDs : 255
10-04 16:55:37.808   975  1036 I display : Set Affinity CPU ID : 0
10-04 16:55:37.808   975  1036 I display : Set Affinity CPU ID : 1
10-04 16:55:37.808   975  1036 I display : Set Affinity CPU ID : 2
10-04 16:55:37.808   975  1036 I display : Set Affinity CPU ID : 3
10-04 16:55:37.808   975  1036 I display : Set Affinity CPU ID : 4
10-04 16:55:37.808   975  1036 I display : Set Affinity CPU ID : 5
10-04 16:55:37.808   975  1036 I display : Set Affinity CPU ID : 6
10-04 16:55:37.808   975  1036 I display : Set Affinity CPU ID : 7
10-04 16:55:37.808   975  1036 I display : Set affinity HWC : 975
10-04 16:55:37.808   975  1036 I display : CPU set : Cluster(0), min_clock(0)
10-04 16:55:37.808   975  1036 I display : CPU set : Cluster(1), min_clock(0)
10-04 16:55:37.808   975  1036 I display : CPU set : Cluster(2), min_clock(0)
10-04 16:55:37.808  1073  1073 I LayerHistory: com.sec.android.app.launcher/com.sec.android.app.launcher.activities.LauncherActivity$_2453#5567 Max (can't resolve refresh rate)
10-04 16:55:37.808  1073  1073 I SurfaceFlinger: Idle - choose 60.00 Hz
10-04 16:55:37.809  1073  1073 D SurfaceFlinger: GPIS:: requestGPISForClientComposition
10-04 16:55:37.811   975  1033 I display : doDisplayConfigPostProcess needSetActiveConfig is true - mDesiredConfig: 2
10-04 16:55:37.811   975  1033 I display : setActiveConfig(config=2)
10-04 16:55:37.811   975  1033 I display : next config(2): width=1080 height=2400 period=16666666 Xdpi=422030 Ydpi=423333 groupId=0
10-04 16:55:37.811   975  1033 I display : Current VRR MODE is 3
10-04 16:55:37.811  1073  1212 I VSyncReactor: Current= 120, Period= 60, hwcPeriod= 120
10-04 16:55:37.819  1073  1212 I VSyncReactor: Current= 120, Period= 60, hwcPeriod= 60
10-04 16:55:37.871  1427  3950 E TaskPersister: File error accessing recents directory (directory doesn't exist?).
10-04 16:55:38.148  2118  2118 I EPDG -- SIM1 [EpdgIntfCont]: Not Mobile Interface. Ignoring Event
10-04 16:55:38.148  2118  2118 I EPDG -- SIM0 [EpdgIntfCont]: Not Mobile Interface. Ignoring Event
10-04 16:55:38.148  2118  2118 I EPDG -- SIM1 [EpdgIntfCont]: Not Mobile Interface. Ignoring Event
10-04 16:55:38.148  2118  2118 I EPDG -- SIM0 [EpdgIntfCont]: Not Mobile Interface. Ignoring Event
10-04 16:55:38.567  1427  1791 D InputReader: Btn_touch(11): value=1 when=89547.036186
10-04 16:55:38.568  1427  1791 I InputReader: Touch event's action is 0x0 (id=3, t=0) [pCnt=1, s=0.697 ] when=89547.036186
10-04 16:55:38.568  1427  1790 I InputDispatcher: Delivering touch to (2042): action: 0x4, f=0x0, d=0, 'e6bbee6', t=1 
10-04 16:55:38.568  1427  1790 I InputDispatcher: Delivering touch to (7973): action: 0x4, f=0x0, d=0, 'ee28167', t=1 
10-04 16:55:38.568  1427  1790 I InputDispatcher: Delivering touch to (2453): action: 0x0, f=0x0, d=0, 'fbdaee8', t=1 
10-04 16:55:38.569  1427  1790 D PowerManagerService: [api] userActivityFromNative : touch displayId=0 eventTime=89547036
10-04 16:55:38.569  2042  2042 D SearcleGestureHandler: allowGesture: false
10-04 16:55:38.570  1427  1579 I GestureDetector: obtain mCurrentDownEvent. id: 187916966 caller: com.android.server.wm.SystemGesturesPointerEventListener.onPointerEvent:204 com.android.server.wm.PointerEventDispatcher.onInputEvent:53 android.view.InputEventReceiver.dispatchInputEvent:337 
10-04 16:55:38.570  2453  2453 I ViewRootImpl@93f9b16[LauncherActivity]: ViewPostIme pointer 0
10-04 16:55:38.570  1427  1579 I GestureDetector: obtain mCurrentDownEvent. id: 187916966 caller: com.android.server.wm.SystemPerformancePointerEventListener.onPointerEvent:89 com.android.server.wm.PointerEventDispatcher.onInputEvent:53 android.view.InputEventReceiver.dispatchInputEvent:337 
10-04 16:55:38.570  2453  2453 I HoneySpace.QuickOptionUtil: QuickOption Touch_Event state = -1, eventY = 791.60156, eventX =394.98047 window Bounds = 2256 containerTouch = null
10-04 16:55:38.570  2453  2453 I HoneySpace.QuickOptionUtil: resetDrag
10-04 16:55:38.570  2453  2453 I HoneySpace.AppscreenContainerView: findActiveTouchController ev = 0
10-04 16:55:38.570  2453  2453 I HoneySpace.AppscreenHomeTouchController: onControllerInterceptTouchEvent ev = 0
10-04 16:55:38.570  2453  2453 I HoneySpace.AppscreenHomeTouchController: canIntercept = true
10-04 16:55:38.570  2453  2453 I HoneySpace.ApplistFastRecyclerView: dispatchTouchEvent() event.action=0
10-04 16:55:38.571  2453  2453 I HoneySpace.IconHoney: sendActiveLaunchBroadcast 206
10-04 16:55:38.573  1427  1996 I Pageboost: start alp : com.companyname.mauiappwindowtest
10-04 16:55:38.573  1427  1996 E ActivityTaskManager: Checking for the Active launch isPkgEverLaunched :true, isPkgStopped : true, isPkgSuspended : false
10-04 16:55:38.573  1427  1999 I Pageboost: alp for : com.companyname.mauiappwindowtest , 0
10-04 16:55:38.574  3227 17162 E pageboostd: alp start : app comcompanynamemauiappwindowtest
10-04 16:55:38.574  1073  1073 I HWComposer: [4633128672291735937] ActiveConfigToHWC, ID : 0
10-04 16:55:38.574   975  1036 I display : Set Affinity config for fps(120) : 0, cpuIDs : 255
10-04 16:55:38.574   975  1036 I display : Set Affinity CPU ID : 0
10-04 16:55:38.574   975  1036 I display : Set Affinity CPU ID : 1
10-04 16:55:38.574   975  1036 I display : Set Affinity CPU ID : 2
10-04 16:55:38.575   975  1036 I display : Set Affinity CPU ID : 3
10-04 16:55:38.575   975  1036 I display : Set Affinity CPU ID : 4
10-04 16:55:38.575   975  1036 I display : Set Affinity CPU ID : 5
10-04 16:55:38.575   975  1036 I display : Set Affinity CPU ID : 6
10-04 16:55:38.575   975  1036 I display : Set Affinity CPU ID : 7
10-04 16:55:38.575   975  1036 I display : Set affinity HWC : 975
10-04 16:55:38.575   975  1036 I display : CPU set : Cluster(0), min_clock(0)
10-04 16:55:38.575   975  1036 I display : CPU set : Cluster(1), min_clock(0)
10-04 16:55:38.575   975  1036 I display : CPU set : Cluster(2), min_clock(0)
10-04 16:55:38.575  1073  1073 I LayerHistory: com.sec.android.app.launcher/com.sec.android.app.launcher.activities.LauncherActivity$_2453#5567 Max (can't resolve refresh rate)
10-04 16:55:38.575  1073  1073 I SurfaceFlinger: Touch Boost - choose 120.00 Hz
10-04 16:55:38.575  1073  1073 D SurfaceFlinger: GPIS:: requestGPISForClientComposition
10-04 16:55:38.576  3227 17162 E pageboostd: comcompanynamemauiappwindowtest, amt 4722688 scnt 2 fcnt 0
10-04 16:55:38.578  1427  1579 I GestureDetector: obtain mCurrentMotionEventRaw. action: 2 id: 978246077
10-04 16:55:38.578  1427  1579 I GestureDetector: obtain mCurrentMotionEventRaw. action: 2 id: 978246077
10-04 16:55:38.586   937   937 E audit   : type=1400 audit(1728057338.579:15515): avc:  denied  { search } for  pid=3227 comm="pageboostd" name="com.google.android.gms" dev="dm-52" ino=6677 scontext=u:r:pageboostd:s0 tcontext=u:object_r:privapp_data_file:s0:c512,c768 tclass=dir permissive=0 SEPF_SM-G991B_12_0001 audit_filtered
10-04 16:55:38.586   937   937 E audit   : type=1300 audit(1728057338.579:15515): arch=c00000b7 syscall=56 success=no exit=-13 a0=ffffff9c a1=b400006f10c7ec00 a2=0 a3=0 items=1 ppid=1 pid=3227 auid=4294967295 uid=1000 gid=1000 euid=1000 suid=1000 fsuid=1000 egid=1000 sgid=1000 fsgid=1000 tty=(none) ses=4294967295 comm="pageboostd" exe="/system/bin/pageboostd" subj=u:r:pageboostd:s0 key=(null)
10-04 16:55:38.586   937   937 E audit   : type=1302 audit(1728057338.579:15515): item=0 name="/data/data/com.google.android.gms/files/fonts/opentype/Noto_COLR_Emoji_Compat-400-100_0-0_0.ttf" nametype=UNKNOWN cap_fp=0 cap_fi=0 cap_fe=0 cap_fver=0 cap_frootid=0
10-04 16:55:38.586   937   937 E audit   : type=1327 audit(1728057338.579:15515): proctitle="/system/bin/pageboostd"
10-04 16:55:38.587  3227 17162 E pageboostd: comcompanynamemauiappwindowtest, amt 52793344 scnt 117 fcnt 4
10-04 16:55:38.588  3227 17162 E pageboostd: alp end : app comcompanynamemauiappwindowtest data_amount 57516032
10-04 16:55:38.589   975  1033 I display : doDisplayConfigPostProcess needSetActiveConfig is true - mDesiredConfig: 0
10-04 16:55:38.589   975  1033 I display : setActiveConfig(config=0)
10-04 16:55:38.589   975  1033 I display : next config(0): width=1080 height=2400 period=8333333 Xdpi=422030 Ydpi=423333 groupId=0
10-04 16:55:38.589   975  1033 I display : Current VRR MODE is 3
10-04 16:55:38.589  1073  1212 I VSyncReactor: Current= 60, Period= 120, hwcPeriod= 60
10-04 16:55:38.603  2453  2453 I HoneySpace.AppscreenContainerView: findActiveTouchController ev = 2
10-04 16:55:38.604  2453  2453 I HoneySpace.AppscreenHomeTouchController: onControllerInterceptTouchEvent ev = 2
10-04 16:55:38.605   975  1033 I display : config 16666666, desired 8333333
10-04 16:55:38.606  1073  1212 I VSyncReactor: Current= 60, Period= 120, hwcPeriod= 60
10-04 16:55:38.620  2453  2453 I HoneySpace.AppscreenContainerView: findActiveTouchController ev = 2
10-04 16:55:38.620  2453  2453 I HoneySpace.AppscreenHomeTouchController: onControllerInterceptTouchEvent ev = 2
10-04 16:55:38.622  1073  1212 I VSyncReactor: Current= 60, Period= 120, hwcPeriod= 120
10-04 16:55:38.625  1427  1791 D InputReader: Btn_touch(11): value=0 when=89547.094606
10-04 16:55:38.625  1427  1791 I InputReader: Touch event's action is 0x1 (id=3, t=0) [pCnt=1, s=] when=89547.094606
10-04 16:55:38.626  1427  1790 I InputDispatcher: Delivering touch to (2453): action: 0x1, f=0x0, d=0, 'fbdaee8', t=1 
10-04 16:55:38.626  2453  2453 I ViewRootImpl@93f9b16[LauncherActivity]: ViewPostIme pointer 1
10-04 16:55:38.626  2453  2453 I HoneySpace.AppscreenContainerView: findActiveTouchController ev = 1
10-04 16:55:38.626  2453  2453 I HoneySpace.AppscreenHomeTouchController: onControllerInterceptTouchEvent ev = 1
10-04 16:55:38.627  2453  2453 I HoneySpace.AppScreenClickAction: onAppClick() id: 206, isNewDex: false
10-04 16:55:38.627  2453  2453 I HoneySpace.DvfsManager: acquireAppLaunch
10-04 16:55:38.627  2453  2453 I SemDvfsHyPerManager: acquire hyper - APP_LAUNCH/2453@1, type = -999
10-04 16:55:38.627   994  1071 I HYPER-HAL: [RequestManager.cpp]acquire(): Acquired ID : 3012286  [2453 / 1]    HINT : APP_LAUNCH    list : 
10-04 16:55:38.628  3946  3946 I SemDvfsHyPerManager: acquire hyper - APP_START_SHORT/3946@14, type = -999
10-04 16:55:38.629   994  1071 I HYPER-HAL: [ResourceManager.cpp]updateResource(): [CPUMinFreq] UpdateResource Request ID : 3012286    Value : 2912000
10-04 16:55:38.633  2453  2453 I HoneySpace.ShellTransitionManager: startShellTransition com.honeyspace.sdk.transition.ShellTransition$Info@e04b45e
10-04 16:55:38.633  2453  2453 I HoneySpace.ShellTransitionManager: open start
10-04 16:55:38.634   994  1071 I HYPER-HAL: [RequestManager.cpp]acquire(): Acquired ID : 7842794  [3946 / 14]    HINT : APP_START    list : [TIMEOUT / 1500] 
10-04 16:55:38.634  2453  2453 I HoneySpace.Launcher: startActivityForResult request : -1
10-04 16:55:38.634   994  1071 I HYPER-HAL: [ResourceManager.cpp]updateResource(): [CPUMaxFreq] UpdateResource Request ID : 7842794    Value : 2912000
10-04 16:55:38.635  1427  1472 D ActivityTaskManager: startActivityAsUser: callingPid=2453, callingUid=10137, caller=com.android.server.wm.ActivityTaskManagerService.startActivityAsUser:1844 com.android.server.wm.ActivityTaskManagerService.startActivity:1818 android.app.IActivityTaskManager$Stub.onTransact:1353 com.android.server.wm.ActivityTaskManagerService.onTransact:6972 android.os.Binder.execTransactInternal:1375 android.os.Binder.execTransact:1311 <bottom of call stack> 
10-04 16:55:38.635  1427  1581 I ChimeraSystemEventListener: appLaunchIntent package name is: com.companyname.mauiappwindowtest
10-04 16:55:38.635  1427  1472 D CompatibilityChangeReporter: Compat change id reported: 161252188; UID 10384; state: DISABLED
10-04 16:55:38.635  1427  1472 I Pageboost: onAppLaunch : com.companyname.mauiappwindowtest
10-04 16:55:38.636  1427  1472 D CompatibilityChangeReporter: Compat change id reported: 265464455; UID 10384; state: DISABLED
10-04 16:55:38.636  1427  1472 D CompatibilityChangeReporter: Compat change id reported: 265452344; UID 10384; state: DISABLED
10-04 16:55:38.636  1427  1472 D CompatibilityChangeReporter: Compat change id reported: 266124927; UID 10384; state: DISABLED
10-04 16:55:38.636  1427  1472 D CompatibilityChangeReporter: Compat change id reported: 265451093; UID 10384; state: DISABLED
10-04 16:55:38.636  1427  1472 D CompatibilityChangeReporter: Compat change id reported: 265456536; UID 10384; state: DISABLED
10-04 16:55:38.636  1427  1472 D CompatibilityChangeReporter: Compat change id reported: 255940284; UID 10384; state: DISABLED
10-04 16:55:38.636  1427  1472 D CompatibilityChangeReporter: Compat change id reported: 236283604; UID 10384; state: DISABLED
10-04 16:55:38.636  1427  1472 D CompatibilityChangeReporter: Compat change id reported: 263959004; UID 10384; state: DISABLED
10-04 16:55:38.636  1427  1472 D CompatibilityChangeReporter: Compat change id reported: 264304459; UID 10384; state: DISABLED
10-04 16:55:38.636  1427  1472 D CompatibilityChangeReporter: Compat change id reported: 264301586; UID 10384; state: DISABLED
10-04 16:55:38.636  1427  1472 D CompatibilityChangeReporter: Compat change id reported: 254631730; UID 10384; state: DISABLED
10-04 16:55:38.636  1427  1472 D CompatibilityChangeReporter: Compat change id reported: 273509367; UID 10384; state: DISABLED
10-04 16:55:38.636  1427  1472 D CompatibilityChangeReporter: Compat change id reported: 263259275; UID 10384; state: DISABLED
10-04 16:55:38.636  1427  1472 D CompatibilityChangeReporter: Compat change id reported: 174042980; UID 10384; state: DISABLED
10-04 16:55:38.636  1427  1472 D CompatibilityChangeReporter: Compat change id reported: 174042936; UID 10384; state: DISABLED
10-04 16:55:38.636  1427  1472 D CompatibilityChangeReporter: Compat change id reported: 181136395; UID 10384; state: DISABLED
10-04 16:55:38.637  1427  1472 D CompatibilityChangeReporter: Compat change id reported: 194480991; UID 10384; state: ENABLED
10-04 16:55:38.637  1427  1472 D WindowManager: Transition is created, t=TransitionRecord{ebfce02 id=-1 type=OPEN flags=0x0}, caller=com.android.server.wm.TransitionController.createAndStartCollecting:1765 com.android.server.wm.ActivityStarter.startActivityUnchecked:2360 com.android.server.wm.ActivityStarter.executeRequest:1953 com.android.server.wm.ActivityStarter.execute:1093 com.android.server.wm.ActivityTaskManagerService.startActivityAsUser:1985 
10-04 16:55:38.637  1427  1472 D WindowManager: SyncGroup is created, id=430, name=Transition, caller=com.android.server.wm.BLASTSyncEngine$SyncGroup.<init>:0 com.android.server.wm.BLASTSyncEngine.prepareSyncSet:513 com.android.server.wm.BLASTSyncEngine.startSyncSet:518 com.android.server.wm.Transition.startCollecting:710 com.android.server.wm.TransitionController.moveToCollecting:360 com.android.server.wm.TransitionController.createAndStartCollecting:1766 com.android.server.wm.ActivityStarter.startActivityUnchecked:2360 
10-04 16:55:38.637  1427  1472 W WindowManager: setSyncMethod, id=430, method=0, caller=com.android.server.wm.Transition.startCollecting:712 com.android.server.wm.TransitionController.moveToCollecting:360 com.android.server.wm.TransitionController.createAndStartCollecting:1766 
10-04 16:55:38.637  1427  1472 V WindowManager: Start collecting in Transition: TransitionRecord{ebfce02 id=430 type=OPEN flags=0x0}, caller=com.android.server.wm.TransitionController.createAndStartCollecting:1766 com.android.server.wm.ActivityStarter.startActivityUnchecked:2360 com.android.server.wm.ActivityStarter.executeRequest:1953 com.android.server.wm.ActivityStarter.execute:1093 com.android.server.wm.ActivityTaskManagerService.startActivityAsUser:1985 
10-04 16:55:38.637  1427  1472 V WindowManager: Collecting in transition 430: ActivityRecord{ffb8313 u0 com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity, caller=com.android.server.wm.Transition.collect:759 com.android.server.wm.TransitionController.collect:935 com.android.server.wm.ActivityStarter.startActivityUnchecked:2376 com.android.server.wm.ActivityStarter.executeRequest:1953 com.android.server.wm.ActivityStarter.execute:1093 
10-04 16:55:38.637  1427  1472 D ActivityTaskManager: TaskLaunchParamsModifier:task=null activity=ActivityRecord{ffb8313 u0 com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity t-1} display-from-option=0 display-id=0 task-display-area-windowing-mode=1 suggested-display-area=DefaultTaskDisplayArea_d0@36679575
10-04 16:55:38.638  1427  1472 D ActivityTaskManager: TaskLaunchParamsModifier:task=null activity=ActivityRecord{ffb8313 u0 com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity t-1} display-from-option=0 display-id=0 task-display-area-windowing-mode=1 suggested-display-area=DefaultTaskDisplayArea_d0@36679575 inherit-from-source=fullscreen non-freeform-task-display-area display-area=DefaultTaskDisplayArea_d0@36679575 default-portrait freeform-size-mismatch=Rect(81, 568 - 999, 1768)
10-04 16:55:38.638  1427  2573 I SemDvfsHyPerManager: acquire hyper - AMS_APP_SWITCH/1427@21, type = -999
10-04 16:55:38.638   994  1071 I HYPER-HAL: [RequestManager.cpp]acquire(): Acquired ID : 1049097  [1427 / 21]    HINT : AMS_APP_SWITCH    list : 
10-04 16:55:38.638  1427  2573 D ActivityManagerPerformance: AMP_acquire() APP_SWITCH
10-04 16:55:38.638   994  1071 I HYPER-HAL: [ResourceManager.cpp]updateResource(): [CPUMinFreq] UpdateResource Request ID : 1049097    Value : 2912000
10-04 16:55:38.638  3946  3946 I SemDvfsHyPerManager: acquire hyper - APP_START_SHORT/3946@14, type = -999
10-04 16:55:38.638  1073  2470 I SurfaceFlinger: id=5575 createSurf, flag=24004, Task=149#5575
10-04 16:55:38.639   994  1071 I HYPER-HAL: [RequestManager.cpp]acquire(): Acquired ID : 7842794  [3946 / 14]    HINT : APP_START    list : [TIMEOUT / 1500] 
10-04 16:55:38.639   994  1071 I HYPER-HAL: [ResourceManager.cpp]updateResource(): [CPUMaxFreq] UpdateResource Request ID : 7842794    Value : 2912000
10-04 16:55:38.639  1427  1472 D ActivityTaskManager: TaskLaunchParamsModifier:task=Task{3b8c950 #149 type=standard A=10384:com.companyname.mauiappwindowtest} activity=ActivityRecord{ffb8313 u0 com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity t-1} display-from-option=0 display-id=0 task-display-area-windowing-mode=1 suggested-display-area=DefaultTaskDisplayArea_d0@36679575 inherit-from-source=fullscreen non-freeform-task-display-area display-area=DefaultTaskDisplayArea_d0@36679575 default-portrait freeform-size-mismatch=Rect(81, 568 - 999, 1768)
10-04 16:55:38.639  1427  1472 V WindowManager: Collecting in transition 430: Task{3b8c950 #149 type=standard A=10384:com.companyname.mauiappwindowtest}, caller=com.android.server.wm.Transition.collect:759 com.android.server.wm.Transition.collectExistenceChange:942 com.android.server.wm.TransitionController.collectExistenceChange:985 com.android.server.wm.ActivityStarter.setNewTask:4727 com.android.server.wm.ActivityStarter.startActivityInner:2944 
10-04 16:55:38.640  1427  1472 D CompatibilityChangeReporter: Compat change id reported: 184838306; UID 10384; state: DISABLED
10-04 16:55:38.640  1427  1472 D CompatibilityChangeReporter: Compat change id reported: 185004937; UID 10384; state: DISABLED
10-04 16:55:38.640  1073  2470 I SurfaceFlinger: id=5576 createSurf, flag=84004, ActivityRecord{ffb8313 u0 com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity t149}#5576
10-04 16:55:38.641  1427  1472 D ActivityTaskManager: scheduleTopResumedActivityChanged, onTop=false, r=ActivityRecord{bc89e32 u0 com.sec.android.app.launcher/.activities.LauncherActivity t6}, caller=com.android.server.wm.ActivityTaskSupervisor.updateTopResumedActivityIfNeeded:2826 com.android.server.wm.TaskDisplayArea.positionChildTaskAt:567 com.android.server.wm.TaskDisplayArea.positionChildAt:483 com.android.server.wm.Task.moveToFront:6077 com.android.server.wm.ActivityStarter.startActivityInner:2972 com.android.server.wm.ActivityStarter.startActivityUnchecked:2379 
10-04 16:55:38.641  1427  1472 V WindowManager: Checking theme of starting window: 0x7f10013e
10-04 16:55:38.641  1427  1472 V WindowManager: Translucent=false Floating=false ShowWallpaper=false Disable=false
10-04 16:55:38.641  1427  1472 D CompatibilityChangeReporter: Compat change id reported: 205907456; UID 10384; state: ENABLED
10-04 16:55:38.641  1427  1472 V WindowManager: Creating SplashScreenStartingData
10-04 16:55:38.641  1427  1472 D ActivityTaskManager: Add starting ActivityRecord{ffb8313 u0 com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity t149}: typeParam=139 startingData=com.android.server.wm.SplashScreenStartingData@860c84e
10-04 16:55:38.641  1427  1472 V WindowManager: Added starting ActivityRecord{ffb8313 u0 com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity t149}: startingWindow=null startingView=com.android.server.wm.StartingSurfaceController$StartingSurface@8913d6f
10-04 16:55:38.642  1427  1472 V WindowManager: Collecting in transition 430: ActivityRecord{ffb8313 u0 com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity t149}, caller=com.android.server.wm.Transition.collect:759 com.android.server.wm.Transition.collectExistenceChange:942 com.android.server.wm.TransitionController.collectExistenceChange:985 com.android.server.wm.ActivityStarter.handleStartResult:2557 com.android.server.wm.ActivityStarter.startActivityUnchecked:2384 
10-04 16:55:38.642  1427  1472 V WindowManager: Requesting StartTransition: TransitionRecord{ebfce02 id=430 type=OPEN flags=0x0}, caller=com.android.server.wm.ActivityStarter.handleStartResult:2591 com.android.server.wm.ActivityStarter.startActivityUnchecked:2384 com.android.server.wm.ActivityStarter.executeRequest:1953 com.android.server.wm.ActivityStarter.execute:1093 com.android.server.wm.ActivityTaskManagerService.startActivityAsUser:1985 
10-04 16:55:38.643  1427  1472 D CompatibilityChangeReporter: Compat change id reported: 194833441; UID 10384; state: ENABLED
10-04 16:55:38.643  1427  1472 I ActivityTaskManager: START u0 {act=android.intent.action.MAIN cat=[android.intent.category.LAUNCHER] flg=0x10200000 cmp=com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity bnds=[289,621][540,983]} with LAUNCH_SINGLE_TOP from uid 10137 (BAL_ALLOW_ALLOWLISTED_COMPONENT) result code=0
10-04 16:55:38.643  1427  1472 I Pageboost: stop alp
10-04 16:55:38.643  1247 10309 I CameraService: onUidStateChanged: uid=10043, procState is changed. (0 -> 1)
10-04 16:55:38.643  1427  1472 I SemDvfsHyPerManager: acquire hyper - AMS_APP_LAUNCH/1427@18, type = -999
10-04 16:55:38.643  2042  2255 D NativeCustomFrequencyManager: [NativeCFMS] BpCustomFrequencyManager::BpCustomFrequencyManager()
10-04 16:55:38.643  3227  3227 E pageboostd: Received HALT command code 2
10-04 16:55:38.643  2042  2164 V WindowManagerShell: Transition requested: android.os.BinderProxy@18f4a09 TransitionRequestInfo { type = OPEN, triggerTask = TaskInfo{userId=0 taskId=149 displayId=0 isRunning=true baseIntent=Intent { act=android.intent.action.MAIN cat=[android.intent.category.LAUNCHER] flg=0x10200000 cmp=com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity } baseActivity=ComponentInfo{com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity} topActivity=ComponentInfo{com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity} origActivity=null realActivity=ComponentInfo{com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity} numActivities=1 lastActiveTime=156092501 supportsMultiWindow=true resizeMode=1 isResizeable=true minWidth=-1 minHeight=-1 maxWidth=-1 maxHeight=-1 defaultMinSize=220 token=WCT{android.window.IWindowContainerToken$Stub$Proxy@e87740e} topActivityType=1 pictureInPictureParams=null shouldDockBigOverlays=false launchIntoPipHostTaskId=-1 lastParentTaskIdBeforePip=-1 displayCutoutSafeInsets=Rect(0, 80 - 0, 0) topActivityInfo=ActivityInfo{5dcde2f crc6457a4a0fbbd3bbed6.MainActivity} launchCookies=[android.os.BinderProxy@2171c3c] positionInParent=Point(0, 0) parentTaskId=-1 isFocused=false isVisible=false isVisibleRequested=false isSleeping=false topActivityInSizeCompat=false topActivityEligibleForLetterboxEducation= false topActivityLetterboxed= false isFromDoubleTap= false topActivityLetterboxVerticalPosition= -1 topActivityLetterboxHorizontalPosition= -1 topActivityLetterboxWidth=-1 topActivityLetterboxHeight=-1 locusId=null displayAreaFeatureId=1 cameraCompatControlState=hidden originallySupportedMultiWindow=true hasWallpaper=false topActivityInFixedAspectRatio=false rootAffinity=10384:com.companyname.mauiappwindowtest topActivityInDisplayCompat=false topActivityInBoundsCompat=false topActivityBounds=null singleTapFromLetterbox=false isTopTaskInStage=false topActivityUiMode=17 CoverLauncherWidgetTask=false CoverScreenTask=false isAllowedSeamlessRotation=false isTopTransparentActivity=false hasPopOver=false}, remoteTransition = RemoteTransition { remoteTransition = android.window.IRemoteTransition$Stub$Proxy@d97dc5, appThread = android.app.IApplicationThread$Stub$Proxy@c4ac31a, debugName = QuickstepLaunch }, displayChange = null }
10-04 16:55:38.643   994  1071 I HYPER-HAL: [RequestManager.cpp]acquire(): Acquired ID : 1044753  [1427 / 18]    HINT : AMS_APP_LAUNCH    list : 
10-04 16:55:38.644  3946  3946 I SemDvfsHyPerManager: acquire hyper - APP_START/3946@16, type = -999
10-04 16:55:38.644   994  1071 I HYPER-HAL: [ResourceManager.cpp]updateResource(): [CPUMinFreq] UpdateResource Request ID : 1044753    Value : 2912000
10-04 16:55:38.644  2453 15403 I HoneySpace.SuggestedAppsRepositoryImpl: sendSuggestedAppsLaunchTarget: ComponentInfo{com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity}
10-04 16:55:38.645  1427  4443 D KNOX_MDM_SettingsProvider: isChangeAllowed() : name = desktop_mode
10-04 16:55:38.645  1427  4443 D KNOX_MDM_SettingsProvider: edmUri: content://com.sec.knox.provider/RestrictionPolicy3
10-04 16:55:38.645  1427  4443 D KNOX_MDM_SettingsProvider: projectionArgs: isSettingsChangesAllowed
10-04 16:55:38.645  1427  4443 D KNOX_MDM_SettingsProvider: selectionArgs: false
10-04 16:55:38.645  1427  4443 D KNOX_MDM_SettingsProvider: selectionArgs: 10043
10-04 16:55:38.645   994 17155 I HYPER-HAL: [ResourceManager.cpp]removeResource(): [CPUMinFreq] RemoveResource Request ID : 1060725
10-04 16:55:38.645  1427  4443 D SecContentProvider: query(), uri = 17 selection = isSettingsChangesAllowed
10-04 16:55:38.645  1427  4443 D SecContentProvider: called from android.uid.systemui:10043
10-04 16:55:38.645   994 17155 I HYPER-HAL: [RequestManager.cpp]releaseLocked(): Released ID : 1060725
10-04 16:55:38.645  1427  4443 D RestrictionPolicy: isSettingsChangesAllowedAsUser, userId 0 : true
10-04 16:55:38.645  1427  4443 D KNOX_MDM_SettingsProvider: ret = 1
10-04 16:55:38.645  1427  9415 D CompatibilityChangeReporter: Compat change id reported: 168419799; UID 10384; state: DISABLED
10-04 16:55:38.645  2042  2164 V WindowManagerShell: RemoteTransition directly requested for android.os.BinderProxy@18f4a09: RemoteTransition { remoteTransition = android.window.IRemoteTransition$Stub$Proxy@d97dc5, appThread = android.app.IApplicationThread$Stub$Proxy@c4ac31a, debugName = QuickstepLaunch }
10-04 16:55:38.645  1427  9415 D CompatibilityChangeReporter: Compat change id reported: 273564678; UID 10384; state: DISABLED
10-04 16:55:38.645  1427  9415 D InputTransport: Input channel constructed: 'e051b5a', fd=800
10-04 16:55:38.645  1427  9415 D InputTransport: Input channel constructed: 'e051b5a', fd=830
10-04 16:55:38.645  2453  2562 I HoneySpace.SALoggingUtils: SA Logging screenID: 201 eventId: 1001 detail: {PackageName=com.companyname.mauiappwindowtest, det=3} value: -1
10-04 16:55:38.645  1427  9415 D InputTransport: Input channel constructed: 'e051b5a', fd=863
10-04 16:55:38.646  1427  9415 D WindowManager: prepareSync <SYNC_STATE_WAITING_FOR_DRAW>, mPrepareSyncSeqId=0, win=Window{e051b5a u0 Splash Screen com.companyname.mauiappwindowtest}
10-04 16:55:38.646  1073  1124 I SurfaceFlinger: id=5577 createSurf, flag=84004, e051b5a Splash Screen com.companyname.mauiappwindowtest#5577
10-04 16:55:38.646   994  1071 I HYPER-HAL: [RequestManager.cpp]acquire(): Acquired ID : 7850719  [3946 / 16]    HINT : APP_START    list : 
10-04 16:55:38.646   994  1071 I HYPER-HAL: [ResourceManager.cpp]updateResource(): [CPUMaxFreq] UpdateResource Request ID : 7850719    Value : 2912000
10-04 16:55:38.646  1427  9415 V WindowManager: addWindow: ActivityRecord{ffb8313 u0 com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity t149} startingWindow=Window{e051b5a u0 Splash Screen com.companyname.mauiappwindowtest}
10-04 16:55:38.646  1427  9415 D InputTransport: Input channel destroyed: 'e051b5a', fd=863
10-04 16:55:38.647  1427  4443 V WindowManager: Starting Transition 430, caller=com.android.server.wm.WindowOrganizerController.startTransition:382 com.android.server.wm.WindowOrganizerController.startTransition:313 android.window.IWindowOrganizerController$Stub.onTransact:257 
10-04 16:55:38.647  1427  4443 V Transition:  allReady query: used=true, override=false, defer=0, states=Display{#0 state=ON size=1080x2400 ROTATION_0}:false
10-04 16:55:38.647  2453  2453 I HoneySpace.Launcher: !@Boot_EBS_D: Launcher.onPause()
10-04 16:55:38.647  2453 15403 I HoneySpace.SPayHandler: updateSpayHandler launcher activity is paused false
10-04 16:55:38.647  2453  2453 I HoneySpace.Launcher: updateLauncherShowing true -> false
10-04 16:55:38.647  2042  2227 I InsetsController: onStateChanged: host=Splash Screen com.companyname.mauiappwindowtest, from=android.view.ViewRootImpl.setView:1753, state=InsetsState: {mDisplayFrame=Rect(0, 0 - 1080, 2400), mDisplayCutout=DisplayCutout{insets=Rect(0, 80 - 0, 0) waterfall=Insets{left=0, top=0, right=0, bottom=0} boundingRect={Bounds=[Rect(0, 0 - 0, 0), Rect(510, 0 - 570, 80), Rect(0, 0 - 0, 0), Rect(0, 0 - 0, 0)]} cutoutPathParserInfo={CutoutPathParserInfo{displayWidth=1080 displayHeight=2400 physicalDisplayWidth=1080 physicalDisplayHeight=2400 density={3.0} cutoutSpec={M 0,0 H -10 V 26.66666666666667 H 10 V 0 H 0 Z @dp} rotation={0} scale={1.0} physicalPixelDisplaySizeRatio={1.0}}}}, mRoundedCorners=RoundedCorners{[RoundedCorner{position=TopLeft, radius=90, center=Point(90, 90)}, RoundedCorner{position=TopRight, radius=90, center=Point(990, 90)}, RoundedCorner{position=BottomRight, radius=90, center=Point(990, 2310)}, RoundedCorner{position=BottomLeft, radius=90, center=Point(90, 2310)}]}  mRoundedCornerFrame=Rect(0, 0 - 1080, 2400), mPrivacyIndicatorBounds=PrivacyIndicatorBounds {static bounds=Rect(948, 0 - 1080, 80) rotation=0}, mDisplayShape=DisplayShape{ spec=-311912193 displayWidth=1080 displayHeight=2400 physicalPixelDisplaySizeRatio=1.0 rotation=0 offsetX=0 offsetY=0 scale=1.0}, mSources= { InsetsSource: {a1c30001 mType=navigationBars mFrame=[0,2256][1080,2400] mVisible=true mFlags=[]}, InsetsSource: {a1c30004 mType=systemGestures mFrame=[0,0][0,0] mVisible=true mFlags=[]}, InsetsSource: {a1c30005 mType=mandatorySystemGestures mFrame=[0,2256][1080,2400] mVisible=true mFlags=[]}, InsetsSource: {a1c30006 mType=tappableElement mFrame=[0,2256][1080,2400] mVisible=true mFlags=[]}, InsetsSource: {a1c30024 mType=systemGestures mFrame=[0,0][0,0] mVisible=true mFlags=[]}, InsetsSource: {27 mType=displayCutout mFrame=[0,0][1080,80] mVisible=true mFlags=[]}, InsetsSource: {765e0000 mType=statusBars mFrame=[0,0][1080,80] mVisible=true mFlags=[]}, InsetsSource: {765e0005 mType=mandatorySystemGestures mFrame=[0,0][1080,116] mVisible=true mFlags=[]}, InsetsSource: {765e0006 mType=tappableElement mFrame=[0,0][1080,80] mVisible=true mFlags=[]} }
10-04 16:55:38.647  2042  2227 I ViewRootImpl@1771f10[mauiappwindowtest]: synced displayState. AttachInfo displayState=2
10-04 16:55:38.647  2042  2227 I ViewRootImpl@1771f10[mauiappwindowtest]: setView = android.widget.FrameLayout@2d93141 TM=true
10-04 16:55:38.648  2042  2255 D OpenGLRenderer: HWUI - treat SMPTE_170M as sRGB
10-04 16:55:38.649  1427  4443 V WindowManager: Collecting in transition 430: ActivityRecord{ffb8313 u0 com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity t149}, caller=com.android.server.wm.Transition.collect:759 com.android.server.wm.TransitionController.collect:935 com.android.server.wm.ActivityRecord.setVisibility:6348 com.android.server.wm.ActivityRecord.setVisibility:6300 com.android.server.wm.EnsureActivitiesVisibleHelper.makeVisibleAndRestartIfNeeded:337 
10-04 16:55:38.649  1427  4443 V WindowManager: Collecting in transition 430: ActivityRecord{bc89e32 u0 com.sec.android.app.launcher/.activities.LauncherActivity t6}, caller=com.android.server.wm.Transition.collect:759 com.android.server.wm.TransitionController.collect:935 com.android.server.wm.ActivityRecord.setVisibility:6348 com.android.server.wm.ActivityRecord.setVisibility:6300 com.android.server.wm.ActivityRecord.makeInvisible:7137 
10-04 16:55:38.649  1427  4443 D WindowManager: prepareSync <SYNC_STATE_WAITING_FOR_DRAW>, mPrepareSyncSeqId=0, win=Window{ee28167 u0 (1-1)-Window{99bf2c6 alpha=1.0 fl=}}
10-04 16:55:38.649  1427  4443 D WindowManager: prepareSync <SYNC_STATE_WAITING_FOR_DRAW>, mPrepareSyncSeqId=0, win=Window{fbdaee8 u0 com.sec.android.app.launcher/com.sec.android.app.launcher.activities.LauncherActivity}
10-04 16:55:38.649  1427  4443 V WindowManager: Collecting in transition 430: WallpaperWindowToken{1f6c5ec token=android.os.Binder@a0f609f}, caller=com.android.server.wm.Transition.collect:759 com.android.server.wm.Transition.collect:847 com.android.server.wm.Transition.collect:759 com.android.server.wm.TransitionController.collect:935 com.android.server.wm.ActivityRecord.setVisibility:6348 
10-04 16:55:38.649  1427  4443 D WindowManager: VisibleRequested updated, r=ActivityRecord{bc89e32 u0 com.sec.android.app.launcher/.activities.LauncherActivity t6}
10-04 16:55:38.651  2453  2586 I HoneySpace.TopTaskSource: onTaskMovedToFront : taskId = 149
10-04 16:55:38.651  1427  9415 D CoreBackPreview: Window{e051b5a u0 Splash Screen com.companyname.mauiappwindowtest}: Setting back callback OnBackInvokedCallbackInfo{mCallback=android.window.IOnBackInvokedCallback$Stub$Proxy@ba89681, mPriority=0, mIsAnimationCallback=false}
10-04 16:55:38.651  2453  2588 I HoneySpace.TopTaskUseCase: topTasks 149 ComponentInfo{com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity}
10-04 16:55:38.651  1427  2275 V WindowManager: Relayout Window{e051b5a u0 Splash Screen com.companyname.mauiappwindowtest}: viewVisibility=0 req=1080x2400 ty=3 d0
10-04 16:55:38.651  1427  2275 D RestrictionPolicy: isScreenCaptureEnabled : ret=true userId=0
10-04 16:55:38.652  1073  1124 I SurfaceFlinger: id=5578 createSurf, flag=44004, Splash Screen com.companyname.mauiappwindowtest$_2042#5578
10-04 16:55:38.652  1427  1581 W ActivityManager: ProcessRecord{d699326 0:com.companyname.mauiappwindowtest/u0a384}: ART verification disabled
10-04 16:55:38.652  1427  2275 D WindowManager: makeSurface duration=1 name=Splash Screen com.companyname.mauiappwindowtest$_2042
10-04 16:55:38.652  1427  1581 D CompatibilityChangeReporter: Compat change id reported: 135634846; UID 10384; state: DISABLED
10-04 16:55:38.652  1427  1581 D CompatibilityChangeReporter: Compat change id reported: 177438394; UID 10384; state: DISABLED
10-04 16:55:38.652  1427  1581 D CompatibilityChangeReporter: Compat change id reported: 135772972; UID 10384; state: DISABLED
10-04 16:55:38.652  1427  1581 D CompatibilityChangeReporter: Compat change id reported: 135754954; UID 10384; state: ENABLED
10-04 16:55:38.652  1427  1589 D CompatibilityChangeReporter: Compat change id reported: 143937733; UID 10384; state: ENABLED
10-04 16:55:38.653  1427  1581 D SGM:FgCheckThread: notePauseComponent(), received pkgName: com.sec.android.app.launcher, userId: 0
10-04 16:55:38.653  1427  1902 I CocktailBarManagerServiceContainer: handleMessage: entry what = 6
10-04 16:55:38.654  1427  2275 V WindowManager: Changing focus from Window{fbdaee8 u0 com.sec.android.app.launcher/com.sec.android.app.launcher.activities.LauncherActivity} to null displayId=0 Callers=com.android.server.wm.RootWindowContainer.updateFocusedWindowLocked:578 com.android.server.wm.WindowManagerService.updateFocusedWindowLocked:6881 com.android.server.wm.WindowManagerService.relayoutWindow:2755 com.android.server.wm.Session.relayout:282 
10-04 16:55:38.655  1427  2275 V WindowManager: rotationForOrientation(orient=SCREEN_ORIENTATION_UNSPECIFIED (-1), last=ROTATION_0 (0)); user=ROTATION_0 (0) 
10-04 16:55:38.655  1427  2275 D WindowManager: rotationForOrientation, orientationSource=ActivityRecord{ffb8313 u0 com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity t149}
10-04 16:55:38.655  2453 15403 I HoneySpace.RecentTasks: onRecentTasksChanged
10-04 16:55:38.655  1427  2275 V WindowManager: rotationForOrientation(orient=SCREEN_ORIENTATION_UNSPECIFIED (-1), last=ROTATION_0 (0)); user=ROTATION_0 (0) 
10-04 16:55:38.655  1427  2275 D WindowManager: rotationForOrientation, orientationSource=ActivityRecord{ffb8313 u0 com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity t149}
10-04 16:55:38.655  1427  2275 V WindowManager: Computed rotation=ROTATION_0 (0) for display id=0 based on lastOrientation=SCREEN_ORIENTATION_UNSPECIFIED (-1) and oldRotation=ROTATION_0 (0), caller=com.android.server.wm.DisplayRotation.updateOrientation:517 com.android.server.wm.DisplayContent.updateOrientation:2176 com.android.server.wm.DisplayContent.updateOrientation:2066 com.android.server.wm.WindowManagerService.relayoutWindow:2792 com.android.server.wm.Session.relayout:282 android.view.IWindowSession$Stub.onTransact:782 
10-04 16:55:38.656  1073  1073 I BpBinder: onLastStrongRef automatically unlinking death recipients: 
10-04 16:55:38.656  1427  2275 V WindowManager: Relayout hash=e051b5a, pid=2042, syncId=-1: mAttrs={(0,0)(fillxfill) sim={adjust=pan} ty=APPLICATION_STARTING fmt=TRANSLUCENT wanim=0x1030303
10-04 16:55:38.656  1427  2275 V WindowManager:   fl=81030118
10-04 16:55:38.656  1427  2275 V WindowManager:   pfl=16000010
10-04 16:55:38.656  1427  2275 V WindowManager:   bhv=DEFAULT
10-04 16:55:38.656  1427  2275 V WindowManager:   fitSides= naviIconColor=0}
10-04 16:55:38.657  1427  9415 D InputDispatcher: Focus left window (0): fbdaee8 com.sec.android.app.launcher/com.sec.android.app.launcher.activities.LauncherActivity
10-04 16:55:38.657  2042  2227 I InsetsController: onStateChanged: host=Splash Screen com.companyname.mauiappwindowtest, from=android.view.ViewRootImpl.relayoutWindow:10072, state=InsetsState: {mDisplayFrame=Rect(0, 0 - 1080, 2400), mDisplayCutout=DisplayCutout{insets=Rect(0, 80 - 0, 0) waterfall=Insets{left=0, top=0, right=0, bottom=0} boundingRect={Bounds=[Rect(0, 0 - 0, 0), Rect(510, 0 - 570, 80), Rect(0, 0 - 0, 0), Rect(0, 0 - 0, 0)]} cutoutPathParserInfo={CutoutPathParserInfo{displayWidth=1080 displayHeight=2400 physicalDisplayWidth=1080 physicalDisplayHeight=2400 density={3.0} cutoutSpec={M 0,0 H -10 V 26.66666666666667 H 10 V 0 H 0 Z @dp} rotation={0} scale={1.0} physicalPixelDisplaySizeRatio={1.0}}}}, mRoundedCorners=RoundedCorners{[RoundedCorner{position=TopLeft, radius=90, center=Point(90, 90)}, RoundedCorner{position=TopRight, radius=90, center=Point(990, 90)}, RoundedCorner{position=BottomRight, radius=90, center=Point(990, 2310)}, RoundedCorner{position=BottomLeft, radius=90, center=Point(90, 2310)}]}  mRoundedCornerFrame=Rect(0, 0 - 1080, 2400), mPrivacyIndicatorBounds=PrivacyIndicatorBounds {static bounds=Rect(948, 0 - 1080, 80) rotation=0}, mDisplayShape=DisplayShape{ spec=-311912193 displayWidth=1080 displayHeight=2400 physicalPixelDisplaySizeRatio=1.0 rotation=0 offsetX=0 offsetY=0 scale=1.0}, mSources= { InsetsSource: {a1c30001 mType=navigationBars mFrame=[0,2256][1080,2400] mVisible=true mFlags=[]}, InsetsSource: {a1c30004 mType=systemGestures mFrame=[0,0][0,0] mVisible=true mFlags=[]}, InsetsSource: {a1c30005 mType=mandatorySystemGestures mFrame=[0,2256][1080,2400] mVisible=true mFlags=[]}, InsetsSource: {a1c30006 mType=tappableElement mFrame=[0,2256][1080,2400] mVisible=true mFlags=[]}, InsetsSource: {a1c30024 mType=systemGestures mFrame=[0,0][0,0] mVisible=true mFlags=[]}, InsetsSource: {3 mType=ime mFrame=[0,0][0,0] mVisible=false mFlags=[]}, InsetsSource: {27 mType=displayCutout mFrame=[0,0][1080,80] mVisible=true mFlags=[]}, InsetsSource: {765e0000 mType=statusBars mFrame=[0,0][1080,80] mVisible=true mFlags=[]}, InsetsSource: {765e0005 mType=mandatorySystemGestures mFrame=[0,0][1080,116] mVisible=true mFlags=[]}, InsetsSource: {765e0006 mType=tappableElement mFrame=[0,0][1080,80] mVisible=true mFlags=[]} }
10-04 16:55:38.657  2453  2453 I ViewRootImpl@93f9b16[LauncherActivity]: handleWindowFocusChanged: 0 0 call from android.view.ViewRootImpl.-$$Nest$mhandleWindowFocusChanged:0
10-04 16:55:38.657  2453  2453 I ImeFocusController: onPreWindowFocus: skipped, hasWindowFocus=false mHasImeFocus=true
10-04 16:55:38.658  2042  2227 I BLASTBufferQueue_Java: new BLASTBufferQueue, mName= ViewRootImpl@1771f10[mauiappwindowtest] mNativeObject= 0xb4000078cd4b4770 sc.mNativeObject= 0xb400007a2d4545d0 caller= android.view.ViewRootImpl.updateBlastSurfaceIfNeeded:3028 android.view.ViewRootImpl.relayoutWindow:10131 android.view.ViewRootImpl.performTraversals:4110 android.view.ViewRootImpl.doTraversal:3288 android.view.ViewRootImpl$TraversalRunnable.run:11344 android.view.Choreographer$CallbackRecord.run:1689 android.view.Choreographer$CallbackRecord.run:1698 android.view.Choreographer.doCallbacks:1153 android.view.Choreographer.doFrame:1079 android.view.Choreographer$FrameDisplayEventReceiver.run:1646 
10-04 16:55:38.658  2042  2227 I BLASTBufferQueue_Java: update, w= 1080 h= 2400 mName = ViewRootImpl@1771f10[mauiappwindowtest] mNativeObject= 0xb4000078cd4b4770 sc.mNativeObject= 0xb400007a2d4545d0 format= -3 caller= android.graphics.BLASTBufferQueue.<init>:89 android.view.ViewRootImpl.updateBlastSurfaceIfNeeded:3028 android.view.ViewRootImpl.relayoutWindow:10131 android.view.ViewRootImpl.performTraversals:4110 android.view.ViewRootImpl.doTraversal:3288 android.view.ViewRootImpl$TraversalRunnable.run:11344 
10-04 16:55:38.658  2453  2453 I ImeFocusController: onPostWindowFocus: skipped, hasWindowFocus=false mHasImeFocus=true
10-04 16:55:38.658  2042  2227 I ViewRootImpl@1771f10[mauiappwindowtest]: Relayout returned: old=(0,0,1080,2400) new=(0,0,1080,2400) relayoutAsync=false req=(1080,2400)0 dur=8 res=0x403 s={true 0xb40000781d51f360} ch=true seqId=0
10-04 16:55:38.658  2042  2227 I ViewRootImpl@1771f10[mauiappwindowtest]: performConfigurationChange setNightDimText nightDimLevel=0
10-04 16:55:38.658  2042  2227 D ViewRootImpl@1771f10[mauiappwindowtest]: mThreadedRenderer.initialize() mSurface={isValid=true 0xb40000781d51f360} hwInitialized=true
10-04 16:55:38.658  2042  2227 D ViewRootImpl@1771f10[mauiappwindowtest]: reportNextDraw android.view.ViewRootImpl.performTraversals:4718 android.view.ViewRootImpl.doTraversal:3288 android.view.ViewRootImpl$TraversalRunnable.run:11344 android.view.Choreographer$CallbackRecord.run:1689 android.view.Choreographer$CallbackRecord.run:1698 
10-04 16:55:38.658  2042  2227 I ViewRootImpl@1771f10[mauiappwindowtest]: Setup new sync=wmsSync-ViewRootImpl@1771f10[mauiappwindowtest]#46
10-04 16:55:38.658  2042  2227 I ViewRootImpl@1771f10[mauiappwindowtest]: Creating new active sync group ViewRootImpl@1771f10[mauiappwindowtest]#47
10-04 16:55:38.659  2042  2227 I ViewRootImpl@1771f10[mauiappwindowtest]: registerCallbacksForSync syncBuffer=false
10-04 16:55:38.659  2042  2784 I ViewRootImpl@1771f10[mauiappwindowtest]: Received frameDrawingCallback syncResult=0 frameNum=1.
10-04 16:55:38.659  2042  2784 I ViewRootImpl@1771f10[mauiappwindowtest]: mWNT: t=0xb40000786d4a33f0 mBlastBufferQueue=0xb4000078cd4b4770 fn= 1 mRenderHdrSdrRatio=1.0 caller= android.view.ViewRootImpl$8.onFrameDraw:13841 android.view.ThreadedRenderer$1.onFrameDraw:792 <bottom of call stack> 
10-04 16:55:38.659  2042  2784 I ViewRootImpl@1771f10[mauiappwindowtest]: Setting up sync and frameCommitCallback
10-04 16:55:38.661   959   959 D Zygote  : Forked child process 17175
10-04 16:55:38.661  2042  2255 I BLASTBufferQueue: [ViewRootImpl@1771f10[mauiappwindowtest]#239](f:0,a:0,s:0) onFrameAvailable the first frame is available
10-04 16:55:38.661  2042  2255 I ViewRootImpl@1771f10[mauiappwindowtest]: Received frameCommittedCallback lastAttemptedDrawFrameNum=1 didProduceBuffer=true
10-04 16:55:38.662  2042  2255 D OpenGLRenderer: CFMS:: SetUp Pid : 2042    Tid : 2255
10-04 16:55:38.662  2362  2362 D HidDeviceService: handleMessage(): msg.what=8
10-04 16:55:38.662  1427  1589 I ActivityManager: Start proc 17175:com.companyname.mauiappwindowtest/u0a384 for next-top-activity {com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity}
10-04 16:55:38.662  2042  2227 I ViewRootImpl@1771f10[mauiappwindowtest]: reportDrawFinished seqId=0
10-04 16:55:38.663  1427  9415 D WindowManager: finishDrawingWindow: Window{e051b5a u0 Splash Screen com.companyname.mauiappwindowtest} mDrawState=DRAW_PENDING seqId=0
10-04 16:55:38.663  1427  9415 V WindowManager: Finishing drawing window Window{e051b5a u0 Splash Screen com.companyname.mauiappwindowtest}: mDrawState=DRAW_PENDING
10-04 16:55:38.663  1427  9415 V WindowManager: Draw state now committed in Window{e051b5a u0 Splash Screen com.companyname.mauiappwindowtest}
10-04 16:55:38.663  1427  1582 V Transition:  allReady query: used=true, override=false, defer=0, states=Display{#0 state=ON size=1080x2400 ROTATION_0}:true
10-04 16:55:38.664  1427  1582 V WindowManager: SyncGroup 430: Finished!
10-04 16:55:38.664  1427  1582 V WindowManager: performShowLocked: mDrawState=HAS_DRAWN in Window{e051b5a u0 Splash Screen com.companyname.mauiappwindowtest}
10-04 16:55:38.664  1427  1582 D ChangeTransitionController: onTransactionReady: TransitionRecord{ebfce02 id=430 type=OPEN flags=0x0}
10-04 16:55:38.664  1427  1582 V WindowManager: Start calculating TransitionInfo based on participants: {WallpaperWindowToken{1f6c5ec token=android.os.Binder@a0f609f}, Task{3b8c950 #149 type=standard A=10384:com.companyname.mauiappwindowtest}, ActivityRecord{bc89e32 u0 com.sec.android.app.launcher/.activities.LauncherActivity t6}, ActivityRecord{ffb8313 u0 com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity t149}}
10-04 16:55:38.664  1427  1582 V WindowManager:   Final targets: [Task{3b8c950 #149 type=standard A=10384:com.companyname.mauiappwindowtest}, Task{d25c7b4 #1 type=home}]
10-04 16:55:38.664  1073  2470 I SurfaceFlinger: id=5579 createSurf, flag=84004, Transition Root: Task=149#5579
10-04 16:55:38.665  1427  1582 I SurfaceControl: show, t=StartTransaction_SyncId<430>, sc=Surface(name=ActivityRecord{ffb8313 u0 com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity t149})/@0xb6144c8, caller=com.android.server.wm.Transition.onTransactionReady:1992 com.android.server.wm.BLASTSyncEngine$SyncGroup.finishNow:315 com.android.server.wm.BLASTSyncEngine$SyncGroup.tryFinish:242 com.android.server.wm.BLASTSyncEngine$SyncGroup.-$$Nest$mtryFinish:0 com.android.server.wm.BLASTSyncEngine.onSurfacePlacement:675 com.android.server.wm.RootWindowContainer.performSurfacePlacementNoTrace:990 
10-04 16:55:38.665  1427  1582 V WindowManager: Calling onTransitionReady: {id=430 t=OPEN f=0x0 trk=0 r=[0@Point(0, 0)] c=[
10-04 16:55:38.665  1427  1582 V WindowManager:         {WCT{RemoteToken{5a9e574 Task{3b8c950 #149 type=standard A=10384:com.companyname.mauiappwindowtest}}} m=OPEN f=NONE leash=Surface(name=Task=149)/@0x8b19c86 sb=Rect(0, 0 - 1080, 2400) eb=Rect(0, 0 - 1080, 2400) d=0 dim=true inset=Rect(0, 80 - 0, 144)},
10-04 16:55:38.665  1427  1582 V WindowManager:         {WCT{RemoteToken{a964ae4 Task{d25c7b4 #1 type=home}}} m=TO_BACK f=SHOW_WALLPAPER|EDGE_EXTENSION_RESTRICTION leash=Surface(name=Task=1)/@0x310faab sb=Rect(0, 0 - 1080, 2400) eb=Rect(0, 0 - 1080, 2400) d=0 inset=Rect(0, 80 - 0, 144)}
10-04 16:55:38.665  1427  1582 V WindowManager:     ]}
10-04 16:55:38.666  1427  1578 V WindowManager: Sent Transition #430 createdAt=10-04 16:55:38.637 via request=TransitionRequestInfo { type = OPEN, triggerTask = TaskInfo{userId=0 taskId=149 displayId=0 isRunning=true baseIntent=Intent { act=android.intent.action.MAIN cat=[android.intent.category.LAUNCHER] flg=0x10200000 cmp=com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity } baseActivity=ComponentInfo{com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity} topActivity=ComponentInfo{com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity} origActivity=null realActivity=ComponentInfo{com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity} numActivities=1 lastActiveTime=156092501 supportsMultiWindow=true resizeMode=1 isResizeable=true minWidth=-1 minHeight=-1 maxWidth=-1 maxHeight=-1 defaultMinSize=220 token=WCT{RemoteToken{5a9e574 Task{3b8c950 #149 type=standard A=10384:com.companyname.mauiappwindowtest}}} topActivityType=1 pictureInPictureParams=null shouldDockBigOverlays=false launchIntoPipHostTaskId=-1 lastParentTaskIdBeforePip=-1 displayCutoutSafeInsets=Rect(0, 80 - 0, 0) topActivityInfo=ActivityInfo{8f83a9d crc6457a4a0fbbd3bbed6.MainActivity} launchCookies=[android.os.BinderProxy@5fafb12] positionInParent=Point(0, 0) parentTaskId=-1 isFocused=false isVisible=false isVisibleRequested=false isSleeping=false topActivityInSizeCompat=false topActivityEligibleForLetterboxEducation= false topActivityLetterboxed= false isFromDoubleTap= false topActivityLetterboxVerticalPosition= -1 topActivityLetterboxHorizontalPosition= -1 topActivityLetterboxWidth=-1 topActivityLetterboxHeight=-1 locusId=null displayAreaFeatureId=1 cameraCompatControlState=hidden originallySupportedMultiWindow=true hasWallpaper=false topActivityInFixedAspectRatio=false rootAffinity=10384:com.companyname.mauiappwindowtest topActivityInDisplayCompat=false topActivityInBoundsCompat=false topActivityBounds=null singleTapFromLetterbox=false isTopTaskInStage=false topActivityUiMode=17 CoverLauncherWidgetTask=false CoverScreenTask=false isAllowedSeamlessRotation=false isTopTransparentActivity=false hasPopOver=false}, remoteTransition = RemoteTransition { remoteTransition = android.window.IRemoteTransition$Stub$Proxy@64892e3, appThread = android.app.IApplicationThread$Stub$Proxy@839e4e0, debugName = QuickstepLaunch }, displayChange = null }
10-04 16:55:38.666  1427  1578 V WindowManager:     startWCT=WindowContainerTransaction { changes = {} hops = [] errorCallbackToken=null taskFragmentOrganizer=null }
10-04 16:55:38.666  1427  1582 I WindowManager: Cancelling animation restarting=true, leash=Surface(name=Surface(name=3d202b3 StatusBar)/@0x8456cea - animation-leash of insets_animation)/@0x2f5f5fe
10-04 16:55:38.666  1427  1582 I WindowManager: Reparenting to original parent: Surface(name=WindowToken{4280822 type=2000 android.os.BinderProxy@5344804})/@0x3badbdb, destroy=false, surface=Surface(name=3d202b3 StatusBar)/@0x8456cea
10-04 16:55:38.666  1427  1578 V WindowManager:     info={id=430 t=OPEN f=0x0 trk=0 r=[0@Point(0, 0)] c=[
10-04 16:55:38.666  1427  1578 V WindowManager:         {WCT{RemoteToken{5a9e574 Task{3b8c950 #149 type=standard A=10384:com.companyname.mauiappwindowtest}}} m=OPEN f=NONE leash=Surface(name=Task=149)/@0x8b19c86 sb=Rect(0, 0 - 1080, 2400) eb=Rect(0, 0 - 1080, 2400) d=0 dim=true inset=Rect(0, 80 - 0, 144)},
10-04 16:55:38.666  1427  1578 V WindowManager:         {WCT{RemoteToken{a964ae4 Task{d25c7b4 #1 type=home}}} m=TO_BACK f=SHOW_WALLPAPER|EDGE_EXTENSION_RESTRICTION leash=Surface(name=Task=1)/@0x310faab sb=Rect(0, 0 - 1080, 2400) eb=Rect(0, 0 - 1080, 2400) d=0 inset=Rect(0, 80 - 0, 144)}
10-04 16:55:38.666  1427  1578 V WindowManager:     ]}
10-04 16:55:38.666  1427  1582 I WindowManager: Reparenting to leash, surface=Surface(name=3d202b3 StatusBar)/@0x8456cea, leashParent=Surface(name=WindowToken{4280822 type=2000 android.os.BinderProxy@5344804})/@0x3badbdb
10-04 16:55:38.666  1073  1124 I SurfaceFlinger: id=5580 createSurf, flag=24000, Surface(name=3d202b3 StatusBar)/@0x8456cea - animation-leash of insets_animation#5580
10-04 16:55:38.667  2042  2164 V WindowManagerShell: onTransitionReady android.os.BinderProxy@18f4a09: {id=430 t=OPEN f=0x0 trk=0 r=[0@Point(0, 0)] c=[{WCT{android.window.IWindowContainerToken$Stub$Proxy@6befcbe} m=OPEN f=NONE leash=Surface(name=Task=149)/@0xdf91bc3 sb=Rect(0, 0 - 1080, 2400) eb=Rect(0, 0 - 1080, 2400) d=0 dim=true inset=Rect(0, 80 - 0, 144)},{WCT{android.window.IWindowContainerToken$Stub$Proxy@947b11f} m=TO_BACK f=SHOW_WALLPAPER|EDGE_EXTENSION_RESTRICTION leash=Surface(name=Task=1)/@0x5586c40 sb=Rect(0, 0 - 1080, 2400) eb=Rect(0, 0 - 1080, 2400) d=0 inset=Rect(0, 80 - 0, 144)}]}
10-04 16:55:38.667  2042  2164 I SurfaceControl: hide, t=FinishTransaction_SyncId<430>, sc=Surface(name=Task=1)/@0x5586c40, caller=com.android.wm.shell.transition.Transitions.dispatchReady:681 com.android.wm.shell.transition.Transitions.onTransitionReady:118 com.android.wm.shell.transition.Transitions$TransitionPlayerImpl$$ExternalSyntheticLambda0.run:13 android.os.Handler.handleCallback:958 android.os.Handler.dispatchMessage:99 android.os.Looper.loopOnce:230 
10-04 16:55:38.667  2042  2164 I SurfaceControl: show, t=StartTransaction_SyncId<430>, sc=Surface(name=Task=149)/@0xdf91bc3, caller=com.android.wm.shell.transition.Transitions.dispatchReady:686 com.android.wm.shell.transition.Transitions.onTransitionReady:118 com.android.wm.shell.transition.Transitions$TransitionPlayerImpl$$ExternalSyntheticLambda0.run:13 android.os.Handler.handleCallback:958 android.os.Handler.dispatchMessage:99 android.os.Looper.loopOnce:230 
10-04 16:55:38.667  2042  2164 I SurfaceControl: show, t=FinishTransaction_SyncId<430>, sc=Surface(name=Task=149)/@0xdf91bc3, caller=com.android.wm.shell.transition.Transitions.dispatchReady:743 com.android.wm.shell.transition.Transitions.onTransitionReady:118 com.android.wm.shell.transition.Transitions$TransitionPlayerImpl$$ExternalSyntheticLambda0.run:13 android.os.Handler.handleCallback:958 android.os.Handler.dispatchMessage:99 android.os.Looper.loopOnce:230 
10-04 16:55:38.667  2042  2164 V WindowManagerShell: Playing animation for (#430)android.os.BinderProxy@18f4a09@0
10-04 16:55:38.667  2042  2164 I SurfaceControl: show, t=StartTransaction_SyncId<430>, sc=Surface(name=Transition Root: Task=149)/@0x121c779, caller=com.android.wm.shell.transition.Transitions.playTransition:80 com.android.wm.shell.transition.Transitions.processReadyQueue:195 com.android.wm.shell.transition.Transitions.dispatchReady:761 com.android.wm.shell.transition.Transitions.onTransitionReady:118 com.android.wm.shell.transition.Transitions$TransitionPlayerImpl$$ExternalSyntheticLambda0.run:13 android.os.Handler.handleCallback:958 
10-04 16:55:38.667  1427  1582 D WindowManager: makeSurface duration=1 leash=Surface(name=Surface(name=3d202b3 StatusBar)/@0x8456cea - animation-leash of insets_animation)/@0xd09b65e
10-04 16:55:38.667  2042  2164 V WindowManagerShell:  try firstHandler com.android.wm.shell.transition.DefaultMixedHandler@eea4ff2
10-04 16:55:38.667  2042  2164 V WindowManagerShell:  Delegate animation for #430 to RemoteTransition { remoteTransition = android.window.IRemoteTransition$Stub$Proxy@d97dc5, appThread = android.app.IApplicationThread$Stub$Proxy@c4ac31a, debugName = QuickstepLaunch }
10-04 16:55:38.667  1427  1582 D InsetsSourceProvider: updateControlForTarget: control=InsetsSourceControl: {765e0000 mType=statusBars initiallyVisible mSurfacePosition=Point(0, 0) mInsetsHint=Insets{left=0, top=80, right=0, bottom=0}}, target=Window{e051b5a u0 Splash Screen com.companyname.mauiappwindowtest}, from=com.android.server.wm.InsetsStateController.onControlTargetChanged:358 com.android.server.wm.InsetsStateController.onBarControlTargetChanged:324 com.android.server.wm.InsetsPolicy.updateBarControlTarget:173 com.android.server.wm.InsetsPolicy.updateSystemBars:805 com.android.server.wm.DisplayPolicy.updateSystemBarsLw:3425 
10-04 16:55:38.667  1427  1582 I WindowManager: Cancelling animation restarting=true, leash=Surface(name=Surface(name=e6bbee6 NavigationBar0)/@0xd856db6 - animation-leash of insets_animation)/@0x774c7ac
10-04 16:55:38.667  1427  1582 I WindowManager: Reparenting to original parent: Surface(name=WindowToken{27ee5c5 type=2019 android.os.BinderProxy@9a062f})/@0xa015ab7, destroy=false, surface=Surface(name=e6bbee6 NavigationBar0)/@0xd856db6
10-04 16:55:38.667  1427  1582 I WindowManager: Reparenting to leash, surface=Surface(name=e6bbee6 NavigationBar0)/@0xd856db6, leashParent=Surface(name=WindowToken{27ee5c5 type=2019 android.os.BinderProxy@9a062f})/@0xa015ab7
10-04 16:55:38.667  1073  1124 I SurfaceFlinger: id=5581 createSurf, flag=24000, Surface(name=e6bbee6 NavigationBar0)/@0xd856db6 - animation-leash of insets_animation#5581
10-04 16:55:38.668  1427  1582 D WindowManager: makeSurface duration=1 leash=Surface(name=Surface(name=e6bbee6 NavigationBar0)/@0xd856db6 - animation-leash of insets_animation)/@0x8086f0c
10-04 16:55:38.668  2042  2164 V WindowManagerShell:  animated by firstHandler
10-04 16:55:38.668  1073  1124 I SurfaceFlinger: id=5582 createSurf, flag=84000, Surface(name=Task=149)/@0x863b86a_transition-leash#5582
10-04 16:55:38.668  1427  1582 D InsetsSourceProvider: updateControlForTarget: control=InsetsSourceControl: {a1c30001 mType=navigationBars initiallyVisible mSurfacePosition=Point(0, 2256) mInsetsHint=Insets{left=0, top=0, right=0, bottom=144}}, target=Window{e051b5a u0 Splash Screen com.companyname.mauiappwindowtest}, from=com.android.server.wm.InsetsStateController.onControlTargetChanged:358 com.android.server.wm.InsetsStateController.onBarControlTargetChanged:327 com.android.server.wm.InsetsPolicy.updateBarControlTarget:173 com.android.server.wm.InsetsPolicy.updateSystemBars:805 com.android.server.wm.DisplayPolicy.updateSystemBarsLw:3425 
10-04 16:55:38.668  2453 12358 I SurfaceControl: show, t=StartTransaction_SyncId<430>, sc=Surface(name=Task=149)/@0x863b86a, caller=com.android.wm.shell.util.TransitionUtil.createLeash:127 com.android.wm.shell.util.TransitionUtil.newTarget:2 com.android.wm.shell.util.TransitionUtil.newTarget:1 com.android.systemui.shared.system.RemoteAnimationTargetCompat.wrap:48 com.android.systemui.shared.system.RemoteAnimationTargetCompat.wrapApps:5 com.android.systemui.shared.system.RemoteAnimationRunnerCompat$1.startAnimation:19 
10-04 16:55:38.668  1073  1124 I SurfaceFlinger: id=5583 createSurf, flag=84000, Surface(name=Task=1)/@0x8c67df8_transition-leash#5583
10-04 16:55:38.668  2453 12358 I SurfaceControl: show, t=StartTransaction_SyncId<430>, sc=Surface(name=Task=1)/@0x8c67df8, caller=com.android.wm.shell.util.TransitionUtil.createLeash:127 com.android.wm.shell.util.TransitionUtil.newTarget:2 com.android.wm.shell.util.TransitionUtil.newTarget:1 com.android.systemui.shared.system.RemoteAnimationTargetCompat.wrap:48 com.android.systemui.shared.system.RemoteAnimationTargetCompat.wrapApps:5 com.android.systemui.shared.system.RemoteAnimationRunnerCompat$1.startAnimation:19 
10-04 16:55:38.668  2453 12358 I SurfaceControl: apply is called, name=StartTransaction_SyncId<430>, caller=android.view.SurfaceControl$Transaction.apply:2921 com.android.systemui.shared.system.RemoteAnimationRunnerCompat$1.startAnimation:658 android.window.IRemoteTransition$Stub.onTransact:131 android.os.Binder.execTransactInternal:1380 android.os.Binder.execTransact:1311 <bottom of call stack> 
10-04 16:55:38.668  2042  2042 D SysUiState: SysUiState changed: old=0x10000000 new=0x10020000
10-04 16:55:38.669  1427  1582 D WindowManager: updateSystemBarAttributes: displayId=0, win=Window{e051b5a u0 Splash Screen com.companyname.mauiappwindowtest}, navColorWin=Window{e051b5a u0 Splash Screen com.companyname.mauiappwindowtest}, focusedCanBeNavColorWin=false, behavior=1, appearance=0, statusBarAppearanceRegions=[AppearanceRegion{ bounds=[0,0][1080,2400]}], requestedVisibilities=-9, from=com.android.server.wm.DisplayPolicy.finishPostLayoutPolicyLw:2320 com.android.server.wm.DisplayContent.applySurfaceChangesTransaction:6130 com.android.server.wm.RootWindowContainer.applySurfaceChangesTransaction:1180 
10-04 16:55:38.669  2453 15403 I HoneySpace.SystemUiRepository: systemUiFlags: allow_gesture|awake
10-04 16:55:38.669  2453  2585 I HoneySpace.TaskbarEventTracker: invokeEvent() called with: event = SystemUiStateChanged(stateFlags=268566528)
10-04 16:55:38.669  2453 12358 I HoneySpace.ShellAnimationRunner: [onAnimationStart] appTarget(0) : taskId-149, mode-0
10-04 16:55:38.669  2453 12358 I HoneySpace.ShellAnimationRunner: [onAnimationStart] appTarget(1) : taskId-1, mode-1
10-04 16:55:38.669  2453  2453 I HoneySpace.ShellTransitionManager: open animation start
10-04 16:55:38.669  2453  2453 I HoneySpace.ShellAnimationRunner: finishExistingAnimation, null
10-04 16:55:38.669  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: onAnimationStart
10-04 16:55:38.669  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: composeIconLaunchAnimator
10-04 16:55:38.669  2453  2453 I HoneySpace.TransitionUtils: areAllTargetsTranslucent - false
10-04 16:55:38.669  1073  1124 I SurfaceFlinger: id=5584 createSurf, flag=84000, bb1c34d ActivityRecordInputSink com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity#5584
10-04 16:55:38.670  2042  2042 D NavigationModeController: getCurrentUserContext: contextUser=0 currentUser=0
10-04 16:55:38.671  2042  2227 I InsetsSourceConsumer: applyRequestedVisibilityToControl: visible=true, type=statusBars, host=Splash Screen com.companyname.mauiappwindowtest
10-04 16:55:38.671  2042  2227 I InsetsSourceConsumer: applyRequestedVisibilityToControl: visible=true, type=navigationBars, host=Splash Screen com.companyname.mauiappwindowtest
10-04 16:55:38.672  2042  2042 D NavigationModeController: getCurrentUserContext: contextUser=0 currentUser=0
10-04 16:55:38.673  1073  1073 I Layer   : Layer [Transition Root: Task=149#5579] hidden!! flag(0)
10-04 16:55:38.673  1073  1073 I Layer   : Layer [Splash Screen com.companyname.mauiappwindowtest$_2042#5578] hidden!! flag(0)
10-04 16:55:38.673  1073  1073 I Layer   : Layer [e051b5a Splash Screen com.companyname.mauiappwindowtest#5577] hidden!! flag(0)
10-04 16:55:38.673  1073  1073 I Layer   : Layer [ActivityRecord{ffb8313 u0 com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity t149}#5576] hidden!! flag(0)
10-04 16:55:38.673  1073  1073 I Layer   : Layer [Task=149#5575] hidden!! flag(0)
10-04 16:55:38.673  1073  1073 I Layer   : id=5568 removeFromCurrentState Surface(name=3d202b3 StatusBar)/@0x8456cea - animation-leash of insets_animation#5568 (127)
10-04 16:55:38.673  1073  1073 I Layer   : id=5569 removeFromCurrentState Surface(name=e6bbee6 NavigationBar0)/@0xd856db6 - animation-leash of insets_animation#5569 (127)
10-04 16:55:38.673  2453  2453 I AppIconSolution: getThemeIconWithBG called with public API, pkg = com.companyname.mauiappwindowtest, mode = 48
10-04 16:55:38.673  2453  2453 I AppIconSolution: return adaptive icon for com.companyname.mauiappwindowtest, isNight = false
10-04 16:55:38.674  2042  2042 D NavigationModeController: getCurrentUserContext: contextUser=0 currentUser=0
10-04 16:55:38.674 17175 17175 I uiappwindowtest: Late-enabling -Xcheck:jni
10-04 16:55:38.675  2453  2453 I LauncherActivityInfo: packageName: com.companyname.mauiappwindowtest, useThemeIcon: false, height: 288, width: 288, density: 640
10-04 16:55:38.675  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 0.0, current rect : RectF(318.11, 684.96277, 510.89, 877.7428), crop rect : Rect(0, 429 - 1080, 1509)
10-04 16:55:38.675  2453  2453 I HoneySpace.ContentsAnimator: from : 0.0
10-04 16:55:38.675  2453  2453 I HoneySpace.ContentsAnimator: ContentsAnimator start
10-04 16:55:38.675  2453  2453 I HoneySpace.WallpaperAnimator: isOpen: true, from: 1.0, to: 1.2
10-04 16:55:38.675  2042  2042 D NavigationModeController: getCurrentUserContext: contextUser=0 currentUser=0
10-04 16:55:38.675  2453  2453 I HoneySpace.WallpaperAnimator: wallpaper animation start
10-04 16:55:38.675  2453  2453 I HoneySpace.AnimationResult: setAnimation, animation: false
10-04 16:55:38.675  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: [AppLaunch] START
10-04 16:55:38.675  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 0.0, current rect : RectF(318.11, 684.96277, 510.89, 877.7428), crop rect : Rect(0, 429 - 1080, 1509)
10-04 16:55:38.675  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 0.0, current rect : RectF(318.11, 684.96277, 510.89, 877.7428), crop rect : Rect(0, 429 - 1080, 1509)
10-04 16:55:38.676  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 0.0, current rect : RectF(318.11, 684.96277, 510.89, 877.7428), crop rect : Rect(0, 429 - 1080, 1509)
10-04 16:55:38.676  1427  4443 I WindowManager: Reparenting to leash, surface=Surface(name=RemoteWallpaperAnim:1:1)/@0x4ac17f2, leashParent=Surface(name=OneHanded:0:14)/@0x3be1e43
10-04 16:55:38.676  1073  2470 I SurfaceFlinger: id=5585 createSurf, flag=24000, Surface(name=RemoteWallpaperAnim:1:1)/@0x4ac17f2 - animation-leash of remote_wallpaper#5585
10-04 16:55:38.677  1427  4443 D WindowManager: makeSurface duration=0 leash=Surface(name=Surface(name=RemoteWallpaperAnim:1:1)/@0x4ac17f2 - animation-leash of remote_wallpaper)/@0xcb52055
10-04 16:55:38.677  2453  4617 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d4acf50 mBlastBufferQueue=0xb4000078cd47f250 fn= 91 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.677  2453  4617 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d407190 mBlastBufferQueue=0xb4000078cd47f250 fn= 91 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.677  2453  4617 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d491490 mBlastBufferQueue=0xb4000078cd47f250 fn= 91 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.677  2453  4617 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d4936f0 mBlastBufferQueue=0xb4000078cd47f250 fn= 91 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.677  1427  4443 D WindowManager: startAnimation for remote wallpaper, leash=Surface(name=Surface(name=RemoteWallpaperAnim:1:1)/@0x4ac17f2 - animation-leash of remote_wallpaper)/@0xcb52055
10-04 16:55:38.677  1427  4443 D WindowManager: startRemoteWallpaperAnimation, d=0, leash=Surface(name=Surface(name=RemoteWallpaperAnim:1:1)/@0x4ac17f2 - animation-leash of remote_wallpaper)/@0xcb52055
10-04 16:55:38.678  2042  2042 D NavigationModeController: getCurrentUserContext: contextUser=0 currentUser=0
10-04 16:55:38.679  1073  2470 I SurfaceFlinger: id=5568 Removed Surface(name=3d202b3 StatusBar)/@0x8456cea - animation-leash of insets_animation#5568 (128)
10-04 16:55:38.679  1073  1370 I SurfaceFlinger: id=5569 Removed Surface(name=e6bbee6 NavigationBar0)/@0xd856db6 - animation-leash of insets_animation#5569 (128)
10-04 16:55:38.681  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 0.114285715, current rect : RectF(317.39233, 684.3854, 512.1739, 879.16693), crop rect : Rect(0, 429 - 1080, 1509)
10-04 16:55:38.681  1073  1073 I Layer   : id=5569 Destroyed Surface(name=e6bbee6 NavigationBar0)/@0xd856db6 - animation-leash of insets_animation#5569
10-04 16:55:38.681  1073  1073 I Layer   : id=5568 Destroyed Surface(name=3d202b3 StatusBar)/@0x8456cea - animation-leash of insets_animation#5568
10-04 16:55:38.682  2453  4618 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d496b30 mBlastBufferQueue=0xb4000078cd47f250 fn= 92 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.682  2042  2042 I BLASTBufferQueue_Java: update, w= 1080 h= 144 mName = ViewRootImpl@141c4ca[NavigationBar0] mNativeObject= 0xb4000078cd42b290 sc.mNativeObject= 0xb400007a2d40c090 format= -3 caller= android.view.ViewRootImpl.updateBlastSurfaceIfNeeded:3017 android.view.ViewRootImpl.relayoutWindow:10131 android.view.ViewRootImpl.performTraversals:4110 android.view.ViewRootImpl.doTraversal:3288 android.view.ViewRootImpl$TraversalRunnable.run:11344 android.view.Choreographer$CallbackRecord.run:1689 
10-04 16:55:38.682  2042  2042 I ViewRootImpl@141c4ca[NavigationBar0]: Relayout returned: old=(0,2256,1080,2400) new=(0,2256,1080,2400) relayoutAsync=true req=(1080,144)0 dur=0 res=0x0 s={true 0xb40000781d4195b0} ch=false seqId=0
10-04 16:55:38.682  2042  2042 I ViewRootImpl@141c4ca[NavigationBar0]: registerCallbackForPendingTransactions
10-04 16:55:38.682  1427  2275 V WindowManager: Relayout Window{e6bbee6 u0 NavigationBar0}: viewVisibility=0 req=1080x144 ty=2019 d0
10-04 16:55:38.683  2042  2783 I ViewRootImpl@141c4ca[NavigationBar0]: mWNT: t=0xb40000786d481d10 mBlastBufferQueue=0xb4000078cd42b290 fn= 10714 mRenderHdrSdrRatio=1.0 caller= android.view.ViewRootImpl$6.onFrameDraw:5635 android.view.ViewRootImpl$2.onFrameDraw:2146 android.view.ThreadedRenderer$1.onFrameDraw:792 
10-04 16:55:38.686  1073  3020 D NativeSemDvfsManager: acquire:: timeout = 2000 mIsAcquired = 1  mTagName : SurfaceFlinger 
10-04 16:55:38.687  1073  3020 E NativeCustomFrequencyManager: [NativeCFMS] BpCustomFrequencyManager::acquire()
10-04 16:55:38.687   994  1071 I HYPER-HAL: [RequestManager.cpp]acquire(): Acquired ID : 2150701  [1073 / 1000]    HINT : SF_GPU_MINLOCK    list : [TIMEOUT / 2000] 
10-04 16:55:38.690  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 0.24285714, current rect : RectF(315.16754, 682.5952, 516.1541, 883.5818), crop rect : Rect(0, 429 - 1080, 1509)
10-04 16:55:38.690  1427  2275 V WindowManager: Relayout hash=e6bbee6, pid=0, syncId=-1: mAttrs={(0,0)(fillx144) gr=BOTTOM CENTER_VERTICAL sim={adjust=pan} layoutInDisplayCutoutMode=always ty=NAVIGATION_BAR fmt=TRANSLUCENT
10-04 16:55:38.690  1427  2275 V WindowManager:   fl=20840028
10-04 16:55:38.690  1427  2275 V WindowManager:   pfl=33001000
10-04 16:55:38.690  1427  2275 V WindowManager:   bhv=DEFAULT
10-04 16:55:38.690  1427  2275 V WindowManager:   providedInsets:
10-04 16:55:38.690  1427  2275 V WindowManager:     InsetsFrameProvider: {id=#a1c30001, index=0, type=navigationBars, source=FRAME, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=144}, insetsSizeOverrides=[TypedInsetsSize: {windowType=INPUT_METHOD, insetsSize=null}]}
10-04 16:55:38.690  1427  2275 V WindowManager:     InsetsFrameProvider: {id=#a1c30006, index=0, type=tappableElement, source=FRAME, flags=[]}
10-04 16:55:38.690  1427  2275 V WindowManager:     InsetsFrameProvider: {id=#a1c30005, index=0, type=mandatorySystemGestures, source=FRAME, flags=[]}
10-04 16:55:38.690  1427  2275 V WindowManager:     InsetsFrameProvider: {id=#a1c30004, index=0, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}}
10-04 16:55:38.690  1427  2275 V WindowManager:     InsetsFrameProvider: {id=#a1c30024, index=1, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}}
10-04 16:55:38.690  1427  2275 V WindowManager:   paramsForRotation:
10-04 16:55:38.690  1427  2275 V WindowManager:     ROTATION_0={(0,0)(fillx144) gr=BOTTOM CENTER_VERTICAL layoutInDisplayCutoutMode=always ty=NAVIGATION_BAR fmt=TRANSLUCENT
10-04 16:55:38.690  1427  2275 V WindowManager:       fl=20840028
10-04 16:55:38.690  1427  2275 V WindowManager:       pfl=31001000
10-04 16:55:38.690  1427  2275 V WindowManager:       bhv=DEFAULT
10-04 16:55:38.690  1427  2275 V WindowManager:       providedInsets:
10-04 16:55:38.690  1427  2275 V WindowManager:         InsetsFrameProvider: {id=#a1c30001, index=0, type=navigationBars, source=FRAME, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=144}, insetsSizeOverrides=[TypedInsetsSize: {windowType=INPUT_METHOD, insetsSize=null}]}
10-04 16:55:38.690  1427  2275 V WindowManager:         InsetsFrameProvider: {id=#a1c30006, index=0, type=tappableElement, source=FRAME, flags=[]}
10-04 16:55:38.690  1427  2275 V WindowManager:         InsetsFrameProvider: {id=#a1c30005, index=0, type=mandatorySystemGestures, source=FRAME, flags=[]}
10-04 16:55:38.690  1427  2275 V WindowManager:         InsetsFrameProvider: {id=#a1c30004, index=0, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}}
10-04 16:55:38.690  1427  2275 V WindowManager:         InsetsFrameProvider: {id=#a1c30024, index=1, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}} naviIconColor=0}
10-04 16:55:38.690  1427  2275 V WindowManager:     ROTATION_90={(0,0)(144xfill) gr=RIGHT CENTER_HORIZONTAL layoutInDisplayCutoutMode=always ty=NAVIGATION_BAR fmt=TRANSLUCENT
10-04 16:55:38.690  1427  2275 V WindowManager:       fl=20840028
10-04 16:55:38.690  1427  2275 V WindowManager:       pfl=31001000
10-04 16:55:38.690  1427  2275 V WindowManager:       bhv=DEFAULT
10-04 16:55:38.690  1427  2275 V WindowManager:       providedInsets:
10-04 16:55:38.690  1427  2275 V WindowManager:         InsetsFrameProvider: {id=#a1c30001, index=0, type=navigationBars, source=FRAME, flags=[], insetsSizeOverrides=[TypedInsetsSize: {windowType=INPUT_METHOD, insetsSize=null}]}
10-04 16:55:38.690  1427  2275 V WindowManager:         InsetsFrameProvider: {id=#a1c30006, index=0, type=tappableElement, source=FRAME, flags=[]}
10-04 16:55:38.690  1427  2275 V WindowManager:         InsetsFrameProvider: {id=#a1c30005, index=0, type=mandatorySystemGestures, source=FRAME, flags=[]}
10-04 16:55:38.690  1427  2275 V WindowManager:         InsetsFrameProvider: {id=#a1c30004, index=0, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}}
10-04 16:55:38.690  1427  2275 V WindowManager:         InsetsFrameProvider: {id=#a1c30024, index=1, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}} naviIconColor=0}
10-04 16:55:38.690  1427  2275 V WindowManager:     ROTATION_180={(0,0)(fillx144) gr=BOTTOM CENTER_VERTICAL layoutInDisplayCutoutMode=always ty=NAVIGATION_BAR fmt=TRANSLUCENT
10-04 16:55:38.690  1427  2275 V WindowManager:       fl=20840028
10-04 16:55:38.690  1427  2275 V WindowManager:       pfl=31001000
10-04 16:55:38.690  1427  2275 V WindowManager:       bhv=DEFAULT
10-04 16:55:38.690  1427  2275 V WindowManager:       providedInsets:
10-04 16:55:38.690  1427  2275 V WindowManager:         InsetsFrameProvider: {id=#a1c30001, index=0, type=navigationBars, source=FRAME, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=144}, insetsSizeOverrides=[TypedInsetsSize: {windowType=INPUT_METHOD, insetsSize=null}]}
10-04 16:55:38.690  1427  2275 V WindowManager:         InsetsFrameProvider: {id=#a1c30006, index=0, type=tappableElement, source=FRAME, flags=[]}
10-04 16:55:38.690  1427  2275 V WindowManager:         InsetsFrameProvider: {id=#a1c30005, index=0, type=mandatorySystemGestures, source=FRAME, flags=[]}
10-04 16:55:38.690  1427  2275 V WindowManager:         InsetsFrameProvider: {id=#a1c30004, index=0, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}}
10-04 16:55:38.690  1427  2275 V WindowManager:         InsetsFrameProvider: {id=#a1c30024, index=1, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}} naviIconColor=0}
10-04 16:55:38.690  1427  2275 V WindowManager:     ROTATION_270={(0,0)(144xfill) gr=LEFT CENTER_HORIZONTAL layoutInDisplayCutoutMode=always ty=NAVIGATION_BAR fmt=TRANSLUCENT
10-04 16:55:38.690  1427  2275 V WindowManager:       fl=20840028
10-04 16:55:38.690  1427  2275 V WindowManager:       pfl=31001000
10-04 16:55:38.690  1427  2275 V WindowManager:       bhv=DEFAULT
10-04 16:55:38.690  1427  2275 V WindowManager:       providedInsets:
10-04 16:55:38.690  1427  2275 V WindowManager:         InsetsFrameProvider: {id=#a1c30001, index=0, type=navigationBars, source=FRAME, flags=[], insetsSizeOverrides=[TypedInsetsSize: {windowType=INPUT_METHOD, insetsSize=null}]}
10-04 16:55:38.690  1427  2275 V WindowManager:         InsetsFrameProvider: {id=#a1c30006, index=0, type=tappableElement, source=FRAME, flags=[]}
10-04 16:55:38.690  1427  2275 V WindowManager:         InsetsFrameProvider: {id=#a1c30005, index=0, type=mandatorySystemGestures, source=FRAME, flags=[]}
10-04 16:55:38.690  1427  2275 V WindowManager:         InsetsFrameProvider: {id=#a1c30004, index=0, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}}
10-04 16:55:38.690  1427  2275 V WindowManager:         InsetsFrameProvider: {id=#a1c30024, index=1, type=systemGestures, source=DISPLAY, flags=[], insetsSize=Insets{left=0, top=0, right=0, bottom=0}, mMinimalInsetsSizeInDisplayCutoutSafe=Insets{left=0, top=0, right=0, bottom=0}} naviIconColor=0} naviIconColor=0}
10-04 16:55:38.690 17175 17175 I uiappwindowtest: Using CollectorTypeCC GC.
10-04 16:55:38.690  2453  4617 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d4aacf0 mBlastBufferQueue=0xb4000078cd47f250 fn= 93 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.696 17175 17175 D nativeloader: Load libframework-connectivity-tiramisu-jni.so using APEX ns com_android_tethering for caller /apex/com.android.tethering/javalib/framework-connectivity-t.jar: ok
10-04 16:55:38.698  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 0.3571429, current rect : RectF(311.32224, 679.5011, 523.03357, 891.2124), crop rect : Rect(0, 429 - 1080, 1509)
10-04 16:55:38.698  2453  4618 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d4a36b0 mBlastBufferQueue=0xb4000078cd47f250 fn= 94 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.699 14526 14531 I adbd    : jdwp connection from 17175
10-04 16:55:38.699 17175 17175 D ActivityThread: setConscryptValidator
10-04 16:55:38.699 17175 17175 D ActivityThread: setConscryptValidator - put
10-04 16:55:38.700  1073  1073 D SurfaceFlinger: Display 4633128672291735937 HWC layers:
10-04 16:55:38.700  1073  1073 D SurfaceFlinger:      CLIENT | 0xb400007784fa1a50 | 0100 | RGBA_8888    |  660.0    0.0 1735.0 2389.0 |    0    0 1080 2400 | Wallpaper BBQ wrapper 5_system#85
10-04 16:55:38.700  1073  1073 D SurfaceFlinger:      CLIENT | 0xb400007784fece50 | 0100 | RGBA_8888    |    0.0    0.0 1080.0 2400.0 |    0    0 1080 2400 | com.sec.android.app.launcher/com.sec[...]herActivity$_2453#5567 (blurRegions)
10-04 16:55:38.700  1073  1073 D SurfaceFlinger:      CLIENT | 0xb400007784fd3150 | 0100 | RGBA_8888    |    0.0  429.0 1080.0 1509.0 |  317  684  512  879 | Splash Screen com.companyname.mauiappwindowtest$_2042#5578
10-04 16:55:38.700  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784faccd0 | 0100 | RGBA_8888    |    0.0    0.0 1080.0   80.0 |    0    0 1080   80 | StatusBar$_2042#89
10-04 16:55:38.700  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784fe2110 | 0100 | RGBA_8888    |    0.0    0.0   67.0  342.0 | 1013  623 1080  965 | com.sec.android.app.launcher/com.sam[...]e.edge.CocktailBarService$_2453#2631
10-04 16:55:38.700  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784fab610 | 0100 | RGBA_8888    |    0.0    0.0 1080.0  144.0 |    0 2256 1080 2400 | NavigationBar0$_2042#82
10-04 16:55:38.700  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784fb6510 | 01
10-04 16:55:38.700  1073  1073 D SurfaceFlinger: 40 | RGBA_8888    |    0.0    0.0 1080.0   80.0 |    0    0 1080   80 | ScreenDecorOverlay$_2042#99
10-04 16:55:38.700  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784fd5ed0 | 0140 | RGBA_8888    |    0.0    0.0 1080.0   80.0 |    0 2320 1080 2400 | ScreenDecorOverlayBottom$_2042#100
10-04 16:55:38.700  1073  1073 D SurfaceFlinger: 
10-04 16:55:38.705  1427  4443 V WindowManager: rotationForOrientation(orient=SCREEN_ORIENTATION_UNSPECIFIED (-1), last=ROTATION_0 (0)); user=ROTATION_0 (0) 
10-04 16:55:38.705  1427  4443 D WindowManager: rotationForOrientation, orientationSource=ActivityRecord{ffb8313 u0 com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity t149}
10-04 16:55:38.705  1427  4443 V WindowManager: Computed rotation=ROTATION_0 (0) for display id=0 based on lastOrientation=SCREEN_ORIENTATION_UNSPECIFIED (-1) and oldRotation=ROTATION_0 (0), caller=com.android.server.wm.DisplayRotation.updateOrientation:517 com.android.server.wm.DisplayContent.updateOrientation:2176 com.android.server.wm.DisplayContent.updateOrientation:2092 com.android.server.wm.RootWindowContainer.ensureVisibilityAndConfig:2091 com.android.server.wm.ActivityTaskSupervisor.realStartActivityLocked:932 com.android.server.wm.RootWindowContainer$AttachApplicationHelper.test:4345 
10-04 16:55:38.706  1427  4443 D SGM:PkgDataHelper: notifyAppCreate(), pkgName: com.companyname.mauiappwindowtest, userId: 0, sendRet: true
10-04 16:55:38.706  1427  1807 D SGM:FgCheckThread: onLooperPrepared(), msg: MSG_APP_CREATE, pkgName: com.companyname.mauiappwindowtest, userId: 0
10-04 16:55:38.707  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 0.4857143, current rect : RectF(304.25583, 666.5298, 535.6756, 920.4487), crop rect : Rect(0, 395 - 1080, 1580)
10-04 16:55:38.708  2453  4617 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d481e70 mBlastBufferQueue=0xb4000078cd47f250 fn= 95 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.709  1427  4443 D SGM:FgCheckThread: TaskStackListener.onTaskFocusChanged(), taskId=6, focused=false
10-04 16:55:38.709  1427  4443 D SGM:FgCheckThread: TaskStackListener.onTaskFocusChanged(), taskId=149, focused=true
10-04 16:55:38.710  1427  4443 D SGM:FgCheckThread:   sendRunningComponentFocus(), pkgName: com.companyname.mauiappwindowtest, userId: 0
10-04 16:55:38.710  1427  1807 D SGM:FgCheckThread: onLooperPrepared(), msg: MSG_TASK_FOCUSED, pkgName: com.companyname.mauiappwindowtest, userId: 0
10-04 16:55:38.710  1427  1807 D SGM:FgCheckThread: handleTaskFocused().
10-04 16:55:38.710  1427  1807 D SGM:FgCheckThread:   handleTaskFocused(), pkgName: com.companyname.mauiappwindowtest, userID:0
10-04 16:55:38.710  1427  1807 D SGM:FgCheckThread: handleResume().
10-04 16:55:38.710  1427  4443 D InputDispatcher: Focused application(0): ActivityRecord{ffb8313 u0 com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity t149}
10-04 16:55:38.710  1427  4443 D SGM:FgCheckThread: TaskStackListener.onTaskFocusChanged(), taskId=6, focused=false
10-04 16:55:38.710  1427  1807 D SGM:FgCheckThread: sendFocusOutConditionally() - mPrevNotiPkg: (unknown), userId: 0
10-04 16:55:38.710  1427  4443 D SGM:FgCheckThread: TaskStackListener.onTaskFocusChanged(), taskId=149, focused=true
10-04 16:55:38.710  1427  4443 D SGM:FgCheckThread:   sendRunningComponentFocus(), pkgName: com.companyname.mauiappwindowtest, userId: 0
10-04 16:55:38.711  1427  1807 D SGM:FgCheckThread:   handleResume(). pkgName: com.companyname.mauiappwindowtest, userId: 0, isTunableApp: null
10-04 16:55:38.711  1427  1807 D SGM:FgCheckThread: notifyFocusInOut(). of pkg: com.companyname.mauiappwindowtest, type: 4, isTunableApp: false, userId: 0
10-04 16:55:38.711  1427  1807 D SGM:FgCheckThread:   notifyFocusInOut(). unexpected mPrevNotiType: -1
10-04 16:55:38.711  1427  1807 D SGM:SystemHelper: callReleaseBlock needReleaseBlock:false
10-04 16:55:38.711  1427  1807 D SGM:FgCheckThread: onLooperPrepared(), msg: MSG_TASK_FOCUSED, pkgName: com.companyname.mauiappwindowtest, userId: 0
10-04 16:55:38.711  1427  1807 D SGM:FgCheckThread: handleTaskFocused().
10-04 16:55:38.711  1427  1807 D SGM:FgCheckThread:   handleTaskFocused(), pkgName: com.companyname.mauiappwindowtest, userID:0
10-04 16:55:38.711  1427  1807 D SGM:FgCheckThread: handleResume().
10-04 16:55:38.711  1427  4443 D ActivityTaskManager: scheduleTopResumedActivityChanged, onTop=true, r=ActivityRecord{ffb8313 u0 com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity t149}, caller=com.android.server.wm.ActivityTaskSupervisor.scheduleTopResumedActivityStateIfNeeded:2857 com.android.server.wm.ActivityTaskSupervisor.updateTopResumedActivityIfNeeded:2849 com.android.server.wm.TaskFragment.setResumedActivity:579 com.android.server.wm.TaskFragment.onActivityStateChanged:903 com.android.server.wm.ActivityRecord.setState:6811 com.android.server.wm.Task.minimalResumeActivityLocked:6192 
10-04 16:55:38.711  1427  1807 D SGM:FgCheckThread: sendFocusOutConditionally() - mPrevNotiPkg: (unknown), userId: 0
10-04 16:55:38.711  1427  1807 D SGM:FgCheckThread:   handleResume(). pkgName: com.companyname.mauiappwindowtest, userId: 0, isTunableApp: null
10-04 16:55:38.711  1427  1807 D SGM:FgCheckThread: notifyFocusInOut(). of pkg: com.companyname.mauiappwindowtest, type: 4, isTunableApp: false, userId: 0
10-04 16:55:38.711  1427  1807 D SGM:FgCheckThread:   notifyFocusInOut(). unexpected mPrevNotiType: -1
10-04 16:55:38.711  1427  1807 D SGM:SystemHelper: callReleaseBlock needReleaseBlock:false
10-04 16:55:38.711  1427  4443 D WindowManagerServiceExt: notifyOccludeChangeNotice: cn=ComponentInfo{com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity} occludesParent=true isInSplitScreenMode=false styleFloating=false caller=com.android.server.wm.ActivityRecord.completeResumeLocked:7452 com.android.server.wm.Task.minimalResumeActivityLocked:6193 com.android.server.wm.ActivityTaskSupervisor.realStartActivityLocked:1158 com.android.server.wm.RootWindowContainer$AttachApplicationHelper.test:4345 com.android.server.wm.RootWindowContainer$AttachApplicationHelper.test:4281 
10-04 16:55:38.712  1427  1878 D AS.MultiSoundManager: mForegroundUid = 10384
10-04 16:55:38.712  1427  1878 D AS.MultiSoundManager: mForegroundUid = 10384
10-04 16:55:38.712  2453  2586 I HoneySpace.TopTaskSource: onTaskFocusChanged(): taskId = 149
10-04 16:55:38.712  2453  2586 I HoneySpace.TopTaskSource: onTaskFocusChanged(): taskId = 149
10-04 16:55:38.712  2453  2586 I HoneySpace.TopTaskSource: onTaskMovedToFront : taskId = 149
10-04 16:55:38.712  2453  2586 I HoneySpace.TopTaskSource: onTaskMovedToFront : taskId = 149
10-04 16:55:38.712  1427  1902 I CocktailBarManagerServiceContainer: handleMessage: entry what = 5
10-04 16:55:38.713  2453  2453 I Edge.ActivityUtils: HomePackage : com.sec.android.app.launcher, resumePackageName : com.companyname.mauiappwindowtest
10-04 16:55:38.713  1427  1581 D SGM:FgCheckThread: noteResumeComponent(), received pkgName: com.companyname.mauiappwindowtest, userId: 0
10-04 16:55:38.713 17175 17175 D CompatibilityChangeReporter: Compat change id reported: 171979766; UID 10384; state: ENABLED
10-04 16:55:38.714  1427  1807 D SGM:FgCheckThread: onLooperPrepared(), msg: MSG_APP_RESUME, pkgName: com.companyname.mauiappwindowtest, userid: 0
10-04 16:55:38.714  1427  1807 D SGM:FgCheckThread: handleResume().
10-04 16:55:38.714  1427  1807 D SGM:FgCheckThread: sendFocusOutConditionally() - mPrevNotiPkg: (unknown), userId: 0
10-04 16:55:38.714  1427  1807 D SGM:FgCheckThread:   handleResume(). pkgName: com.companyname.mauiappwindowtest, userId: 0, isTunableApp: null
10-04 16:55:38.714 17175 17175 D CompatibilityChangeReporter: Compat change id reported: 242716250; UID 10384; state: ENABLED
10-04 16:55:38.714  1427  1807 D SGM:FgCheckThread: notifyFocusInOut(). of pkg: com.companyname.mauiappwindowtest, type: 4, isTunableApp: false, userId: 0
10-04 16:55:38.714  1427  1807 D SGM:FgCheckThread:   notifyFocusInOut(). unexpected mPrevNotiType: -1
10-04 16:55:38.714  1427  1807 D SGM:SystemHelper: callReleaseBlock needReleaseBlock:false
10-04 16:55:38.714  1427  1581 D SGM:GameManager: identifyGamePackage. com.companyname.mauiappwindowtest, mCurrentUserId: 0, callerUserId: 0, callingMethodInfo: com.samsung.android.game.SemGameManager.isGamePackage(SemGameManager.java:109)
10-04 16:55:38.714  1427  1581 D SGM:PkgDataHelper: getGamePkgData(). com.companyname.mauiappwindowtest
10-04 16:55:38.714  1427  1581 D SGM:SemGameManager: isGamePackage(), pkgName=com.companyname.mauiappwindowtest, ret=false
10-04 16:55:38.714  1427  1581 I GameSDK@LifeCycle: noteResumeComponent(): package name  : com.companyname.mauiappwindowtest
10-04 16:55:38.714  1427  1581 I ActivityManager: Changes in 10384 19 to 2, 0 to 63
10-04 16:55:38.715  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 0.6, current rect : RectF(293.8533, 640.6074, 554.2861, 977.2409), crop rect : Rect(0, 326 - 1080, 1722)
10-04 16:55:38.716  2362  2362 D HidDeviceService: handleMessage(): msg.what=8
10-04 16:55:38.716  2453  4618 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d404170 mBlastBufferQueue=0xb4000078cd47f250 fn= 96 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.718  1427  1427 I WALLPAPER_SVC:SemWallpaperManagerService: isHomeActivityVisible : false 
10-04 16:55:38.718  1427  1579 D PkgPredictorService-SecIpmManagerServiceImpl: onForegroundActivitiesChanged pid:17175 uid:10384
10-04 16:55:38.718  1427  1427 D WALLPAPER_SVC:WallpaperManagerService: dispatchHomeVisibilityChanged: visible = false, connection = com.android.server.wallpaper.WallpaperManagerService$WallpaperConnection@99a56e8, systemWallpaper = WallpaperData@48ce4f1, id: 3, which: 5, file mod: 0, info: null, engine(s): Proxy@81367bb, type = 0, userId = 0, uri= null, wallpaperComponent = ComponentInfo{com.android.systemui/com.android.systemui.wallpapers.ImageWallpaper}, nextWallpaperComponent = ComponentInfo{com.android.systemui/com.android.systemui.wallpapers.ImageWallpaper} 
10-04 16:55:38.719  1427  1833 V NetworkPolicy: getFirewallRuleWifi UID:10384 policy:0
10-04 16:55:38.723  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 0.7142858, current rect : RectF(277.8918, 604.03564, 582.8418, 1058.0723), crop rect : Rect(0, 257 - 1080, 1865)
10-04 16:55:38.724  2453  4617 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d415b50 mBlastBufferQueue=0xb4000078cd47f250 fn= 97 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.724 17175 17175 W ziparchive: Unable to open '/data/app/~~ftu52CcVnrTUUPpUvNVZ1g==/com.companyname.mauiappwindowtest-228w7o67vLngLnX7vSDiVQ==/base.dm': No such file or directory
10-04 16:55:38.724 17175 17175 W ziparchive: Unable to open '/data/app/~~ftu52CcVnrTUUPpUvNVZ1g==/com.companyname.mauiappwindowtest-228w7o67vLngLnX7vSDiVQ==/base.dm': No such file or directory
10-04 16:55:38.731  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 0.8428571, current rect : RectF(253.31511, 546.7151, 626.81036, 1184.7695), crop rect : Rect(0, 180 - 1080, 2025)
10-04 16:55:38.732  2453  4618 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d490c50 mBlastBufferQueue=0xb4000078cd47f250 fn= 98 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.740  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 0.95714283, current rect : RectF(225.5487, 478.12634, 676.4854, 1336.5762), crop rect : Rect(0, 112 - 1080, 2168)
10-04 16:55:38.740  2453  4617 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d47ee50 mBlastBufferQueue=0xb4000078cd47f250 fn= 99 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.747  7973  7973 I A       : onPause
10-04 16:55:38.748  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 1.0, current rect : RectF(196.83037, 397.0899, 727.8636, 1512.2595), crop rect : Rect(0, 42 - 1080, 2310)
10-04 16:55:38.750  2453  4618 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d4474b0 mBlastBufferQueue=0xb4000078cd47f250 fn= 100 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.750  3946 11501 I SDHMS:l : onTaskStackChanged
10-04 16:55:38.752  2453 12442 I HoneySpace.RecentTasks: onRecentTasksChanged
10-04 16:55:38.757  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 1.0, current rect : RectF(168.33723, 321.94543, 778.83875, 1678.6155), crop rect : Rect(0, 0 - 1080, 2400)
10-04 16:55:38.757  2453  4617 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d4a3550 mBlastBufferQueue=0xb4000078cd47f250 fn= 101 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.762 17175 17175 D nativeloader: Configuring clns-4 for other apk /data/app/~~ftu52CcVnrTUUPpUvNVZ1g==/com.companyname.mauiappwindowtest-228w7o67vLngLnX7vSDiVQ==/base.apk. target_sdk_version=35, uses_libraries=, library_path=/data/app/~~ftu52CcVnrTUUPpUvNVZ1g==/com.companyname.mauiappwindowtest-228w7o67vLngLnX7vSDiVQ==/lib/arm64:/data/app/~~ftu52CcVnrTUUPpUvNVZ1g==/com.companyname.mauiappwindowtest-228w7o67vLngLnX7vSDiVQ==/base.apk!/lib/arm64-v8a, permitted_path=/data:/mnt/expand:/data/user/0/com.companyname.mauiappwindowtest
10-04 16:55:38.765  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 1.0, current rect : RectF(147.37025, 281.846, 816.3494, 1768.4666), crop rect : Rect(0, 0 - 1080, 2400)
10-04 16:55:38.765  2453  4618 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d49ccd0 mBlastBufferQueue=0xb4000078cd47f250 fn= 102 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.770 17175 17175 D nativeloader: Load libframework-connectivity-jni.so using APEX ns com_android_tethering for caller /apex/com.android.tethering/javalib/framework-connectivity.jar: ok
10-04 16:55:38.771  1427  2275 D VpnManagerService: Exception: java.lang.NullPointerException: Attempt to invoke interface method 'int com.samsung.android.knox.zt.networktrust.filter.IKnoxNetworkFilterService.getKnoxNwFilterHttpProxyPort(int, java.lang.String)' on a null object reference
10-04 16:55:38.771  1427  2275 D VpnManagerService: 	at com.android.server.VpnManagerService.getKnoxNwFilterHttpProxyPort(VpnManagerService.java:1945)
10-04 16:55:38.771  1427  2275 D VpnManagerService: 	at android.net.IVpnManager$Stub.onTransact(IVpnManager.java:1075)
10-04 16:55:38.771  1427  2275 D VpnManagerService: 	at android.os.Binder.execTransactInternal(Binder.java:1375)
10-04 16:55:38.771  1427  2275 D VpnManagerService: 	at android.os.Binder.execTransact(Binder.java:1311)
10-04 16:55:38.773 17175 17175 V GraphicsEnvironment: Currently set values for:
10-04 16:55:38.773 17175 17175 V GraphicsEnvironment:   angle_gl_driver_selection_pkgs=[]
10-04 16:55:38.773 17175 17175 V GraphicsEnvironment:   angle_gl_driver_selection_values=[]
10-04 16:55:38.773 17175 17175 V GraphicsEnvironment: ANGLE GameManagerService for com.companyname.mauiappwindowtest: false
10-04 16:55:38.773 17175 17175 V GraphicsEnvironment: com.companyname.mauiappwindowtest is not listed in per-application setting
10-04 16:55:38.773 17175 17175 V GraphicsEnvironment: App is not on the allowlist for updatable production driver.
10-04 16:55:38.773  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 1.0, current rect : RectF(126.91794, 242.73093, 852.93933, 1856.1118), crop rect : Rect(0, 0 - 1080, 2400)
10-04 16:55:38.774  2453  4617 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d48aab0 mBlastBufferQueue=0xb4000078cd47f250 fn= 103 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.782  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 1.0, current rect : RectF(112.81854, 215.76581, 878.16364, 1916.5327), crop rect : Rect(0, 0 - 1080, 2400)
10-04 16:55:38.782  2453  4618 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d47f270 mBlastBufferQueue=0xb4000078cd47f250 fn= 104 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.790  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 1.0, current rect : RectF(99.12894, 189.58441, 902.6548, 1975.1975), crop rect : Rect(0, 0 - 1080, 2400)
10-04 16:55:38.791  2453  4617 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d49ae90 mBlastBufferQueue=0xb4000078cd47f250 fn= 105 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.798  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 1.0, current rect : RectF(86.67581, 165.76776, 924.93384, 2028.5635), crop rect : Rect(0, 0 - 1080, 2400)
10-04 16:55:38.799  2453  4618 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d4870f0 mBlastBufferQueue=0xb4000078cd47f250 fn= 106 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.807  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 1.0, current rect : RectF(77.29431, 147.82556, 941.7178, 2068.7666), crop rect : Rect(0, 0 - 1080, 2400)
10-04 16:55:38.807  2453  4617 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d430c70 mBlastBufferQueue=0xb4000078cd47f250 fn= 107 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.811  1427  2275 D CompatibilityChangeReporter: Compat change id reported: 161145287; UID 10384; state: ENABLED
10-04 16:55:38.815  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 1.0, current rect : RectF(68.86206, 131.69885, 956.80334, 2104.9019), crop rect : Rect(0, 0 - 1080, 2400)
10-04 16:55:38.816  2453  4618 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d4398b0 mBlastBufferQueue=0xb4000078cd47f250 fn= 108 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.820 17175 17175 D nativeloader: Load /data/app/~~ftu52CcVnrTUUPpUvNVZ1g==/com.companyname.mauiappwindowtest-228w7o67vLngLnX7vSDiVQ==/lib/arm64/libmonosgen-2.0.so using ns clns-4 from class loader (caller=/data/app/~~ftu52CcVnrTUUPpUvNVZ1g==/com.companyname.mauiappwindowtest-228w7o67vLngLnX7vSDiVQ==/base.apk!classes2.dex): ok
10-04 16:55:38.821 17175 17175 D nativeloader: Load /data/app/~~ftu52CcVnrTUUPpUvNVZ1g==/com.companyname.mauiappwindowtest-228w7o67vLngLnX7vSDiVQ==/lib/arm64/libxamarin-app.so using ns clns-4 from class loader (caller=/data/app/~~ftu52CcVnrTUUPpUvNVZ1g==/com.companyname.mauiappwindowtest-228w7o67vLngLnX7vSDiVQ==/base.apk!classes2.dex): ok
10-04 16:55:38.822 17175 17175 D nativeloader: Load /data/app/~~ftu52CcVnrTUUPpUvNVZ1g==/com.companyname.mauiappwindowtest-228w7o67vLngLnX7vSDiVQ==/lib/arm64/libSystem.Security.Cryptography.Native.Android.so using ns clns-4 from class loader (caller=/data/app/~~ftu52CcVnrTUUPpUvNVZ1g==/com.companyname.mauiappwindowtest-228w7o67vLngLnX7vSDiVQ==/base.apk!classes2.dex): ok
10-04 16:55:38.822 17175 17175 D DOTNET  : AndroidCryptoNative_InitLibraryOnLoad: jint AndroidCryptoNative_InitLibraryOnLoad(JavaVM *, void *) in /__w/1/s/src/native/libs/System.Security.Cryptography.Native.Android/pal_jni.c
10-04 16:55:38.822 17175 17175 D DOTNET  : GetOptionalClassGRef: optional class com/android/org/conscrypt/OpenSSLEngineImpl was not found
10-04 16:55:38.823 17175 17175 D nativeloader: Load /data/app/~~ftu52CcVnrTUUPpUvNVZ1g==/com.companyname.mauiappwindowtest-228w7o67vLngLnX7vSDiVQ==/lib/arm64/libmonodroid.so using ns clns-4 from class loader (caller=/data/app/~~ftu52CcVnrTUUPpUvNVZ1g==/com.companyname.mauiappwindowtest-228w7o67vLngLnX7vSDiVQ==/base.apk!classes2.dex): ok
10-04 16:55:38.824  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 1.0, current rect : RectF(60.238525, 115.2063, 972.2312, 2141.8567), crop rect : Rect(0, 0 - 1080, 2400)
10-04 16:55:38.824 17175 17175 W monodroid: Failed to create directory '/data/user/0/com.companyname.mauiappwindowtest/files/.__override__/arm64-v8a'. No such file or directory
10-04 16:55:38.824 17175 17175 W monodroid: Creating public update directory: `/data/user/0/com.companyname.mauiappwindowtest/files/.__override__/arm64-v8a`
10-04 16:55:38.824 17175 17175 W uiappwindowtest: Attempt to remove non-JNI local reference
10-04 16:55:38.824 17175 17175 W monodroid-debug: Trying to initialize the debugger with options: --debugger-agent=transport=dt_socket,loglevel=0,address=127.0.0.1:52542,server=y,embedding=1,timeout=1728057349
10-04 16:55:38.824  2453  4617 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d494350 mBlastBufferQueue=0xb4000078cd47f250 fn= 109 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.826 17175 17175 W monodroid-assembly: Unable to open app library directory '/data/user/0/com.companyname.mauiappwindowtest/files/.__override__/arm64-v8a': No such file or directory
10-04 16:55:38.832  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 1.0, current rect : RectF(53.70508, 102.71112, 983.9197, 2169.8547), crop rect : Rect(0, 0 - 1080, 2400)
10-04 16:55:38.832  2453  4618 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d4621b0 mBlastBufferQueue=0xb4000078cd47f250 fn= 110 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.840  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 1.0, current rect : RectF(47.624115, 91.08124, 994.7987, 2195.9138), crop rect : Rect(0, 0 - 1080, 2400)
10-04 16:55:38.840  2453  4617 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d446850 mBlastBufferQueue=0xb4000078cd47f250 fn= 111 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.848  1427  1870 D MdnieScenarioControlService:  packageName : com.companyname.mauiappwindowtest    className : crc6457a4a0fbbd3bbed6.MainActivity
10-04 16:55:38.848  1427  1870 V MdnieScenarioControlService: setUIMode from UI function(3)
10-04 16:55:38.848  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 1.0, current rect : RectF(41.586853, 79.53497, 1005.5997, 2221.7856), crop rect : Rect(0, 0 - 1080, 2400)
10-04 16:55:38.849  2453  4618 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d40f2d0 mBlastBufferQueue=0xb4000078cd47f250 fn= 112 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.857  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 1.0, current rect : RectF(36.752716, 70.28967, 1014.24805, 2242.5015), crop rect : Rect(0, 0 - 1080, 2400)
10-04 16:55:38.857  2453  4617 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d49d930 mBlastBufferQueue=0xb4000078cd47f250 fn= 113 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.865  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 1.0, current rect : RectF(32.41162, 61.987305, 1022.01447, 2261.1047), crop rect : Rect(0, 0 - 1080, 2400)
10-04 16:55:38.866  2453  4618 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d43ccf0 mBlastBufferQueue=0xb4000078cd47f250 fn= 114 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.870  1427  1579 I GestureDetector: handleMessage TAP
10-04 16:55:38.871  1427  1427 I GestureDetector: handleMessage TAP
10-04 16:55:38.874  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 1.0, current rect : RectF(27.908508, 53.37506, 1030.0708, 2280.402), crop rect : Rect(0, 0 - 1080, 2400)
10-04 16:55:38.874  2453  4617 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d492250 mBlastBufferQueue=0xb4000078cd47f250 fn= 115 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.882  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 1.0, current rect : RectF(24.470795, 46.800476, 1036.2208, 2295.134), crop rect : Rect(0, 0 - 1080, 2400)
10-04 16:55:38.882  2453  4618 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d4acdf0 mBlastBufferQueue=0xb4000078cd47f250 fn= 116 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.890  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 1.0, current rect : RectF(20.665833, 39.523438, 1043.0281, 2311.4397), crop rect : Rect(0, 0 - 1080, 2400)
10-04 16:55:38.891  2453  4617 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d48c4d0 mBlastBufferQueue=0xb4000078cd47f250 fn= 117 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.899  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 1.0, current rect : RectF(18.026672, 34.476074, 1047.7498, 2322.7495), crop rect : Rect(0, 0 - 1080, 2400)
10-04 16:55:38.899  2453  4618 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d48ca50 mBlastBufferQueue=0xb4000078cd47f250 fn= 118 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.907  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 1.0, current rect : RectF(15.387482, 29.42865, 1052.4712, 2334.0593), crop rect : Rect(0, 0 - 1080, 2400)
10-04 16:55:38.907  2453  4617 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d4a9c70 mBlastBufferQueue=0xb4000078cd47f250 fn= 119 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.915  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 1.0, current rect : RectF(12.754028, 24.39209, 1057.1826, 2345.3445), crop rect : Rect(0, 0 - 1080, 2400)
10-04 16:55:38.916  2453  4618 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d47c3b0 mBlastBufferQueue=0xb4000078cd47f250 fn= 120 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.924  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 1.0, current rect : RectF(10.82312, 20.699219, 1060.6371, 2353.6191), crop rect : Rect(0, 0 - 1080, 2400)
10-04 16:55:38.924  2453  4617 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d43ded0 mBlastBufferQueue=0xb4000078cd47f250 fn= 121 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.932  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 1.0, current rect : RectF(8.892242, 17.00647, 1064.0914, 2361.8936), crop rect : Rect(0, 0 - 1080, 2400)
10-04 16:55:38.932  2453  4618 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d498d90 mBlastBufferQueue=0xb4000078cd47f250 fn= 122 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.940  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 1.0, current rect : RectF(7.093384, 13.566101, 1067.3097, 2369.6023), crop rect : Rect(0, 0 - 1080, 2400)
10-04 16:55:38.941  2453  4617 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d4ad370 mBlastBufferQueue=0xb4000078cd47f250 fn= 123 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.948  1427  1870 V MdnieScenarioControlService: mAclOffEnabled : false
10-04 16:55:38.949  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 1.0, current rect : RectF(5.7929993, 11.079102, 1069.6361, 2375.175), crop rect : Rect(0, 0 - 1080, 2400)
10-04 16:55:38.949  2453  4618 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d43eb30 mBlastBufferQueue=0xb4000078cd47f250 fn= 124 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.957  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 1.0, current rect : RectF(4.3299866, 8.281128, 1072.2534, 2381.4443), crop rect : Rect(0, 0 - 1080, 2400)
10-04 16:55:38.957  2453  4617 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d40d5f0 mBlastBufferQueue=0xb4000078cd47f250 fn= 125 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.965  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 1.0, current rect : RectF(3.2647705, 6.2438965, 1074.1592, 2386.0093), crop rect : Rect(0, 0 - 1080, 2400)
10-04 16:55:38.966  2453  4618 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d4941f0 mBlastBufferQueue=0xb4000078cd47f250 fn= 126 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.974  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 1.0, current rect : RectF(2.5277405, 4.8342896, 1075.4778, 2389.1677), crop rect : Rect(0, 0 - 1080, 2400)
10-04 16:55:38.974  2453  4617 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d48ad70 mBlastBufferQueue=0xb4000078cd47f250 fn= 127 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.982  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 1.0, current rect : RectF(1.6985168, 3.248413, 1076.9613, 2392.7212), crop rect : Rect(0, 0 - 1080, 2400)
10-04 16:55:38.982  2453  4618 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d4923b0 mBlastBufferQueue=0xb4000078cd47f250 fn= 128 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.991  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 1.0, current rect : RectF(0.96136475, 1.838623, 1078.28, 2395.8804), crop rect : Rect(0, 0 - 1080, 2400)
10-04 16:55:38.991  2453  4617 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d4a9010 mBlastBufferQueue=0xb4000078cd47f250 fn= 129 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:38.999  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 1.0, current rect : RectF(0.69595337, 1.3309937, 1078.7549, 2397.0176), crop rect : Rect(0, 0 - 1080, 2400)
10-04 16:55:38.999  2453  4618 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d4aa770 mBlastBufferQueue=0xb4000078cd47f250 fn= 130 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:39.007  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 1.0, current rect : RectF(0.43496704, 0.83184814, 1079.2218, 2398.136), crop rect : Rect(0, 0 - 1080, 2400)
10-04 16:55:39.008  2453  4617 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d49e850 mBlastBufferQueue=0xb4000078cd47f250 fn= 131 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:39.014  2453  2453 I Edge.TrayVisibilityController: getComputedTrayVisible : keyguardState = 1
10-04 16:55:39.014  2453  2453 I Edge.TrayVisibilityController: updateTrayVisible: State=1 visible=1 mCurrentVisible=1 specificMode=0
10-04 16:55:39.014  2453  2453 I Edge.TrayStateController: onNotifyUpdateTray: state=0
10-04 16:55:39.016  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 1.0, current rect : RectF(0.2029419, 0.38812256, 1079.637, 2399.1304), crop rect : Rect(0, 0 - 1080, 2400)
10-04 16:55:39.016  2453  4618 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d4058d0 mBlastBufferQueue=0xb4000078cd47f250 fn= 132 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:39.024  2453  2453 I HoneySpace.HoneyScreenManagerImpl: transitionAnimator is ended, onCancel: false
10-04 16:55:39.024  2453  2453 I HoneySpace.ContentsAnimator: ContentsAnimator end
10-04 16:55:39.024  2453  2453 I HoneySpace.WallpaperAnimator: wallpaper animation end
10-04 16:55:39.024  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: window alpha : 1.0, current rect : RectF(0.0, 0.0, 1080.0, 2400.0), crop rect : Rect(0, 0 - 1080, 2400)
10-04 16:55:39.024  2453  2453 I HoneySpace.IconView: setIconVisible : visible-true, currentForceHideBadge-false
10-04 16:55:39.024  2453  2453 I HoneySpace.AppLaunchAnimationDelegate: [AppLaunch] END
10-04 16:55:39.024  2453  2453 I HoneySpace.AnimationResult: finish, false
10-04 16:55:39.025  1427  2275 I WindowManager: Cancelling animation restarting=false, leash=Surface(name=Surface(name=RemoteWallpaperAnim:1:1)/@0x4ac17f2 - animation-leash of remote_wallpaper)/@0xcb52055
10-04 16:55:39.025  1427  2275 I WindowManager: Reparenting to original parent: Surface(name=OneHanded:0:14)/@0x3be1e43, destroy=false, surface=Surface(name=RemoteWallpaperAnim:1:1)/@0x4ac17f2
10-04 16:55:39.025  1427  2275 D WindowManager: finishRemoteWallpaperAnimation, success=true
10-04 16:55:39.025  2453  4617 I ViewRootImpl@93f9b16[LauncherActivity]: mWNT: t=0xb40000786d4a8eb0 mBlastBufferQueue=0xb4000078cd47f250 fn= 133 mRenderHdrSdrRatio=1.0 caller= com.android.systemui.shared.launcher.ViewRootImplCompat.mergeWithNextTransaction:4 com.honeyspace.transition.utils.SurfaceTransactionApplier.scheduleApply$lambda$1:26 com.honeyspace.transition.utils.SurfaceTransactionApplier.c:0 
10-04 16:55:39.026  2042  2164 V WindowManagerShell: Transition animation finished (aborted=false), notifying core (#430)android.os.BinderProxy@18f4a09@0
10-04 16:55:39.026  2042  2164 I SurfaceControl: apply is called, name=FinishTransaction_SyncId<430>, caller=android.view.SurfaceControl$Transaction.apply:2921 com.android.wm.shell.transition.Transitions.onFinish:302 com.android.wm.shell.transition.Transitions$$ExternalSyntheticLambda6.onTransitionFinished:11 com.android.wm.shell.transition.DefaultMixedHandler$$ExternalSyntheticLambda1.onTransitionFinished:81 com.android.wm.shell.transition.RemoteTransitionHandler$1$$ExternalSyntheticLambda0.run:118 android.os.Handler.handleCallback:958 
10-04 16:55:39.026  2453  6740 I HoneySpace.AnimationResult: asyncFinishRunnable run
10-04 16:55:39.026  2453  2453 I HoneySpace.ShellTransitionManager: open normal end
10-04 16:55:39.026  2453  2453 I HoneySpace.RunnableList: executeAllAndClear() called
10-04 16:55:39.026  2453  2453 I HoneySpace.AnimationResult: completeCallback run
10-04 16:55:39.026  1427  4443 V WindowManager: Finish Transition: TransitionRecord{ebfce02 id=430 type=OPEN flags=0x0}, caller=com.android.server.wm.WindowOrganizerController.finishTransition:454 android.window.IWindowOrganizerController$Stub.onTransact:286 com.android.server.wm.WindowOrganizerController.onTransact:217 
10-04 16:55:39.027  1427  1578 V WindowManager: Finish Transition #430: created at 10-04 16:55:38.637 collect-started=0.206ms request-sent=5.608ms started=9.683ms ready=26.414ms sent=28.397ms finished=389.535ms
10-04 16:55:39.027  1427  4443 V WindowManager: Setting visibility of Window{ee28167 u0 (1-1)-Window{99bf2c6 alpha=1.0 fl=}}: false, caller=com.android.server.wm.WindowContainer.sendAppVisibilityToClients:1301 com.android.server.wm.WindowToken.setClientVisible:446 com.android.server.wm.ActivityRecord.setClientVisible:8121 com.android.server.wm.ActivityRecord.postApplyAnimation:6685 com.android.server.wm.ActivityRecord.commitVisibility:6628 
10-04 16:55:39.027  1427  4443 V WindowManager: Setting visibility of Window{fbdaee8 u0 com.sec.android.app.launcher/com.sec.android.app.launcher.activities.LauncherActivity}: false, caller=com.android.server.wm.WindowContainer.sendAppVisibilityToClients:1301 com.android.server.wm.WindowToken.setClientVisible:446 com.android.server.wm.ActivityRecord.setClientVisible:8121 com.android.server.wm.ActivityRecord.postApplyAnimation:6685 com.android.server.wm.ActivityRecord.commitVisibility:6628 
10-04 16:55:39.027  7973  7973 I ViewRootImpl@12a5813[0 fl=}]: handleAppVisibility mAppVisible = true visible = false
10-04 16:55:39.027  1427  4443 V WindowManager: Setting visibility of Window{7fa477f u0 com.android.systemui.wallpapers.ImageWallpaper_system}: false, caller=com.android.server.wm.WindowContainer.sendAppVisibilityToClients:1301 com.android.server.wm.WindowToken.setClientVisible:446 com.android.server.wm.WallpaperWindowToken.setVisible:192 com.android.server.wm.WallpaperWindowToken.commitVisibility:243 com.android.server.wm.Transition.finishTransition:1548 
10-04 16:55:39.027  2042  9413 I WallpaperService: dispatchAppVisibility: system, visible=false
10-04 16:55:39.027  2042  2331 I WallpaperService: reportVisibility: visibility changed. visible=false
10-04 16:55:39.027  2042  2331 I ImageWallpaper[CanvasEngine_d0_w1]:  onVisibilityChanged: visible=false , displayId=0
10-04 16:55:39.028  2453  2453 I ViewRootImpl@93f9b16[LauncherActivity]: handleAppVisibility mAppVisible = true visible = false
10-04 16:55:39.029  2042  2164 V WindowManagerShell: Track 0 became idle
10-04 16:55:39.029  2042  2164 V WindowManagerShell: All active transition animations finished
10-04 16:55:39.030  1427  1581 D PowerManagerService: [api] setScreenDimDurationOverrideFromWindowManagerInternal: timeoutMillis: -1
10-04 16:55:39.033  1073  1073 I Layer   : Layer [Task=1#52] hidden!! flag(1)
10-04 16:55:39.033  2453  2453 I ViewRootImpl@93f9b16[LauncherActivity]: destroyHardwareResources: Callers=android.view.ViewRootImpl.performTraversals:3932 android.view.ViewRootImpl.doTraversal:3288 android.view.ViewRootImpl$TraversalRunnable.run:11344 android.view.Choreographer$CallbackRecord.run:1689 android.view.Choreographer$CallbackRecord.run:1698 android.view.Choreographer.doCallbacks:1153 android.view.Choreographer.doFrame:1079 android.view.Choreographer$FrameDisplayEventReceiver.run:1646 android.os.Handler.handleCallback:958 android.os.Handler.dispatchMessage:99 
10-04 16:55:39.033  1073  1073 I Layer   : id=5579 removeFromCurrentState Transition Root: Task=149#5579 (126)
10-04 16:55:39.033  7973  7973 I ViewRootImpl@12a5813[0 fl=}]: destroyHardwareResources: Callers=android.view.ViewRootImpl.performTraversals:3932 android.view.ViewRootImpl.doTraversal:3288 android.view.ViewRootImpl$TraversalRunnable.run:11344 android.view.Choreographer$CallbackRecord.run:1689 android.view.Choreographer$CallbackRecord.run:1698 android.view.Choreographer.doCallbacks:1153 android.view.Choreographer.doFrame:1079 android.view.Choreographer$FrameDisplayEventReceiver.run:1646 android.os.Handler.handleCallback:958 android.os.Handler.dispatchMessage:99 
10-04 16:55:39.033  1073  1073 I Layer   : id=5583 removeFromCurrentState Surface(name=Task=1)/@0x8c67df8_transition-leash#5583 (126)
10-04 16:55:39.033  1073  1073 I Layer   : id=5582 removeFromCurrentState Surface(name=Task=149)/@0x863b86a_transition-leash#5582 (126)
10-04 16:55:39.033  1073  1073 I Layer   : id=5575 removeFromCurrentState Task=149#5575 (126)
10-04 16:55:39.033  1073  1073 I Layer   : id=5576 removeFromCurrentState ActivityRecord{ffb8313 u0 com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity t149}#5576 (126)
10-04 16:55:39.033  1073  1073 I Layer   : id=5584 removeFromCurrentState bb1c34d ActivityRecordInputSink com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity#5584 (126)
10-04 16:55:39.033  1073  1073 I Layer   : id=5577 removeFromCurrentState e051b5a Splash Screen com.companyname.mauiappwindowtest#5577 (126)
10-04 16:55:39.033  1073  1073 I Layer   : id=5578 removeFromCurrentState Splash Screen com.companyname.mauiappwindowtest$_2042#5578 (126)
10-04 16:55:39.033  1073  1073 I Layer   : id=5575 addToCurrentState Task=149#5575 (126)
10-04 16:55:39.033  1073  1073 I Layer   : id=5576 addToCurrentState ActivityRecord{ffb8313 u0 com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity t149}#5576 (126)
10-04 16:55:39.033  1073  1073 I Layer   : id=5584 addToCurrentState bb1c34d ActivityRecordInputSink com.companyname.mauiappwindowtest/crc6457a4a0fbbd3bbed6.MainActivity#5584 (126)
10-04 16:55:39.033  1073  1073 I Layer   : id=5577 addToCurrentState e051b5a Splash Screen com.companyname.mauiappwindowtest#5577 (126)
10-04 16:55:39.033  1073  1073 I Layer   : id=5578 addToCurrentState Splash Screen com.companyname.mauiappwindowtest$_2042#5578 (126)
10-04 16:55:39.033  1073  1073 I Layer   : id=5579 removeFromCurrentState Transition Root: Task=149#5579 (126)
10-04 16:55:39.033  1073  1073 I Layer   : id=5583 removeFromCurrentState Surface(name=Task=1)/@0x8c67df8_transition-leash#5583 (126)
10-04 16:55:39.033  1073  1073 I Layer   : id=5582 removeFromCurrentState Surface(name=Task=149)/@0x863b86a_transition-leash#5582 (126)
10-04 16:55:39.033  1073  1073 I Layer   : id=5585 removeFromCurrentState Surface(name=RemoteWallpaperAnim:1:1)/@0x4ac17f2 - animation-leash of remote_wallpaper#5585 (126)
10-04 16:55:39.033  1073  1073 I Layer   : Layer [Task=6#121] hidden!! flag(1)
10-04 16:55:39.033  1073  1073 I Layer   : Layer [com.android.systemui.wallpapers.ImageWallpaper_system$_2042#84] hidden!! flag(1)
10-04 16:55:39.033  1073  1073 I Layer   : Layer [ActivityRecord{bc89e32 u0 com.sec.android.app.launcher/.activities.LauncherActivity t6}#122] hidden!! flag(1)
10-04 16:55:39.033  1073  1073 I Layer   : Layer [com.sec.android.app.launcher/com.sec.android.app.launcher.activities.LauncherActivity$_2453#5567] hidden!! flag(1)
10-04 16:55:39.033  1073  1073 I Layer   : Layer [(1-1)-Window{99bf2c6 alpha=1.0 fl=}$_7973#5566] hidden!! flag(1)
10-04 16:55:39.033  7973  8590 D OpenGLRenderer: CacheManager::trimMemory(20)
10-04 16:55:39.034  1427  2275 V WindowManager: Relayout Window{ee28167 u0 (1-1)-Window{99bf2c6 alpha=1.0 fl=}}: viewVisibility=8 req=1080x2400 ty=4 d0
10-04 16:55:39.034  1073  1073 I SurfaceFlinger: id=5579 Removed Transition Root: Task=149#5579 (126)
10-04 16:55:39.034  1073  1073 I SurfaceFlinger: id=5585 Removed Surface(name=RemoteWallpaperAnim:1:1)/@0x4ac17f2 - animation-leash of remote_wallpaper#5585 (126)
10-04 16:55:39.035  1427  4443 V WindowManager: Relayout Window{fbdaee8 u0 com.sec.android.app.launcher/com.sec.android.app.launcher.activities.LauncherActivity}: viewVisibility=8 req=1080x2400 ty=1 d0
10-04 16:55:39.035  1427  2275 V WindowManager: Relayout hash=ee28167, pid=7973, syncId=-1: mAttrs={(0,0)(fillxfill) gr=LEFT CENTER_HORIZONTAL sim={adjust=resize} layoutInDisplayCutoutMode=always ty=DRAWN_APPLICATION fmt=TRANSPARENT wanim=0x10302f2 alpha=0.0
10-04 16:55:39.035  1427  2275 V WindowManager:   fl=81850118
10-04 16:55:39.035  1427  2275 V WindowManager:   pfl=16008040
10-04 16:55:39.035  1427  2275 V WindowManager:   vsysui=2010
10-04 16:55:39.035  1427  2275 V WindowManager:   bhv=DEFAULT
10-04 16:55:39.035  1427  2275 V WindowManager:   fitSides=
10-04 16:55:39.035  1427  2275 V WindowManager:  dimAmount=0.0 screenDimDuration=200000 naviIconColor=0}
10-04 16:55:39.035  1427  4443 V WindowManager: Relayout hash=fbdaee8, pid=2453, syncId=-1: mAttrs={(0,0)(fillxfill) sim={adjust=nothing forwardNavigation} layoutInDisplayCutoutMode=shortEdges ty=BASE_APPLICATION fmt=TRANSPARENT wanim=0x10302f2
10-04 16:55:39.035  1427  4443 V WindowManager:   fl=81910100
10-04 16:55:39.035  1427  4443 V WindowManager:   pfl=1e008040
10-04 16:55:39.035  1427  4443 V WindowManager:   bhv=SHOW_TRANSIENT_BARS_BY_SWIPE
10-04 16:55:39.035  1427  4443 V WindowManager:   fitSides= screenDimDuration=200000 naviIconColor=0}
10-04 16:55:39.036  2453  2453 I ViewRootImpl@93f9b16[LauncherActivity]: Relayout returned: old=(0,0,1080,2400) new=(0,0,1080,2400) relayoutAsync=false req=(1080,2400)8 dur=2 res=0x402 s={false 0x0} ch=true seqId=0
10-04 16:55:39.036  7973  7973 I ViewRootImpl@12a5813[0 fl=}]: Relayout returned: old=(0,0,1080,2400) new=(0,0,1080,2400) relayoutAsync=false req=(1080,2400)8 dur=2 res=0x402 s={false 0x0} ch=true seqId=0
10-04 16:55:39.038  1073  1073 D SurfaceFlinger: Display 4633128672291735937 HWC layers:
10-04 16:55:39.038  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784fd3150 | 0100 | RGBA_8888    |    0.0    0.0 1080.0 2400.0 |    0    0 1080 2400 | Splash Screen com.companyname.mauiappwindowtest$_2042#5578
10-04 16:55:39.038  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784faccd0 | 0100 | RGBA_8888    |    0.0    0.0 1080.0   80.0 |    0    0 1080   80 | StatusBar$_2042#89
10-04 16:55:39.038  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784fe2110 | 0100 | RGBA_8888    |    0.0    0.0   67.0  342.0 | 1013  623 1080  965 | com.sec.android.app.launcher/com.sam[...]e.edge.CocktailBarService$_2453#2631
10-04 16:55:39.038  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784fab610 | 0100 | RGBA_8888    |    0.0    0.0 1080.0  144.0 |    0 2256 1080 2400 | NavigationBar0$_2042#82
10-04 16:55:39.038  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784fb6510 | 0140 | RGBA_8888    |    0.0    0.0 1080.0   80.0 |    0    0 1080   80 | ScreenDecorOverlay$_2042#99
10-04 16:55:39.038  1073  1073 D SurfaceFlinger:      DEVICE | 0xb400007784fd5ed0 | 0140 | RGBA_8888    |    0.0    0.0 1080.0   80.0 |    0 2320 1080 2400 | ScreenDecorOverlayBottom$_2042#100
10-04 16:55:39.038  1073  1073 D SurfaceFlinger: 
10-04 16:55:39.038  1073  1124 I SurfaceFlinger: id=5583 Removed Surface(name=Task=1)/@0x8c67df8_transition-leash#5583 (126)
10-04 16:55:39.039  1073  1124 I SurfaceFlinger: id=5582 Removed Surface(name=Task=149)/@0x863b86a_transition-leash#5582 (126)
10-04 16:55:39.041  1073  1073 I Layer   : id=5585 Destroyed Surface(name=RemoteWallpaperAnim:1:1)/@0x4ac17f2 - animation-leash of remote_wallpaper#5585
10-04 16:55:39.041  1073  1073 I Layer   : id=5579 Destroyed Transition Root: Task=149#5579
10-04 16:55:39.041  1073  1073 I Layer   : id=5583 Destroyed Surface(name=Task=1)/@0x8c67df8_transition-leash#5583
10-04 16:55:39.041  1073  1073 I Layer   : id=5582 Destroyed Surface(name=Task=149)/@0x863b86a_transition-leash#5582
10-04 16:55:39.166  1427  3647 D SemWifiUsabilityStatsMonitor: onWifiUsabilityStats - seqNum 23126, isSameBssidAndFreq true
10-04 16:55:39.167  2042  2042 D StatusBarIconController: ignoring old pipeline callback because the new wifi icon is enabled
10-04 16:55:39.280  3946  5214 I SDHMS:C : SIOP:: AP:289 BAT:255 USB:256 CHG:283 PA:268 CP:270 WIFI:273 CF:261 BLK:0 SUBBAT:0 SKIN:270 SKINF:270 SKINB:278 LRP:278 LRP2:270 LRF:270 LRB:278 LRF2:270 LRB2:270 AP2:270 CHG2:269 MEM2:270 WIFI2:270 RCV2:268 SPK2:266 FCAM:256 UPSPK:259 DNSPK:256 
10-04 16:55:39.334   994 17169 I HYPER-HAL: [ResourceManager.cpp]removeResource(): [CPUMinFreq] RemoveResource Request ID : 3012286
10-04 16:55:39.334   994 17169 I HYPER-HAL: [RequestManager.cpp]releaseLocked(): Released ID : 3012286
10-04 16:55:39.432  1073  1073 I HWComposer: [4633128672291735937] ActiveConfigToHWC, ID : 2
10-04 16:55:39.432   975  1036 I display : Set Affinity config for fps(60) : 2, cpuIDs : 255
10-04 16:55:39.433   975  1036 I display : Set Affinity CPU ID : 0
10-04 16:55:39.433   975  1036 I display : Set Affinity CPU ID : 1
10-04 16:55:39.433   975  1036 I display : Set Affinity CPU ID : 2
10-04 16:55:39.433   975  1036 I display : Set Affinity CPU ID : 3
10-04 16:55:39.433   975  1036 I display : Set Affinity CPU ID : 4
10-04 16:55:39.433   975  1036 I display : Set Affinity CPU ID : 5
10-04 16:55:39.433   975  1036 I display : Set Affinity CPU ID : 6
10-04 16:55:39.433   975  1036 I display : Set Affinity CPU ID : 7
10-04 16:55:39.433   975  1036 I display : Set affinity HWC : 975
10-04 16:55:39.433   975  1036 I display : CPU set : Cluster(0), min_clock(0)
10-04 16:55:39.433   975  1036 I display : CPU set : Cluster(1), min_clock(0)
10-04 16:55:39.433   975  1036 I display : CPU set : Cluster(2), min_clock(0)
10-04 16:55:39.433  1073  1073 I LayerHistory: StatusBar$_2042#89 voted 0, 0.00 fps
10-04 16:55:39.433  1073  1073 I LayerHistory: NavigationBar0$_2042#82 Max (can't resolve refresh rate)
10-04 16:55:39.433  1073  1073 I LayerHistory: com.sec.android.app.launcher/com.sec.android.app.launcher.activities.LauncherActivity$_2453#5567 Max (can't resolve refresh rate)
10-04 16:55:39.433  1073  1073 I SurfaceFlinger: Idle - choose 60.00 Hz
10-04 16:55:39.433   975  1033 I display : doDisplayConfigPostProcess needSetActiveConfig is true - mDesiredConfig: 2
10-04 16:55:39.433   975  1033 I display : setActiveConfig(config=2)
10-04 16:55:39.433   975  1033 I display : next config(2): width=1080 height=2400 period=16666666 Xdpi=422030 Ydpi=423333 groupId=0
10-04 16:55:39.433   975  1033 I display : Current VRR MODE is 3
10-04 16:55:39.434  1073  1212 I VSyncReactor: Current= 120, Period= 60, hwcPeriod= 120
10-04 16:55:39.442  1073  1212 I VSyncReactor: Current= 120, Period= 60, hwcPeriod= 60
10-04 16:55:39.644   994 17172 I HYPER-HAL: [ResourceManager.cpp]removeResource(): [CPUMinFreq] RemoveResource Request ID : 1044753
10-04 16:55:39.644   994 17172 I HYPER-HAL: [RequestManager.cpp]releaseLocked(): Released ID : 1044753
10-04 16:55:39.801   676   676 D io_stats: !@   8,0 r 706554 27994068 w 792861 17795136 d 216628 120718488 f 0 0 iot 796956 0 th 0 0 0 pt 0 inp 0 0 89548.270
10-04 16:55:39.802   676   676 D io_stats: !@ Read_top(KB): system_server(1427) 8
10-04 16:55:39.802   676   676 D io_stats: !@ Write_top(KB): kworker/u16:2(13231) 488 id.diagmonagent(3928) 56
10-04 16:55:39.969  3956 16894 I NearbyMediums: No BLE Fast/GATT advertisements found in the latest cycle.
10-04 16:55:40.044  1073  1212 I VSyncReactor: Current= 60, Period= 60, hwcPeriod= 60
10-04 16:55:40.139   994 17170 I HYPER-HAL: [ResourceManager.cpp]removeResource(): [CPUMaxFreq] RemoveResource Request ID : 7842794
10-04 16:55:40.139   994 17170 I HYPER-HAL: [RequestManager.cpp]releaseLocked(): Released ID : 7842794
10-04 16:55:40.532   976   976 I android.hardware.health@2.1-service-samsung: updateLrpSysfs: write: 270
10-04 16:55:40.687   994 17153 I HYPER-HAL: [RequestManager.cpp]releaseLocked(): Released ID : 2150701
10-04 16:55:41.316  1052  1241 I EDEN    : [Exynos][EDEN][v1.6.23][SERVICE] processAliveMointorMain:253: Try to check pid=(1004)...
10-04 16:55:41.569  1427  1610 D PowerManagerService: UserActivityStateListenerState: 0
10-04 16:55:41.639  1427  2573 I SemDvfsHyPerManager: acquire hyper - AMS_RESUME_TAIL/1427@19, type = -999
10-04 16:55:41.639  1427  2573 I SemDvfsHyPerManager: acquire hyper - AMS_ACT_LAZY/1427@20, type = -999
10-04 16:55:41.639  1427  2573 D ActivityManagerPerformance: AMP_acquire() TAIL
10-04 16:55:41.639  1427  2573 D ActivityManagerPerformance: AMP_release() APP_SWITCH
10-04 16:55:41.639   994  1071 I HYPER-HAL: [RequestManager.cpp]acquire(): Acquired ID : 1046200  [1427 / 19]    HINT : AMS_RESUME_TAIL    list : 
10-04 16:55:41.639   994  1071 I HYPER-HAL: [ResourceManager.cpp]updateResource(): [CPUMinFreq] UpdateResource Request ID : 1046200    Value : 1768000
10-04 16:55:41.639   994  1071 I HYPER-HAL: [ResourceManager.cpp]removeResource(): [CPUMinFreq] RemoveResource Request ID : 1049097
10-04 16:55:41.644   994  1071 I HYPER-HAL: [RequestManager.cpp]releaseLocked(): Released ID : 1049097
10-04 16:55:41.648  1427  3950 E TaskPersister: File error accessing recents directory (directory doesn't exist?).
10-04 16:55:41.718   986   986 I Sensors : batch(19) - light_cct_sensor try to batching with 200000000
10-04 16:55:41.720   986   986 I Sensors : LightCCT_Sensor old sensor_state 16896, new sensor_state : 1550332870017536 en : 1
10-04 16:55:41.725   986   986 I Sensors : enable:: light_cct_sensor(19)
10-04 16:55:41.726  1427  1872 D SensorManager: registerListener :: 33, TMD4912 Light CCT, 200000, 0, com.samsung.android.displaysolution.EyeComfortSolutionService$2@8da8bbd
10-04 16:55:41.763   986  1743 I Sensors : lux = 122, CCT = 0, r = 3154, g = 376, b = 3444, c = 593, atime = 350, again = 512, lux_raw = 122, brightness = 100, time = 156095614608493
10-04 16:55:41.766   986   986 I Sensors : LightCCT_Sensor old sensor_state 16896, new sensor_state : 1550328575050240 en : 0
10-04 16:55:41.769   986   986 I Sensors : disable:: light_cct_sensor(19)
10-04 16:55:41.770  1427  1872 D SensorManager: unregisterListener :: com.samsung.android.displaysolution.EyeComfortSolutionService$2@8da8bbd
10-04 16:55:41.803   676   676 D io_stats: !@   8,0 r 706556 27994076 w 792864 17795144 d 216628 120718488 f 0 0 iot 796964 0 th 0 0 0 pt 0 inp 0 0 89550.272
10-04 16:55:41.941   994 17199 I HYPER-HAL: [ResourceManager.cpp]removeResource(): [CPUMinFreq] RemoveResource Request ID : 1046200
10-04 16:55:41.943   994 17199 I HYPER-HAL: [RequestManager.cpp]releaseLocked(): Released ID : 1046200
10-04 16:55:42.280  1427  3647 D SemWifiUsabilityStatsMonitor: onWifiUsabilityStats - seqNum 23127, isSameBssidAndFreq true
10-04 16:55:42.649   994 17173 I HYPER-HAL: [ResourceManager.cpp]removeResource(): [CPUMaxFreq] RemoveResource Request ID : 7850719
10-04 16:55:42.650   994 17173 I HYPER-HAL: [RequestManager.cpp]releaseLocked(): Released ID : 7850719
10-04 16:55:43.805   676   676 D io_stats: !@   8,0 r 706556 27994076 w 792947 17795620 d 216690 120721372 f 0 0 iot 797012 0 th 0 0 0 pt 0 inp 0 0 89552.274
10-04 16:55:43.805   676   676 D io_stats: !@ Read_top(KB): ogle.android.as(3859) 8
10-04 16:55:43.806   676   676 D io_stats: !@ Write_top(KB): earchbox:search(7973) 172 kworker/u16:1(16945) 96 soft.appmanager(25739) 16
10-04 16:55:44.637  2273  2273 I wpa_supplicant: Heartbeat 8920
10-04 16:55:45.394  1427  3647 D SemWifiUsabilityStatsMonitor: onWifiUsabilityStats - seqNum 23128, isSameBssidAndFreq true
10-04 16:55:45.523  3993  3993 D BoundBrokerSvc: onUnbind: Intent { act=com.google.android.gms.safetynet.service.START pkg=com.google.android.gms }
10-04 16:55:45.525  1427  4443 W ProcessStats: Tracking association SourceState{941d570 com.google.android.googlequicksearchbox:search/10237 BTop #85140} whose proc state 2 is better than process ProcessState{2c933eb com.google.android.gms.persistent/10227 pkg=com.google.android.gms} proc state 4 (91 skipped)
```