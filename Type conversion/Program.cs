
// types of conversions

#region Implicit conversions

using System.Runtime.Intrinsics;

///// Types of conversions
//short v1 = 20;  // short
//Console.WriteLine($"short v1:{v1}");

//int v2 = v1;  //short to int
//Console.WriteLine($"int v2:{v2}");

//long v3 = v2;  //int to long
//Console.WriteLine($"long v3:{v3}");

//float v4 = v3;  //long to float
//Console.WriteLine($"float v4:{v4}");


#endregion

#region Explicit Conversion

//// Type Cast Operator //

//v4 = 15.5f;  //float to int
//int v5 =(int) v4;
//Console.WriteLine($"int v5:{v5}");

//decimal v11 = 12.555m;

//int v12 = (int)v11;
//Console.WriteLine($"int v12:{v12}");


//decimal v14 = 12.555m;

//long v13 = (long)v14;
//Console.WriteLine($"int v13:{v13}");


//// Convert Class Method //

string v6 = "100";
////int v7 = v6; //string to int is not converting automatically 
//int v7 = Convert.ToInt32(v6);  //convert manually
//Console.WriteLine($"int v7:{v7}");

v6 = "true";
bool v8 = Convert.ToBoolean(v6);   //string to bool
Console.WriteLine($"bool v8:{v8}");


//// Using Parse() Method //

//v6 = "120";

//int v9 = int.Parse(v6);  //string to int  // by Parse() Method
//Console.WriteLine($"int v9:{v9}");

//int v10 = Convert.ToInt32(v9);       // by Convert class method
//Console.WriteLine($"int v10:{v10}");


//// Using TryParse() Method  //

//string s = "asdfgh";
////int i = Convert.ToInt32(s);
////int i = int.Parse(s);

//int i;
//bool b = int.TryParse(s, out i);
//Console.WriteLine($"is conversion success:{b} int i:{i}");
//Console.ReadLine();

//s = "500";
//b = int.TryParse(s, out i);
//Console.WriteLine($"is conversion success:{b} int i:{i}");

#endregion



