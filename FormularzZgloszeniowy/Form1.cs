using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularzZgloszeniowy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Error.Visible = false;
            SavedPanel.Location = new Point(840, 0);
            SavedPanel.BackColor = Color.Transparent;
            this.DataPanel.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private bool canGo = true;
        async Task PutTaskDelay()
        {
            await Task.Delay(1);
            canGo = true;
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {

            if (!Validation())
                return;

            SavedPanel.BackColor = Color.LightBlue;


            ResetSecondPanel();

            InputSecondPanel();
            


            for (int i = 0; i <= 70; i++)
            {

                if (canGo)
                {
                    canGo = false;
                    await PutTaskDelay();
                    SavedPanel.Location = new Point(840 - i * 12, 0);
                }
                else
                {
                    i -= 1;
                    continue;
                }
            }

            this.DataPanel.Visible = true;


            for (int i = 0; i <= 86; i++)
            {

                if (canGo)
                {
                    canGo = false;
                    await PutTaskDelay();
                    SavedPanel.Size = new Size(860 - i * 10, SavedPanel.Size.Height);
                }
                else
                {
                    i -= 1;
                    continue;
                }
            }


            SavedPanel.Size = new Size(860, SavedPanel.Size.Height);
            SavedPanel.Location = new Point(840, 0);
            SavedPanel.BackColor = Color.Transparent;


        }

        private async void ReturnButton_Click(object sender, EventArgs e)
        {
            SavedPanel.BackColor = Color.LightBlue;
            ResetFirstPanel();

            for (int i = 0; i <= 70; i++)
            {

                if (canGo)
                {
                    canGo = false;
                    await PutTaskDelay();
                    SavedPanel.Location = new Point(840 - i * 12, 0);
                }
                else
                {
                    i -= 1;
                    continue;
                }
            }
            this.DataPanel.Visible = false;
            for (int i = 0; i <= 86; i++)
            {

                if (canGo)
                {
                    canGo = false;
                    await PutTaskDelay();
                    SavedPanel.Size = new Size(860 - i * 10, SavedPanel.Size.Height);
                }
                else
                {
                    i -= 1;
                    continue;
                }
            }


            SavedPanel.Size = new Size(860, SavedPanel.Size.Height);
            SavedPanel.Location = new Point(840, 0);
            SavedPanel.BackColor = Color.Transparent;


        }



        private bool Validation()
        {
            if (textBox1.Text == "")
            {
                Error.ForeColor = Color.Red;
                Error.Text = "Pole 'IMIE' musi być wypełnione";
                Error.Visible = true;
                return false;
            }
            else if (textBox2.Text == "")
            {
                Error.ForeColor = Color.Red;
                Error.Text = "Pole 'NAZWISKO' musi być wypełnione";
                Error.Visible = true;
                return false;
            }
            else if (comboBox1.SelectedItem == null)
            {
                Error.ForeColor = Color.Red;
                Error.Text = "Pole wyboru 'JAKIEJ PRZEGLĄDARKI UŻYWASZ' musi być wybrane";
                Error.Visible = true;
                return false;
            }
            return true;
        }


        private void ResetFirstPanel()
        {
            textBox1.Clear();
            textBox2.Clear();
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            comboBox1.SelectedItem = null;
            Error.Visible = false;
        }

        private void ResetSecondPanel()
        {
            labelName.Text = "Imię: ";
            labelLastName.Text = "Nazwisko: ";
            labelPlec.Text = "Płeć: ";
            labelBirthday.Text = "Data Urodzin: ";
            labelInterests.Text = "Zainteresowania: ";
            labelWebBrowser.Text = "Przeglądarka: ";
        }

        private void InputSecondPanel()
        {
            this.labelName.Text += this.textBox1.Text;
            this.labelLastName.Text += this.textBox2.Text;
            if (radioButton1.Checked)
                this.labelPlec.Text += this.radioButton1.Text;
            else
                this.labelPlec.Text += this.radioButton2.Text;

            this.labelBirthday.Text += this.dateTimePicker1.Text;

            List<CheckBox> tabela = new List<CheckBox>() { this.checkBox1, this.checkBox2, this.checkBox3, this.checkBox4, this.checkBox5 };

            bool empty = true;

            foreach (CheckBox value in tabela)
            {
                if (value.Checked)
                {
                    this.labelInterests.Text += Environment.NewLine + value.Text;
                    empty = false;
                }
            }

            if (empty)
                this.labelInterests.Text += Environment.NewLine + "Brak";

            this.labelWebBrowser.Text += this.comboBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SavedPanel_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
