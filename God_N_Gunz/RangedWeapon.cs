using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace God_N_Gunz
{
   abstract public class RangedWeapon:Weapon

    {
        public bool outOfAmmo;
        int _ammocount { get; set; }
        int _accuracy { get; set; }
        int _range { get; set; }
        public int ammoCount { get { return _ammocount; } set { _ammocount = value; } }
        public int accuracy { get { return _accuracy; } set { _accuracy = value; } }
        public int range { get { return _range; }set { _range = value; } }

        public RangedWeapon():base()
        {
                
        }
        public RangedWeapon(string RangedWeaponName,int ammoCount,int accuracy,int range):base(RangedWeaponName)
        {
            this.ammoCount = ammoCount;
            this.accuracy = accuracy;
            this.range = range;
        }
        public int chanceToHitWithRangedWeapon()
        {
            try
            {
                hitchance = ran.Next(0, 100);
                hitchance += accuracy - range;
                return hitchance;
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Argument out of exception");
                return 0;
            }
        }
        public void Aim()
        {
            MessageBox.Show("aiming on targets");
        }
        public void stopAim()
        {
            MessageBox.Show("stop aiming");
        }
        public bool OutofAmmo()
        {
            outOfAmmo = false;
            if (ammoCount == 0|| ammoCount<0)
            {
                outOfAmmo = true;
                return outOfAmmo;
            }
            else
            {
                return outOfAmmo;
            }
        }
    }
}
