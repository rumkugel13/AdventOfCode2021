
namespace AdventOfCode2021
{
    public class Day04
    {
        List<int> sequence;
        List<Board> boards;

        public Day04(string[] data)
        {
            var seq = data[0].Split(',');
            sequence = new List<int>();

            for (int i = 0; i < seq.Length; i++)
            {
                sequence.Add(Convert.ToInt32(seq[i]));
            }

            boards = new List<Board>();
            Board current = new Board();
            current.board = new List<int>(25);
            current.marked = new HashSet<int>();
            int row = 0;

            for (int i = 1; i < data.Length; i++)
            {
                if (string.IsNullOrEmpty(data[i]))
                {
                    // next board
                    current = new Board();
                    current.board = new List<int>(25);
                    current.marked = new HashSet<int>();
                    row = 0;
                }
                else
                {
                    var nums = data[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    for (int j = 0; j < nums.Length; j++)
                    {
                        current.board.Add(Convert.ToInt32(nums[j]));
                    }
                    row++;
                }

                if (row == 4)
                {
                    boards.Add(current);
                }
            }
        }

        public struct Board
        {
            public List<int> board;
            public HashSet<int> marked;
        }

        public int SolvePart1()
        {
            for (int seq = 0; seq < sequence.Count; seq++)
            {
                for (int b = 0; b < boards.Count; b++)
                {
                    // mark found indexes
                    Board board = boards[b];
                    MarkIfFound(board, sequence[seq]);

                    if (IsBingo(board))
                    {
                        return SumUnmarked(board) * sequence[seq];
                    }
                }
            }

            return 0;
        }

        public int SolvePart2()
        {
            HashSet<int> completed = new HashSet<int>();
            for (int seq = 0; seq < sequence.Count; seq++)
            {
                for (int b = 0; b < boards.Count; b++)
                {
                    if (completed.Contains(b))
                    {
                        continue;
                    }

                    // mark found indexes
                    Board board = boards[b];
                    MarkIfFound(board, sequence[seq]);

                    if (IsBingo(board))
                    {
                        // remove board
                        completed.Add(b);

                        if (completed.Count == boards.Count)
                        {
                            return SumUnmarked(board) * sequence[seq];
                        }
                    }
                }
            }

            return 0;
        }

        public int SumUnmarked(Board board)
        {
            int sum = 0;
            for (int k = 0; k < board.board.Count; k++)
            {
                if (!board.marked.Contains(k))
                {
                    sum += board.board[k];
                }
            }
            return sum;
        }

        public void MarkIfFound(Board board, int value)
        {
            int index = board.board.IndexOf(value);
            if (index != -1)
            {
                board.marked.Add(index);
            }
        }

        public static bool IsBingo(Board board)
        {
            bool row = true;
            bool col = true;
            for (int i = 0; i < 5; i++)
            {
                row = true;
                col = true;
                for (int j = 0; j < 5; j++)
                {
                    // row
                    if (!board.marked.Contains(5 * i + j))
                    {
                        row = false;
                    }

                    // col
                    if (!board.marked.Contains(5 * j + i))
                    {
                        col = false;
                    }
                }

                if (row || col)
                {
                    // early out
                    return true;
                }
            }

            return row || col;
        }
    }
}
