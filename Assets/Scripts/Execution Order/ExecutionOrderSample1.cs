using UnityEngine;

public class ExecutionOrderSample1 : MonoBehaviour
{

    private ExecutionOrderSample2 _sample2;

    private int _randomValue;

    private void Awake()
    {
        _sample2 = FindObjectOfType<ExecutionOrderSample2>();

        _randomValue = _sample2.GetRandomValue();
    }
}
