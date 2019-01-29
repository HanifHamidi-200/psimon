using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSA
{
    public partial class fSub2 : Form
    {
        private List<String> _name = new List<string> { null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<String> _tsa = new List<string> { null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<int> _length = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private int nNumber;
        private String msShuffle1;
        private String msShuffle2;
        private int mnItem1, mnItem2;

        private void fClick()
        {
            int nPos = fFree();
            String sTwo;

            if (nPos != 0)
            {
                sTwo = Convert.ToString(mnItem2);
                if (sTwo.Length == 1)
                {
                    sTwo = "0" + sTwo;
                }
                fPlace(sTwo, nPos);
            }

            fUpdateDisplay();
        }

        private void fPlace(String sText,int nPos)
        {
            msShuffle2 = msShuffle2.Substring(0, nPos * 2 - 2) + sText + msShuffle2.Substring(nPos * 2, (36 - nPos) * 2);
        }

        private void fReset()
        {
            Random rnd1 = new Random();
            char sLetter1, sLetter2;
            String sText;
            String sTwo;

            msShuffle1 = "010203040506070809100102030405060708091001020304050607080910313233343536";
            msShuffle2 = null;

            sTwo = "00";
            for (int i = 1; i <= 36; i++)
            {
                msShuffle2 = msShuffle2 + sTwo;
            }

            for (int i = 1; i <= 14; i++)
            {
                sLetter1 = (char)(rnd1.Next(1, 27) + 64 );
                sLetter2 = (char)(rnd1.Next(1, 27) + 64 );
                sText = Convert.ToString(sLetter1) + Convert.ToString(sLetter2);
                _name[i - 1] = sText;
                sText = null;
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    sText = sText + "T";
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    sText = sText + "S";
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    sText = sText + "A";
                }
                _tsa[i - 1] = sText;
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _length[i - 1] = 0;
                }
                else
                {
                    _length[i - 1] = rnd1.Next(1, 4001);
                }
            }

            fUpdateList();
            fUpdateDisplay();
        }

        private int fFree()
        {
            Random rnd1 = new Random();
            int nTries = 0;
            bool bFound = false;
            int nPos;
            String sType;

            do
            {
                nTries += 1;
                nPos = rnd1.Next(1, 37);
                sType = fHoletype(msShuffle2, nPos);
                if (sType == "00")
                {
                    bFound = true;
                }
                if (nTries > 5)
                {
                    return 0;
                }
            } while (bFound == false);

            return nPos;
        }
        private String fHoletype(String sText,int nPos)
        {
            return sText.Substring(nPos * 2 - 2, 2);
        }

        private String fText(int nPos)
        {
            String sTwo;
            int nValue;
            String sText = null;

            sTwo = fHoletype(msShuffle2, nPos);
            nValue = Convert.ToInt32(sTwo);
            if (nValue == 0)
            {
                sText = "0";
            }
            else
            {
                switch (mnItem1)
                {
                    case 1:
                        sText = _name[nValue - 1];
                        break;
                    case 2:
                        sText = _tsa[nValue - 1];
                        break;
                    case 3:
                        sText = Convert.ToString(_length[nValue - 1]);
                        break;
                }
            }
            return sText;

        }
        private void fUpdateDisplay()
        {
            String sText;

            sText = fText(1);
            lbl11.Text = sText;
            sText = fText(2);
            lbl12.Text = sText;
            sText = fText(3);
            lbl13.Text = sText;
            sText = fText(4);
            lbl14.Text = sText;
            sText = fText(5);
            lbl15.Text = sText;
            sText = fText(6);
            lbl16.Text = sText;
            sText = fText(7);
            lbl21.Text = sText;
            sText = fText(8);
            lbl22.Text = sText;
            sText = fText(9);
            lbl23.Text = sText;
            sText = fText(10);
            lbl24.Text = sText;

            sText = fText(11);
            lbl25.Text = sText;
            sText = fText(12);
            lbl26.Text = sText;
            sText = fText(13);
            lbl31.Text = sText;
            sText = fText(14);
            lbl32.Text = sText;
            sText = fText(15);
            lbl33.Text = sText;
            sText = fText(16);
            lbl34.Text = sText;
            sText = fText(17);
            lbl35.Text = sText;
            sText = fText(18);
            lbl36.Text = sText;
            sText = fText(19);
            lbl41.Text = sText;
            sText = fText(20);
            lbl42.Text = sText;

            sText = fText(21);
            lbl43.Text = sText;
            sText = fText(22);
            lbl44.Text = sText;
            sText = fText(23);
            lbl45.Text = sText;
            sText = fText(24);
            lbl46.Text = sText;
            sText = fText(25);
            lbl51.Text = sText;
            sText = fText(26);
            lbl52.Text = sText;
            sText = fText(27);
            lbl53.Text = sText;
            sText = fText(28);
            lbl54.Text = sText;
            sText = fText(29);
            lbl55.Text = sText;
            sText = fText(30);
            lbl56.Text = sText;

            sText = fText(31);
            lbl61.Text = sText;
            sText = fText(32);
            lbl62.Text = sText;
            sText = fText(33);
            lbl63.Text = sText;
            sText = fText(34);
            lbl64.Text = sText;
            sText = fText(35);
            lbl65.Text = sText;
            sText = fText(36);
            lbl66.Text = sText;
        }

        private void fUpdateList()
        {
            btn11.Text = _name[0];
            btn12.Text = _name[1];
            btn13.Text = _name[2];
            btn14.Text = _name[3];
            btn15.Text = _name[4];
            btn16.Text = _name[5];
            btn17.Text = _name[6];
            btn18.Text = _name[7];
            btn19.Text = _name[8];
            btn1a.Text = _name[9];
            btn1b.Text = _name[10];
            btn1c.Text = _name[11];
            btn1d.Text = _name[12];
            btn1e.Text = _name[13];

            btn21.Text = _tsa[0];
            btn22.Text = _tsa[1];
            btn23.Text = _tsa[2];
            btn24.Text = _tsa[3];
            btn25.Text = _tsa[4];
            btn26.Text = _tsa[5];
            btn27.Text = _tsa[6];
            btn28.Text = _tsa[7];
            btn29.Text = _tsa[8];
            btn2a.Text = _tsa[9];
            btn2b.Text = _tsa[10];
            btn2c.Text = _tsa[11];
            btn2d.Text = _tsa[12];
            btn2e.Text = _tsa[13];

            btn31.Text = Convert.ToString(_length[0]);
            btn32.Text = Convert.ToString(_length[1]);
            btn33.Text = Convert.ToString(_length[2]);
            btn34.Text = Convert.ToString(_length[3]);
            btn35.Text = Convert.ToString(_length[4]);
            btn36.Text = Convert.ToString(_length[5]);
            btn37.Text = Convert.ToString(_length[6]);
            btn38.Text = Convert.ToString(_length[7]);
            btn39.Text = Convert.ToString(_length[8]);
            btn3a.Text = Convert.ToString(_length[9]);
            btn3b.Text = Convert.ToString(_length[10]);
            btn3c.Text = Convert.ToString(_length[11]);
            btn3d.Text = Convert.ToString(_length[12]);
            btn3e.Text = Convert.ToString(_length[13]);

        }
        public fSub2()
        {
            InitializeComponent();
        }

        private void fSub2_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void Btn11_Click(object sender, EventArgs e)
        {
            mnItem1 = 1;
            mnItem2 = 1;
            fClick();
        }

        private void Btn12_Click(object sender, EventArgs e)
        {
            mnItem1 = 1;
            mnItem2 = 2;
            fClick();

        }

        private void Btn13_Click(object sender, EventArgs e)
        {
            mnItem1 = 1;
            mnItem2 = 3;
            fClick();

        }

        private void Btn14_Click(object sender, EventArgs e)
        {
            mnItem1 = 1;
            mnItem2 = 4;
            fClick();

        }

        private void Btn15_Click(object sender, EventArgs e)
        {
            mnItem1 = 1;
            mnItem2 = 5;
            fClick();

        }

        private void Btn16_Click(object sender, EventArgs e)
        {
            mnItem1 = 1;
            mnItem2 = 6;
            fClick();

        }

        private void Btn17_Click(object sender, EventArgs e)
        {
            mnItem1 = 1;
            mnItem2 = 7;
            fClick();

        }

        private void Btn18_Click(object sender, EventArgs e)
        {
            mnItem1 = 1;
            mnItem2 = 8;
            fClick();

        }

        private void Btn19_Click(object sender, EventArgs e)
        {
            mnItem1 = 1;
            mnItem2 = 9;
            fClick();

        }

        private void Btn1a_Click(object sender, EventArgs e)
        {
            mnItem1 = 1;
            mnItem2 = 10;
            fClick();

        }

        private void Btn1b_Click(object sender, EventArgs e)
        {
            mnItem1 = 1;
            mnItem2 = 11;
            fClick();

        }

        private void Btn1c_Click(object sender, EventArgs e)
        {
            mnItem1 = 1;
            mnItem2 = 12;
            fClick();

        }

        private void Btn1d_Click(object sender, EventArgs e)
        {
            mnItem1 = 1;
            mnItem2 = 13;
            fClick();

        }

        private void Btn1e_Click(object sender, EventArgs e)
        {
            mnItem1 = 1;
            mnItem2 = 14;
            fClick();

        }

        private void Btn21_Click(object sender, EventArgs e)
        {
            mnItem1 = 2;
            mnItem2 = 1;
            fClick();

        }

        private void Btn22_Click(object sender, EventArgs e)
        {
            mnItem1 = 2;
            mnItem2 = 2;
            fClick();

        }

        private void Btn23_Click(object sender, EventArgs e)
        {
            mnItem1 = 2;
            mnItem2 = 3;
            fClick();

        }

        private void Btn24_Click(object sender, EventArgs e)
        {
            mnItem1 = 2;
            mnItem2 = 4;
            fClick();

        }

        private void Btn25_Click(object sender, EventArgs e)
        {
            mnItem1 = 2;
            mnItem2 = 5;
            fClick();

        }

        private void Btn26_Click(object sender, EventArgs e)
        {
            mnItem1 = 2;
            mnItem2 = 6;
            fClick();

        }

        private void Btn27_Click(object sender, EventArgs e)
        {
            mnItem1 = 2;
            mnItem2 = 7;
            fClick();

        }

        private void Btn28_Click(object sender, EventArgs e)
        {
            mnItem1 = 2;
            mnItem2 = 8;
            fClick();

        }

        private void Btn29_Click(object sender, EventArgs e)
        {
            mnItem1 = 2;
            mnItem2 = 9;
            fClick();

        }

        private void Btn2a_Click(object sender, EventArgs e)
        {
            mnItem1 = 2;
            mnItem2 = 10;
            fClick();

        }

        private void Btn2b_Click(object sender, EventArgs e)
        {
            mnItem1 = 2;
            mnItem2 = 11;
            fClick();

        }

        private void Btn2c_Click(object sender, EventArgs e)
        {
            mnItem1 = 2;
            mnItem2 = 12;
            fClick();

        }

        private void Btn2d_Click(object sender, EventArgs e)
        {
            mnItem1 = 2;
            mnItem2 = 13;
            fClick();

        }

        private void Btn2e_Click(object sender, EventArgs e)
        {
            mnItem1 = 2;
            mnItem2 = 14;
            fClick();

        }

        private void Btn31_Click(object sender, EventArgs e)
        {
            mnItem1 = 3;
            mnItem2 = 1;
            fClick();

        }

        private void Btn32_Click(object sender, EventArgs e)
        {
            mnItem1 = 3;
            mnItem2 = 2;
            fClick();

        }

        private void Btn33_Click(object sender, EventArgs e)
        {
            mnItem1 = 3;
            mnItem2 = 3;
            fClick();

        }

        private void Btn34_Click(object sender, EventArgs e)
        {
            mnItem1 = 3;
            mnItem2 = 4;
            fClick();

        }

        private void Btn35_Click(object sender, EventArgs e)
        {
            mnItem1 = 3;
            mnItem2 = 5;
            fClick();

        }

        private void Btn36_Click(object sender, EventArgs e)
        {
            mnItem1 = 3;
            mnItem2 = 6;
            fClick();

        }

        private void Btn37_Click(object sender, EventArgs e)
        {
            mnItem1 = 3;
            mnItem2 = 7;
            fClick();

        }

        private void Btn38_Click(object sender, EventArgs e)
        {
            mnItem1 = 3;
            mnItem2 = 8;
            fClick();

        }

        private void Btn39_Click(object sender, EventArgs e)
        {
            mnItem1 = 3;
            mnItem2 = 9;
            fClick();

        }

        private void Btn3a_Click(object sender, EventArgs e)
        {
            mnItem1 = 3;
            mnItem2 = 10;
            fClick();

        }

        private void Btn3b_Click(object sender, EventArgs e)
        {
            mnItem1 = 3;
            mnItem2 = 11;
            fClick();

        }

        private void Btn3c_Click(object sender, EventArgs e)
        {
            mnItem1 = 3;
            mnItem2 = 12;
            fClick();

        }

        private void Btn3d_Click(object sender, EventArgs e)
        {
            mnItem1 = 3;
            mnItem2 = 13;
            fClick();

        }

        private void Btn3e_Click(object sender, EventArgs e)
        {
            mnItem1 = 3;
            mnItem2 = 14;
            fClick();

        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
