using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Vector3Extend
{
    public static bool InferiorOf(this Vector3 a, Vector3 b)
    {
        return !(a.x > b.x) && !(a.y > b.y) && !(a.z > b.z);
    } 
}
