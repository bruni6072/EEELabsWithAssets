using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScript_f_D2 : MonoBehaviour
{
    Text text;
    public static int voltage_D2;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        text.text = voltage_D2.ToString() +'V';
    }
}
