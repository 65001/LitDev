cd "C:\Program Files (x86)\Microsoft\Small Basic\lib"
del *.pdb
ILMerge /lib:..\ /lib:"C:\Program Files (x86)\Microsoft SDKs\Expression\Blend\.NETFramework\v4.5\Libraries" /xmldocs /ndebug /allowDup /targetplatform:v4,"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.5" /out:LitDev.dll LitDev.dll HelixToolkit.Wpf.dll InTheHand.Net.Personal.dll Ionic.Zip.dll MySql.Data.dll DirectShowLib-2005.dll Svg.dll IWshRuntimeLibrary.dll Interop.Shell32.dll System.Data.SQLite.dll MathNet.Numerics.dll Newtonsoft.Json.dll
del HelixToolkit.Wpf.dll InTheHand.Net.Personal.dll Ionic.Zip.dll MySql.Data.dll DirectShowLib-2005.dll Svg.dll IWshRuntimeLibrary.dll Interop.Shell32.dll System.Data.SQLite.dll SlimDX.dll MathNet.Numerics.dll Newtonsoft.Json.dll *.pdb
pause