namespace Todo_List
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
            label = new Label();
            list = new CheckedListBox();
            textBox = new TextBox();
            add = new Button();
            clean = new Button();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Tahoma", 17.25F, FontStyle.Bold, GraphicsUnit.Point);
            label.Location = new Point(124, 0);
            label.Name = "label";
            label.Size = new Size(117, 28);
            label.TabIndex = 0;
            label.Text = "Todo List";
            label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // list
            // 
            list.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            list.FormattingEnabled = true;
            list.Location = new Point(32, 32);
            list.Name = "list";
            list.Size = new Size(293, 352);
            list.TabIndex = 1;
            // 
            // textBox
            // 
            textBox.Location = new Point(33, 412);
            textBox.Name = "textBox";
            textBox.Size = new Size(187, 23);
            textBox.TabIndex = 2;
            // 
            // add
            // 
            add.Cursor = Cursors.Hand;
            add.FlatAppearance.BorderSize = 0;
            add.ForeColor = SystemColors.Control;
            add.Image = (Image)resources.GetObject("add.Image");
            add.Location = new Point(226, 399);
            add.Name = "add";
            add.Size = new Size(47, 47);
            add.TabIndex = 3;
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // clean
            // 
            clean.Cursor = Cursors.Hand;
            clean.FlatAppearance.BorderSize = 0;
            clean.ForeColor = SystemColors.Control;
            clean.Image = (Image)resources.GetObject("clean.Image");
            clean.Location = new Point(278, 399);
            clean.Name = "clean";
            clean.Size = new Size(47, 47);
            clean.TabIndex = 4;
            clean.UseVisualStyleBackColor = true;
            clean.Click += clean_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 461);
            Controls.Add(clean);
            Controls.Add(add);
            Controls.Add(textBox);
            Controls.Add(list);
            Controls.Add(label);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Todo List";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private CheckedListBox list;
        private TextBox textBox;
        private Button add;
        private Button clean;
    }
}