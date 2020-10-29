using System.Linq;
using UnityEngine;

public class ExecutionOrderSample2 : MonoBehaviour
{
    private int[] _randomValues;

    private readonly System.Random _random = new System.Random();

    private void Awake()
    {
        // Initialize random values array
        GenerateRandomValues();
    }

    public int GetRandomValue()
    {
        var index = _random.Next(0, 19);
        return _randomValues[index];
    }

    private void GenerateRandomValues()
    {
        _randomValues = Enumerable.Range(0, 20).Select(x => _random.Next(0, 300)).ToArray();
    }
}