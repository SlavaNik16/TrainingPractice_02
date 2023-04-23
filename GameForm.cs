using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        public GameForm(int count) : this()
        {

            size = count;
            mas = new int[count, count];
            Shuffle();

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
                for (var j = 0; j < count; j++)
                {

                    tablePanel.ColumnStyles[j].SizeType = SizeType.Percent;
                    tablePanel.ColumnStyles[j].Width = width;
                    tablePanel.ColumnStyles.Add(new ColumnStyle());
                    if (mas[i, j] == -1)
                    {
                        tablePanel.Controls.Add(new Label());
                    }
                    else
                    {
                        button = new Button();
                        button.Text = $"{mas[i, j]}";
                        button.Font = new Font("Times New Roman", 24);
                        if (count > 10)
                        {
                            button.Font = new Font("Times New Roman", 14);
                        }
                        button.Width = ClientRectangle.Width / count;
                        button.Height = ClientRectangle.Height / count;
                        button.BackColor = Color.Orange;
                        button.ForeColor = Color.Black;
                        button.FlatStyle = FlatStyle.Flat;
                        button.Dock = DockStyle.Fill;
                        tablePanel.Controls.Add(button);
                        button.Click += Button_Click;
                    }

                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickButton = (Button)sender;
            int.TryParse(clickButton.Text.ToString(), out int number);
            int indexI = -1;
            int indexJ = -1;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
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

            Control positionStart = tablePanel.GetControlFromPosition(indexJ, indexI);
            int temp;
            if (positionStart != null)
            {
                if (indexI + 1 != size)
                {
                    if (mas[indexI + 1, indexJ] == -1)
                    {
                        //MessageBox.Show("Кнопка может переместиться вниз");
                        SwapCellsRight(positionStart, indexI + 1, indexJ);
                        temp = mas[indexI, indexJ];
                        mas[indexI, indexJ] = mas[indexI + 1, indexJ];
                        mas[indexI + 1, indexJ] = temp;
                    }
                }
                if (indexI != 0)
                {
                    if (mas[indexI - 1, indexJ] == -1)
                    {
                        //MessageBox.Show("Кнопка может переместиться вверх");
                        SwapCellsLeft(positionStart, indexI - 1, indexJ);
                        temp = mas[indexI, indexJ];
                        mas[indexI, indexJ] = mas[indexI - 1, indexJ];
                        mas[indexI - 1, indexJ] = temp;
                    }
                }

                if (indexJ + 1 != size)
                {
                    if (mas[indexI, indexJ + 1] == -1)
                    {

                        //MessageBox.Show("Кнопка может переместиться вправо");
                        SwapCellsRight(positionStart, indexI, indexJ + 1);

                        temp = mas[indexI, indexJ];
                        mas[indexI, indexJ] = mas[indexI, indexJ + 1];
                        mas[indexI, indexJ + 1] = temp;

                    }
                }

                if (indexJ != 0)
                {
                    if (mas[indexI, indexJ - 1] == -1)
                    {

                        //MessageBox.Show("Кнопка может переместиться влево");
                        SwapCellsLeft(positionStart, indexI, indexJ - 1);
                        temp = mas[indexI, indexJ];
                        mas[indexI, indexJ] = mas[indexI, indexJ - 1];
                        mas[indexI, indexJ - 1] = temp;

                    }
                }
            }
            if (isWin())
            {
                MessageBox.Show("Поздравляю вы победили!", "Ура!!!");
                Close();
            }



        }

        private void SwapCellsLeft(Control positionStart, int indexINext, int indexJNext)
        {

            Control positionEnd = tablePanel.GetControlFromPosition(indexJNext, indexINext);

            if (positionEnd != null)
            {

                var cellStart = tablePanel.GetPositionFromControl(positionStart);
                var cellEnd = tablePanel.GetPositionFromControl(positionEnd);
                tablePanel.SetCellPosition(positionStart, cellEnd);
                tablePanel.SetCellPosition(positionEnd, cellStart);


            }
        }
        private void SwapCellsRight(Control positionStart, int indexINext, int indexJNext)
        {

            Control positionEnd = tablePanel.GetControlFromPosition(indexJNext, indexINext);

            if (positionEnd != null)
            {

                var cellStart = tablePanel.GetPositionFromControl(positionStart);
                var cellEnd = tablePanel.GetPositionFromControl(positionEnd);
                tablePanel.SetCellPosition(positionEnd, cellStart);
                tablePanel.SetCellPosition(positionStart, cellEnd);


            }
        }

        private void Shuffle()
        {
            for (int m = 0; m < size; m++)
            {
                for (int n = 0; n < size; n++)
                {
                    mas[m, n] = 0;
                }
                if (m == size - 1) mas[m, size - 1] = -1;
            }
            int num = 1, i, j;
            var rnd = new Random();
            while (num != size * size)
            {
                i = rnd.Next(size);
                j = rnd.Next(size);
                if (num == size * size - 1)
                {
                    if (size == 4)
                    {
                        int temp;
                        if (mas[i, j] == 0)
                        {
                            temp = mas[size - 1, size - 2];
                            mas[size - 1, size - 2] = num;
                            mas[i, j] = temp;
                            break;
                        }
                    }
                }

                if (mas[i, j] == 0)
                {
                    mas[i, j] = num;
                    num++;

                }
            }
            mas[size - 1, size - 1] = -1;
            if (!isShuffle()) Shuffle(); }

        private bool isWin()
        {

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == size - 1 && j == size - 1)
                    {
                        if (mas[i, j] == -1) return true;
                    }
                    if (mas[i, j] != size * i + j + 1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool isShuffle()
        {
            int num = 0;
            int countMess = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    num++;
                    if (num == size * size)
                    {
                        num = -1;
                    }
                    if (mas[i, j] != num)
                    {
                        countMess++;
                    }
                }
            }
            //if (countMess % 2 == 0 && countMess != size * size - 2) return true;
            if ((countMess % 2 != 0 && size % 2 != 0) ||
                (countMess % 2 == 0 && size % 2 == 0)) return true;
            return false;
        }
    }
}
