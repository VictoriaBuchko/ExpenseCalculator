namespace ExpenseCalculator
{
    public partial class Form1 : Form
    {
        private decimal totalExpenses = 0;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();
            AddCost.Click += AddCost_Click;//  Підписка на подію натискання кнопки 
            timer.Interval = 5000;
            timer.Tick += Timer_Tick; // Підписка на подію таймера
            timer.Start();
        }

        // Обробник події таймера
        private void Timer_Tick(object sender, EventArgs e)
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            TimeCounter.Text = $"Час: {currentTime}";
        }

        // Обробник події напискання кнопки (Додати витрати)
        private void AddCost_Click(object? sender, EventArgs e)
        {
            //Перевірки на ввод інформації
            if (string.IsNullOrWhiteSpace(CostNameBox.Text))
            {
                MessageBox.Show("Будь ласка, введіть назву витрат", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Categories.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, виберіть категорію витрат", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //лічильник загальної суми витрат
            totalExpenses += SumNameUpDown.Value;

            //виведення інформації про витрати
            MessageBox.Show($"Витрати додано: {CostNameBox.Text}, Сума: {SumNameUpDown.Value} грн, Категорія: {Categories.SelectedItem}",
                            "Підтвердження", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TotalCost.Text = $"Загальна сума витрат:\n {totalExpenses} грн";

            //очищуємо поля вводу інформації для наступних дій
            CostNameBox.Clear();
            SumNameUpDown.Value = 0;
            Categories.SelectedItem = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
