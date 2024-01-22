using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CalculatorScript : MonoBehaviour
{
    public float SGDAmount;
    public float value;
    public Toggle USD;
    public Toggle JPY;
    public InputField txtAmount;
    public InputField Convertedvalue;
    public Text debugText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void conversion()
    {
        Convertedvalue.textComponent.color = Color.black;
        try
        {
            SGDAmount = float.Parse(txtAmount.text);
        }
        catch (Exception e)
        {
            debugText.text = "Key in a valid amount value";
        }

        if (USD.GetComponent<Toggle>().isOn == true)
        {
            value = SGDAmount * 0.74f;
            Convertedvalue.text = value.ToString() + " USD";
        }

        if (JPY.GetComponent<Toggle>().isOn == true)
        {
            value = SGDAmount * 110.38f;
            Convertedvalue.text = value.ToString() + " JPY";
        }

        if ((USD.GetComponent<Toggle>().isOn == true) && (JPY.GetComponent<Toggle>().isOn == true))
        {
            Convertedvalue.text = "Choose only one option";
            Convertedvalue.textComponent.color = Color.red;
        }

        /*if (txtAmount.text == "")
        {
            Convertedvalue.text = "Key in a valid amount value";
        }*/
    }
    public void Clear()
    {
        Convertedvalue.text = "";
        txtAmount.text = "";
        debugText.text = "";
        JPY.GetComponent<Toggle>().isOn = false;
        USD.GetComponent<Toggle>().isOn = false;
    }
}
