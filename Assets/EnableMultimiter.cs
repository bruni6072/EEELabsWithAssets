using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnableMultimiter : MonoBehaviour
{
    public GameObject multimiter;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Vout")
        {
            multimiter.GetComponent<GameplayManagerVx>().enabled = false;
            multimiter.GetComponent<GameplayManagerVout>().enabled = true;
        }
        else
        {
            if (collision.gameObject.tag == "Vx")
            {
                multimiter.GetComponent<GameplayManagerVout>().enabled = false;
                multimiter.GetComponent<GameplayManagerVx>().enabled = true;
            }

        }
    }
    
}
