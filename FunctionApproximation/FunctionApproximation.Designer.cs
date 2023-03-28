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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.buildPlotsButton = new System.Windows.Forms.Button();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            legend7.IsTextAutoFit = false;
            legend7.Name = "Legend1";
            legend7.Title = "Многочлены";
            legend7.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(653, 537);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart";
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filePathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.filePathTextBox.Location = new System.Drawing.Point(39, 80);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(190, 31);
            this.filePathTextBox.TabIndex = 1;
            // 
            // pathLabel
            // 
            this.pathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.pathLabel.Location = new System.Drawing.Point(68, 34);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(138, 25);
            this.pathLabel.TabIndex = 2;
            this.pathLabel.Text = "Введите путь";
            // 
            // buildPlotsButton
            // 
            this.buildPlotsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buildPlotsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.buildPlotsButton.Location = new System.Drawing.Point(63, 134);
            this.buildPlotsButton.Name = "buildPlotsButton";
            this.buildPlotsButton.Size = new System.Drawing.Size(143, 34);
            this.buildPlotsButton.TabIndex = 3;
            this.buildPlotsButton.Text = "Построить графики";
            this.buildPlotsButton.UseVisualStyleBackColor = true;
            this.buildPlotsButton.Click += new System.EventHandler(this.buildPlotsButton_Click);
            // 
            // pointsLabel
            // 
            this.pointsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.pointsLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pointsLabel.Location = new System.Drawing.Point(96, 195);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(0, 25);
            this.pointsLabel.TabIndex = 4;
            this.pointsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.chart1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(923, 543);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pathLabel);
            this.panel1.Controls.Add(this.pointsLabel);
            this.panel1.Controls.Add(this.filePathTextBox);
            this.panel1.Controls.Add(this.buildPlotsButton);
            this.panel1.Location = new System.Drawing.Point(662, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 537);
            this.panel1.TabIndex = 1;
            // 
            // FunctionApproximation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 563);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FunctionApproximation";
            this.Text = "FunctionApproximation";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Button buildPlotsButton;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}

