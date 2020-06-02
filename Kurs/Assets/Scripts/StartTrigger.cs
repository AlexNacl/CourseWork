using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTrigger : MonoBehaviour
{
    public UnityEngine.Events.UnityEvent DialogsToTrigger;

    public bool isTriggered = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isTriggered==false){
            DialogsToTrigger.Invoke();
            isTriggered = true;
        }
    }
}
