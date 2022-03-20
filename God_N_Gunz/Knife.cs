using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace God_N_Gunz
{
   public class Knife:MeleeWeapon
    {
        int knifeSharpness;

        public Knife()
        {
            knifeSharpness = ran.Next(50, 100);
        }
        public Knife(string knifeName):base(knifeName)
        {
            knifeSharpness = ran.Next(50, 100);

        }
        public override void Strike()
        {
            try
            {
                int attackTypechance = ran.Next(0, 1);
                hitchance = ran.Next(0, 2);
                switch (hitchance)
                {
                    case (1):
                        if (knifeSharpness > 30)
                        {
                            switch (attackTypechance)
                            {
                                case 1:
                                    StabAttack();
                                    KilledorInjured();
                                    break;
                                default:
                                    CutAttack();
                                    KilledorInjured();
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Your knife become dull. Find a whetstone to make it sharp again!");
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
        
        public void StabAttack()
        {
            try
            {
                MessageBox.Show("Stab Attack!");
                sound = new SoundPlayer(@"\..\..\..\..\..\God_N_Gunz\Sounds\StabKnife.wav");
                sound.Play();

            }
            catch(UriFormatException)
            {
                MessageBox.Show("Uri format excecption");
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
        public void CutAttack()
        {
            try
            {
                MessageBox.Show("Cut Attack!");
                sound = new SoundPlayer(@"\..\..\..\..\..\God_N_Gunz\Sounds\swordSlash.wav");
                sound.Play();

            }
            catch(UriFormatException)
            {
                MessageBox.Show("Uri format exception");
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


        public int GetWhetStone()
        {
            knifeSharpness = 100;
            return knifeSharpness;
        }
    }
}
