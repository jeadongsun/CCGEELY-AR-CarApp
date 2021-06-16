using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollowRotation : MonoBehaviour
{
    public float xSpeed = 100;//旋转速度
    public float ySpeed = 100;
    public float yMinLimit = -20;//旋转限制
    public float yMaxLimit = 80;
    public float x = 0.0f;
    public float y = 0.0f;
    void Start()
    {
        Vector2 angles = transform.eulerAngles;
        x = angles.y;
        y = angles.x;
    }

    void Update()
    {
        if (Input.touchCount == 1)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                x += Input.GetAxis("Mouse X") * xSpeed * 0.02f;
                y -= Input.GetAxis("Mouse Y") * ySpeed * 0.02f;
            }
        }
    }

    public void LateUpdate()
    {
        y = ClampAngle(y, yMinLimit, yMaxLimit);
        Quaternion rotation = Quaternion.Euler(y, x, 0);
        transform.rotation = rotation;

    }

    /// <summary>
    /// Y值的限制
    /// </summary>
    float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360)
            angle += 360;

        if (angle > 360)
            angle -= 360;

        return Mathf.Clamp(angle, min, max);
    }
}
