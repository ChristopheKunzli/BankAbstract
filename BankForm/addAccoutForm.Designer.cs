namespace BankForm
{
    partial class frmAddAccount: Form
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.lblRef = new System.Windows.Forms.Label();
            this.radCommonAccount = new System.Windows.Forms.RadioButton();
            this.radSavingAccount = new System.Windows.Forms.RadioButton();
            this.numBalance = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panCom = new System.Windows.Forms.Panel();
            this.numOverdraft = new System.Windows.Forms.NumericUpDown();
            this.lblOverdraft = new System.Windows.Forms.Label();
            this.panSaving = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.numInterest = new System.Windows.Forms.NumericUpDown();
            this.lblSaving = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numBalance)).BeginInit();
            this.panCom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOverdraft)).BeginInit();
            this.panSaving.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterest)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(25, 191);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Créer";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtRef
            // 
            this.txtRef.Location = new System.Drawing.Point(107, 18);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(100, 23);
            this.txtRef.TabIndex = 1;
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.Location = new System.Drawing.Point(25, 21);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(59, 15);
            this.lblRef.TabIndex = 2;
            this.lblRef.Text = "Reference";
            // 
            // radCommonAccount
            // 
            this.radCommonAccount.AutoSize = true;
            this.radCommonAccount.Location = new System.Drawing.Point(25, 93);
            this.radCommonAccount.Name = "radCommonAccount";
            this.radCommonAccount.Size = new System.Drawing.Size(106, 19);
            this.radCommonAccount.TabIndex = 3;
            this.radCommonAccount.TabStop = true;
            this.radCommonAccount.Text = "Compte simple";
            this.radCommonAccount.UseVisualStyleBackColor = true;
            this.radCommonAccount.Click += new System.EventHandler(this.radCommonAccount_Click);
            // 
            // radSavingAccount
            // 
            this.radSavingAccount.AutoSize = true;
            this.radSavingAccount.Location = new System.Drawing.Point(25, 118);
            this.radSavingAccount.Name = "radSavingAccount";
            this.radSavingAccount.Size = new System.Drawing.Size(124, 19);
            this.radSavingAccount.TabIndex = 4;
            this.radSavingAccount.TabStop = true;
            this.radSavingAccount.Text = "Compte d\'épargne";
            this.radSavingAccount.UseVisualStyleBackColor = true;
            this.radSavingAccount.Click += new System.EventHandler(this.radSavingAccount_Click);
            // 
            // numBalance
            // 
            this.numBalance.Location = new System.Drawing.Point(107, 47);
            this.numBalance.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numBalance.Name = "numBalance";
            this.numBalance.Size = new System.Drawing.Size(100, 23);
            this.numBalance.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Solde de base";
            // 
            // panCom
            // 
            this.panCom.Controls.Add(this.numOverdraft);
            this.panCom.Controls.Add(this.lblOverdraft);
            this.panCom.Location = new System.Drawing.Point(180, 143);
            this.panCom.Name = "panCom";
            this.panCom.Size = new System.Drawing.Size(185, 44);
            this.panCom.TabIndex = 7;
            // 
            // numOverdraft
            // 
            this.numOverdraft.Location = new System.Drawing.Point(73, 12);
            this.numOverdraft.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numOverdraft.Name = "numOverdraft";
            this.numOverdraft.Size = new System.Drawing.Size(98, 23);
            this.numOverdraft.TabIndex = 1;
            // 
            // lblOverdraft
            // 
            this.lblOverdraft.AutoSize = true;
            this.lblOverdraft.Location = new System.Drawing.Point(3, 14);
            this.lblOverdraft.Name = "lblOverdraft";
            this.lblOverdraft.Size = new System.Drawing.Size(40, 15);
            this.lblOverdraft.TabIndex = 0;
            this.lblOverdraft.Text = "Limite";
            // 
            // panSaving
            // 
            this.panSaving.Controls.Add(this.label2);
            this.panSaving.Controls.Add(this.numInterest);
            this.panSaving.Controls.Add(this.lblSaving);
            this.panSaving.Location = new System.Drawing.Point(180, 93);
            this.panSaving.Name = "panSaving";
            this.panSaving.Size = new System.Drawing.Size(185, 44);
            this.panSaving.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "%";
            // 
            // numInterest
            // 
            this.numInterest.Location = new System.Drawing.Point(87, 12);
            this.numInterest.Name = "numInterest";
            this.numInterest.Size = new System.Drawing.Size(61, 23);
            this.numInterest.TabIndex = 1;
            // 
            // lblSaving
            // 
            this.lblSaving.AutoSize = true;
            this.lblSaving.Location = new System.Drawing.Point(3, 14);
            this.lblSaving.Name = "lblSaving";
            this.lblSaving.Size = new System.Drawing.Size(78, 15);
            this.lblSaving.TabIndex = 0;
            this.lblSaving.Text = "Taux d\'intéret";
            // 
            // frmAddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 225);
            this.Controls.Add(this.panSaving);
            this.Controls.Add(this.panCom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numBalance);
            this.Controls.Add(this.radSavingAccount);
            this.Controls.Add(this.radCommonAccount);
            this.Controls.Add(this.lblRef);
            this.Controls.Add(this.txtRef);
            this.Controls.Add(this.btnCreate);
            this.Name = "frmAddAccount";
            this.Text = "Créer un compte";
            this.Load += new System.EventHandler(this.frmAddAccoutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBalance)).EndInit();
            this.panCom.ResumeLayout(false);
            this.panCom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOverdraft)).EndInit();
            this.panSaving.ResumeLayout(false);
            this.panSaving.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCreate;
        private TextBox txtRef;
        private Label lblRef;
        private RadioButton radCommonAccount;
        private RadioButton radSavingAccount;
        private NumericUpDown numBalance;
        private Label label1;
        private Panel panCom;
        private Label lblOverdraft;
        private NumericUpDown numOverdraft;
        private Panel panSaving;
        private NumericUpDown numInterest;
        private Label lblSaving;
        private Label label2;
    }
}