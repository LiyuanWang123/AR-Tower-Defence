using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite : MonoBehaviour {

    Sprite currentSprite;

	// Use this for initialization
	void Start () {
        currentSprite = gameObject.GetComponent<Sprite>();
        currentSprite.transform.localScale = new Vector3(Screen.width / 1366f, Screen.height / 768f, 1);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

}
