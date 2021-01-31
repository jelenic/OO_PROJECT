namespace PresentationLayer.Views.UserControls
{
    partial class RestaurantItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.restaurantNameTB = new System.Windows.Forms.Label();
            this.restaurantAddressTB = new System.Windows.Forms.Label();
            this.removeRestaurantBtn = new System.Windows.Forms.Button();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // restaurantNameTB
            // 
            this.restaurantNameTB.AutoSize = true;
            this.restaurantNameTB.Location = new System.Drawing.Point(100, 21);
            this.restaurantNameTB.Name = "restaurantNameTB";
            this.restaurantNameTB.Size = new System.Drawing.Size(10, 13);
            this.restaurantNameTB.TabIndex = 2;
            this.restaurantNameTB.Text = "-";
            // 
            // restaurantAddressTB
            // 
            this.restaurantAddressTB.AutoSize = true;
            this.restaurantAddressTB.Location = new System.Drawing.Point(100, 48);
            this.restaurantAddressTB.Name = "restaurantAddressTB";
            this.restaurantAddressTB.Size = new System.Drawing.Size(10, 13);
            this.restaurantAddressTB.TabIndex = 3;
            this.restaurantAddressTB.Text = "-";
            // 
            // removeRestaurantBtn
            // 
            this.removeRestaurantBtn.Location = new System.Drawing.Point(173, 11);
            this.removeRestaurantBtn.Name = "removeRestaurantBtn";
            this.removeRestaurantBtn.Size = new System.Drawing.Size(111, 23);
            this.removeRestaurantBtn.TabIndex = 4;
            this.removeRestaurantBtn.Text = "RemoveRestaurant";
            this.removeRestaurantBtn.UseVisualStyleBackColor = true;
            this.removeRestaurantBtn.Click += new System.EventHandler(this.removeRestaurantBtn_Click);
            // 
            // addUserBtn
            // 
            this.addUserBtn.Location = new System.Drawing.Point(173, 46);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(111, 23);
            this.addUserBtn.TabIndex = 5;
            this.addUserBtn.Text = "AddEmployee";
            this.addUserBtn.UseVisualStyleBackColor = true;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // RestaurantItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addUserBtn);
            this.Controls.Add(this.removeRestaurantBtn);
            this.Controls.Add(this.restaurantAddressTB);
            this.Controls.Add(this.restaurantNameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RestaurantItem";
            this.Size = new System.Drawing.Size(320, 85);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label restaurantNameTB;
        private System.Windows.Forms.Label restaurantAddressTB;
        private System.Windows.Forms.Button removeRestaurantBtn;
        private System.Windows.Forms.Button addUserBtn;
    }
}
