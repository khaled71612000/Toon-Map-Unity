using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform followTarget;
    public float followspeed = 5;
    private Vector3 offset;
    void Start()
    {
        offset = followTarget.position - transform.position;
        
    }

    // Update is called once per Late frame
    void LateUpdate()
    {
        if(followTarget)
        {
            transform.position = followTarget.position - offset;
        }
        
    }
}
