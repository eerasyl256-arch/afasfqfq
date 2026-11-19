namespace WinFormsApp8
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Panel headerPanel;
        private Panel counterPanel;
        private Panel leftPanel;
        private Panel rightPanel;
        private Label titleLabel;
        private Label subtitleLabel;
        private Label countLabel;
        private Label newEventLabel;
        private Label nameLabel;
        private Label formatLabel;
        private Label validationLabel;
        private Label planLabel;
        private Label deleteHintLabel;
        private Label statusLabel;
        private TextBox nameTextBox;
        private ComboBox formatComboBox;
        private ListBox eventsListBox;
        private Button addButton;
        private Button clearButton;
        private Button deleteButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            headerPanel = new Panel();
            counterPanel = new Panel();
            leftPanel = new Panel();
            rightPanel = new Panel();
            titleLabel = new Label();
            subtitleLabel = new Label();
            countLabel = new Label();
            newEventLabel = new Label();
            nameLabel = new Label();
            formatLabel = new Label();
            validationLabel = new Label();
            planLabel = new Label();
            deleteHintLabel = new Label();
            statusLabel = new Label();
            nameTextBox = new TextBox();
            formatComboBox = new ComboBox();
            eventsListBox = new ListBox();
            addButton = new Button();
            clearButton = new Button();
            deleteButton = new Button();

            headerPanel.SuspendLayout();
            counterPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            SuspendLayout();

            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 245, 251);
            ClientSize = new Size(900, 560);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(780, 520);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "События колледжа";

            headerPanel.BackColor = Color.FromArgb(39, 78, 126);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Height = 110;
            headerPanel.Padding = new Padding(24, 16, 24, 14);

            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(24, 10);
            titleLabel.Text = "События колледжа";

            subtitleLabel.AutoSize = true;
            subtitleLabel.Font = new Font("Segoe UI", 10F);
            subtitleLabel.ForeColor = Color.FromArgb(225, 233, 245);
            subtitleLabel.Location = new Point(26, 55);
            subtitleLabel.Text = "Планирование мероприятий студенческого совета";

            counterPanel.BackColor = Color.FromArgb(31, 65, 107);
            counterPanel.Location = new Point(706, 30);
            counterPanel.Size = new Size(170, 48);
            counterPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            countLabel.Dock = DockStyle.Fill;
            countLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            countLabel.ForeColor = Color.White;
            countLabel.Text = "Событий: 3";
            countLabel.TextAlign = ContentAlignment.MiddleCenter;
            counterPanel.Controls.Add(countLabel);

            headerPanel.Controls.Add(titleLabel);
            headerPanel.Controls.Add(subtitleLabel);
            headerPanel.Controls.Add(counterPanel);

            leftPanel.BackColor = Color.White;
            leftPanel.Location = new Point(22, 132);
            leftPanel.Size = new Size(300, 360);
            leftPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;

            newEventLabel.AutoSize = true;
            newEventLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            newEventLabel.ForeColor = Color.FromArgb(25, 32, 43);
            newEventLabel.Location = new Point(20, 16);
            newEventLabel.Text = "Новое событие";

            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(20, 56);
            nameLabel.Text = "Название";

            nameTextBox.Location = new Point(20, 82);
            nameTextBox.Size = new Size(260, 27);
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            formatLabel.AutoSize = true;
            formatLabel.Location = new Point(20, 122);
            formatLabel.Text = "Формат";

            formatComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            formatComboBox.Items.AddRange(new object[] { "Встреча", "Мастер-класс", "Конкурс" });
            formatComboBox.Location = new Point(20, 148);
            formatComboBox.Size = new Size(260, 28);
            formatComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            formatComboBox.SelectedIndex = 0;

            validationLabel.AutoSize = false;
            validationLabel.Font = new Font("Segoe UI", 8F);
            validationLabel.ForeColor = Color.FromArgb(120, 128, 140);
            validationLabel.Location = new Point(20, 182);
            validationLabel.Size = new Size(260, 38);
            validationLabel.Text = "От 3 до 40 символов.\nПробелы по краям удаляются.";
            validationLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            addButton.BackColor = Color.FromArgb(39, 102, 235);
            addButton.Cursor = Cursors.Hand;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(20, 232);
            addButton.Size = new Size(260, 44);
            addButton.Text = "Добавить событие";
            addButton.UseVisualStyleBackColor = false;
            addButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addButton.Click += AddEvent;

            clearButton.BackColor = Color.FromArgb(229, 234, 243);
            clearButton.Cursor = Cursors.Hand;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            clearButton.ForeColor = Color.FromArgb(35, 44, 58);
            clearButton.Location = new Point(20, 286);
            clearButton.Size = new Size(260, 44);
            clearButton.Text = "Очистить поля";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clearButton.Click += ClearButton_Click;

            leftPanel.Controls.Add(newEventLabel);
            leftPanel.Controls.Add(nameLabel);
            leftPanel.Controls.Add(nameTextBox);
            leftPanel.Controls.Add(formatLabel);
            leftPanel.Controls.Add(formatComboBox);
            leftPanel.Controls.Add(validationLabel);
            leftPanel.Controls.Add(addButton);
            leftPanel.Controls.Add(clearButton);

            rightPanel.BackColor = Color.White;
            rightPanel.Location = new Point(338, 132);
            rightPanel.Size = new Size(540, 360);
            rightPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            planLabel.AutoSize = true;
            planLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            planLabel.ForeColor = Color.FromArgb(25, 32, 43);
            planLabel.Location = new Point(20, 16);
            planLabel.Text = "План мероприятий";

            eventsListBox.Font = new Font("Segoe UI", 9F);
            eventsListBox.Items.AddRange(new object[]
            {
                "Встреча — День открытых дверей",
                "Мастер-класс — Монтаж короткого видео",
                "Конкурс — Турнир по настольным играм"
            });
            eventsListBox.Location = new Point(20, 52);
            eventsListBox.Size = new Size(500, 228);
            eventsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            deleteButton.BackColor = Color.FromArgb(229, 234, 243);
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            deleteButton.ForeColor = Color.FromArgb(35, 44, 58);
            deleteButton.Location = new Point(20, 294);
            deleteButton.Size = new Size(230, 42);
            deleteButton.Text = "Удалить выбранное";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            deleteButton.Click += DeleteSelectedEvent;

            deleteHintLabel.AutoSize = false;
            deleteHintLabel.Font = new Font("Segoe UI", 8F);
            deleteHintLabel.ForeColor = Color.FromArgb(120, 128, 140);
            deleteHintLabel.Location = new Point(266, 296);
            deleteHintLabel.Size = new Size(190, 38);
            deleteHintLabel.Text = "Удаляется только\nвыбранная запись.";
            deleteHintLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

            rightPanel.Controls.Add(planLabel);
            rightPanel.Controls.Add(eventsListBox);
            rightPanel.Controls.Add(deleteButton);
            rightPanel.Controls.Add(deleteHintLabel);

            statusLabel.AutoSize = true;
            statusLabel.ForeColor = Color.FromArgb(110, 119, 133);
            statusLabel.Location = new Point(24, 510);
            statusLabel.Text = "Добавьте событие или выберите запись справа для удаления.";
            statusLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

            Controls.Add(statusLabel);
            Controls.Add(leftPanel);
            Controls.Add(rightPanel);
            Controls.Add(headerPanel);

            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            counterPanel.ResumeLayout(false);
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
