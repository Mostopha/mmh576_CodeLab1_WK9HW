using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimaryShot : MonoBehaviour {

    protected string name = "PrimaryShot";
    protected float speed = 10.0f;
    public virtual void FireRocket(Vector3 modPos)
    {
        GameObject rocketClone = Instantiate(Resources.Load("Prefabs/Sphere")) as GameObject;
        rocketClone.transform.position = transform.position+modPos;
        rocketClone.GetComponent<Rigidbody2D>().AddForce(Vector3.left * speed);
      
        

    }
}
