using System;
using UnityEngine;

public class RegionOrder : MonoBehaviour
{
    #region Events

    public Action EventSample;

    #endregion

    #region Public Variables

    public string publicVariableSample;

    #endregion

    #region Private Variables Properties

    public int PublicPropertySample { get; set; }

    #endregion

    #region Private Variables

    private string _privateVariableSample;

    #endregion

    #region Unity Methods: 1 Awake 2 OnEnable 3 Start 4 Update ...

    private void Awake()
    {

    }

    public void Start()
    {

    }

    #endregion

    #region Own Methods: 1 Public ones (interface) 2 Private ones (class methods)

    public void PublicSampleMethod()
    {

    }

    private void PrivateSampleMethod()
    {

    }

    #endregion

    #region Event Delegates

    private void OnEventSample()
    {
        if (EventSample != null)
        {
            EventSample.Invoke();
        }
    }

    #endregion
}