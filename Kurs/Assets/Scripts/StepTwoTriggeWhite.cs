using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepTwoTriggerWhite : MonoBehaviour
{
    public UnityEngine.Events.UnityEvent DialogsToTrigger;
    public static bool isTriggered = false;
    void Start()
    {
        
    }

    void Update()
    {
        if (isTriggered==false){
            DialogsToTrigger.Invoke();
            isTriggered = true;
        }
    }
}
