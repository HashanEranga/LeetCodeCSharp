namespace LeetCodeCSharp.Arrays;

public class TopKFrequentElements
{
    public int[] TopKFrequent(int[] nums, int k) {
        
        var uniqueItems = new HashSet<int>(nums).ToList();
        if(uniqueItems.Count == k) return uniqueItems.ToArray();

        var frequencyMap = new Dictionary<int, int>();
        foreach(var num in nums)
            frequencyMap[num] = frequencyMap.GetValueOrDefault(num, 0) + 1;
        
        int maxFreq = frequencyMap.Values.Max();
        var buckets = new List<int>[maxFreq + 1];
        for(int i = 0; i <= maxFreq; i++){
            buckets[i] = new List<int>();
        }

        foreach(var kvp in frequencyMap)
            buckets[kvp.Value].Add(kvp.Key);
        
        var results = new List<int>();
        for(int freq = maxFreq; freq >= 1 && results.Count < k; freq--){
           foreach(var num in buckets[freq]){
                if(results.Count < k)
                    results.Add(num);
           } 
        }

        return results.ToArray();
    }
}