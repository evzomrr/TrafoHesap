using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trafoHesap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool hareket;
        int  mouse_x;
        int  mouse_y;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            hareket = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            hareket = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (hareket)
            {
                this.SetDesktopLocation(MousePosition.X-mouse_x,MousePosition.Y-mouse_y);
            }
        }
        const float C = 1.02f;
        double a = 0, b = 0, nuveGucu = 0, Sn=0;
        double Vp = 0, Vs = 0, Ip = 0, Is = 0;

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != 59)
            {
                e.Handled = true;
                MessageBox.Show("Lütfen ondalıklı sayıyı gösterimde ',' (virgül) kulanın.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != 59)
            {
                e.Handled = true;
                MessageBox.Show("Lütfen ondalıklı sayıyı gösterimde ',' (virgül) kulanın.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != 59)
            {
                e.Handled = true;
                MessageBox.Show("Lütfen ondalıklı sayıyı gösterimde ',' (virgül) kulanın.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != 59)
            {
                e.Handled = true;
                MessageBox.Show("Lütfen ondalıklı sayıyı gösterimde ',' (virgül) kulanın.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != 59)
            {
                e.Handled = true;
                MessageBox.Show("Lütfen Transformator sacının belirli B magnetik akı yoğunluğu değerini giriniz.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != 59)
            {
                e.Handled = true;
                MessageBox.Show("Lütfen ondalıklı sayıyı gösterimde ',' (virgül) kulanın.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != 59)
            {
                e.Handled = true;
                MessageBox.Show("Lütfen ondalıklı sayıyı gösterimde ',' (virgül) kulanın.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != 59)
            {
                e.Handled = true;
                MessageBox.Show("Lütfen ondalıklı sayıyı gösterimde ',' (virgül) kulanın.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCRmjQpz_yWW0nx1G1A4d7TA");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label19.Text = DateTime.Now.ToString();
        }

        double B = 0, J = 0;
        double Np = 0, Ns = 0, dp = 0, ds = 0;
        double SeconderPower = 0;
        double F = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                a = Convert.ToDouble(textBox1.Text);    
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen cm cinsinden ' , ' (virgül) ile ayrılmış pozitif tam sayı giriniz", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
           {
                b = Convert.ToDouble(textBox2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen cm cinsinden ' , ' (virgül) ile ayrılmış pozitif tam sayı giriniz", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
           {
                Vp = Convert.ToDouble(textBox9.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Volt cinsinden ' , ' (virgül) ile ayrılmış pozitif tam sayı giriniz", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                Vs = Convert.ToDouble(textBox10.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Volt cinsinden ' , ' (virgül) ile ayrılmış pozitif tam sayı giriniz", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
           {
                Is = Convert.ToDouble(textBox12.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Amper cinsinden ' , ' (virgül) ile ayrılmış pozitif tam sayı giriniz", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
          {
                B = Convert.ToDouble(textBox13.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Gauss cinsinden 7000 ile 18000 arasında sayı giriniz", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
           {
                J = Convert.ToDouble(textBox14.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen A/mm2 cinsinden ' , ' (virgül) ile ayrılmış 1,8 ile 2,5 arasında sayı giriniz", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
           {
                F = Convert.ToDouble(textBox15.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Hz cinsinden frekans  giriniz", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            nuveGucu = (Math.Pow((a * b), 2)) / C;
         Sn = a * b;
         Np = (Vp*100000000) / (4.44*B*Sn*F);
         Ns = (Vs*100000000) / (4.44*B*Sn*F);
         Ip = (Ns / Np) * Is;
         dp = Math.Sqrt((4 * (Ip / J)) / Math.PI);
         ds = Math.Sqrt((4 * (Is / J)) / Math.PI);
         SeconderPower = (Vs * Is)-((Vs * Is)*0.02);

            textBox3.Clear();
            textBox3.Text = Convert.ToString(nuveGucu);

            textBox11.Clear();
            textBox11.Text = Convert.ToString(Ip);

            textBox4.Clear();
            textBox4.Text = Convert.ToString(Math.Round(Np));

            textBox5.Clear();
            textBox5.Text = Convert.ToString(Math.Round(Ns));

            textBox6.Clear();
            textBox6.Text = Convert.ToString(dp);

            textBox7.Clear();
            textBox7.Text = Convert.ToString(ds);

            textBox8.Clear();
            textBox8.Text = Convert.ToString(SeconderPower);

            if (SeconderPower > nuveGucu)
               {
                MessageBox.Show("Istenen çıkış gücü için nüve gücü yetersiz.! Lütfen daha büyük kesitli nüve kullanın.", "Dikkat !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               }



        }
    }
}
