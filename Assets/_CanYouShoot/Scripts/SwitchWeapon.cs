using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWeapon : MonoBehaviour
{
    public List<GameObject> weapons;

    private int current = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        ActivateWeapon(current);
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.A))
        {
            current++;
            if (current == weapons.Count)
            {
                current = 0;
                current = 0;
            }
            ActivateWeapon(current);
        }
    }

    public void ActivateWeapon(int index)
    {
        for (int i = 0; i < weapons.Count; i++)
        {
            weapons[i].SetActive(i == index);
        }
    }
}
