using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;


namespace God_N_Gunz
{
    abstract public class Weapon
    {
        public SoundPlayer sound;
        public Random ran = new Random();
        public int hitchance;
        string _weaponName { get; set; }
        public string weaponName { get { return _weaponName; } set { _weaponName = value; } }
        public Weapon()
        {
                
        }
        public Weapon(string weaponName)
        {
            this.weaponName = weaponName;
        }

        public void KilledorInjured()
        {
            try
            {
                int chanceToDie = ran.Next(1, 100);
                if (chanceToDie <= 75)
                {
                    System.Windows.Forms.MessageBox.Show("Target Injured");
                    sound = new SoundPlayer(@"..\..\..\God_N_Gunz\Sounds\scream.wav");
                    sound.Play();

                }
                else
                {

                    System.Windows.Forms.MessageBox.Show("Target Killed");
                    sound = new SoundPlayer(@"..\..\..\God_N_Gunz\Sounds\wilhelmscream.wav");
                    sound.Play();
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
        
    }
}
