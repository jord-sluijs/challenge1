using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   public float turnSpeed = 25.0f;
   public float verticalInput; 
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 15); 
        transform.Translate(Vector2.up * turnSpeed * Time.deltaTime * 15);

    }
}
