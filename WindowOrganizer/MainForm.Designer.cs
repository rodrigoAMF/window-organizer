namespace WindowOrganizer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_setParam = new System.Windows.Forms.Button();
            this.txt_WindowTitle = new System.Windows.Forms.TextBox();
            this.lbl_WindowTitle = new System.Windows.Forms.Label();
            this.txt_posX = new System.Windows.Forms.TextBox();
            this.lbl_posX = new System.Windows.Forms.Label();
            this.lbl_posY = new System.Windows.Forms.Label();
            this.txt_posY = new System.Windows.Forms.TextBox();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.lbl_heigth = new System.Windows.Forms.Label();
            this.txt_width = new System.Windows.Forms.TextBox();
            this.lbl_width = new System.Windows.Forms.Label();
            this.btn_findWindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_setParam
            // 
            this.btn_setParam.Enabled = false;
            this.btn_setParam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_setParam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_setParam.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setParam.Location = new System.Drawing.Point(79, 389);
            this.btn_setParam.Name = "btn_setParam";
            this.btn_setParam.Size = new System.Drawing.Size(172, 49);
            this.btn_setParam.TabIndex = 0;
            this.btn_setParam.Text = "Set Parameters";
            this.btn_setParam.UseVisualStyleBackColor = true;
            this.btn_setParam.Click += new System.EventHandler(this.btn_setParam_Click);
            // 
            // txt_WindowTitle
            // 
            this.txt_WindowTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_WindowTitle.Location = new System.Drawing.Point(29, 63);
            this.txt_WindowTitle.Name = "txt_WindowTitle";
            this.txt_WindowTitle.Size = new System.Drawing.Size(280, 38);
            this.txt_WindowTitle.TabIndex = 1;
            this.txt_WindowTitle.Text = "SNES";
            // 
            // lbl_WindowTitle
            // 
            this.lbl_WindowTitle.AutoSize = true;
            this.lbl_WindowTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WindowTitle.Location = new System.Drawing.Point(24, 22);
            this.lbl_WindowTitle.Name = "lbl_WindowTitle";
            this.lbl_WindowTitle.Size = new System.Drawing.Size(178, 28);
            this.lbl_WindowTitle.TabIndex = 2;
            this.lbl_WindowTitle.Text = "Target window title";
            // 
            // txt_posX
            // 
            this.txt_posX.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_posX.Location = new System.Drawing.Point(29, 160);
            this.txt_posX.Name = "txt_posX";
            this.txt_posX.Size = new System.Drawing.Size(120, 38);
            this.txt_posX.TabIndex = 3;
            this.txt_posX.Text = "0";
            // 
            // lbl_posX
            // 
            this.lbl_posX.AutoSize = true;
            this.lbl_posX.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_posX.Location = new System.Drawing.Point(27, 119);
            this.lbl_posX.Name = "lbl_posX";
            this.lbl_posX.Size = new System.Drawing.Size(24, 28);
            this.lbl_posX.TabIndex = 4;
            this.lbl_posX.Text = "X";
            // 
            // lbl_posY
            // 
            this.lbl_posY.AutoSize = true;
            this.lbl_posY.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_posY.Location = new System.Drawing.Point(179, 119);
            this.lbl_posY.Name = "lbl_posY";
            this.lbl_posY.Size = new System.Drawing.Size(23, 28);
            this.lbl_posY.TabIndex = 5;
            this.lbl_posY.Text = "Y";
            // 
            // txt_posY
            // 
            this.txt_posY.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_posY.Location = new System.Drawing.Point(187, 160);
            this.txt_posY.Name = "txt_posY";
            this.txt_posY.Size = new System.Drawing.Size(122, 38);
            this.txt_posY.TabIndex = 6;
            this.txt_posY.Text = "0";
            // 
            // txt_height
            // 
            this.txt_height.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_height.Location = new System.Drawing.Point(29, 263);
            this.txt_height.Name = "txt_height";
            this.txt_height.Size = new System.Drawing.Size(120, 38);
            this.txt_height.TabIndex = 7;
            this.txt_height.Text = "440";
            // 
            // lbl_heigth
            // 
            this.lbl_heigth.AutoSize = true;
            this.lbl_heigth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heigth.Location = new System.Drawing.Point(25, 223);
            this.lbl_heigth.Name = "lbl_heigth";
            this.lbl_heigth.Size = new System.Drawing.Size(71, 28);
            this.lbl_heigth.TabIndex = 8;
            this.lbl_heigth.Text = "Height";
            // 
            // txt_width
            // 
            this.txt_width.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_width.Location = new System.Drawing.Point(187, 263);
            this.txt_width.Name = "txt_width";
            this.txt_width.Size = new System.Drawing.Size(120, 38);
            this.txt_width.TabIndex = 9;
            this.txt_width.Text = "440";
            // 
            // lbl_width
            // 
            this.lbl_width.AutoSize = true;
            this.lbl_width.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_width.Location = new System.Drawing.Point(185, 223);
            this.lbl_width.Name = "lbl_width";
            this.lbl_width.Size = new System.Drawing.Size(66, 28);
            this.lbl_width.TabIndex = 10;
            this.lbl_width.Text = "Width";
            // 
            // btn_findWindow
            // 
            this.btn_findWindow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_findWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_findWindow.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_findWindow.Location = new System.Drawing.Point(79, 324);
            this.btn_findWindow.Name = "btn_findWindow";
            this.btn_findWindow.Size = new System.Drawing.Size(172, 49);
            this.btn_findWindow.TabIndex = 11;
            this.btn_findWindow.Text = "Find Window";
            this.btn_findWindow.UseVisualStyleBackColor = true;
            this.btn_findWindow.Click += new System.EventHandler(this.btn_findWindow_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(343, 463);
            this.Controls.Add(this.btn_findWindow);
            this.Controls.Add(this.lbl_width);
            this.Controls.Add(this.txt_width);
            this.Controls.Add(this.lbl_heigth);
            this.Controls.Add(this.txt_height);
            this.Controls.Add(this.txt_posY);
            this.Controls.Add(this.lbl_posY);
            this.Controls.Add(this.lbl_posX);
            this.Controls.Add(this.txt_posX);
            this.Controls.Add(this.lbl_WindowTitle);
            this.Controls.Add(this.txt_WindowTitle);
            this.Controls.Add(this.btn_setParam);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Window Organizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_setParam;
        private System.Windows.Forms.TextBox txt_WindowTitle;
        private System.Windows.Forms.Label lbl_WindowTitle;
        private System.Windows.Forms.TextBox txt_posX;
        private System.Windows.Forms.Label lbl_posX;
        private System.Windows.Forms.Label lbl_posY;
        private System.Windows.Forms.TextBox txt_posY;
        private System.Windows.Forms.TextBox txt_height;
        private System.Windows.Forms.Label lbl_heigth;
        private System.Windows.Forms.TextBox txt_width;
        private System.Windows.Forms.Label lbl_width;
        private System.Windows.Forms.Button btn_findWindow;
    }
}

