; ModuleID = 'obj\Debug\120\android\marshal_methods.x86.ll'
source_filename = "obj\Debug\120\android\marshal_methods.x86.ll"
target datalayout = "e-m:e-p:32:32-p270:32:32-p271:32:32-p272:64:64-f64:32:64-f80:32-n8:16:32-S128"
target triple = "i686-unknown-linux-android"


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
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [332 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 106
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 140
	i32 39109920, ; 2: Newtonsoft.Json.dll => 0x254c520 => 23
	i32 57263871, ; 3: Xamarin.Forms.Core.dll => 0x369c6ff => 133
	i32 57967248, ; 4: Xamarin.Android.Support.VersionedParcelable.dll => 0x3748290 => 75
	i32 101534019, ; 5: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 122
	i32 120558881, ; 6: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 122
	i32 160529393, ; 7: Xamarin.Android.Arch.Core.Common => 0x9917bf1 => 43
	i32 165246403, ; 8: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 87
	i32 166922606, ; 9: Xamarin.Android.Support.Compat.dll => 0x9f3096e => 54
	i32 182336117, ; 10: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 123
	i32 201930040, ; 11: Xamarin.Android.Arch.Core.Runtime => 0xc093538 => 44
	i32 209399409, ; 12: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 85
	i32 215846017, ; 13: Sharpnado.MaterialFrame.dll => 0xcdd8c81 => 29
	i32 220171995, ; 14: System.Diagnostics.Debug => 0xd1f8edb => 155
	i32 230216969, ; 15: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 101
	i32 231814094, ; 16: System.Globalization => 0xdd133ce => 163
	i32 232587938, ; 17: Xamarin.AndroidX.MediaRouter => 0xddd02a2 => 112
	i32 232815796, ; 18: System.Web.Services => 0xde07cb4 => 150
	i32 261689757, ; 19: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 90
	i32 278686392, ; 20: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 105
	i32 280482487, ; 21: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 99
	i32 293914992, ; 22: Xamarin.Android.Support.Transition => 0x1184c970 => 70
	i32 318968648, ; 23: Xamarin.AndroidX.Activity.dll => 0x13031348 => 77
	i32 321597661, ; 24: System.Numerics => 0x132b30dd => 35
	i32 342366114, ; 25: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 103
	i32 388313361, ; 26: Xamarin.Android.Support.Animated.Vector.Drawable => 0x17253111 => 50
	i32 389971796, ; 27: Xamarin.Android.Support.Core.UI => 0x173e7f54 => 56
	i32 393699800, ; 28: Firebase => 0x177761d8 => 16
	i32 402672763, ; 29: Xamarin.Plugin.Calendar => 0x18004c7b => 141
	i32 405971685, ; 30: Refractored.XamForms.PullToRefresh.dll => 0x1832a2e5 => 26
	i32 441335492, ; 31: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 89
	i32 442521989, ; 32: Xamarin.Essentials => 0x1a605985 => 132
	i32 442565967, ; 33: System.Collections => 0x1a61054f => 151
	i32 450948140, ; 34: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 98
	i32 464011637, ; 35: CarouselView.FormsPlugin.Abstractions => 0x1ba84175 => 8
	i32 465846621, ; 36: mscorlib => 0x1bc4415d => 22
	i32 469710990, ; 37: System.dll => 0x1bff388e => 34
	i32 476646585, ; 38: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 99
	i32 484505379, ; 39: PanCardView => 0x1ce0f723 => 24
	i32 484808150, ; 40: Com.Android.DeskClock.dll => 0x1ce595d6 => 10
	i32 486930444, ; 41: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 110
	i32 498788369, ; 42: System.ObjectModel => 0x1dbae811 => 162
	i32 501699973, ; 43: Xamarin.Forms.Skeleton => 0x1de75585 => 137
	i32 505051701, ; 44: BXM308_Assignment.dll => 0x1e1a7a35 => 7
	i32 514659665, ; 45: Xamarin.Android.Support.Compat => 0x1ead1551 => 54
	i32 520798577, ; 46: FFImageLoading.Platform => 0x1f0ac171 => 15
	i32 524864063, ; 47: Xamarin.Android.Support.Print => 0x1f48ca3f => 67
	i32 525008092, ; 48: SkiaSharp.dll => 0x1f4afcdc => 30
	i32 526420162, ; 49: System.Transactions.dll => 0x1f6088c2 => 145
	i32 539750087, ; 50: Xamarin.Android.Support.Design => 0x202beec7 => 60
	i32 545304856, ; 51: System.Runtime.Extensions => 0x2080b118 => 158
	i32 571524804, ; 52: Xamarin.Android.Support.v7.RecyclerView => 0x2210c6c4 => 73
	i32 605376203, ; 53: System.IO.Compression.FileSystem => 0x24154ecb => 148
	i32 610194910, ; 54: System.Reactive.dll => 0x245ed5de => 37
	i32 627609679, ; 55: Xamarin.AndroidX.CustomView => 0x2568904f => 94
	i32 663517072, ; 56: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 128
	i32 666292255, ; 57: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 82
	i32 672442732, ; 58: System.Collections.Concurrent => 0x2814a96c => 165
	i32 690569205, ; 59: System.Xml.Linq.dll => 0x29293ff5 => 40
	i32 692692150, ; 60: Xamarin.Android.Support.Annotations => 0x2949a4b6 => 51
	i32 747088582, ; 61: Xamarin.Forms.Skeleton.dll => 0x2c87aac6 => 137
	i32 775507847, ; 62: System.IO.Compression => 0x2e394f87 => 147
	i32 801787702, ; 63: Xamarin.Android.Support.Interpolator => 0x2fca4f36 => 64
	i32 809851609, ; 64: System.Drawing.Common.dll => 0x30455ad9 => 1
	i32 843511501, ; 65: Xamarin.AndroidX.Print => 0x3246f6cd => 119
	i32 877678880, ; 66: System.Globalization.dll => 0x34505120 => 163
	i32 902159924, ; 67: Rg.Plugins.Popup => 0x35c5de34 => 27
	i32 916714535, ; 68: Xamarin.Android.Support.Print.dll => 0x36a3f427 => 67
	i32 928116545, ; 69: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 140
	i32 955402788, ; 70: Newtonsoft.Json => 0x38f24a24 => 23
	i32 967690846, ; 71: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 103
	i32 974778368, ; 72: FormsViewGroup.dll => 0x3a19f000 => 17
	i32 987342438, ; 73: Xamarin.Android.Arch.Lifecycle.LiveData.dll => 0x3ad9a666 => 47
	i32 992768348, ; 74: System.Collections.dll => 0x3b2c715c => 151
	i32 994148100, ; 75: BXM308_Assignment => 0x3b417f04 => 7
	i32 1012816738, ; 76: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 121
	i32 1035644815, ; 77: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 81
	i32 1042160112, ; 78: Xamarin.Forms.Platform.dll => 0x3e1e19f0 => 136
	i32 1052210849, ; 79: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 107
	i32 1052823365, ; 80: Com.ViewPagerIndicator => 0x3ec0cf45 => 11
	i32 1098167829, ; 81: Xamarin.Android.Arch.Lifecycle.ViewModel => 0x4174b615 => 49
	i32 1098259244, ; 82: System => 0x41761b2c => 34
	i32 1175144683, ; 83: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 126
	i32 1178241025, ; 84: Xamarin.AndroidX.Navigation.Runtime.dll => 0x463a8801 => 115
	i32 1204270330, ; 85: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 82
	i32 1267360935, ; 86: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 127
	i32 1292763917, ; 87: Xamarin.Android.Support.CursorAdapter.dll => 0x4d0e030d => 58
	i32 1293217323, ; 88: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 96
	i32 1297413738, ; 89: Xamarin.Android.Arch.Lifecycle.LiveData.Core => 0x4d54f66a => 46
	i32 1324164729, ; 90: System.Linq => 0x4eed2679 => 161
	i32 1359785034, ; 91: Xamarin.Android.Support.Design.dll => 0x510cac4a => 60
	i32 1364015309, ; 92: System.IO => 0x514d38cd => 154
	i32 1365406463, ; 93: System.ServiceModel.Internals.dll => 0x516272ff => 142
	i32 1376866003, ; 94: Xamarin.AndroidX.SavedState => 0x52114ed3 => 121
	i32 1379779777, ; 95: System.Resources.ResourceManager => 0x523dc4c1 => 4
	i32 1395857551, ; 96: Xamarin.AndroidX.Media.dll => 0x5333188f => 111
	i32 1406073936, ; 97: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 91
	i32 1445445088, ; 98: Xamarin.Android.Support.Fragment => 0x5627bde0 => 63
	i32 1457743152, ; 99: System.Runtime.Extensions.dll => 0x56e36530 => 158
	i32 1460219004, ; 100: Xamarin.Forms.Xaml => 0x57092c7c => 138
	i32 1462112819, ; 101: System.IO.Compression.dll => 0x57261233 => 147
	i32 1469204771, ; 102: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 80
	i32 1471004569, ; 103: BXM308_Assignment.Android.dll => 0x57adbf99 => 0
	i32 1488488195, ; 104: Toasts.Forms.Plugin.Droid => 0x58b88703 => 42
	i32 1530772511, ; 105: FFImageLoading.Forms.Platform => 0x5b3dbc1f => 14
	i32 1532191201, ; 106: Toasts.Forms.Plugin.Droid.dll => 0x5b5361e1 => 42
	i32 1543031311, ; 107: System.Text.RegularExpressions.dll => 0x5bf8ca0f => 160
	i32 1550322496, ; 108: System.Reflection.Extensions.dll => 0x5c680b40 => 5
	i32 1574652163, ; 109: Xamarin.Android.Support.Core.Utils.dll => 0x5ddb4903 => 57
	i32 1582372066, ; 110: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 95
	i32 1587447679, ; 111: Xamarin.Android.Arch.Core.Common.dll => 0x5e9e877f => 43
	i32 1592978981, ; 112: System.Runtime.Serialization.dll => 0x5ef2ee25 => 6
	i32 1622152042, ; 113: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 109
	i32 1624863272, ; 114: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 130
	i32 1636350590, ; 115: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 93
	i32 1639515021, ; 116: System.Net.Http.dll => 0x61b9038d => 3
	i32 1639986890, ; 117: System.Text.RegularExpressions => 0x61c036ca => 160
	i32 1657153582, ; 118: System.Runtime => 0x62c6282e => 38
	i32 1658241508, ; 119: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 124
	i32 1658251792, ; 120: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 139
	i32 1662014763, ; 121: Xamarin.Android.Support.Vector.Drawable => 0x6310552b => 74
	i32 1670060433, ; 122: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 90
	i32 1677501392, ; 123: System.Net.Primitives.dll => 0x63fca3d0 => 156
	i32 1701541528, ; 124: System.Diagnostics.Debug.dll => 0x656b7698 => 155
	i32 1722051300, ; 125: SkiaSharp.Views.Forms => 0x66a46ae4 => 32
	i32 1726116996, ; 126: System.Reflection.dll => 0x66e27484 => 152
	i32 1729485958, ; 127: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 86
	i32 1765942094, ; 128: System.Reflection.Extensions => 0x6942234e => 5
	i32 1766324549, ; 129: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 123
	i32 1776026572, ; 130: System.Core.dll => 0x69dc03cc => 33
	i32 1788241197, ; 131: Xamarin.AndroidX.Fragment => 0x6a96652d => 98
	i32 1793089559, ; 132: FFImageLoading.Forms.dll => 0x6ae06017 => 13
	i32 1808609942, ; 133: Xamarin.AndroidX.Loader => 0x6bcd3296 => 109
	i32 1812481981, ; 134: Xamarin.Plugin.Calendar.dll => 0x6c0847bd => 141
	i32 1813201214, ; 135: Xamarin.Google.Android.Material => 0x6c13413e => 139
	i32 1818569960, ; 136: Xamarin.AndroidX.Navigation.UI.dll => 0x6c652ce8 => 116
	i32 1840964413, ; 137: FFImageLoading.Forms => 0x6dbae33d => 13
	i32 1866717392, ; 138: Xamarin.Android.Support.Interpolator.dll => 0x6f43d8d0 => 64
	i32 1867746548, ; 139: Xamarin.Essentials.dll => 0x6f538cf4 => 132
	i32 1877418711, ; 140: Xamarin.Android.Support.v7.RecyclerView.dll => 0x6fe722d7 => 73
	i32 1878053835, ; 141: Xamarin.Forms.Xaml.dll => 0x6ff0d3cb => 138
	i32 1885316902, ; 142: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 83
	i32 1900610850, ; 143: System.Resources.ResourceManager.dll => 0x71490522 => 4
	i32 1904755420, ; 144: System.Runtime.InteropServices.WindowsRuntime.dll => 0x718842dc => 2
	i32 1916660109, ; 145: Xamarin.Android.Arch.Lifecycle.ViewModel.dll => 0x723de98d => 49
	i32 1919157823, ; 146: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 113
	i32 1971544783, ; 147: Sharpnado.MaterialFrame.Android => 0x758362cf => 28
	i32 2019465201, ; 148: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 107
	i32 2033194209, ; 149: Toasts.Forms.Plugin.Abstractions.dll => 0x793014e1 => 41
	i32 2037417872, ; 150: Xamarin.Android.Support.ViewPager => 0x79708790 => 76
	i32 2044222327, ; 151: Xamarin.Android.Support.Loader => 0x79d85b77 => 65
	i32 2055257422, ; 152: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 104
	i32 2079903147, ; 153: System.Runtime.dll => 0x7bf8cdab => 38
	i32 2090596640, ; 154: System.Numerics.Vectors => 0x7c9bf920 => 36
	i32 2097448633, ; 155: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 100
	i32 2113902067, ; 156: Xamarin.Forms.PancakeView.dll => 0x7dff95f3 => 134
	i32 2126786730, ; 157: Xamarin.Forms.Platform.Android => 0x7ec430aa => 135
	i32 2139458754, ; 158: Xamarin.Android.Support.DrawerLayout => 0x7f858cc2 => 62
	i32 2166116741, ; 159: Xamarin.Android.Support.Core.Utils => 0x811c5185 => 57
	i32 2193016926, ; 160: System.ObjectModel.dll => 0x82b6c85e => 162
	i32 2196165013, ; 161: Xamarin.Android.Support.VersionedParcelable => 0x82e6d195 => 75
	i32 2201231467, ; 162: System.Net.Http => 0x8334206b => 3
	i32 2217644978, ; 163: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 126
	i32 2223038681, ; 164: Sharpnado.MaterialFrame => 0x8480e0d9 => 29
	i32 2244775296, ; 165: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 110
	i32 2256548716, ; 166: Xamarin.AndroidX.MultiDex => 0x8680336c => 113
	i32 2261435625, ; 167: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x86cac4e9 => 102
	i32 2279755925, ; 168: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 120
	i32 2315684594, ; 169: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 78
	i32 2330457430, ; 170: Xamarin.Android.Support.Core.UI.dll => 0x8ae7f556 => 56
	i32 2330986192, ; 171: Xamarin.Android.Support.SlidingPaneLayout.dll => 0x8af006d0 => 68
	i32 2340826669, ; 172: FFImageLoading.dll => 0x8b862e2d => 12
	i32 2353062107, ; 173: System.Net.Primitives => 0x8c40e0db => 156
	i32 2373288475, ; 174: Xamarin.Android.Support.Fragment.dll => 0x8d75821b => 63
	i32 2397082276, ; 175: Xamarin.Forms.PancakeView => 0x8ee092a4 => 134
	i32 2409053734, ; 176: Xamarin.AndroidX.Preference.dll => 0x8f973e26 => 118
	i32 2440966767, ; 177: Xamarin.Android.Support.Loader.dll => 0x917e326f => 65
	i32 2454642406, ; 178: System.Text.Encoding.dll => 0x924edee6 => 159
	i32 2465532216, ; 179: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 89
	i32 2471215200, ; 180: ImageCircle.Forms.Plugin => 0x934bc060 => 18
	i32 2471841756, ; 181: netstandard.dll => 0x93554fdc => 143
	i32 2475788418, ; 182: Java.Interop.dll => 0x93918882 => 19
	i32 2487632829, ; 183: Xamarin.Android.Support.DocumentFile => 0x944643bd => 61
	i32 2501346920, ; 184: System.Data.DataSetExtensions => 0x95178668 => 146
	i32 2505896520, ; 185: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 106
	i32 2581819634, ; 186: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 127
	i32 2620871830, ; 187: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 93
	i32 2624644809, ; 188: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 97
	i32 2633051222, ; 189: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 105
	i32 2693849962, ; 190: System.IO.dll => 0xa090e36a => 154
	i32 2698266930, ; 191: Xamarin.Android.Arch.Lifecycle.LiveData => 0xa0d44932 => 47
	i32 2701096212, ; 192: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 124
	i32 2715334215, ; 193: System.Threading.Tasks.dll => 0xa1d8b647 => 153
	i32 2719786539, ; 194: BXM308_Assignment.Android => 0xa21ca62b => 0
	i32 2732626843, ; 195: Xamarin.AndroidX.Activity => 0xa2e0939b => 77
	i32 2737747696, ; 196: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 80
	i32 2751899777, ; 197: Xamarin.Android.Support.Collections => 0xa406a881 => 53
	i32 2766581644, ; 198: Xamarin.Forms.Core => 0xa4e6af8c => 133
	i32 2772484381, ; 199: Xamarin.AndroidX.Palette.dll => 0xa540c11d => 117
	i32 2778768386, ; 200: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 129
	i32 2788639665, ; 201: Xamarin.Android.Support.LocalBroadcastManager => 0xa63743b1 => 66
	i32 2788775637, ; 202: Xamarin.Android.Support.SwipeRefreshLayout.dll => 0xa63956d5 => 69
	i32 2795602088, ; 203: SkiaSharp.Views.Android.dll => 0xa6a180a8 => 31
	i32 2810250172, ; 204: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 91
	i32 2819470561, ; 205: System.Xml.dll => 0xa80db4e1 => 39
	i32 2842369275, ; 206: FFImageLoading.Forms.Platform.dll => 0xa96b1cfb => 14
	i32 2853208004, ; 207: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 129
	i32 2855708567, ; 208: Xamarin.AndroidX.Transition => 0xaa36a797 => 125
	i32 2861816565, ; 209: Rg.Plugins.Popup.dll => 0xaa93daf5 => 27
	i32 2873222696, ; 210: FFImageLoading => 0xab41e628 => 12
	i32 2876493027, ; 211: Xamarin.Android.Support.SwipeRefreshLayout => 0xab73cce3 => 69
	i32 2893257763, ; 212: Xamarin.Android.Arch.Core.Runtime.dll => 0xac739c23 => 44
	i32 2901442782, ; 213: System.Reflection => 0xacf080de => 152
	i32 2903344695, ; 214: System.ComponentModel.Composition => 0xad0d8637 => 149
	i32 2905242038, ; 215: mscorlib.dll => 0xad2a79b6 => 22
	i32 2912489636, ; 216: SkiaSharp.Views.Android => 0xad9910a4 => 31
	i32 2916838712, ; 217: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 130
	i32 2919462931, ; 218: System.Numerics.Vectors.dll => 0xae037813 => 36
	i32 2921128767, ; 219: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 79
	i32 2921692953, ; 220: Xamarin.Android.Support.CustomView.dll => 0xae257f19 => 59
	i32 2922925221, ; 221: Xamarin.Android.Support.Vector.Drawable.dll => 0xae384ca5 => 74
	i32 2974793899, ; 222: SkiaSharp.Views.Forms.dll => 0xb14fc0ab => 32
	i32 2978675010, ; 223: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 96
	i32 3024354802, ; 224: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 101
	i32 3044182254, ; 225: FormsViewGroup => 0xb57288ee => 17
	i32 3056250942, ; 226: Xamarin.Android.Support.AsyncLayoutInflater.dll => 0xb62ab03e => 52
	i32 3057625584, ; 227: Xamarin.AndroidX.Navigation.Common => 0xb63fa9f0 => 114
	i32 3068715062, ; 228: Xamarin.Android.Arch.Lifecycle.Common => 0xb6e8e036 => 45
	i32 3075834255, ; 229: System.Threading.Tasks => 0xb755818f => 153
	i32 3079937701, ; 230: PanCardView.dll => 0xb7941ea5 => 24
	i32 3108538180, ; 231: PanCardView.Droid => 0xb9488744 => 25
	i32 3111772706, ; 232: System.Runtime.Serialization => 0xb979e222 => 6
	i32 3204380047, ; 233: System.Data.dll => 0xbefef58f => 144
	i32 3204912593, ; 234: Xamarin.Android.Support.AsyncLayoutInflater => 0xbf0715d1 => 52
	i32 3211777861, ; 235: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 95
	i32 3220365878, ; 236: System.Threading => 0xbff2e236 => 157
	i32 3233339011, ; 237: Xamarin.Android.Arch.Lifecycle.LiveData.Core.dll => 0xc0b8d683 => 46
	i32 3243986101, ; 238: CarouselView.FormsPlugin.Droid.dll => 0xc15b4cb5 => 9
	i32 3247949154, ; 239: Mono.Security => 0xc197c562 => 164
	i32 3258312781, ; 240: Xamarin.AndroidX.CardView => 0xc235e84d => 86
	i32 3267021929, ; 241: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 84
	i32 3296380511, ; 242: Xamarin.Android.Support.Collections.dll => 0xc47ac65f => 53
	i32 3299363146, ; 243: System.Text.Encoding => 0xc4a8494a => 159
	i32 3317135071, ; 244: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 94
	i32 3317144872, ; 245: System.Data => 0xc5b79d28 => 144
	i32 3321585405, ; 246: Xamarin.Android.Support.DocumentFile.dll => 0xc5fb5efd => 61
	i32 3322403133, ; 247: Firebase.dll => 0xc607d93d => 16
	i32 3340387945, ; 248: SkiaSharp => 0xc71a4669 => 30
	i32 3340431453, ; 249: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 83
	i32 3346324047, ; 250: Xamarin.AndroidX.Navigation.Runtime => 0xc774da4f => 115
	i32 3352662376, ; 251: Xamarin.Android.Support.CoordinaterLayout => 0xc7d59168 => 55
	i32 3353484488, ; 252: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 100
	i32 3353544232, ; 253: Xamarin.CommunityToolkit.dll => 0xc7e30628 => 131
	i32 3357663996, ; 254: Xamarin.Android.Support.CursorAdapter => 0xc821e2fc => 58
	i32 3362522851, ; 255: Xamarin.AndroidX.Core => 0xc86c06e3 => 92
	i32 3366347497, ; 256: Java.Interop => 0xc8a662e9 => 19
	i32 3369739654, ; 257: Xamarin.AndroidX.Palette => 0xc8da2586 => 117
	i32 3374999561, ; 258: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 120
	i32 3404865022, ; 259: System.ServiceModel.Internals => 0xcaf21dfe => 142
	i32 3407215217, ; 260: Xamarin.CommunityToolkit => 0xcb15fa71 => 131
	i32 3410756605, ; 261: Refractored.XamForms.PullToRefresh => 0xcb4c03fd => 26
	i32 3429136800, ; 262: System.Xml => 0xcc6479a0 => 39
	i32 3430777524, ; 263: netstandard => 0xcc7d82b4 => 143
	i32 3439690031, ; 264: Xamarin.Android.Support.Annotations.dll => 0xcd05812f => 51
	i32 3441283291, ; 265: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 97
	i32 3442068161, ; 266: Sharpnado.MaterialFrame.Android.dll => 0xcd29cac1 => 28
	i32 3476120550, ; 267: Mono.Android => 0xcf3163e6 => 21
	i32 3483112796, ; 268: ImageCircle.Forms.Plugin.dll => 0xcf9c155c => 18
	i32 3486566296, ; 269: System.Transactions => 0xcfd0c798 => 145
	i32 3493954962, ; 270: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 88
	i32 3498942916, ; 271: Xamarin.Android.Support.v7.CardView.dll => 0xd08da1c4 => 72
	i32 3501239056, ; 272: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 84
	i32 3509114376, ; 273: System.Xml.Linq => 0xd128d608 => 40
	i32 3536029504, ; 274: Xamarin.Forms.Platform.Android.dll => 0xd2c38740 => 135
	i32 3547625832, ; 275: Xamarin.Android.Support.SlidingPaneLayout => 0xd3747968 => 68
	i32 3567349600, ; 276: System.ComponentModel.Composition.dll => 0xd4a16f60 => 149
	i32 3596207933, ; 277: LiteDB.dll => 0xd659c73d => 20
	i32 3607250274, ; 278: Com.ViewPagerIndicator.dll => 0xd7024562 => 11
	i32 3608519521, ; 279: System.Linq.dll => 0xd715a361 => 161
	i32 3618140916, ; 280: Xamarin.AndroidX.Preference => 0xd7a872f4 => 118
	i32 3623276856, ; 281: PanCardView.Droid.dll => 0xd7f6d138 => 25
	i32 3627220390, ; 282: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 119
	i32 3629053394, ; 283: Xamarin.AndroidX.MediaRouter.dll => 0xd84ef5d2 => 112
	i32 3629588173, ; 284: LiteDB => 0xd8571ecd => 20
	i32 3632359727, ; 285: Xamarin.Forms.Platform => 0xd881692f => 136
	i32 3633644679, ; 286: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 79
	i32 3641597786, ; 287: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 104
	i32 3658720537, ; 288: CarouselView.FormsPlugin.Abstractions.dll => 0xda13a519 => 8
	i32 3664423555, ; 289: Xamarin.Android.Support.ViewPager.dll => 0xda6aaa83 => 76
	i32 3672681054, ; 290: Mono.Android.dll => 0xdae8aa5e => 21
	i32 3676310014, ; 291: System.Web.Services.dll => 0xdb2009fe => 150
	i32 3678221644, ; 292: Xamarin.Android.Support.v7.AppCompat => 0xdb3d354c => 71
	i32 3681174138, ; 293: Xamarin.Android.Arch.Lifecycle.Common.dll => 0xdb6a427a => 45
	i32 3682565725, ; 294: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 85
	i32 3684561358, ; 295: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 88
	i32 3684933406, ; 296: System.Runtime.InteropServices.WindowsRuntime => 0xdba39f1e => 2
	i32 3689375977, ; 297: System.Drawing.Common => 0xdbe768e9 => 1
	i32 3714038699, ; 298: Xamarin.Android.Support.LocalBroadcastManager.dll => 0xdd5fbbab => 66
	i32 3718463572, ; 299: Xamarin.Android.Support.Animated.Vector.Drawable.dll => 0xdda34054 => 50
	i32 3718780102, ; 300: Xamarin.AndroidX.Annotation => 0xdda814c6 => 78
	i32 3724971120, ; 301: Xamarin.AndroidX.Navigation.Common.dll => 0xde068c70 => 114
	i32 3731644420, ; 302: System.Reactive => 0xde6c6004 => 37
	i32 3756868177, ; 303: Toasts.Forms.Plugin.Abstractions => 0xdfed4251 => 41
	i32 3758932259, ; 304: Xamarin.AndroidX.Legacy.Support.V4 => 0xe00cc123 => 102
	i32 3776062606, ; 305: Xamarin.Android.Support.DrawerLayout.dll => 0xe112248e => 62
	i32 3786282454, ; 306: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 87
	i32 3822602673, ; 307: Xamarin.AndroidX.Media => 0xe3d849b1 => 111
	i32 3829621856, ; 308: System.Numerics.dll => 0xe4436460 => 35
	i32 3832731800, ; 309: Xamarin.Android.Support.CoordinaterLayout.dll => 0xe472d898 => 55
	i32 3862817207, ; 310: Xamarin.Android.Arch.Lifecycle.Runtime.dll => 0xe63de9b7 => 48
	i32 3874897629, ; 311: Xamarin.Android.Arch.Lifecycle.Runtime => 0xe6f63edd => 48
	i32 3883175360, ; 312: Xamarin.Android.Support.v7.AppCompat.dll => 0xe7748dc0 => 71
	i32 3885922214, ; 313: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 125
	i32 3896106733, ; 314: System.Collections.Concurrent.dll => 0xe839deed => 165
	i32 3896760992, ; 315: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 92
	i32 3920810846, ; 316: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 148
	i32 3921031405, ; 317: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 128
	i32 3929156617, ; 318: Com.Android.DeskClock => 0xea322c09 => 10
	i32 3931092270, ; 319: Xamarin.AndroidX.Navigation.UI => 0xea4fb52e => 116
	i32 3945713374, ; 320: System.Data.DataSetExtensions.dll => 0xeb2ecede => 146
	i32 3955647286, ; 321: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 81
	i32 4063435586, ; 322: Xamarin.Android.Support.CustomView => 0xf2331b42 => 59
	i32 4073602200, ; 323: System.Threading.dll => 0xf2ce3c98 => 157
	i32 4105002889, ; 324: Mono.Security.dll => 0xf4ad5f89 => 164
	i32 4125258827, ; 325: CarouselView.FormsPlugin.Droid => 0xf5e2744b => 9
	i32 4151237749, ; 326: System.Core => 0xf76edc75 => 33
	i32 4182413190, ; 327: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 108
	i32 4184283386, ; 328: FFImageLoading.Platform.dll => 0xf96718fa => 15
	i32 4216993138, ; 329: Xamarin.Android.Support.Transition.dll => 0xfb5a3572 => 70
	i32 4219003402, ; 330: Xamarin.Android.Support.v7.CardView => 0xfb78e20a => 72
	i32 4292120959 ; 331: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 108
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [332 x i32] [
	i32 106, i32 140, i32 23, i32 133, i32 75, i32 122, i32 122, i32 43, ; 0..7
	i32 87, i32 54, i32 123, i32 44, i32 85, i32 29, i32 155, i32 101, ; 8..15
	i32 163, i32 112, i32 150, i32 90, i32 105, i32 99, i32 70, i32 77, ; 16..23
	i32 35, i32 103, i32 50, i32 56, i32 16, i32 141, i32 26, i32 89, ; 24..31
	i32 132, i32 151, i32 98, i32 8, i32 22, i32 34, i32 99, i32 24, ; 32..39
	i32 10, i32 110, i32 162, i32 137, i32 7, i32 54, i32 15, i32 67, ; 40..47
	i32 30, i32 145, i32 60, i32 158, i32 73, i32 148, i32 37, i32 94, ; 48..55
	i32 128, i32 82, i32 165, i32 40, i32 51, i32 137, i32 147, i32 64, ; 56..63
	i32 1, i32 119, i32 163, i32 27, i32 67, i32 140, i32 23, i32 103, ; 64..71
	i32 17, i32 47, i32 151, i32 7, i32 121, i32 81, i32 136, i32 107, ; 72..79
	i32 11, i32 49, i32 34, i32 126, i32 115, i32 82, i32 127, i32 58, ; 80..87
	i32 96, i32 46, i32 161, i32 60, i32 154, i32 142, i32 121, i32 4, ; 88..95
	i32 111, i32 91, i32 63, i32 158, i32 138, i32 147, i32 80, i32 0, ; 96..103
	i32 42, i32 14, i32 42, i32 160, i32 5, i32 57, i32 95, i32 43, ; 104..111
	i32 6, i32 109, i32 130, i32 93, i32 3, i32 160, i32 38, i32 124, ; 112..119
	i32 139, i32 74, i32 90, i32 156, i32 155, i32 32, i32 152, i32 86, ; 120..127
	i32 5, i32 123, i32 33, i32 98, i32 13, i32 109, i32 141, i32 139, ; 128..135
	i32 116, i32 13, i32 64, i32 132, i32 73, i32 138, i32 83, i32 4, ; 136..143
	i32 2, i32 49, i32 113, i32 28, i32 107, i32 41, i32 76, i32 65, ; 144..151
	i32 104, i32 38, i32 36, i32 100, i32 134, i32 135, i32 62, i32 57, ; 152..159
	i32 162, i32 75, i32 3, i32 126, i32 29, i32 110, i32 113, i32 102, ; 160..167
	i32 120, i32 78, i32 56, i32 68, i32 12, i32 156, i32 63, i32 134, ; 168..175
	i32 118, i32 65, i32 159, i32 89, i32 18, i32 143, i32 19, i32 61, ; 176..183
	i32 146, i32 106, i32 127, i32 93, i32 97, i32 105, i32 154, i32 47, ; 184..191
	i32 124, i32 153, i32 0, i32 77, i32 80, i32 53, i32 133, i32 117, ; 192..199
	i32 129, i32 66, i32 69, i32 31, i32 91, i32 39, i32 14, i32 129, ; 200..207
	i32 125, i32 27, i32 12, i32 69, i32 44, i32 152, i32 149, i32 22, ; 208..215
	i32 31, i32 130, i32 36, i32 79, i32 59, i32 74, i32 32, i32 96, ; 216..223
	i32 101, i32 17, i32 52, i32 114, i32 45, i32 153, i32 24, i32 25, ; 224..231
	i32 6, i32 144, i32 52, i32 95, i32 157, i32 46, i32 9, i32 164, ; 232..239
	i32 86, i32 84, i32 53, i32 159, i32 94, i32 144, i32 61, i32 16, ; 240..247
	i32 30, i32 83, i32 115, i32 55, i32 100, i32 131, i32 58, i32 92, ; 248..255
	i32 19, i32 117, i32 120, i32 142, i32 131, i32 26, i32 39, i32 143, ; 256..263
	i32 51, i32 97, i32 28, i32 21, i32 18, i32 145, i32 88, i32 72, ; 264..271
	i32 84, i32 40, i32 135, i32 68, i32 149, i32 20, i32 11, i32 161, ; 272..279
	i32 118, i32 25, i32 119, i32 112, i32 20, i32 136, i32 79, i32 104, ; 280..287
	i32 8, i32 76, i32 21, i32 150, i32 71, i32 45, i32 85, i32 88, ; 288..295
	i32 2, i32 1, i32 66, i32 50, i32 78, i32 114, i32 37, i32 41, ; 296..303
	i32 102, i32 62, i32 87, i32 111, i32 35, i32 55, i32 48, i32 48, ; 304..311
	i32 71, i32 125, i32 165, i32 92, i32 148, i32 128, i32 10, i32 116, ; 312..319
	i32 146, i32 81, i32 59, i32 157, i32 164, i32 9, i32 33, i32 108, ; 320..327
	i32 15, i32 70, i32 72, i32 108 ; 328..331
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="none" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "stackrealign" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"NumRegisterParameters", i32 0}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ 45b0e144f73b2c8747d8b5ec8cbd3b55beca67f0"}
!llvm.linker.options = !{}
