// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;
namespace AdventOfCode {
public class DayOne {
    public List<int>[] readFile() {
        List<int> list1 = new List<int>();
        List<int> list2 = new List<int>();
        String line;
        try
        {
            StreamReader sr = new StreamReader(@"/Users/will/AdventOfCode/dotnet/input.txt");
            //Read the first line of text
            line = sr.ReadLine();
            //Continue to read until you reach end of file
            while (line != null)
            {
                string[] lineSplit = line.Split(' ');
                list1.Add(int.Parse(lineSplit[0]));
                list2.Add(int.Parse(lineSplit[3]));
                //Read the next line
                line = sr.ReadLine();
            }
            //close the file
            sr.Close();
        }
        catch(Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }
        return [list1, list2];
    }
    public int partOne() { 
    
    var lists = readFile();
    var list1 = lists[0];
    list1.Sort();
    var list2 = lists[1];
    list2.Sort();

    var sum = 0;
    for (int i = 0; i < list1.Count; i++){
        if(list1[i] >= list2[i]){
            sum += list1[i] - list2[i];
        } else {
            sum += list2[i] - list1[i];
        }
    }
        Console.WriteLine(sum);

        return sum;
    }
    public int partTwo() {
        var lists = readFile();
        var list1 = lists[0];
        list1.Sort();
        var list2 = lists[1];
        list2.Sort();

        var total = 0;
        for (int i = 0; i < list1.Count; i++){
            var count = 0;
            for (int j = 0; j < list2.Count; j++){
                if(list1[i] == list2[j]) {
                    count++;
                }
            }
            total += list1[i] * count;
        }
            Console.WriteLine(total);
            return total;
        }
    }
}