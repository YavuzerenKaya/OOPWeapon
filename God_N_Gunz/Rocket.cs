using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace God_N_Gunz
{
    class Rocket:Gun,IFireReload
    {
        public Rocket() : base()
        {
                
        }
        public Rocket(string rocketName, int rocketammoCapacity, int ammoInRocket, int rocketAmmocount, int rocketAccuracy, int rocketRange) : base(rocketName, rocketammoCapacity, ammoInRocket, rocketAmmocount, rocketAccuracy, rocketRange)
        {

        }
        public void Fire()
        {
            try
            {
                OutofAmmo();
                switch (outOfAmmo)
                {
                    case true:
                        MessageBox.Show("You dont have any pistol ammo run");
                        break;
                    default:

                        if (ammoInGun == 0)
                        {
                            sound = new SoundPlayer(@"\..\..\..\..\..\God_N_Gunz\Sounds\GunEmpty.wav");
                            sound.Play();
                            MessageBox.Show("need reload!");
                        }
                        else
                        {
                            chanceToHitWithRangedWeapon();
                            sound = new SoundPlayer(@"\..\..\..\..\..\God_N_Gunz\Sounds\rocketexplosion.wav");
                            sound.Play();
                            KilledorInjured();
                        }

                        break;
                }
            }
            catch (UriFormatException)
            {
                MessageBox.Show("UriFormatException");
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("File not found exception");
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Invalid operation exception");
            }


        }

        public void Reload()
        {
            try
            {
                MessageBox.Show("Reloading");
                sound = new SoundPlayer(@"\..\..\..\..\..\God_N_Gunz\Sounds\rocketReload.wav");
                sound.Play();
                ReloadBehaviour();
            }
            catch (UriFormatException)
            {
                MessageBox.Show("UriFormatException");
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("File not found exception");
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Invalid operation exception");
            }
            
        }

        public override int ReloadBehaviour()
        {
            ammoInGun++;
            return ammoInGun;
        }
    }
}
