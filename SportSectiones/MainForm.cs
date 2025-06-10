using static System.Collections.Specialized.BitVector32;

namespace SportSectiones
{
    public partial class MainForm : Form
    {
        private List<Section> sections = new List<Section>();
        public MainForm()
        {
            InitializeComponent();
            sections.Add(new Section("������", "���� ����������", 22));
            sections.Add(new Section("���������", "�������� ���������", 16));
            sections.Add(new Section("���������� ������", "������ ����������", 12));
            sections.Add(new Section("��������", "��������� ���������", 8));
            sections.Add(new Section("������� ��������", "����� ����������", 30));
            sections.Add(new Section("�������", "������ �������������", 10));
            UpdateSectionsList();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void listBoxSections_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSections.SelectedIndex != -1)
            {
                Section selectedSection = sections[listBoxSections.SelectedIndex];
                FormRegistration formReg = new FormRegistration(selectedSection);
                formReg.ShowDialog();

                UpdateSectionsList();
            }
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            foreach (Section section in sections)
            {
                if (section.FreeSpots < 3)
                {
                    MessageBox.Show($"������ \"{section.Name}\" ������� �������� ��������������.");
                }
            }
        }
        private void UpdateSectionsList()
        {
            listBoxSections.Items.Clear();
            foreach (Section section in sections)
            {
                listBoxSections.Items.Add(section.Name);
            }
        }
    }
}
