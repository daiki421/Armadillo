using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemController : MonoBehaviour {

    //[SerializeField]
    //GameObject hogehoge;

    //[SerializeField]
    //GameObject canvas;

    //[SerializeField]
    //GameObject childPrefab;
    //public GameObject item;
    //GameObject imagePrefab;
    GameObject pillar;

    void Awake()
    {
        //buttonPrefab = Resources.Load<GameObject>("Prefabs/Item");
    }

    void Start()
    {
        pillar = GameObject.Find("ItemPillar");
    }

     //Update is called once per frame
    [SerializeField, Range(0f, 1f)] private float followStrength;
    void Update () {

    }

    public void MyPointerDownUI()
    {
        Debug.Log("押された");
        //var instance = Instantiate(buttonPrefab);
        //pillar.transform.SetParent(gameObject.transform, false);
        // マウス位置をスクリーン座標からワールド座標に変換する
        var targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pillar.transform.position = new Vector3(targetPos.x, targetPos.y, -1f);
        // Z座標を修正する
        //targetPos.z = 0f;
    }

    public void MyDragUI()
    {
        print("ドラッグ");
        // マウス位置をスクリーン座標からワールド座標に変換する
        var targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);


        // Z座標を修正する
        targetPos.z = -1f;

        // このスクリプトがアタッチされたゲームオブジェクトを、マウス位置に線形補間で追従させる
        pillar.transform.position = Vector3.Lerp(transform.position, targetPos, followStrength);
    }

    public void MyPointerUp()
    {
        print("アップ");
        Rigidbody2D rigidbody;
        rigidbody = pillar.AddComponent<Rigidbody2D>();
        rigidbody.mass = 200;
        Collider2D collider;
        collider = pillar.GetComponent<Collider2D>();
        collider.isTrigger = false;
        GameObject.Find("Image").SetActive(false);
        pillar.GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 1.0f);
    }
}
