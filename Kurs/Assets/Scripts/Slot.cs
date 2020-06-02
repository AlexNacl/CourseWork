using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IDropHandler {

    public Text addText;
    public static bool dropped = false;
    public static bool wrongComp = false;
    public static int rightComponentNum = 0;

    public void OnDrop(PointerEventData eventData) {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null) {
            if(eventData.pointerDrag.GetComponent<DragDrop>().JarNum == 0)
            {   
                if (ConstantData.colorNumb == 1){
                    addText.text += "Al2O3";
                    GameManager.IsFirstCorrect = true;
                    dropped = true;
                    StepTwoTriggerRed.isTriggeredStepTwoWhite = true;
                } 
                if (ConstantData.colorNumb == 2){
                    addText.text += "Al2O3";
                    GameManager.IsFirstCorrect = true;
                    dropped = true;
                    StepTwoTriggerRed.isTriggeredStepTwoRed = true;
                } 
            }    
                else if (eventData.pointerDrag.GetComponent<DragDrop>().JarNum == 1){
                    wrongComp = true;
                    dropped = true;
                    Debug.Log("WrongComponent");
                } else if (eventData.pointerDrag.GetComponent<DragDrop>().JarNum == 2){
                    if (ConstantData.colorNumb == 2){
                        addText.text += "Vanadium";
                        dropped = true;
                        rightComponentNum++;
                    } else {
                        wrongComp = true;
                        dropped = true;
                    }
                } else if (eventData.pointerDrag.GetComponent<DragDrop>().JarNum == 3){
                    if (ConstantData.colorNumb == 2){
                        addText.text += "C2O3";
                        dropped = true;
                        rightComponentNum++;
                    } else {
                        wrongComp = true;
                        dropped = true;
                    }
                } else if (eventData.pointerDrag.GetComponent<DragDrop>().JarNum == 4){
                    if (ConstantData.colorNumb == 3){
                        addText.text += "Kukaracha";
                        dropped = true;
                        rightComponentNum++;
                    } else {
                        wrongComp = true;
                        dropped = true;
                    }
                } else
                {
                    dropped = false;
                }
                if (ConstantData.colorNumb == 2){
                    if(rightComponentNum == 2){
                        StepTwoTriggerRed.isTriggeredStepThreeRed = true;
                    }
                }
        }
    }
}
