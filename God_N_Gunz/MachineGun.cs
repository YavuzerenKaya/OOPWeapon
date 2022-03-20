using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace God_N_Gunz
{
    class MachineGun:Gun,IFireReload
    {
        public MachineGun():base()
        {

        }
        public MachineGun(string machineGunName, int machineGunammoCapacity, int ammoInMachineGun, int machineGunAmmocount, int machineGunAccuracy, int machineGunRange) : base(machineGunName, machineGunammoCapacity, ammoInMachineGun, machineGunAmmocount, machineGunAccuracy, machineGunRange)
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
                        MessageBox.Show("You dont have any machineGun ammo run");
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
                                int machineGunSound = ran.Next(1, 2);
                                chanceToHitWithRangedWeapon();
                                switch (machineGunSound)
                                {
                                    case 1:
                                        sound = new SoundPlayer(@"\..\..\..\..\..\God_N_Gunz\Sounds\Taramali.wav");
                                        sound.Play();
                                        break;
                                    case 2:
                                        sound = new SoundPlayer(@"\..\..\..\..\..\God_N_Gunz\Sounds\Taramali1.wav");
                                        sound.Play();
                                        break;
                                    default:
                                        sound = new SoundPlayer(@"\..\..\..\..\..\God_N_Gunz\Sounds\Taramali2.wav");
                                        sound.Play();
                                        break;
                                }
                                KilledorInjured();
                            }
                        }
                        break;
                }
            }
            catch(UriFormatException)
            {
                MessageBox.Show("Uri format exception");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Argument out of range exception");
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
                sound = new SoundPlayer(@"\..\..\..\..\..\God_N_Gunz\Sounds\reload.wav");
                sound.Play();
                ReloadBehaviour();

            }
            catch(UriFormatException)
            {
                MessageBox.Show("Uri Format Exception");
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
            ammoInGun = ammoCapacity;
            return ammoInGun;
        }
    }
}
