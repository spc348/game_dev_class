using UnityEngine;
using System.Collections;

public class cameraLookat : MonoBehaviour {

    public Transform target;
    
    void Update ()
    {
        transform.LookAt(target);
    }
}