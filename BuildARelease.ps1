& "c:\Program Files (x86)\Microsoft Visual Studio\2017\Community\MSBuild\15.0\Bin\MSBuild.exe" /P:Configuration=Release
del AutonumberMarkdown.zip
$here = pwd
cd AutonumberMarkdown\bin\Release
& "C:\Program Files\7-Zip\7z.exe" a -bb0 -bd "$here\AutonumberMarkdown.zip" AutonumberMarkdown.exe
cd  $here

