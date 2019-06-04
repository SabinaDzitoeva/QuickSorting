namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Fill_MasRandom = new System.Windows.Forms.ToolStripMenuItem();
            this.Fill_Mas = new System.Windows.Forms.ToolStripMenuItem();
            this.Fill_MasFile = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранениеРезультатовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьСтатистикуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьИтоговыйМассивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Sort = new System.Windows.Forms.Button();
            this.arrayLengthLabel = new System.Windows.Forms.Label();
            this.timeSortLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.InputTextBox = new System.Windows.Forms.RichTextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.Graf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Graf)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu,
            this.сохранениеРезультатовToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1136, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Fill_MasRandom,
            this.Fill_Mas,
            this.Fill_MasFile});
            this.Menu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(149, 24);
            this.Menu.Text = "Заполнить массив";
            this.Menu.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // Fill_MasRandom
            // 
            this.Fill_MasRandom.Name = "Fill_MasRandom";
            this.Fill_MasRandom.Size = new System.Drawing.Size(361, 24);
            this.Fill_MasRandom.Text = "Заполнить массив случайными числами";
            this.Fill_MasRandom.Click += new System.EventHandler(this.Fill_MasRandom_Click);
            // 
            // Fill_Mas
            // 
            this.Fill_Mas.Name = "Fill_Mas";
            this.Fill_Mas.Size = new System.Drawing.Size(361, 24);
            this.Fill_Mas.Text = "Ввести вручную";
            // 
            // Fill_MasFile
            // 
            this.Fill_MasFile.Name = "Fill_MasFile";
            this.Fill_MasFile.Size = new System.Drawing.Size(361, 24);
            this.Fill_MasFile.Text = "Считать из файла";
            this.Fill_MasFile.Click += new System.EventHandler(this.Fill_MasFile_Click);
            // 
            // сохранениеРезультатовToolStripMenuItem
            // 
            this.сохранениеРезультатовToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьСтатистикуToolStripMenuItem,
            this.сохранитьИтоговыйМассивToolStripMenuItem});
            this.сохранениеРезультатовToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сохранениеРезультатовToolStripMenuItem.Name = "сохранениеРезультатовToolStripMenuItem";
            this.сохранениеРезультатовToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.сохранениеРезультатовToolStripMenuItem.Text = "Сохранение результатов";
            // 
            // сохранитьСтатистикуToolStripMenuItem
            // 
            this.сохранитьСтатистикуToolStripMenuItem.Name = "сохранитьСтатистикуToolStripMenuItem";
            this.сохранитьСтатистикуToolStripMenuItem.Size = new System.Drawing.Size(277, 24);
            this.сохранитьСтатистикуToolStripMenuItem.Text = "Сохранить статистику";
            this.сохранитьСтатистикуToolStripMenuItem.Click += new System.EventHandler(this.сохранитьСтатистикуToolStripMenuItem_Click_1);
            // 
            // сохранитьИтоговыйМассивToolStripMenuItem
            // 
            this.сохранитьИтоговыйМассивToolStripMenuItem.Name = "сохранитьИтоговыйМассивToolStripMenuItem";
            this.сохранитьИтоговыйМассивToolStripMenuItem.Size = new System.Drawing.Size(277, 24);
            this.сохранитьИтоговыйМассивToolStripMenuItem.Text = "Сохранить итоговый массив";
            this.сохранитьИтоговыйМассивToolStripMenuItem.Click += new System.EventHandler(this.сохранитьИтоговыйМассивToolStripMenuItem_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gold;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 317);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 29);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Исходные элементы массива";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Gold;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(12, 467);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(273, 29);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Итоговые элементы массива";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(12, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(449, 193);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "1) Выберите способ заполнения массива в меню \"Заполнить массив\"\n2) Отсортируйте м" +
    "ассив с помощью кнопки \"Отсортировать массив\"\n3) Сохраните статистику и итоговый" +
    " результат сортировки в файл ";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Sort
            // 
            this.Sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sort.Location = new System.Drawing.Point(916, 586);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(176, 63);
            this.Sort.TabIndex = 7;
            this.Sort.Text = "Отсортировать";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // arrayLengthLabel
            // 
            this.arrayLengthLabel.AutoSize = true;
            this.arrayLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arrayLengthLabel.Location = new System.Drawing.Point(11, 433);
            this.arrayLengthLabel.Name = "arrayLengthLabel";
            this.arrayLengthLabel.Size = new System.Drawing.Size(151, 24);
            this.arrayLengthLabel.TabIndex = 8;
            this.arrayLengthLabel.Text = "Длина массива:";
            // 
            // timeSortLabel
            // 
            this.timeSortLabel.AutoSize = true;
            this.timeSortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeSortLabel.Location = new System.Drawing.Point(11, 583);
            this.timeSortLabel.Name = "timeSortLabel";
            this.timeSortLabel.Size = new System.Drawing.Size(254, 24);
            this.timeSortLabel.TabIndex = 9;
            this.timeSortLabel.Text = "Время работы сортировки:";
            this.timeSortLabel.Click += new System.EventHandler(this.timeSortLabel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputTextBox.Location = new System.Drawing.Point(12, 494);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(1112, 86);
            this.OutputTextBox.TabIndex = 13;
            this.OutputTextBox.Text = "";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputTextBox.Location = new System.Drawing.Point(11, 344);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(1113, 86);
            this.InputTextBox.TabIndex = 0;
            this.InputTextBox.Text = "";
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(703, 586);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(176, 63);
            this.ClearButton.TabIndex = 15;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Graf
            // 
            chartArea1.Name = "ChartArea1";
            this.Graf.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Graf.Legends.Add(legend1);
            this.Graf.Location = new System.Drawing.Point(547, 39);
            this.Graf.Name = "Graf";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.Graf.Series.Add(series1);
            this.Graf.Series.Add(series2);
            this.Graf.Size = new System.Drawing.Size(577, 288);
            this.Graf.TabIndex = 16;
            this.Graf.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1136, 661);
            this.Controls.Add(this.Graf);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.timeSortLabel);
            this.Controls.Add(this.arrayLengthLabel);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuickSorting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Graf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem Fill_MasRandom;
        private System.Windows.Forms.ToolStripMenuItem Fill_Mas;
        private System.Windows.Forms.ToolStripMenuItem Fill_MasFile;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.Label arrayLengthLabel;
        private System.Windows.Forms.Label timeSortLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem сохранениеРезультатовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьСтатистикуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьИтоговыйМассивToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox OutputTextBox;
        private System.Windows.Forms.RichTextBox InputTextBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graf;
    }
}

