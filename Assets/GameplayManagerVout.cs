using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class GameplayManagerVout : MonoBehaviour
{
    //public Text scoreText; //Asign screen(text)

    Text text;
    public static int voltage;
    public static int voltage_D2;
    public static int FinalVoltage =0;
    
   
    void Start()
    {
        text = GetComponent<Text>();

    }
    void Update()
    {
     
        FinalVoltage = voltage + voltage_D2;
        text.text = FinalVoltage.ToString() + 'V';

       
    }
    //Passing var of battery1/2
    /*public void UpdateScore(int voltage)
    {
        scoreText.text = voltage.ToString() +"V";
    }*/
    // Start is called before the first frame update

    /*void Start()
{

}

// Update is called once per frame
void Update()
{

}*/
}
