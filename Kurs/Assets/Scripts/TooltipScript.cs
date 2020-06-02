using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TooltipScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]
    private GameObject tooltip;
    
    public void ShowTooltip(){
		tooltip.SetActive(true);
	}

    public void HideTooltip(){
        tooltip.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData){
        ShowTooltip();
    }

    public void OnPointerExit(PointerEventData eventData){
        HideTooltip();
    }
}
