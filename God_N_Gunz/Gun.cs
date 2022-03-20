using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace God_N_Gunz
{
    abstract public class Gun:RangedWeapon
    {
        public bool jam;
        public int jamchance;
        int _ammoCapacity { get; set; }
        int _ammoInGun { get; set; }
        public int ammoCapacity { get { return _ammoCapacity; } set { _ammoCapacity = value; } }
        public int ammoInGun { get { return _ammoInGun; } set { _ammoInGun = value; } }
        public Gun():base()
        {

        }
        public Gun(string gunName,int ammoCapacity,int ammoInGun,int ammocount,int accuracy,int range ):base(gunName,ammocount,accuracy,range)
        {
            this.ammoCapacity = ammoCapacity;
            this.ammoInGun = ammoCapacity;
        }
        public abstract int ReloadBehaviour();

        public bool IsItJammed()
        {
            try
            {
                jamchance = ran.Next(0, 100);
                if (jamchance > 95)
                {
                    jam = true;
                }
                else
                {
                    jam = false;
                }
                return jam;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Argument out of range exception");
                return false;
            }
            
        }
        public void JammedGun()
        {
            if (jam)
            {
                MessageBox.Show("Weapon Jammed!!Unjam it");
                Unjam();
            }

        }
        public void Unjam()
        {
            ammoInGun--;
            MessageBox.Show("Gun chamber is clear now");
        }

        
    }
}
