using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie_7._2
{
    public partial class Form1 : Form
    {
        EmployeeProcessor processor = new EmployeeProcessor();

        public Form1()
        {
            InitializeComponent();  }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Текстовые файлы (*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtInputFile.Text = ofd.FileName;
                if (string.IsNullOrEmpty(txtOutputFile.Text))
                {
                    txtOutputFile.Text = System.IO.Path.ChangeExtension(ofd.FileName, "обработанные.txt");
                }
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Текстовые файлы (*.txt)|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                txtOutputFile.Text = sfd.FileName;
            }
        }
        
        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInputFile.Text) || string.IsNullOrEmpty(txtOutputFile.Text))
            {
                MessageBox.Show("Выберите входной и выходной файлы!");
                return;
            }
            
            rtxtResult.Clear();
            processor.Process(txtInputFile.Text, txtOutputFile.Text, rtxtResult);
            MessageBox.Show("Готово!");
        }
    }
    
}
