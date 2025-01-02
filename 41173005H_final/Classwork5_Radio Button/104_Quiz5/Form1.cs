﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _106_Quiz4;
using _106_Classwork5_2;
using _104_Quiz5;

namespace _106_Classwork5_2
{
    public partial class Form1 : Form
    {
        PinBoard board = null;
        Triangle tri;
        TextBox[,] txtRowCol;
        TextBox[,] txtXY;
        GroupBox[,] grpBoxPinContainers;
        RadioButton[,] rbtnPins;

        public Form1()
        {
            InitializeComponent();
            tri = new Triangle();

            txtRowCol = new TextBox[3, 2];
            int xInit = 14;
            int yInit = 68;
            int x, y;
            int width = 54;
            int height = 22;
            int xSpace = 26;
            int ySpace = 20;
            y = yInit;
            for (int i = 0; i <= 2; i++)
            {
                x = xInit;
                for (int j = 0; j <= 1; j++)
                {
                    txtRowCol[i, j] = new TextBox();
                    this.grpBoxCoordonate.Controls.Add(this.txtRowCol[i, j]);
                    txtRowCol[i, j].Width = width;
                    txtRowCol[i, j].Height = height;
                    txtRowCol[i, j].Location = new System.Drawing.Point(x, y);
                    txtRowCol[i, j].Text = "0";
                    this.txtRowCol[i, j].TextChanged += new System.EventHandler(this.txtRowCol_TextChanged);
                    x += (width + xSpace);
                }
                y += (height + ySpace);
            }
            txtXY = new TextBox[3, 2];
            xInit = 190;
            yInit = 68;
            y = yInit;
            for (int i = 0; i <= 2; i++)
            {
                x = xInit;
                for (int j = 0; j <= 1; j++)
                {
                    txtXY[i, j] = new TextBox();
                    this.grpBoxCoordonate.Controls.Add(this.txtXY[i, j]);
                    txtXY[i, j].Width = width;
                    txtXY[i, j].Height = height;
                    txtXY[i, j].Location = new System.Drawing.Point(x, y);
                    txtXY[i, j].Enabled = false;
                    x += (width + xSpace);
                }
                y += (height + ySpace);
            }
        }

