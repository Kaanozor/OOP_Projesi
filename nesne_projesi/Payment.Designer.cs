
namespace nesne_projesi
{
    partial class Payment
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
            this.Coupon = new System.Windows.Forms.TextBox();
            this.CouponEnter = new System.Windows.Forms.Button();
            this.Amount = new System.Windows.Forms.Label();
            this.CreditCard = new System.Windows.Forms.Button();
            this.Cash = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Coupon
            // 
            this.Coupon.Location = new System.Drawing.Point(181, 267);
            this.Coupon.Name = "Coupon";
            this.Coupon.Size = new System.Drawing.Size(100, 20);
            this.Coupon.TabIndex = 3;
            // 
            // CouponEnter
            // 
            this.CouponEnter.Location = new System.Drawing.Point(197, 293);
            this.CouponEnter.Name = "CouponEnter";
            this.CouponEnter.Size = new System.Drawing.Size(75, 23);
            this.CouponEnter.TabIndex = 4;
            this.CouponEnter.Text = "button4";
            this.CouponEnter.UseVisualStyleBackColor = true;
            this.CouponEnter.Click += new System.EventHandler(this.CouponEnter_Click);
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(295, 137);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(35, 13);
            this.Amount.TabIndex = 5;
            this.Amount.Text = "label1";
            // 
            // CreditCard
            // 
            this.CreditCard.Location = new System.Drawing.Point(348, 132);
            this.CreditCard.Name = "CreditCard";
            this.CreditCard.Size = new System.Drawing.Size(75, 23);
            this.CreditCard.TabIndex = 6;
            this.CreditCard.Text = "button1";
            this.CreditCard.UseVisualStyleBackColor = true;
            this.CreditCard.Click += new System.EventHandler(this.CreditCard_Click);
            // 
            // Cash
            // 
            this.Cash.Location = new System.Drawing.Point(348, 161);
            this.Cash.Name = "Cash";
            this.Cash.Size = new System.Drawing.Size(75, 23);
            this.Cash.TabIndex = 7;
            this.Cash.Text = "button2";
            this.Cash.UseVisualStyleBackColor = true;
            this.Cash.Click += new System.EventHandler(this.Cash_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 328);
            this.Controls.Add(this.Cash);
            this.Controls.Add(this.CreditCard);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.CouponEnter);
            this.Controls.Add(this.Coupon);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Coupon;
        private System.Windows.Forms.Button CouponEnter;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Button CreditCard;
        private System.Windows.Forms.Button Cash;
    }
}