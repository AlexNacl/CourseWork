using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableOpenScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        if(ConstantData.TableOpen == true){
            StepTwoTriggerRed.isTriggeredStepTwoRed = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
