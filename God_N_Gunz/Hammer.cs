using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace God_N_Gunz
{
   public class Hammer:MeleeWeapon
    {
        int hammerCondition;
        public Hammer()
        {
            hammerCondition = ran.Next(50, 100);
        }
        public Hammer(string hammerName):base(hammerName)
        {

        }

        public override void Strike()
        {
            try
            {
                hitchance = ran.Next(0, 1);
                switch (hitchance)
                {
                    case 1:
                        if (hammerCondition > 20)
                        {
                            crushAttack();
                            KilledorInjured();
                        }
                        else
                        {
                            MessageBox.Show("Your Hammer broke due to low condition. Run away!");
                        }
                        break;
                    default:
                        MessageBox.Show("Missed!!");
                        break;
                }
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Argument out of range exception");
            }
            
        }
        public void crushAttack()
        {
            try
            {
                MessageBox.Show("crush attack!");
                sound = new SoundPlayer(@"..\..\..\God_N_Gunz\Sounds\hammer.wav");
                sound.Play();

            }
            catch(UriFormatException)
            {
                MessageBox.Show("UriFormatException");
            }
            catch(System.IO.FileNotFoundException)
            {
                MessageBox.Show("File not found exception");
            }
            catch(InvalidOperationException)
            {
                MessageBox.Show("Invalid operation exception");
            }
        }
    }
}
