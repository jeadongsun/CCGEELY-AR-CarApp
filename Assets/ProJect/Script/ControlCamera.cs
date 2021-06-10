﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ControlCamera : MonoBehaviour
{


#if UNITY_IOS || UNITY_ANDROID
    public float CameraUpperHeightBound; //Zoom out
    public float CameraLowerHeightBound; //Zoom in

    private Vector3 cameraStartPosition;

        //Update Plane
        if (Input.touchCount >= 1)

        //Scroll (Pan function)
        if (Input.touchCount >= 1)
            //Get distance camera should travel
            Delta1 = PlanePositionDelta(Input.GetTouch(0)) / DecreaseCameraPanSpeed;

        //Pinch (Zoom Function)
        if (Input.touchCount >= 2)

            //calc zoom
            var zoom = Vector3.Distance(pos1, pos2) /
Vector3.Distance(pos1b, pos2b);

            //edge case
            if (zoom == 0 || zoom > 10)

            //Move cam amount the mid ray
            Vector3 camPositionBeforeAdjustment = Camera.transform.position;

            //Restricts zoom height 

            //Upper (ZoomOut)
            if (Camera.transform.position.y > (cameraStartPosition.y + CameraUpperHeightBound))
            //Lower (Zoom in)
            if (Camera.transform.position.y < (cameraStartPosition.y - CameraLowerHeightBound) || Camera.transform.position.y <= 1)


            //Rotation Function
            if (Rotate && pos2b != pos2)

    //Returns the point between first and final finger position
    protected Vector3 PlanePositionDelta(Touch touch)
        //not moved
        if (touch.phase != TouchPhase.Moved)


        //delta
        var rayBefore = Camera.ScreenPointToRay(touch.position - touch.deltaPosition);

        //not on plane
        return Vector3.zero;
        //position
        var rayNow = Camera.ScreenPointToRay(screenPos);
}