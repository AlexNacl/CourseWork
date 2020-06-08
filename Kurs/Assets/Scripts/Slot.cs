using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IDropHandler {

    //public Text addText;
    public static bool wrongComp = false;
    public static bool stepTwo = false;
    public static int rightRedComponentNum = 0;
    public static int rightBlueComponentNum = 0;
    public static int rightYellowComponentNum = 0;

    public void OnDrop(PointerEventData eventData) {
        Debug.Log("OnDrop");
            if (eventData.pointerDrag != null) {
                if (stepTwo == false){
                    if(eventData.pointerDrag.GetComponent<DragDrop>().JarNum == 0)
                {   
                    //addText.text += "Al2O3";
                    GameManager.IsFirstCorrect = true;
                    ConstantData.dropped = true;
                    StepTwoTriggerRed.isDialogTriggerOne = true;
                    Debug.Log("ComponentSlot");
                    stepTwo = true;
                }    
                else if (ConstantData.wrongComp == false){
                    ConstantData.wrongComp = true;
                    ConstantData.dropped = true;
                    Debug.Log("WrongComponentSlot");
                    
                } else
                {
                    ConstantData.dropped = false;
                }
                }
                








            if (stepTwo == true){
                if (eventData.pointerDrag.GetComponent<DragDrop>().JarNum == 1){
                    if (ConstantData.colorNumb == 3){
                        ConstantData.dropped = true;
                        rightBlueComponentNum++;
                    } else {
                        ConstantData.wrongComp = true;
                        ConstantData.dropped = true;
                    }
                } else
                if (eventData.pointerDrag.GetComponent<DragDrop>().JarNum == 2){
                    if (ConstantData.colorNumb == 2){
                        ConstantData.dropped = true;
                        rightRedComponentNum++;
                    } else {
                        ConstantData.wrongComp = true;
                        ConstantData.dropped = true;
                    }
                } else
                if (eventData.pointerDrag.GetComponent<DragDrop>().JarNum == 3){
                    if (ConstantData.colorNumb == 4){
                        ConstantData.dropped = true;
                        rightYellowComponentNum++;
                    } else {
                        ConstantData.wrongComp = true;
                        ConstantData.dropped = true;
                    }
                } else
                if (eventData.pointerDrag.GetComponent<DragDrop>().JarNum == 4){
                    if (ConstantData.colorNumb == 2){
                        ConstantData.dropped = true;
                        rightRedComponentNum++;
                    } else {
                        ConstantData.wrongComp = true;
                        ConstantData.dropped = true;
                    } 
                }
            }
                










                if (ConstantData.colorNumb == 2){
                    if(rightRedComponentNum == 2){
                        StepTwoTriggerRed.isTriggeredStepThreeRed = true;
                    }
                }
                if (ConstantData.colorNumb == 3){
                    if(rightBlueComponentNum == 1){
                        StepTwoTriggerRed.isTriggeredStepThreeRed = true;
                    }
                }
                if (ConstantData.colorNumb == 4){
                    if(rightYellowComponentNum == 1){
                        StepTwoTriggerRed.isTriggeredStepThreeRed = true;
                    }
                }
        }
    }
}
