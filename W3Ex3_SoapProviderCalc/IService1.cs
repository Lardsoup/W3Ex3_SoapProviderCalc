using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace W3Ex3_SoapProviderCalc
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
	[ServiceContract]
	public interface IService1
	{

		[OperationContract]
		string GetData(int value);

		[OperationContract]
		double Add(double ValueA, double ValueB);

		[OperationContract]
		double Subtract(double ValueA, double ValueB);

		[OperationContract]
		double Multiply(double ValueA, double ValueB);

		[OperationContract]
		double Divide(double ValueA, double ValueB);

		[OperationContract]
		double DoAll(double ValueA, double ValueB, out double Sub, out double Multi, out double Div);

		//[OperationContract]
		//CompositeType GetDataUsingDataContract(CompositeType composite);
	}


	//Use a data contract as illustrated in the sample below to add composite types to service operations.

 //  [DataContract]
	//public class CompositeType
	//{
	//	bool boolValue = true;
	//	string stringValue = "Hello ";

	//	[DataMember]
	//	public bool BoolValue
	//	{
	//		get { return boolValue; }
	//		set { boolValue = value; }
	//	}

	//	[DataMember]
	//	public string StringValue
	//	{
	//		get { return stringValue; }
	//		set { stringValue = value; }
	//	}
	//}
}
