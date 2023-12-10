
namespace Tyuiu.KultyshevaEA.Sprint6.Task5.V11
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_KEA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KEA = new System.Windows.Forms.TextBox();
            this.groupBoxRes_KEA = new System.Windows.Forms.GroupBox();
            this.dataGridViewRes_KEA = new System.Windows.Forms.DataGridView();
            this.buttonHelp_KEA = new System.Windows.Forms.Button();
            this.buttonDone_KEA = new System.Windows.Forms.Button();
            this.buttonFile_KEA = new System.Windows.Forms.Button();
            this.chartRes_KEA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_KEA.SuspendLayout();
            this.groupBoxRes_KEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_KEA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRes_KEA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_KEA
            // 
            this.groupBoxTask_KEA.Controls.Add(this.textBoxTask_KEA);
            this.groupBoxTask_KEA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_KEA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_KEA.Name = "groupBoxTask_KEA";
            this.groupBoxTask_KEA.Size = new System.Drawing.Size(669, 97);
            this.groupBoxTask_KEA.TabIndex = 0;
            this.groupBoxTask_KEA.TabStop = false;
            this.groupBoxTask_KEA.Text = "Условие";
            // 
            // textBoxTask_KEA
            // 
            this.textBoxTask_KEA.AcceptsTab = true;
            this.textBoxTask_KEA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTask_KEA.BackColor = System.Drawing.Color.White;
            this.textBoxTask_KEA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_KEA.Location = new System.Drawing.Point(3, 22);
            this.textBoxTask_KEA.Multiline = true;
            this.textBoxTask_KEA.Name = "textBoxTask_KEA";
            this.textBoxTask_KEA.ReadOnly = true;
            this.textBoxTask_KEA.Size = new System.Drawing.Size(658, 69);
            this.textBoxTask_KEA.TabIndex = 0;
            this.textBoxTask_KEA.Text = "Прочитать данные из файла InPutFileTask5V11.txt. Вывести в dataGridView. Дан спис" +
    "ок из чисел. Вывести все числа, кратные 5. Построить диаграмму по этим значениям" +
    ". ";
            // 
            // groupBoxRes_KEA
            // 
            this.groupBoxRes_KEA.Controls.Add(this.dataGridViewRes_KEA);
            this.groupBoxRes_KEA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxRes_KEA.Location = new System.Drawing.Point(3, 97);
            this.groupBoxRes_KEA.Name = "groupBoxRes_KEA";
            this.groupBoxRes_KEA.Size = new System.Drawing.Size(211, 453);
            this.groupBoxRes_KEA.TabIndex = 1;
            this.groupBoxRes_KEA.TabStop = false;
            this.groupBoxRes_KEA.Text = "Вывод данных:";
            // 
            // dataGridViewRes_KEA
            // 
            this.dataGridViewRes_KEA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRes_KEA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewRes_KEA.ColumnHeadersVisible = false;
            this.dataGridViewRes_KEA.Location = new System.Drawing.Point(0, 25);
            this.dataGridViewRes_KEA.Name = "dataGridViewRes_KEA";
            this.dataGridViewRes_KEA.RowHeadersVisible = false;
            this.dataGridViewRes_KEA.Size = new System.Drawing.Size(205, 422);
            this.dataGridViewRes_KEA.TabIndex = 1;
            // 
            // buttonHelp_KEA
            // 
            this.buttonHelp_KEA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonHelp_KEA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_KEA.Location = new System.Drawing.Point(684, 22);
            this.buttonHelp_KEA.Name = "buttonHelp_KEA";
            this.buttonHelp_KEA.Size = new System.Drawing.Size(50, 51);
            this.buttonHelp_KEA.TabIndex = 2;
            this.buttonHelp_KEA.Text = "?";
            this.buttonHelp_KEA.UseVisualStyleBackColor = false;
            this.buttonHelp_KEA.Click += new System.EventHandler(this.buttonHelp_KEA_Click);
            // 
            // buttonDone_KEA
            // 
            this.buttonDone_KEA.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonDone_KEA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_KEA.Location = new System.Drawing.Point(740, 22);
            this.buttonDone_KEA.Name = "buttonDone_KEA";
            this.buttonDone_KEA.Size = new System.Drawing.Size(190, 51);
            this.buttonDone_KEA.TabIndex = 3;
            this.buttonDone_KEA.Text = "Выполнить";
            this.buttonDone_KEA.UseVisualStyleBackColor = false;
            this.buttonDone_KEA.Click += new System.EventHandler(this.buttonDone_KEA_Click);
            // 
            // buttonFile_KEA
            // 
            this.buttonFile_KEA.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonFile_KEA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFile_KEA.Location = new System.Drawing.Point(936, 24);
            this.buttonFile_KEA.Name = "buttonFile_KEA";
            this.buttonFile_KEA.Size = new System.Drawing.Size(162, 49);
            this.buttonFile_KEA.TabIndex = 4;
            this.buttonFile_KEA.Text = "Открыть файл";
            this.buttonFile_KEA.UseVisualStyleBackColor = false;
            this.buttonFile_KEA.Click += new System.EventHandler(this.buttonFile_KEA_Click);
            // 
            // chartRes_KEA
            // 
            this.chartRes_KEA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea7.Name = "ChartArea1";
            this.chartRes_KEA.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartRes_KEA.Legends.Add(legend7);
            this.chartRes_KEA.Location = new System.Drawing.Point(228, 111);
            this.chartRes_KEA.Name = "chartRes_KEA";
            this.chartRes_KEA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chartRes_KEA.Series.Add(series7);
            this.chartRes_KEA.Size = new System.Drawing.Size(870, 433);
            this.chartRes_KEA.TabIndex = 5;
            this.chartRes_KEA.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1110, 550);
            this.Controls.Add(this.chartRes_KEA);
            this.Controls.Add(this.buttonFile_KEA);
            this.Controls.Add(this.buttonDone_KEA);
            this.Controls.Add(this.buttonHelp_KEA);
            this.Controls.Add(this.groupBoxRes_KEA);
            this.Controls.Add(this.groupBoxTask_KEA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 | Вариант 11 | Култышева Е.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_KEA.ResumeLayout(false);
            this.groupBoxTask_KEA.PerformLayout();
            this.groupBoxRes_KEA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_KEA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRes_KEA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KEA;
        private System.Windows.Forms.TextBox textBoxTask_KEA;
        private System.Windows.Forms.GroupBox groupBoxRes_KEA;
        private System.Windows.Forms.DataGridView dataGridViewRes_KEA;
        private System.Windows.Forms.Button buttonHelp_KEA;
        private System.Windows.Forms.Button buttonDone_KEA;
        private System.Windows.Forms.Button buttonFile_KEA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes_KEA;
    }
}

