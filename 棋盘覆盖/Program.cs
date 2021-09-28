using System;
using System.Collections.Generic;
namespace Chessboard_Cover
{
    class Program
    {
        private static List<List<int>> m_board;
        private static int m_LIndex;
        private static void ChessboardCover(int topX, int topY, int specialX, int specialY, int size)
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
        private static void Main()
        {
            int count = 0;
            string input;
            while ((input = Console.ReadLine()) != "")
            {
                int size;
                if (!int.TryParse(input.Split(" ")[0], out int k) || k < 1
                    || !int.TryParse(input.Split(" ")[1], out int specialX) || specialX < 1 || specialX > (size = (int)Math.Pow(2, k))
                    || !int.TryParse(input.Split(" ")[2], out int specialY) || specialY < 1 || specialY > size)
                {
                    Console.WriteLine("输入错误。");
                    continue;
                }
                m_LIndex = 1;
                m_board = new();
                for (int i = 0; i < size; i++)
                {
                    List<int> temp = new();
                    temp.AddRange(new int[size]);
                    m_board.Add(temp);
                }
                ChessboardCover(0, 0, specialX - 1, specialY - 1, size);
                count++;
                Console.WriteLine($"Case {count}: n = {size}");
                for (int i = 0; i < m_board.Count; i++)
                {
                    for (int j = 0; j < m_board[i].Count; j++)
                    {
                        Console.Write(m_board[i][j] == 0 ? "# " : m_board[i][j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}