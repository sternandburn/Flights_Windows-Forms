namespace SternFlight
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
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.lbFlights = new System.Windows.Forms.ListBox();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.btnNSF = new System.Windows.Forms.Button();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTO = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbFrom
            // 
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Location = new System.Drawing.Point(129, 87);
            this.cbFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(222, 24);
            this.cbFrom.TabIndex = 0;
            this.cbFrom.SelectedIndexChanged += new System.EventHandler(this.cbFrom_SelectedIndexChanged);
            // 
            // lbFlights
            // 
            this.lbFlights.FormattingEnabled = true;
            this.lbFlights.ItemHeight = 16;
            this.lbFlights.Location = new System.Drawing.Point(129, 134);
            this.lbFlights.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbFlights.Name = "lbFlights";
            this.lbFlights.Size = new System.Drawing.Size(743, 276);
            this.lbFlights.TabIndex = 2;
            this.lbFlights.SelectedIndexChanged += new System.EventHandler(this.lbFlights_SelectedIndexChanged);
            // 
            // cbTo
            // 
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Location = new System.Drawing.Point(639, 87);
            this.cbTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(233, 24);
            this.cbTo.TabIndex = 6;
            this.cbTo.SelectedIndexChanged += new System.EventHandler(this.cbTo_SelectedIndexChanged);
            // 
            // btnNSF
            // 
            this.btnNSF.BackColor = System.Drawing.SystemColors.Window;
            this.btnNSF.Location = new System.Drawing.Point(387, 418);
            this.btnNSF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNSF.Name = "btnNSF";
            this.btnNSF.Size = new System.Drawing.Size(261, 28);
            this.btnNSF.TabIndex = 7;
            this.btnNSF.Text = "Show Flights";
            this.btnNSF.UseVisualStyleBackColor = false;
            this.btnNSF.Click += new System.EventHandler(this.btnNSF_Click);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(180, 68);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(55, 17);
            this.lblFrom.TabIndex = 9;
            this.lblFrom.Text = "Depart:";
            this.lblFrom.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTO
            // 
            this.lblTO.AutoSize = true;
            this.lblTO.Location = new System.Drawing.Point(776, 68);
            this.lblTO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTO.Name = "lblTO";
            this.lblTO.Size = new System.Drawing.Size(49, 17);
            this.lblTO.TabIndex = 10;
            this.lblTO.Text = "Arrive:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(387, 454);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(261, 28);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear Flights";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblTO);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.btnNSF);
            this.Controls.Add(this.cbTo);
            this.Controls.Add(this.lbFlights);
            this.Controls.Add(this.cbFrom);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.ListBox lbFlights;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.Button btnNSF;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTO;
        private System.Windows.Forms.Button btnClear;
    }
}

