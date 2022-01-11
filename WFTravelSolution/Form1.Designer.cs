
namespace WFTravelSolution
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.priceTravelLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lifeLabel = new System.Windows.Forms.Label();
            this.transportLabel = new System.Windows.Forms.Label();
            this.excursLabel = new System.Windows.Forms.Label();
            this.visaLabel = new System.Windows.Forms.Label();
            this.insuranceLabel = new System.Windows.Forms.Label();
            this.nameTravel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.4F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(86, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(648, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Рассчет стоимости путешествия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(336, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Стоимость:";
            // 
            // priceTravelLabel
            // 
            this.priceTravelLabel.AutoSize = true;
            this.priceTravelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.priceTravelLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.priceTravelLabel.Location = new System.Drawing.Point(399, 298);
            this.priceTravelLabel.Name = "priceTravelLabel";
            this.priceTravelLabel.Size = new System.Drawing.Size(29, 31);
            this.priceTravelLabel.TabIndex = 4;
            this.priceTravelLabel.Text = "0";
            this.priceTravelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(272, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "____________________________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(272, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "____________________________________________";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "РФ",
            "Зарубеж",
            "Экстрим зарубеж",
            "Экстрим РФ"});
            this.comboBox1.Location = new System.Drawing.Point(342, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(166, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Проживание";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(272, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Перелет";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(361, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Экскурсии";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(452, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Визы";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(523, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Страховка";
            // 
            // lifeLabel
            // 
            this.lifeLabel.AutoSize = true;
            this.lifeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lifeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lifeLabel.Location = new System.Drawing.Point(199, 217);
            this.lifeLabel.Name = "lifeLabel";
            this.lifeLabel.Size = new System.Drawing.Size(16, 17);
            this.lifeLabel.TabIndex = 4;
            this.lifeLabel.Text = "0";
            // 
            // transportLabel
            // 
            this.transportLabel.AutoSize = true;
            this.transportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.transportLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.transportLabel.Location = new System.Drawing.Point(293, 217);
            this.transportLabel.Name = "transportLabel";
            this.transportLabel.Size = new System.Drawing.Size(16, 17);
            this.transportLabel.TabIndex = 4;
            this.transportLabel.Text = "0";
            // 
            // excursLabel
            // 
            this.excursLabel.AutoSize = true;
            this.excursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.excursLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.excursLabel.Location = new System.Drawing.Point(387, 217);
            this.excursLabel.Name = "excursLabel";
            this.excursLabel.Size = new System.Drawing.Size(16, 17);
            this.excursLabel.TabIndex = 4;
            this.excursLabel.Text = "0";
            // 
            // visaLabel
            // 
            this.visaLabel.AutoSize = true;
            this.visaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.visaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.visaLabel.Location = new System.Drawing.Point(463, 217);
            this.visaLabel.Name = "visaLabel";
            this.visaLabel.Size = new System.Drawing.Size(16, 17);
            this.visaLabel.TabIndex = 4;
            this.visaLabel.Text = "0";
            // 
            // insuranceLabel
            // 
            this.insuranceLabel.AutoSize = true;
            this.insuranceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.insuranceLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.insuranceLabel.Location = new System.Drawing.Point(550, 217);
            this.insuranceLabel.Name = "insuranceLabel";
            this.insuranceLabel.Size = new System.Drawing.Size(16, 17);
            this.insuranceLabel.TabIndex = 4;
            this.insuranceLabel.Text = "0";
            // 
            // nameTravel
            // 
            this.nameTravel.AutoSize = true;
            this.nameTravel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.nameTravel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameTravel.Location = new System.Drawing.Point(336, 338);
            this.nameTravel.Name = "nameTravel";
            this.nameTravel.Size = new System.Drawing.Size(42, 31);
            this.nameTravel.TabIndex = 4;
            this.nameTravel.Text = "ss";
            this.nameTravel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTravel);
            this.Controls.Add(this.priceTravelLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.insuranceLabel);
            this.Controls.Add(this.visaLabel);
            this.Controls.Add(this.excursLabel);
            this.Controls.Add(this.transportLabel);
            this.Controls.Add(this.lifeLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Агенство путешествий \"Журавушка\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label priceTravelLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lifeLabel;
        private System.Windows.Forms.Label transportLabel;
        private System.Windows.Forms.Label excursLabel;
        private System.Windows.Forms.Label visaLabel;
        private System.Windows.Forms.Label insuranceLabel;
        private System.Windows.Forms.Label nameTravel;
    }
}

