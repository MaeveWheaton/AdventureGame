/*
 * Maeve Wheaton
 * Mr. T
 * May 18, 2021
 * A short choose your adventure game with three storylines and many possible endings,
 * the variable page is used to advance the story after each choice.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace AdventureGame
{
    public partial class Form1 : Form
    {
        //tracked variables
        int page = 1;
        string meleeWeapon, rangeWeapon;
        /*int sword = 1;
        int polearm = 2;        
        int bow = 1;
        int daggers = 2;*/
        bool tunnelMap = false;
        bool spiritWater = false;
        bool littleBoy = false;
        int health = 10;
        int successPercent;
            
        //resources
        SoundPlayer musicPlayer = new SoundPlayer(Properties.Resources.forest_sound_1);
        Random randGen = new Random();

        public Form1()
        {
            InitializeComponent();

            //Start music
            musicPlayer.Play();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //clear button, show info message, show pg 1
            startButton.Visible = false;
            startButton.Enabled = false;            
            storyOutput.Visible = true;
            Refresh();
            Thread.Sleep(5000);

            option1Output.Visible = true;
            option2Output.Visible = true;
            option1Button.Visible = true;
            option2Button.Visible = true;
            healthOutput.Visible = true;

            DisplayPage();            
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                meleeWeapon = "sword";
                page = 2;
            }
            else if (page == 2)
            {
                rangeWeapon = "bow";
                page = 3;
            }
            else if (page == 3) { page = 4; }
            else if (page == 4) { page = 5; }
            else if (page == 5)
            {
                health = health - 2;
                HealthCheck();
                page = 6;
            }
            else if (page == 7)
            {
                health = health - 2;
                HealthCheck();
                tunnelMap = true;
                page = 8;
            }
            else if (page == 8) { page = 10; }
            else if (page == 9) { page = 10; }
            else if (page == 10)
            {
                if (meleeWeapon == "polearm")
                {
                    health = health - 2;
                }
                else
                {
                    health = health - 3;
                }
                HealthCheck();
                page = 12;
            }
            else if (page == 11)
            {
                health = health - 1;
                HealthCheck();
                page = 14;
            }
            else if (page == 14) { page = 22; }
            else if (page == 15) { page = 22; }
            else if (page == 16)
            {
                health = health - 1;
                HealthCheck();
                page = 18;
            }
            else if (page == 17)
            {
                if (meleeWeapon == "polearm")
                {
                    health = health - 2;
                }
                else
                {
                    health = health - 3;
                }
                HealthCheck();
                page = 20;
            }
            else if (page == 22) { page = 23; }
            else if (page == 23) { page = 1; }
            else if (page == 24) { page = 1; }
            else if (page == 25) { page = 26; }
            else if (page == 26) { page = 1; }
            else if (page == 27) { page = 1; }
            else if (page == 98) { page = 1; }

            DisplayPage();
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                meleeWeapon = "polearm";
                page = 2;
            }
            else if (page == 2)
            {
                rangeWeapon = "daggers";
                page = 3;
            }
            else if (page == 3) { page = 28; }
            else if (page == 4) { page = 3; }
            else if (page == 5)
            {
                health = health - 2;
                HealthCheck();
                page = 6;
            }
            else if (page == 7) { page = 9; }
            else if (page == 8) { page = 11; }
            else if (page == 9) { page = 11; }
            else if (page == 10)
            {
                health = health - 1;
                HealthCheck();
                page = 13;
            }
            else if (page == 11)
            {
                if (rangeWeapon == "daggers")
                {
                    health = health - 2;
                }
                else
                {
                    health = health - 3;
                }
                HealthCheck();
                page = 15;
            }
            else if (page == 14) { page = 17; }
            else if (page == 15) { page = 17; }
            else if (page == 16)
            {
                if (rangeWeapon == "daggers")
                {
                    health = health - 2;
                }
                else
                {
                    health = health - 3;
                }
                HealthCheck();
                page = 19;
            }
            else if (page == 17)
            {
                health = health - 1;
                HealthCheck();
                page = 21;
            }
            else if (page == 22)
            {
                successPercent = randGen.Next(1, 101);

                if (successPercent > 30) { page = 24; }
                else { page = 25; }
            }
            else if (page == 23) { page = 99; }
            else if (page == 24) { page = 99; }
            else if (page == 25) { page = 27; }
            else if (page == 26) { page = 99; }
            else if (page == 27) { page = 99; }
            else if (page == 98) { page = 99; }

             DisplayPage();
            }

        private void option3Button_Click(object sender, EventArgs e)
        {
            if (page == 5) { page = 7; }
            else if (page == 22)
            {
                successPercent = randGen.Next(1, 101);

                if (successPercent > 30) { page = 24; }
                else { page = 25; }
            }

            DisplayPage();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (page == 6) { page = 5; }
            else if (page == 12) { page = 16; }
            else if (page == 13) { page = 16; }
            else if (page == 18) { page = 22; }
            else if (page == 19) { page = 22; }
            else if (page == 20) { page = 22; }
            else if (page == 21) { page = 22; }

            nextButton.Visible = false;
            DisplayPage();
        }

        public void DisplayPage()
        {
            switch (page)
            {
                case 1:
                    titleLabel.Text = "Choose Your Adventure";
                    musicPlayer.Stop();
                    musicPlayer = new SoundPlayer(Properties.Resources.forest_sound_1);
                    musicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.polearm;

                    storyOutput.Text = "Congratulations young apprentice, please choose your melee weapon, the weapon you will use in close combat.";
                    option1Output.Text = "Long Sword";
                    option2Output.Text = "Polearm";
                    break;
                case 2:
                    imageOutput.BackgroundImage = Properties.Resources.bow_arrows;

                    storyOutput.Text = "Next, please choose your long range weapon, the weapon you will use for long range attacks.";
                    option1Output.Text = "Bow and Arrows";
                    option2Output.Text = "Throwing Daggers";
                    break;
                case 3:
                    option3Button.Visible = true;
                    option3Output.Visible = true;

                    imageOutput.BackgroundImage = Properties.Resources.main_map;

                    storyOutput.Text = "Now that you have your weapons you are ready to begin your journey for...";
                    option1Output.Text = "Riches";
                    option2Button.Enabled = false; //disable unfinished storylines
                    option3Button.Enabled = false;
                    option2Output.Text = "Glory (coming soon)";
                    option3Output.Text = "Revenge (coming soon)";
                    break;
                case 4:
                    option2Button.Enabled = true; //enable buttons
                    option3Button.Enabled = true;
                    option3Button.Visible = false;
                    option3Output.Visible = false;
                    //musicPlayer.Stop();
                    //musicPlayer = new SoundPlayer(Properties.Resources.forest_sound_1);
                    //musicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.riches_map;

                    storyOutput.Text = "Far to the south there is said to be a cave full of gold and jewels. Would you like to enbark on this quest?";
                    option1Output.Text = "Yes";
                    option2Output.Text = "No";
                    break;
                case 5:
                    titleLabel.Text = "A Quest for Riches";
                    nextButton.Visible = false;
                    option3Button.Visible = true;
                    option3Output.Visible = true;
                    //musicPlayer.Stop();
                    //musicPlayer = new SoundPlayer(Properties.Resources.forest_sound_1);
                    //musicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.mountain_door;

                    storyOutput.Text = "You arrive at the mountain to find a door with strange inscription. Answer the riddle and ye shall enter, it says. People make me, keep me, change me, raise me, even though I can be very dirty. What am I?";
                    option1Output.Text = "Child";
                    option2Output.Text = "Plant";
                    option3Output.Text = "Money";
                    break;
                case 6:
                    option3Button.Visible = false;
                    option3Output.Visible = false;
                    //musicPlayer.Stop();
                    //musicPlayer = new SoundPlayer(Properties.Resources.forest_sound_1);
                    //musicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.mountain_door_2;

                    storyOutput.Text = "Unfortunately, that answer is incorrect. The door glows and you feel a most painful shock go through you. Press Next to try again.";
                    option1Output.Text = "";
                    option2Output.Text = "";

                    healthOutput.Text = $"Health: {health}";

                    nextButton.Visible = true;
                    break;
                case 7:
                    option3Button.Visible = false;
                    option3Output.Visible = false;
                    //musicPlayer.Stop();
                    //musicPlayer = new SoundPlayer(Properties.Resources.forest_sound_1);
                    //musicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.mountain_entrance;

                    storyOutput.Text = "The door glows and the side of the mountain swings open. You step into a large open room with the entrance to a tunnel on the right side.";
                    option1Output.Text = "Look around";
                    option2Output.Text = "Enter the tunnel";
                    break;
                case 8:
                    mapImageOutput.Visible = true;
                    //musicPlayer.Stop();
                    //musicPlayer = new SoundPlayer(Properties.Resources.);
                    //musicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.tunnel_fork;

                    storyOutput.Text = "When searching aroung you trip a trap which realeases a volley of arrows from hidden holes in the walls, most miss you but you are wounded. However, you also find a map of what seems to be the tunnels leading to the treasure. Then you enter the tunnel into the mountain.";
                    option1Output.Text = "Go Right";
                    option2Output.Text = "Go Left";

                    healthOutput.Text = $"Health: {health}";
                    HealthCheck();
                    break;
                case 9:
                    //musicPlayer.Stop();
                    //musicPlayer = new SoundPlayer(Properties.Resources.);
                    //musicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.tunnel_fork;

                    storyOutput.Text = "You enter the tunnel and continue until you reach a fork in the tunnel.";
                    option1Output.Text = "Go Right";
                    option2Output.Text = "Go Left";
                    break;
                case 10:
                    musicPlayer.Stop();
                    musicPlayer = new SoundPlayer(Properties.Resources.slime);
                    musicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.slime_monster;

                    storyOutput.Text = "The right tunnel leads to a room, in the centre is a large green monster. How will you attack?";
                    option1Output.Text = "Melee Weapon";
                    option2Output.Text = "Long Range Weapon";
                    break;
                case 11:
                    //musicPlayer.Stop();
                    //musicPlayer = new SoundPlayer(Properties.Resources.);
                    //musicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.armoured_dwarf;

                    storyOutput.Text = "The left tunnel leads to a room, sitting at the side is an armoured dwarf. How will you attack?";
                    option1Output.Text = "Melee Weapon";
                    option2Output.Text = "Long Range Weapon";
                    break;
                case 12:
                    //musicPlayer.Stop();
                    //musicPlayer = new SoundPlayer(Properties.Resources.);
                    //musicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.slime_monster;

                    storyOutput.Text = $"You rush the monster and pierce it with your {meleeWeapon}. The monster explodes and your arms are covered in a slimy substance which burns your skin. After wiping it off quickly you continue through a tunnel on the other side of the room.";
                    option1Output.Text = "";
                    option2Output.Text = "";

                    healthOutput.Text = $"Health: {health}";
                    HealthCheck();

                    nextButton.Visible = true;
                    break;
                case 13:
                    //musicPlayer.Stop();
                    //musicPlayer = new SoundPlayer(Properties.Resources.);
                    //musicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.slime_monster;

                    storyOutput.Text = "You attack the monster from a distance and when it explodes most of the slimy substance in the explosion misses you, leaving you with only some minor burns as you continue through a tunnel on the other side of the room.";
                    option1Output.Text = "";
                    option2Output.Text = "";

                    healthOutput.Text = $"Health: {health}";
                    HealthCheck();

                    nextButton.Visible = true;
                    break;
                case 14:
                    //musicPlayer.Stop();
                    //musicPlayer = new SoundPlayer(Properties.Resources.);
                    //musicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.armoured_dwarf;

                    storyOutput.Text = $"You sprint to the dwarf, drawing your {meleeWeapon}, and attack. The dwarf swings ax at you but only manages to clip you before you land a killing blow. Then you continue through the tunnel on the other side of the room to another fork.";
                    option1Output.Text = "Go Left";
                    option2Output.Text = "Continue Straight";

                    healthOutput.Text = $"Health: {health}";
                    HealthCheck();
                    break;
                case 15:
                    //musicPlayer.Stop();
                    //musicPlayer = new SoundPlayer(Properties.Resources.);
                    //musicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.armoured_dwarf;

                    storyOutput.Text = $"You attack the dwarf with your {rangeWeapon}, but the dwarf's armor protects it from most of your attacks. It is able to attack you with it's ax before dying, leaving you injured but alive as you continue through the tunnel on the other side of the room to another fork.";
                    option1Output.Text = "Go Left";
                    option2Output.Text = "Continue Straight";
                    break;
                case 16:
                    nextButton.Visible = false;
                    //musicPlayer.Stop();
                    //musicPlayer = new SoundPlayer(Properties.Resources.);
                    //musicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.armoured_dwarf;

                    storyOutput.Text = "The tunnel leads to a room, sitting at the side is an armoured dwarf. How will you attack?";
                    option1Output.Text = "Melee Weapon";
                    option2Output.Text = "Long Range Weapon";
                    break;
                case 17:
                    musicPlayer.Stop();
                    musicPlayer = new SoundPlayer(Properties.Resources.slime);
                    musicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.slime_monster;

                    storyOutput.Text = "The tunnel leads to a room, in the centre is a large green monster. How will you attack?";
                    option1Output.Text = "Melee Weapon";
                    option2Output.Text = "Long Range Weapon";
                    break;
                case 18:
                    break;
                case 19:
                    break;
                case 20:
                    break;
                case 21:
                    break;
                case 22:
                    break;
                case 23:
                    break;
                case 24:
                    break;
                case 25:
                    break;
                case 26:
                    break;
                case 27:
                    break;
                case 28:
                    break;
                default:
                    break;
            }
        }                

        public void HealthCheck()
        {
            if (health == 0)
            {
                page = 98;
            }
        }
    }
}
