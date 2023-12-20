using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreFinishMove : MonoBehaviour
{
    
    void Update()
    {
        float x = Mathf.MoveTowards(transform.position.x, 0, Time.deltaTime * 2f);
        float z = transform.position.z + 3f * Time.deltaTime;
        transform.position += new Vector3(0, 0, 3*Time.deltaTime);


        float rot = Mathf.MoveTowardsAngle(transform.eulerAngles.y, 0, Time.deltaTime * 10f);
        transform.localEulerAngles = new Vector3(0, rot, 0);
    
    
    }
}
