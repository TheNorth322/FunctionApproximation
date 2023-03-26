namespace FunctionApproximation
{
    partial class FunctionApproximation
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.buildPlotsButton = new System.Windows.Forms.Button();
            this.pointsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(1003, 602);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart";
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(1040, 51);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(144, 20);
            this.filePathTextBox.TabIndex = 1;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pathLabel.Location = new System.Drawing.Point(1055, 28);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(114, 20);
            this.pathLabel.TabIndex = 2;
            this.pathLabel.Text = "Введите путь";
            // 
            // buildPlotsButton
            // 
            this.buildPlotsButton.Location = new System.Drawing.Point(1040, 91);
            this.buildPlotsButton.Name = "buildPlotsButton";
            this.buildPlotsButton.Size = new System.Drawing.Size(144, 23);
            this.buildPlotsButton.TabIndex = 3;
            this.buildPlotsButton.Text = "Построить графики";
            this.buildPlotsButton.UseVisualStyleBackColor = true;
            this.buildPlotsButton.Click += new System.EventHandler(this.buildPlotsButton_Click);
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pointsLabel.Location = new System.Drawing.Point(1037, 139);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(0, 20);
            this.pointsLabel.TabIndex = 4;
            // 
            // FunctionApproximation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 661);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.buildPlotsButton);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.chart1);
            this.Name = "FunctionApproximation";
            this.Text = "FunctionApproximation";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Button buildPlotsButton;
        private System.Windows.Forms.Label pointsLabel;
    }
}

