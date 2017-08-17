Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.IO
Imports System.IO.Compression
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Windows.Forms
Imports System.Xml
Imports Microsoft.VisualBasic

Namespace CodeEvaler
	Public NotInheritable Class Program
		Private Sub New()
		End Sub
		Public Shared Sub Main()
			Dim ce As New CodeEvaler()
			ce.Eval()
		End Sub
	End Class

	Public Class CodeEvaler
		Public Sub Eval()
			MakeRequests()
		End Sub
Private Sub MakeRequests()
	Dim response As HttpWebResponse

	If deneme(response) Then
		response.Close()
	End If
End Sub

Private Function deneme(ByRef response As HttpWebResponse) As Boolean
	response = Nothing

	Try
		Dim request As HttpWebRequest = DirectCast(WebRequest.Create("http://www.google.com.tr/"), HttpWebRequest)

		request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; rv:54.0) Gecko/20100101 Firefox/54.0"
		request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8"
		request.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.5")
		request.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate")
		request.Referer = "https://www.google.com.tr/"
		request.Headers.Set(HttpRequestHeader.Cookie, "_cb_ls=1; myhd=anon|||; uniqid=15029953473599; ltm=noys|all; _ga=GA1.2.1284157329.1502995345; _gid=GA1.2.813776711.1502995346; favCitiesTmpNew=default#{""url"":""/asya/turkiye/istanbul"",""icon"":""04"",""highTemp"":""31"",""lowTemp"":""22"",""city"":""%u0130stanbul""}; __gfp_64b=dO.cr1CgnZ2681fuWLDckfECNOj3v04iEne46GNgoRX.17; _ym_uid=15029953471067968973; _ym_isad=2; scs=%7B%22t%22%3A1%7D; inLanding=http%3A%2F%2Fwww.mynet.com%2F; __gads=ID=63304b4a4cf0414e:T=1502995349:S=ALNI_MZioRy1qqgp26k6xr1Jmc1cua5jXg; ins-gaSSId=da728c4c-037e-b121-fab1-803ee57c385b_1502998948; spUID=15029953478693d112c9055.471042b8; insdrSV=2; _cb=etgijDH4Gg-DPjWZu; _chartbeat2=.1502995349316.1502995469531.1.BYh-EfClnBq-nR4r5lIq0HDifAAn; _cb_svref=https%3A%2F%2Fwww.google.com.tr%2F")
		request.Headers.Add("Upgrade-Insecure-Requests", "1")

		response = DirectCast(request.GetResponse(), HttpWebResponse)
	Catch e As WebException
		If e.Status = WebExceptionStatus.ProtocolError Then
			response = DirectCast(e.Response, HttpWebResponse)
		Else
			Return False
		End If
	Catch e As Exception
		If response IsNot Nothing Then
			response.Close()
		End If
		Return False
	End Try

	Return True
End Function 

	End Class
End Namespace
