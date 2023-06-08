namespace Bingo2
{
    partial class sub
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
            mainTable = new TableLayoutPanel();
            btn2 = new Button();
            btn1 = new Button();
            mainTable.SuspendLayout();
            SuspendLayout();
            // 
            // mainTable
            // 
            mainTable.ColumnCount = 1;
            mainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            mainTable.Controls.Add(btn2, 0, 1);
            mainTable.Controls.Add(btn1, 0, 0);
            mainTable.Dock = DockStyle.Fill;
            mainTable.Location = new Point(0, 0);
            mainTable.Margin = new Padding(0);
            mainTable.Name = "mainTable";
            mainTable.RowCount = 2;
            mainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            mainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            mainTable.Size = new Size(224, 121);
            mainTable.TabIndex = 0;
            // 
            // btn2
            // 
            btn2.Dock = DockStyle.Fill;
            btn2.Font = new Font("メイリオ", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.Location = new Point(0, 60);
            btn2.Margin = new Padding(0);
            btn2.Name = "btn2";
            btn2.Size = new Size(224, 61);
            btn2.TabIndex = 1;
            btn2.Text = "Continue";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Dock = DockStyle.Fill;
            btn1.Font = new Font("メイリオ", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.Location = new Point(0, 0);
            btn1.Margin = new Padding(0);
            btn1.Name = "btn1";
            btn1.Size = new Size(224, 60);
            btn1.TabIndex = 0;
            btn1.Text = "New";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // sub
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(224, 121);
            Controls.Add(mainTable);
            Name = "sub";
            StartPosition = FormStartPosition.Manual;
            Text = "Settings";
            mainTable.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTable;
        private Button btn2;
        private Button btn1;
    }
}