
namespace Lingo_OOP__V2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWoord = new System.Windows.Forms.TextBox();
            this.lblListCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLingo = new System.Windows.Forms.Label();
            this.btnChecken = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblRij = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxNamen = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(739, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "listNamen.count:";
            // 
            // txtWoord
            // 
            this.txtWoord.Font = new System.Drawing.Font("JetBrains Mono Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWoord.Location = new System.Drawing.Point(744, 163);
            this.txtWoord.Name = "txtWoord";
            this.txtWoord.Size = new System.Drawing.Size(158, 33);
            this.txtWoord.TabIndex = 2;
            this.txtWoord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWoord_KeyPress);
            // 
            // lblListCount
            // 
            this.lblListCount.AutoSize = true;
            this.lblListCount.Font = new System.Drawing.Font("JetBrains Mono Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListCount.Location = new System.Drawing.Point(1001, 77);
            this.lblListCount.Name = "lblListCount";
            this.lblListCount.Size = new System.Drawing.Size(23, 25);
            this.lblListCount.TabIndex = 4;
            this.lblListCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(739, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "strLingo:";
            // 
            // lblLingo
            // 
            this.lblLingo.AutoSize = true;
            this.lblLingo.Font = new System.Drawing.Font("JetBrains Mono Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLingo.Location = new System.Drawing.Point(885, 116);
            this.lblLingo.Name = "lblLingo";
            this.lblLingo.Size = new System.Drawing.Size(122, 25);
            this.lblLingo.TabIndex = 6;
            this.lblLingo.Text = "LingoWoord";
            // 
            // btnChecken
            // 
            this.btnChecken.BackColor = System.Drawing.Color.DarkOrange;
            this.btnChecken.Location = new System.Drawing.Point(744, 219);
            this.btnChecken.Name = "btnChecken";
            this.btnChecken.Size = new System.Drawing.Size(158, 52);
            this.btnChecken.TabIndex = 8;
            this.btnChecken.Text = "Check";
            this.btnChecken.UseVisualStyleBackColor = false;
            this.btnChecken.Click += new System.EventHandler(this.btnChecken_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblRij
            // 
            this.lblRij.AutoSize = true;
            this.lblRij.Font = new System.Drawing.Font("JetBrains Mono Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRij.Location = new System.Drawing.Point(1001, 41);
            this.lblRij.Name = "lblRij";
            this.lblRij.Size = new System.Drawing.Size(23, 25);
            this.lblRij.TabIndex = 10;
            this.lblRij.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("JetBrains Mono Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(739, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "intRij:";
            // 
            // listBoxNamen
            // 
            this.listBoxNamen.FormattingEnabled = true;
            this.listBoxNamen.ItemHeight = 19;
            this.listBoxNamen.Location = new System.Drawing.Point(731, 304);
            this.listBoxNamen.Name = "listBoxNamen";
            this.listBoxNamen.Size = new System.Drawing.Size(636, 479);
            this.listBoxNamen.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 777);
            this.Controls.Add(this.lblRij);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnChecken);
            this.Controls.Add(this.lblLingo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblListCount);
            this.Controls.Add(this.listBoxNamen);
            this.Controls.Add(this.txtWoord);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("JetBrains Mono Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F1Lingo OOP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWoord;
        private System.Windows.Forms.Label lblListCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLingo;
        private System.Windows.Forms.Button btnChecken;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblRij;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxNamen;
    }
}

