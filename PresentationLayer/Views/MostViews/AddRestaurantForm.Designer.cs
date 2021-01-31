namespace PresentationLayer.Views.MostViews
{
    partial class AddRestaurantForm
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
            this.restaurantNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.restaurantAddressTB = new System.Windows.Forms.TextBox();
            this.addRestaurantBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // restaurantNameTB
            // 
            this.restaurantNameTB.Location = new System.Drawing.Point(305, 70);
            this.restaurantNameTB.Name = "restaurantNameTB";
            this.restaurantNameTB.Size = new System.Drawing.Size(194, 20);
            this.restaurantNameTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "RestaurantName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "RestaurantAddress";
            // 
            // restaurantAddressTB
            // 
            this.restaurantAddressTB.Location = new System.Drawing.Point(305, 112);
            this.restaurantAddressTB.Name = "restaurantAddressTB";
            this.restaurantAddressTB.Size = new System.Drawing.Size(194, 20);
            this.restaurantAddressTB.TabIndex = 2;
            // 
            // addRestaurantBtn
            // 
            this.addRestaurantBtn.Location = new System.Drawing.Point(330, 161);
            this.addRestaurantBtn.Name = "addRestaurantBtn";
            this.addRestaurantBtn.Size = new System.Drawing.Size(108, 23);
            this.addRestaurantBtn.TabIndex = 4;
            this.addRestaurantBtn.Text = "AddRestaurant";
            this.addRestaurantBtn.UseVisualStyleBackColor = true;
            this.addRestaurantBtn.Click += new System.EventHandler(this.addRestaurantBtn_Click);
            // 
            // AddRestaurantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addRestaurantBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.restaurantAddressTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.restaurantNameTB);
            this.Name = "AddRestaurantForm";
            this.Text = "AddRestaurantForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox restaurantNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox restaurantAddressTB;
        private System.Windows.Forms.Button addRestaurantBtn;
    }
}