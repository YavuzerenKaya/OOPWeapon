using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace God_N_Gunz
{
    public class Shotgun : Gun, IFireReload
    {
        public Shotgun(string shotgunName, int shotgunammoCapacity, int ammoInShotgun, int shotgunAmmocount, int shotgunAccuracy, int shotgunRange) : base(shotgunName, shotgunammoCapacity, ammoInShotgun, shotgunAmmocount, shotgunAccuracy, shotgunRange)
        {

        }
        public Shotgun():base()
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
                        MessageBox.Show("You dont have any shotgun ammo run");
                        break;
                    default:
                        IsItJammed();
                        if (jam)
                        {
                            JammedGun();
                            Unjam();
                        }
                        else
                        {
                            if (ammoInGun == 0)
                            {
                                sound = new SoundPlayer(@"\..\..\..\..\..\God_N_Gunz\Sounds\GunEmpty.wav");
                                sound.Play();
                                MessageBox.Show("need reload!");
                            }
                            else
                            {
                                chanceToHitWithRangedWeapon();
                                sound = new SoundPlayer(@"\..\..\..\..\..\God_N_Gunz\Sounds\Pompali.wav");
                                sound.Play();
                                KilledorInjured();
                            }
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
                sound = new SoundPlayer(@"\..\..\..\..\..\God_N_Gunz\Sounds\PompaliSarjor.wav");
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
