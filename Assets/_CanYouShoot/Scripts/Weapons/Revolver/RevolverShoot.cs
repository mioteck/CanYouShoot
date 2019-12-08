using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolverShoot : MonoBehaviour
{
    
    public GameObject ProjectilePrefab;

    public float Force;

    public RevolverBall ball;
    
    void Update()
    {
        if (OVRInput.GetDown(OVRMapping.IndexRight) || Input.GetKeyDown(KeyCode.Space))
        {
            GameObject projectile = Instantiate(ProjectilePrefab, transform.position, transform.rotation);
            ball = projectile.GetComponent<RevolverBall>();
            ball.reference = transform;
        }
        if (OVRInput.GetUp(OVRMapping.IndexRight) || Input.GetKeyUp(KeyCode.Space))
        {
            ball.IsLaunch = true;
            ball.GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * Force, ForceMode.VelocityChange);
        }
    }
}
