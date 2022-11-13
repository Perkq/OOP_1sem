using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    public class Boss
    {

        public delegate void Upgrade(string level);
        public delegate void TurnOn(Boss boss, int voltage);


        public event Upgrade upgrade;
        public event TurnOn turnOn;
            


        private int level;

        public int Level
        {
            get { return level; }
            
            set
            {
                level = value;
            }
        }

        public Boss(int level)
        {
            this.level = level;
        }

        public void GetLevel()
        {
            level++;
            if(upgrade != null)
            {
                upgrade?.Invoke("Уровень босса повышен!");
            }
        }

        public void GiveVoltage(int voltage)
        {
            if(turnOn != null)
            {
                turnOn?.Invoke(this, voltage);
            }
        }

    }
}
