﻿namespace PresentationLayer.Views.MostViews
{
    partial class ListRestaurantsGuestForm
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
            this.restaurantPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // restaurantPanel
            // 
            this.restaurantPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.restaurantPanel.AutoScroll = true;
            this.restaurantPanel.Location = new System.Drawing.Point(37, 31);
            this.restaurantPanel.Name = "restaurantPanel";
            this.restaurantPanel.Size = new System.Drawing.Size(560, 382);
            this.restaurantPanel.TabIndex = 0;
            // 
            // ListRestaurantsGuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.restaurantPanel);
            this.Name = "ListRestaurantsGuestForm";
            this.Text = "ListRestaurantsGuestForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel restaurantPanel;
    }
}