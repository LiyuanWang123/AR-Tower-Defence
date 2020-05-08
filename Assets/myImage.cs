using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class myImage : MonoBehaviour
{
    Image myImageComponent;
    public Sprite myFirstImage;

    // Use this for initialization
    void Start()
    {
        myImageComponent = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.up = Camera.main.transform.position - transform.position;
        transform.forward = -Camera.main.transform.up;
    }
}

