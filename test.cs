using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Forms;
using System.Xml;

namespace CodeEvaler {
	public static class Program {
		public static void Main() {
			(new CodeEvaler()).Eval();
		}
	}

	public class CodeEvaler {
		public void Eval() {
			MakeRequests();
		}
private void MakeRequests()
{
	HttpWebResponse response;

	if (deneme(out response))
	{
		response.Close();
	}
}

private bool deneme(out HttpWebResponse response)
{
	response = null;

	try
	{
		HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.google.com.tr");

		request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; rv:54.0) Gecko/20100101 Firefox/54.0";
		request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
		request.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.5");
		request.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate");
		request.Referer = "https://www.google.com.tr/";
		request.Headers.Set(HttpRequestHeader.Cookie, @"_cb_ls=1; myhd=anon|||; uniqid=15029953473599; ltm=noys|all; _ga=GA1.2.1284157329.1502995345; _gid=GA1.2.813776711.1502995346; favCitiesTmpNew=default#{""url"":""/asya/turkiye/istanbul"",""icon"":""04"",""highTemp"":""31"",""lowTemp"":""22"",""city"":""%u0130stanbul""}; __gfp_64b=dO.cr1CgnZ2681fuWLDckfECNOj3v04iEne46GNgoRX.17; _ym_uid=15029953471067968973; _ym_isad=2; scs=%7B%22t%22%3A1%7D; inLanding=http%3A%2F%2Fwww.mynet.com%2F; __gads=ID=63304b4a4cf0414e:T=1502995349:S=ALNI_MZioRy1qqgp26k6xr1Jmc1cua5jXg; ins-gaSSId=da728c4c-037e-b121-fab1-803ee57c385b_1502998948; spUID=15029953478693d112c9055.471042b8; insdrSV=2; _cb=etgijDH4Gg-DPjWZu; _chartbeat2=.1502995349316.1502995469531.1.BYh-EfClnBq-nR4r5lIq0HDifAAn; _cb_svref=https%3A%2F%2Fwww.google.com.tr%2F");
		request.KeepAlive = true;
		request.Headers.Add("Upgrade-Insecure-Requests", @"1");

		response = (HttpWebResponse)request.GetResponse();
	}
	catch (WebException e)
	{
		if (e.Status == WebExceptionStatus.ProtocolError) response = (HttpWebResponse)e.Response;
		else return false;
	}
	catch (Exception)
	{
		if(response != null) response.Close();
		return false;
	}

	return true;
} 

	}
}