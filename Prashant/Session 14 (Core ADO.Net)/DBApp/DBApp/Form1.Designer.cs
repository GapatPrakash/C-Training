namespace DBApp
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
            this.btnName = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.dgResult = new System.Windows.Forms.DataGridView();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.dsCust1 = new DBApp.DsCust();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCust1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(101, 12);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(75, 23);
            this.btnName.TabIndex = 0;
            this.btnName.Text = "Show";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(101, 41);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(155, 20);
            this.txtResult.TabIndex = 1;
            // 
            // dgResult
            // 
            this.dgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResult.Location = new System.Drawing.Point(91, 177);
            this.dgResult.Name = "dgResult";
            this.dgResult.Size = new System.Drawing.Size(614, 373);
            this.dgResult.TabIndex = 2;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(59, 41);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Result";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(281, 34);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(62, 13);
            this.lblFName.TabIndex = 5;
            this.lblFName.Text = "Firsst Name";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(349, 34);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(155, 20);
            this.txtFName.TabIndex = 4;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(285, 72);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(58, 13);
            this.lblLName.TabIndex = 7;
            this.lblLName.Text = "Last Name";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(349, 69);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(155, 20);
            this.txtLName.TabIndex = 6;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(307, 107);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 9;
            this.lblCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(349, 107);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(155, 20);
            this.txtCity.TabIndex = 8;
            // 
            // dsCust1
            // 
            this.dsCust1.DataSetName = "DsCust";
            this.dsCust1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 500);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.dgResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCust1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.DataGridView dgResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private DsCust dsCust1;
    }
}

