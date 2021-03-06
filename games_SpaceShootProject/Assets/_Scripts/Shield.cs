﻿using UnityEngine;
using System.Collections;

public class Shield : MonoBehaviour {

	public float rotationsPerSec = 0.1f;
	public bool ___________;
	public int levelShown = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//read current shield level
		int currLevel = Mathf.FloorToInt(Player.S.shieldLevel);

		if (levelShown != currLevel) {
			levelShown = currLevel;
			Material mat = this.GetComponent<Renderer>().material;
			mat.mainTextureOffset = new Vector2 (0.2f * levelShown, 0);
		}

		float rZ = (rotationsPerSec * Time.time * 360) % 360f;
		transform.rotation = Quaternion.Euler (0, 0, rZ);
	}
}
