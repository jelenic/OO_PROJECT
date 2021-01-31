namespace PresentationLayer.Views.UserControls
{
    partial class RestaurantItemGuest
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
            this.restaurantAddressTB = new System.Windows.Forms.Label();
            this.restaurantNameTB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listMealsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // restaurantAddressTB
            // 
            this.restaurantAddressTB.AutoSize = true;
            this.restaurantAddressTB.Location = new System.Drawing.Point(103, 66);
            this.restaurantAddressTB.Name = "restaurantAddressTB";
            this.restaurantAddressTB.Size = new System.Drawing.Size(10, 13);
            this.restaurantAddressTB.TabIndex = 7;
            this.restaurantAddressTB.Text = "-";
            // 
            // restaurantNameTB
            // 
            this.restaurantNameTB.AutoSize = true;
            this.restaurantNameTB.Location = new System.Drawing.Point(103, 39);
            this.restaurantNameTB.Name = "restaurantNameTB";
            this.restaurantNameTB.Size = new System.Drawing.Size(10, 13);
            this.restaurantNameTB.TabIndex = 6;
            this.restaurantNameTB.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // listMealsBtn
            // 
            this.listMealsBtn.Location = new System.Drawing.Point(254, 39);
            this.listMealsBtn.Name = "listMealsBtn";
            this.listMealsBtn.Size = new System.Drawing.Size(75, 23);
            this.listMealsBtn.TabIndex = 8;
            this.listMealsBtn.Text = "ListMeals";
            this.listMealsBtn.UseVisualStyleBackColor = true;
            this.listMealsBtn.Click += new System.EventHandler(this.listMealsBtn_Click);
            // 
            // RestaurantItemGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listMealsBtn);
            this.Controls.Add(this.restaurantAddressTB);
            this.Controls.Add(this.restaurantNameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RestaurantItemGuest";
            this.Size = new System.Drawing.Size(396, 95);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label restaurantAddressTB;
        private System.Windows.Forms.Label restaurantNameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button listMealsBtn;
    }
}
