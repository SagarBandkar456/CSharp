using System;

public class Asteroid735
{
    public int[] AsteroidCollision(int[] asteroids)
    {
        Stack<int> st = new();


        for (int i = 0; i < asteroids.Length; i++)
        {
            if (asteroids[i] > 0) st.Push(asteroids[i]);
            else
            {
                while (st.Count > 0 && st.Peek() > 0 && st.Peek() < Math.Abs(asteroids[i])) st.Pop();

                if (st.Count > 0 && st.Peek() == Math.Abs(asteroids[i])) st.Pop();

                if (st.Count == 0 || st.Peek() < 0)
                    st.Push(asteroids[i]);
            }
        }

        return st.Reverse().ToArray();
    }
}