namespace ForRuslan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BruteForceMethod = new System.Windows.Forms.Button();
            this.MethodOfUnevenCoatings = new System.Windows.Forms.Button();
            this.DrawGraph = new System.Windows.Forms.Button();
            this.GraphF = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.Iter = new System.Windows.Forms.Label();
            this.yMin = new System.Windows.Forms.Label();
            this.xMin = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.X0 = new System.Windows.Forms.TextBox();
            this.X1 = new System.Windows.Forms.TextBox();
            this.E = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GraphF)).BeginInit();
            this.SuspendLayout();
            // 
            // BruteForceMethod
            // 
            this.BruteForceMethod.Location = new System.Drawing.Point(12, 350);
            this.BruteForceMethod.Name = "BruteForceMethod";
            this.BruteForceMethod.Size = new System.Drawing.Size(171, 38);
            this.BruteForceMethod.TabIndex = 0;
            this.BruteForceMethod.Text = "Метод перебора";
            this.BruteForceMethod.UseVisualStyleBackColor = true;
            this.BruteForceMethod.Click += new System.EventHandler(this.BruteForceMethod_Click);
            // 
            // MethodOfUnevenCoatings
            // 
            this.MethodOfUnevenCoatings.Location = new System.Drawing.Point(199, 350);
            this.MethodOfUnevenCoatings.Name = "MethodOfUnevenCoatings";
            this.MethodOfUnevenCoatings.Size = new System.Drawing.Size(171, 38);
            this.MethodOfUnevenCoatings.TabIndex = 1;
            this.MethodOfUnevenCoatings.Text = "Метод неравномерных покрытий";
            this.MethodOfUnevenCoatings.UseVisualStyleBackColor = true;
            this.MethodOfUnevenCoatings.Click += new System.EventHandler(this.MethodOfUnevenCoatings_Click);
            // 
            // DrawGraph
            // 
            this.DrawGraph.Location = new System.Drawing.Point(479, 350);
            this.DrawGraph.Name = "DrawGraph";
            this.DrawGraph.Size = new System.Drawing.Size(171, 38);
            this.DrawGraph.TabIndex = 2;
            this.DrawGraph.Text = "Нарисовать график";
            this.DrawGraph.UseVisualStyleBackColor = true;
            this.DrawGraph.Click += new System.EventHandler(this.DrawGraph_Click);
            // 
            // GraphF
            // 
            chartArea1.Name = "ChartArea1";
            this.GraphF.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GraphF.Legends.Add(legend1);
            this.GraphF.Location = new System.Drawing.Point(381, 12);
            this.GraphF.Name = "GraphF";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.GraphF.Series.Add(series1);
            this.GraphF.Size = new System.Drawing.Size(337, 329);
            this.GraphF.TabIndex = 3;
            this.GraphF.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Точка минимума - ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Значение функции - ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество итераций - ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Время выполнения (мс) - ";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(170, 103);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(13, 15);
            this.Time.TabIndex = 11;
            this.Time.Text = "0";
            // 
            // Iter
            // 
            this.Iter.AutoSize = true;
            this.Iter.Location = new System.Drawing.Point(170, 78);
            this.Iter.Name = "Iter";
            this.Iter.Size = new System.Drawing.Size(13, 15);
            this.Iter.TabIndex = 10;
            this.Iter.Text = "0";
            // 
            // yMin
            // 
            this.yMin.AutoSize = true;
            this.yMin.Location = new System.Drawing.Point(170, 52);
            this.yMin.Name = "yMin";
            this.yMin.Size = new System.Drawing.Size(13, 15);
            this.yMin.TabIndex = 9;
            this.yMin.Text = "0";
            // 
            // xMin
            // 
            this.xMin.AutoSize = true;
            this.xMin.Location = new System.Drawing.Point(170, 27);
            this.xMin.Name = "xMin";
            this.xMin.Size = new System.Drawing.Size(13, 15);
            this.xMin.TabIndex = 8;
            this.xMin.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "X0 - ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "X1 - ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 15);
            this.label12.TabIndex = 14;
            this.label12.Text = "E - ";
            // 
            // X0
            // 
            this.X0.Location = new System.Drawing.Point(60, 150);
            this.X0.Name = "X0";
            this.X0.Size = new System.Drawing.Size(100, 23);
            this.X0.TabIndex = 16;
            this.X0.Text = "-6";
            // 
            // X1
            // 
            this.X1.Location = new System.Drawing.Point(60, 179);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(100, 23);
            this.X1.TabIndex = 17;
            this.X1.Text = "6";
            // 
            // E
            // 
            this.E.Location = new System.Drawing.Point(60, 208);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(100, 23);
            this.E.TabIndex = 18;
            this.E.Text = "0,001";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 398);
            this.Controls.Add(this.E);
            this.Controls.Add(this.X1);
            this.Controls.Add(this.X0);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Iter);
            this.Controls.Add(this.yMin);
            this.Controls.Add(this.xMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GraphF);
            this.Controls.Add(this.DrawGraph);
            this.Controls.Add(this.MethodOfUnevenCoatings);
            this.Controls.Add(this.BruteForceMethod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "RuslanWork";
            ((System.ComponentModel.ISupportInitialize)(this.GraphF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BruteForceMethod;
        private Button MethodOfUnevenCoatings;
        private Button DrawGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraphF;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label Time;
        private Label Iter;
        private Label yMin;
        private Label xMin;
        private Label label9;
        private Label label10;
        private Label label12;
        private TextBox X0;
        private TextBox X1;
        private TextBox E;
    }
}