using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore
{
    public class PlayerCharacter
    {
        public int Health { get; private set; } = 100;
        public bool IsDead { get; private set; } = false;

        public string Race { get; set; }

        public void Hit(int damage)
        {
            this.Health -= damage;

            if (this.Health <= 0)
            {
                //dd
                this.IsDead = true;
            }

        }
    }
}
