using System;

public class Question {
    public static string heading = "----------=-=-=-=-=----------";
    public static int Int(string Prompt, bool clearBeforeInput = true) {
        if (clearBeforeInput) { Console.Clear(); }
        Console.WriteLine(heading);
        Console.WriteLine("\n" + Prompt + "\n");
        Console.WriteLine(heading);
        int.TryParse(Console.ReadLine(), out int result);
        return result;
    }

    public static bool Bool(string Prompt, bool clearBeforeInput = true) {
        if (clearBeforeInput) { Console.Clear(); }
        Console.WriteLine(heading);
        Console.WriteLine("\n" + Prompt + "\n");
        Console.WriteLine(heading);
        bool result = false;
        switch(Console.ReadLine()) {
            case "y":
                result = true;
                return result;
        }
        return result;
    }
}