

using System.Runtime.CompilerServices;

/*
Console.ReadLine();

var dss =  new[] {1,2,3,4,5,6,7,8,9,10 ,11, 12, 13, 14, 15};

Span<int> s = dss;
var ss1 = dss.Skip(1).Take(3).ToArray();

var ds = s.Slice(1, 3);
*/
var ds = "C# goes b" + "r" * 10;

var k = new ArraySegment<byte>(new byte[10]);
Console.WriteLine(ds);

var arr = new byte[10];
Span<byte> bytes = arr; // Implicit cast from T[] to Span<T>

public static class ExtensionMember
{
    extension(string source)
    {
        public static string operator *(string str, int count)
        {
            return string.Concat(Enumerable.Repeat(str, count)); 
        }
    }
}

/*void DoSmth(ref MyStruct s)
{
    Console.WriteLine(s);
    s.x = 5;
    s.y = 77;
    Console.WriteLine(s);
}*/

/*struct MyStruct
{
    public int x;
    public int y;

    override public string ToString()
    {
        return $"({x} - {y})";
    }
}*/