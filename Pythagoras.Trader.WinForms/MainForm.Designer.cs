namespace Pythagoras.Trader.WinForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            simpleButtonClockSignal = new DevExpress.XtraEditors.SimpleButton();
            SuspendLayout();
            // 
            // simpleButtonClockSignal
            // 
            simpleButtonClockSignal.Appearance.FontSizeDelta = 4;
            simpleButtonClockSignal.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            simpleButtonClockSignal.Appearance.Options.UseFont = true;
            simpleButtonClockSignal.Appearance.Options.UseTextOptions = true;
            simpleButtonClockSignal.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            simpleButtonClockSignal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            simpleButtonClockSignal.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            simpleButtonClockSignal.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButtonClockSignal.ImageOptions.SvgImage");
            simpleButtonClockSignal.ImageOptions.SvgImageSize = new System.Drawing.Size(64, 64);
            simpleButtonClockSignal.Location = new System.Drawing.Point(14, 14);
            simpleButtonClockSignal.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            simpleButtonClockSignal.Name = "simpleButtonClockSignal";
            simpleButtonClockSignal.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            simpleButtonClockSignal.Size = new System.Drawing.Size(121, 145);
            simpleButtonClockSignal.TabIndex = 0;
            simpleButtonClockSignal.Text = "Clock Signal";
            simpleButtonClockSignal.Click += simpleButtonClockSignal_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(721, 174);
            Controls.Add(simpleButtonClockSignal);
            FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "MainForm";
            Text = "Pythagoras Asset Management";
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButtonClockSignal;
    }
}

