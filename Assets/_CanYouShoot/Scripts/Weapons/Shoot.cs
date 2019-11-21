using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.XR.WSA;

public class Shoot : MonoBehaviour
{

    public GameObject ProjectilePrefab;

    public float Force;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.DOScale(new Vector3(0.1f, 0.1f, 0.1f), 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRMapping.IndexRight) || Input.GetKeyUp(KeyCode.Space))
        {
            GameObject projectile = Instantiate(ProjectilePrefab, transform.position, transform.rotation);
            projectile.GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * Force, ForceMode.VelocityChange);
        }

    }
}
