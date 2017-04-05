using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootScript : MonoBehaviour {
    public Rigidbody2D rocket;
    public float speed = 10f;

    public KeyCode shootButton = KeyCode.LeftControl;

    // Use this for initialization
    void Start () {
		
	}

 

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown(shootButton))
        {
            GetComponent<PrimaryShot>().FireRocket(Vector3.zero);
        }
		
	}
}
