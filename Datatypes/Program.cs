
/// Datatypes in C#


#region integral types

/////integral types

////byte

//byte v1 = 10;
//Console.WriteLine($"byte:val:{v1} min value:{byte.MinValue}max value:{byte.MaxValue}" + $"size:{sizeof(byte)}bytes");


////short

//short v2 = 10;
//Console.WriteLine($"short:val:{v2} min value:{short.MinValue}max value:{short.MaxValue}" + $"size:{sizeof(short)}bytes");


//// int

//int v3 = 1000;
//Console.WriteLine($"int:val:{v3} min value:{int.MinValue}max value:{int.MaxValue}" + $"size:{sizeof(int)}bytes");


//// long

//long v4 = 77092944;
//Console.WriteLine($"long:val:{v4} min value:{long.MinValue}max value:{long.MaxValue}" + $"size:{sizeof(long)}bytes");

#endregion


#region floating types

///// floating types

//// float

//float v5 = 10.5f;
//Console.WriteLine($"float:val:{v5}min value:{float.MinValue}max value:{float.MaxValue}" + $"size:{sizeof(float)}bytes");


//// double

//double v6 = 10.5555;
//Console.WriteLine($"double:val:{v6}min value:{double.MinValue}max value:{double.MaxValue}" + $"size:{sizeof(double)}bytes");


//// decimal

//decimal v7 = 102152.15m;
//Console.WriteLine($"decimal:val:{v7}min value:{decimal.MinValue}max value:{decimal.MaxValue}" + $"size:{sizeof(decimal)}bytes");

#endregion

#region boolen type

///// boolen type

//bool status = true;
//Console.WriteLine($"bool:value:{status} size:{sizeof(bool)}bytes");

//bool status1 = false;
//Console.WriteLine($"bool:val:{status1} size:{sizeof(bool)}bytes");

#endregion

#region char and string types

///// string types

//// char
//char currency = '$';
//Console.WriteLine($"char:value:{currency} size:{sizeof(char)}bytes");

//// string
//string name = "Vikul sir";
//Console.WriteLine($"string:value:{name}");

#endregion

#region string function

///// string function
//string name = "vishal";
//Console.WriteLine(name.Length); // Length property

//Console.WriteLine(name.ToUpper()); // ToUpper() method

//Console.WriteLine(name.ToLower()); // ToLower() method

//string name1  = "   Pankaj";
//Console.WriteLine(name1.Trim());  //trim() method to remove leading and trailing spaces

#endregion

#region escape sequence

//string name = "\"pankaj\"";  //using backslash to escape quotes
//Console.WriteLine(name);

//string name1 = "'pankaj'";  //using single quotes
//Console.WriteLine(name1);

//string name2 = "pankaj\nmore";  //using \n for new line
//Console.WriteLine(name2);

//string name3 = "pankaj\tmore";  //using \t for tab space
//Console.WriteLine(name3);

//string name4 = "pankaj\\more";  //using \\ for backslash
//Console.WriteLine(name4);

//string name5 = @"pankaj\\\more";  //using @ for verbatim string literal
//Console.WriteLine(name5);


#endregion

#region string concatenation

//string FirstName = "pankaj";
//string LastName = "more";
//string fullname = FirstName + " " + LastName;   // Concatenation using '+' operator
//Console.WriteLine(fullname);

//fullname = FirstName + "\t   " + LastName;   // Using tab character for spacing
//Console.WriteLine(fullname);

//string middlename = "machindra";
//fullname = string.Concat(FirstName, " ", middlename, " ", LastName);  // Concat method to combine strings
//Console.WriteLine(fullname);

#endregion

    #region string formatting


    ///// placeholder syntax

    //fullname = string.Format("fullname:{0} {1} {2}", FirstName, middlename, LastName);  //placeholder syntax 
    //Console.WriteLine(fullname);

    ///// interpolated string syntax

    //fullname = $"full name : {FirstName} {middlename} {LastName}";
    //Console.WriteLine(fullname);

    #endregion

#region indexof() method

////indexof() method to find the index of 'm' character

//string email = "pankaj342002@gmail.com";
//int index = email.IndexOf('m');
//Console.WriteLine($"index of m:{index}");

//// Substring method to extract username

//string username = email.Substring(0, 10);
//Console.WriteLine($"username:{username}");

#endregion

#region substring() method

//// Substring method to extract domain name
//string domain = email.Substring(index + 1, email.Length - index - 1);
//Console.WriteLine($"domain:{domain}");

#endregion

