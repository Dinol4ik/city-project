﻿namespace Проект_Отлов_животных
{
    partial class mainForm
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
            this.accountName = new System.Windows.Forms.Label();
            this.AccountBtn = new System.Windows.Forms.Button();
            this.ActBtn = new System.Windows.Forms.Button();
            this.AplicationRegBtn = new System.Windows.Forms.Button();
            this.AddContractBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OrgAddBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OrgSearchBut = new System.Windows.Forms.Button();
            this.SearchApplicationBut = new System.Windows.Forms.Button();
            this.SearchActBut = new System.Windows.Forms.Button();
            this.SearchContractBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accountName
            // 
            this.accountName.AutoSize = true;
            this.accountName.Location = new System.Drawing.Point(733, 47);
            this.accountName.Name = "accountName";
            this.accountName.Size = new System.Drawing.Size(38, 15);
            this.accountName.TabIndex = 1;
            this.accountName.Text = "label1";
            // 
            // AccountBtn
            // 
            this.AccountBtn.Location = new System.Drawing.Point(12, 12);
            this.AccountBtn.Name = "AccountBtn";
            this.AccountBtn.Size = new System.Drawing.Size(156, 23);
            this.AccountBtn.TabIndex = 2;
            this.AccountBtn.Text = "Личный аккаунт";
            this.AccountBtn.UseVisualStyleBackColor = true;
            // 
            // ActBtn
            // 
            this.ActBtn.Location = new System.Drawing.Point(324, 116);
            this.ActBtn.Name = "ActBtn";
            this.ActBtn.Size = new System.Drawing.Size(148, 23);
            this.ActBtn.TabIndex = 3;
            this.ActBtn.Text = "Добавление акта";
            this.ActBtn.UseVisualStyleBackColor = true;
            this.ActBtn.Click += new System.EventHandler(this.ActBtn_Click);
            // 
            // AplicationRegBtn
            // 
            this.AplicationRegBtn.Location = new System.Drawing.Point(140, 116);
            this.AplicationRegBtn.Name = "AplicationRegBtn";
            this.AplicationRegBtn.Size = new System.Drawing.Size(178, 23);
            this.AplicationRegBtn.TabIndex = 4;
            this.AplicationRegBtn.Text = "Регистрация заявки";
            this.AplicationRegBtn.UseVisualStyleBackColor = true;
            this.AplicationRegBtn.Click += new System.EventHandler(this.AplicationRegBtn_Click);
            // 
            // AddContractBut
            // 
            this.AddContractBut.Location = new System.Drawing.Point(478, 116);
            this.AddContractBut.Name = "AddContractBut";
            this.AddContractBut.Size = new System.Drawing.Size(153, 23);
            this.AddContractBut.TabIndex = 5;
            this.AddContractBut.Text = "Добавление контракта";
            this.AddContractBut.UseVisualStyleBackColor = true;
            this.AddContractBut.Click += new System.EventHandler(this.AddContractBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Организация";
            // 
            // OrgAddBtn
            // 
            this.OrgAddBtn.Location = new System.Drawing.Point(12, 116);
            this.OrgAddBtn.Name = "OrgAddBtn";
            this.OrgAddBtn.Size = new System.Drawing.Size(109, 23);
            this.OrgAddBtn.TabIndex = 7;
            this.OrgAddBtn.Text = "Добавление Орг";
            this.OrgAddBtn.UseVisualStyleBackColor = true;
            this.OrgAddBtn.Click += new System.EventHandler(this.OrgAddBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Заявки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Акты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Муниципальный контракт";
            // 
            // OrgSearchBut
            // 
            this.OrgSearchBut.Location = new System.Drawing.Point(12, 145);
            this.OrgSearchBut.Name = "OrgSearchBut";
            this.OrgSearchBut.Size = new System.Drawing.Size(109, 41);
            this.OrgSearchBut.TabIndex = 11;
            this.OrgSearchBut.Text = "Поиск организации";
            this.OrgSearchBut.UseVisualStyleBackColor = true;
            this.OrgSearchBut.Click += new System.EventHandler(this.OrgDeleteBut_Click);
            // 
            // SearchApplicationBut
            // 
            this.SearchApplicationBut.Location = new System.Drawing.Point(140, 145);
            this.SearchApplicationBut.Name = "SearchApplicationBut";
            this.SearchApplicationBut.Size = new System.Drawing.Size(178, 41);
            this.SearchApplicationBut.TabIndex = 12;
            this.SearchApplicationBut.Text = "Список заявок";
            this.SearchApplicationBut.UseVisualStyleBackColor = true;
            this.SearchApplicationBut.Click += new System.EventHandler(this.SearchApplicationBut_Click);
            // 
            // SearchActBut
            // 
            this.SearchActBut.Location = new System.Drawing.Point(324, 145);
            this.SearchActBut.Name = "SearchActBut";
            this.SearchActBut.Size = new System.Drawing.Size(148, 41);
            this.SearchActBut.TabIndex = 13;
            this.SearchActBut.Text = "Список актов";
            this.SearchActBut.UseVisualStyleBackColor = true;
            this.SearchActBut.Click += new System.EventHandler(this.SearchActBut_Click);
            // 
            // SearchContractBut
            // 
            this.SearchContractBut.Location = new System.Drawing.Point(478, 145);
            this.SearchContractBut.Name = "SearchContractBut";
            this.SearchContractBut.Size = new System.Drawing.Size(153, 41);
            this.SearchContractBut.TabIndex = 14;
            this.SearchContractBut.Text = "Список контрактов";
            this.SearchContractBut.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchContractBut);
            this.Controls.Add(this.SearchActBut);
            this.Controls.Add(this.SearchApplicationBut);
            this.Controls.Add(this.OrgSearchBut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OrgAddBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddContractBut);
            this.Controls.Add(this.AplicationRegBtn);
            this.Controls.Add(this.ActBtn);
            this.Controls.Add(this.AccountBtn);
            this.Controls.Add(this.accountName);
            this.Name = "mainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label accountName;
        private Button AccountBtn;
        private Button ActBtn;
        private Button AplicationRegBtn;
        private Button AddContractBut;
        private Label label1;
        private Button OrgAddBtn;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button OrgSearchBut;
        private Button SearchApplicationBut;
        private Button SearchActBut;
        private Button SearchContractBut;
    }
}