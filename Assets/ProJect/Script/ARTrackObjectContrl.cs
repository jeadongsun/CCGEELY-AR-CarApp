using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(ARTrackedObjectManager))]
public class ARTrackObjectContrl : MonoBehaviour
{
    ARTrackedObjectManager aRTrackedObjectManager;

    public GameObject currentObj;

    void Awake()
    {
        aRTrackedObjectManager = GetComponent<ARTrackedObjectManager>();
    }

    private void OnEnable()
    // Update is called once per frame
    void Update()
    {

    }


    void OnTrackedObjectsChanged(ARTrackedObjectsChangedEventArgs eventArgs)
    {
        foreach (var trackedObject in eventArgs.added)
    }
}