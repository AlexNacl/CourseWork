using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotSecondPhase : MonoBehaviour, IDropHandler {

    public Text addText;
    public static bool dropped = false;
    public static bool wrongComp = false;
    public static bool secondTask = false;
    public static int rightComponentNum = 0;

    public void OnDrop(PointerEventData eventData) {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null) {
            if (secondTask == false){
                if(eventData.pointerDrag.GetComponent<DragNDropSecondPhase>().JarNum == 0)
                {   
                    StepTwoTriggerRed.isTriggeredStepTwoRed = true;
                    dropped = true;
                    Debug.Log("Dropped true");
                } else {
                    wrongComp = true;
                    dropped = true;
                    Debug.Log("WrongComponent");
                }
            }
            if (secondTask == true){
                if (eventData.pointerDrag.GetComponent<DragNDropSecondPhase>().JarNum == 2){
                wrongComp = true;
                dropped = true;
                Debug.Log("WrongComponent");
                } else{

                }
            } 
        }
    }
}
