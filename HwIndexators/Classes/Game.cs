using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace HwIndexators.Classes;

class Game
{
    public int age;
    public List<Enemy> enemies = new List<Enemy> { };

    public Game()
    {
        GenerateEnemies();
    }

    public int BirthYear {  
        
        get=> 2024-age;
        set
        {
            age = 2024 - value;
        }
    }
    public void GenerateEnemies()
    {
        enemies.Add(new Enemy() { health = 100, type = "normal"});
        enemies.Add(new Enemy() { health = 200, type = "normal" });
        enemies.Add(new Enemy() { health = 300, type = "top" });
        enemies.Add(new Enemy() { health = 400, type = "normal" });
        enemies.Add(new Enemy() { health = 500, type = "top" });


    }
    public Enemy this[int index]
    {
        get => enemies[index];
        set
        {
            if (enemies.Count - 1 < index)
            {
                enemies.Add(value);
                return;
            }
            enemies[index] = value;
        }
    }
    public List<Enemy> this[bool isAlive, string type]
    {
        get
        {
            List<Enemy> enemyList = new List<Enemy> { };
            foreach (Enemy enemy in enemies)
            {
                if (enemy.type == type && enemy.IsLive == isAlive) enemyList.Add(enemy);
                
            }
            return enemyList;
            
        }
    }
}



