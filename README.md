# csharp-compiler
Visual Studio kullanmadan direk projeyi derleyin :)
Kullanım : 

C:\Windows\Microsoft.NET\Framework\v2.0.50727\csc.exe /t:exe /utf8output /R:"system.dll" /R:"system.xml.dll" /R:"system.data.dll" /R:"system.web.dll" /R:"system.windows.forms.dll" /R:"system.drawing.dll" /out:"test.exe" /debug- /optimize+ /optimize  "test.cs"

kod da test.cs olan kısım projenizin olduğu dosya ismidir.<br>
test.cs dosyasının olduğu dizinde test.exe oluşacaktır.<br>
Örnek olarak verdiğim c# kodu google.com.tr a istek yollamaktadır.Sizde kafanıza göre kodlarınızı deneyebilirsiniz.<br>
