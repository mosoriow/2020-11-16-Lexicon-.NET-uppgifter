using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGames
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Axe
    {
        public int DurabilityPoints { get; set; }

        public Axe(int durabilitypoints)
        {
            DurabilityPoints = durabilitypoints;
        }
        public void Attack(Dummy dummy)
        {
            DurabilityPoints--;
            dummy.LoosesHealth();
        }
    }

    public class Dummy
    {
        public int Health { get; set; }
        public Dummy(int health)
        {
            Health = health;
        }
        public void LoosesHealth()
        {
            Health--;
            if (Health <= 0)
            {
                Health = 0;
                throw new Exception("Dummy is dead");
            }
        }
    }

}
