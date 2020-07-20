﻿namespace dllArendaJournalAccrualsPenalties
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbObject = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTypeContract = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPeriodCredit = new System.Windows.Forms.ComboBox();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btPrint = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btAcceptD = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chbCongressAccept = new System.Windows.Forms.CheckBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.tbAgreement = new System.Windows.Forms.TextBox();
            this.tbTenant = new System.Windows.Forms.TextBox();
            this.tbItogPenalty = new System.Windows.Forms.TextBox();
            this.lItogoPenalty = new System.Windows.Forms.Label();
            this.nameTenant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTypeContract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAgreements = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPeriodCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSummaCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDatePay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSumma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCountDaysCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrcPenalty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSummaPenalty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cItogPenalty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbObject
            // 
            this.cmbObject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbObject.FormattingEnabled = true;
            this.cmbObject.Location = new System.Drawing.Point(676, 26);
            this.cmbObject.Name = "cmbObject";
            this.cmbObject.Size = new System.Drawing.Size(230, 21);
            this.cmbObject.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Объект аренды";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Тип договора";
            // 
            // cmbTypeContract
            // 
            this.cmbTypeContract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeContract.FormattingEnabled = true;
            this.cmbTypeContract.Location = new System.Drawing.Point(352, 26);
            this.cmbTypeContract.Name = "cmbTypeContract";
            this.cmbTypeContract.Size = new System.Drawing.Size(230, 21);
            this.cmbTypeContract.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Период начисления";
            // 
            // cmbPeriodCredit
            // 
            this.cmbPeriodCredit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodCredit.FormattingEnabled = true;
            this.cmbPeriodCredit.Location = new System.Drawing.Point(131, 26);
            this.cmbPeriodCredit.Name = "cmbPeriodCredit";
            this.cmbPeriodCredit.Size = new System.Drawing.Size(116, 21);
            this.cmbPeriodCredit.TabIndex = 5;
            // 
            // btUpdate
            // 
            this.btUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btUpdate.Image = global::dllArendaJournalAccrualsPenalties.Properties.Resources.reload_8055;
            this.btUpdate.Location = new System.Drawing.Point(1233, 12);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(48, 48);
            this.btUpdate.TabIndex = 11;
            this.btUpdate.UseVisualStyleBackColor = true;
            // 
            // btPrint
            // 
            this.btPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btPrint.Image = global::dllArendaJournalAccrualsPenalties.Properties.Resources.klpq_2511;
            this.btPrint.Location = new System.Drawing.Point(1211, 545);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(32, 32);
            this.btPrint.TabIndex = 12;
            this.btPrint.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.Image = global::dllArendaJournalAccrualsPenalties.Properties.Resources.exit_8633;
            this.btExit.Location = new System.Drawing.Point(1249, 545);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(32, 32);
            this.btExit.TabIndex = 13;
            this.btExit.UseVisualStyleBackColor = true;
            // 
            // btAcceptD
            // 
            this.btAcceptD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAcceptD.Image = global::dllArendaJournalAccrualsPenalties.Properties.Resources.like;
            this.btAcceptD.Location = new System.Drawing.Point(608, 537);
            this.btAcceptD.Name = "btAcceptD";
            this.btAcceptD.Size = new System.Drawing.Size(48, 48);
            this.btAcceptD.TabIndex = 14;
            this.btAcceptD.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(9, 516);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(19, 19);
            this.panel2.TabIndex = 16;
            // 
            // chbCongressAccept
            // 
            this.chbCongressAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chbCongressAccept.AutoSize = true;
            this.chbCongressAccept.Location = new System.Drawing.Point(37, 517);
            this.chbCongressAccept.Name = "chbCongressAccept";
            this.chbCongressAccept.Size = new System.Drawing.Size(149, 17);
            this.chbCongressAccept.TabIndex = 15;
            this.chbCongressAccept.Text = " - подтвержденные пени";
            this.chbCongressAccept.UseVisualStyleBackColor = true;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameTenant,
            this.cTypeContract,
            this.cAgreements,
            this.cPeriodCredit,
            this.cSummaCredit,
            this.cDatePay,
            this.cSumma,
            this.cCountDaysCredit,
            this.cPrcPenalty,
            this.cSummaPenalty,
            this.cItogPenalty});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvData.Location = new System.Drawing.Point(9, 83);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(1272, 424);
            this.dgvData.TabIndex = 17;
            this.dgvData.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvData_ColumnWidthChanged);
            this.dgvData.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvData_RowPostPaint);
            this.dgvData.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvData_RowPrePaint);
            this.dgvData.SelectionChanged += new System.EventHandler(this.dgvData_SelectionChanged);
            // 
            // tbAgreement
            // 
            this.tbAgreement.Location = new System.Drawing.Point(221, 57);
            this.tbAgreement.Name = "tbAgreement";
            this.tbAgreement.Size = new System.Drawing.Size(100, 20);
            this.tbAgreement.TabIndex = 19;
            // 
            // tbTenant
            // 
            this.tbTenant.Location = new System.Drawing.Point(115, 57);
            this.tbTenant.Name = "tbTenant";
            this.tbTenant.Size = new System.Drawing.Size(100, 20);
            this.tbTenant.TabIndex = 20;
            // 
            // tbItogPenalty
            // 
            this.tbItogPenalty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbItogPenalty.Location = new System.Drawing.Point(1181, 513);
            this.tbItogPenalty.Name = "tbItogPenalty";
            this.tbItogPenalty.Size = new System.Drawing.Size(100, 20);
            this.tbItogPenalty.TabIndex = 22;
            // 
            // lItogoPenalty
            // 
            this.lItogoPenalty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lItogoPenalty.AutoSize = true;
            this.lItogoPenalty.Location = new System.Drawing.Point(1138, 516);
            this.lItogoPenalty.Name = "lItogoPenalty";
            this.lItogoPenalty.Size = new System.Drawing.Size(37, 13);
            this.lItogoPenalty.TabIndex = 4;
            this.lItogoPenalty.Text = "Итого";
            // 
            // nameTenant
            // 
            this.nameTenant.DataPropertyName = "nameTenant";
            this.nameTenant.HeaderText = "Арендатор";
            this.nameTenant.Name = "nameTenant";
            this.nameTenant.ReadOnly = true;
            // 
            // cTypeContract
            // 
            this.cTypeContract.HeaderText = "Тип договора";
            this.cTypeContract.Name = "cTypeContract";
            this.cTypeContract.ReadOnly = true;
            // 
            // cAgreements
            // 
            this.cAgreements.HeaderText = "Номер договора";
            this.cAgreements.Name = "cAgreements";
            this.cAgreements.ReadOnly = true;
            // 
            // cPeriodCredit
            // 
            this.cPeriodCredit.HeaderText = "Период долга";
            this.cPeriodCredit.Name = "cPeriodCredit";
            this.cPeriodCredit.ReadOnly = true;
            // 
            // cSummaCredit
            // 
            this.cSummaCredit.HeaderText = "Сумма долга";
            this.cSummaCredit.Name = "cSummaCredit";
            this.cSummaCredit.ReadOnly = true;
            // 
            // cDatePay
            // 
            this.cDatePay.HeaderText = "Дата оплаты";
            this.cDatePay.Name = "cDatePay";
            this.cDatePay.ReadOnly = true;
            // 
            // cSumma
            // 
            this.cSumma.HeaderText = "Сумма оплаты";
            this.cSumma.Name = "cSumma";
            this.cSumma.ReadOnly = true;
            // 
            // cCountDaysCredit
            // 
            this.cCountDaysCredit.HeaderText = "Дней просрочки";
            this.cCountDaysCredit.Name = "cCountDaysCredit";
            this.cCountDaysCredit.ReadOnly = true;
            // 
            // cPrcPenalty
            // 
            this.cPrcPenalty.HeaderText = "% пени";
            this.cPrcPenalty.Name = "cPrcPenalty";
            this.cPrcPenalty.ReadOnly = true;
            // 
            // cSummaPenalty
            // 
            this.cSummaPenalty.HeaderText = "Сумма пени";
            this.cSummaPenalty.Name = "cSummaPenalty";
            this.cSummaPenalty.ReadOnly = true;
            // 
            // cItogPenalty
            // 
            this.cItogPenalty.HeaderText = "Итого пени";
            this.cItogPenalty.Name = "cItogPenalty";
            this.cItogPenalty.ReadOnly = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 597);
            this.Controls.Add(this.tbItogPenalty);
            this.Controls.Add(this.tbAgreement);
            this.Controls.Add(this.tbTenant);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chbCongressAccept);
            this.Controls.Add(this.btAcceptD);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.cmbPeriodCredit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTypeContract);
            this.Controls.Add(this.lItogoPenalty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbObject);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Журнал начисления пени";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbObject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTypeContract;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btAcceptD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chbCongressAccept;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox tbAgreement;
        private System.Windows.Forms.TextBox tbTenant;
        private System.Windows.Forms.TextBox tbItogPenalty;
        private System.Windows.Forms.Label lItogoPenalty;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameTenant;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTypeContract;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAgreements;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPeriodCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSummaCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDatePay;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSumma;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCountDaysCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrcPenalty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSummaPenalty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cItogPenalty;
        private System.Windows.Forms.ComboBox cmbPeriodCredit;
    }
}

