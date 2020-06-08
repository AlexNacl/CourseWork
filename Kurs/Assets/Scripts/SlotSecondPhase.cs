using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotSecondPhase : MonoBehaviour, IDropHandler {

    public Text addText;
    public static bool dropped = false;
    public static bool wrongComp = false;
    public static bool readyNext = false;
    public static bool secondTask = false;
    public static bool Chromium = false;
    public static bool Vanadium = false;
    public static bool Titanium = false;
    public static bool Ferrum = false;
    public static bool Cro = false;
    public static bool Van = false;



    public static int rightComponentNum = 0;


    private void Awake(){
        if (ConstantData.colorNumb == 1){
            StepTwoTriggerRed.white = true;
        }
        if (ConstantData.colorNumb == 2){
            StepTwoTriggerRed.red = true;
        }
        if (ConstantData.colorNumb == 3){
            StepTwoTriggerRed.blue = true;
        }
        if (ConstantData.colorNumb == 4){
           StepTwoTriggerRed.yellow = true;
        }  
    }


    public void ReadyMaker(){
        readyNext = true;
    }

    public void OnDrop(PointerEventData eventData) {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null) {

            if (secondTask == false){
                ConstantData.wrongComp = true;
                ConstantData.dropped = false;
                Debug.Log("WrongComponent");
            }
            
            if (secondTask == true && readyNext == true){
                 Debug.Log("WrongComponentSlot");
                if  (eventData.pointerDrag.GetComponent<DragDrop>().JarNum == 2){
                    if (ConstantData.colorNumb == 2){
                    StepTwoTriggerRed.drop = true;
                    readyNext = false;
                    ConstantData.dropped = true;
                    Vanadium = true;
                    } 
                } else 
                if (eventData.pointerDrag.GetComponent<DragDrop>().JarNum == 4){
                    if (ConstantData.colorNumb == 2){
                    StepTwoTriggerRed.drop = true;
                    readyNext = false;
                    ConstantData.dropped = true;
                    Chromium = true;
                    }
                } else 
                if (eventData.pointerDrag.GetComponent<DragDrop>().JarNum == 1){
                    if (ConstantData.colorNumb == 3){
                    StepTwoTriggerRed.drop = true;
                    ConstantData.dropped = true;
                    Titanium = true;
                    }
                } else 
                if (eventData.pointerDrag.GetComponent<DragDrop>().JarNum == 3){
                    if (ConstantData.colorNumb == 4){
                    StepTwoTriggerRed.drop = true;
                    ConstantData.dropped = true;
                    Ferrum = true;
                    }
                } else {
                ConstantData.wrongComp = true;
                ConstantData.dropped = false;
                Debug.Log("WrongComponentSlot");
                }
            } else if (eventData.pointerDrag.GetComponent<DragDrop>().JarNum > 10){
                if (eventData.pointerDrag.GetComponent<DragDrop>().JarNum == 11){
                    StepTwoTriggerRed.isDialogTriggerOne = true;
                    ConstantData.dropped = true;
                }
                if (eventData.pointerDrag.GetComponent<DragDrop>().JarNum == 12){
                    if (Cro == true){
                        StepTwoTriggerRed.isDialogTriggerOne = true;
                        ConstantData.dropped = true;
                    } else {
                        Van = true;
                        ConstantData.dropped = true;
                    }
                }
                if (eventData.pointerDrag.GetComponent<DragDrop>().JarNum == 13){
                    StepTwoTriggerRed.isDialogTriggerOne = true;
                    ConstantData.dropped = true;
                }
                if (eventData.pointerDrag.GetComponent<DragDrop>().JarNum == 14){
                    if (Van == true){
                        StepTwoTriggerRed.isDialogTriggerOne = true;
                        ConstantData.dropped = true;
                    } else {
                       Cro = true; 
                       ConstantData.dropped = true;
                    }
                }
            }
            else {
                ConstantData.wrongComp = true;
                ConstantData.dropped = false;
                Debug.Log("WrongComponentSlot");
            }
        }
    }
}

