namespace LessonsAlgorithms.Lessons
{
    public class Lesson7StacksAndQueues
    {
        #region FishCount
        public int FishCount(int[] A, int[] B)
        {
            var downstream = new Stack<int>();
            var upstream = new Stack<int>();

            for (var i = 0; i < A.Length; i++)
            {
                if (B[i] == 0 && downstream.Count == 0)
                {
                    upstream.Push(A[i]);
                    continue;
                }
                if (B[i] == 1)
                {
                    downstream.Push(A[i]);
                    continue;
                }
                if (B[i] == 0)
                {
                    var notEaten = true;
                    while (downstream.Count > 0 && notEaten)
                    {
                        var downstreamFish = downstream.Peek();
                        notEaten = A[i] > downstreamFish;
                        if (notEaten)
                        {
                            downstream.Pop();
                        }
                    }
                    if (notEaten)
                    {
                        upstream.Push(A[i]);
                    }
                }
            }

            return downstream.Count + upstream.Count;
        }
        #region

        #region Nesting
        public int Nesting(string S)
        {
            if (S.Length == 0)
            {
                return 1;
            }

            if (S.Length == 1)
            {
                return 0;
            }

            if (S[0] == ')')
            {
                return 0;
            }

            int nestingCount = 0;

            for (var i = 0; i < S.Length; i++)
            {
                if (S[i] == '(')
                {
                    nestingCount++;
                }
                if (S[i] == ')')
                {
                    nestingCount--;
                }
                if (nestingCount < 0)
                {
                    return 0;
                }
            }

            return nestingCount == 0 ? 1 : 0;
        }
        #endregion

        #region StoneWall
        public int StoneWall(int[] H)
        {
            if (H.Length == 1)
            {
                return 1;
            }

            var blocks = 0;
            var blockStack = new Stack<int>();

            for (var i = 0; i < H.Length; i++)
            {
                var hI = H[i];
                if (blockStack.Count == 0)
                {
                    blocks++;
                    blockStack.Push(H[i]);
                    continue;
                }
                var lastBlock = blockStack.Pop();
                if (H[i] == lastBlock)
                {
                    blockStack.Push(lastBlock);
                    continue;
                }
                if (H[i] < lastBlock)
                {
                    if (blockStack.Count == 0)
                    {
                        blocks++;
                        blockStack.Push(H[i]);
                        continue;
                    }
                    else
                    {
                        while (blockStack.Count > 0 && H[i] < lastBlock)
                        {
                            lastBlock = blockStack.Pop();
                        }
                        if (H[i] == lastBlock)
                        {
                            blockStack.Push(lastBlock);
                            continue;
                        }
                        blocks++;
                        blockStack.Push(lastBlock);
                        blockStack.Push(H[i]);
                        continue;
                    }
                }
                if (H[i] > lastBlock)
                {
                    blocks++;
                    blockStack.Push(lastBlock);
                    blockStack.Push(H[i]);
                }
            }

            return blocks;
            #endregion
        }
    }
}
