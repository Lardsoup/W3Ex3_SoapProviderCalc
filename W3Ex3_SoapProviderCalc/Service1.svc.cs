using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace W3Ex3_SoapProviderCalc
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
	// NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
	public class Service1 : IService1
	{
		public string GetData(int value)
		{
			return string.Format("You entered: {0}", value);
		}

		public double Add(double ValueA, double ValueB)
		{
			return ValueA + ValueB;
		}

		public double Subtract(double ValueA, double ValueB)
		{
			return ValueA - ValueB;
		}

		public double Multiply(double ValueA, double ValueB)
		{
			return ValueA * ValueB;
		}

		public double Divide(double ValueA, double ValueB)
		{
			return ValueA / ValueB;
		}

		public double DoAll(double ValueA, double ValueB, out double Sub, out double Multi, out double Div)
		{
			double a  = Add(ValueA, ValueB);
			Sub = Subtract(ValueA, ValueB);
			Multi = Multiply(ValueA, ValueB);
			Div = Divide(ValueA, ValueB);
			return a;
		}

		//public CompositeType GetDataUsingDataContract(CompositeType composite)
		//{
		//	if (composite == null)
		//	{
		//		throw new ArgumentNullException("composite");
		//	}
		//	if (composite.BoolValue)
		//	{
		//		composite.StringValue += "Suffix";
		//	}
		//	return composite;
		//}
	}
}
