namespace PresentationLayer.Views.MostViews
{
    partial class UserForm
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
            this.listMealsBtn = new System.Windows.Forms.Button();
            this.addMealBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listMealsBtn
            // 
            this.listMealsBtn.Location = new System.Drawing.Point(321, 79);
            this.listMealsBtn.Name = "listMealsBtn";
            this.listMealsBtn.Size = new System.Drawing.Size(151, 62);
            this.listMealsBtn.TabIndex = 0;
            this.listMealsBtn.Text = "ListMeals";
            this.listMealsBtn.UseVisualStyleBackColor = true;
            this.listMealsBtn.Click += new System.EventHandler(this.listMealsBtn_Click);
            // 
            // addMealBtn
            // 
            this.addMealBtn.Location = new System.Drawing.Point(321, 198);
            this.addMealBtn.Name = "addMealBtn";
            this.addMealBtn.Size = new System.Drawing.Size(151, 62);
            this.addMealBtn.TabIndex = 1;
            this.addMealBtn.Text = "AddMeal";
            this.addMealBtn.UseVisualStyleBackColor = true;
            this.addMealBtn.Click += new System.EventHandler(this.addMealBtn_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addMealBtn);
            this.Controls.Add(this.listMealsBtn);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button listMealsBtn;
        private System.Windows.Forms.Button addMealBtn;
    }
}