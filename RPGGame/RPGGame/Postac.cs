using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    abstract class Postac
    {
        protected int _hp;
        protected int _attack;

        public int HP
        {
            get => _hp;
            set
            {
                _hp = value;
            }
        }

        public int Attack
        {
            get => _attack;
            set
            {
                _attack = value;
            }
        }

        public Postac()
        {
            this._hp = 100;
            this._attack = 10;
        }

        public abstract void MakeAttack(Postac p);
        
    }

    class Mag : Postac
    {
        public override void MakeAttack(Postac p)
        {
            p.HP -= (int)(_attack*1.25);
        }

        public void Stan()
        {
            Console.WriteLine("HP: {0}, Atak: {1}", _hp, _attack);
        }
        public Mag()
        {
            this._hp = 70;
            this._attack = 50;
        }
    }


    class Wojownik : Postac
    {
        public override void MakeAttack(Postac p)
        {
            p.HP -= (int)(_attack*1.5);
        }

        public void Stan()
        {
            Console.WriteLine("HP: {0}, Atak: {1}", _hp, _attack);
        }

        public Wojownik()
        {
            this._hp = 150;
            this._attack = 8;
        }
    }
}
