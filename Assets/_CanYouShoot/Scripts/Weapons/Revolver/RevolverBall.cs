using System;
using UnityEngine;

public class RevolverBall : MonoBehaviour
{

    public Vector3 MinSize;
    public Vector3 MaxSize;
    public float SizeSpeed;

    public Transform reference;

    public bool IsLaunch;
    
    // Start is called before the first frame update
    void Start()
    {
        
        transform.localScale = MinSize;
    }

    // Update is called once per frame
    void Update()
    {
        if (!IsLaunch && transform.localScale.InferiorOf(MaxSize))
        {
            transform.localScale += Vector3.one * SizeSpeed * Time.deltaTime;
        }
        if(!IsLaunch)
        {
            transform.position = reference.transform.position;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }
}
