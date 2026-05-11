namespace LeetCodeCSharp.BinarySearch;

public class TimeBasedKeyValueStore
{
    private Dictionary<string, List<(int timestamp, string value)>> store;

    public TimeBasedKeyValueStore()
    {
        store = new Dictionary<string, List<(int, string)>>();
    }

    // O(1) — timestamps for the same key are strictly increasing, so append keeps the list sorted.
    public void Set(string key, string value, int timestamp)
    {
        if (!store.ContainsKey(key))
        {
            store[key] = new List<(int, string)>();
        }
        store[key].Add((timestamp, value));
    }

    // O(log n) — binary search for the largest timestamp <= target.
    public string Get(string key, int timestamp)
    {
        if (!store.TryGetValue(key, out var list) || list.Count == 0)
        {
            return "";
        }

        int left = 0, right = list.Count - 1;
        string result = "";

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (list[mid].timestamp <= timestamp)
            {
                result = list[mid].value;
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return result;
    }
}
