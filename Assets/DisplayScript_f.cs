using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScript_f : MonoBehaviour
{
    Text text;
    public static int voltage=0;
    /*private GameplayManager gameplayManager;
    void awake()
    {
        gameplayManager = GameObject.FindObjectOfType<GameplayManager>();
    }*/

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {

        text.text = voltage.ToString() + 'V';
        
        //gameplayManager.UpdateScore(voltage);
    }
}
