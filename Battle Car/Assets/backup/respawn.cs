﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour {

	public int respawnTime = 60;

	void OnCollisionEnter(){
		this.GetComponent<SphereCollider> ().enabled = false;
		this.GetComponent<MeshRenderer> ().enabled = false;

		Invoke ("Respawn", respawnTime);
	}


	void Respawn(){
		this.GetComponent<SphereCollider> ().enabled = true;
		this.GetComponent<MeshRenderer> ().enabled = true;
	}
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
