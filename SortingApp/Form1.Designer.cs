namespace SortingApp
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
            Czas = new Label();
            GenerujLiczby = new CheckBox();
            NumberGenerator = new NumericUpDown();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SBubble = new Button();
            SSelection = new Button();
            SInsertion = new Button();
            SMerge = new Button();
            SQuick = new Button();
            Generate = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)NumberGenerator).BeginInit();
            SuspendLayout();
            // 
            // Czas
            // 
            Czas.AutoSize = true;
            Czas.Location = new Point(465, 211);
            Czas.Name = "Czas";
            Czas.Size = new Size(42, 20);
            Czas.TabIndex = 0;
            Czas.Text = "Czas:";
            // 
            // GenerujLiczby
            // 
            GenerujLiczby.AutoSize = true;
            GenerujLiczby.Location = new Point(328, 48);
            GenerujLiczby.Name = "GenerujLiczby";
            GenerujLiczby.Size = new Size(124, 24);
            GenerujLiczby.TabIndex = 1;
            GenerujLiczby.Text = "Generuj liczby";
            GenerujLiczby.UseVisualStyleBackColor = true;
            // 
            // NumberGenerator
            // 
            NumberGenerator.Location = new Point(535, 49);
            NumberGenerator.Name = "NumberGenerator";
            NumberGenerator.Size = new Size(150, 27);
            NumberGenerator.TabIndex = 2;
            NumberGenerator.ValueChanged += NumberGenerator_ValueChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(81, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(81, 211);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            // 
            // SBubble
            // 
            SBubble.Location = new Point(31, 321);
            SBubble.Name = "SBubble";
            SBubble.Size = new Size(112, 29);
            SBubble.TabIndex = 5;
            SBubble.Text = "SBubble";
            SBubble.UseVisualStyleBackColor = true;
            SBubble.Click += SBubble_Click;
            // 
            // SSelection
            // 
            SSelection.Location = new Point(179, 321);
            SSelection.Name = "SSelection";
            SSelection.Size = new Size(114, 29);
            SSelection.TabIndex = 6;
            SSelection.Text = "SSelection";
            SSelection.UseVisualStyleBackColor = true;
            SSelection.Click += SSelection_Click;
            // 
            // SInsertion
            // 
            SInsertion.Location = new Point(333, 321);
            SInsertion.Name = "SInsertion";
            SInsertion.Size = new Size(119, 29);
            SInsertion.TabIndex = 7;
            SInsertion.Text = "SInsertion";
            SInsertion.UseVisualStyleBackColor = true;
            SInsertion.Click += SInsertion_Click;
            // 
            // SMerge
            // 
            SMerge.Location = new Point(493, 321);
            SMerge.Name = "SMerge";
            SMerge.Size = new Size(119, 29);
            SMerge.TabIndex = 8;
            SMerge.Text = "SMerge";
            SMerge.UseVisualStyleBackColor = true;
            SMerge.Click += SMerge_Click;
            // 
            // SQuick
            // 
            SQuick.Location = new Point(648, 321);
            SQuick.Name = "SQuick";
            SQuick.Size = new Size(115, 29);
            SQuick.TabIndex = 9;
            SQuick.Text = "SQuick";
            SQuick.UseVisualStyleBackColor = true;
            SQuick.Click += SQuick_Click;
            // 
            // Generate
            // 
            Generate.Location = new Point(577, 127);
            Generate.Name = "Generate";
            Generate.Size = new Size(94, 29);
            Generate.TabIndex = 10;
            Generate.Text = "Generate";
            Generate.UseVisualStyleBackColor = true;
            Generate.Click += Generate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(577, 214);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(Generate);
            Controls.Add(SQuick);
            Controls.Add(SMerge);
            Controls.Add(SInsertion);
            Controls.Add(SSelection);
            Controls.Add(SBubble);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(NumberGenerator);
            Controls.Add(GenerujLiczby);
            Controls.Add(Czas);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NumberGenerator).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Czas;
        private CheckBox GenerujLiczby;
        private NumericUpDown NumberGenerator;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button SBubble;
        private Button SSelection;
        private Button SInsertion;
        private Button SMerge;
        private Button SQuick;
        private Button Generate;
        private Label label2;
    }
}