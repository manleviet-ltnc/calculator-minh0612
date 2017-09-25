using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //phân tích thành hai số: số thứ 1 và số thứ 2.
        string chuoidau="0", chuoihai="0", s;
        //dấu phép tính có 4 phép tính.
        int dau = 0;
        //dấu chấm thập phân ở cả hai số, ktdấu dùng cho nút +/- và các nút phép tính để nhận dạng trường hợp.
        int ktcham1 = 0, ktcham2 = 0, ktdau = 0;
        //kết quả của phép tính, chuyendau dùng cho nút +/- để chứa dữ liệu tạm thời.
        double so1, so2, chuyendau, kq;
        private void Backspace_Click(object sender, EventArgs e)
        {
            s = Result.Text;
            if (Result.Text != "")
            {
                Result.Text = s.Substring(0, s.Length - 1);
                Result.SelectionStart = s.Length;
                if (dau == 0)
                {
                    chuoidau = Result.Text;
                    chuoidau.Substring(0, chuoidau.Length - 1);
                    Result.SelectionStart = chuoidau.Length;
                    chuoidau = Result.Text;    
                }
                else
                {
                    chuoihai = Result.Text;
                    chuoihai.Substring(0, chuoihai.Length - 1);
                    Result.SelectionStart = chuoihai.Length;
                    chuoihai = Result.Text;
                }
            }        
        }

        private void CE_Click(object sender, EventArgs e)
        {
            Result.Text = "0.";
            chuoidau = chuoihai ="";
            dau = ktcham1 = ktcham2 = ktdau = 0;
            so1 = so2 = chuyendau = 0;
        }

        private void Nut1_Click(object sender, EventArgs e)
        {
            if (dau == 0)
            {
                Result.Text = chuoidau + "1";
                chuoidau = chuoidau + "1";
            }
            else
            {
                Result.Text = chuoihai + "1";
                chuoihai = chuoihai + "1";
            }
        }

        private void Nut2_Click(object sender, EventArgs e)
        {
            if (dau == 0)
            {
                Result.Text = chuoidau + "2";
                chuoidau = chuoidau + "2";
            }
            else
            {
                Result.Text = chuoihai + "2";
                chuoihai = chuoihai + "2";
            }
        }

        private void Nut3_Click(object sender, EventArgs e)
        {
            if (dau == 0)
            {
                Result.Text = chuoidau + "3";
                chuoidau = chuoidau + "3";
            }
            else
            {
                Result.Text = chuoihai + "3";
                chuoihai = chuoihai + "3";
            }
        }

        private void Nut4_Click(object sender, EventArgs e)
        {
            if (dau == 0)
            {
                Result.Text = chuoidau + "4";
                chuoidau = chuoidau + "4";
            }
            else
            {
                Result.Text = chuoihai + "4";
                chuoihai = chuoihai + "4";
            }
        }

        private void Nut5_Click(object sender, EventArgs e)
        {
            if (dau == 0)
            {
                Result.Text = chuoidau + "5";
                chuoidau = chuoidau + "5";
            }
            else
            {
                Result.Text = chuoihai + "5";
                chuoihai = chuoihai + "5";
            }
        }

        private void Nut6_Click(object sender, EventArgs e)
        {
            if (dau == 0)
            {
                Result.Text = chuoidau + "6";
                chuoidau = chuoidau + "6";
            }
            else
            {
                Result.Text = chuoihai + "6";
                chuoihai = chuoihai + "6";
            }
        }

        private void Nut7_Click(object sender, EventArgs e)
        {
            if (dau == 0)
            {
                Result.Text = chuoidau + "7";
                chuoidau = chuoidau + "7";
            }
            else
            {
                Result.Text = chuoihai + "7";
                chuoihai = chuoihai + "7";
            }
        }

        private void Nut8_Click(object sender, EventArgs e)
        {
            if (dau == 0)
            {
                Result.Text = chuoidau + "8";
                chuoidau = chuoidau + "8";
            }
            else
            {
                Result.Text = chuoihai + "8";
                chuoihai = chuoihai + "8";
            }
        }

        private void Nut9_Click(object sender, EventArgs e)
        {
            if (dau == 0)
            {
                Result.Text = chuoidau + "9";
                chuoidau = chuoidau + "9";
            }
            else
            {
                Result.Text = chuoihai + "9";
                chuoihai = chuoihai + "9";
            }
        }

        private void Nut0_Click(object sender, EventArgs e)
        {
            if (dau == 0)
            {
                Result.Text = chuoidau + "0";
                chuoidau = chuoidau + "0";
            }
            else
            {
                Result.Text = chuoihai + "0";
                chuoihai = chuoihai + "0";
            }
        }

        private void Nutcham_Click(object sender, EventArgs e)
        {
            if (dau == 0 && ktcham1 == 0)
            {
                Result.Text = chuoidau + ".";
                chuoidau = chuoidau + ".";
                ktcham1 = 1;
            }
            else
            {
                Result.Text = chuoihai + ".";
                chuoihai = chuoihai + ".";
                ktcham2 = 1;
            }
        }
        
        private void Daubang_Click(object sender, EventArgs e)
        {
            hamDaubang();
        }

        private void hamDaubang()
        {
            if (dau == 1)
                if (chuoihai == "")
                    goto kt;
                else
                    cong();
            else if (dau == 2)
                if (chuoihai == "")
                    goto kt;
                else
                    tru();
            else if (dau == 3)
                if (chuoihai == "")
                    goto kt;
                else
                    nhan();
            else if (dau == 4)
                if (chuoihai == "")
                    goto kt;
                else
                    chia();
            else
                Result.Text = "";
            Result.Text = kq.ToString();
            chuoidau = kq.ToString();
            ktdau = 1;
        kt: ;
        }

        private void cong()
        {
            so1 = double.Parse(chuoidau);
            so2 = double.Parse(chuoihai);
            kq = so1 + so2;
        }

        private void tru()
        {
            so1 = double.Parse(chuoidau);
            so2 = double.Parse(chuoihai);
            kq = so1 - so2;
        }

        private void nhan()
        {
            so1 = double.Parse(chuoidau);
            so2 = double.Parse(chuoihai);
            kq = so1 * so2;
        }

        private void chia()
        {
            so1 = double.Parse(chuoidau);
            so2 = double.Parse(chuoihai);
            kq = so1 / so2;
        }

        private void Nutcong_Click(object sender, EventArgs e)
        {
            if (dau > 0 && ktdau == 0)
            {
                hamDaubang();
                dau = 1;
                chuoihai = "";
            }
            else
            {
                dau = 1;
                chuoihai = "";
                hamDaubang();
            }
        }
        
        private void Nuttru_Click(object sender, EventArgs e)
        {
            if (dau > 0 && ktdau == 0)
            {
                hamDaubang();
                dau = 2;
                chuoihai = "";
            }
            else
            {
                dau = 2;
                chuoihai = "";
                hamDaubang();
            }
        }

        private void Nutnhan_Click(object sender, EventArgs e)
        {
            if (dau > 0 && ktdau == 0)
            {
                hamDaubang();
                dau = 3;
                chuoihai = "";
            }
            else
            {
                dau = 3;
                chuoihai = "";
                hamDaubang();
            }
        }

        private void Nutchia_Click(object sender, EventArgs e)
        {
            if (dau > 0 && ktdau == 0)
            {
                hamDaubang();
                dau = 4;
                chuoihai = "";
            }
            else
            {
                dau = 4;
                chuoihai = "";
                hamDaubang();
            }
        }

        private void Nutphantram_Click(object sender, EventArgs e)
        {
            double phantram, so1, so2;
            if (dau == 1)
            {
                so1 = double.Parse(chuoidau);
                so2 = double.Parse(chuoihai);
                kq = so1 + so2;
            }
            else if (dau == 2)
            {
                so1 = double.Parse(chuoidau);
                so2 = double.Parse(chuoihai);
                kq = so1 - so2;
            }
            else if (dau == 3)
            {
                so1 = double.Parse(chuoidau);
                so2 = double.Parse(chuoihai);
                kq = so1 * so2;
            }
            else if (dau == 4)
            {
                so1 = double.Parse(chuoidau);
                so2 = double.Parse(chuoihai);
                kq = so1 / so2;
            }
            else
                Result.Text = "";
            phantram = kq / 100;
            Result.Text = phantram.ToString();
            chuoidau = chuoihai = "";
            so1 = so2 = kq = dau = ktcham1 = ktcham2 = 0;
        }

        private void Nutcan_Click(object sender, EventArgs e)
        {
            double canso;
            if (chuoihai == "" && ktdau == 0)
            {
                canso = System.Math.Sqrt(double.Parse(chuoidau));
                Result.Text = canso.ToString();
                chuoidau = canso.ToString();
            }
            else if (chuoihai != "" && ktdau == 0)
            {
                canso = System.Math.Sqrt(double.Parse(chuoihai));
                Result.Text = canso.ToString();
                chuoihai = canso.ToString();
            }
            else
            {
                canso = System.Math.Sqrt(kq);
                kq = canso;
                Result.Text = canso.ToString();
            }
        }

        private void Nutdau_Click(object sender, EventArgs e)
        {
            if (dau == 0 && ktdau == 0)
            {
                chuyendau = double.Parse(chuoidau);
                chuyendau = 0 - chuyendau;
                chuoidau = chuyendau.ToString();
                Result.Text = chuoidau;
            }
            else if (dau > 0 && ktdau == 0)
            {
                chuyendau = double.Parse(chuoihai);
                chuyendau = 0 - chuyendau;
                chuoihai = chuyendau.ToString();
                Result.Text = chuoihai;
            }
            else
            {
                kq = 0 - kq;
                Result.Text = kq.ToString();
                chuoidau = kq.ToString();
            }
        }
        
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Result_KeyDown(object sender, KeyEventArgs e)
        {
            s=Result.Text;
            if (e.KeyCode == Keys.Back && Result.Text != "")
            {
                Result.Text = s.Substring(0, s.Length - 1);
                Result.SelectionStart = s.Length;
            }
            s = Result.Text;
        }

        private void Result_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
