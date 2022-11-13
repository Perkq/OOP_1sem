using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    class Events
    {
        public void CheckVoltage(Boss boss, int volt)
        {
            if(boss.Level * 100 < volt && boss.Level * 200 > volt)
            {
                Console.WriteLine("Запуск прошёл успешно");
            } else if(boss.Level * 200 < volt)
            {
                Console.WriteLine("Сгорел на работе");
            } else
            {
                Console.WriteLine("Недостаточно напряжения");
            }
        }
    }
}
