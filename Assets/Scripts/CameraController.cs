using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform target;
    public float smoothing = 5f;
    private Vector3 offset;
    private float posy;
    private float posz;

    // Use this for initialization
    void Start () {
        offset = transform.position - target.position;

    }
	
	// Update is called once per frame
	void Update () {
        Vector3 targetCamPos = target.position + offset;
        targetCamPos.y = 0;
        targetCamPos.z = -100;

        //targetCamPos = new Vector3(target.position.x + offset.position.x, 0, -100);
        transform.position = Vector3.Lerp(
            transform.position,
            targetCamPos,
            Time.deltaTime * smoothing
        );
    }


}
