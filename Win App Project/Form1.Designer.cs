namespace Win_App_Project
{
    partial class Form1
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
            this.rdb_Pationt = new System.Windows.Forms.RadioButton();
            this.rdb_Dockters = new System.Windows.Forms.RadioButton();
            this.rdb_Sections = new System.Windows.Forms.RadioButton();
            this.rdb_services = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_visitTime = new System.Windows.Forms.RadioButton();
            this.rdb_join = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdb_Pationt
            // 
            this.rdb_Pationt.AutoSize = true;
            this.rdb_Pationt.Location = new System.Drawing.Point(147, 18);
            this.rdb_Pationt.Name = "rdb_Pationt";
            this.rdb_Pationt.Size = new System.Drawing.Size(58, 17);
            this.rdb_Pationt.TabIndex = 1;
            this.rdb_Pationt.TabStop = true;
            this.rdb_Pationt.Text = "مریضها";
            this.rdb_Pationt.UseVisualStyleBackColor = true;
            // 
            // rdb_Dockters
            // 
            this.rdb_Dockters.AutoSize = true;
            this.rdb_Dockters.Location = new System.Drawing.Point(147, 42);
            this.rdb_Dockters.Name = "rdb_Dockters";
            this.rdb_Dockters.Size = new System.Drawing.Size(57, 17);
            this.rdb_Dockters.TabIndex = 2;
            this.rdb_Dockters.TabStop = true;
            this.rdb_Dockters.Text = "دکترها";
            this.rdb_Dockters.UseVisualStyleBackColor = true;
            // 
            // rdb_Sections
            // 
            this.rdb_Sections.AutoSize = true;
            this.rdb_Sections.Location = new System.Drawing.Point(147, 67);
            this.rdb_Sections.Name = "rdb_Sections";
            this.rdb_Sections.Size = new System.Drawing.Size(55, 17);
            this.rdb_Sections.TabIndex = 3;
            this.rdb_Sections.TabStop = true;
            this.rdb_Sections.Text = "بخشها";
            this.rdb_Sections.UseVisualStyleBackColor = true;
            // 
            // rdb_services
            // 
            this.rdb_services.AutoSize = true;
            this.rdb_services.Location = new System.Drawing.Point(147, 90);
            this.rdb_services.Name = "rdb_services";
            this.rdb_services.Size = new System.Drawing.Size(54, 17);
            this.rdb_services.TabIndex = 4;
            this.rdb_services.TabStop = true;
            this.rdb_services.Text = "خدمات";
            this.rdb_services.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_visitTime);
            this.groupBox1.Controls.Add(this.rdb_join);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.rdb_Pationt);
            this.groupBox1.Controls.Add(this.rdb_services);
            this.groupBox1.Controls.Add(this.rdb_Dockters);
            this.groupBox1.Controls.Add(this.rdb_Sections);
            this.groupBox1.Location = new System.Drawing.Point(286, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 177);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ورود اطلاعات";
            // 
            // rdb_visitTime
            // 
            this.rdb_visitTime.AutoSize = true;
            this.rdb_visitTime.Location = new System.Drawing.Point(147, 136);
            this.rdb_visitTime.Name = "rdb_visitTime";
            this.rdb_visitTime.Size = new System.Drawing.Size(76, 17);
            this.rdb_visitTime.TabIndex = 7;
            this.rdb_visitTime.TabStop = true;
            this.rdb_visitTime.Text = "زمان ویزیت";
            this.rdb_visitTime.UseVisualStyleBackColor = true;
            // 
            // rdb_join
            // 
            this.rdb_join.AutoSize = true;
            this.rdb_join.Location = new System.Drawing.Point(147, 113);
            this.rdb_join.Name = "rdb_join";
            this.rdb_join.Size = new System.Drawing.Size(84, 17);
            this.rdb_join.TabIndex = 6;
            this.rdb_join.TabStop = true;
            this.rdb_join.Text = "تعریف ترکیب";
            this.rdb_join.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.button2.Location = new System.Drawing.Point(34, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "باز کردن فرم";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 43);
            this.button3.TabIndex = 6;
            this.button3.Text = "لیست بیماران به تفکیک بخش یا سرویس";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(93, 108);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 44);
            this.button4.TabIndex = 7;
            this.button4.Text = "تعداد بیماران در صف هر سرویس";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 364);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rdb_Pationt;
        private System.Windows.Forms.RadioButton rdb_Dockters;
        private System.Windows.Forms.RadioButton rdb_Sections;
        private System.Windows.Forms.RadioButton rdb_services;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rdb_join;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton rdb_visitTime;
    }
}

