
namespace lab6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.K_TextBox = new System.Windows.Forms.MaskedTextBox();
            this.A_TextBox = new System.Windows.Forms.TextBox();
            this.P_TextBox = new System.Windows.Forms.TextBox();
            this.B_TextBox = new System.Windows.Forms.TextBox();
            this.A_label = new System.Windows.Forms.Label();
            this.P_label = new System.Windows.Forms.Label();
            this.K_label = new System.Windows.Forms.Label();
            this.B_label = new System.Windows.Forms.Label();
            this.Equation = new System.Windows.Forms.PictureBox();
            this.Parameters = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Output_Mode = new System.Windows.Forms.ComboBox();
            this.Button_Choose_Color = new System.Windows.Forms.Button();
            this.Draw_Panel = new System.Windows.Forms.Panel();
            this.Output_Mode_Label = new System.Windows.Forms.Label();
            this.Graph_Color_Label = new System.Windows.Forms.Label();
            this.Button_ReDraw = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Equation)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // K_TextBox
            // 
            this.K_TextBox.Location = new System.Drawing.Point(200, 138);
            this.K_TextBox.Name = "K_TextBox";
            this.K_TextBox.Size = new System.Drawing.Size(125, 27);
            this.K_TextBox.TabIndex = 0;
            // 
            // A_TextBox
            // 
            this.A_TextBox.Location = new System.Drawing.Point(29, 138);
            this.A_TextBox.Name = "A_TextBox";
            this.A_TextBox.Size = new System.Drawing.Size(125, 27);
            this.A_TextBox.TabIndex = 1;
            // 
            // P_TextBox
            // 
            this.P_TextBox.Location = new System.Drawing.Point(29, 187);
            this.P_TextBox.Name = "P_TextBox";
            this.P_TextBox.Size = new System.Drawing.Size(125, 27);
            this.P_TextBox.TabIndex = 2;
            // 
            // B_TextBox
            // 
            this.B_TextBox.Location = new System.Drawing.Point(200, 187);
            this.B_TextBox.Name = "B_TextBox";
            this.B_TextBox.Size = new System.Drawing.Size(125, 27);
            this.B_TextBox.TabIndex = 3;
            // 
            // A_label
            // 
            this.A_label.AutoSize = true;
            this.A_label.Location = new System.Drawing.Point(6, 141);
            this.A_label.Name = "A_label";
            this.A_label.Size = new System.Drawing.Size(17, 20);
            this.A_label.TabIndex = 4;
            this.A_label.Text = "a";
            // 
            // P_label
            // 
            this.P_label.AutoSize = true;
            this.P_label.Location = new System.Drawing.Point(6, 190);
            this.P_label.Name = "P_label";
            this.P_label.Size = new System.Drawing.Size(18, 20);
            this.P_label.TabIndex = 5;
            this.P_label.Text = "p";
            // 
            // K_label
            // 
            this.K_label.AutoSize = true;
            this.K_label.Location = new System.Drawing.Point(178, 141);
            this.K_label.Name = "K_label";
            this.K_label.Size = new System.Drawing.Size(16, 20);
            this.K_label.TabIndex = 6;
            this.K_label.Text = "k";
            // 
            // B_label
            // 
            this.B_label.AutoSize = true;
            this.B_label.Location = new System.Drawing.Point(176, 190);
            this.B_label.Name = "B_label";
            this.B_label.Size = new System.Drawing.Size(18, 20);
            this.B_label.TabIndex = 7;
            this.B_label.Text = "b";
            // 
            // Equation
            // 
            this.Equation.Image = ((System.Drawing.Image)(resources.GetObject("Equation.Image")));
            this.Equation.Location = new System.Drawing.Point(6, 26);
            this.Equation.Name = "Equation";
            this.Equation.Size = new System.Drawing.Size(414, 80);
            this.Equation.TabIndex = 8;
            this.Equation.TabStop = false;
            // 
            // Parameters
            // 
            this.Parameters.AutoSize = true;
            this.Parameters.Location = new System.Drawing.Point(6, 109);
            this.Parameters.Name = "Parameters";
            this.Parameters.Size = new System.Drawing.Size(93, 20);
            this.Parameters.TabIndex = 9;
            this.Parameters.Text = "Параметры:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Output_Mode);
            this.groupBox1.Controls.Add(this.Button_Choose_Color);
            this.groupBox1.Controls.Add(this.Draw_Panel);
            this.groupBox1.Controls.Add(this.Output_Mode_Label);
            this.groupBox1.Controls.Add(this.Graph_Color_Label);
            this.groupBox1.Controls.Add(this.Button_ReDraw);
            this.groupBox1.Controls.Add(this.Parameters);
            this.groupBox1.Controls.Add(this.Equation);
            this.groupBox1.Controls.Add(this.B_label);
            this.groupBox1.Controls.Add(this.K_label);
            this.groupBox1.Controls.Add(this.P_label);
            this.groupBox1.Controls.Add(this.A_label);
            this.groupBox1.Controls.Add(this.B_TextBox);
            this.groupBox1.Controls.Add(this.P_TextBox);
            this.groupBox1.Controls.Add(this.A_TextBox);
            this.groupBox1.Controls.Add(this.K_TextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 658);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "График функции";
            // 
            // Output_Mode
            // 
            this.Output_Mode.FormattingEnabled = true;
            this.Output_Mode.Items.AddRange(new object[] {
            "Точки",
            "Линия",
            "Bitmap(Experimental)"});
            this.Output_Mode.Location = new System.Drawing.Point(588, 186);
            this.Output_Mode.Name = "Output_Mode";
            this.Output_Mode.Size = new System.Drawing.Size(181, 28);
            this.Output_Mode.TabIndex = 15;
            this.Output_Mode.SelectedIndexChanged += new System.EventHandler(this.Output_Mode_SelectedIndexChanged);
            // 
            // Button_Choose_Color
            // 
            this.Button_Choose_Color.Location = new System.Drawing.Point(588, 139);
            this.Button_Choose_Color.Name = "Button_Choose_Color";
            this.Button_Choose_Color.Size = new System.Drawing.Size(71, 24);
            this.Button_Choose_Color.TabIndex = 14;
            this.Button_Choose_Color.Text = "...";
            this.Button_Choose_Color.UseVisualStyleBackColor = true;
            this.Button_Choose_Color.Click += new System.EventHandler(this.Button_Choose_Color_Click);
            // 
            // Draw_Panel
            // 
            this.Draw_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Draw_Panel.Location = new System.Drawing.Point(6, 246);
            this.Draw_Panel.Name = "Draw_Panel";
            this.Draw_Panel.Size = new System.Drawing.Size(763, 400);
            this.Draw_Panel.TabIndex = 13;
            this.Draw_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Draw_Panel_Paint);
            // 
            // Output_Mode_Label
            // 
            this.Output_Mode_Label.AutoSize = true;
            this.Output_Mode_Label.Location = new System.Drawing.Point(447, 190);
            this.Output_Mode_Label.Name = "Output_Mode_Label";
            this.Output_Mode_Label.Size = new System.Drawing.Size(112, 20);
            this.Output_Mode_Label.TabIndex = 12;
            this.Output_Mode_Label.Text = "Режим вывода";
            // 
            // Graph_Color_Label
            // 
            this.Graph_Color_Label.AutoSize = true;
            this.Graph_Color_Label.Location = new System.Drawing.Point(447, 141);
            this.Graph_Color_Label.Name = "Graph_Color_Label";
            this.Graph_Color_Label.Size = new System.Drawing.Size(103, 20);
            this.Graph_Color_Label.TabIndex = 11;
            this.Graph_Color_Label.Text = "Цвет графика";
            // 
            // Button_ReDraw
            // 
            this.Button_ReDraw.Location = new System.Drawing.Point(447, 26);
            this.Button_ReDraw.Name = "Button_ReDraw";
            this.Button_ReDraw.Size = new System.Drawing.Size(323, 80);
            this.Button_ReDraw.TabIndex = 10;
            this.Button_ReDraw.Text = "Перерисовать";
            this.Button_ReDraw.UseVisualStyleBackColor = true;
            this.Button_ReDraw.Click += new System.EventHandler(this.Button_ReDraw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 681);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Equation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox K_TextBox;
        private System.Windows.Forms.TextBox A_TextBox;
        private System.Windows.Forms.TextBox P_TextBox;
        private System.Windows.Forms.TextBox B_TextBox;
        private System.Windows.Forms.Label A_label;
        private System.Windows.Forms.Label P_label;
        private System.Windows.Forms.Label K_label;
        private System.Windows.Forms.Label B_label;
        private System.Windows.Forms.PictureBox Equation;
        private System.Windows.Forms.Label Parameters;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Output_Mode;
        private System.Windows.Forms.Button Button_Choose_Color;
        private System.Windows.Forms.Panel Draw_Panel;
        private System.Windows.Forms.Label Output_Mode_Label;
        private System.Windows.Forms.Label Graph_Color_Label;
        private System.Windows.Forms.Button Button_ReDraw;
    }
}

