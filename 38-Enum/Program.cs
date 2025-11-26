//student s1 = new student()
//{
//    rollnumber = 1,
//    name = "pankaj",
//    gender = 1
//};
//Console.WriteLine($"s1=> roll number : {s1.rollnumber} name : {s1.name} gender : {s1.gender}");


//student s2 = new student()
//{
//    rollnumber = 1,
//    name = "pankaj",
//    gender = gender.male
//};

//Console.WriteLine($"s2=> rollnumber = {s2.rollnumber} name = {s2.name} gender = {s2.gender}");



//enum class


//get underlying type of enum

//Type gender = Enum.GetUnderlyingType(typeof(gender));
//Console.WriteLine($"Enum underlying type : {gender.Name}");
//Console.WriteLine();


////get all names from enum type

//string[] names = Enum.GetNames(typeof(gender));
//foreach (string name in names)
//{
//    Console.WriteLine($"{name}");
//}
//Console.WriteLine();


////get all values

//Array values = Enum.GetValues(typeof(gender));
//foreach ( int value in  values)
//{
//    Console.WriteLine($"{value}");
//}
//Console.WriteLine();


//subjects s = subjects.english;
//Console.WriteLine($"subject name : {s}");


static string GetGender (int gender)
{
    switch(gender)
    {
        case 1:
            return "male";
        case 2:
            return "female";
        default:
            return "invalid gender";
    }
}




Console.Read();