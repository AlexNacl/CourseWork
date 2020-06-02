using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibraOpenScript : MonoBehaviour
{
    void Awake()
    {
        if(ConstantData.LibraOpen == true){
            StepTwoTriggerRed.isTriggeredStepThreeRed = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
