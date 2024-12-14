using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwIndexators.Classes;

class Enemy
{
    public float health;
    public string type;
    public bool IsLive => health>0; 
}

