using System;
using UnityEngine;

public class RegionOrder : MonoBehaviour
{

    public Action EventSample;

    public int PublicPropertySample { get; set; }

    public string publicVariableSample;

    private string _privateVariableSample;

    private void Awake()
    {

    }

    public void Start()
    {

    }


    private void PrivateSampleMethod()
    {

    }


    public void PublicSampleMethod()
    {

    }


    private void OnEventSample()
    {
        if (EventSample != null)
        {
            EventSample.Invoke();
        }
    }
}
