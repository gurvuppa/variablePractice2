
namespace variablePractice2
{
    partial class background
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.buttonHockey = new System.Windows.Forms.Button();
            this.buttonArea = new System.Windows.Forms.Button();
            this.buttonCarpet = new System.Windows.Forms.Button();
            this.buttonBill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(241, 33);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(521, 369);
            this.outputLabel.TabIndex = 0;
            // 
            // buttonHockey
            // 
            this.buttonHockey.Location = new System.Drawing.Point(62, 33);
            this.buttonHockey.Name = "buttonHockey";
            this.buttonHockey.Size = new System.Drawing.Size(128, 48);
            this.buttonHockey.TabIndex = 2;
            this.buttonHockey.Text = "Hockey";
            this.buttonHockey.UseVisualStyleBackColor = true;
            this.buttonHockey.Click += new System.EventHandler(this.buttonHockey_Click);
            // 
            // buttonArea
            // 
            this.buttonArea.Location = new System.Drawing.Point(62, 248);
            this.buttonArea.Name = "buttonArea";
            this.buttonArea.Size = new System.Drawing.Size(128, 48);
            this.buttonArea.TabIndex = 3;
            this.buttonArea.Text = "Area";
            this.buttonArea.UseVisualStyleBackColor = true;
            this.buttonArea.Click += new System.EventHandler(this.buttonArea_Click);
            // 
            // buttonCarpet
            // 
            this.buttonCarpet.Location = new System.Drawing.Point(62, 139);
            this.buttonCarpet.Name = "buttonCarpet";
            this.buttonCarpet.Size = new System.Drawing.Size(128, 48);
            this.buttonCarpet.TabIndex = 4;
            this.buttonCarpet.Text = "Carpet";
            this.buttonCarpet.UseVisualStyleBackColor = true;
            this.buttonCarpet.Click += new System.EventHandler(this.buttonCarpet_Click);
            // 
            // buttonBill
            // 
            this.buttonBill.Location = new System.Drawing.Point(62, 354);
            this.buttonBill.Name = "buttonBill";
            this.buttonBill.Size = new System.Drawing.Size(128, 48);
            this.buttonBill.TabIndex = 5;
            this.buttonBill.Text = "Bill";
            this.buttonBill.UseVisualStyleBackColor = true;
            this.buttonBill.Click += new System.EventHandler(this.buttonBill_Click);
            // 
            // background
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBill);
            this.Controls.Add(this.buttonCarpet);
            this.Controls.Add(this.buttonArea);
            this.Controls.Add(this.buttonHockey);
            this.Controls.Add(this.outputLabel);
            this.Name = "background";
            this.Text = "Variable Practice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button buttonHockey;
        private System.Windows.Forms.Button buttonArea;
        private System.Windows.Forms.Button buttonCarpet;
        private System.Windows.Forms.Button buttonBill;
    }
}

