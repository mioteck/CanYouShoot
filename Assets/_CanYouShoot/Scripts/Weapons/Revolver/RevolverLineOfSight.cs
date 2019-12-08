using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RevolverLineOfSight : MonoBehaviour
{
    public LineRenderer LineRenderer;

    public SpriteRenderer Circle;

    private void Start()
    {
        LineRenderer.positionCount = 2;
    }

    void Update()
    {
        RaycastHit hit;

        Vector3 direction = transform.TransformDirection(Vector3.forward);
        
        if (Physics.Raycast(transform.position, direction, out hit, 1000, 7))
        {
            LineRenderer.SetPosition(0, Vector3.zero);

            Vector3 hitPoint = transform.InverseTransformPoint(hit.point);
            
            LineRenderer.SetPosition(1, hitPoint);

            Circle.transform.position = hit.point;
            Circle.transform.LookAt(Player.Instance.transform);
        }

        Vector3 randomPoint = Random.insideUnitCircle;
        
        Vector3 pointInsideCircle = randomPoint * Circle.transform.localScale.x + Circle.transform.position;

        
        Debug.DrawLine(transform.position, pointInsideCircle, new Color(0.8f, 0.2f, 0.8f, 0.2f), 300);
    }
}
