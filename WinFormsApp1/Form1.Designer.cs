namespace WinFormsApp1
{
    partial class Calculator
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
            button1=new Button();
            button2=new Button();
            button3=new Button();
            button4=new Button();
            button5=new Button();
            button6=new Button();
            button7=new Button();
            button8=new Button();
            button9=new Button();
            button0=new Button();
            ButtonResult=new Button();
            ButtonPlus=new Button();
            ButtonMin=new Button();
            ButtonDiv=new Button();
            ButtonMul=new Button();
            TextBox=new TextBox();
            ButtonClear=new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font=new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location=new Point(2, 136);
            button1.Name="button1";
            button1.Size=new Size(83, 83);
            button1.TabIndex=0;
            button1.Text="1";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // button2
            // 
            button2.Font=new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location=new Point(91, 136);
            button2.Name="button2";
            button2.Size=new Size(83, 83);
            button2.TabIndex=1;
            button2.Text="2";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // button3
            // 
            button3.Font=new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location=new Point(180, 136);
            button3.Name="button3";
            button3.Size=new Size(83, 83);
            button3.TabIndex=2;
            button3.Text="3";
            button3.UseVisualStyleBackColor=true;
            button3.Click+=button3_Click;
            // 
            // button4
            // 
            button4.Font=new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location=new Point(2, 225);
            button4.Name="button4";
            button4.Size=new Size(83, 83);
            button4.TabIndex=3;
            button4.Text="4";
            button4.UseVisualStyleBackColor=true;
            button4.Click+=button4_Click;
            // 
            // button5
            // 
            button5.Font=new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location=new Point(91, 225);
            button5.Name="button5";
            button5.Size=new Size(83, 83);
            button5.TabIndex=4;
            button5.Text="5";
            button5.UseVisualStyleBackColor=true;
            button5.Click+=button5_Click;
            // 
            // button6
            // 
            button6.Font=new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location=new Point(180, 225);
            button6.Name="button6";
            button6.Size=new Size(83, 83);
            button6.TabIndex=5;
            button6.Text="6";
            button6.UseVisualStyleBackColor=true;
            button6.Click+=button6_Click;
            // 
            // button7
            // 
            button7.Font=new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location=new Point(2, 314);
            button7.Name="button7";
            button7.Size=new Size(83, 83);
            button7.TabIndex=6;
            button7.Text="7";
            button7.UseVisualStyleBackColor=true;
            button7.Click+=button7_Click;
            // 
            // button8
            // 
            button8.Font=new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location=new Point(91, 314);
            button8.Name="button8";
            button8.Size=new Size(83, 83);
            button8.TabIndex=7;
            button8.Text="8";
            button8.UseVisualStyleBackColor=true;
            button8.Click+=button8_Click;
            // 
            // button9
            // 
            button9.Font=new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location=new Point(180, 314);
            button9.Name="button9";
            button9.Size=new Size(83, 83);
            button9.TabIndex=8;
            button9.Text="9";
            button9.UseVisualStyleBackColor=true;
            button9.Click+=button9_Click;
            // 
            // button0
            // 
            button0.Font=new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button0.Location=new Point(2, 403);
            button0.Name="button0";
            button0.Size=new Size(83, 83);
            button0.TabIndex=9;
            button0.Text="0";
            button0.UseVisualStyleBackColor=true;
            button0.Click+=button0_Click;
            // 
            // ButtonResult
            // 
            ButtonResult.Font=new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonResult.Location=new Point(91, 403);
            ButtonResult.Name="ButtonResult";
            ButtonResult.Size=new Size(172, 83);
            ButtonResult.TabIndex=10;
            ButtonResult.Text="=";
            ButtonResult.UseVisualStyleBackColor=true;
            ButtonResult.Click+=ButtonResult_Click;
            // 
            // ButtonPlus
            // 
            ButtonPlus.BackColor=Color.DarkOrange;
            ButtonPlus.Font=new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonPlus.Location=new Point(269, 136);
            ButtonPlus.Name="ButtonPlus";
            ButtonPlus.Size=new Size(95, 127);
            ButtonPlus.TabIndex=11;
            ButtonPlus.Text="+";
            ButtonPlus.UseVisualStyleBackColor=false;
            ButtonPlus.Click+=ButtonPlus_Click;
            // 
            // ButtonMin
            // 
            ButtonMin.BackColor=Color.DarkOrange;
            ButtonMin.Font=new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonMin.Location=new Point(269, 269);
            ButtonMin.Name="ButtonMin";
            ButtonMin.Size=new Size(95, 127);
            ButtonMin.TabIndex=12;
            ButtonMin.Text="-";
            ButtonMin.UseVisualStyleBackColor=false;
            ButtonMin.Click+=ButtonMin_Click;
            // 
            // ButtonDiv
            // 
            ButtonDiv.BackColor=Color.DarkOrange;
            ButtonDiv.Font=new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonDiv.Location=new Point(370, 136);
            ButtonDiv.Name="ButtonDiv";
            ButtonDiv.Size=new Size(95, 127);
            ButtonDiv.TabIndex=13;
            ButtonDiv.Text="/";
            ButtonDiv.UseVisualStyleBackColor=false;
            ButtonDiv.Click+=ButtonDiv_Click;
            // 
            // ButtonMul
            // 
            ButtonMul.BackColor=Color.DarkOrange;
            ButtonMul.Font=new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonMul.Location=new Point(370, 269);
            ButtonMul.Name="ButtonMul";
            ButtonMul.Size=new Size(95, 127);
            ButtonMul.TabIndex=15;
            ButtonMul.Text="*";
            ButtonMul.UseVisualStyleBackColor=false;
            ButtonMul.Click+=ButtonMul_Click;
            // 
            // TextBox
            // 
            TextBox.Font=new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox.Location=new Point(2, 80);
            TextBox.Multiline=true;
            TextBox.Name="TextBox";
            TextBox.Size=new Size(463, 50);
            TextBox.TabIndex=16;
            // 
            // ButtonClear
            // 
            ButtonClear.Font=new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonClear.Location=new Point(269, 403);
            ButtonClear.Name="ButtonClear";
            ButtonClear.Size=new Size(196, 83);
            ButtonClear.TabIndex=17;
            ButtonClear.Text="Clear";
            ButtonClear.UseVisualStyleBackColor=true;
            ButtonClear.Click+=ButtonClear_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(477, 500);
            Controls.Add(ButtonClear);
            Controls.Add(TextBox);
            Controls.Add(ButtonMul);
            Controls.Add(ButtonDiv);
            Controls.Add(ButtonMin);
            Controls.Add(ButtonPlus);
            Controls.Add(ButtonResult);
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
            Name="Calculator";
            Text="Calculator";
            Load+=Form1_Load;
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
        private Button ButtonResult;
        private Button ButtonPlus;
        private Button ButtonMin;
        private Button ButtonDiv;
        private Button ButtonMul;
        private TextBox TextBox;
        private Button ButtonClear;
    }
}