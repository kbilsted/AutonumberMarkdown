C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe /P:Configuration=Release
del AutonumberMarkdown.zip
$here = pwd
cd AutonumberMarkdown\bin\Release
& "C:\Program Files\7-Zip\7z.exe" a -bb0 -bd "$here\AutonumberMarkdown.zip" AutonumberMarkdown.exe
cd  $here

