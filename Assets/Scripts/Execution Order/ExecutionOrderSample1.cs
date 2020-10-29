using UnityEngine;

public class ExecutionOrderSample1 : MonoBehaviour
{
    private ExecutionOrderSample2 _sample2;

    private int _randomValue;

    private void Awake()
    {
        _sample2 = FindObjectOfType<ExecutionOrderSample2>();

        /* If Sample1 Awake method is called before Sample2 Awake method, this line:
         *
        _randomValue = _sample2.GetRandomValue();
         *
         * which is trying to access a method from Sample2, will throw an error
         * because Sample2 random values array hasn't been initialized. */
    }

    // Solution, make sure Sample2 is initialized before trying to acces one of his methods
    private void Start()
    {
        _randomValue = _sample2.GetRandomValue();
    }
}