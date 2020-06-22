namespace smartcard_omron
{
    partial class InsertSmartCard
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
            this.components = new System.ComponentModel.Container();
            this.timer_checkReadsmartcard = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer_checkReadsmartcard
            // 
            this.timer_checkReadsmartcard.Interval = 3000;
            this.timer_checkReadsmartcard.Tick += new System.EventHandler(this.timer_checkReadsmartcard_Tick);
            // 
            // InsertSmartCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::smartcard_omron.Properties.Resources.insertsmartcard;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 644);
            this.Name = "InsertSmartCard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_checkReadsmartcard;
    }
}