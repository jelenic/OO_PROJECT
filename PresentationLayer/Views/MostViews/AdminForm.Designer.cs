namespace PresentationLayer.Views.MostViews
{
    partial class AdminForm
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
            this.addRestaurantBtn = new System.Windows.Forms.Button();
            this.listRestaurantsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addRestaurantBtn
            // 
            this.addRestaurantBtn.Location = new System.Drawing.Point(324, 115);
            this.addRestaurantBtn.Name = "addRestaurantBtn";
            this.addRestaurantBtn.Size = new System.Drawing.Size(135, 45);
            this.addRestaurantBtn.TabIndex = 0;
            this.addRestaurantBtn.Text = "Add restaurant";
            this.addRestaurantBtn.UseVisualStyleBackColor = true;
            this.addRestaurantBtn.Click += new System.EventHandler(this.addRestaurantBtn_Click);
            // 
            // listRestaurantsBtn
            // 
            this.listRestaurantsBtn.Location = new System.Drawing.Point(324, 203);
            this.listRestaurantsBtn.Name = "listRestaurantsBtn";
            this.listRestaurantsBtn.Size = new System.Drawing.Size(135, 45);
            this.listRestaurantsBtn.TabIndex = 1;
            this.listRestaurantsBtn.Text = "List restaurants";
            this.listRestaurantsBtn.UseVisualStyleBackColor = true;
            this.listRestaurantsBtn.Click += new System.EventHandler(this.listRestaurantsBtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listRestaurantsBtn);
            this.Controls.Add(this.addRestaurantBtn);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addRestaurantBtn;
        private System.Windows.Forms.Button listRestaurantsBtn;
    }
}