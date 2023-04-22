using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingPractice_02
{
    public partial class GameForm : Form
    {
        private Button button;
        private int[,] mas;
        private int size;
        public GameForm()
        {
            InitializeComponent();
        } 
        public GameForm(int count):this()
        {

            size = count;
            mas = new int[size, size];
            tablePanel.Dock = DockStyle.Fill;

            tablePanel.RowCount = count;
            tablePanel.ColumnCount = count;

            var height = 100.0f / count;
            var width = 100.0f / count;


            for (var i = 0; i < count; i++)
            {

                tablePanel.RowStyles[i].SizeType = SizeType.Percent;
                tablePanel.RowStyles[i].Height = height;
                tablePanel.RowStyles.Add(new RowStyle()); 
                for(var j = 0; j < count; j++)
                {

                    tablePanel.ColumnStyles[j].SizeType = SizeType.Percent;
                    tablePanel.ColumnStyles[j].Width = width;
                    tablePanel.ColumnStyles.Add(new ColumnStyle());
                    if (i == count - 1 && j == count - 1)
                    {
                        mas[i,j] = -1;
                        break;
                    }
                    mas[i, j] = count * i + j + 1;
                    button = new Button();
                    button.Text = $"{count * i + j + 1}";
                    button.Width = ClientRectangle.Width / count;
                    button.Height = ClientRectangle.Height / count;
                    button.BackColor = Color.Orange;
                    button.ForeColor = Color.Black;
                    button.FlatStyle = FlatStyle.Flat;
                    button.Dock = DockStyle.Fill;

                    button.Click += Button_Click;
                    tablePanel.Controls.Add(button);
                    
                    
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickButton = (Button)sender;
            int.TryParse(clickButton.Text.ToString(), out int number); 
            int indexI = -1;
            int indexJ = -1;
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    if (mas[i, j] == number)
                    {
                        indexI = i;
                        indexJ = j;
                        break;
                    }
                }
                if (indexJ != -1) break;
            }
            if (indexI + 1 != size)
            {
                if (mas[indexI + 1, indexJ] == -1)
                {
                    MessageBox.Show("Кнопка может спуститься вниз");
                }
            }
            if (indexI != 0)
            {
                if (mas[indexI - 1, indexJ] == -1)
                {
                    MessageBox.Show("Кнопка может подняться вверх");
                }
            }

        }

        private void tablePanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
           // e.Graphics.DrawRectangle(new Pen(Color.Blue), e.CellBounds);
        }
    }
}
