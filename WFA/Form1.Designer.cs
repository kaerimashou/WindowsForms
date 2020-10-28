using System;
using System.Diagnostics.Tracing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace WFA
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
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.labelNumber = new System.Windows.Forms.Label();
            this.bplus = new System.Windows.Forms.Button();
            this.bminus = new System.Windows.Forms.Button();
            this.bmult = new System.Windows.Forms.Button();
            this.bsub = new System.Windows.Forms.Button();
            this.bpowb = new System.Windows.Forms.Button();
            this.bsqb = new System.Windows.Forms.Button();
            this.bclear = new System.Windows.Forms.Button();
            this.bchange = new System.Windows.Forms.Button();
            this.bpoint = new System.Windows.Forms.Button();
            this.bequal = new System.Windows.Forms.Button();
            this.bpow2 = new System.Windows.Forms.Button();
            this.bfact = new System.Windows.Forms.Button();
            this.bsqrt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b1.Location = new System.Drawing.Point(12, 77);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(70, 70);
            this.b1.TabIndex = 1;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b2.Location = new System.Drawing.Point(88, 77);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(70, 70);
            this.b2.TabIndex = 2;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b3.Location = new System.Drawing.Point(164, 77);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(70, 70);
            this.b3.TabIndex = 3;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b4
            // 
            this.b4.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b4.Location = new System.Drawing.Point(12, 153);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(70, 70);
            this.b4.TabIndex = 4;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b5.Location = new System.Drawing.Point(88, 153);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(70, 70);
            this.b5.TabIndex = 5;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b6
            // 
            this.b6.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b6.Location = new System.Drawing.Point(164, 153);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(70, 70);
            this.b6.TabIndex = 6;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b7.Location = new System.Drawing.Point(12, 229);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(70, 70);
            this.b7.TabIndex = 7;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b8.Location = new System.Drawing.Point(88, 229);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(70, 70);
            this.b8.TabIndex = 8;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b9.Location = new System.Drawing.Point(164, 229);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(70, 70);
            this.b9.TabIndex = 9;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // b0
            // 
            this.b0.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b0.Location = new System.Drawing.Point(88, 305);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(70, 70);
            this.b0.TabIndex = 10;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelNumber.Location = new System.Drawing.Point(12, 34);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(0, 32);
            this.labelNumber.TabIndex = 11;
            // 
            // bplus
            // 
            this.bplus.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bplus.Location = new System.Drawing.Point(340, 77);
            this.bplus.Name = "bplus";
            this.bplus.Size = new System.Drawing.Size(70, 70);
            this.bplus.TabIndex = 12;
            this.bplus.Text = "+";
            this.bplus.UseVisualStyleBackColor = true;
            this.bplus.Click += new System.EventHandler(this.button_Click);
            // 
            // bminus
            // 
            this.bminus.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bminus.Location = new System.Drawing.Point(416, 77);
            this.bminus.Name = "bminus";
            this.bminus.Size = new System.Drawing.Size(70, 70);
            this.bminus.TabIndex = 13;
            this.bminus.Text = "-";
            this.bminus.UseVisualStyleBackColor = true;
            this.bminus.Click += new System.EventHandler(this.button_Click);
            // 
            // bmult
            // 
            this.bmult.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bmult.Location = new System.Drawing.Point(340, 153);
            this.bmult.Name = "bmult";
            this.bmult.Size = new System.Drawing.Size(70, 70);
            this.bmult.TabIndex = 14;
            this.bmult.Text = "*";
            this.bmult.UseVisualStyleBackColor = true;
            this.bmult.Click += new System.EventHandler(this.button_Click);
            // 
            // bsub
            // 
            this.bsub.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bsub.Location = new System.Drawing.Point(416, 153);
            this.bsub.Name = "bsub";
            this.bsub.Size = new System.Drawing.Size(70, 70);
            this.bsub.TabIndex = 15;
            this.bsub.Text = "/";
            this.bsub.UseVisualStyleBackColor = true;
            this.bsub.Click += new System.EventHandler(this.button_Click);
            // 
            // bpowb
            // 
            this.bpowb.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bpowb.Location = new System.Drawing.Point(583, 77);
            this.bpowb.Name = "bpowb";
            this.bpowb.Size = new System.Drawing.Size(70, 70);
            this.bpowb.TabIndex = 16;
            this.bpowb.Text = "a^b";
            this.bpowb.UseVisualStyleBackColor = true;
            this.bpowb.Click += new System.EventHandler(this.button_Click);
            // 
            // bsqb
            // 
            this.bsqb.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bsqb.Location = new System.Drawing.Point(416, 305);
            this.bsqb.Name = "bsqb";
            this.bsqb.Size = new System.Drawing.Size(70, 70);
            this.bsqb.TabIndex = 17;
            this.bsqb.Text = "b√";
            this.bsqb.UseVisualStyleBackColor = true;
            this.bsqb.Click += new System.EventHandler(this.button_Click);
            // 
            // bclear
            // 
            this.bclear.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bclear.Location = new System.Drawing.Point(694, 153);
            this.bclear.Name = "bclear";
            this.bclear.Size = new System.Drawing.Size(70, 70);
            this.bclear.TabIndex = 18;
            this.bclear.Text = "C";
            this.bclear.UseVisualStyleBackColor = true;
            this.bclear.Click += new System.EventHandler(this.bclear_Click);
            // 
            // bchange
            // 
            this.bchange.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bchange.Location = new System.Drawing.Point(416, 229);
            this.bchange.Name = "bchange";
            this.bchange.Size = new System.Drawing.Size(70, 70);
            this.bchange.TabIndex = 19;
            this.bchange.Text = "+/-";
            this.bchange.UseVisualStyleBackColor = true;
            this.bchange.Click += new System.EventHandler(this.bchange_Click);
            // 
            // bpoint
            // 
            this.bpoint.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bpoint.Location = new System.Drawing.Point(340, 229);
            this.bpoint.Name = "bpoint";
            this.bpoint.Size = new System.Drawing.Size(70, 70);
            this.bpoint.TabIndex = 20;
            this.bpoint.Text = ".";
            this.bpoint.UseVisualStyleBackColor = true;
            this.bpoint.Click += new System.EventHandler(this.bpoint_Click);
            // 
            // bequal
            // 
            this.bequal.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bequal.Location = new System.Drawing.Point(694, 77);
            this.bequal.Name = "bequal";
            this.bequal.Size = new System.Drawing.Size(70, 70);
            this.bequal.TabIndex = 21;
            this.bequal.Text = "=";
            this.bequal.UseVisualStyleBackColor = true;
            this.bequal.Click += new System.EventHandler(this.bequal_Click);
            // 
            // bpow2
            // 
            this.bpow2.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bpow2.Location = new System.Drawing.Point(583, 153);
            this.bpow2.Name = "bpow2";
            this.bpow2.Size = new System.Drawing.Size(70, 70);
            this.bpow2.TabIndex = 22;
            this.bpow2.Text = "a^2";
            this.bpow2.UseVisualStyleBackColor = true;
            this.bpow2.Click += new System.EventHandler(this.bpow2_Click);
            // 
            // bfact
            // 
            this.bfact.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bfact.Location = new System.Drawing.Point(583, 229);
            this.bfact.Name = "bfact";
            this.bfact.Size = new System.Drawing.Size(70, 70);
            this.bfact.TabIndex = 23;
            this.bfact.Text = "a!";
            this.bfact.UseVisualStyleBackColor = true;
            this.bfact.Click += new System.EventHandler(this.bfact_Click);
            // 
            // bsqrt
            // 
            this.bsqrt.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bsqrt.Location = new System.Drawing.Point(340, 305);
            this.bsqrt.Name = "bsqrt";
            this.bsqrt.Size = new System.Drawing.Size(70, 70);
            this.bsqrt.TabIndex = 24;
            this.bsqrt.Text = "2√";
            this.bsqrt.UseVisualStyleBackColor = true;
            this.bsqrt.Click += new System.EventHandler(this.bsqrt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bsqrt);
            this.Controls.Add(this.bfact);
            this.Controls.Add(this.bpow2);
            this.Controls.Add(this.bequal);
            this.Controls.Add(this.bpoint);
            this.Controls.Add(this.bchange);
            this.Controls.Add(this.bclear);
            this.Controls.Add(this.bsqb);
            this.Controls.Add(this.bpowb);
            this.Controls.Add(this.bsub);
            this.Controls.Add(this.bmult);
            this.Controls.Add(this.bminus);
            this.Controls.Add(this.bplus);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button b1;       
        private System.Windows.Forms.Button b2;    
        private System.Windows.Forms.Button b3;       
        private System.Windows.Forms.Button b4;        
        private System.Windows.Forms.Button b5;        
        private System.Windows.Forms.Button b6;       
        private System.Windows.Forms.Button b7;       
        private System.Windows.Forms.Button b8;        
        private System.Windows.Forms.Button b9;        
        private System.Windows.Forms.Button b0;        
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Button bplus;    
        private System.Windows.Forms.Button bminus;        
        private System.Windows.Forms.Button bmult;        
        private System.Windows.Forms.Button bsub;
        private System.Windows.Forms.Button bpowb;        
        private System.Windows.Forms.Button bsqb;        
        private System.Windows.Forms.Button bclear;  
        private System.Windows.Forms.Button bchange;       
        private System.Windows.Forms.Button bpoint;      
        private System.Windows.Forms.Button bequal;       
        private System.Windows.Forms.Button bpow2;
        private System.Windows.Forms.Button bfact;        
        private System.Windows.Forms.Button bsqrt;
    }
}

