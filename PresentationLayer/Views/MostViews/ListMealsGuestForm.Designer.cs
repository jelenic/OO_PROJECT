namespace PresentationLayer.Views.MostViews
{
    partial class ListMealsGuestForm
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
            this.mealPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mealPanel.AutoScroll = true;
            this.mealPanel.Location = new System.Drawing.Point(12, 12);
            this.mealPanel.Name = "mealPanel";
            this.mealPanel.Size = new System.Drawing.Size(472, 394);
            this.mealPanel.TabIndex = 0;
            // 
            // ListMealsGuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mealPanel);
            this.Name = "ListMealsGuestForm";
            this.Text = "ListMealsGuestForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mealPanel;
    }
}