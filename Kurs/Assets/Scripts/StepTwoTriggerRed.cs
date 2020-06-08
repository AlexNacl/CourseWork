using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepTwoTriggerRed : MonoBehaviour
{
    public UnityEngine.Events.UnityEvent DialogsToTrigger;
    public UnityEngine.Events.UnityEvent StepTwoRed;
    public UnityEngine.Events.UnityEvent StepTwoWhite;
    public UnityEngine.Events.UnityEvent StepThreeRed;
    public UnityEngine.Events.UnityEvent DialogOne;
    public UnityEngine.Events.UnityEvent WhiteTrigger;
    public UnityEngine.Events.UnityEvent RedTrigger;
    public UnityEngine.Events.UnityEvent YellowTrigger;
    public UnityEngine.Events.UnityEvent BlueTrigger;
    public UnityEngine.Events.UnityEvent White2Trigger;
    public UnityEngine.Events.UnityEvent Red2Trigger;
    public UnityEngine.Events.UnityEvent Yellow2Trigger;
    public UnityEngine.Events.UnityEvent Blue2Trigger;
    public UnityEngine.Events.UnityEvent SkeepTrigger;
    public UnityEngine.Events.UnityEvent VanadiumTrigger;
    public UnityEngine.Events.UnityEvent ChromiumTrigger;
    public UnityEngine.Events.UnityEvent FerrumTrigger;
    public UnityEngine.Events.UnityEvent TitaniumTrigger;
    public UnityEngine.Events.UnityEvent DroppedTrigger;
    public static bool white = false;
    public static bool red = false;
    public static bool blue = false;
    public static bool yellow = false;
    public static bool white2 = false;
    public static bool red2 = false;
    public static bool blue2 = false;
    public static bool yellow2 = false;
    public static bool isTriggered = true;
    public static bool Skeep = false;
    public static bool Vanadium = false;
    public static bool Chromium = false;
    public static bool Ferrum = false;
    public static bool Titanium = false;
    public static bool drop = false;
    public static bool isTriggeredStepTwoRed = false;
    public static bool isTriggeredStepTwoWhite = false;
    public static bool isTriggeredStepTwoGreen = false;
    public static bool isTriggeredStepThreeRed = false;
    public static bool isTriggeredStepThreeWhite = false;
    public static bool isTriggeredStepThreeGreen = false;
    public static bool isDialogTriggerOne = false;
    void Start()
    {
        
    }

    void Update()
    {
        if (isTriggered==true){
            DialogsToTrigger.Invoke();
            isTriggered = false;
        }
        if (isTriggeredStepTwoRed==true){
            StepTwoRed.Invoke();
            isTriggeredStepTwoRed = false;
        }
        
        if (isTriggeredStepTwoWhite==true){
            StepTwoWhite.Invoke();
            isTriggeredStepTwoWhite = false;
        }
        if (isTriggeredStepThreeRed==true){
            StepThreeRed.Invoke();
            isTriggeredStepThreeRed = false;
        }
        if (isDialogTriggerOne==true){
            DialogOne.Invoke();
            isDialogTriggerOne = false;
        }
        if (white==true){
            WhiteTrigger.Invoke();
            white = false;
        }
        if (red==true){
            RedTrigger.Invoke();
            red = false;
        }
        if (blue==true){
            BlueTrigger.Invoke();
            blue = false;
        }
        if (yellow==true){
            YellowTrigger.Invoke();
            yellow = false;
        }
        if (white2==true){
            White2Trigger.Invoke();
            white2 = false;
        }
        if (red2==true){
            Red2Trigger.Invoke();
            red2 = false;
        }
        if (blue2==true){
            Blue2Trigger.Invoke();
            blue2 = false;
        }
        if (yellow2==true){
            Yellow2Trigger.Invoke();
            yellow2 = false;
        }
        if (Skeep==true){
            SkeepTrigger.Invoke();
            Skeep = false;
        }
        if (Vanadium == true){
            VanadiumTrigger.Invoke();
            Vanadium = false;
        }
        if (Chromium == true){
            ChromiumTrigger.Invoke();
            Chromium = false;
        }
        if (Ferrum == true){
            FerrumTrigger.Invoke();
            Ferrum = false;
        }
        if (Titanium == true){
            TitaniumTrigger.Invoke();
            Titanium = false;
        }
        if (drop == true){
            DroppedTrigger.Invoke();
            drop = false;
        }
    }

    public void IfWhite(){
        if (ConstantData.colorNumb == 1){
            white = true;
        }
        if (ConstantData.colorNumb == 2){
            red = true;
        }
        if (ConstantData.colorNumb == 3){
            blue = true;
        }
        if (ConstantData.colorNumb == 4){
           yellow = true;
        }  
    }
    public void IfWhite2(){
        if (ConstantData.colorNumb == 1){
            white2 = true;
        }
        if (ConstantData.colorNumb == 2){
            red2 = true;
        }
        if (ConstantData.colorNumb == 3){
            blue2 = true;
        }
        if (ConstantData.colorNumb == 4){
           yellow2 = true;
        }  
    }

    public void Skeeper(){
        if (ConstantData.colorNumb == 1){
            Skeep = true;
        } 
    }

    public void Dropped(){
        drop = true;
    }
}
