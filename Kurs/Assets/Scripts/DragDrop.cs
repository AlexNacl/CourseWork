
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler {

    [SerializeField] private Canvas canvas;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    public GameObject self;
    public int JarNum;
    protected float pX;
    protected float pY;
    public Dialog dialog;
    public GameObject robogood;
    public GameObject roboangry;

    public void TriggerDialog(){
        FindObjectOfType<DialogManager>().StartDialog(dialog);
    }

    private void Awake() {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        pX = rectTransform.anchoredPosition.x;
        pY = rectTransform.anchoredPosition.y;
    }

    public void OnBeginDrag(PointerEventData eventData) {
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData) {
        //Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData) {
        canvasGroup.blocksRaycasts = true;
        Debug.Log("OnEnd");
        if (ConstantData.dropped == false){
            rectTransform.anchoredPosition = new Vector2(pX/canvas.scaleFactor, pY/canvas.scaleFactor);
            robogood.SetActive(true);
            roboangry.SetActive(false);
            Debug.Log("Dropped false");
        } else if (ConstantData.wrongComp == true){
            rectTransform.anchoredPosition = new Vector2(pX/canvas.scaleFactor, pY/canvas.scaleFactor);
            Debug.Log("DoingMyWork");
            robogood.SetActive(false);
            roboangry.SetActive(true);
            ConstantData.wrongComp = false;
            ConstantData.dropped = false;
            //TriggerDialog();
        } else
        {
            Debug.Log("Check");
            self.SetActive(false);
            robogood.SetActive(true);
            roboangry.SetActive(false);
            ConstantData.wrongComp = false;
            ConstantData.dropped = false;
        }
    }

    public void OnPointerDown(PointerEventData eventData) {
    }

}
