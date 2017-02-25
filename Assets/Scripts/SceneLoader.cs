using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () {
		//SceneManager.GetSceneByName("GameSelect");
		SceneManager.LoadScene("GameSelect", LoadSceneMode.Additive);
		SceneManager.LoadScene("Player", LoadSceneMode.Additive);

		yield return null;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
