namespace ExpenseCalculator
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
            CostName = new Label();
            CostNameBox = new TextBox();
            SumName = new Label();
            SumNameUpDown = new NumericUpDown();
            Category = new Label();
            Categories = new ComboBox();
            AddCost = new Button();
            TotalCost = new Label();
            TimeCounter = new Label();
            ((System.ComponentModel.ISupportInitialize)SumNameUpDown).BeginInit();
            SuspendLayout();
            // 
            // CostName
            // 
            CostName.AutoSize = true;
            CostName.Location = new Point(32, 17);
            CostName.Name = "CostName";
            CostName.Size = new Size(104, 20);
            CostName.TabIndex = 0;
            CostName.Text = "Назва витрат:";
            // 
            // CostNameBox
            // 
            CostNameBox.Location = new Point(31, 40);
            CostNameBox.Name = "CostNameBox";
            CostNameBox.Size = new Size(125, 27);
            CostNameBox.TabIndex = 1;
            // 
            // SumName
            // 
            SumName.AutoSize = true;
            SumName.Location = new Point(32, 81);
            SumName.Name = "SumName";
            SumName.Size = new Size(97, 20);
            SumName.TabIndex = 2;
            SumName.Text = "Сума витрат:";
            // 
            // SumNameUpDown
            // 
            SumNameUpDown.Location = new Point(32, 117);
            SumNameUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            SumNameUpDown.Name = "SumNameUpDown";
            SumNameUpDown.Size = new Size(150, 27);
            SumNameUpDown.TabIndex = 3;
            // 
            // Category
            // 
            Category.AutoSize = true;
            Category.Location = new Point(32, 167);
            Category.Name = "Category";
            Category.Size = new Size(79, 20);
            Category.TabIndex = 4;
            Category.Text = "Категорія:";
            // 
            // Categories
            // 
            Categories.FormattingEnabled = true;
            Categories.Items.AddRange(new object[] { "Харчування", "Транспорт", "Спорт", "Розваги", "Побутові товари" });
            Categories.Location = new Point(34, 202);
            Categories.Name = "Categories";
            Categories.Size = new Size(151, 28);
            Categories.TabIndex = 5;
            // 
            // AddCost
            // 
            AddCost.Location = new Point(260, 201);
            AddCost.Name = "AddCost";
            AddCost.Size = new Size(94, 29);
            AddCost.TabIndex = 6;
            AddCost.Text = "Додати витрати";
            AddCost.UseVisualStyleBackColor = true;
            // 
            // TotalCost
            // 
            TotalCost.AutoSize = true;
            TotalCost.Location = new Point(202, 81);
            TotalCost.Name = "TotalCost";
            TotalCost.Size = new Size(168, 20);
            TotalCost.TabIndex = 7;
            TotalCost.Text = "Загальна сума витрати";
            // 
            // TimeCounter
            // 
            TimeCounter.AutoSize = true;
            TimeCounter.Location = new Point(239, 17);
            TimeCounter.Name = "TimeCounter";
            TimeCounter.Size = new Size(41, 20);
            TimeCounter.TabIndex = 8;
            TimeCounter.Text = "Час: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 253);
            Controls.Add(TimeCounter);
            Controls.Add(TotalCost);
            Controls.Add(AddCost);
            Controls.Add(Categories);
            Controls.Add(Category);
            Controls.Add(SumNameUpDown);
            Controls.Add(SumName);
            Controls.Add(CostNameBox);
            Controls.Add(CostName);
            Name = "Form1";
            Text = "Калькулятор витрат";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)SumNameUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CostName;
        private TextBox CostNameBox;
        private Label SumName;
        private NumericUpDown SumNameUpDown;
        private Label Category;
        private ComboBox Categories;
        private Button AddCost;
        private Label TotalCost;
        private Label TimeCounter;
    }
}
