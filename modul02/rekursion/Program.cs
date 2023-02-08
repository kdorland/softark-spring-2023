// Program.cs
Console.WriteLine(Opgaver.Reverse("B"));
Console.WriteLine(Opgaver.Reverse("Banankage"));

class Opgaver {
    public static string Reverse(string s) {
        if (s.Length <= 1) {
            return s;
        } else {
            return Reverse(s.Substring(1)) + s[0];
        }
    }
}


