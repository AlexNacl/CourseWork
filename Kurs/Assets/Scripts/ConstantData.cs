using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.Audio;

public class ConstantData : MonoBehaviour
{
    public AudioMixer mixer;
    public Text ProcentText;
    public Text SpeedText;
    public static float mixerLevel = 1;
    public static int colorNumb = 0;
    public static float colorBright = 0;
    public static float Temp = 0;
    public static float Speed = 0;
    public static int addWeight = 0;
    public static int phaseNum = 0;
    public static bool LibraOpen = false;
    public static bool TableOpen = false;
    public static bool FurnaceOn = false;
    public static bool Freeze = false;
    public static bool Fail = false;
    public void ColorWhite() {
        colorNumb = 1;
    }
    public void ColorRed() {
        colorNumb = 2;
    }
    public void ColorBlue() {
        colorNumb = 3;
    }
    public void ColorYellow() {
        colorNumb = 4;
    }
    public void SecondPhase(){
        phaseNum = 1;
    }
    public void TableOpenScript(){
        TableOpen = true;
    }
	public void AdjustBrightness(float choise){
        colorBright = choise+1;
	}
    public void Adjust(){
        ProcentText.text = "Вы выбрали w="+(int)colorBright+"%. Посмотретие на формулу." + Environment.NewLine + "Дано:" + Environment.NewLine + "m(Al2O3) = 100грамм" + Environment.NewLine + "w = "+(int)colorBright+"%" + Environment.NewLine + "Найти: m добавки" + Environment.NewLine + "Вставьте пропуски в поля и нажмите 'Равно'";
    }
    public void AdjustTemperature(float choise){
        Temp = choise;
        if(FurnaceOn == true){
            if((int)Temp == 2067){
                Freeze = true;
            }else if((int)Temp<2067){
                Freeze = false;
                Fail = true;
            } else {
                Freeze = true;
            }
        }
	}
    public void AdjustTempNum(){
        ProcentText.text = "";
        ProcentText.text += (int)Temp;
    }
    public void plusBtnClick(){
        Temp++;
        ProcentText.text = "";
        ProcentText.text += (int)Temp;
        if(FurnaceOn == true){
            if((int)Temp == 2067){
                Freeze = true;
            }else if((int)Temp<2067){
                Freeze = false;
                Fail = true;
            } else {
                Freeze = true;
            }
        }
    }
    public void minusBtnClick(){
        Temp--;
        ProcentText.text = "";
        ProcentText.text += (int)Temp;
        if(FurnaceOn == true){
            if((int)Temp == 2067){
                Freeze = true;
            }else if((int)Temp<2067){
                Freeze = false;
                Fail = true;
            } else {
                Freeze = true;
            }
        }
    }
    public void On(){
        if((int)Temp == 2077){
            FurnaceOn = true;
            StepTwoTriggerRed.isTriggeredStepTwoRed = true;
            Debug.Log("TriggerHappy");
        }
    }
    public void FreezeScript(){
        if(Freeze == true){
            StepTwoTriggerRed.isTriggeredStepTwoWhite = true;
        }
    }

    public void AdjustSpeed(float choise){
        Speed = choise;
	}
    public void AdjustSpeedNum(){
        SpeedText.text = "";
        SpeedText.text += (int)Speed;
    }
     public void plusBtnClickSpeed(){
        Speed++;
        SpeedText.text = "";
        SpeedText.text += (int)Speed;
    }
    public void minusBtnClickSpeed(){
        Speed--;
        SpeedText.text = "";
        SpeedText.text += (int)Speed;
    }

    public void SpeedConfirm(){
        if((int)Speed < 11){
            if((int)Speed>2){
                StepTwoTriggerRed.isTriggeredStepThreeRed = true;
        }
        }else if((int)Speed > 11){
            Fail = true;
        }
        else if((int)Speed < 2){
            Fail = true;
        }
    }

    public void SetLevel(float mixerLevel)
    {
        mixer.SetFloat ("MusicVol",Mathf.Log10(mixerLevel)*20);
        ConstantData.mixerLevel = mixerLevel;
    }
}
