namespace _104_Quiz5
{
    partial class Form3
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
            this.btn_triangle = new System.Windows.Forms.Button();
            this.btn_quadrilateral = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_triangle
            // 
            this.btn_triangle.Location = new System.Drawing.Point(156, 157);
            this.btn_triangle.Name = "btn_triangle";
            this.btn_triangle.Size = new System.Drawing.Size(175, 169);
            this.btn_triangle.TabIndex = 0;
            this.btn_triangle.Text = "三角形";
            this.btn_triangle.UseVisualStyleBackColor = true;
            this.btn_triangle.Click += new System.EventHandler(this.btn_triangle_Click);
            // 
            // btn_quadrilateral
            // 
            this.btn_quadrilateral.Location = new System.Drawing.Point(459, 157);
            this.btn_quadrilateral.Name = "btn_quadrilateral";
            this.btn_quadrilateral.Size = new System.Drawing.Size(168, 169);
            this.btn_quadrilateral.TabIndex = 1;
            this.btn_quadrilateral.Text = "四邊形";
            this.btn_quadrilateral.UseVisualStyleBackColor = true;
            this.btn_quadrilateral.Click += new System.EventHandler(this.btn_quadrilateral_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.btn_quadrilateral);
            this.Controls.Add(this.btn_triangle);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_triangle;
        private System.Windows.Forms.Button btn_quadrilateral;
    }
}