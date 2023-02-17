namespace diffie_hellman
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prime1tb = new System.Windows.Forms.TextBox();
            this.prime2tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.secret2tb = new System.Windows.Forms.TextBox();
            this.secret1tb = new System.Windows.Forms.TextBox();
            this.compute = new System.Windows.Forms.Button();
            this.keytb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "prime 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "prime 2";
            // 
            // prime1tb
            // 
            this.prime1tb.Location = new System.Drawing.Point(75, 16);
            this.prime1tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prime1tb.Name = "prime1tb";
            this.prime1tb.Size = new System.Drawing.Size(175, 20);
            this.prime1tb.TabIndex = 2;
            this.prime1tb.TextChanged += new System.EventHandler(this.prime1tb_TextChanged);
            // 
            // prime2tb
            // 
            this.prime2tb.Location = new System.Drawing.Point(75, 48);
            this.prime2tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prime2tb.Name = "prime2tb";
            this.prime2tb.Size = new System.Drawing.Size(175, 20);
            this.prime2tb.TabIndex = 3;
            this.prime2tb.TextChanged += new System.EventHandler(this.prime2tb_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "secret 1";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "secret 2";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // secret2tb
            // 
            this.secret2tb.Location = new System.Drawing.Point(330, 48);
            this.secret2tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.secret2tb.Name = "secret2tb";
            this.secret2tb.Size = new System.Drawing.Size(175, 20);
            this.secret2tb.TabIndex = 7;
            this.secret2tb.TextChanged += new System.EventHandler(this.secret2tb_TextChanged);
            // 
            // secret1tb
            // 
            this.secret1tb.Location = new System.Drawing.Point(330, 16);
            this.secret1tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.secret1tb.Name = "secret1tb";
            this.secret1tb.Size = new System.Drawing.Size(175, 20);
            this.secret1tb.TabIndex = 6;
            this.secret1tb.TextChanged += new System.EventHandler(this.secret1tb_TextChanged);
            // 
            // compute
            // 
            this.compute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compute.Location = new System.Drawing.Point(11, 79);
            this.compute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.compute.Name = "compute";
            this.compute.Size = new System.Drawing.Size(494, 30);
            this.compute.TabIndex = 8;
            this.compute.Text = "compute";
            this.compute.UseVisualStyleBackColor = true;
            this.compute.Click += new System.EventHandler(this.compute_Click);
            // 
            // keytb
            // 
            this.keytb.Location = new System.Drawing.Point(48, 122);
            this.keytb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.keytb.Name = "keytb";
            this.keytb.Size = new System.Drawing.Size(457, 20);
            this.keytb.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "key";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 166);
            this.Controls.Add(this.keytb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.compute);
            this.Controls.Add(this.secret2tb);
            this.Controls.Add(this.secret1tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prime2tb);
            this.Controls.Add(this.prime1tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "diffie-hellman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prime1tb;
        private System.Windows.Forms.TextBox prime2tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox secret2tb;
        private System.Windows.Forms.TextBox secret1tb;
        private System.Windows.Forms.Button compute;
        private System.Windows.Forms.TextBox keytb;
        private System.Windows.Forms.Label label5;
    }
}

