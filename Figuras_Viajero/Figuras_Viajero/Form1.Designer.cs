namespace Figuras_Viajero
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttongenerate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttontrain = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonsom = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(43, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttongenerate
            // 
            this.buttongenerate.Location = new System.Drawing.Point(584, 62);
            this.buttongenerate.Name = "buttongenerate";
            this.buttongenerate.Size = new System.Drawing.Size(75, 23);
            this.buttongenerate.TabIndex = 1;
            this.buttongenerate.Text = "Generar";
            this.buttongenerate.UseVisualStyleBackColor = true;
            this.buttongenerate.Click += new System.EventHandler(this.buttongenerate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(584, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Identificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttontrain
            // 
            this.buttontrain.Location = new System.Drawing.Point(584, 91);
            this.buttontrain.Name = "buttontrain";
            this.buttontrain.Size = new System.Drawing.Size(75, 23);
            this.buttontrain.TabIndex = 3;
            this.buttontrain.Text = "Entrenar";
            this.buttontrain.UseVisualStyleBackColor = true;
            this.buttontrain.Click += new System.EventHandler(this.buttontrain_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(584, 129);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(75, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(581, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // buttonsom
            // 
            this.buttonsom.Location = new System.Drawing.Point(584, 250);
            this.buttonsom.Name = "buttonsom";
            this.buttonsom.Size = new System.Drawing.Size(75, 23);
            this.buttonsom.TabIndex = 6;
            this.buttonsom.Text = "SOM";
            this.buttonsom.UseVisualStyleBackColor = true;
            this.buttonsom.Click += new System.EventHandler(this.buttonsom_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(584, 292);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(75, 23);
            this.progressBar2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 566);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.buttonsom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttontrain);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttongenerate);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttongenerate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttontrain;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonsom;
        private System.Windows.Forms.ProgressBar progressBar2;
    }
}

