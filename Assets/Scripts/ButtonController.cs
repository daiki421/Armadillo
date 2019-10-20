using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // to Main
    public void Reset() {
        SceneManager.LoadScene(2);
    }

    // to StageSelect
    public void Begin() {
        SceneManager.LoadScene(1);
    }

    // to Main
    public void Select() {
        SceneManager.LoadScene(2);
    }

    public void Play() {
        GameObject stopper = GameObject.Find("Stopper1");
        Destroy(stopper);
    }

    public void Item() {
        GameObject item_image = new GameObject("Item1");
        item_image.transform.parent = GameObject.Find("Canvas").transform;
        item_image.AddComponent<RectTransform>().anchoredPosition = new Vector3(0, 0, 0);
        item_image.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        item_image.AddComponent<Image>().sprite = Resources.Load<Sprite>("polygon");
    }
}
