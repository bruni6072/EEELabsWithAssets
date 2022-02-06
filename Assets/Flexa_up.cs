using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flexa_up : MonoBehaviour
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
            DisplayScript_f.voltage += 1;
            GameplayManagerVout.voltage += 1;
            GameplayManagerVx.voltage += 1;
        }


    }
}
