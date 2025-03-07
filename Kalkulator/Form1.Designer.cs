namespace Kalkulator
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonminus = new Button();
            buttonmnozenie = new Button();
            buttonplus = new Button();
            buttondzielenie = new Button();
            buttonrowne = new Button();
            textWynik = new TextBox();
            buttonC = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(175, 117);
            button1.Name = "button1";
            button1.Size = new Size(62, 62);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Cyfra_Click;
            // 
            // button2
            // 
            button2.Location = new Point(243, 117);
            button2.Name = "button2";
            button2.Size = new Size(62, 62);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Cyfra_Click;
            // 
            // button3
            // 
            button3.Location = new Point(311, 117);
            button3.Name = "button3";
            button3.Size = new Size(62, 62);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Cyfra_Click;
            // 
            // button4
            // 
            button4.Location = new Point(175, 185);
            button4.Name = "button4";
            button4.Size = new Size(62, 62);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Cyfra_Click;
            // 
            // button5
            // 
            button5.Location = new Point(243, 185);
            button5.Name = "button5";
            button5.Size = new Size(62, 62);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Cyfra_Click;
            // 
            // button6
            // 
            button6.Location = new Point(311, 185);
            button6.Name = "button6";
            button6.Size = new Size(62, 62);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Cyfra_Click;
            // 
            // button7
            // 
            button7.Location = new Point(175, 253);
            button7.Name = "button7";
            button7.Size = new Size(62, 62);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Cyfra_Click;
            // 
            // button8
            // 
            button8.Location = new Point(243, 253);
            button8.Name = "button8";
            button8.Size = new Size(62, 62);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Cyfra_Click;
            // 
            // button9
            // 
            button9.Location = new Point(311, 253);
            button9.Name = "button9";
            button9.Size = new Size(62, 62);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Cyfra_Click;
            // 
            // button0
            // 
            button0.Location = new Point(243, 321);
            button0.Name = "button0";
            button0.Size = new Size(62, 62);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += Cyfra_Click;
            // 
            // buttonminus
            // 
            buttonminus.Location = new Point(412, 185);
            buttonminus.Name = "buttonminus";
            buttonminus.Size = new Size(62, 62);
            buttonminus.TabIndex = 10;
            buttonminus.Text = "-";
            buttonminus.UseVisualStyleBackColor = true;
            buttonminus.Click += Operacja_Click;
            // 
            // buttonmnozenie
            // 
            buttonmnozenie.Location = new Point(412, 253);
            buttonmnozenie.Name = "buttonmnozenie";
            buttonmnozenie.Size = new Size(62, 62);
            buttonmnozenie.TabIndex = 11;
            buttonmnozenie.Text = "*";
            buttonmnozenie.UseVisualStyleBackColor = true;
            buttonmnozenie.Click += Operacja_Click;
            // 
            // buttonplus
            // 
            buttonplus.Location = new Point(412, 117);
            buttonplus.Name = "buttonplus";
            buttonplus.Size = new Size(62, 62);
            buttonplus.TabIndex = 12;
            buttonplus.Text = "+";
            buttonplus.UseVisualStyleBackColor = true;
            buttonplus.Click += Operacja_Click;
            // 
            // buttondzielenie
            // 
            buttondzielenie.Location = new Point(412, 321);
            buttondzielenie.Name = "buttondzielenie";
            buttondzielenie.Size = new Size(62, 62);
            buttondzielenie.TabIndex = 13;
            buttondzielenie.Text = "/";
            buttondzielenie.UseVisualStyleBackColor = true;
            buttondzielenie.Click += Operacja_Click;
            // 
            // buttonrowne
            // 
            buttonrowne.Location = new Point(492, 213);
            buttonrowne.Name = "buttonrowne";
            buttonrowne.Size = new Size(62, 62);
            buttonrowne.TabIndex = 14;
            buttonrowne.Text = "=";
            buttonrowne.UseVisualStyleBackColor = true;
            buttonrowne.Click += buttonrowne_Click;
            // 
            // textWynik
            // 
            textWynik.Location = new Point(175, 88);
            textWynik.Name = "textWynik";
            textWynik.ReadOnly = true;
            textWynik.Size = new Size(198, 23);
            textWynik.TabIndex = 15;
            textWynik.TextChanged += textWynik_TextChanged;
            // 
            // buttonC
            // 
            buttonC.Location = new Point(412, 35);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(62, 62);
            buttonC.TabIndex = 16;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = true;
            buttonC.Click += buttonC_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonC);
            Controls.Add(textWynik);
            Controls.Add(buttonrowne);
            Controls.Add(buttondzielenie);
            Controls.Add(buttonplus);
            Controls.Add(buttonmnozenie);
            Controls.Add(buttonminus);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonminus;
        private Button buttonmnozenie;
        private Button buttonplus;
        private Button buttondzielenie;
        private Button buttonrowne;
        private TextBox textWynik;
        private Button buttonC;
    }
}
