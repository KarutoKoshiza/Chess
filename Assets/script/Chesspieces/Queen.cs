using System.Collections.Generic;
using UnityEngine;

public class Queen : Chesspiece
{
    public override List<Vector2Int> GetAvailableMoves(ref Chesspiece[,] board, int tileCountX, int tileCountY)
    {
        List<Vector2Int> r = new List<Vector2Int>();

        for (int i = currentY - 1; i >= 0; i--)
        {
            if (board[currentX, i] == null)
                r.Add(new Vector2Int(currentX, i));

            if (board[currentX, i] != null)
            {
                if (board[currentX, i].team != team)
                    r.Add(new Vector2Int(currentX, i));

                break;
            }
        }

        for (int i = currentY + 1; i < tileCountY; i++)
        {
            if (board[currentX, i] == null)
                r.Add(new Vector2Int(currentX, i));

            if (board[currentX, i] != null)
            {
                if (board[currentX, i].team != team)
                    r.Add(new Vector2Int(currentX, i));

                break;
            }
        }

        for (int i = currentX - 1; i >= 0; i--)
        {
            if (board[i, currentY] == null)
                r.Add(new Vector2Int(i, currentY));

            if (board[i, currentY] != null)
            {
                if (board[i, currentY].team != team)
                    r.Add(new Vector2Int(i, currentY));

                break;
            }
        }

        for (int i = currentX + 1; i < tileCountX; i++)
        {
            if (board[i, currentY] == null)
                r.Add(new Vector2Int(i, currentY));

            if (board[i, currentY] != null)
            {
                if (board[i, currentY].team != team)
                    r.Add(new Vector2Int(i, currentY));

                break;
            }
        }

        for (int x = currentX + 1, y = currentY + 1; x < tileCountX && y < tileCountY; x++, y++)
        {
            if (board[x, y] == null)
                r.Add(new Vector2Int(x, y));
            else
            {
                if (board[x, y].team != team)
                    r.Add(new Vector2Int(x, y));

                break;
            }
        }

        for (int x = currentX - 1, y = currentY + 1; x >= 0 && y < tileCountY; x--, y++)
        {
            if (board[x, y] == null)
                r.Add(new Vector2Int(x, y));
            else
            {
                if (board[x, y].team != team)
                    r.Add(new Vector2Int(x, y));

                break;
            }
        }

        for (int x = currentX + 1, y = currentY - 1; x < tileCountX && y >= 0; x++, y--)
        {
            if (board[x, y] == null)
                r.Add(new Vector2Int(x, y));
            else
            {
                if (board[x, y].team != team)
                    r.Add(new Vector2Int(x, y));

                break;
            }
        }

        for (int x = currentX - 1, y = currentY - 1; x >= 0 && y >= 0; x--, y--)
        {
            if (board[x, y] == null)
                r.Add(new Vector2Int(x, y));
            else
            {
                if (board[x, y].team != team)
                    r.Add(new Vector2Int(x, y));

                break;
            }
        }

        return r;
    }
}