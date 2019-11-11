using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace AdventureGame
{/// <summary>
/// Anika Sindwani and Kira Waldron
/// November 2019
/// Robber adventure game
/// </summary>
    public partial class Form1 : Form
    {
        // tracks what part of the game the user is at
        int scene = 0;

        // random number generator
        Random randGen = new Random();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.M)
            {
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 4; }
                else if (scene == 2) { scene = 4; }
                else if (scene == 3) { scene = 4; }
                else if (scene == 4) { scene = 5; }
                else if (scene == 5) { scene = 99;}
                else if (scene == 6) { scene = 12;}
                else if (scene == 7) { scene = 9; }
                else if (scene == 8) { scene = 11;}
                else if (scene == 9) { scene = 12;}
                else if (scene == 11) { scene = 12;}
                else if (scene == 13) { scene = 15;}
                else if (scene == 15) { scene = 99;}
                else if (scene == 16) { scene = 21;}

                else if (scene == 12)
                {
                    int randValue = randGen.Next(1, 101);

                    if (randValue < 50) { scene = 20; }
                    { scene = 18; }
                }

                else if (scene == 18) { scene = 99; }
                else if (scene == 20) { scene = 21;}
                else if (scene == 21) { scene = 99;}
                else if (scene == 22) { scene = 24;}
                else if (scene == 24) { scene = 28;}
                else if (scene == 25) { scene = 26;}
                else if (scene == 26) { scene = 99;}
                else if (scene == 27) { scene = 28;}
                else if (scene == 28) { scene = 98;}
                else if (scene == 99) { scene = 0; }
                else if (scene == 98) { scene = 0; }
            }
            else if (e.KeyCode == Keys.B)
            {
                if (scene == 0) { scene = 3; }
                else if (scene == 1) { scene = 7; }
                else if (scene == 2) { scene = 7; }
                else if (scene == 3) { scene = 7; }
                else if (scene == 7) { scene = 8; }
                else if (scene == 8) { scene = 10; }
                else if (scene == 10) { scene = 99; }
                else if (scene == 4) { scene = 6; }
                else if (scene == 6) { scene = 13; }
                else if (scene == 9) { scene = 13; }
                else if (scene == 11) { scene = 13; }
                else if (scene == 13) { scene = 16; }
                else if (scene == 16) { scene = 23; }
                else if (scene == 23) { scene = 99; }
                else if (scene == 12) { scene = 14; }
                else if (scene == 14) { scene = 99; }
                else if (scene == 20) { scene = 23; }
                else if (scene == 23) { scene = 99; }
                else if (scene == 24) { scene = 29; }
                else if (scene == 22) { scene = 25; }
                else if (scene == 25) { scene = 27; }
                else if (scene == 27) { scene = 29; }
                else if (scene == 29) { scene = 99; }
                if (scene == 98)
                {
                    this.Close();
                }
                if (scene == 99)
                {
                    this.Close();
                }
            }
            else if (e.KeyCode == Keys.Space)
            {
                if (scene == 0) { scene = 2; }
                else if (scene == 20) { scene = 22; }
                else if (scene == 16) { scene = 22; }

            }

            switch (scene)
            {
                case 0:

                    outputLabel.Text = "You're planning to rob a bank, Pick a player.";
                    redLabel.Text = "Squaidward Tentacles";
                    blueLabel.Text = "Patrick Star";
                    greenLabel.Text = "Sponegbob Squarepants";
                    sceneImage.BackgroundImage = Properties.Resources.bankImage;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    break;
                case 1:

                    outputLabel.Text = "You picked Squidward Tentacles. It's midnight, you approach your local bank when you see car lights." +
                        " Do you run to a tree or duck behind a nearby car?";
                    redLabel.Text = "Run to a Tree";
                    blueLabel.Text = "Duck behind a nearby car";
                    greenLabel.Text = "";
                    pictureBox3.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources.squidwardTentacles;
                    SoundPlayer carSound1 = new SoundPlayer(Properties.Resources.carLights);
                    carSound1.Play();

                    break;
                case 2:

                    outputLabel.Text = "You picked Spongebob Squarepants. It's midnight, you approach your local bank when you see car lights." +
                        " Do you run to a tree or duck behind a nearby car?";
                    redLabel.Text = "Run to a Tree";
                    blueLabel.Text = "Duck behind a nearby car";
                    greenLabel.Text = "";
                    pictureBox3.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources.spongebobSquarepants;
                    SoundPlayer nightSounds = new SoundPlayer(Properties.Resources.nightTime);
                    nightSounds.Play();
                    break;
                case 3:

                    outputLabel.Text = "You picked Patrick Star. It's midnight, you approach your local bank when you see car lights." +
                        " Do you run to a tree or duck behind a nearby car?";
                    redLabel.Text = "Run to a Tree";
                    blueLabel.Text = "Duck behind a nearby car";
                    greenLabel.Text = "";
                    pictureBox3.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources.patrickStar;
                    SoundPlayer nightCrickets = new SoundPlayer(Properties.Resources.nightCrickets);
                    nightCrickets.Play();

                    break;
                case 4:

                    outputLabel.Text = "You are running towards the tree when you bump into the police officer on the sidewalk. " +
                        "He asks why you are in such a hurry. Do you say 'just going on a jog' or 'I left the stove on!'?";
                    redLabel.Text = "I left the stove on";
                    blueLabel.Text = "Just going on a jog";
                    greenLabel.Text = "";
                    pictureBox3.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources.policeOfficer; 
                    break;
                case 5:

                    outputLabel.Text = "You say I left the stove on. He doesn't believe you and he starts to question you. ";
                    Refresh();
                    Thread.Sleep(3000);
                    outputLabel.Text = "Your crack under pressure and get arrested.";
                    redLabel.Text = "Press the red button to continue";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources.bigX;
                    SoundPlayer endSound = new SoundPlayer(Properties.Resources.endSound);
                    endSound.Play();
                    break;
                case 6:

                    outputLabel.Text = "You say 'Just going on a jog', he believes you, as he turns around you run back to the bank. " +
                        "You see a vent on the side of the building and decide to climb in, you pop it open and see 2 paths. " +
                        "Do you go right or left? ";
                    redLabel.Text = "right";
                    blueLabel.Text = "left";
                    greenLabel.Text = "";
                    pictureBox3.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources.bankVent;
                    break;
                case 7:

                    outputLabel.Text = "The car alarm of the car you ducked behind goes off. Do you run from the car or " +
                        "hide in a bush beside you? ";
                    redLabel.Text = "Run from the car";
                    blueLabel.Text = "Hide in the bush beside you";
                    greenLabel.Text = "";
                    pictureBox3.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources.greenCar;
                    SoundPlayer carAlarm = new SoundPlayer(Properties.Resources.carAlarm);
                    carAlarm.Play();
                    break;
                case 8:

                    outputLabel.Text = "You hide in the bush beside you, and you hear a rustling noise! Do you turn around or " +
                        "run into the road? ";
                    redLabel.Text = "Run";
                    blueLabel.Text = "Turn around";
                    greenLabel.Text = "";
                    pictureBox3.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources.bushPlant;
                    break;
                case 9:

                    outputLabel.Text = "You run away from the alarm You see the car lights pass by and run back to the bank. " +
                        "You see a vent on the side of the building and decide to climb in, you pop it open and see 2 paths. " +
                        "Do you go right or left? ";
                    redLabel.Text = "Right";
                    blueLabel.Text = "Left";
                    greenLabel.Text = "";
                    pictureBox3.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources.bankVent;
                    break;
                case 10:

                    outputLabel.Text = "When you turn around you prick your arm on the bush!";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = "The bush is poisonous";


                    redLabel.Text = "Press the red button to continue";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources.bigX;
                    SoundPlayer endSound2 = new SoundPlayer(Properties.Resources.endSound);
                    endSound2.Play();

                    break;
                case 11:

                    outputLabel.Text = "You run into the road and make it across the sidewalk. You arrive to the bank." +
                        " You see a vent on the side of the building and decide to climb in, you pop it open and see 2 paths. " +
                        "Do you go right or left? ";
                    redLabel.Text = "Right";
                    blueLabel.Text = "Left";
                    greenLabel.Text = "";
                    pictureBox3.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources.bankVent;
                    break;
                case 12:

                    outputLabel.Text = "You go right and run into a fan, Do you turn back or attempt to stop the fan?  ";
                    redLabel.Text = "attempt to stop the fan";
                    blueLabel.Text = "Turn back";
                    greenLabel.Text = "";
                    pictureBox3.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources.ventFan;
                    break;
                case 13:

                    outputLabel.Text = "You go left and exit through another vent, Do you go right or left? ";
                    redLabel.Text = "Right";
                    blueLabel.Text = "Left";
                    greenLabel.Text = "";
                    pictureBox3.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources.bankVent;
                    break;
                case 14:

                    outputLabel.Text = "You turn back but the way back is blocked off. ";
                    Refresh();
                    Thread.Sleep(3000);
                    outputLabel.Text = "You die of suffocation. ";


                    redLabel.Text = "Press the red button to continue";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources.bigX;
                    SoundPlayer endSound3 = new SoundPlayer(Properties.Resources.endSound);
                    endSound3.Play();
                    break;
                case 15:

                    outputLabel.Text = "You go right and you hear a loud noise. The noise stops.";
                    SoundPlayer ventNoise = new SoundPlayer(Properties.Resources.ventNoise);
                    ventNoise.Play();
                    Refresh();
                    Thread.Sleep(3000);
                    outputLabel.Text = "you fall through the ceiling and set off the alarms.";
                    redLabel.Text = "Press the red button to continue";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources.bigX;
                    SoundPlayer endSound6 = new SoundPlayer(Properties.Resources.endSound);
                    endSound6.Play();
                    break;
                case 16:

                    outputLabel.Text = "You go left and see a room through the air vents. " +
                        "You drop down and see a vault but it's password protected. You need to guess the passcode. Do you guess 1234, " +
                        "password or qwerty? ";
                    redLabel.Text = "1234";
                    blueLabel.Text = "qwerty";
                    greenLabel.Text = "password";
                    pictureBox3.Visible = true;
                    sceneImage.BackgroundImage = Properties.Resources.passcodeLock;
                    break;
                case 18:

                    outputLabel.Text = "You attempt to stop the fan. ";
                    Refresh();
                    Thread.Sleep(3000);
                    outputLabel.Text = "You get electricuted. ";
                    redLabel.Text = "Press the red button to continue";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    pictureBox3.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources.bigX;
                    SoundPlayer endSound5 = new SoundPlayer(Properties.Resources.endSound);
                    endSound5.Play();
                    break;
                case 19:

                    outputLabel.Text = "You go left and exit through another vent, Do you go right or left? ";
                    redLabel.Text = "Right";
                    blueLabel.Text = "Left";
                    greenLabel.Text = "";
                    pictureBox3.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources.bankVent;
                    break;
                case 20:

                    outputLabel.Text = "You get through the fan and see a room through the air vents. You drop in the room. You see a vault, " +
                        "but it's password protected. You need to guess the passcode. Do you guess 1234, " +
                        "password or qwerty?";
                    redLabel.Text = "1234";
                    blueLabel.Text = "qwerty";
                    greenLabel.Text = "password";
                    sceneImage.BackgroundImage = Properties.Resources.passcodeLock;
                    break;
                case 21:

                    outputLabel.Text = "You guess 1234 and a security guard walks in.";
                    Refresh();
                    Thread.Sleep(3000);
                    outputLabel.Text = "You got caught and go to jail.";
                    redLabel.Text = "Press the red button to continue";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources.bigX;
                    SoundPlayer endSound7 = new SoundPlayer(Properties.Resources.endSound);
                    endSound7.Play();
                    break;
                case 22:

                    outputLabel.Text = "You guess 'password' and it works. You get in the vault and start putting money into bags! " +
                        "You grab all the money you can. You need to get out of there! You see a staircase. Do you go back in the vent" +
                        " or go up the staircase?  ";
                    redLabel.Text = "Go up the staircase";
                    blueLabel.Text = "Go back ";
                    greenLabel.Text = "";
                    pictureBox3.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources.bankMoney;
                    break;
                case 23:

                    outputLabel.Text = "You guess 'qwerty' and an alarm goes off. A police officer walks in and arrests you";
                    Refresh();
                    Thread.Sleep(3000);
                    outputLabel.Text = "You got caught and go to jail.";
                    redLabel.Text = "Press the red button to continue";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources.bigX;
                    SoundPlayer endSound8 = new SoundPlayer(Properties.Resources.endSound);
                    endSound8.Play();
                    break;
                case 24:

                    outputLabel.Text = "You go up the staircase to reveal the beautiful city lights when something catches your eye. A ladder! " +
                        "You climb down and get on the ground when you hear an alarm go off. You see blinding red and blue lights approach the bank. " +
                        "You need to run. Do you run towards the forest or towards the sidewalk. ";
                    redLabel.Text = "Run towards the sidewalk";
                    blueLabel.Text = "Run towards the forest";
                    greenLabel.Text = "";
                    pictureBox3.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources.citySkyline;
                    SoundPlayer bankAlarm = new SoundPlayer(Properties.Resources.bankAlarm);
                    bankAlarm.Play();
                    break;
                case 25:

                    outputLabel.Text = "You attempt to go back up the vent. You get up in the vent when you hear a crack. " +
                        "You fall through the vent to reveal several security guards. Do you attempt to beat them up or jump out of a window? ";
                    redLabel.Text = "Jump out a window";
                    blueLabel.Text = "Attempt to beat them up";
                    greenLabel.Text = "";
                    pictureBox3.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources.securityGuards;
                    break;
                case 26:

                    outputLabel.Text = "You attempt to jump out then window but you are grabbed by your hoodie " +
                        "and pulled back in by the security guards.";
                    Refresh();
                    Thread.Sleep(3000);
                    sceneImage.BackgroundImage = Properties.Resources.bankWindow;
                    outputLabel.Text = "You got caught and go to jail.";
                    redLabel.Text = "Press the red button to continue";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources.bigX;
                    SoundPlayer endSound9 = new SoundPlayer(Properties.Resources.endSound);
                    endSound9.Play();
                    break;
                case 27:

                    outputLabel.Text = "You beat up the guards and jump out the open window. " +
                        "You make it out and you see blinding red and blue lights approach the bank. You need to run. Do you run " +
                        "towards the forest or towards the sidewalk.";
                    redLabel.Text = "Run towards the sidewalk";
                    blueLabel.Text = "Run towards the forest";
                    greenLabel.Text = "";
                    pictureBox3.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources.policeLights;
                    break;
                case 28:

                    outputLabel.Text = "You run towards the sidewalk and make it across you run back to your house.";
                    Refresh();
                    Thread.Sleep(3000);
                    sceneImage.BackgroundImage = Properties.Resources.bankWindow;
                    outputLabel.Text = "You successfully robbed the bank!  ";
                    redLabel.Text = "Press the red button to continue";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources.winImage;
                    SoundPlayer winSound = new SoundPlayer(Properties.Resources.youWin);
                    winSound.Play();
                    break;
                case 29:

                    outputLabel.Text = "You run towards the forest and step on tree branches." +
                        " The police hear you stepping on the braches.";
                    Refresh();
                    Thread.Sleep(3000);
                    sceneImage.BackgroundImage = Properties.Resources.bankWindow;
                    outputLabel.Text = "You get caught and go to jail.";
                    redLabel.Text = "Press the red button to continue";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources.bigX;
                    SoundPlayer endSound10 = new SoundPlayer(Properties.Resources.endSound);
                    endSound10.Play();
                    break;
                case 99:
                    sceneImage.BackgroundImage = Properties.Resources.bigX;
                    outputLabel.Text = "You lose, would you like to play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    pictureBox2.Visible = true;

                    break;
                case 98:
                    sceneImage.BackgroundImage = Properties.Resources.winImage;
                    outputLabel.Text = "You Win, would you like to play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    pictureBox2.Visible = true;
                    break;
            }
        }

    }
}

