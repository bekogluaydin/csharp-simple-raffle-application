namespace Giveaway
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
            this.rtxtCandidate = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgList = new System.Windows.Forms.DataGridView();
            this.btnGiveawayStart = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.nQuantity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGiveawayNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giveaway";
            // 
            // rtxtCandidate
            // 
            this.rtxtCandidate.Location = new System.Drawing.Point(488, 55);
            this.rtxtCandidate.Name = "rtxtCandidate";
            this.rtxtCandidate.Size = new System.Drawing.Size(300, 383);
            this.rtxtCandidate.TabIndex = 1;
            this.rtxtCandidate.Text = "";
            this.rtxtCandidate.TextChanged += new System.EventHandler(this.rtxtCandidate_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(496, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giveaway List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(496, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fill in each line with a name.";
            // 
            // dtgList
            // 
            this.dtgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgList.Location = new System.Drawing.Point(12, 78);
            this.dtgList.Name = "dtgList";
            this.dtgList.Size = new System.Drawing.Size(459, 294);
            this.dtgList.TabIndex = 4;
            // 
            // btnGiveawayStart
            // 
            this.btnGiveawayStart.Location = new System.Drawing.Point(188, 397);
            this.btnGiveawayStart.Name = "btnGiveawayStart";
            this.btnGiveawayStart.Size = new System.Drawing.Size(94, 23);
            this.btnGiveawayStart.TabIndex = 5;
            this.btnGiveawayStart.Text = "Start Giveaway";
            this.btnGiveawayStart.UseVisualStyleBackColor = true;
            this.btnGiveawayStart.Click += new System.EventHandler(this.btnGiveawayStart_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(338, 397);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // nQuantity
            // 
            this.nQuantity.Location = new System.Drawing.Point(15, 397);
            this.nQuantity.Name = "nQuantity";
            this.nQuantity.Size = new System.Drawing.Size(120, 20);
            this.nQuantity.TabIndex = 7;
            this.nQuantity.ValueChanged += new System.EventHandler(this.nQuantity_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "number of attendees:";
            // 
            // lblGiveawayNumber
            // 
            this.lblGiveawayNumber.AutoSize = true;
            this.lblGiveawayNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGiveawayNumber.Location = new System.Drawing.Point(171, 50);
            this.lblGiveawayNumber.Name = "lblGiveawayNumber";
            this.lblGiveawayNumber.Size = new System.Drawing.Size(15, 16);
            this.lblGiveawayNumber.TabIndex = 9;
            this.lblGiveawayNumber.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGiveawayNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nQuantity);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGiveawayStart);
            this.Controls.Add(this.dtgList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtxtCandidate);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtCandidate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgList;
        private System.Windows.Forms.Button btnGiveawayStart;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.NumericUpDown nQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGiveawayNumber;
    }
}

