﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	
	public bool mobile;
	public bool advance;
	public bool retreat;
	public bool up;
	public bool down;

	// Use this for initialization
	void Start () {
		mobile = false;
		advance = false;
	}
	
	void FixedUpdate () {

	}
	
	// Update is called once per frame
	void LateUpdate () {
		if (mobile) {
			if(GameObject.Find("PlayerModel").GetComponent<Transform>().position.x - gameObject.transform.position.x > 2) {
				advance = true;
			}
			else if (GameObject.Find("PlayerModel").GetComponent<Transform>().position.x - gameObject.transform.position.x < 1) {
				advance = false;
			}
			
			if((gameObject.transform.position.x > 0) && (GameObject.Find("PlayerModel").GetComponent<Transform>().position.x - gameObject.transform.position.x < -2)) {
				retreat = true;
			}
			else if ((gameObject.transform.position.x <= 0) || (GameObject.Find("PlayerModel").GetComponent<Transform>().position.x - gameObject.transform.position.x > -1)) {
				retreat = false;
			}
			
			if((GameObject.Find("PlayerModel").GetComponent<Transform>().position.y - gameObject.transform.position.y > 2)) {
				up = true;
			}
			else if (GameObject.Find("PlayerModel").GetComponent<Transform>().position.y - gameObject.transform.position.y < 1) {
				up = false;
			}
			
			if((gameObject.transform.position.y > 0.5) && (GameObject.Find("PlayerModel").GetComponent<Transform>().position.y - gameObject.transform.position.y <= -1)) {
				down = true;
			}
			else if ((gameObject.transform.position.y <= 0.5) || (GameObject.Find("PlayerModel").GetComponent<Transform>().position.y - gameObject.transform.position.y > -1)) {
				down = false;
			}
			
			if(advance || retreat) {
				gameObject.transform.position += new Vector3 (0.045f * (GameObject.Find("PlayerModel").GetComponent<Transform>().position.x - gameObject.transform.position.x), 0, 0);
			}
			
			if(up) {
				gameObject.transform.position += new Vector3 (0, 0.2f, 0);
			}
			else if (down) {
				gameObject.transform.position -= new Vector3 (0, 0.2f, 0);
			}
		
		}
	}
}
