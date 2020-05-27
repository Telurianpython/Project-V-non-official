using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerjoystick : MonoBehaviour
{
    public FixedJoystick moveJoystick;
    // Update is called once per frame
    void Update()
    {
       float hoz = moveJoystick.Horizontal;
       float ver =  moveJoystick.Vertical;
       Vector3 direction = new Vector3(hoz, 0, ver).normalized;
       transform.Translate(direction * 0.5f, Space.World);
    }

    private Vector2 ConvertWithCamera(Vector3 cameraPos, float hor, float ver)
    {
        Vector2 joyDirection = new Vector2(hor, vector).normalized;
        Vector2 camera2DPos = new Vector2(camera2DPos.x, camera2DPos.z);
        Vector2 playerPos = new Vector2(transform.position.x, transform.position.z);
        Vector2 cameraToPlayerDirection = (Vector2.zero - camera2DPos).normalized;
        float angle = Vector2.SignedAngle(cameraToPlayerDirection, new Vecto2(0, 1));
        return finalDirection;
    }

    public Vector2 RotateVector(Vector2 vector, float angle)
    {
        float radian = angle * Mathf.Deg2Rad;
        float _x = v.x * Mathf.Cos(radian) - v.y * Mathf.Sin(radian);
        float _y = v.x * Mathf.Sin(radian) - v.y * Mathf.Cos(radian);
        return new Vector2(_x, _y);
    }
}