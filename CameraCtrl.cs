﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrl : MonoBehaviour {

    public GameObject player;

    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position; 
	}
	
    private void LateUpdate()
    {

        transform.position = player.transform.position + offset;

    }
}
