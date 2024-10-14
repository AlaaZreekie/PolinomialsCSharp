namespace TestDesktop
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtTerm = new TextBox();
            lblAddTerm = new Label();
            txtP2 = new TextBox();
            txtP1 = new TextBox();
            btnWriteResult = new Button();
            lbP2 = new Label();
            lbP1 = new Label();
            cboOption = new ComboBox();
            richTextBox1 = new RichTextBox();
            lblOptions = new Label();
            lblResult = new Label();
            txtPoly = new TextBox();
            txtX = new TextBox();
            lbPolinomial = new Label();
            lbX = new Label();
            btnEval = new Button();
            btnOptionForPoly = new ComboBox();
            richTextBox2 = new RichTextBox();
            SuspendLayout();
            // 
            // txtTerm
            // 
            txtTerm.Location = new Point(47, 189);
            txtTerm.Name = "txtTerm";
            txtTerm.Size = new Size(193, 27);
            txtTerm.TabIndex = 0;
            // 
            // lblAddTerm
            // 
            lblAddTerm.AutoSize = true;
            lblAddTerm.Location = new Point(47, 153);
            lblAddTerm.Name = "lblAddTerm";
            lblAddTerm.Size = new Size(149, 20);
            lblAddTerm.TabIndex = 1;
            lblAddTerm.Text = "Term (degree, factor)";
            lblAddTerm.Click += label1_Click;
            // 
            // txtP2
            // 
            txtP2.Location = new Point(144, 83);
            txtP2.Name = "txtP2";
            txtP2.Size = new Size(271, 27);
            txtP2.TabIndex = 2;
            // 
            // txtP1
            // 
            txtP1.Location = new Point(144, 30);
            txtP1.Name = "txtP1";
            txtP1.Size = new Size(271, 27);
            txtP1.TabIndex = 3;
            // 
            // btnWriteResult
            // 
            btnWriteResult.Location = new Point(47, 232);
            btnWriteResult.Name = "btnWriteResult";
            btnWriteResult.Size = new Size(193, 27);
            btnWriteResult.TabIndex = 4;
            btnWriteResult.Text = "Write";
            btnWriteResult.UseVisualStyleBackColor = true;
            btnWriteResult.Click += btnWriteResult_Click;
            // 
            // lbP2
            // 
            lbP2.AutoSize = true;
            lbP2.Location = new Point(47, 86);
            lbP2.Name = "lbP2";
            lbP2.Size = new Size(25, 20);
            lbP2.TabIndex = 5;
            lbP2.Text = "P2";
            // 
            // lbP1
            // 
            lbP1.AutoSize = true;
            lbP1.Location = new Point(47, 37);
            lbP1.Name = "lbP1";
            lbP1.Size = new Size(25, 20);
            lbP1.TabIndex = 6;
            lbP1.Text = "P1";
            // 
            // cboOption
            // 
            cboOption.FormattingEnabled = true;
            cboOption.Items.AddRange(new object[] { "P1", "-P1", "P2", "-P2", "P1 - P2", "P2 - P1", "P1 + P2", "P1 * P2" });
            cboOption.Location = new Point(354, 202);
            cboOption.Name = "cboOption";
            cboOption.Size = new Size(196, 28);
            cboOption.TabIndex = 7;
            cboOption.Text = "Options";
            cboOption.SelectedIndexChanged += cboOption_SelectedIndexChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(47, 336);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(478, 78);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // lblOptions
            // 
            lblOptions.AutoSize = true;
            lblOptions.Location = new Point(354, 170);
            lblOptions.Name = "lblOptions";
            lblOptions.Size = new Size(61, 20);
            lblOptions.TabIndex = 10;
            lblOptions.Text = "Options";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(47, 301);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(49, 20);
            lblResult.TabIndex = 11;
            lblResult.Text = "Result";
            // 
            // txtPoly
            // 
            txtPoly.Location = new Point(754, 86);
            txtPoly.Name = "txtPoly";
            txtPoly.Size = new Size(125, 27);
            txtPoly.TabIndex = 12;
            // 
            // txtX
            // 
            txtX.Location = new Point(754, 146);
            txtX.Name = "txtX";
            txtX.Size = new Size(125, 27);
            txtX.TabIndex = 13;
            // 
            // lbPolinomial
            // 
            lbPolinomial.AutoSize = true;
            lbPolinomial.Location = new Point(664, 93);
            lbPolinomial.Name = "lbPolinomial";
            lbPolinomial.Size = new Size(82, 20);
            lbPolinomial.TabIndex = 14;
            lbPolinomial.Text = "Polynomial";
            // 
            // lbX
            // 
            lbX.AutoSize = true;
            lbX.Location = new Point(690, 153);
            lbX.Name = "lbX";
            lbX.Size = new Size(16, 20);
            lbX.TabIndex = 15;
            lbX.Text = "x";
            lbX.Click += lbX_Click;
            // 
            // btnEval
            // 
            btnEval.Location = new Point(664, 251);
            btnEval.Name = "btnEval";
            btnEval.Size = new Size(94, 29);
            btnEval.TabIndex = 16;
            btnEval.Text = "Execute";
            btnEval.UseVisualStyleBackColor = true;
            btnEval.Click += btnEval_Click;
            // 
            // btnOptionForPoly
            // 
            btnOptionForPoly.AutoCompleteCustomSource.AddRange(new string[] { "Integration", "Derivation", "Evaluation" });
            btnOptionForPoly.FormattingEnabled = true;
            btnOptionForPoly.Items.AddRange(new object[] { "Evaluation", "Integration", "Derivation" });
            btnOptionForPoly.Location = new Point(664, 202);
            btnOptionForPoly.Name = "btnOptionForPoly";
            btnOptionForPoly.Size = new Size(196, 28);
            btnOptionForPoly.TabIndex = 17;
            btnOptionForPoly.Text = "Options";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(624, 336);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(325, 78);
            richTextBox2.TabIndex = 18;
            richTextBox2.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 450);
            Controls.Add(richTextBox2);
            Controls.Add(btnOptionForPoly);
            Controls.Add(btnEval);
            Controls.Add(lbX);
            Controls.Add(lbPolinomial);
            Controls.Add(txtX);
            Controls.Add(txtPoly);
            Controls.Add(lblResult);
            Controls.Add(lblOptions);
            Controls.Add(richTextBox1);
            Controls.Add(cboOption);
            Controls.Add(lbP1);
            Controls.Add(lbP2);
            Controls.Add(btnWriteResult);
            Controls.Add(txtP1);
            Controls.Add(txtP2);
            Controls.Add(lblAddTerm);
            Controls.Add(txtTerm);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtTerm;
        private Label lblAddTerm;
        private TextBox txtP2;
        private TextBox txtP1;
        private Button btnWriteResult;
        private Label lbP2;
        private Label lbP1;
        private ComboBox cboOption;
        private RichTextBox richTextBox1;
        private Label lblOptions;
        private Label lblResult;
        private TextBox txtPoly;
        private TextBox txtX;
        private Label lbPolinomial;
        private Label lbX;
        private Button btnEval;
        private ComboBox btnOptionForPoly;
        private RichTextBox richTextBox2;
    }
}
