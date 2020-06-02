using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public static bool whichButton = false;
    public Text upper;
    public Text lower; 
    public Text resultText;


    public void upperBtnClick(){
        whichButton = false;
    }

    public void lowerBtnClick(){
        whichButton = true;
    }

    public void One(){
        if(whichButton == false){
            upper.text += "1";
        }
        if(whichButton == true){
            lower.text += "1";
        }
    }

    public void Two(){
        if(whichButton == false){
            upper.text += "2";
        }
        if(whichButton == true){
            lower.text += "2";
        }
    }

    public void Three(){
        if(whichButton == false){
            upper.text += "3";
        }
        if(whichButton == true){
            lower.text += "3";
        }
    }

    public void Four(){
        if(whichButton == false){
            upper.text += "4";
        }
        if(whichButton == true){
            lower.text += "4";
        }
    }

    public void Five(){
        if(whichButton == false){
            upper.text += "5";
        }
        if(whichButton == true){
            lower.text += "5";
        }
    }

    public void Six(){
        if(whichButton == false){
            upper.text += "6";
        }
        if(whichButton == true){
            lower.text += "6";
        }
    }

    public void Seven(){
        if(whichButton == false){
            upper.text += "7";
        }
        if(whichButton == true){
            lower.text += "7";
        }
    }

    public void Eight(){
        if(whichButton == false){
            upper.text += "8";
        }
        if(whichButton == true){
            lower.text += "8";
        }
    }

    public void Nine(){
        if(whichButton == false){
            upper.text += "9";
        }
        if(whichButton == true){
            lower.text += "9";
        }
    }

    public void Zero(){
        if(whichButton == false){
            upper.text += "0";
        }
        if(whichButton == true){
            lower.text += "0";
        }
    }

    public void Dot(){
        if(whichButton == false){
            upper.text += ".";
        }
        if(whichButton == true){
            lower.text += ".";
        }
    }

    public void Clear(){
        if(whichButton == false){
            upper.text = "";
        }
        if(whichButton == true){
            lower.text = "";
        }
    }

    public void Calculate(){
        resultText.text ="";
        int result = (int)(float.Parse(upper.text)/(100/float.Parse(lower.text)-1));
        resultText.text = "= " + result.ToString();
        ConstantData.addWeight = result;
    }
   
}
