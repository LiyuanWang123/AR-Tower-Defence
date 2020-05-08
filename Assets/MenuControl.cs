using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuControl : MonoBehaviour {
    public Canvas CanvasObject;


    // Use this for initialization
    void Start()
    {
        CanvasObject = GameObject.Find("MenuCanvas").GetComponent<Canvas>();
        CanvasObject.GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MenuShow()
    {

     if (CanvasObject.enabled == false)
     {
                CanvasObject.GetComponent<Canvas>().enabled = true;
            }

        else {
                CanvasObject.GetComponent<Canvas>().enabled = false;
            }        
     
    }
}