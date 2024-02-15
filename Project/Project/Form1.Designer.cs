
namespace Project
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
            this.btnOpenFitnessTracker = new System.Windows.Forms.Button();
            this.btnOpenDietPlanner = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenFitnessTracker
            // 
            this.btnOpenFitnessTracker.BackColor = System.Drawing.Color.White;
            this.btnOpenFitnessTracker.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenFitnessTracker.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnOpenFitnessTracker.Location = new System.Drawing.Point(422, 247);
            this.btnOpenFitnessTracker.Name = "btnOpenFitnessTracker";
            this.btnOpenFitnessTracker.Size = new System.Drawing.Size(210, 49);
            this.btnOpenFitnessTracker.TabIndex = 0;
            this.btnOpenFitnessTracker.Text = "Fitness tracker";
            this.btnOpenFitnessTracker.UseVisualStyleBackColor = false;
            this.btnOpenFitnessTracker.Click += new System.EventHandler(this.btnOpenFitnessTracker_Click);
            // 
            // btnOpenDietPlanner
            // 
            this.btnOpenDietPlanner.BackColor = System.Drawing.Color.White;
            this.btnOpenDietPlanner.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenDietPlanner.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnOpenDietPlanner.Location = new System.Drawing.Point(422, 314);
            this.btnOpenDietPlanner.Name = "btnOpenDietPlanner";
            this.btnOpenDietPlanner.Size = new System.Drawing.Size(210, 52);
            this.btnOpenDietPlanner.TabIndex = 1;
            this.btnOpenDietPlanner.Text = "Диета";
            this.btnOpenDietPlanner.UseVisualStyleBackColor = false;
            this.btnOpenDietPlanner.Click += new System.EventHandler(this.btnOpenDietPlanner_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(422, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "БМИ калкулатор";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.DarkOrange;
            this.button2.Location = new System.Drawing.Point(422, 456);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 58);
            this.button2.TabIndex = 3;
            this.button2.Text = "Покажи здравословни навици";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.stock_vector_healthy_lifestyle_background_219742735;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(667, 598);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOpenDietPlanner);
            this.Controls.Add(this.btnOpenFitnessTracker);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HealthyLifestyle";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFitnessTracker;
        private System.Windows.Forms.Button btnOpenDietPlanner;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

