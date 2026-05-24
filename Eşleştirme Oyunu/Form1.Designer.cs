using System;

namespace eşleştirme_oyunu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "images (0_0).jpg");
            this.ımageList1.Images.SetKeyName(1, "indir (0_0).jpg");
            this.ımageList1.Images.SetKeyName(2, "indir (0_1).jpg");
            this.ımageList1.Images.SetKeyName(3, "indir (0_2).jpg");
            this.ımageList1.Images.SetKeyName(4, "indir (0_3).jpg");
            this.ımageList1.Images.SetKeyName(5, "indir (0_4).jpg");
            this.ımageList1.Images.SetKeyName(6, "indir (1_0).jpg");
            this.ımageList1.Images.SetKeyName(7, "indir (1_1).jpg");
            this.ımageList1.Images.SetKeyName(8, "indir (1_2).jpg");
            this.ımageList1.Images.SetKeyName(9, "indir (1_3).jpg");
            this.ımageList1.Images.SetKeyName(10, "indir (1_4).jpg");
            this.ımageList1.Images.SetKeyName(11, "images (0_0).png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
    }
}

