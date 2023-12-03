
namespace Tyuiu.KultyshevaEA.Sprint6.Task3.V12
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
            this.groupBoxTask_KEA = new System.Windows.Forms.GroupBox();
            this.dataGridViewMTRX_KEA = new System.Windows.Forms.DataGridView();
            this.textBoxTask_KEA = new System.Windows.Forms.TextBox();
            this.groupBoxResult_KEA = new System.Windows.Forms.GroupBox();
            this.buttonDone_KEA = new System.Windows.Forms.Button();
            this.buttonInfo_KEA = new System.Windows.Forms.Button();
            this.Result_KEA = new System.Windows.Forms.DataGridView();
            this.labelResult_KEA = new System.Windows.Forms.Label();
            this.groupBoxTask_KEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMTRX_KEA)).BeginInit();
            this.groupBoxResult_KEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Result_KEA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_KEA
            // 
            this.groupBoxTask_KEA.Controls.Add(this.dataGridViewMTRX_KEA);
            this.groupBoxTask_KEA.Controls.Add(this.textBoxTask_KEA);
            this.groupBoxTask_KEA.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_KEA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_KEA.Name = "groupBoxTask_KEA";
            this.groupBoxTask_KEA.Size = new System.Drawing.Size(656, 445);
            this.groupBoxTask_KEA.TabIndex = 0;
            this.groupBoxTask_KEA.TabStop = false;
            this.groupBoxTask_KEA.Text = "Условие";
            // 
            // dataGridViewMTRX_KEA
            // 
            this.dataGridViewMTRX_KEA.AllowUserToAddRows = false;
            this.dataGridViewMTRX_KEA.AllowUserToDeleteRows = false;
            this.dataGridViewMTRX_KEA.AllowUserToResizeColumns = false;
            this.dataGridViewMTRX_KEA.AllowUserToResizeRows = false;
            this.dataGridViewMTRX_KEA.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewMTRX_KEA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMTRX_KEA.ColumnHeadersVisible = false;
            this.dataGridViewMTRX_KEA.Location = new System.Drawing.Point(346, 85);
            this.dataGridViewMTRX_KEA.Name = "dataGridViewMTRX_KEA";
            this.dataGridViewMTRX_KEA.ReadOnly = true;
            this.dataGridViewMTRX_KEA.RowHeadersVisible = false;
            this.dataGridViewMTRX_KEA.Size = new System.Drawing.Size(285, 235);
            this.dataGridViewMTRX_KEA.TabIndex = 1;
            // 
            // textBoxTask_KEA
            // 
            this.textBoxTask_KEA.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_KEA.Location = new System.Drawing.Point(3, 31);
            this.textBoxTask_KEA.Multiline = true;
            this.textBoxTask_KEA.Name = "textBoxTask_KEA";
            this.textBoxTask_KEA.ReadOnly = true;
            this.textBoxTask_KEA.Size = new System.Drawing.Size(311, 395);
            this.textBoxTask_KEA.TabIndex = 0;
            this.textBoxTask_KEA.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в первой строке на 0.\r\n-6 -" +
    "13  -1  -7  10\r\n  14 -18  18   1  11\r\n  -2 -17 -15 -10  -8\r\n  19  -4  -6 -11   8" +
    "\r\n -17  17  14  13  19\r\n";
            // 
            // groupBoxResult_KEA
            // 
            this.groupBoxResult_KEA.Controls.Add(this.buttonDone_KEA);
            this.groupBoxResult_KEA.Controls.Add(this.buttonInfo_KEA);
            this.groupBoxResult_KEA.Controls.Add(this.Result_KEA);
            this.groupBoxResult_KEA.Controls.Add(this.labelResult_KEA);
            this.groupBoxResult_KEA.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxResult_KEA.Location = new System.Drawing.Point(662, 12);
            this.groupBoxResult_KEA.Name = "groupBoxResult_KEA";
            this.groupBoxResult_KEA.Size = new System.Drawing.Size(321, 433);
            this.groupBoxResult_KEA.TabIndex = 2;
            this.groupBoxResult_KEA.TabStop = false;
            this.groupBoxResult_KEA.Text = "Выход данных:";
            // 
            // buttonDone_KEA
            // 
            this.buttonDone_KEA.BackColor = System.Drawing.Color.Aqua;
            this.buttonDone_KEA.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_KEA.Location = new System.Drawing.Point(92, 358);
            this.buttonDone_KEA.Name = "buttonDone_KEA";
            this.buttonDone_KEA.Size = new System.Drawing.Size(211, 55);
            this.buttonDone_KEA.TabIndex = 4;
            this.buttonDone_KEA.Text = "Выполнить";
            this.buttonDone_KEA.UseVisualStyleBackColor = false;
            this.buttonDone_KEA.Click += new System.EventHandler(this.buttonDone_KEA_Click);
            // 
            // buttonInfo_KEA
            // 
            this.buttonInfo_KEA.BackColor = System.Drawing.Color.Aqua;
            this.buttonInfo_KEA.Location = new System.Drawing.Point(18, 358);
            this.buttonInfo_KEA.Name = "buttonInfo_KEA";
            this.buttonInfo_KEA.Size = new System.Drawing.Size(68, 56);
            this.buttonInfo_KEA.TabIndex = 3;
            this.buttonInfo_KEA.Text = "?";
            this.buttonInfo_KEA.UseVisualStyleBackColor = false;
            this.buttonInfo_KEA.Click += new System.EventHandler(this.buttonInfo_KEA_Click);
            // 
            // Result_KEA
            // 
            this.Result_KEA.AllowUserToAddRows = false;
            this.Result_KEA.AllowUserToDeleteRows = false;
            this.Result_KEA.AllowUserToResizeColumns = false;
            this.Result_KEA.AllowUserToResizeRows = false;
            this.Result_KEA.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Result_KEA.ColumnHeadersHeight = 45;
            this.Result_KEA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Result_KEA.ColumnHeadersVisible = false;
            this.Result_KEA.Location = new System.Drawing.Point(18, 73);
            this.Result_KEA.Name = "Result_KEA";
            this.Result_KEA.ReadOnly = true;
            this.Result_KEA.RowHeadersVisible = false;
            this.Result_KEA.RowHeadersWidth = 45;
            this.Result_KEA.Size = new System.Drawing.Size(285, 235);
            this.Result_KEA.TabIndex = 2;
            this.Result_KEA.TabStop = false;
            // 
            // labelResult_KEA
            // 
            this.labelResult_KEA.AutoSize = true;
            this.labelResult_KEA.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult_KEA.Location = new System.Drawing.Point(75, 26);
            this.labelResult_KEA.Name = "labelResult_KEA";
            this.labelResult_KEA.Size = new System.Drawing.Size(78, 29);
            this.labelResult_KEA.TabIndex = 0;
            this.labelResult_KEA.Text = "Результат";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(995, 450);
            this.Controls.Add(this.groupBoxResult_KEA);
            this.Controls.Add(this.groupBoxTask_KEA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 3 | Вариант 12 | Култышева Е.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_KEA.ResumeLayout(false);
            this.groupBoxTask_KEA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMTRX_KEA)).EndInit();
            this.groupBoxResult_KEA.ResumeLayout(false);
            this.groupBoxResult_KEA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Result_KEA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KEA;
        private System.Windows.Forms.TextBox textBoxTask_KEA;
        private System.Windows.Forms.DataGridView dataGridViewMTRX_KEA;
        private System.Windows.Forms.GroupBox groupBoxResult_KEA;
        private System.Windows.Forms.Button buttonDone_KEA;
        private System.Windows.Forms.Button buttonInfo_KEA;
        private System.Windows.Forms.DataGridView Result_KEA;
        private System.Windows.Forms.Label labelResult_KEA;
    }
}

