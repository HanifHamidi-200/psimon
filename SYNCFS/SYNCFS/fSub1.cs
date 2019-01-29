﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYNCFS
{
    public partial class fSub1 : Form
    {
        private String msShuffle;
        private String msShuffle2;
        private int nNumber;
        private int mnCol, mnRow, mnRotate;
        private int mnWin = 0;

        private void fNav(int nMode)
        {
            switch (nMode)
            {
                case 1:
                    mnRow -= 1;
                    break;
                case 2:
                    mnCol += 1;
                    mnRow -= 1;
                    break;
                case 3:
                    mnCol += 1;
                    break;
                case 4:
                    mnCol += 1;
                    mnRow += 1;
                    break;
                case 5:
                    mnRow += 1;
                    break;
                case 6:
                    mnCol -= 1;
                    mnRow += 1;
                    break;
                case 7:
                    mnCol -= 1;
                    break;
                default:
                    mnCol -= 1;
                    mnRow -= 1;
                    break;
            }

            if (mnCol == 0)
            {
                if (mnRow <= 3)
                {
                    fWin();
                    goto endline;
                }
                else
                {
                    mnCol = 8;
                }
            }
            if (mnCol == 9)
            {
                mnCol = 1;
            }
            if (mnRow == 0)
            {
                mnRow = 10;
            }
            if (mnRow == 11)
            {
                mnRow = 1;
            }

            fUpdateDisplay();

            endline:;
        }

        private void fWin()
        {
            mnWin += 1;
            MessageBox.Show("You win", "GWin" + Convert.ToString(mnWin));
            fReset();
        }
        private void fReset()
        {
            Random rnd1 = new Random();
            String sTwo;
            int nPos2 = rnd1.Next(1, 4);
            int nPos;
            int nCol = 0, nRow = 0;
            int nTop;

            msShuffle = "0102030405060708091011121314151617181920212223242526272829303132333435363738394041424344454647484950515253545556575859606162636465666768697071727374757677787980";
            msShuffle2 = null;

            for (int i = 1; i <= 80; i++)
            {
                sTwo = "01";
                msShuffle2 = msShuffle2 + sTwo;
            }

            for (int i = 1; i <= 8; i++)
            {
                nTop = i + 3;
                for (int j = nTop; j <= 10; j++)
                {
                    sTwo = "02";
                    nPos = (i - 1) * 10 + j;
                    fPlace(sTwo, nPos);

                }
            }
            for (int i = 1; i <= 8; i++)
            {
                nCol = i;
                fFree2(ref nCol, ref nRow);
                sTwo = "03";
                nPos = (nCol - 1) * 8 + nRow;
                fPlace(sTwo, nPos);
            }

            for (int i = 1; i <= 4; i++)
            {
                fFree(ref nCol, ref nRow);
                sTwo = "04";
                nPos = (nCol - 1) * 8 + nRow;
                fPlace(sTwo, nPos);
            }
            fFree(ref nCol, ref nRow);
            mnCol = nCol;
            mnRow = nRow;
            mnRotate = rnd1.Next(1, 5);

            fUpdateDisplay();

        }
        private void fUpdateDisplay()
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate = 1;

            //1
            nType = fHoletype(msShuffle2, 1);
            fPeek(nType, nRotate, ref _pic);
            pic11.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 2);
            fPeek(nType, nRotate, ref _pic);
            pic12.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 3);
            fPeek(nType, nRotate, ref _pic);
            pic13.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 4);
            fPeek(nType, nRotate, ref _pic);
            pic14.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 5);
            fPeek(nType, nRotate, ref _pic);
            pic15.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 6);
            fPeek(nType, nRotate, ref _pic);
            pic16.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 7);
            fPeek(nType, nRotate, ref _pic);
            pic17.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 8);
            fPeek(nType, nRotate, ref _pic);
            pic18.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 9);
            fPeek(nType, nRotate, ref _pic);
            pic19.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 10);
            fPeek(nType, nRotate, ref _pic);
            pic1a.Image = _pic.Image;

            //2
            nType = fHoletype(msShuffle2, 11);
            fPeek(nType, nRotate, ref _pic);
            pic21.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 12);
            fPeek(nType, nRotate, ref _pic);
            pic22.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 13);
            fPeek(nType, nRotate, ref _pic);
            pic23.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 14);
            fPeek(nType, nRotate, ref _pic);
            pic24.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 15);
            fPeek(nType, nRotate, ref _pic);
            pic25.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 16);
            fPeek(nType, nRotate, ref _pic);
            pic26.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 17);
            fPeek(nType, nRotate, ref _pic);
            pic27.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 18);
            fPeek(nType, nRotate, ref _pic);
            pic28.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 19);
            fPeek(nType, nRotate, ref _pic);
            pic29.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 20);
            fPeek(nType, nRotate, ref _pic);
            pic2a.Image = _pic.Image;

            //3
            nType = fHoletype(msShuffle2, 21);
            fPeek(nType, nRotate, ref _pic);
            pic31.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 22);
            fPeek(nType, nRotate, ref _pic);
            pic32.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 23);
            fPeek(nType, nRotate, ref _pic);
            pic33.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 24);
            fPeek(nType, nRotate, ref _pic);
            pic34.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 25);
            fPeek(nType, nRotate, ref _pic);
            pic35.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 26);
            fPeek(nType, nRotate, ref _pic);
            pic36.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 27);
            fPeek(nType, nRotate, ref _pic);
            pic37.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 28);
            fPeek(nType, nRotate, ref _pic);
            pic38.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 29);
            fPeek(nType, nRotate, ref _pic);
            pic39.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 30);
            fPeek(nType, nRotate, ref _pic);
            pic3a.Image = _pic.Image;

            //4
            nType = fHoletype(msShuffle2, 31);
            fPeek(nType, nRotate, ref _pic);
            pic41.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 32);
            fPeek(nType, nRotate, ref _pic);
            pic42.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 33);
            fPeek(nType, nRotate, ref _pic);
            pic43.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 34);
            fPeek(nType, nRotate, ref _pic);
            pic44.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 35);
            fPeek(nType, nRotate, ref _pic);
            pic45.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 36);
            fPeek(nType, nRotate, ref _pic);
            pic46.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 37);
            fPeek(nType, nRotate, ref _pic);
            pic47.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 38);
            fPeek(nType, nRotate, ref _pic);
            pic48.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 39);
            fPeek(nType, nRotate, ref _pic);
            pic49.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 40);
            fPeek(nType, nRotate, ref _pic);
            pic4a.Image = _pic.Image;


            //5
            nType = fHoletype(msShuffle2, 41);
            fPeek(nType, nRotate, ref _pic);
            pic51.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 42);
            fPeek(nType, nRotate, ref _pic);
            pic52.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 43);
            fPeek(nType, nRotate, ref _pic);
            pic53.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 44);
            fPeek(nType, nRotate, ref _pic);
            pic54.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 45);
            fPeek(nType, nRotate, ref _pic);
            pic55.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 46);
            fPeek(nType, nRotate, ref _pic);
            pic56.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 47);
            fPeek(nType, nRotate, ref _pic);
            pic57.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 48);
            fPeek(nType, nRotate, ref _pic);
            pic58.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 49);
            fPeek(nType, nRotate, ref _pic);
            pic59.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 50);
            fPeek(nType, nRotate, ref _pic);
            pic5a.Image = _pic.Image;

            //6
            nType = fHoletype(msShuffle2, 51);
            fPeek(nType, nRotate, ref _pic);
            pic61.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 52);
            fPeek(nType, nRotate, ref _pic);
            pic62.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 53);
            fPeek(nType, nRotate, ref _pic);
            pic63.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 54);
            fPeek(nType, nRotate, ref _pic);
            pic64.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 55);
            fPeek(nType, nRotate, ref _pic);
            pic65.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 56);
            fPeek(nType, nRotate, ref _pic);
            pic66.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 57);
            fPeek(nType, nRotate, ref _pic);
            pic67.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 58);
            fPeek(nType, nRotate, ref _pic);
            pic68.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 59);
            fPeek(nType, nRotate, ref _pic);
            pic69.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 60);
            fPeek(nType, nRotate, ref _pic);
            pic6a.Image = _pic.Image;

            //7
            nType = fHoletype(msShuffle2, 61);
            fPeek(nType, nRotate, ref _pic);
            pic71.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 62);
            fPeek(nType, nRotate, ref _pic);
            pic72.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 63);
            fPeek(nType, nRotate, ref _pic);
            pic73.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 64);
            fPeek(nType, nRotate, ref _pic);
            pic74.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 65);
            fPeek(nType, nRotate, ref _pic);
            pic75.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 66);
            fPeek(nType, nRotate, ref _pic);
            pic76.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 67); ;
            fPeek(nType, nRotate, ref _pic);
            pic77.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 68);
            fPeek(nType, nRotate, ref _pic);
            pic78.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 69);
            fPeek(nType, nRotate, ref _pic);
            pic79.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 70);
            fPeek(nType, nRotate, ref _pic);
            pic7a.Image = _pic.Image;

            //8
            nType = fHoletype(msShuffle2, 71);
            fPeek(nType, nRotate, ref _pic);
            pic81.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 72);
            fPeek(nType, nRotate, ref _pic);
            pic82.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 73);
            fPeek(nType, nRotate, ref _pic);
            pic83.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 74);
            fPeek(nType, nRotate, ref _pic);
            pic84.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 75);
            fPeek(nType, nRotate, ref _pic);
            pic85.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 76);
            fPeek(nType, nRotate, ref _pic);
            pic86.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 77);
            fPeek(nType, nRotate, ref _pic);
            pic87.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 78);
            fPeek(nType, nRotate, ref _pic);
            pic88.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 79);
            fPeek(nType, nRotate, ref _pic);
            pic89.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 80);
            fPeek(nType, nRotate, ref _pic);
            pic8a.Image = _pic.Image;

            nType = 5;
            nRotate = mnRotate;
            fIcon(nType, nRotate, mnCol, mnRow);
        }

        private void fIcon(int nType, int nRotate, int nCol, int nRow)
        {
            PictureBox _pic = new PictureBox();

            fPeek(nType, nRotate, ref _pic);

            switch (nCol)
            {
                case 1:
                    switch (nRow)
                    {
                        case 1:
                            pic11.Image = _pic.Image;
                            break;
                        case 2:
                            pic12.Image = _pic.Image;
                            break;
                        case 3:
                            pic13.Image = _pic.Image;
                            break;
                        case 4:
                            pic14.Image = _pic.Image;
                            break;
                        case 5:
                            pic15.Image = _pic.Image;
                            break;
                        case 6:
                            pic16.Image = _pic.Image;
                            break;
                        case 7:
                            pic17.Image = _pic.Image;
                            break;
                        case 8:
                            pic18.Image = _pic.Image;
                            break;
                        case 9:
                            pic19.Image = _pic.Image;
                            break;
                        default:
                            pic1a.Image = _pic.Image;
                            break;
                    }
                    break;
                case 2:
                    switch (nRow)
                    {
                        case 1:
                            pic21.Image = _pic.Image;
                            break;
                        case 2:
                            pic22.Image = _pic.Image;
                            break;
                        case 3:
                            pic23.Image = _pic.Image;
                            break;
                        case 4:
                            pic24.Image = _pic.Image;
                            break;
                        case 5:
                            pic25.Image = _pic.Image;
                            break;
                        case 6:
                            pic26.Image = _pic.Image;
                            break;
                        case 7:
                            pic27.Image = _pic.Image;
                            break;
                        case 8:
                            pic28.Image = _pic.Image;
                            break;
                        case 9:
                            pic29.Image = _pic.Image;
                            break;
                        default:
                            pic2a.Image = _pic.Image;
                            break;
                    }
                    break;
                case 3:
                    switch (nRow)
                    {
                        case 1:
                            pic31.Image = _pic.Image;
                            break;
                        case 2:
                            pic32.Image = _pic.Image;
                            break;
                        case 3:
                            pic33.Image = _pic.Image;
                            break;
                        case 4:
                            pic34.Image = _pic.Image;
                            break;
                        case 5:
                            pic35.Image = _pic.Image;
                            break;
                        case 6:
                            pic36.Image = _pic.Image;
                            break;
                        case 7:
                            pic37.Image = _pic.Image;
                            break;
                        case 8:
                            pic38.Image = _pic.Image;
                            break;
                        case 9:
                            pic39.Image = _pic.Image;
                            break;
                        default:
                            pic3a.Image = _pic.Image;
                            break;
                    }
                    break;
                case 4:
                    switch (nRow)
                    {
                        case 1:
                            pic41.Image = _pic.Image;
                            break;
                        case 2:
                            pic42.Image = _pic.Image;
                            break;
                        case 3:
                            pic43.Image = _pic.Image;
                            break;
                        case 4:
                            pic44.Image = _pic.Image;
                            break;
                        case 5:
                            pic45.Image = _pic.Image;
                            break;
                        case 6:
                            pic46.Image = _pic.Image;
                            break;
                        case 7:
                            pic47.Image = _pic.Image;
                            break;
                        case 8:
                            pic48.Image = _pic.Image;
                            break;
                        case 9:
                            pic49.Image = _pic.Image;
                            break;
                        default:
                            pic4a.Image = _pic.Image;
                            break;
                    }
                    break;
                case 5:
                    switch (nRow)
                    {
                        case 1:
                            pic51.Image = _pic.Image;
                            break;
                        case 2:
                            pic52.Image = _pic.Image;
                            break;
                        case 3:
                            pic53.Image = _pic.Image;
                            break;
                        case 4:
                            pic54.Image = _pic.Image;
                            break;
                        case 5:
                            pic55.Image = _pic.Image;
                            break;
                        case 6:
                            pic56.Image = _pic.Image;
                            break;
                        case 7:
                            pic57.Image = _pic.Image;
                            break;
                        case 8:
                            pic58.Image = _pic.Image;
                            break;
                        case 9:
                            pic59.Image = _pic.Image;
                            break;
                        default:
                            pic5a.Image = _pic.Image;
                            break;
                    }
                    break;
                case 6:
                    switch (nRow)
                    {
                        case 1:
                            pic61.Image = _pic.Image;
                            break;
                        case 2:
                            pic62.Image = _pic.Image;
                            break;
                        case 3:
                            pic63.Image = _pic.Image;
                            break;
                        case 4:
                            pic64.Image = _pic.Image;
                            break;
                        case 5:
                            pic65.Image = _pic.Image;
                            break;
                        case 6:
                            pic66.Image = _pic.Image;
                            break;
                        case 7:
                            pic67.Image = _pic.Image;
                            break;
                        case 8:
                            pic68.Image = _pic.Image;
                            break;
                        case 9:
                            pic69.Image = _pic.Image;
                            break;
                        default:
                            pic6a.Image = _pic.Image;
                            break;
                    }
                    break;
                case 7:
                    switch (nRow)
                    {
                        case 1:
                            pic71.Image = _pic.Image;
                            break;
                        case 2:
                            pic72.Image = _pic.Image;
                            break;
                        case 3:
                            pic73.Image = _pic.Image;
                            break;
                        case 4:
                            pic74.Image = _pic.Image;
                            break;
                        case 5:
                            pic75.Image = _pic.Image;
                            break;
                        case 6:
                            pic76.Image = _pic.Image;
                            break;
                        case 7:
                            pic77.Image = _pic.Image;
                            break;
                        case 8:
                            pic78.Image = _pic.Image;
                            break;
                        case 9:
                            pic79.Image = _pic.Image;
                            break;
                        default:
                            pic7a.Image = _pic.Image;
                            break;
                    }
                    break;
                default:
                    switch (nRow)
                    {
                        case 1:
                            pic81.Image = _pic.Image;
                            break;
                        case 2:
                            pic82.Image = _pic.Image;
                            break;
                        case 3:
                            pic83.Image = _pic.Image;
                            break;
                        case 4:
                            pic84.Image = _pic.Image;
                            break;
                        case 5:
                            pic85.Image = _pic.Image;
                            break;
                        case 6:
                            pic86.Image = _pic.Image;
                            break;
                        case 7:
                            pic87.Image = _pic.Image;
                            break;
                        case 8:
                            pic88.Image = _pic.Image;
                            break;
                        case 9:
                            pic89.Image = _pic.Image;
                            break;
                        default:
                            pic8a.Image = _pic.Image;
                            break;
                    }
                    break;

            }

        }

        private int fHoletype(String sShuffle, int nSquare)
        {
            int nType = 0;
            nType = Convert.ToInt32(sShuffle.Substring(nSquare * 2 - 2, 2));

            return nType;
        }

        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F innerspace.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F space.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F moons.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F teleport.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F YOU.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            switch (nValue)
            {
                case 1:
                    _pic2 = picture1;
                    break;
                case 2:
                    _pic2 = picture2;
                    break;
                case 3:
                    _pic2 = picture3;
                    break;
                case 4:
                    _pic2 = picture4;
                    break;
                case 5:
                    _pic2 = picture5;
                    break;
                default:
                    _pic2 = picture6;
                    break;
            }
            for (int i = 1; i <= nRotate - 1; i++)
            {
                _pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

        }
        private void fPlace(String sText, int nPos)
        {
            if (nPos == 80)
            {
                msShuffle2 = msShuffle2.Substring(0, nPos * 2 - 2) + sText;

            }
            else
            {
                msShuffle2 = msShuffle2.Substring(0, nPos * 2 - 2) + sText + msShuffle2.Substring(nPos * 2, (80 - nPos) * 2);

            }
        }
        private void fFree(ref int nCol, ref int nRow)
        {
            Random rnd1 = new Random();
            bool bFound = false;
            String sData;
            int nValue;

            do
            {
                nCol = rnd1.Next(1, 9);
                nRow = rnd1.Next(1, 11);
                sData = fData(nCol, nRow);
                nValue = Convert.ToInt32(sData);
                if (nValue == 1)
                {
                    bFound = true;
                }
            } while (bFound == false);
        }

        private void fFree2(ref int nCol, ref int nRow)
        {
            Random rnd1 = new Random();
            bool bFound = false;
            String sData;
            int nValue;

            do
            {
                nRow = rnd1.Next(1, nCol + 4);
                sData = fData(nCol, nRow);
                nValue = Convert.ToInt32(sData);
                if (nValue == 1)
                {
                    bFound = true;
                }
            } while (bFound == false);
        }
        private String fData(int nCol, int nRow)
        {
            int nPos = (nCol - 1) * 8 + nRow;
            String sTwo = msShuffle2.Substring(nPos * 2 - 2, 2);

            return sTwo;
        }

       private void btnQNext_Click_1(object sender, EventArgs e)
        {
            fReset();

        }

        private void btnNav1_Click(object sender, EventArgs e)
        {
            fNav(1);
        }

        private void btnNav2_Click(object sender, EventArgs e)
        {
            fNav(2);
        }

        private void btnNav3_Click(object sender, EventArgs e)
        {
            fNav(3);
        }

        private void btnNav4_Click(object sender, EventArgs e)
        {
            fNav(4);
        }

        private void btnNav5_Click(object sender, EventArgs e)
        {
            fNav(5);
        }

        private void btnNav6_Click(object sender, EventArgs e)
        {
            fNav(6);
        }

        private void btnNav7_Click(object sender, EventArgs e)
        {
            fNav(7);
        }

        private void btnNav8_Click(object sender, EventArgs e)
        {
            fNav(8);
        }

        public fSub1()
        {
            InitializeComponent();
        }

        private void fSub1_Load(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
