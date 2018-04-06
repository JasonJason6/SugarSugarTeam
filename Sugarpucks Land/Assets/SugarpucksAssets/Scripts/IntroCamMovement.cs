using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroCamMovement : MonoBehaviour {
    public float speed;
    public GameObject Blue;
    
    private void Update()
    {
        
        transform.RotateAround(Blue.transform.position, new Vector3(0, 1, 0), 100 * Time.deltaTime * speed);
    }
}
