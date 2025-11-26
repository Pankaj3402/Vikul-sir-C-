using System.Text;

string s = " hi";
s += " my";
s += " name";
s += " is";
s += " pankaj";

Console.WriteLine(s);


StringBuilder sb = new StringBuilder("my");
sb.Append(" name");
sb.Append(" is");
sb.Append(" pankaj");

Console.WriteLine(sb.ToString());