﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterController : MonoBehaviour {

    public Object thumbs;

	// Use this for initialization
	void Start () {
        GameObject.Find("UIModel").GetComponent<UIController>().PrintCenteredText("Press Enter!");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("return"))
        {
            GameObject.Find("UIModel").GetComponent<UIController>().RemoveCenteredText();
            GameObject.Find("PlayerModel").GetComponent<PlayerController>().CreatePlayer();
        }
	}

}