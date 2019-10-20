using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        iTween.MoveTo(this.gameObject, iTween.Hash("position", new Vector3(8.7f, 0f, 54.8f), "time", 10f, "delay", 1f, "easeType", iTween.EaseType.linear));
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
