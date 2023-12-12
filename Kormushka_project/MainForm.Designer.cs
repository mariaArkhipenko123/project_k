namespace Kormushka_project
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_change = new System.Windows.Forms.Button();
            this.button_monitoring = new System.Windows.Forms.Button();
            this.addKormushka = new System.Windows.Forms.Button();
            this.button_replenish = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button_replenish);
            this.panel1.Controls.Add(this.addKormushka);
            this.panel1.Controls.Add(this.button_monitoring);
            this.panel1.Controls.Add(this.button_change);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 100);
            this.panel3.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("MS PGothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(767, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(800, 58);
            this.label7.TabIndex = 0;
            this.label7.Text = "Главный экран";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.UseMnemonic = false;
            this.label7.UseWaitCursor = true;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button_change
            // 
            this.button_change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_change.ForeColor = System.Drawing.Color.White;
            this.button_change.Location = new System.Drawing.Point(262, 201);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(221, 55);
            this.button_change.TabIndex = 11;
            this.button_change.Text = "Изменить расписание";
            this.button_change.UseVisualStyleBackColor = false;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // button_monitoring
            // 
            this.button_monitoring.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_monitoring.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_monitoring.ForeColor = System.Drawing.Color.White;
            this.button_monitoring.Location = new System.Drawing.Point(262, 271);
            this.button_monitoring.Name = "button_monitoring";
            this.button_monitoring.Size = new System.Drawing.Size(221, 55);
            this.button_monitoring.TabIndex = 12;
            this.button_monitoring.Text = "Мониторинг";
            this.button_monitoring.UseVisualStyleBackColor = false;
            this.button_monitoring.Click += new System.EventHandler(this.button_monitoring_Click);
            // 
            // addKormushka
            // 
            this.addKormushka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addKormushka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addKormushka.ForeColor = System.Drawing.Color.White;
            this.addKormushka.Location = new System.Drawing.Point(262, 346);
            this.addKormushka.Name = "addKormushka";
            this.addKormushka.Size = new System.Drawing.Size(221, 55);
            this.addKormushka.TabIndex = 13;
            this.addKormushka.Text = "Добавить кормушку";
            this.addKormushka.UseVisualStyleBackColor = false;
            this.addKormushka.Click += new System.EventHandler(this.addKormushka_Click);
            // 
            // button_replenish
            // 
            this.button_replenish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_replenish.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_replenish.ForeColor = System.Drawing.Color.White;
            this.button_replenish.Location = new System.Drawing.Point(262, 125);
            this.button_replenish.Name = "button_replenish";
            this.button_replenish.Size = new System.Drawing.Size(221, 55);
            this.button_replenish.TabIndex = 14;
            this.button_replenish.Text = "Пополнить";
            this.button_replenish.UseVisualStyleBackColor = false;
            this.button_replenish.Click += new System.EventHandler(this.button_replenish_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addKormushka;
        private System.Windows.Forms.Button button_monitoring;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.Button button_replenish;
    }
}