        private void btnCreatePinBoard_Click(object sender, EventArgs e)
        {
            int rows = Convert.ToInt32(txtRows.Text);
            int cols = Convert.ToInt32(txtCols.Text);
            if (board == null)
            {
                board = new PinBoard();
                board.Rows = Convert.ToInt32(txtRows.Text);
                board.Cols = Convert.ToInt32(txtCols.Text);
                board.XInterval = Convert.ToDouble(txtXInterval.Text);
                board.YInterval = Convert.ToDouble(txtYInterval.Text);
                board.CreatePins();
                board.SetPinPoistions();
                CreateVisualPinBoard(board.Rows, board.Cols);
            }
            else if (rows == board.Rows && cols == board.Cols)
            {
                board.XInterval = Convert.ToDouble(txtXInterval.Text);
                board.YInterval = Convert.ToDouble(txtYInterval.Text);
                board.SetPinPoistions();

            }
            else
            {
                DestroyVisualPinBoard(board.Rows, board.Cols);
                board.Rows = Convert.ToInt32(txtRows.Text);
                board.Cols = Convert.ToInt32(txtCols.Text);
                board.XInterval = Convert.ToDouble(txtXInterval.Text);
                board.YInterval = Convert.ToDouble(txtYInterval.Text);
                board.CreatePins();
                board.SetPinPoistions();
                CreateVisualPinBoard(board.Rows, board.Cols);
            }
        }
        private void DestroyVisualPinBoard(int rows, int cols)
        {
            if (grpBoxPinContainers == null)
                return;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    this.grpBoxVisualPinBoard.Controls.Remove(this.grpBoxPinContainers[i, j]);
                }
            }
        }
        private void CreateVisualPinBoard(int rows, int cols)
        {
            grpBoxPinContainers = new GroupBox[rows, cols];
            rbtnPins = new RadioButton[rows, cols];
            int xInit = 10;
            int yInit = 10;
            int x, y;
            int width = 30;
            int height = 30;
            int xSpace = 1;
            int ySpace = 1;
            y = yInit;
            for (int i = 0; i < rows; i++)
            {
                x = xInit;
                for (int j = 0; j < cols; j++)
                {
                    grpBoxPinContainers[i, j] = new GroupBox();
                    grpBoxPinContainers[i, j].Width = width;
                    grpBoxPinContainers[i, j].Height = height;
                    grpBoxPinContainers[i, j].Location = new System.Drawing.Point(x, y);
                    grpBoxPinContainers[i, j].Text = "";
                    this.grpBoxVisualPinBoard.Controls.Add(this.grpBoxPinContainers[i, j]);
                    rbtnPins[i, j] = new RadioButton();
                    rbtnPins[i, j].Location = new System.Drawing.Point(10, 5);
                    this.grpBoxPinContainers[i, j].Controls.Add(this.rbtnPins[i, j]);
                    rbtnPins[i, j].Click += new System.EventHandler(this.rbtnPins_Click);
                    x += (width + xSpace);
                }
                y += (height + ySpace);
            }
            this.grpBoxVisualPinBoard.ResumeLayout(false);
            this.grpBoxVisualPinBoard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            UpdatePosition();
            for (int i = 0; i <= 2; i++)
            {
                tri.ptArr[i] = board.PinArray[Convert.ToInt32(txtRowCol[i, 0].Text), Convert.ToInt32(txtRowCol[i, 1].Text)];
            }

            tri.CreatePoints();
            for (int i = 0; i <= 2; i++)
            {
                tri.ptArr[i].xCoord = Double.Parse(txtXY[i, 0].Text);
                tri.ptArr[i].yCoord = Double.Parse(txtXY[i, 1].Text);
            }

            if (tri.isValid())
            {

                txtMessage.Text += ("Area=" + tri.Area().ToString() + Environment.NewLine);

                txtMessage.Text += ("Perimeter=" + tri.Perimeter().ToString() + Environment.NewLine);


                switch (tri.ShapeType())
                {

                    case 1:
                        txtMessage.Text += "本三角形為直角三角形";
                        break;
                    case 2:
                        txtMessage.Text += "本三角形為銳角三角形";
                        break;
                    case 3:
                        txtMessage.Text += "本三角形為鈍角三角形";
                        break;
                    default:
                        txtMessage.Text += "程式有錯";
                        break;
                }

            }
            else
            {
                txtMessage.Text += "此三點無法形成三角形";
            }

        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMessage.Clear();
        }

        private void txtRowCol_TextChanged(object sender, EventArgs e)
        {
            UpdatePosition();
            //下列函數開啟時會打架
            //            UpdatePinPosition();

        }
        private void rbtnPins_Click(object sender, EventArgs e)
        {
            int pinNum = calculateSelectedPins();
            if (pinNum == 3)
            {
                DisableUnselectedPins();
            }
            UpdatePinRowCol();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetRowColTextBox();
            ResetPinBoard();
            txtMessage.Clear();
        }
        private void ResetPinBoard()
        {
            for (int i = 0; i < board.Rows; i++)
            {
                for (int j = 0; j < board.Cols; j++)
                {
                    rbtnPins[i, j].Checked = false;
                    rbtnPins[i, j].Enabled = true;
                }
            }
        }
        private void UpdatePosition()
        {
            for (int i = 0; i <= 2; i++)
            {
                txtXY[i, 0].Text = (Convert.ToDouble(txtRowCol[i, 1].Text) * board.XInterval).ToString();
                txtXY[i, 1].Text = (Convert.ToDouble(txtRowCol[i, 0].Text) * board.YInterval).ToString();
            }
        }

        private void DisableUnselectedPins()
        {
            for (int i = 0; i < board.Rows; i++)
            {
                for (int j = 0; j < board.Cols; j++)
                {
                    if (rbtnPins[i, j].Checked == false)
                        rbtnPins[i, j].Enabled = false;

                }
            }
        }
        private int calculateSelectedPins()
        {
            int pinNum = 0;
            for (int i = 0; i < board.Rows; i++)
            {
                for (int j = 0; j < board.Cols; j++)
                {
                    if (rbtnPins[i, j].Checked == true)
                    {
                        pinNum += 1;
                    }
                }
            }
            return pinNum;
        }


        private void UpdatePinRowCol()
        {
            int pinNum = 0;
            for (int i = 0; i < board.Rows; i++)
            {
                for (int j = 0; j < board.Cols; j++)
                {
                    if (rbtnPins[i, j].Checked == true)
                    {
                        txtRowCol[pinNum, 0].Text = i.ToString();
                        txtRowCol[pinNum, 1].Text = j.ToString();
                        pinNum += 1;
                    }
                }
            }
        }
        private void ResetRowColTextBox()
        {
            for (int i = 0; i <= 2; i++)
            {
                txtRowCol[i, 0].Text = "0";
                txtRowCol[i, 1].Text = "0";
            }
        }
        private void UpdatePinPosition()
        {
            ResetPinBoard();
            for (int i = 0; i <= 2; i++)
            {
                rbtnPins[Convert.ToInt16(txtRowCol[i, 0].Text), Convert.ToInt16(txtRowCol[i, 1].Text)].Checked = true;
            }
            DisableUnselectedPins();

        }


}
}
