
namespace Tyuiu.KultyshevaEA.Sprint6.Task6.V24
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonFile_KEA = new System.Windows.Forms.Button();
            this.groupBoxButtons_KEA = new System.Windows.Forms.GroupBox();
            this.buttonDone_KEA = new System.Windows.Forms.Button();
            this.buttonHelp_KEA = new System.Windows.Forms.Button();
            this.groupBoxVar_KEA = new System.Windows.Forms.GroupBox();
            this.groupBoxRes_KEA = new System.Windows.Forms.GroupBox();
            this.openFileDialogTask_KEA = new System.Windows.Forms.OpenFileDialog();
            this.textBoxIn_KEA = new System.Windows.Forms.TextBox();
            this.textBoxOut_KEA = new System.Windows.Forms.TextBox();
            this.toolTip_KEA = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxButtons_KEA.SuspendLayout();
            this.groupBoxVar_KEA.SuspendLayout();
            this.groupBoxRes_KEA.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFile_KEA
            // 
            this.buttonFile_KEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonFile_KEA.Image")));
            this.buttonFile_KEA.Location = new System.Drawing.Point(6, 19);
            this.buttonFile_KEA.Name = "buttonFile_KEA";
            this.buttonFile_KEA.Size = new System.Drawing.Size(118, 97);
            this.buttonFile_KEA.TabIndex = 0;
            this.toolTip_KEA.SetToolTip(this.buttonFile_KEA, "Открыть файл\r\nВыберите нужный файл для обработки\r\n\r\n");
            this.buttonFile_KEA.UseVisualStyleBackColor = true;
            this.buttonFile_KEA.Click += new System.EventHandler(this.buttonFile_KEA_Click);
            // 
            // groupBoxButtons_KEA
            // 
            this.groupBoxButtons_KEA.BackColor = System.Drawing.Color.MistyRose;
            this.groupBoxButtons_KEA.Controls.Add(this.buttonHelp_KEA);
            this.groupBoxButtons_KEA.Controls.Add(this.buttonDone_KEA);
            this.groupBoxButtons_KEA.Controls.Add(this.buttonFile_KEA);
            this.groupBoxButtons_KEA.Location = new System.Drawing.Point(3, 3);
            this.groupBoxButtons_KEA.Name = "groupBoxButtons_KEA";
            this.groupBoxButtons_KEA.Size = new System.Drawing.Size(1130, 122);
            this.groupBoxButtons_KEA.TabIndex = 1;
            this.groupBoxButtons_KEA.TabStop = false;
            // 
            // buttonDone_KEA
            // 
            this.buttonDone_KEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_KEA.Image")));
            this.buttonDone_KEA.Location = new System.Drawing.Point(128, 19);
            this.buttonDone_KEA.Name = "buttonDone_KEA";
            this.buttonDone_KEA.Size = new System.Drawing.Size(116, 97);
            this.buttonDone_KEA.TabIndex = 1;
            this.toolTip_KEA.SetToolTip(this.buttonDone_KEA, "Выводит первое слово каждой строки в результирующею строку");
            this.buttonDone_KEA.UseVisualStyleBackColor = true;
            this.buttonDone_KEA.Click += new System.EventHandler(this.buttonDone_KEA_Click);
            // 
            // buttonHelp_KEA
            // 
            this.buttonHelp_KEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_KEA.Image")));
            this.buttonHelp_KEA.Location = new System.Drawing.Point(1036, 34);
            this.buttonHelp_KEA.Name = "buttonHelp_KEA";
            this.buttonHelp_KEA.Size = new System.Drawing.Size(75, 66);
            this.buttonHelp_KEA.TabIndex = 2;
            this.toolTip_KEA.SetToolTip(this.buttonHelp_KEA, "Сведения о программе");
            this.buttonHelp_KEA.UseVisualStyleBackColor = true;
            this.buttonHelp_KEA.Click += new System.EventHandler(this.buttonHelp_KEA_Click);
            // 
            // groupBoxVar_KEA
            // 
            this.groupBoxVar_KEA.Controls.Add(this.textBoxIn_KEA);
            this.groupBoxVar_KEA.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxVar_KEA.Location = new System.Drawing.Point(9, 131);
            this.groupBoxVar_KEA.Name = "groupBoxVar_KEA";
            this.groupBoxVar_KEA.Size = new System.Drawing.Size(567, 462);
            this.groupBoxVar_KEA.TabIndex = 3;
            this.groupBoxVar_KEA.TabStop = false;
            this.groupBoxVar_KEA.Text = "Ввод данных:";
            // 
            // groupBoxRes_KEA
            // 
            this.groupBoxRes_KEA.Controls.Add(this.textBoxOut_KEA);
            this.groupBoxRes_KEA.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxRes_KEA.Location = new System.Drawing.Point(582, 131);
            this.groupBoxRes_KEA.Name = "groupBoxRes_KEA";
            this.groupBoxRes_KEA.Size = new System.Drawing.Size(551, 462);
            this.groupBoxRes_KEA.TabIndex = 0;
            this.groupBoxRes_KEA.TabStop = false;
            this.groupBoxRes_KEA.Text = "Вывод данных:";
            // 
            // openFileDialogTask_KEA
            // 
            this.openFileDialogTask_KEA.FileName = "openFileDialog1";
            this.openFileDialogTask_KEA.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogTask_KEA_FileOk);
            // 
            // textBoxIn_KEA
            // 
            this.textBoxIn_KEA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIn_KEA.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxIn_KEA.Location = new System.Drawing.Point(3, 28);
            this.textBoxIn_KEA.Multiline = true;
            this.textBoxIn_KEA.Name = "textBoxIn_KEA";
            this.textBoxIn_KEA.ReadOnly = true;
            this.textBoxIn_KEA.Size = new System.Drawing.Size(558, 428);
            this.textBoxIn_KEA.TabIndex = 4;
            // 
            // textBoxOut_KEA
            // 
            this.textBoxOut_KEA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOut_KEA.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxOut_KEA.Location = new System.Drawing.Point(6, 28);
            this.textBoxOut_KEA.Multiline = true;
            this.textBoxOut_KEA.Name = "textBoxOut_KEA";
            this.textBoxOut_KEA.ReadOnly = true;
            this.textBoxOut_KEA.Size = new System.Drawing.Size(537, 428);
            this.textBoxOut_KEA.TabIndex = 5;
            // 
            // toolTip_KEA
            // 
            this.toolTip_KEA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_KEA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 596);
            this.Controls.Add(this.groupBoxRes_KEA);
            this.Controls.Add(this.groupBoxVar_KEA);
            this.Controls.Add(this.groupBoxButtons_KEA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 6 | Вариант 24 | Култышева Е.А.";
            this.groupBoxButtons_KEA.ResumeLayout(false);
            this.groupBoxVar_KEA.ResumeLayout(false);
            this.groupBoxVar_KEA.PerformLayout();
            this.groupBoxRes_KEA.ResumeLayout(false);
            this.groupBoxRes_KEA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFile_KEA;
        private System.Windows.Forms.GroupBox groupBoxButtons_KEA;
        private System.Windows.Forms.Button buttonHelp_KEA;
        private System.Windows.Forms.Button buttonDone_KEA;
        private System.Windows.Forms.GroupBox groupBoxVar_KEA;
        private System.Windows.Forms.GroupBox groupBoxRes_KEA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_KEA;
        private System.Windows.Forms.TextBox textBoxIn_KEA;
        private System.Windows.Forms.TextBox textBoxOut_KEA;
        private System.Windows.Forms.ToolTip toolTip_KEA;
    }
}

