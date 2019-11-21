using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OVRMapping
{
    public static OVRInput.Button IndexRight = OVRInput.Button.SecondaryIndexTrigger;
    public static OVRInput.Button IndexLeft = OVRInput.Button.PrimaryIndexTrigger;

    public static OVRInput.Button ThumbRight = OVRInput.Button.SecondaryHandTrigger;
    public static OVRInput.Button ThumbLeft = OVRInput.Button.PrimaryHandTrigger;

    public static OVRInput.Button A = OVRInput.Button.One;
    public static OVRInput.Button B = OVRInput.Button.Two;
    public static OVRInput.Button X = OVRInput.Button.Three;
    public static OVRInput.Button Y = OVRInput.Button.Four;

    public static OVRInput.Button Start = OVRInput.Button.Start;

    public static OVRInput.Button RightButtonStick = OVRInput.Button.SecondaryThumbstick;
    public static OVRInput.Button LeftButtonStick = OVRInput.Button.PrimaryThumbstick;

    public static OVRInput.Axis2D RightStick = OVRInput.Axis2D.SecondaryThumbstick;
    public static OVRInput.Axis2D LeftStick = OVRInput.Axis2D.PrimaryThumbstick;
}
