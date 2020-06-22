namespace smartcard_omron
{
    partial class ReadOmron9020
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
            this.timer_readOmron9020 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer_readOmron9020
            // 
            this.timer_readOmron9020.Interval = 2000;
            this.timer_readOmron9020.Tick += new System.EventHandler(this.timer_readOmron9020_Tick);
            // 
            // ReadOmron9020
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::smartcard_omron.Properties.Resources.bp320;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 712);
            this.Name = "ReadOmron9020";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Timer timer_readOmron9020;
    }
}