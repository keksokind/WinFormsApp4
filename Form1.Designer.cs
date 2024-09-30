namespace WinFormsApp4
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
            label1 = new Label();
            label2 = new Label();
            WeightInput = new TextBox();
            HeightInput = new TextBox();
            Calculatebtn = new Button();
            Output = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 0;
            label1.Text = "Weight (pounds)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 1;
            label2.Text = "Height (inches)";
            // 
            // WeightInput
            // 
            WeightInput.Location = new Point(159, 20);
            WeightInput.Name = "WeightInput";
            WeightInput.Size = new Size(125, 27);
            WeightInput.TabIndex = 2;
            WeightInput.TextChanged += textBox1_TextChanged;
            // 
            // HeightInput
            // 
            HeightInput.Location = new Point(159, 77);
            HeightInput.Name = "HeightInput";
            HeightInput.Size = new Size(125, 27);
            HeightInput.TabIndex = 3;
            HeightInput.TextChanged += HeightInput_TextChanged;
            // 
            // Calculatebtn
            // 
            Calculatebtn.Location = new Point(309, 77);
            Calculatebtn.Name = "Calculatebtn";
            Calculatebtn.Size = new Size(94, 27);
            Calculatebtn.TabIndex = 4;
            Calculatebtn.Text = "Calculate";
            Calculatebtn.UseVisualStyleBackColor = true;
            Calculatebtn.Click += Calculatebtn_Click;
            // 
            // Output
            // 
            Output.AutoSize = true;
            Output.Location = new Point(12, 123);
            Output.Name = "Output";
            Output.Size = new Size(0, 20);
            Output.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Output);
            Controls.Add(Calculatebtn);
            Controls.Add(HeightInput);
            Controls.Add(WeightInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox WeightInput;
        private TextBox HeightInput;
        private Button Calculatebtn;
        private Label Output;
    }
}
