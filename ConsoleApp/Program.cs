using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
	class Program
	{
		private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		static void Main(string[] args)
		{
			try
			{
				WebServiceReference.WebServiceSoapClient obj = new WebServiceReference.WebServiceSoapClient();

				log.Info("Appel du web service Fibonacci(10)");

				int fibonacci = obj.Fibonacci(10);
				Console.WriteLine("FIBONACCI (10) : " + fibonacci);

				log.Info("Appel du web service XmlToJson() de l'exemple 1");

				string json1 = obj.XmlToJson("<foo>bar</foo>");
				Console.WriteLine("XmlToJson exemple 1: \n" + json1);

				log.Info("Appel du web service XmlToJson() de l'exemple 2");

				string json2 = obj.XmlToJson("<foo>hello</bar>");
				Console.WriteLine("XmlToJson exemple 2: \n" + json2);

				log.Info("Appel du web service XmlToJson() de l'exemple 3");

				string json3 = obj.XmlToJson("<TRANS><HPAY><ID>103</ID><STATUS>3</STATUS><EXTRA><IS3DS>0</IS3DS><AUTH>031183</AUTH></EXTRA><INT_MSG/><MLABEL>501767XXXXXX6700</MLABEL><MTOKEN>project01</MTOKEN></HPAY></TRANS>");
				Console.WriteLine("XmlToJson exemple 3: \n" + json3);

			}
			catch (Exception e)
			{
				Console.WriteLine("Une erreur est survenue");
				log.Error(e.Message);
			}

			Console.Read();
		}
	}
}
