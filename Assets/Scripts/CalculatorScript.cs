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
    public Toggle RM;
    public Toggle EUR;
    public Toggle KRW;
    public Toggle TWD;
    public InputField txtAmount;
    public InputField Convertedvalue;
    public Text debugText;
    public int toggleCount;

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
        toggleCount = 0;
        try
        {
            SGDAmount = float.Parse(txtAmount.text);
        }
        catch (Exception e)
        {
            debugText.text = "Key in a valid amount value";
        }

        checkToggleOn();

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

        if (RM.GetComponent<Toggle>().isOn == true)
        {
            value = SGDAmount * 3.08f;
            Convertedvalue.text = value.ToString() + " RM";
        }

        if (EUR.GetComponent<Toggle>().isOn == true)
        {
            value = SGDAmount * 0.63f;
            Convertedvalue.text = value.ToString() + " EUR";
        }

        if (KRW.GetComponent<Toggle>().isOn == true)
        {
            value = SGDAmount * 881.54f;
            Convertedvalue.text = value.ToString() + " KRW";
        }

        if (TWD.GetComponent<Toggle>().isOn == true)
        {
            value = SGDAmount * 20.73f;
            Convertedvalue.text = value.ToString() + " TWD";
        }

        if(toggleCount > 1)
        {
            Convertedvalue.text = "Choose only one option";
            Convertedvalue.textComponent.color = Color.red;
        }

        /* if ((USD.GetComponent<Toggle>().isOn == true) && (JPY.GetComponent<Toggle>().isOn == true))
         {
             Convertedvalue.text = "Choose only one option";
             Convertedvalue.textComponent.color = Color.red;
         }

         /*if (txtAmount.text == "")
         {
             Convertedvalue.text = "Key in a valid amount value";
         }*/

    }

    private void checkToggleOn()
    {
        if (USD.isOn)
            toggleCount++;
        if (JPY.isOn)
            toggleCount++;
        if (RM.isOn)
            toggleCount++;
        if (EUR.isOn)
            toggleCount++;
        if (KRW.isOn)
            toggleCount++;
        if (TWD.isOn)
            toggleCount++;
    }

    public void Clear()
    {
        Convertedvalue.text = "";
        txtAmount.text = "";
        debugText.text = "";
        
        JPY.GetComponent<Toggle>().isOn = false;
        USD.GetComponent<Toggle>().isOn = false;
        RM.GetComponent<Toggle>().isOn = false;
        KRW.GetComponent<Toggle>().isOn = false;
        EUR.GetComponent<Toggle>().isOn = false;
        TWD.GetComponent<Toggle>().isOn = false;
    }
}
