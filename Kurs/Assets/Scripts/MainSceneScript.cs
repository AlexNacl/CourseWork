using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneScript : MonoBehaviour
{
    public static bool phase = false;
    public Animator animator;
    void Awake()
    {
        if(ConstantData.phaseNum == 0){
            StepTwoTriggerRed.isTriggered = true;
        }
        if(ConstantData.phaseNum == 1){
            StepTwoTriggerRed.isTriggeredStepTwoRed = true;
        }
        if(ConstantData.LibraOpen == true){
            StepTwoTriggerRed.isTriggeredStepTwoWhite = true;
        }
    }

    void Update()
    {
        //if(ConstantData.phaseNum == 0){
        //    StepTwoTriggerRed.isTriggered = true;
        //}
        //if(ConstantData.phaseNum == 1){
        //    StepTwoTriggerRed.isTriggeredStepTwoRed = true;
        //}
    }

    public void ToFurnace()
    {
        animator.SetBool("Furnace", true);
    }
    public void ToTable()
    {
        animator.SetBool("Furnace", false);
    }
}
