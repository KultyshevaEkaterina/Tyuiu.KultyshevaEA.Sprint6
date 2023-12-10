
namespace Tyuiu.KultyshevaEA.Sprint6.Task7.V24
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
            this.groupBoxButtons_KEA = new System.Windows.Forms.GroupBox();
            this.buttonFile_KEA = new System.Windows.Forms.Button();
            this.buttonDone_KEA = new System.Windows.Forms.Button();
            this.buttonSave_KEA = new System.Windows.Forms.Button();
            this.buttonHelp_KEA = new System.Windows.Forms.Button();
            this.groupBoxTask_KEA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KEA = new System.Windows.Forms.TextBox();
            this.groupBoxVar_KEA = new System.Windows.Forms.GroupBox();
            this.groupBoxRes_KEA = new System.Windows.Forms.GroupBox();
            this.dataGridViewVar_KEA = new System.Windows.Forms.DataGridView();
            this.dataGridViewRes_KEA = new System.Windows.Forms.DataGridView();
            this.toolTip_KEA = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialogTask_KEA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_KEA = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxButtons_KEA.SuspendLayout();
            this.groupBoxTask_KEA.SuspendLayout();
            this.groupBoxVar_KEA.SuspendLayout();
            this.groupBoxRes_KEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVar_KEA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_KEA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxButtons_KEA
            // 
            this.groupBoxButtons_KEA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBoxButtons_KEA.Controls.Add(this.buttonHelp_KEA);
            this.groupBoxButtons_KEA.Controls.Add(this.buttonSave_KEA);
            this.groupBoxButtons_KEA.Controls.Add(this.buttonDone_KEA);
            this.groupBoxButtons_KEA.Controls.Add(this.buttonFile_KEA);
            this.groupBoxButtons_KEA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxButtons_KEA.Name = "groupBoxButtons_KEA";
            this.groupBoxButtons_KEA.Size = new System.Drawing.Size(1149, 124);
            this.groupBoxButtons_KEA.TabIndex = 0;
            this.groupBoxButtons_KEA.TabStop = false;
            // 
            // buttonFile_KEA
            // 
            this.buttonFile_KEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonFile_KEA.Image")));
            this.buttonFile_KEA.Location = new System.Drawing.Point(12, 19);
            this.buttonFile_KEA.Name = "buttonFile_KEA";
            this.buttonFile_KEA.Size = new System.Drawing.Size(115, 81);
            this.buttonFile_KEA.TabIndex = 0;
            this.toolTip_KEA.SetToolTip(this.buttonFile_KEA, "Открыть файл");
            this.buttonFile_KEA.UseVisualStyleBackColor = true;
            this.buttonFile_KEA.Click += new System.EventHandler(this.buttonFile_KEA_Click);
            // 
            // buttonDone_KEA
            // 
            this.buttonDone_KEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_KEA.Image")));
            this.buttonDone_KEA.Location = new System.Drawing.Point(133, 19);
            this.buttonDone_KEA.Name = "buttonDone_KEA";
            this.buttonDone_KEA.Size = new System.Drawing.Size(114, 81);
            this.buttonDone_KEA.TabIndex = 1;
            this.toolTip_KEA.SetToolTip(this.buttonDone_KEA, "Выполнить");
            this.buttonDone_KEA.UseVisualStyleBackColor = true;
            this.buttonDone_KEA.Click += new System.EventHandler(this.buttonDone_KEA_Click);
            // 
            // buttonSave_KEA
            // 
            this.buttonSave_KEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_KEA.Image")));
            this.buttonSave_KEA.Location = new System.Drawing.Point(253, 19);
            this.buttonSave_KEA.Name = "buttonSave_KEA";
            this.buttonSave_KEA.Size = new System.Drawing.Size(114, 81);
            this.buttonSave_KEA.TabIndex = 2;
            this.toolTip_KEA.SetToolTip(this.buttonSave_KEA, "Сохранить файл");
            this.buttonSave_KEA.UseVisualStyleBackColor = true;
            this.buttonSave_KEA.Click += new System.EventHandler(this.buttonSave_KEA_Click);
            // 
            // buttonHelp_KEA
            // 
            this.buttonHelp_KEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_KEA.Image")));
            this.buttonHelp_KEA.Location = new System.Drawing.Point(1062, 27);
            this.buttonHelp_KEA.Name = "buttonHelp_KEA";
            this.buttonHelp_KEA.Size = new System.Drawing.Size(75, 73);
            this.buttonHelp_KEA.TabIndex = 3;
            this.toolTip_KEA.SetToolTip(this.buttonHelp_KEA, "О программе");
            this.buttonHelp_KEA.UseVisualStyleBackColor = true;
            this.buttonHelp_KEA.Click += new System.EventHandler(this.buttonHelp_KEA_Click);
            // 
            // groupBoxTask_KEA
            // 
            this.groupBoxTask_KEA.Controls.Add(this.textBoxTask_KEA);
            this.groupBoxTask_KEA.Location = new System.Drawing.Point(0, 130);
            this.groupBoxTask_KEA.Name = "groupBoxTask_KEA";
            this.groupBoxTask_KEA.Size = new System.Drawing.Size(1149, 108);
            this.groupBoxTask_KEA.TabIndex = 4;
            this.groupBoxTask_KEA.TabStop = false;
            this.groupBoxTask_KEA.Text = "Условие:";
            // 
            // textBoxTask_KEA
            // 
            this.textBoxTask_KEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_KEA.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_KEA.Multiline = true;
            this.textBoxTask_KEA.Name = "textBoxTask_KEA";
            this.textBoxTask_KEA.ReadOnly = true;
            this.textBoxTask_KEA.Size = new System.Drawing.Size(1140, 86);
            this.textBoxTask_KEA.TabIndex = 0;
            this.textBoxTask_KEA.Text = resources.GetString("textBoxTask_KEA.Text");
            // 
            // groupBoxVar_KEA
            // 
            this.groupBoxVar_KEA.Controls.Add(this.dataGridViewVar_KEA);
            this.groupBoxVar_KEA.Location = new System.Drawing.Point(3, 244);
            this.groupBoxVar_KEA.Name = "groupBoxVar_KEA";
            this.groupBoxVar_KEA.Size = new System.Drawing.Size(545, 327);
            this.groupBoxVar_KEA.TabIndex = 1;
            this.groupBoxVar_KEA.TabStop = false;
            this.groupBoxVar_KEA.Text = "Ввод:";
            // 
            // groupBoxRes_KEA
            // 
            this.groupBoxRes_KEA.Controls.Add(this.dataGridViewRes_KEA);
            this.groupBoxRes_KEA.Location = new System.Drawing.Point(554, 244);
            this.groupBoxRes_KEA.Name = "groupBoxRes_KEA";
            this.groupBoxRes_KEA.Size = new System.Drawing.Size(589, 327);
            this.groupBoxRes_KEA.TabIndex = 0;
            this.groupBoxRes_KEA.TabStop = false;
            this.groupBoxRes_KEA.Text = "Вывод:";
            // 
            // dataGridViewVar_KEA
            // 
            this.dataGridViewVar_KEA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVar_KEA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewVar_KEA.Name = "dataGridViewVar_KEA";
            this.dataGridViewVar_KEA.Size = new System.Drawing.Size(536, 305);
            this.dataGridViewVar_KEA.TabIndex = 0;
            // 
            // dataGridViewRes_KEA
            // 
            this.dataGridViewRes_KEA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes_KEA.Location = new System.Drawing.Point(6, 16);
            this.dataGridViewRes_KEA.Name = "dataGridViewRes_KEA";
            this.dataGridViewRes_KEA.Size = new System.Drawing.Size(583, 305);
            this.dataGridViewRes_KEA.TabIndex = 1;
            // 
            // openFileDialogTask_KEA
            // 
            this.openFileDialogTask_KEA.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1149, 583);
            this.Controls.Add(this.groupBoxRes_KEA);
            this.Controls.Add(this.groupBoxVar_KEA);
            this.Controls.Add(this.groupBoxTask_KEA);
            this.Controls.Add(this.groupBoxButtons_KEA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 7 | Вариант 24 | Култышева Е.А.";
            this.groupBoxButtons_KEA.ResumeLayout(false);
            this.groupBoxTask_KEA.ResumeLayout(false);
            this.groupBoxTask_KEA.PerformLayout();
            this.groupBoxVar_KEA.ResumeLayout(false);
            this.groupBoxRes_KEA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVar_KEA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_KEA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxButtons_KEA;
        private System.Windows.Forms.Button buttonHelp_KEA;
        private System.Windows.Forms.Button buttonSave_KEA;
        private System.Windows.Forms.Button buttonDone_KEA;
        private System.Windows.Forms.Button buttonFile_KEA;
        private System.Windows.Forms.GroupBox groupBoxTask_KEA;
        private System.Windows.Forms.TextBox textBoxTask_KEA;
        private System.Windows.Forms.GroupBox groupBoxVar_KEA;
        private System.Windows.Forms.DataGridView dataGridViewVar_KEA;
        private System.Windows.Forms.GroupBox groupBoxRes_KEA;
        private System.Windows.Forms.DataGridView dataGridViewRes_KEA;
        private System.Windows.Forms.ToolTip toolTip_KEA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_KEA;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_KEA;
    }
}

