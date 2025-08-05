using System;

public class CombSum39
{
    public IList<IList<int>> res = new List<IList<int>>();
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        IList<int> lst = new List<int>();
        Solve(candidates, target, 0, lst);
        return res;
    }

    public void Solve(int[] candidates, int target, int index, IList<int> lst)
    {
        if (index == candidates.Length)
        {
            if (target == 0)
                res.Add(new List<int>(lst));

            return;
        }

        if (candidates[index] <= target)
        {
            lst.Add(candidates[index]);
            Solve(candidates, target - candidates[index], index, lst);
            lst.RemoveAt(lst.Count - 1);
        }

        Solve(candidates, target, index + 1, lst);

    }

    //////////////////////////////////////////////////////////
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        IList<int> lst = new List<int>();
        Array.Sort(candidates);
        Solve2(candidates, target, 0, lst);
        return res;
    }

    public void Solve2(int[] candidates, int target, int index, IList<int> lst)
    {

        if (target == 0)
        {
            res.Add(new List<int>(lst));
            return;
        }


        for (int i = index; i < candidates.Length; i++)
        {
            if (i > index && candidates[i] == candidates[i - 1]) continue;
            if (candidates[i] > target) break;

            lst.Add(candidates[i]);
            Solve2(candidates, target - candidates[i], i + 1, lst);
            lst.RemoveAt(lst.Count - 1);
        }
    }
}
