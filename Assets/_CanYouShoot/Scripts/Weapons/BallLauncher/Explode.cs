using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Explode : MonoBehaviour
{
    public GameObject Explosion;

    public void Start()
    {
        transform.DOScale(Vector3.one, 1);
    }

    private void OnCollisionEnter(Collision other)
    {
        Destroy(GetComponent<Rigidbody>());
        GetComponent<Renderer>().enabled = false;
        Explosion.SetActive(true);
        
    } 
}
