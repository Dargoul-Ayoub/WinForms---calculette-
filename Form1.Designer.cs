namespace calculette
{
    partial class Form1
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label_nbr1 = new System.Windows.Forms.Label();
            this.label_Result = new System.Windows.Forms.Label();
            this.label_nbr2 = new System.Windows.Forms.Label();
            this.textBox_nbr = new System.Windows.Forms.TextBox();
            this.textBox_nbr2 = new System.Windows.Forms.TextBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.button_RMZ = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.label_Operation = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_RC = new System.Windows.Forms.RadioButton();
            this.radioButton_div = new System.Windows.Forms.RadioButton();
            this.radioButton_Mult = new System.Windows.Forms.RadioButton();
            this.radioButton_Sou = new System.Windows.Forms.RadioButton();
            this.radioButton_Add = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label_nbr1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label_Result, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label_nbr2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.textBox_nbr, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBox_nbr2, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.textBox_result, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.button_RMZ, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.button_ok, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label_Operation, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(300, 412);
            this.tableLayoutPanel3.TabIndex = 0;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // label_nbr1
            // 
            this.label_nbr1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_nbr1.AutoSize = true;
            this.label_nbr1.Location = new System.Drawing.Point(3, 0);
            this.label_nbr1.Name = "label_nbr1";
            this.label_nbr1.Size = new System.Drawing.Size(144, 82);
            this.label_nbr1.TabIndex = 0;
            this.label_nbr1.Text = "Nombre 1";
            this.label_nbr1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Result
            // 
            this.label_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Result.AutoSize = true;
            this.label_Result.Location = new System.Drawing.Point(3, 246);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(144, 82);
            this.label_Result.TabIndex = 2;
            this.label_Result.Text = "Result";
            this.label_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_nbr2
            // 
            this.label_nbr2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_nbr2.AutoSize = true;
            this.label_nbr2.Location = new System.Drawing.Point(3, 164);
            this.label_nbr2.Name = "label_nbr2";
            this.label_nbr2.Size = new System.Drawing.Size(144, 82);
            this.label_nbr2.TabIndex = 1;
            this.label_nbr2.Text = "Nombre 2";
            this.label_nbr2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_nbr
            // 
            this.textBox_nbr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_nbr.Location = new System.Drawing.Point(175, 30);
            this.textBox_nbr.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.textBox_nbr.Name = "textBox_nbr";
            this.textBox_nbr.Size = new System.Drawing.Size(100, 20);
            this.textBox_nbr.TabIndex = 3;
            this.textBox_nbr.TextChanged += new System.EventHandler(this.textBox_nbr_TextChanged);
            this.textBox_nbr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_nbr_KeyPress);
            // 
            // textBox_nbr2
            // 
            this.textBox_nbr2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_nbr2.Location = new System.Drawing.Point(175, 194);
            this.textBox_nbr2.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.textBox_nbr2.Name = "textBox_nbr2";
            this.textBox_nbr2.Size = new System.Drawing.Size(100, 20);
            this.textBox_nbr2.TabIndex = 4;
            this.textBox_nbr2.TextChanged += new System.EventHandler(this.textBox_nbr2_TextChanged);
            this.textBox_nbr2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_nbr2_KeyPress);
            // 
            // textBox_result
            // 
            this.textBox_result.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_result.Enabled = false;
            this.textBox_result.Location = new System.Drawing.Point(175, 276);
            this.textBox_result.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(100, 20);
            this.textBox_result.TabIndex = 5;
            // 
            // button_RMZ
            // 
            this.button_RMZ.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_RMZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RMZ.Location = new System.Drawing.Point(37, 358);
            this.button_RMZ.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.button_RMZ.Name = "button_RMZ";
            this.button_RMZ.Size = new System.Drawing.Size(75, 23);
            this.button_RMZ.TabIndex = 6;
            this.button_RMZ.Text = "Remise";
            this.button_RMZ.UseVisualStyleBackColor = true;
            this.button_RMZ.Click += new System.EventHandler(this.button_RMZ_Click);
            // 
            // button_ok
            // 
            this.button_ok.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ok.Location = new System.Drawing.Point(187, 358);
            this.button_ok.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 7;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // label_Operation
            // 
            this.label_Operation.AutoSize = true;
            this.label_Operation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Operation.Location = new System.Drawing.Point(153, 82);
            this.label_Operation.Name = "label_Operation";
            this.label_Operation.Size = new System.Drawing.Size(144, 82);
            this.label_Operation.TabIndex = 8;
            this.label_Operation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(329, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(250, 412);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_RC);
            this.groupBox2.Controls.Add(this.radioButton_div);
            this.groupBox2.Controls.Add(this.radioButton_Mult);
            this.groupBox2.Controls.Add(this.radioButton_Sou);
            this.groupBox2.Controls.Add(this.radioButton_Add);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 194);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operations";
            // 
            // radioButton_RC
            // 
            this.radioButton_RC.AutoSize = true;
            this.radioButton_RC.Location = new System.Drawing.Point(48, 132);
            this.radioButton_RC.Name = "radioButton_RC";
            this.radioButton_RC.Size = new System.Drawing.Size(87, 17);
            this.radioButton_RC.TabIndex = 4;
            this.radioButton_RC.TabStop = true;
            this.radioButton_RC.Text = "Racine Carré";
            this.radioButton_RC.UseVisualStyleBackColor = true;
            this.radioButton_RC.CheckedChanged += new System.EventHandler(this.radioButton_RC_CheckedChanged);
            // 
            // radioButton_div
            // 
            this.radioButton_div.AutoSize = true;
            this.radioButton_div.Location = new System.Drawing.Point(48, 109);
            this.radioButton_div.Name = "radioButton_div";
            this.radioButton_div.Size = new System.Drawing.Size(64, 17);
            this.radioButton_div.TabIndex = 3;
            this.radioButton_div.TabStop = true;
            this.radioButton_div.Text = "divesion";
            this.radioButton_div.UseVisualStyleBackColor = true;
            this.radioButton_div.CheckedChanged += new System.EventHandler(this.radioButton_div_CheckedChanged);
            // 
            // radioButton_Mult
            // 
            this.radioButton_Mult.AutoSize = true;
            this.radioButton_Mult.Location = new System.Drawing.Point(48, 86);
            this.radioButton_Mult.Name = "radioButton_Mult";
            this.radioButton_Mult.Size = new System.Drawing.Size(86, 17);
            this.radioButton_Mult.TabIndex = 2;
            this.radioButton_Mult.TabStop = true;
            this.radioButton_Mult.Text = "Multiplication";
            this.radioButton_Mult.UseVisualStyleBackColor = true;
            this.radioButton_Mult.CheckedChanged += new System.EventHandler(this.radioButton_Mult_CheckedChanged);
            // 
            // radioButton_Sou
            // 
            this.radioButton_Sou.AutoSize = true;
            this.radioButton_Sou.Location = new System.Drawing.Point(48, 63);
            this.radioButton_Sou.Name = "radioButton_Sou";
            this.radioButton_Sou.Size = new System.Drawing.Size(84, 17);
            this.radioButton_Sou.TabIndex = 1;
            this.radioButton_Sou.TabStop = true;
            this.radioButton_Sou.Text = "Soustraction";
            this.radioButton_Sou.UseVisualStyleBackColor = true;
            this.radioButton_Sou.CheckedChanged += new System.EventHandler(this.radioButton_Sou_CheckedChanged);
            // 
            // radioButton_Add
            // 
            this.radioButton_Add.AutoSize = true;
            this.radioButton_Add.Location = new System.Drawing.Point(48, 40);
            this.radioButton_Add.Name = "radioButton_Add";
            this.radioButton_Add.Size = new System.Drawing.Size(63, 17);
            this.radioButton_Add.TabIndex = 0;
            this.radioButton_Add.TabStop = true;
            this.radioButton_Add.Text = "Addition";
            this.radioButton_Add.UseVisualStyleBackColor = true;
            this.radioButton_Add.CheckedChanged += new System.EventHandler(this.radioButton_Add_CheckedChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(579, 412);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calucalette";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label_nbr1;
        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.Label label_nbr2;
        private System.Windows.Forms.TextBox textBox_nbr;
        private System.Windows.Forms.TextBox textBox_nbr2;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button button_RMZ;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Label label_Operation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_RC;
        private System.Windows.Forms.RadioButton radioButton_div;
        private System.Windows.Forms.RadioButton radioButton_Mult;
        private System.Windows.Forms.RadioButton radioButton_Sou;
        private System.Windows.Forms.RadioButton radioButton_Add;
    }
}

