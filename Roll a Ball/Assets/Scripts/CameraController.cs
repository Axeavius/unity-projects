using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public GameObject player;

    private Vector3 offest;

    // Use this for initialization
    void Start () {
        offest = transform.position - player.transform.position;
    }
    
    // Update is called once per frame
    void Update () {
        //transform.position = player.transform.position + offest;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offest;
    }
}
