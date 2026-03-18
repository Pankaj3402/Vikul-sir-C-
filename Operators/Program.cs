
//types of operators

#region Arthmetic Operators 
/////// Arthmetic Operators Example


//int a = 101, b = 20;

//Console.WriteLine($"a:{a},b:{b}");

///// add
//int add = a + b;
//Console.WriteLine($"addition:{add}");

///// subtract
//int sub = a - b;
//Console.WriteLine($"substraction:{sub}");

///// multiply
//int mul = a * b;
//Console.WriteLine($"multiply:{mul}");


///// divide
//int div = a / b;
//Console.WriteLine($"division:{div}");

///// modulus
//int mod = a % b;
//Console.WriteLine($"remainder:{mod}");

#endregion

#region Unary Operators

/////// Unary Operators Example

//int a = 10;

///// increment

//Console.WriteLine($"a:{a}");  //10

//a++;
//Console.WriteLine($"a:{a}"); // post increment  //11

//++a;
//Console.WriteLine($"a:{a}"); // pre increment  //12


///// decrement


//Console.WriteLine($"a:{a}"); //12

//a--; a=-2;
//Console.WriteLine($"a:{a}"); // post decrement  //11

//--a;
//Console.WriteLine($"a:{a}"); // pre decrement  //10

#endregion

#region assignment Operators

/////// Assignment Operators Example

////assign =
//int a = 10;
//Console.WriteLine($"a:{a}"); //10

////add and assign +=
//a = 10;
//a += 5;  //a = a + 5; //a=10+5 (ans.15)

//Console.WriteLine($"a:{a}");

////subtract and assign -=
//a -= 5;  //a=a-5; //a=15-5 (ans.10)
//Console.WriteLine($"a:{a}");

////multiply and assign *=
//a *= 5; //a=a*5; //a=10*5 (ans.50)
//Console.WriteLine($"a:{a}");

////divide and assign /=
//a /= 5; //a=a/5; //a=50/5 (ans.10)
//Console.WriteLine($"a:{a}");

////modulus and assign %=
//a %= 4; //a=a%4; //a=10%4 (ans.2)
//Console.WriteLine($"a:{a}");

#endregion

#region Relational/ comparison Operators
//// Relational/ comparison Operators Example

////equal to ==
//int a1 = 10;
//bool b1 = a1 == 10;
//Console.WriteLine($"a1==10:{b1}");  // true

//int a2 = 15;
//bool b2 = a2 ==10;
//Console.WriteLine($"a2==10:{b2}");  // false

////not equal to !=
//b1 = a1 != 15;
//Console.WriteLine($"a1!=15:{b1}");  // true

//b2 = a2 != 15;
//Console.WriteLine($"a2!=15:{b2}"); // false

////greater than >
//b1 = a1 > 5;
//Console.WriteLine($"a1>5:{b1}");  // true

//b2 = a2 > 20;
//Console.WriteLine($"a2>20:{b2}"); // false

////less than <
//b1 = a1 < 20;
//Console.WriteLine($"a1<20:{b1}"); // true

//b2 = a2 < 10;
//Console.WriteLine($"a2<10:{b2}"); // false

////greater than or equal to >=
//b1 = a1 >= 10;
//Console.WriteLine($"a1>=10:{b1}"); // true

//b2 = a2 >= 20;
//Console.WriteLine($"a2>=20:{b2}"); // false

////less than or equal to <=
//b1 = a1 <= 15;
//Console.WriteLine($"a1<=15:{b1}"); // true

//b2 = a2 <= 5;
//Console.WriteLine($"a2<=5:{b2}"); // false

#endregion

#region Logical Operators
/////// Logical Operators Example

////logical AND &&
//int a1 = 10, a2 = 20;
//bool b1 = a1 > 7 && a2 < 25;
//Console.WriteLine($"a1>7 && a2<25:{b1}"); // true

//b1 = a1 > 15 && a2 < 10;
//Console.WriteLine($"a1>15 && a2<10:{b1}"); //false

//// OR operators
//b1 = a1 > 15 || a2 < 25;
//Console.WriteLine($"a1>15 || a2 < 25:{b1}"); //true

//b1 = a1 > 15 || a2 < 15;
//Console.WriteLine($"a1>15 || a2 < 15:{b1}"); //false





#endregion
