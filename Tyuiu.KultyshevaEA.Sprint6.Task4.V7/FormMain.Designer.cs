
namespace Tyuiu.KultyshevaEA.Sprint6.Task4.V7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_KEA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KEA = new System.Windows.Forms.TextBox();
            this.groupBoxVar_KEA = new System.Windows.Forms.GroupBox();
            this.labelStopStep_KEA = new System.Windows.Forms.Label();
            this.textBoxStopStep_KEA = new System.Windows.Forms.TextBox();
            this.labelStartStep_KEA = new System.Windows.Forms.Label();
            this.textBoxStartStep_KEA = new System.Windows.Forms.TextBox();
            this.groupBoxResult_KEA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_KEA = new System.Windows.Forms.TextBox();
            this.buttonHelp_KEA = new System.Windows.Forms.Button();
            this.buttonDone_KEA = new System.Windows.Forms.Button();
            this.buttonSave_KEA = new System.Windows.Forms.Button();
            this.chartResult_KEA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_KEA.SuspendLayout();
            this.groupBoxVar_KEA.SuspendLayout();
            this.groupBoxResult_KEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_KEA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_KEA
            // 
            this.groupBoxTask_KEA.Controls.Add(this.textBoxTask_KEA);
            this.groupBoxTask_KEA.Font = new System.Drawing.Font("NSimSun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTask_KEA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_KEA.Name = "groupBoxTask_KEA";
            this.groupBoxTask_KEA.Size = new System.Drawing.Size(687, 175);
            this.groupBoxTask_KEA.TabIndex = 0;
            this.groupBoxTask_KEA.TabStop = false;
            this.groupBoxTask_KEA.Text = "Условие";
            // 
            // textBoxTask_KEA
            // 
            this.textBoxTask_KEA.Location = new System.Drawing.Point(3, 21);
            this.textBoxTask_KEA.Multiline = true;
            this.textBoxTask_KEA.Name = "textBoxTask_KEA";
            this.textBoxTask_KEA.ReadOnly = true;
            this.textBoxTask_KEA.Size = new System.Drawing.Size(675, 148);
            this.textBoxTask_KEA.TabIndex = 0;
            this.textBoxTask_KEA.Text = resources.GetString("textBoxTask_KEA.Text");
            // 
            // groupBoxVar_KEA
            // 
            this.groupBoxVar_KEA.Controls.Add(this.labelStopStep_KEA);
            this.groupBoxVar_KEA.Controls.Add(this.textBoxStopStep_KEA);
            this.groupBoxVar_KEA.Controls.Add(this.labelStartStep_KEA);
            this.groupBoxVar_KEA.Controls.Add(this.textBoxStartStep_KEA);
            this.groupBoxVar_KEA.Font = new System.Drawing.Font("NSimSun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxVar_KEA.Location = new System.Drawing.Point(693, 12);
            this.groupBoxVar_KEA.Name = "groupBoxVar_KEA";
            this.groupBoxVar_KEA.Size = new System.Drawing.Size(302, 163);
            this.groupBoxVar_KEA.TabIndex = 1;
            this.groupBoxVar_KEA.TabStop = false;
            this.groupBoxVar_KEA.Text = "Ввод данных:";
            // 
            // labelStopStep_KEA
            // 
            this.labelStopStep_KEA.AutoSize = true;
            this.labelStopStep_KEA.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStopStep_KEA.Location = new System.Drawing.Point(150, 21);
            this.labelStopStep_KEA.Name = "labelStopStep_KEA";
            this.labelStopStep_KEA.Size = new System.Drawing.Size(138, 13);
            this.labelStopStep_KEA.TabIndex = 3;
            this.labelStopStep_KEA.Text = "Конец шага:";
            // 
            // textBoxStopStep_KEA
            // 
            this.textBoxStopStep_KEA.Location = new System.Drawing.Point(224, 46);
            this.textBoxStopStep_KEA.Multiline = true;
            this.textBoxStopStep_KEA.Name = "textBoxStopStep_KEA";
            this.textBoxStopStep_KEA.Size = new System.Drawing.Size(72, 44);
            this.textBoxStopStep_KEA.TabIndex = 2;
            this.textBoxStopStep_KEA.Text = "5";
            // 
            // labelStartStep_KEA
            // 
            this.labelStartStep_KEA.AutoSize = true;
            this.labelStartStep_KEA.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartStep_KEA.Location = new System.Drawing.Point(6, 21);
            this.labelStartStep_KEA.Name = "labelStartStep_KEA";
            this.labelStartStep_KEA.Size = new System.Drawing.Size(138, 13);
            this.labelStartStep_KEA.TabIndex = 1;
            this.labelStartStep_KEA.Text = "Старт шага:";
            // 
            // textBoxStartStep_KEA
            // 
            this.textBoxStartStep_KEA.Location = new System.Drawing.Point(9, 46);
            this.textBoxStartStep_KEA.Multiline = true;
            this.textBoxStartStep_KEA.Name = "textBoxStartStep_KEA";
            this.textBoxStartStep_KEA.Size = new System.Drawing.Size(69, 44);
            this.textBoxStartStep_KEA.TabIndex = 0;
            this.textBoxStartStep_KEA.Text = "-5";
            // 
            // groupBoxResult_KEA
            // 
            this.groupBoxResult_KEA.Controls.Add(this.textBoxResult_KEA);
            this.groupBoxResult_KEA.Font = new System.Drawing.Font("NSimSun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxResult_KEA.Location = new System.Drawing.Point(3, 175);
            this.groupBoxResult_KEA.Name = "groupBoxResult_KEA";
            this.groupBoxResult_KEA.Size = new System.Drawing.Size(387, 525);
            this.groupBoxResult_KEA.TabIndex = 1;
            this.groupBoxResult_KEA.TabStop = false;
            this.groupBoxResult_KEA.Text = "Вывод:";
            // 
            // textBoxResult_KEA
            // 
            this.textBoxResult_KEA.Location = new System.Drawing.Point(6, 24);
            this.textBoxResult_KEA.Multiline = true;
            this.textBoxResult_KEA.Name = "textBoxResult_KEA";
            this.textBoxResult_KEA.ReadOnly = true;
            this.textBoxResult_KEA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_KEA.Size = new System.Drawing.Size(375, 495);
            this.textBoxResult_KEA.TabIndex = 4;
            // 
            // buttonHelp_KEA
            // 
            this.buttonHelp_KEA.Font = new System.Drawing.Font("NSimSun", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp_KEA.Location = new System.Drawing.Point(1025, 58);
            this.buttonHelp_KEA.Name = "buttonHelp_KEA";
            this.buttonHelp_KEA.Size = new System.Drawing.Size(55, 44);
            this.buttonHelp_KEA.TabIndex = 5;
            this.buttonHelp_KEA.Text = "?";
            this.buttonHelp_KEA.UseVisualStyleBackColor = true;
            this.buttonHelp_KEA.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonDone_KEA
            // 
            this.buttonDone_KEA.BackColor = System.Drawing.Color.Violet;
            this.buttonDone_KEA.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDone_KEA.Location = new System.Drawing.Point(1086, 58);
            this.buttonDone_KEA.Name = "buttonDone_KEA";
            this.buttonDone_KEA.Size = new System.Drawing.Size(165, 44);
            this.buttonDone_KEA.TabIndex = 6;
            this.buttonDone_KEA.Text = "Выполнить";
            this.buttonDone_KEA.UseVisualStyleBackColor = false;
            this.buttonDone_KEA.Click += new System.EventHandler(this.buttonDone_KEA_Click);
            // 
            // buttonSave_KEA
            // 
            this.buttonSave_KEA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSave_KEA.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave_KEA.Location = new System.Drawing.Point(1257, 58);
            this.buttonSave_KEA.Name = "buttonSave_KEA";
            this.buttonSave_KEA.Size = new System.Drawing.Size(153, 44);
            this.buttonSave_KEA.TabIndex = 7;
            this.buttonSave_KEA.Text = "Сохранить";
            this.buttonSave_KEA.UseVisualStyleBackColor = false;
            this.buttonSave_KEA.Click += new System.EventHandler(this.buttonSave_KEA_Click);
            // 
            // chartResult_KEA
            // 
            this.chartResult_KEA.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chartResult_KEA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartResult_KEA.Legends.Add(legend1);
            this.chartResult_KEA.Location = new System.Drawing.Point(407, 181);
            this.chartResult_KEA.Name = "chartResult_KEA";
            this.chartResult_KEA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.BorderColor = System.Drawing.Color.White;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartResult_KEA.Series.Add(series1);
            this.chartResult_KEA.Size = new System.Drawing.Size(1003, 519);
            this.chartResult_KEA.TabIndex = 8;
            this.chartResult_KEA.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1422, 712);
            this.Controls.Add(this.chartResult_KEA);
            this.Controls.Add(this.buttonSave_KEA);
            this.Controls.Add(this.buttonDone_KEA);
            this.Controls.Add(this.buttonHelp_KEA);
            this.Controls.Add(this.groupBoxResult_KEA);
            this.Controls.Add(this.groupBoxVar_KEA);
            this.Controls.Add(this.groupBoxTask_KEA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 4 | Вариант 7 | Култышева Е.А.";
            this.groupBoxTask_KEA.ResumeLayout(false);
            this.groupBoxTask_KEA.PerformLayout();
            this.groupBoxVar_KEA.ResumeLayout(false);
            this.groupBoxVar_KEA.PerformLayout();
            this.groupBoxResult_KEA.ResumeLayout(false);
            this.groupBoxResult_KEA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_KEA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KEA;
        private System.Windows.Forms.TextBox textBoxTask_KEA;
        private System.Windows.Forms.GroupBox groupBoxVar_KEA;
        private System.Windows.Forms.Label labelStopStep_KEA;
        private System.Windows.Forms.TextBox textBoxStopStep_KEA;
        private System.Windows.Forms.Label labelStartStep_KEA;
        private System.Windows.Forms.TextBox textBoxStartStep_KEA;
        private System.Windows.Forms.GroupBox groupBoxResult_KEA;
        private System.Windows.Forms.TextBox textBoxResult_KEA;
        private System.Windows.Forms.Button buttonHelp_KEA;
        private System.Windows.Forms.Button buttonDone_KEA;
        private System.Windows.Forms.Button buttonSave_KEA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_KEA;
    }
}

