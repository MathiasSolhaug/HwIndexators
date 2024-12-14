/* 1.
 * public class Sample
{
    private int[] data = new int[10];

   
    public int this[int index]
    {
        get
        {
            return data[index];
        }
        set
        {
            data[index] = value;
        }
    }
}
*/
/* 2 
 * Static nelzya ispolzovatj vmeste s indexami
 * 
 * public class Sample
{
    public static int this[int index]
    {
        get
        {
            // 
        }
        set
        {
            // 
        }
    }
}
*/

/*3
 * public class Sample
{
    private Dictionary<string, string> data = new Dictionary<string, string>();

    public string this[string key]
    {
        get
        {
            return data[key];
        }
        set
        {
            data.Add(key, value);
        }
    }
}
*/
/* 4.
 * 
public class Sample
{
    public int this[int index1, int index2]
    {
        get
        {
            return index1 + index2;
        }
        set
        {
            // Некоторый код
        }
    }

    public int this[int index1, int index2]
    {
        get
        {
            return index1 * index2;
        }
        set
        {
            // Некоторый код
        }
    }
}
*/
/* 5. 
 * 
 * public class Sample
{
    public int this[int index]
    {
        get
        {
            return index;
        }
        private set
        {
            // Некоторый код
        }
    }
}

Sample s = new Sample();
s[0] = 10;

 */

/*class MyCollection
{
    this[int]
}*/

/*using HwIndexators.Classes;
using System.Linq.Expressions;

Game game = new Game() { age = 10};
game.BirthYear = 2010;
//Console.WriteLine(game.BirthYear);
//Console.WriteLine(game[0].health);
game[5] = new Enemy();
//Console.WriteLine(game[5].health);
List<Enemy> myenemies = game[true, "top"];
foreach (Enemy enemy in myenemies)
{
    Console.WriteLine(enemy.health);
}*/

using HwIndexators.EasyTasks;
using HwIndexators.PracticalTasks;

MyCollection myCollection = new MyCollection();
myCollection[0] = 42;
Console.WriteLine(myCollection[0]);

QuestLog questLog = new QuestLog();

questLog.AddQuest("StartQuest");
questLog.AddQuest("ExploreQuest");
Console.WriteLine(questLog["ExploreQuestt"]);
