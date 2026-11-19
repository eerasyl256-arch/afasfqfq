namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddEvent(object? sender, EventArgs e)
        {
            string name = nameTextBox.Text.Trim();
            if (name.Length < 3 || name.Length > 40)
            {
                MessageBox.Show(
                    "Название должно содержать от 3 до 40 символов.",
                    "Некорректное название",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                nameTextBox.Focus();
                return;
            }

            string format = formatComboBox.SelectedItem?.ToString() ?? "Встреча";
            eventsListBox.Items.Add($"{format} — {name}");
            ClearFields();
            UpdateCount();
            statusLabel.Text = "Событие добавлено в план.";
        }

        private void ClearButton_Click(object? sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            nameTextBox.Clear();
            formatComboBox.SelectedIndex = 0;
            nameTextBox.Focus();
        }

        private void DeleteSelectedEvent(object? sender, EventArgs e)
        {
            if (eventsListBox.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Выберите событие для удаления.",
                    "Событие не выбрано",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            eventsListBox.Items.RemoveAt(eventsListBox.SelectedIndex);
            UpdateCount();
            statusLabel.Text = "Выбранное событие удалено.";
        }

        private void UpdateCount()
        {
            countLabel.Text = $"Событий: {eventsListBox.Items.Count}";
        }
    }
}
