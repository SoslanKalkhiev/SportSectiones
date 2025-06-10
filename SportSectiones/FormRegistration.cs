using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace SportSectiones
{
    
    public partial class FormRegistration : Form

    {
        private Section section;
        public FormRegistration(Section section)
        {
            InitializeComponent();
            this.section = section;
        }

        private void FormRegistation_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (section.FreeSpots > 0)
            {
                section.Students.Add($"{textBoxName.Text} (возраст: {textBoxAge.Text}, телефон: {textBoxPhone.Text})");
                MessageBox.Show("Регистрация завершена.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Мест нет.");
            }

        }
    }
}
