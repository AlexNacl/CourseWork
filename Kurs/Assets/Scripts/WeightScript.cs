using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeightScript : MonoBehaviour
{
    public Text self;
    public Dialog dialogGood;
    public Dialog dialogBad;
    public Dialog dialogBadSecond;
    public Dialog dialogGoodSecond;
    public static int weight = 0;
    public GameObject robogood;
    public GameObject roboangry;
    public bool secondPhase = false;

    public void TriggerDialogGood(){
        robogood.SetActive(true);
        roboangry.SetActive(false);
        FindObjectOfType<DialogManager>().StartDialog(dialogGood);
    }
    public void TriggerDialogBad(){
        robogood.SetActive(false);
        roboangry.SetActive(true);
        FindObjectOfType<DialogManager>().StartDialog(dialogBad);
    }
    public void TriggerDialogGoodSecond(){
        robogood.SetActive(true);
        roboangry.SetActive(false);
        FindObjectOfType<DialogManager>().StartDialog(dialogGoodSecond);
    }
    public void TriggerDialogBadSecond(){
        robogood.SetActive(false);
        roboangry.SetActive(true);
        FindObjectOfType<DialogManager>().StartDialog(dialogBadSecond);
    }

    public void nextPhase(){
        secondPhase = true;
    }
    
    public void plusBtnClick(){
        weight++;
        UpdateTest();
    }
    public void minusBtnClick(){
        weight--;
        UpdateTest();
    }

    public void bigPlusClick(){
        weight+=10;
        UpdateTest();
    }
    
    public void bigMinusClick(){
        weight-=10;
        UpdateTest();
    }  

    public void UpdateTest()
	{
		self.text = weight.ToString();
	}

    public void Apply(){
        if(secondPhase==false){
            if (weight !=100){
            robogood.SetActive(false);
            roboangry.SetActive(true);
            TriggerDialogBad();
            }
            if (weight == 100){
                robogood.SetActive(true);
                roboangry.SetActive(false);
                TriggerDialogGood();
                StepTwoTriggerRed.isTriggeredStepTwoWhite = true;
            }
        }
        if(secondPhase==true){
            if (weight != ConstantData.addWeight){
                TriggerDialogBadSecond();
            }
            if (weight == ConstantData.addWeight){
                TriggerDialogGoodSecond();
                StepTwoTriggerRed.isTriggeredStepThreeRed = true;
                ConstantData.phaseNum = 1;
                ConstantData.LibraOpen = true;
            }
        }
        
    }
        
}
