using System;
using System.IO;

class FileWriter
{
    public static void Main()
    {
        string filePath = @"/Users/mille/SkillFactory/module_7/7.1.10_task/7.1.10_task/Program.cs";

        using (StreamReader sr = File.OpenText(filePath))
        {
            string str = "";
            while((str = sr.ReadLine()) != null)
                Console.WriteLine(str);
        }
       

    }
}
