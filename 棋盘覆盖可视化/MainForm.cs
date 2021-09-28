using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace Visualize_Chessboard_Cover
{
    public partial class MainForm : Form
    {
        private int m_size;
        private int m_specialX;
        private int m_specialY;
        private bool m_isInitialize;
        private List<List<int>> m_board;
        private int m_LIndex;
        private int m_drawIndex;
        private readonly Graphics m_graphics;
        private readonly List<List<int>> m_colors;
        public MainForm()
        {
            InitializeComponent();
            m_graphics = CreateGraphics();
            sizeCombo.SelectedIndex = 0;
            m_size = 1;
            m_specialX = 1;
            m_specialY = 1;
            m_colors = new();
        }
        private void ChessboardCover(int topX, int topY, int specialX, int specialY, int size)
        {
            if (size == 1)
            {
                return;
            }
            size /= 2;
            int LIndex = m_LIndex++;
            if (topX + size > specialX && topY + size > specialY)
            {
                ChessboardCover(topX, topY, specialX, specialY, size);
            }
            else
            {
                m_board[topX + size - 1][topY + size - 1] = LIndex;
                ChessboardCover(topX, topY, topX + size - 1, topY + size - 1, size);
            }
            if (topX + size > specialX && topY + size <= specialY)
            {
                ChessboardCover(topX, topY + size, specialX, specialY, size);
            }
            else
            {
                m_board[topX + size - 1][topY + size] = LIndex;
                ChessboardCover(topX, topY + size, topX + size - 1, topY + size, size);
            }
            if (topX + size <= specialX && topY + size > specialY)
            {
                ChessboardCover(topX + size, topY, specialX, specialY, size);
            }
            else
            {
                m_board[topX + size][topY + size - 1] = LIndex;
                ChessboardCover(topX + size, topY, topX + size, topY + size - 1, size);
            }
            if (topX + size <= specialX && topY + size <= specialY)
            {
                ChessboardCover(topX + size, topY + size, specialX, specialY, size);
            }
            else
            {
                m_board[topX + size][topY + size] = LIndex;
                ChessboardCover(topX + size, topY + size, topX + size, topY + size, size);
            }
        }
        private void DrawFrame()
        {
            m_graphics.FillRectangle(Brushes.LightGray, new RectangleF(10, 10, 512, 512));
            int unitWidth = 512 / m_size;
            Pen pen = new(Color.Black, 1);
            for (int i = 0; i <= m_size; i++)
            {
                m_graphics.DrawLine(pen, 10 + i * unitWidth, 10, 10 + i * unitWidth, 522);
                m_graphics.DrawLine(pen, 10, 10 + i * unitWidth, 522, 10 + i * unitWidth);
            }
        }
        private void DrawSpecialUnit(int x, int y)
        {
            int unitWidth = 512 / m_size;
            m_graphics.FillRectangle(Brushes.LightGray, new RectangleF(11 + (m_specialX - 1) * unitWidth, 11 + (m_specialY - 1) * unitWidth, unitWidth - 1, unitWidth - 1));
            m_graphics.FillRectangle(Brushes.LightSeaGreen, new RectangleF(11 + (x - 1) * unitWidth, 11 + (y - 1) * unitWidth, unitWidth - 1, unitWidth - 1));
        }
        private void DrawThreeUnit(bool next)
        {
            if (!next)
            {
                m_drawIndex--;
            }
            int firstYIndex = 0;
            bool tag = false;
            for (int i = 0; i < m_board.Count; i++)
            {
                if (m_board[i].Contains(m_drawIndex))
                {
                    firstYIndex = i;
                    tag = true;
                    break;
                }
            }
            if (!tag)
            {
                startButton.Text = "开始";
                drawTImer.Enabled = false;
                sizeCombo.Enabled = true;
                positionXText.Enabled = true;
                positionYText.Enabled = true;
                previousButton.Enabled = false;
                nextButton.Enabled = false;
                return;
            }
            Random randomGetter = new();
            List<int> color = new();
            do
            {
                color.Clear();
                for (int i = 0; i < 3; i++)
                {
                    color.Add(randomGetter.Next(0, 256));

                }
            } while (m_colors.Contains(color));
            for (int i = firstYIndex; i < firstYIndex + 2; i++)
            {
                for (int j = 0; j < m_board[i].Count; j++)
                {
                    if (m_board[i][j] == m_drawIndex)
                    {
                        int unitWidth = 512 / m_size;
                        m_graphics.FillRectangle(next ? new SolidBrush(Color.FromArgb(color[0], color[1], color[2])) : Brushes.LightGray,
                            new RectangleF(11 + j * unitWidth, 11 + i * unitWidth, unitWidth - 1, unitWidth - 1));
                    }
                }
            }
            if (next)
            {
                m_drawIndex++;
            }
        }
        private void BeginCover(object sender, EventArgs e)
        {
            if (startButton.Text == "开始" && sizeCombo.Enabled)
            {
                if (positionXText.Text == "" || positionYText.Text == "" || frequencyText.Text == "")
                {
                    MessageBox.Show("输入错误", "错误", MessageBoxButtons.OK);
                    return;
                }
                DrawFrame();
                DrawSpecialUnit(m_specialX, m_specialY);
                m_LIndex = 1;
                m_drawIndex = 1;
                m_board = new();
                startButton.Text = "暂停";
                sizeCombo.Enabled = false;
                positionXText.Enabled = false;
                positionYText.Enabled = false;
                previousButton.Enabled = true;
                nextButton.Enabled = true;
                for (int i = 0; i < m_size; i++)
                {
                    List<int> temp = new();
                    temp.AddRange(new int[m_size]);
                    m_board.Add(temp);
                }
                ChessboardCover(0, 0, m_specialY - 1, m_specialX - 1, m_size);
                drawTImer.Enabled = true;
            }
            else if (startButton.Text == "开始" && !sizeCombo.Enabled)
            {
                startButton.Text = "暂停";
                drawTImer.Enabled = true;
            }
            else
            {
                startButton.Text = "开始";
                drawTImer.Enabled = false;
            }
        }
        private void ChessboardSizeChanged(object sender, EventArgs e)
        {
            m_size = int.Parse(sizeCombo.Text);
            if (m_specialX > m_size)
            {
                m_specialX = m_size;
                positionXText.Text = m_size.ToString();
            }
            if (m_specialY > m_size)
            {
                m_specialY = m_size;
                positionYText.Text = m_size.ToString();
            }
            DrawFrame();
            DrawSpecialUnit(m_specialX, m_specialY);
        }
        private void SpecialXChanged(object sender, EventArgs e)
        {
            if (int.TryParse(positionXText.Text, out int specialX) && specialX > 0 && specialX <= m_size)
            {
                DrawFrame();
                DrawSpecialUnit(specialX, m_specialY);
                m_specialX = specialX;
            }
            else
            {
                if (positionXText.Text == "")
                {
                    return;
                }
                MessageBox.Show("输入错误", "错误", MessageBoxButtons.OK);
                positionXText.Text = "1";
            }
        }
        private void SpecialYChanged(object sender, EventArgs e)
        {
            if (int.TryParse(positionYText.Text, out int specialY) && specialY > 0 && specialY <= m_size)
            {
                DrawFrame();
                DrawSpecialUnit(m_specialX, specialY);
                m_specialY = specialY;
            }
            else
            {
                if (positionYText.Text == "")
                {
                    return;
                }
                MessageBox.Show("输入错误", "错误", MessageBoxButtons.OK);
                positionYText.Text = "1";
            }
        }
        private void DrawUnitThreeByThree(object sender, EventArgs e)
        {
            DrawThreeUnit(true);
        }
        private void FrequencyChanged(object sender, EventArgs e)
        {
            try
            {
                drawTImer.Interval = int.Parse(frequencyText.Text);
            }
            catch
            {
                if (frequencyText.Text == "")
                {
                    return;
                }
                MessageBox.Show("输入错误", "错误", MessageBoxButtons.OK);
                positionYText.Text = "1000";
            }
        }
        private void ResetChessboard(object sender, EventArgs e)
        {
            startButton.Text = "开始";
            drawTImer.Enabled = false;
            sizeCombo.Enabled = true;
            positionXText.Enabled = true;
            positionYText.Enabled = true;
            previousButton.Enabled = false;
            nextButton.Enabled = false;
            DrawFrame();
            DrawSpecialUnit(m_specialX, m_specialY);
        }
        private void GoPrevious(object sender, EventArgs e)
        {
            if (m_drawIndex < 2 || sizeCombo.Enabled)
            {
                return;
            }
            startButton.Text = "开始";
            drawTImer.Enabled = false;
            DrawThreeUnit(false);
        }
        private void GoNext(object sender, EventArgs e)
        {
            startButton.Text = "开始";
            drawTImer.Enabled = false;
            DrawThreeUnit(true);
        }

        private void InitialPaint(object sender, PaintEventArgs e)
        {
            if (!m_isInitialize)
            {
                DrawFrame();
                DrawSpecialUnit(m_specialX, m_specialY);
                m_isInitialize = true;
            }
        }
    }
}