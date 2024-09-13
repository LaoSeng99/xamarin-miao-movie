; ModuleID = 'obj\Debug\120\android\marshal_methods.arm64-v8a.ll'
source_filename = "obj\Debug\120\android\marshal_methods.arm64-v8a.ll"
target datalayout = "e-m:e-i8:8:32-i16:16:32-i64:64-i128:128-n32:64-S128"
target triple = "aarch64-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 8
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [332 x i64] [
	i64 2646484529726201, ; 0: FFImageLoading.Forms.Platform => 0x966f6b24c42f9 => 14
	i64 24362543149721218, ; 1: Xamarin.AndroidX.DynamicAnimation => 0x568d9a9a43a682 => 97
	i64 47710610751200758, ; 2: Refractored.XamForms.PullToRefresh => 0xa9808c35d79df6 => 26
	i64 120698629574877762, ; 3: Mono.Android => 0x1accec39cafe242 => 21
	i64 210515253464952879, ; 4: Xamarin.AndroidX.Collection.dll => 0x2ebe681f694702f => 87
	i64 232391251801502327, ; 5: Xamarin.AndroidX.SavedState.dll => 0x3399e9cbc897277 => 121
	i64 263803244706540312, ; 6: Rg.Plugins.Popup.dll => 0x3a937a743542b18 => 27
	i64 295915112840604065, ; 7: Xamarin.AndroidX.SlidingPaneLayout => 0x41b4d3a3088a9a1 => 122
	i64 347331204332682223, ; 8: ImageCircle.Forms.Plugin => 0x4d1f7e3dda87bef => 18
	i64 403694196094993479, ; 9: Xamarin.AndroidX.MediaRouter => 0x59a35bb84210447 => 112
	i64 464346026994987652, ; 10: System.Reactive.dll => 0x671b04057e67284 => 37
	i64 590536689428908136, ; 11: Xamarin.Android.Arch.Lifecycle.ViewModel.dll => 0x83201fd803ec868 => 49
	i64 634308326490598313, ; 12: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x8cd840fee8b6ba9 => 106
	i64 702024105029695270, ; 13: System.Drawing.Common => 0x9be17343c0e7726 => 1
	i64 720058930071658100, ; 14: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x9fe29c82844de74 => 100
	i64 816102801403336439, ; 15: Xamarin.Android.Support.Collections => 0xb53612c89d8d6f7 => 53
	i64 846634227898301275, ; 16: Xamarin.Android.Arch.Lifecycle.LiveData.Core => 0xbbfd9583890bb5b => 46
	i64 872800313462103108, ; 17: Xamarin.AndroidX.DrawerLayout => 0xc1ccf42c3c21c44 => 96
	i64 940822596282819491, ; 18: System.Transactions => 0xd0e792aa81923a3 => 145
	i64 996343623809489702, ; 19: Xamarin.Forms.Platform => 0xdd3b93f3b63db26 => 136
	i64 1000557547492888992, ; 20: Mono.Security.dll => 0xde2b1c9cba651a0 => 164
	i64 1120440138749646132, ; 21: Xamarin.Google.Android.Material.dll => 0xf8c9a5eae431534 => 139
	i64 1205285505719690600, ; 22: Sharpnado.MaterialFrame => 0x10ba08c815596568 => 29
	i64 1315114680217950157, ; 23: Xamarin.AndroidX.Arch.Core.Common.dll => 0x124039d5794ad7cd => 82
	i64 1342439039765371018, ; 24: Xamarin.Android.Support.Fragment => 0x12a14d31b1d4d88a => 63
	i64 1425944114962822056, ; 25: System.Runtime.Serialization.dll => 0x13c9f89e19eaf3a8 => 6
	i64 1476839205573959279, ; 26: System.Net.Primitives.dll => 0x147ec96ece9b1e6f => 156
	i64 1490981186906623721, ; 27: Xamarin.Android.Support.VersionedParcelable => 0x14b1077d6c5c0ee9 => 75
	i64 1624659445732251991, ; 28: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0x168bf32877da9957 => 80
	i64 1628611045998245443, ; 29: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0x1699fd1e1a00b643 => 108
	i64 1636321030536304333, ; 30: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0x16b5614ec39e16cd => 101
	i64 1731380447121279447, ; 31: Newtonsoft.Json => 0x18071957e9b889d7 => 23
	i64 1744702963312407042, ; 32: Xamarin.Android.Support.v7.AppCompat => 0x18366e19eeceb202 => 71
	i64 1795316252682057001, ; 33: Xamarin.AndroidX.AppCompat.dll => 0x18ea3e9eac997529 => 81
	i64 1808110659757781871, ; 34: CarouselView.FormsPlugin.Abstractions.dll => 0x1917b310b575b36f => 8
	i64 1836611346387731153, ; 35: Xamarin.AndroidX.SavedState => 0x197cf449ebe482d1 => 121
	i64 1860886102525309849, ; 36: Xamarin.Android.Support.v7.RecyclerView.dll => 0x19d3320d047b7399 => 73
	i64 1875917498431009007, ; 37: Xamarin.AndroidX.Annotation.dll => 0x1a08990699eb70ef => 78
	i64 1981742497975770890, ; 38: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x1b80904d5c241f0a => 107
	i64 1984538867944326539, ; 39: FFImageLoading.Platform.dll => 0x1b8a7f95fac7058b => 15
	i64 1986553961460820075, ; 40: Xamarin.CommunityToolkit => 0x1b91a84d8004686b => 131
	i64 2133195048986300728, ; 41: Newtonsoft.Json.dll => 0x1d9aa1984b735138 => 23
	i64 2136356949452311481, ; 42: Xamarin.AndroidX.MultiDex.dll => 0x1da5dd539d8acbb9 => 113
	i64 2165725771938924357, ; 43: Xamarin.AndroidX.Browser => 0x1e0e341d75540745 => 85
	i64 2262844636196693701, ; 44: Xamarin.AndroidX.DrawerLayout.dll => 0x1f673d352266e6c5 => 96
	i64 2284400282711631002, ; 45: System.Web.Services => 0x1fb3d1f42fd4249a => 150
	i64 2287834202362508563, ; 46: System.Collections.Concurrent => 0x1fc00515e8ce7513 => 165
	i64 2329709569556905518, ; 47: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x2054ca829b447e2e => 104
	i64 2427608535807450384, ; 48: Com.Android.DeskClock => 0x21b09919ee825d10 => 10
	i64 2470498323731680442, ; 49: Xamarin.AndroidX.CoordinatorLayout => 0x2248f922dc398cba => 91
	i64 2479423007379663237, ; 50: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x2268ae16b2cba985 => 126
	i64 2497223385847772520, ; 51: System.Runtime => 0x22a7eb7046413568 => 38
	i64 2547086958574651984, ; 52: Xamarin.AndroidX.Activity.dll => 0x2359121801df4a50 => 77
	i64 2592350477072141967, ; 53: System.Xml.dll => 0x23f9e10627330e8f => 39
	i64 2624866290265602282, ; 54: mscorlib.dll => 0x246d65fbde2db8ea => 22
	i64 2642180066339582676, ; 55: CarouselView.FormsPlugin.Abstractions => 0x24aae8c57ec9f2d4 => 8
	i64 2694427813909235223, ; 56: Xamarin.AndroidX.Preference.dll => 0x256487d230fe0617 => 118
	i64 2863324215353042462, ; 57: FFImageLoading.Forms => 0x27bc92340ce4661e => 13
	i64 2941226221300907765, ; 58: Toasts.Forms.Plugin.Droid.dll => 0x28d155aa3cb47ef5 => 42
	i64 2949706848458024531, ; 59: Xamarin.Android.Support.SlidingPaneLayout => 0x28ef76c01de0a653 => 68
	i64 2960931600190307745, ; 60: Xamarin.Forms.Core => 0x2917579a49927da1 => 133
	i64 2977248461349026546, ; 61: Xamarin.Android.Support.DrawerLayout => 0x29514fb392c97af2 => 62
	i64 3017704767998173186, ; 62: Xamarin.Google.Android.Material => 0x29e10a7f7d88a002 => 139
	i64 3289520064315143713, ; 63: Xamarin.AndroidX.Lifecycle.Common => 0x2da6b911e3063621 => 103
	i64 3303437397778967116, ; 64: Xamarin.AndroidX.Annotation.Experimental => 0x2dd82acf985b2a4c => 79
	i64 3311221304742556517, ; 65: System.Numerics.Vectors.dll => 0x2df3d23ba9e2b365 => 36
	i64 3493805808809882663, ; 66: Xamarin.AndroidX.Tracing.Tracing.dll => 0x307c7ddf444f3427 => 124
	i64 3522470458906976663, ; 67: Xamarin.AndroidX.SwipeRefreshLayout => 0x30e2543832f52197 => 123
	i64 3531994851595924923, ; 68: System.Numerics => 0x31042a9aade235bb => 35
	i64 3571415421602489686, ; 69: System.Runtime.dll => 0x319037675df7e556 => 38
	i64 3716579019761409177, ; 70: netstandard.dll => 0x3393f0ed5c8c5c99 => 143
	i64 3727469159507183293, ; 71: Xamarin.AndroidX.RecyclerView => 0x33baa1739ba646bd => 120
	i64 3772598417116884899, ; 72: Xamarin.AndroidX.DynamicAnimation.dll => 0x345af645b473efa3 => 97
	i64 3788644642786275579, ; 73: PanCardView => 0x3493f83ac17670fb => 24
	i64 4252163538099460320, ; 74: Xamarin.Android.Support.ViewPager.dll => 0x3b02b8357f4958e0 => 76
	i64 4264996749430196783, ; 75: Xamarin.Android.Support.Transition.dll => 0x3b304ff259fb8a2f => 70
	i64 4271283160018321307, ; 76: BXM308_Assignment.Android => 0x3b46a5675fffff9b => 0
	i64 4349341163892612332, ; 77: Xamarin.Android.Support.DocumentFile => 0x3c5bf6bea8cd9cec => 61
	i64 4416987920449902723, ; 78: Xamarin.Android.Support.AsyncLayoutInflater.dll => 0x3d4c4b1c879b9883 => 52
	i64 4525561845656915374, ; 79: System.ServiceModel.Internals => 0x3ece06856b710dae => 142
	i64 4616232946718031335, ; 80: Toasts.Forms.Plugin.Droid => 0x401027683d953de7 => 42
	i64 4636684751163556186, ; 81: Xamarin.AndroidX.VersionedParcelable.dll => 0x4058d0370893015a => 128
	i64 4782108999019072045, ; 82: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0x425d76cc43bb0a2d => 84
	i64 4794310189461587505, ; 83: Xamarin.AndroidX.Activity => 0x4288cfb749e4c631 => 77
	i64 4795410492532947900, ; 84: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0x428cb86f8f9b7bbc => 123
	i64 4805546890380114129, ; 85: Toasts.Forms.Plugin.Abstractions.dll => 0x42b0bb6f9896f8d1 => 41
	i64 4841234827713643511, ; 86: Xamarin.Android.Support.CoordinaterLayout => 0x432f856d041f03f7 => 55
	i64 4963205065368577818, ; 87: Xamarin.Android.Support.LocalBroadcastManager.dll => 0x44e0d8b5f4b6a71a => 66
	i64 5081566143765835342, ; 88: System.Resources.ResourceManager.dll => 0x4685597c05d06e4e => 4
	i64 5099468265966638712, ; 89: System.Resources.ResourceManager => 0x46c4f35ea8519678 => 4
	i64 5142919913060024034, ; 90: Xamarin.Forms.Platform.Android.dll => 0x475f52699e39bee2 => 135
	i64 5178572682164047940, ; 91: Xamarin.Android.Support.Print.dll => 0x47ddfc6acbee1044 => 67
	i64 5203618020066742981, ; 92: Xamarin.Essentials => 0x4836f704f0e652c5 => 132
	i64 5205316157927637098, ; 93: Xamarin.AndroidX.LocalBroadcastManager => 0x483cff7778e0c06a => 110
	i64 5288341611614403055, ; 94: Xamarin.Android.Support.Interpolator.dll => 0x4963f6ad4b3179ef => 64
	i64 5348796042099802469, ; 95: Xamarin.AndroidX.Media => 0x4a3abda9415fc165 => 111
	i64 5375264076663995773, ; 96: Xamarin.Forms.PancakeView => 0x4a98c632c779bd7d => 134
	i64 5376510917114486089, ; 97: Xamarin.AndroidX.VectorDrawable.Animated => 0x4a9d3431719e5d49 => 126
	i64 5408338804355907810, ; 98: Xamarin.AndroidX.Transition => 0x4b0e477cea9840e2 => 125
	i64 5439315836349573567, ; 99: Xamarin.Android.Support.Animated.Vector.Drawable.dll => 0x4b7c54ef36c5e9bf => 50
	i64 5446034149219586269, ; 100: System.Diagnostics.Debug => 0x4b94333452e150dd => 155
	i64 5451019430259338467, ; 101: Xamarin.AndroidX.ConstraintLayout.dll => 0x4ba5e94a845c2ce3 => 90
	i64 5507995362134886206, ; 102: System.Core.dll => 0x4c705499688c873e => 33
	i64 5563049671862343767, ; 103: Xamarin.AndroidX.Palette.dll => 0x4d33ec33c7355857 => 117
	i64 5655995608527325224, ; 104: Com.ViewPagerIndicator.dll => 0x4e7e220a0970c828 => 11
	i64 5692067934154308417, ; 105: Xamarin.AndroidX.ViewPager2.dll => 0x4efe49a0d4a8bb41 => 130
	i64 5757522595884336624, ; 106: Xamarin.AndroidX.Concurrent.Futures.dll => 0x4fe6d44bd9f885f0 => 88
	i64 5767696078500135884, ; 107: Xamarin.Android.Support.Annotations.dll => 0x500af9065b6a03cc => 51
	i64 5814345312393086621, ; 108: Xamarin.AndroidX.Preference => 0x50b0b44182a5c69d => 118
	i64 5896680224035167651, ; 109: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x51d5376bfbafdda3 => 105
	i64 6044705416426755068, ; 110: Xamarin.Android.Support.SwipeRefreshLayout.dll => 0x53e31b8ccdff13fc => 69
	i64 6085203216496545422, ; 111: Xamarin.Forms.Platform.dll => 0x5472fc15a9574e8e => 136
	i64 6086316965293125504, ; 112: FormsViewGroup.dll => 0x5476f10882baef80 => 17
	i64 6225510378550627689, ; 113: CarouselView.FormsPlugin.Droid.dll => 0x566574b483048d69 => 9
	i64 6311200438583329442, ; 114: Xamarin.Android.Support.LocalBroadcastManager => 0x5795e35c580c82a2 => 66
	i64 6319713645133255417, ; 115: Xamarin.AndroidX.Lifecycle.Runtime => 0x57b42213b45b52f9 => 106
	i64 6401687960814735282, ; 116: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0x58d75d486341cfb2 => 104
	i64 6405879832841858445, ; 117: Xamarin.Android.Support.Vector.Drawable.dll => 0x58e641c4a660ad8d => 74
	i64 6471717919390774717, ; 118: Sharpnado.MaterialFrame.dll => 0x59d02928b7d135bd => 29
	i64 6504860066809920875, ; 119: Xamarin.AndroidX.Browser.dll => 0x5a45e7c43bd43d6b => 85
	i64 6548213210057960872, ; 120: Xamarin.AndroidX.CustomView.dll => 0x5adfed387b066da8 => 94
	i64 6591024623626361694, ; 121: System.Web.Services.dll => 0x5b7805f9751a1b5e => 150
	i64 6659513131007730089, ; 122: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0x5c6b57e8b6c3e1a9 => 100
	i64 6671798237668743565, ; 123: SkiaSharp => 0x5c96fd260152998d => 30
	i64 6876862101832370452, ; 124: System.Xml.Linq => 0x5f6f85a57d108914 => 40
	i64 6894844156784520562, ; 125: System.Numerics.Vectors => 0x5faf683aead1ad72 => 36
	i64 7036436454368433159, ; 126: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x61a671acb33d5407 => 102
	i64 7103753931438454322, ; 127: Xamarin.AndroidX.Interpolator.dll => 0x62959a90372c7632 => 99
	i64 7111211609209905225, ; 128: Xamarin.Plugin.Calendar => 0x62b0194821972049 => 141
	i64 7141577505875122296, ; 129: System.Runtime.InteropServices.WindowsRuntime.dll => 0x631bfae7659b5878 => 2
	i64 7194160955514091247, ; 130: Xamarin.Android.Support.CursorAdapter.dll => 0x63d6cb45d266f6ef => 58
	i64 7270811800166795866, ; 131: System.Linq => 0x64e71ccf51a90a5a => 161
	i64 7338192458477945005, ; 132: System.Reflection => 0x65d67f295d0740ad => 152
	i64 7488575175965059935, ; 133: System.Xml.Linq.dll => 0x67ecc3724534ab5f => 40
	i64 7489048572193775167, ; 134: System.ObjectModel => 0x67ee71ff6b419e3f => 162
	i64 7602111570124318452, ; 135: System.Reactive => 0x698020320025a6f4 => 37
	i64 7635363394907363464, ; 136: Xamarin.Forms.Core.dll => 0x69f6428dc4795888 => 133
	i64 7637365915383206639, ; 137: Xamarin.Essentials.dll => 0x69fd5fd5e61792ef => 132
	i64 7654504624184590948, ; 138: System.Net.Http => 0x6a3a4366801b8264 => 3
	i64 7820441508502274321, ; 139: System.Data => 0x6c87ca1e14ff8111 => 144
	i64 7821246742157274664, ; 140: Xamarin.Android.Support.AsyncLayoutInflater => 0x6c8aa67926f72e28 => 52
	i64 7836164640616011524, ; 141: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x6cbfa6390d64d704 => 80
	i64 7879037620440914030, ; 142: Xamarin.Android.Support.v7.AppCompat.dll => 0x6d57f6f88a51d86e => 71
	i64 7927939710195668715, ; 143: SkiaSharp.Views.Android.dll => 0x6e05b32992ed16eb => 31
	i64 8044118961405839122, ; 144: System.ComponentModel.Composition => 0x6fa2739369944712 => 149
	i64 8064050204834738623, ; 145: System.Collections.dll => 0x6fe942efa61731bf => 151
	i64 8083354569033831015, ; 146: Xamarin.AndroidX.Lifecycle.Common.dll => 0x702dd82730cad267 => 103
	i64 8101777744205214367, ; 147: Xamarin.Android.Support.Annotations => 0x706f4beeec84729f => 51
	i64 8103644804370223335, ; 148: System.Data.DataSetExtensions.dll => 0x7075ee03be6d50e7 => 146
	i64 8113615946733131500, ; 149: System.Reflection.Extensions => 0x70995ab73cf916ec => 5
	i64 8167236081217502503, ; 150: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 19
	i64 8185542183669246576, ; 151: System.Collections => 0x7198e33f4794aa70 => 151
	i64 8187102936927221770, ; 152: SkiaSharp.Views.Forms => 0x719e6ebe771ab80a => 32
	i64 8196541262927413903, ; 153: Xamarin.Android.Support.Interpolator => 0x71bff6d9fb9ec28f => 64
	i64 8290740647658429042, ; 154: System.Runtime.Extensions => 0x730ea0b15c929a72 => 158
	i64 8385935383968044654, ; 155: Xamarin.Android.Arch.Lifecycle.Runtime.dll => 0x7460d3cd16cb566e => 48
	i64 8398329775253868912, ; 156: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x748cdc6f3097d170 => 89
	i64 8400357532724379117, ; 157: Xamarin.AndroidX.Navigation.UI.dll => 0x749410ab44503ded => 116
	i64 8601935802264776013, ; 158: Xamarin.AndroidX.Transition.dll => 0x7760370982b4ed4d => 125
	i64 8626175481042262068, ; 159: Java.Interop => 0x77b654e585b55834 => 19
	i64 8639588376636138208, ; 160: Xamarin.AndroidX.Navigation.Runtime => 0x77e5fbdaa2fda2e0 => 115
	i64 8684531736582871431, ; 161: System.IO.Compression.FileSystem => 0x7885a79a0fa0d987 => 148
	i64 8702320156596882678, ; 162: Firebase.dll => 0x78c4da1357adccf6 => 16
	i64 8808820144457481518, ; 163: Xamarin.Android.Support.Loader.dll => 0x7a3f374010b17d2e => 65
	i64 8917102979740339192, ; 164: Xamarin.Android.Support.DocumentFile.dll => 0x7bbfe9ea4d000bf8 => 61
	i64 8974768617058262486, ; 165: Xamarin.AndroidX.MediaRouter.dll => 0x7c8cc881c114ddd6 => 112
	i64 9057635389615298436, ; 166: LiteDB => 0x7db32f65bf06d784 => 20
	i64 9114191852432800567, ; 167: FFImageLoading.dll => 0x7e7c1d3363043b37 => 12
	i64 9238306115887712111, ; 168: FFImageLoading.Forms.dll => 0x80350e773bce476f => 13
	i64 9296667808972889535, ; 169: LiteDB.dll => 0x8104661dcca35dbf => 20
	i64 9312692141327339315, ; 170: Xamarin.AndroidX.ViewPager2 => 0x813d54296a634f33 => 130
	i64 9324707631942237306, ; 171: Xamarin.AndroidX.AppCompat => 0x8168042fd44a7c7a => 81
	i64 9475595603812259686, ; 172: Xamarin.Android.Support.Design => 0x838013ff707b9766 => 60
	i64 9584643793929893533, ; 173: System.IO.dll => 0x85037ebfbbd7f69d => 154
	i64 9659729154652888475, ; 174: System.Text.RegularExpressions => 0x860e407c9991dd9b => 160
	i64 9662334977499516867, ; 175: System.Numerics.dll => 0x8617827802b0cfc3 => 35
	i64 9678050649315576968, ; 176: Xamarin.AndroidX.CoordinatorLayout.dll => 0x864f57c9feb18c88 => 91
	i64 9695067051349111183, ; 177: PanCardView.Droid.dll => 0x868bcc1dd541f18f => 25
	i64 9704560845386760312, ; 178: Refractored.XamForms.PullToRefresh.dll => 0x86ad86ac02714078 => 26
	i64 9711637524876806384, ; 179: Xamarin.AndroidX.Media.dll => 0x86c6aadfd9a2c8f0 => 111
	i64 9808709177481450983, ; 180: Mono.Android.dll => 0x881f890734e555e7 => 21
	i64 9825649861376906464, ; 181: Xamarin.AndroidX.Concurrent.Futures => 0x885bb87d8abc94e0 => 88
	i64 9834056768316610435, ; 182: System.Transactions.dll => 0x8879968718899783 => 145
	i64 9866412715007501892, ; 183: Xamarin.Android.Arch.Lifecycle.Common.dll => 0x88ec8a16fd6b6644 => 45
	i64 9998632235833408227, ; 184: Mono.Security => 0x8ac2470b209ebae3 => 164
	i64 10038780035334861115, ; 185: System.Net.Http.dll => 0x8b50e941206af13b => 3
	i64 10144742755892837524, ; 186: Firebase => 0x8cc95dc98eb5bc94 => 16
	i64 10229024438826829339, ; 187: Xamarin.AndroidX.CustomView => 0x8df4cb880b10061b => 94
	i64 10303855825347935641, ; 188: Xamarin.Android.Support.Loader => 0x8efea647eeb3fd99 => 65
	i64 10360651442923773544, ; 189: System.Text.Encoding => 0x8fc86d98211c1e68 => 159
	i64 10363495123250631811, ; 190: Xamarin.Android.Support.Collections.dll => 0x8fd287e80cd8d483 => 53
	i64 10376576884623852283, ; 191: Xamarin.AndroidX.Tracing.Tracing => 0x900101b2f888c2fb => 124
	i64 10430153318873392755, ; 192: Xamarin.AndroidX.Core => 0x90bf592ea44f6673 => 92
	i64 10566960649245365243, ; 193: System.Globalization.dll => 0x92a562b96dcd13fb => 163
	i64 10635644668885628703, ; 194: Xamarin.Android.Support.DrawerLayout.dll => 0x93996679ee34771f => 62
	i64 10714184849103829812, ; 195: System.Runtime.Extensions.dll => 0x94b06e5aa4b4bb34 => 158
	i64 10785150219063592792, ; 196: System.Net.Primitives => 0x95ac8cfb68830758 => 156
	i64 10847732767863316357, ; 197: Xamarin.AndroidX.Arch.Core.Common => 0x968ae37a86db9f85 => 82
	i64 10850923258212604222, ; 198: Xamarin.Android.Arch.Lifecycle.Runtime => 0x9696393672c9593e => 48
	i64 10936139690908480862, ; 199: Xamarin.Forms.Skeleton => 0x97c4f91b52a6755e => 137
	i64 11023048688141570732, ; 200: System.Core => 0x98f9bc61168392ac => 33
	i64 11037814507248023548, ; 201: System.Xml => 0x992e31d0412bf7fc => 39
	i64 11122995063473561350, ; 202: Xamarin.CommunityToolkit.dll => 0x9a5cd113fcc3df06 => 131
	i64 11162124722117608902, ; 203: Xamarin.AndroidX.ViewPager => 0x9ae7d54b986d05c6 => 129
	i64 11340910727871153756, ; 204: Xamarin.AndroidX.CursorAdapter => 0x9d630238642d465c => 93
	i64 11376461258732682436, ; 205: Xamarin.Android.Support.Compat => 0x9de14f3d5fc13cc4 => 54
	i64 11392833485892708388, ; 206: Xamarin.AndroidX.Print.dll => 0x9e1b79b18fcf6824 => 119
	i64 11395105072750394936, ; 207: Xamarin.Android.Support.v7.CardView => 0x9e238bb09789fe38 => 72
	i64 11529969570048099689, ; 208: Xamarin.AndroidX.ViewPager.dll => 0xa002ae3c4dc7c569 => 129
	i64 11578238080964724296, ; 209: Xamarin.AndroidX.Legacy.Support.V4 => 0xa0ae2a30c4cd8648 => 102
	i64 11580057168383206117, ; 210: Xamarin.AndroidX.Annotation => 0xa0b4a0a4103262e5 => 78
	i64 11597940890313164233, ; 211: netstandard => 0xa0f429ca8d1805c9 => 143
	i64 11666126733838079721, ; 212: Xamarin.Plugin.Calendar.dll => 0xa1e66874631b56e9 => 141
	i64 11672361001936329215, ; 213: Xamarin.AndroidX.Interpolator => 0xa1fc8e7d0a8999ff => 99
	i64 11724931932191659106, ; 214: Xamarin.AndroidX.Palette => 0xa2b7537891eb1462 => 117
	i64 11743665907891708234, ; 215: System.Threading.Tasks => 0xa2f9e1ec30c0214a => 153
	i64 11834399401546345650, ; 216: Xamarin.Android.Support.SlidingPaneLayout.dll => 0xa43c3b8deb43ecb2 => 68
	i64 11865714326292153359, ; 217: Xamarin.Android.Arch.Lifecycle.LiveData => 0xa4ab7c5000e8440f => 47
	i64 12123043025855404482, ; 218: System.Reflection.Extensions.dll => 0xa83db366c0e359c2 => 5
	i64 12137774235383566651, ; 219: Xamarin.AndroidX.VectorDrawable => 0xa872095bbfed113b => 127
	i64 12388767885335911387, ; 220: Xamarin.Android.Arch.Lifecycle.LiveData.dll => 0xabedbec0d236dbdb => 47
	i64 12414299427252656003, ; 221: Xamarin.Android.Support.Compat.dll => 0xac48738e28bad783 => 54
	i64 12451044538927396471, ; 222: Xamarin.AndroidX.Fragment.dll => 0xaccaff0a2955b677 => 98
	i64 12466513435562512481, ; 223: Xamarin.AndroidX.Loader.dll => 0xad01f3eb52569061 => 109
	i64 12476224141212591012, ; 224: BXM308_Assignment.Android.dll => 0xad2473c12b2123a4 => 0
	i64 12487638416075308985, ; 225: Xamarin.AndroidX.DocumentFile.dll => 0xad4d00fa21b0bfb9 => 95
	i64 12538491095302438457, ; 226: Xamarin.AndroidX.CardView.dll => 0xae01ab382ae67e39 => 86
	i64 12550732019250633519, ; 227: System.IO.Compression => 0xae2d28465e8e1b2f => 147
	i64 12559163541709922900, ; 228: Xamarin.Android.Support.v7.CardView.dll => 0xae4b1cb32ba82254 => 72
	i64 12700543734426720211, ; 229: Xamarin.AndroidX.Collection => 0xb041653c70d157d3 => 87
	i64 12708238894395270091, ; 230: System.IO => 0xb05cbbf17d3ba3cb => 154
	i64 12952608645614506925, ; 231: Xamarin.Android.Support.Core.Utils => 0xb3c0e8eff48193ad => 57
	i64 12963446364377008305, ; 232: System.Drawing.Common.dll => 0xb3e769c8fd8548b1 => 1
	i64 13358059602087096138, ; 233: Xamarin.Android.Support.Fragment.dll => 0xb9615c6f1ee5af4a => 63
	i64 13370592475155966277, ; 234: System.Runtime.Serialization => 0xb98de304062ea945 => 6
	i64 13401370062847626945, ; 235: Xamarin.AndroidX.VectorDrawable.dll => 0xb9fb3b1193964ec1 => 127
	i64 13404347523447273790, ; 236: Xamarin.AndroidX.ConstraintLayout.Core => 0xba05cf0da4f6393e => 89
	i64 13454009404024712428, ; 237: Xamarin.Google.Guava.ListenableFuture => 0xbab63e4543a86cec => 140
	i64 13491513212026656886, ; 238: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0xbb3b7bc905569876 => 83
	i64 13492263892638604996, ; 239: SkiaSharp.Views.Forms.dll => 0xbb3e2686788d9ec4 => 32
	i64 13572454107664307259, ; 240: Xamarin.AndroidX.RecyclerView.dll => 0xbc5b0b19d99f543b => 120
	i64 13613039368886131107, ; 241: Sharpnado.MaterialFrame.Android.dll => 0xbceb3b2e57dd99a3 => 28
	i64 13647894001087880694, ; 242: System.Data.dll => 0xbd670f48cb071df6 => 144
	i64 13852575513600495870, ; 243: ImageCircle.Forms.Plugin.dll => 0xc03e3c09186e90fe => 18
	i64 13959074834287824816, ; 244: Xamarin.AndroidX.Fragment => 0xc1b8989a7ad20fb0 => 98
	i64 13967638549803255703, ; 245: Xamarin.Forms.Platform.Android => 0xc1d70541e0134797 => 135
	i64 14124974489674258913, ; 246: Xamarin.AndroidX.CardView => 0xc405fd76067d19e1 => 86
	i64 14125464355221830302, ; 247: System.Threading.dll => 0xc407bafdbc707a9e => 157
	i64 14172845254133543601, ; 248: Xamarin.AndroidX.MultiDex => 0xc4b00faaed35f2b1 => 113
	i64 14240145736568846764, ; 249: Com.ViewPagerIndicator => 0xc59f291991fab9ac => 11
	i64 14261073672896646636, ; 250: Xamarin.AndroidX.Print => 0xc5e982f274ae0dec => 119
	i64 14267242366184657376, ; 251: Toasts.Forms.Plugin.Abstractions => 0xc5ff6d5748d711e0 => 41
	i64 14327695147300244862, ; 252: System.Reflection.dll => 0xc6d632d338eb4d7e => 152
	i64 14343779804637125676, ; 253: PanCardView.Droid => 0xc70f57bc57d15c2c => 25
	i64 14369828458497533121, ; 254: Xamarin.Android.Support.Vector.Drawable => 0xc76be2d9300b64c1 => 74
	i64 14400856865250966808, ; 255: Xamarin.Android.Support.Core.UI => 0xc7da1f051a877d18 => 56
	i64 14454106681488828596, ; 256: PanCardView.dll => 0xc8974d7217bde8b4 => 24
	i64 14486659737292545672, ; 257: Xamarin.AndroidX.Lifecycle.LiveData => 0xc90af44707469e88 => 105
	i64 14644440854989303794, ; 258: Xamarin.AndroidX.LocalBroadcastManager.dll => 0xcb3b815e37daeff2 => 110
	i64 14661790646341542033, ; 259: Xamarin.Android.Support.SwipeRefreshLayout => 0xcb7924e94e552091 => 69
	i64 14792063746108907174, ; 260: Xamarin.Google.Guava.ListenableFuture.dll => 0xcd47f79af9c15ea6 => 140
	i64 14852515768018889994, ; 261: Xamarin.AndroidX.CursorAdapter.dll => 0xce1ebc6625a76d0a => 93
	i64 14977203018215041975, ; 262: CarouselView.FormsPlugin.Droid => 0xcfd9b6cadd9dabb7 => 9
	i64 14987728460634540364, ; 263: System.IO.Compression.dll => 0xcfff1ba06622494c => 147
	i64 14988210264188246988, ; 264: Xamarin.AndroidX.DocumentFile => 0xd000d1d307cddbcc => 95
	i64 15076659072870671916, ; 265: System.ObjectModel.dll => 0xd13b0d8c1620662c => 162
	i64 15133485256822086103, ; 266: System.Linq.dll => 0xd204f0a9127dd9d7 => 161
	i64 15188640517174936311, ; 267: Xamarin.Android.Arch.Core.Common => 0xd2c8e413d75142f7 => 43
	i64 15246441518555807158, ; 268: Xamarin.Android.Arch.Core.Common.dll => 0xd3963dc832493db6 => 43
	i64 15326820765897713587, ; 269: Xamarin.Android.Arch.Core.Runtime.dll => 0xd4b3ce481769e7b3 => 44
	i64 15370334346939861994, ; 270: Xamarin.AndroidX.Core.dll => 0xd54e65a72c560bea => 92
	i64 15398511348637731642, ; 271: FFImageLoading.Forms.Platform.dll => 0xd5b2807c9d5f8b3a => 14
	i64 15406949360826139137, ; 272: Com.Android.DeskClock.dll => 0xd5d07ad06c794201 => 10
	i64 15418891414777631748, ; 273: Xamarin.Android.Support.Transition => 0xd5fae80c88241404 => 70
	i64 15526743539506359484, ; 274: System.Text.Encoding.dll => 0xd77a12fc26de2cbc => 159
	i64 15568534730848034786, ; 275: Xamarin.Android.Support.VersionedParcelable.dll => 0xd80e8bda21875fe2 => 75
	i64 15582737692548360875, ; 276: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xd841015ed86f6aab => 108
	i64 15609085926864131306, ; 277: System.dll => 0xd89e9cf3334914ea => 34
	i64 15777549416145007739, ; 278: Xamarin.AndroidX.SlidingPaneLayout.dll => 0xdaf51d99d77eb47b => 122
	i64 15810740023422282496, ; 279: Xamarin.Forms.Xaml => 0xdb6b08484c22eb00 => 138
	i64 15817206913877585035, ; 280: System.Threading.Tasks.dll => 0xdb8201e29086ac8b => 153
	i64 15937221174461587888, ; 281: Sharpnado.MaterialFrame.Android => 0xdd2c62381a9de1b0 => 28
	i64 16154507427712707110, ; 282: System => 0xe03056ea4e39aa26 => 34
	i64 16242842420508142678, ; 283: Xamarin.Android.Support.CoordinaterLayout.dll => 0xe16a2b1f8908ac56 => 55
	i64 16324796876805858114, ; 284: SkiaSharp.dll => 0xe28d5444586b6342 => 30
	i64 16565028646146589191, ; 285: System.ComponentModel.Composition.dll => 0xe5e2cdc9d3bcc207 => 149
	i64 16621146507174665210, ; 286: Xamarin.AndroidX.ConstraintLayout => 0xe6aa2caf87dedbfa => 90
	i64 16677317093839702854, ; 287: Xamarin.AndroidX.Navigation.UI => 0xe771bb8960dd8b46 => 116
	i64 16767985610513713374, ; 288: Xamarin.Android.Arch.Core.Runtime => 0xe8b3da12798808de => 44
	i64 16822611501064131242, ; 289: System.Data.DataSetExtensions => 0xe975ec07bb5412aa => 146
	i64 16833383113903931215, ; 290: mscorlib => 0xe99c30c1484d7f4f => 22
	i64 16866861824412579935, ; 291: System.Runtime.InteropServices.WindowsRuntime => 0xea132176ffb5785f => 2
	i64 16890310621557459193, ; 292: System.Text.RegularExpressions.dll => 0xea66700587f088f9 => 160
	i64 16932527889823454152, ; 293: Xamarin.Android.Support.Core.Utils.dll => 0xeafc6c67465253c8 => 57
	i64 17009591894298689098, ; 294: Xamarin.Android.Support.Animated.Vector.Drawable => 0xec0e35b50a097e4a => 50
	i64 17024911836938395553, ; 295: Xamarin.AndroidX.Annotation.Experimental.dll => 0xec44a31d250e5fa1 => 79
	i64 17031351772568316411, ; 296: Xamarin.AndroidX.Navigation.Common.dll => 0xec5b843380a769fb => 114
	i64 17037200463775726619, ; 297: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xec704b8e0a78fc1b => 101
	i64 17285063141349522879, ; 298: Rg.Plugins.Popup => 0xefe0e158cc55fdbf => 27
	i64 17383232329670771222, ; 299: Xamarin.Android.Support.CustomView.dll => 0xf13da5b41a1cc216 => 59
	i64 17428701562824544279, ; 300: Xamarin.Android.Support.Core.UI.dll => 0xf1df2fbaec73d017 => 56
	i64 17483646997724851973, ; 301: Xamarin.Android.Support.ViewPager => 0xf2a2644fe5b6ef05 => 76
	i64 17524135665394030571, ; 302: Xamarin.Android.Support.Print => 0xf3323c8a739097eb => 67
	i64 17544493274320527064, ; 303: Xamarin.AndroidX.AsyncLayoutInflater => 0xf37a8fada41aded8 => 84
	i64 17620075112035931419, ; 304: Xamarin.Forms.Skeleton.dll => 0xf48714f5909a551b => 137
	i64 17627500474728259406, ; 305: System.Globalization => 0xf4a176498a351f4e => 163
	i64 17643123953373031521, ; 306: FFImageLoading => 0xf4d8f7c220fc2c61 => 12
	i64 17666959971718154066, ; 307: Xamarin.Android.Support.CustomView => 0xf52da67d9f4e4752 => 59
	i64 17671790519499593115, ; 308: SkiaSharp.Views.Android => 0xf53ecfd92be3959b => 31
	i64 17685921127322830888, ; 309: System.Diagnostics.Debug.dll => 0xf571038fafa74828 => 155
	i64 17704177640604968747, ; 310: Xamarin.AndroidX.Loader => 0xf5b1dfc36cac272b => 109
	i64 17710060891934109755, ; 311: Xamarin.AndroidX.Lifecycle.ViewModel => 0xf5c6c68c9e45303b => 107
	i64 17760961058993581169, ; 312: Xamarin.Android.Arch.Lifecycle.Common => 0xf67b9bfb46dbac71 => 45
	i64 17827832363535584534, ; 313: Xamarin.Forms.PancakeView.dll => 0xf7692f1427c04d16 => 134
	i64 17841643939744178149, ; 314: Xamarin.Android.Arch.Lifecycle.ViewModel => 0xf79a40a25573dfe5 => 49
	i64 17882897186074144999, ; 315: FormsViewGroup => 0xf82cd03e3ac830e7 => 17
	i64 17892495832318972303, ; 316: Xamarin.Forms.Xaml.dll => 0xf84eea293687918f => 138
	i64 17928294245072900555, ; 317: System.IO.Compression.FileSystem.dll => 0xf8ce18a0b24011cb => 148
	i64 17936749993673010118, ; 318: Xamarin.Android.Support.Design.dll => 0xf8ec231615deabc6 => 60
	i64 17947624217716767869, ; 319: FFImageLoading.Platform => 0xf912c522ab34bc7d => 15
	i64 17958105683855786126, ; 320: Xamarin.Android.Arch.Lifecycle.LiveData.Core.dll => 0xf93801f92d25c08e => 46
	i64 18025913125965088385, ; 321: System.Threading => 0xfa28e87b91334681 => 157
	i64 18090425465832348288, ; 322: Xamarin.Android.Support.v7.RecyclerView => 0xfb0e1a1d2e9e1a80 => 73
	i64 18116111925905154859, ; 323: Xamarin.AndroidX.Arch.Core.Runtime => 0xfb695bd036cb632b => 83
	i64 18121036031235206392, ; 324: Xamarin.AndroidX.Navigation.Common => 0xfb7ada42d3d42cf8 => 114
	i64 18129453464017766560, ; 325: System.ServiceModel.Internals.dll => 0xfb98c1df1ec108a0 => 142
	i64 18129516712185991190, ; 326: BXM308_Assignment => 0xfb98fb653b5a9016 => 7
	i64 18245806341561545090, ; 327: System.Collections.Concurrent.dll => 0xfd3620327d587182 => 165
	i64 18301997741680159453, ; 328: Xamarin.Android.Support.CursorAdapter => 0xfdfdc1fa58d8eadd => 58
	i64 18305135509493619199, ; 329: Xamarin.AndroidX.Navigation.Runtime.dll => 0xfe08e7c2d8c199ff => 115
	i64 18380184030268848184, ; 330: Xamarin.AndroidX.VersionedParcelable => 0xff1387fe3e7b7838 => 128
	i64 18402699419805051340 ; 331: BXM308_Assignment.dll => 0xff63859ee1c469cc => 7
], align 8
@assembly_image_cache_indices = local_unnamed_addr constant [332 x i32] [
	i32 14, i32 97, i32 26, i32 21, i32 87, i32 121, i32 27, i32 122, ; 0..7
	i32 18, i32 112, i32 37, i32 49, i32 106, i32 1, i32 100, i32 53, ; 8..15
	i32 46, i32 96, i32 145, i32 136, i32 164, i32 139, i32 29, i32 82, ; 16..23
	i32 63, i32 6, i32 156, i32 75, i32 80, i32 108, i32 101, i32 23, ; 24..31
	i32 71, i32 81, i32 8, i32 121, i32 73, i32 78, i32 107, i32 15, ; 32..39
	i32 131, i32 23, i32 113, i32 85, i32 96, i32 150, i32 165, i32 104, ; 40..47
	i32 10, i32 91, i32 126, i32 38, i32 77, i32 39, i32 22, i32 8, ; 48..55
	i32 118, i32 13, i32 42, i32 68, i32 133, i32 62, i32 139, i32 103, ; 56..63
	i32 79, i32 36, i32 124, i32 123, i32 35, i32 38, i32 143, i32 120, ; 64..71
	i32 97, i32 24, i32 76, i32 70, i32 0, i32 61, i32 52, i32 142, ; 72..79
	i32 42, i32 128, i32 84, i32 77, i32 123, i32 41, i32 55, i32 66, ; 80..87
	i32 4, i32 4, i32 135, i32 67, i32 132, i32 110, i32 64, i32 111, ; 88..95
	i32 134, i32 126, i32 125, i32 50, i32 155, i32 90, i32 33, i32 117, ; 96..103
	i32 11, i32 130, i32 88, i32 51, i32 118, i32 105, i32 69, i32 136, ; 104..111
	i32 17, i32 9, i32 66, i32 106, i32 104, i32 74, i32 29, i32 85, ; 112..119
	i32 94, i32 150, i32 100, i32 30, i32 40, i32 36, i32 102, i32 99, ; 120..127
	i32 141, i32 2, i32 58, i32 161, i32 152, i32 40, i32 162, i32 37, ; 128..135
	i32 133, i32 132, i32 3, i32 144, i32 52, i32 80, i32 71, i32 31, ; 136..143
	i32 149, i32 151, i32 103, i32 51, i32 146, i32 5, i32 19, i32 151, ; 144..151
	i32 32, i32 64, i32 158, i32 48, i32 89, i32 116, i32 125, i32 19, ; 152..159
	i32 115, i32 148, i32 16, i32 65, i32 61, i32 112, i32 20, i32 12, ; 160..167
	i32 13, i32 20, i32 130, i32 81, i32 60, i32 154, i32 160, i32 35, ; 168..175
	i32 91, i32 25, i32 26, i32 111, i32 21, i32 88, i32 145, i32 45, ; 176..183
	i32 164, i32 3, i32 16, i32 94, i32 65, i32 159, i32 53, i32 124, ; 184..191
	i32 92, i32 163, i32 62, i32 158, i32 156, i32 82, i32 48, i32 137, ; 192..199
	i32 33, i32 39, i32 131, i32 129, i32 93, i32 54, i32 119, i32 72, ; 200..207
	i32 129, i32 102, i32 78, i32 143, i32 141, i32 99, i32 117, i32 153, ; 208..215
	i32 68, i32 47, i32 5, i32 127, i32 47, i32 54, i32 98, i32 109, ; 216..223
	i32 0, i32 95, i32 86, i32 147, i32 72, i32 87, i32 154, i32 57, ; 224..231
	i32 1, i32 63, i32 6, i32 127, i32 89, i32 140, i32 83, i32 32, ; 232..239
	i32 120, i32 28, i32 144, i32 18, i32 98, i32 135, i32 86, i32 157, ; 240..247
	i32 113, i32 11, i32 119, i32 41, i32 152, i32 25, i32 74, i32 56, ; 248..255
	i32 24, i32 105, i32 110, i32 69, i32 140, i32 93, i32 9, i32 147, ; 256..263
	i32 95, i32 162, i32 161, i32 43, i32 43, i32 44, i32 92, i32 14, ; 264..271
	i32 10, i32 70, i32 159, i32 75, i32 108, i32 34, i32 122, i32 138, ; 272..279
	i32 153, i32 28, i32 34, i32 55, i32 30, i32 149, i32 90, i32 116, ; 280..287
	i32 44, i32 146, i32 22, i32 2, i32 160, i32 57, i32 50, i32 79, ; 288..295
	i32 114, i32 101, i32 27, i32 59, i32 56, i32 76, i32 67, i32 84, ; 296..303
	i32 137, i32 163, i32 12, i32 59, i32 31, i32 155, i32 109, i32 107, ; 304..311
	i32 45, i32 134, i32 49, i32 17, i32 138, i32 148, i32 60, i32 15, ; 312..319
	i32 46, i32 157, i32 73, i32 83, i32 114, i32 142, i32 7, i32 165, ; 320..327
	i32 58, i32 115, i32 128, i32 7 ; 328..331
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 8; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 8

; Function attributes: "frame-pointer"="non-leaf" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 8
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 8
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="non-leaf" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="non-leaf" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2, !3, !4, !5}
!llvm.ident = !{!6}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"branch-target-enforcement", i32 0}
!3 = !{i32 1, !"sign-return-address", i32 0}
!4 = !{i32 1, !"sign-return-address-all", i32 0}
!5 = !{i32 1, !"sign-return-address-with-bkey", i32 0}
!6 = !{!"Xamarin.Android remotes/origin/d17-5 @ 45b0e144f73b2c8747d8b5ec8cbd3b55beca67f0"}
!llvm.linker.options = !{}
