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
        public GameForm()
        {
            InitializeComponent();
        } 
        public GameForm(int count):this()
        {
            var form = new GameForm();

            tablePanel.Dock = DockStyle.Fill;

            tablePanel.RowCount = count;
            tablePanel.ColumnCount = count;

            var height = 100.0f / count;
            var width = 100.0f / count;

            //form.Width = (int)(ClientRectangle.Width - (ClientRectangle.Width * width /100f));
            //form.Height = (int)(ClientRectangle.Height - (ClientRectangle.Height * height /100f));
            

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
                        break;
                    
                   
                    Button button = new Button();
                    button.Text = $"{count * i + j + 1}";
                    button.Width = ClientRectangle.Width / count;
                    button.Height = ClientRectangle.Height / count;
                    button.BackColor = Color.Orange;
                    button.Dock = DockStyle.Fill;
                   
                    tablePanel.Controls.Add(button);
                    
                    
                }
            }
        }

        private void tablePanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Blue), e.CellBounds);
        }
    }
}
