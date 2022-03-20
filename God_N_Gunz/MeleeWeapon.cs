using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace God_N_Gunz
{
    abstract public class MeleeWeapon:Weapon
    {
       
        public MeleeWeapon():base()
        {
               
        }
        public MeleeWeapon(string weaponName):base(weaponName)
        {
        }
        public abstract void Strike();

    }
}
