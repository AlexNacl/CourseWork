using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

	public UIManager current;
				
	public Text ColorText;	
	public static string currentColor;

	void Awake()
	{
		
	}

	public void ColorWhite() {
        currentColor = "Белый";
    }
    public void ColorRed() {
        currentColor = "Красный";
    }
    public void ColorBlue() {
        currentColor = "Синий";
    }
    public void ColorYellow() {
        currentColor = "Желтый";
    }


	public void UpdateColorTextUI()
	{
		if (current == null)
			return;
		current.ColorText.text = "Выбранный цвет кристалла: " + currentColor;
	}
}