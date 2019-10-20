using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageSelectController : MonoBehaviour {



	// Use this for initialization
	void Start () {
        // 個別でボタンを識別
        // クリアしてるか判定
        // クリアしてない場合はボタンを押せないようにする
        // 初クリアかどうか判定
        // 初クリアの場合は鎖が消えて無くなる演出を入れる
        // 2回目以降は鎖がない状態でボタンを表示
        if (PlayerPrefs.GetInt("Stage1", 0) == 0)
        {
            Button btn = GetComponent<Button>();
            btn.interactable = false;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void testPush ()
    {

        print("PUSH");
    }
}
