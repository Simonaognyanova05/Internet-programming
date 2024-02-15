
namespace Project
{
    partial class HealthyTipsForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblHealthyTip = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(162, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Покажи здраволовните навици ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(616, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "ЗАТВОРИ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblHealthyTip
            // 
            this.lblHealthyTip.FormattingEnabled = true;
            this.lblHealthyTip.Location = new System.Drawing.Point(82, 233);
            this.lblHealthyTip.Name = "lblHealthyTip";
            this.lblHealthyTip.Size = new System.Drawing.Size(440, 82);
            this.lblHealthyTip.TabIndex = 3;
            this.lblHealthyTip.SelectedIndexChanged += new System.EventHandler(this.lblHealthyTip_SelectedIndexChanged);
            // 
            // HealthyTipsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.orthoindy_a_healthy_environment_could_lead_to_a_healthy_lifestyle;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(727, 474);
            this.Controls.Add(this.lblHealthyTip);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "HealthyTipsForm";
            this.Text = "HealthyTipsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lblHealthyTip;
    }
}