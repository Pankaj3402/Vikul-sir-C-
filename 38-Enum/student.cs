#region using integral constants
////male = 1
////female = 2
//public class student
   
//{
//    public int rollnumber {  get; set; }
//    public string name { get; set; }
//    public int gender { get; set; }
//}


#endregion using integral constants

#region using enum

//male = 1
//female = 2

public class student
{
    public int rollnumber {  get; set; }
    public string name { get; set; }
    public gender gender { get; set; }
}

public enum gender
{
    male,female = 3, unknown
}

public enum subjects
{
    marathi, hindi , english ,maths , science
}
#endregion using enum