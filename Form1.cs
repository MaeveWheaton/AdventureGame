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
        int meleeWeapon, rangeWeapon;
        int sword = 1;
        int polearm = 2;        
        int bow = 1;
        int daggers = 2;
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
                meleeWeapon = sword;
                page = 2;
            }
            else if (page == 2)
            {
                rangeWeapon = bow;
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
                if (meleeWeapon == polearm)
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
                if (meleeWeapon == polearm)
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
                meleeWeapon = polearm;
                page = 2;
            }
            else if (page == 2)
            {
                rangeWeapon = daggers;
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
                if (rangeWeapon == daggers)
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
                if (rangeWeapon == daggers)
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
                    musicPlayer.Stop();
                    musicPlayer = new SoundPlayer(Properties.Resources.forest_sound_1);
                    musicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.polearm;

                    storyOutput.Text = "Congratulations young apprentice, please choose your melee weapon, the weapon you will use in close combat.";
                    option1Output.Text = "Long Sword";
                    option2Output.Text = "Polearm";
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    musicPlayer.Stop();
                    musicPlayer = new SoundPlayer(Properties.Resources.forest_sound_1);
                    musicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.polearm;

                    storyOutput.Text = "Unfortunately, that answer is incorrect. The door glows and you feel a most painful shock go through you. Press Next to try again.";
                    option1Output.Text = "";
                    option2Output.Text = "";
                    healthOutput.Text = $"Health = {health}";

                    nextButton.Visible = true;
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
