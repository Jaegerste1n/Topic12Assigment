namespace Topic12Assigment
{
    partial class FormInput
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
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnCalculatePrice = new System.Windows.Forms.Button();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.updQuantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.updQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // txtItem
            // 
            this.txtItem.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtItem.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.ForeColor = System.Drawing.Color.LawnGreen;
            this.txtItem.Location = new System.Drawing.Point(133, 12);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(100, 20);
            this.txtItem.TabIndex = 0;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtPrice.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.LawnGreen;
            this.txtPrice.Location = new System.Drawing.Point(133, 49);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 1;
            // 
            // btnCalculatePrice
            // 
            this.btnCalculatePrice.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCalculatePrice.Font = new System.Drawing.Font("Monotxt_IV25", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculatePrice.Location = new System.Drawing.Point(12, 125);
            this.btnCalculatePrice.Name = "btnCalculatePrice";
            this.btnCalculatePrice.Size = new System.Drawing.Size(221, 23);
            this.btnCalculatePrice.TabIndex = 3;
            this.btnCalculatePrice.Text = "Calculate";
            this.btnCalculatePrice.UseVisualStyleBackColor = false;
            this.btnCalculatePrice.Click += new System.EventHandler(this.btnCalculatePrice_Click);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblItem.Location = new System.Drawing.Point(13, 15);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(119, 14);
            this.lblItem.TabIndex = 4;
            this.lblItem.Text = "Enter Item Name:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblPrice.Location = new System.Drawing.Point(13, 56);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(91, 14);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Enter Price:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblQuantity.Location = new System.Drawing.Point(13, 93);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(98, 14);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Enter Amount:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Font = new System.Drawing.Font("MS Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTotalPrice.Location = new System.Drawing.Point(13, 162);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(225, 106);
            this.lblTotalPrice.TabIndex = 7;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // updQuantity
            // 
            this.updQuantity.BackColor = System.Drawing.SystemColors.MenuText;
            this.updQuantity.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updQuantity.ForeColor = System.Drawing.Color.LawnGreen;
            this.updQuantity.Location = new System.Drawing.Point(133, 87);
            this.updQuantity.Maximum = new decimal(new int[] {
            8008135,
            0,
            0,
            0});
            this.updQuantity.Name = "updQuantity";
            this.updQuantity.Size = new System.Drawing.Size(100, 20);
            this.updQuantity.TabIndex = 9;
            // 
            // FormInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(250, 277);
            this.Controls.Add(this.updQuantity);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.btnCalculatePrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtItem);
            this.Name = "FormInput";
            this.Text = "User Input";
            ((System.ComponentModel.ISupportInitialize)(this.updQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnCalculatePrice;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.NumericUpDown updQuantity;
    }
}

