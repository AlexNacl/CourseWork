using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepTwoTriggerRed : MonoBehaviour
{
    public UnityEngine.Events.UnityEvent DialogsToTrigger;
    public UnityEngine.Events.UnityEvent StepTwoRed;
    public UnityEngine.Events.UnityEvent StepTwoWhite;
    public UnityEngine.Events.UnityEvent StepThreeRed;
    public static bool isTriggered = true;
    public static bool isTriggeredStepTwoRed = false;
    public static bool isTriggeredStepTwoWhite = false;
    public static bool isTriggeredStepTwoGreen = false;
    public static bool isTriggeredStepThreeRed = false;
    public static bool isTriggeredStepThreeWhite = false;
    public static bool isTriggeredStepThreeGreen = false;
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
    }
}
