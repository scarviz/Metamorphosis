using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRoll : MonoBehaviour {
	public GameObject cylinder;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		var rotation = cylinder.transform.rotation;
		rotation *= Quaternion.Euler(0, -120 * Time.deltaTime, 0);
		cylinder.transform.rotation = rotation;
	}
}
