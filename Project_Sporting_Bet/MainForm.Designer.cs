namespace Project_Sporting_Bet
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
            this.components = new System.ComponentModel.Container();
            this.gamblerNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AddBetbtn = new System.Windows.Forms.Button();
            this.AddMatchbtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.gamblerListView = new System.Windows.Forms.ListView();
            this.gamblerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gamblerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gamblerMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.serializationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamblerErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gamblerBtnReport = new System.Windows.Forms.Button();
            this.ComboMain = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamblerErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gamblerNameTextBox
            // 
            this.gamblerNameTextBox.Location = new System.Drawing.Point(489, 242);
            this.gamblerNameTextBox.Name = "gamblerNameTextBox";
            this.gamblerNameTextBox.Size = new System.Drawing.Size(244, 22);
            this.gamblerNameTextBox.TabIndex = 0;
            this.gamblerNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gambler Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddBetbtn
            // 
            this.AddBetbtn.Location = new System.Drawing.Point(379, 157);
            this.AddBetbtn.Name = "AddBetbtn";
            this.AddBetbtn.Size = new System.Drawing.Size(169, 23);
            this.AddBetbtn.TabIndex = 6;
            this.AddBetbtn.Text = "Add Bet";
            this.AddBetbtn.UseVisualStyleBackColor = true;
            this.AddBetbtn.Click += new System.EventHandler(this.AddBetbtn_Click);
            this.AddBetbtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddBetbtn_KeyDown);
            // 
            // AddMatchbtn
            // 
            this.AddMatchbtn.Location = new System.Drawing.Point(598, 157);
            this.AddMatchbtn.Name = "AddMatchbtn";
            this.AddMatchbtn.Size = new System.Drawing.Size(135, 23);
            this.AddMatchbtn.TabIndex = 7;
            this.AddMatchbtn.Text = "Add Match";
            this.AddMatchbtn.UseVisualStyleBackColor = true;
            this.AddMatchbtn.Click += new System.EventHandler(this.AddMatchbtn_Click);
            this.AddMatchbtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddMatchbtn_KeyDown);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(598, 390);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(489, 301);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(244, 22);
            this.numericUpDown.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Id";
            // 
            // gamblerListView
            // 
            this.gamblerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.gamblerName,
            this.gamblerId});
            this.gamblerListView.FullRowSelect = true;
            this.gamblerListView.GridLines = true;
            this.gamblerListView.HideSelection = false;
            this.gamblerListView.Location = new System.Drawing.Point(27, 154);
            this.gamblerListView.MaximumSize = new System.Drawing.Size(385, 280);
            this.gamblerListView.Name = "gamblerListView";
            this.gamblerListView.Size = new System.Drawing.Size(297, 280);
            this.gamblerListView.TabIndex = 11;
            this.gamblerListView.UseCompatibleStateImageBehavior = false;
            this.gamblerListView.View = System.Windows.Forms.View.Details;
            this.gamblerListView.SelectedIndexChanged += new System.EventHandler(this.gamblerListView_SelectedIndexChanged);
            // 
            // gamblerName
            // 
            this.gamblerName.Text = "Name";
            this.gamblerName.Width = 149;
            // 
            // gamblerId
            // 
            this.gamblerId.Text = "ID";
            this.gamblerId.Width = 234;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gamblerMenuStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(904, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gamblerMenuStrip
            // 
            this.gamblerMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializationToolStripMenuItem,
            this.deserializationToolStripMenuItem});
            this.gamblerMenuStrip.Name = "gamblerMenuStrip";
            this.gamblerMenuStrip.Size = new System.Drawing.Size(64, 24);
            this.gamblerMenuStrip.Text = "Binary";
            // 
            // serializationToolStripMenuItem
            // 
            this.serializationToolStripMenuItem.Name = "serializationToolStripMenuItem";
            this.serializationToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.serializationToolStripMenuItem.Text = "Serialization";
            this.serializationToolStripMenuItem.Click += new System.EventHandler(this.serializationToolStripMenuItem_Click);
            // 
            // deserializationToolStripMenuItem
            // 
            this.deserializationToolStripMenuItem.Name = "deserializationToolStripMenuItem";
            this.deserializationToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.deserializationToolStripMenuItem.Text = "Deserialization";
            this.deserializationToolStripMenuItem.Click += new System.EventHandler(this.deserializationToolStripMenuItem_Click);
            // 
            // gamblerErrorProvider
            // 
            this.gamblerErrorProvider.ContainerControl = this;
            // 
            // gamblerBtnReport
            // 
            this.gamblerBtnReport.Location = new System.Drawing.Point(480, 75);
            this.gamblerBtnReport.Name = "gamblerBtnReport";
            this.gamblerBtnReport.Size = new System.Drawing.Size(169, 23);
            this.gamblerBtnReport.TabIndex = 13;
            this.gamblerBtnReport.Text = "Make a report";
            this.gamblerBtnReport.UseVisualStyleBackColor = true;
            this.gamblerBtnReport.Click += new System.EventHandler(this.gamblerBtnReport_Click);
            // 
            // ComboMain
            // 
            this.ComboMain.FormattingEnabled = true;
            this.ComboMain.Location = new System.Drawing.Point(732, 31);
            this.ComboMain.Name = "ComboMain";
            this.ComboMain.Size = new System.Drawing.Size(121, 24);
            this.ComboMain.TabIndex = 14;
            this.ComboMain.SelectedIndexChanged += new System.EventHandler(this.ComboMain_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(904, 475);
            this.Controls.Add(this.ComboMain);
            this.Controls.Add(this.gamblerBtnReport);
            this.Controls.Add(this.gamblerListView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.AddMatchbtn);
            this.Controls.Add(this.AddBetbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gamblerNameTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddBetbtn_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamblerErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gamblerNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddBetbtn;
        private System.Windows.Forms.Button AddMatchbtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView gamblerListView;
        private System.Windows.Forms.ColumnHeader gamblerName;
        private System.Windows.Forms.ColumnHeader gamblerId;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gamblerMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem serializationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializationToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider gamblerErrorProvider;
        private System.Windows.Forms.Button gamblerBtnReport;
        private System.Windows.Forms.ComboBox ComboMain;
    }
}

