
namespace Tyuiu.KultyshevaEA.Sprint6.Task7.V24
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAva_KEA = new System.Windows.Forms.PictureBox();
            this.label_KEA = new System.Windows.Forms.Label();
            this.buttonOK_KEA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva_KEA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAva_KEA
            // 
            this.pictureBoxAva_KEA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAva_KEA.Image")));
            this.pictureBoxAva_KEA.Location = new System.Drawing.Point(2, 9);
            this.pictureBoxAva_KEA.Name = "pictureBoxAva_KEA";
            this.pictureBoxAva_KEA.Size = new System.Drawing.Size(100, 118);
            this.pictureBoxAva_KEA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAva_KEA.TabIndex = 0;
            this.pictureBoxAva_KEA.TabStop = false;
            // 
            // label_KEA
            // 
            this.label_KEA.BackColor = System.Drawing.Color.White;
            this.label_KEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_KEA.Location = new System.Drawing.Point(108, 9);
            this.label_KEA.Name = "label_KEA";
            this.label_KEA.Size = new System.Drawing.Size(287, 197);
            this.label_KEA.TabIndex = 1;
            this.label_KEA.Text = resources.GetString("label_KEA.Text");
            this.label_KEA.Click += new System.EventHandler(this.label_KEA_Click);
            // 
            // buttonOK_KEA
            // 
            this.buttonOK_KEA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonOK_KEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK_KEA.Location = new System.Drawing.Point(320, 209);
            this.buttonOK_KEA.Name = "buttonOK_KEA";
            this.buttonOK_KEA.Size = new System.Drawing.Size(75, 47);
            this.buttonOK_KEA.TabIndex = 2;
            this.buttonOK_KEA.Text = "Ok";
            this.buttonOK_KEA.UseVisualStyleBackColor = false;
            this.buttonOK_KEA.Click += new System.EventHandler(this.buttonOK_KEA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(401, 257);
            this.Controls.Add(this.buttonOK_KEA);
            this.Controls.Add(this.label_KEA);
            this.Controls.Add(this.pictureBoxAva_KEA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva_KEA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAva_KEA;
        private System.Windows.Forms.Label label_KEA;
        private System.Windows.Forms.Button buttonOK_KEA;
    }
}