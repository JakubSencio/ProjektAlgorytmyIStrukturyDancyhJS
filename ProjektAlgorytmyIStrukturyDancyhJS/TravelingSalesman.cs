using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektAlgorytmyIStrukturyDancyhJS
{
    class TravelingSalesman
    {
        public int SolveTSP(int[,] graph, bool[] visited, int currentPos, int n, int count, int cost, int answer)
        {
            if (count == n && graph[currentPos, 0] > 0)
            {
                answer = Math.Min(answer, cost + graph[currentPos, 0]);
                return answer;
            }

            for (int i = 0; i < n; i++)
            {
                if (!visited[i] && graph[currentPos, i] > 0)
                {
                    visited[i] = true;
                    answer = SolveTSP(graph, visited, i, n, count + 1, cost + graph[currentPos, i], answer);
                    visited[i] = false;
                }
            }
            return answer;
        }
    }

}
