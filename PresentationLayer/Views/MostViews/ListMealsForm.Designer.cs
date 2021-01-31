namespace PresentationLayer.Views.MostViews
{
    partial class ListMealsForm
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
            this.mealPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // mealPanel
            // 
            this.mealPanel.Location = new System.Drawing.Point(24, 12);
            this.mealPanel.Name = "mealPanel";
            this.mealPanel.Size = new System.Drawing.Size(513, 342);
            this.mealPanel.TabIndex = 0;
            // 
            // ListMealsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mealPanel);
            this.Name = "ListMealsForm";
            this.Text = "ListMealsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mealPanel;
    }
}