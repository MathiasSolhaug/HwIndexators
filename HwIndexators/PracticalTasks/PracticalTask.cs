using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwIndexators.PracticalTasks;

public class QuestLog
{
    //Dictionary<>
    public List<Quest> Quests = new List<Quest>();
    public Quest currentQuest;

    public Quest this[string title]
    {
        get
        {
            foreach (Quest item in Quests)
            {
                if (item.Title == title) return item;
            }
            return null;
        }
        set
        {
            foreach (Quest item in Quests)
            {
                if(item.Title == title) currentQuest = item;
            }
        }
    }
    public class Quest
    {
        public string Title;
        public string Description;
        public bool IsCompleted;
    }
    public void AddQuest(string title)
    {
        Quest item = new Quest();
        item.Title = title;
        Quests.Add(item);
    }
    

}

