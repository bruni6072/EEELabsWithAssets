using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flexa_up_D2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "hand")
        {
            DisplayScript_f_D2.voltage_D2 += 1;
            GameplayManagerVout.voltage_D2 += 1;
            GameplayManagerVx.voltage_D2 += 1;
        }
    }
}
