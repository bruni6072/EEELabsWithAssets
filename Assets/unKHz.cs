using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unKHz : MonoBehaviour
{
    public GameObject ObjectEnabled;
    public GameObject ObjectDisabled1;
    public GameObject ObjectDisabled2;

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
        {/*
            ObjectEnabled.enabled = true;
            ObjectDisabled1.enabled = false;
            ObjectDisabled2.enabled = false;
            */
            ObjectEnabled.active = true;
            ObjectDisabled1.active = false;
            ObjectDisabled2.active = false;

        }


    }
}
