using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerjoystick : MonoBehaviour
{
    public FixedJoyStick moveJoystick;
    
    // Update is called once per frame
    void Update()
    {
       float hoz = moveJoystick.Horizontal;
       float ver =  moveJoystick.Vertical;
       Vector3 direction = new Vector3(hoz, 0, ver).noralized;
       transform.Translate(direction * 0.02f, space.world);
    }
}
