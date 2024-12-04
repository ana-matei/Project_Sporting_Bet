namespace Project_Sporting_Bet
{
    partial class AddBet
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.betTeamTextBox = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.CancelbtnAddBets = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.errorAmount = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorBet = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderBetTeam = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBetTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bet Team";
            // 
            // betTeamTextBox
            // 
            this.betTeamTextBox.Location = new System.Drawing.Point(125, 123);
            this.betTeamTextBox.Name = "betTeamTextBox";
            this.betTeamTextBox.Size = new System.Drawing.Size(100, 22);
            this.betTeamTextBox.TabIndex = 3;
            this.betTeamTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.betTeamTextBox_Validating);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(125, 23);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Validating += new System.ComponentModel.CancelEventHandler(this.numericUpDown1_Validating);
            // 
            // CancelbtnAddBets
            // 
            this.CancelbtnAddBets.Location = new System.Drawing.Point(72, 182);
            this.CancelbtnAddBets.Name = "CancelbtnAddBets";
            this.CancelbtnAddBets.Size = new System.Drawing.Size(75, 23);
            this.CancelbtnAddBets.TabIndex = 6;
            this.CancelbtnAddBets.Text = "Cancel";
            this.CancelbtnAddBets.UseVisualStyleBackColor = true;
            this.CancelbtnAddBets.Click += new System.EventHandler(this.CancelbtnAddBets_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveBtn.Location = new System.Drawing.Point(279, 182);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(125, 71);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 22);
            this.amountTextBox.TabIndex = 8;
            this.amountTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.amountTextBox_Validating);
            // 
            // errorAmount
            // 
            this.errorAmount.ContainerControl = this;
            // 
            // errorBet
            // 
            this.errorBet.ContainerControl = this;
            // 
            // errorProviderBetTeam
            // 
            this.errorProviderBetTeam.ContainerControl = this;
            // 
            // AddBet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 237);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CancelbtnAddBets);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.betTeamTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddBet";
            this.Text = "AddBetForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBetTeam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox betTeamTextBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button CancelbtnAddBets;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.ErrorProvider errorAmount;
        private System.Windows.Forms.ErrorProvider errorBet;
        private System.Windows.Forms.ErrorProvider errorProviderBetTeam;
    }
}