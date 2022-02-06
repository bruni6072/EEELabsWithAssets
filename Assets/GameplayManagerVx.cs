using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class GameplayManagerVx : MonoBehaviour
{
    Text text;
    public static int voltage;
    public static int voltage_D2;
    public static int FinalVoltage = 0;


    void Start()
    {
        text = GetComponent<Text>();

    }
    void Update()
    {
        
         double FinalVoltage = (double)(voltage + voltage_D2)/3; //double= decimals in output
         //double FinalVoltage = (double)(2+2)/3;
        FinalVoltage = (double)System.Math.Round(FinalVoltage, 2);//Only a two decimal place voltage output
        
        text.text = FinalVoltage.ToString() + 'V'; // numbers to scrtipt & output 
       


    }
}

