namespace _104_Quiz5
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReset = new System.Windows.Forms.Button();
            this.grpBoxVisualPinBoard = new System.Windows.Forms.GroupBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.grpBoxCoordonate = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpBoxPinBoard = new System.Windows.Forms.GroupBox();
            this.btnCreatePinBoard = new System.Windows.Forms.Button();
            this.txtYInterval = new System.Windows.Forms.TextBox();
            this.txtCols = new System.Windows.Forms.TextBox();
            this.txtXInterval = new System.Windows.Forms.TextBox();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBoxCoordonate.SuspendLayout();
            this.grpBoxPinBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(952, 442);
            this.btnReset.Margin = new System.Windows.Forms.Padding(6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(132, 46);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // grpBoxVisualPinBoard
            // 
            this.grpBoxVisualPinBoard.Location = new System.Drawing.Point(952, 27);
            this.grpBoxVisualPinBoard.Margin = new System.Windows.Forms.Padding(6);
            this.grpBoxVisualPinBoard.Name = "grpBoxVisualPinBoard";
            this.grpBoxVisualPinBoard.Padding = new System.Windows.Forms.Padding(6);
            this.grpBoxVisualPinBoard.Size = new System.Drawing.Size(866, 400);
            this.grpBoxVisualPinBoard.TabIndex = 9;
            this.grpBoxVisualPinBoard.TabStop = false;
            this.grpBoxVisualPinBoard.Text = "Visualization of PinBoard";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(952, 539);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(6);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(717, 276);
            this.txtMessage.TabIndex = 8;
            // 
            // grpBoxCoordonate
            // 
            this.grpBoxCoordonate.Controls.Add(this.btnCalculate);
            this.grpBoxCoordonate.Controls.Add(this.label8);
            this.grpBoxCoordonate.Controls.Add(this.label7);
            this.grpBoxCoordonate.Controls.Add(this.label6);
            this.grpBoxCoordonate.Controls.Add(this.label5);
            this.grpBoxCoordonate.Location = new System.Drawing.Point(15, 365);
            this.grpBoxCoordonate.Margin = new System.Windows.Forms.Padding(6);
            this.grpBoxCoordonate.Name = "grpBoxCoordonate";
            this.grpBoxCoordonate.Padding = new System.Windows.Forms.Padding(6);
            this.grpBoxCoordonate.Size = new System.Drawing.Size(897, 530);
            this.grpBoxCoordonate.TabIndex = 7;
            this.grpBoxCoordonate.TabStop = false;
            this.grpBoxCoordonate.Text = "Coordinates of Pionts";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(629, 464);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(6);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(255, 46);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(624, 62);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Col";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Row";
            // 
            // grpBoxPinBoard
            // 
            this.grpBoxPinBoard.Controls.Add(this.btnCreatePinBoard);
            this.grpBoxPinBoard.Controls.Add(this.txtYInterval);
            this.grpBoxPinBoard.Controls.Add(this.txtCols);
            this.grpBoxPinBoard.Controls.Add(this.txtXInterval);
            this.grpBoxPinBoard.Controls.Add(this.txtRows);
            this.grpBoxPinBoard.Controls.Add(this.label4);
            this.grpBoxPinBoard.Controls.Add(this.label2);
            this.grpBoxPinBoard.Controls.Add(this.label3);
            this.grpBoxPinBoard.Controls.Add(this.label1);
            this.grpBoxPinBoard.Location = new System.Drawing.Point(15, 27);
            this.grpBoxPinBoard.Margin = new System.Windows.Forms.Padding(6);
            this.grpBoxPinBoard.Name = "grpBoxPinBoard";
            this.grpBoxPinBoard.Padding = new System.Windows.Forms.Padding(6);
            this.grpBoxPinBoard.Size = new System.Drawing.Size(897, 326);
            this.grpBoxPinBoard.TabIndex = 6;
            this.grpBoxPinBoard.TabStop = false;
            this.grpBoxPinBoard.Text = "Properties of PinBoard";
            // 
            // btnCreatePinBoard
            // 
            this.btnCreatePinBoard.Location = new System.Drawing.Point(629, 269);
            this.btnCreatePinBoard.Margin = new System.Windows.Forms.Padding(6);
            this.btnCreatePinBoard.Name = "btnCreatePinBoard";
            this.btnCreatePinBoard.Size = new System.Drawing.Size(255, 46);
            this.btnCreatePinBoard.TabIndex = 8;
            this.btnCreatePinBoard.Text = "Create PinBoard";
            this.btnCreatePinBoard.UseVisualStyleBackColor = true;
            this.btnCreatePinBoard.Click += new System.EventHandler(this.btnCreatePinBoard_Click_1);
            // 
            // txtYInterval
            // 
            this.txtYInterval.Location = new System.Drawing.Point(533, 178);
            this.txtYInterval.Margin = new System.Windows.Forms.Padding(6);
            this.txtYInterval.Name = "txtYInterval";
            this.txtYInterval.Size = new System.Drawing.Size(212, 36);
            this.txtYInterval.TabIndex = 7;
            this.txtYInterval.Text = "1.0";
            // 
            // txtCols
            // 
            this.txtCols.Location = new System.Drawing.Point(533, 46);
            this.txtCols.Margin = new System.Windows.Forms.Padding(6);
            this.txtCols.Name = "txtCols";
            this.txtCols.Size = new System.Drawing.Size(212, 36);
            this.txtCols.TabIndex = 5;
            this.txtCols.Text = "10";
            // 
            // txtXInterval
            // 
            this.txtXInterval.Location = new System.Drawing.Point(128, 178);
            this.txtXInterval.Margin = new System.Windows.Forms.Padding(6);
            this.txtXInterval.Name = "txtXInterval";
            this.txtXInterval.Size = new System.Drawing.Size(212, 36);
            this.txtXInterval.TabIndex = 6;
            this.txtXInterval.Text = "1.0";
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(128, 46);
            this.txtRows.Margin = new System.Windows.Forms.Padding(6);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(212, 36);
            this.txtRows.TabIndex = 4;
            this.txtRows.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "YInterval";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cols";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "XInterval";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rows";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1826, 869);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grpBoxVisualPinBoard);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.grpBoxCoordonate);
            this.Controls.Add(this.grpBoxPinBoard);
            this.Name = "Form2";
            this.Text = "Form2";
            this.grpBoxCoordonate.ResumeLayout(false);
            this.grpBoxCoordonate.PerformLayout();
            this.grpBoxPinBoard.ResumeLayout(false);
            this.grpBoxPinBoard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grpBoxVisualPinBoard;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.GroupBox grpBoxCoordonate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpBoxPinBoard;
        private System.Windows.Forms.Button btnCreatePinBoard;
        private System.Windows.Forms.TextBox txtYInterval;
        private System.Windows.Forms.TextBox txtCols;
        private System.Windows.Forms.TextBox txtXInterval;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}