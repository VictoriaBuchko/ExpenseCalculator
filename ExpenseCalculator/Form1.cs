namespace ExpenseCalculator
{
    public partial class Form1 : Form
    {
        private decimal totalExpenses = 0;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();
            AddCost.Click += AddCost_Click;//  ϳ������ �� ���� ���������� ������ 
            timer.Interval = 5000;
            timer.Tick += Timer_Tick; // ϳ������ �� ���� �������
            timer.Start();
        }

        // �������� ��䳿 �������
        private void Timer_Tick(object sender, EventArgs e)
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            TimeCounter.Text = $"���: {currentTime}";
        }

        // �������� ��䳿 ���������� ������ (������ �������)
        private void AddCost_Click(object? sender, EventArgs e)
        {
            //�������� �� ���� ����������
            if (string.IsNullOrWhiteSpace(CostNameBox.Text))
            {
                MessageBox.Show("���� �����, ������ ����� ������", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Categories.SelectedItem == null)
            {
                MessageBox.Show("���� �����, ������� �������� ������", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //�������� �������� ���� ������
            totalExpenses += SumNameUpDown.Value;

            //��������� ���������� ��� �������
            MessageBox.Show($"������� ������: {CostNameBox.Text}, ����: {SumNameUpDown.Value} ���, ��������: {Categories.SelectedItem}",
                            "ϳ�����������", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TotalCost.Text = $"�������� ���� ������:\n {totalExpenses} ���";

            //������� ���� ����� ���������� ��� ��������� ��
            CostNameBox.Clear();
            SumNameUpDown.Value = 0;
            Categories.SelectedItem = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
