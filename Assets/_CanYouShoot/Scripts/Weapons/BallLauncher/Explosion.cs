using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float ExplosionSize;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.DOScale(Vector3.one * ExplosionSize, 10f).onComplete += () => Destroy(transform.parent.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
