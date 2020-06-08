using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explainscript : MonoBehaviour
{

    bool wasShownOne = false;
    public GameObject objOne;
    bool wasShownTwo = false;
    public GameObject objTwo;

    public void show(){
        if (wasShownTwo == true && wasShownOne == true){
            StepTwoTriggerRed.isDialogTriggerOne = true;
        }
        if (wasShownTwo == false && wasShownOne == true){
            objTwo.SetActive(true);
            wasShownTwo = true;
        } else {
            objTwo.SetActive(false);
        }
        if (wasShownOne == false){
            objOne.SetActive(true);
            wasShownOne = true;
        } else {
            objOne.SetActive(false);
        }
        
    }
}
