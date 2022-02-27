﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tamagochi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            new Settings();

            game_timer.Interval = 1000 / Settings.speed;
            game_timer.Start();

            init_game();
        }

        private void init_scale(Label lbl_cur, Label lbl_max, Scale scale)
        {
            lbl_cur.Text = scale.current_value.ToString();
            lbl_max.Text = scale.max_value.ToString();
        }

        private void init_game()
        {
            new Settings();
            init_scale(lblEatCur, lblEatMax, Settings.eat);
            init_scale(lblSleepCur, lblSleepMax, Settings.sleep);
            init_scale(lblClearCur, lblClearMax, Settings.clear);
            init_scale(lblHappyCur, lblHappyMax, Settings.happy);
            init_scale(lblHPCur, lblHPMax, Settings.hp);

            lblGameOver.Visible = false;
        }

        private void set_scales()
        {
            lblEatCur.Text = Settings.eat.current_value.ToString();
            lblClearCur.Text = Settings.clear.current_value.ToString();
            lblSleepCur.Text = Settings.sleep.current_value.ToString();
            lblHappyCur.Text = Settings.happy.current_value.ToString();
            lblHPCur.Text = Settings.hp.current_value.ToString();
        }



        public bool is_die()
        {
            int dino_life = (Settings.eat.current_value +
                             Settings.clear.current_value +
                             Settings.happy.current_value +
                             Settings.sleep.current_value) / 4;
            Settings.hp.current_value = dino_life;
            if(Settings.eat.current_value   *
               Settings.clear.current_value *
               Settings.happy.current_value *
               Settings.sleep.current_value == 0)
            {
                Settings.hp.current_value = 0;
                return true;
            }
            return false;
        }

        private void game_over_action()
        {
            dino.Image = Properties.Resources.dead;
            lblHPCur.Text = "0";
            lblGameOver.Visible = true;
            slp.Enabled = false;
            dinoeat.Enabled = false;
            hap.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Settings.eat = Settings.eat.add_value(Settings.add);
            Settings.clear = Settings.clear.dif_value(Settings.sub);
            set_scales();
            Settings.is_game_over = is_die();
        }

        private void slp_Click(object sender, EventArgs e)
        {
            Settings.sleep = Settings.sleep.add_value(Settings.add);
            Settings.eat = Settings.eat.dif_value(Settings.sub);
            set_scales();
            Settings.is_game_over = is_die();
        }

        private void hap_Click(object sender, EventArgs e)
        {
            Settings.happy = Settings.happy.add_value(Settings.add);
            Settings.sleep = Settings.sleep.dif_value(Settings.sub);
            set_scales();
            Settings.is_game_over = is_die();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.clear = Settings.clear.add_value(Settings.add);
            Settings.happy = Settings.happy.dif_value(Settings.sub);
            set_scales();
            Settings.is_game_over = is_die();
        }

        public void generate_action(Random random)
        {
            List<Action> list = new List<Action>() { dec_clear,
                                                     dec_eat,
                                                     dec_happy,
                                                     dec_sleep};
            int index = random.Next(list.Count);
            list[index]();
        }

        public void dec_sleep()
        {
            Settings.sleep.dif_value(Settings.sub);
            set_scales();
            Settings.is_game_over = is_die();
        }

        public void dec_happy()
        {
            Settings.happy.dif_value(Settings.sub);
            set_scales();
            Settings.is_game_over = is_die();
        }

        public void dec_eat()
        {
            Settings.eat.dif_value(Settings.sub);
            set_scales();
            Settings.is_game_over = is_die();
        }

        public void dec_clear()
        {
            Settings.clear.dif_value(Settings.sub);
            set_scales();
            Settings.is_game_over = is_die();
        }

        private void game_timer_Tick(object sender, EventArgs e)
        {
            if (Settings.is_game_over)
            {
                game_over_action();
            }
            else
            {
                Random random = new Random();
                int is_action = random.Next(0, 2);
                if(is_action == 1)
                {
                    generate_action(random);
                }
            }
        }
    }  
}
