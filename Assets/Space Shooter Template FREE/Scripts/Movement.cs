using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float _speed = 5.0f;
    private float _horizontalInput;
    private float _verticalInput;
    // Update is called once per frame
    void Update()
    {
     _horizontalInput = Input.GetAxis("Horizontal");
     _verticalInput = Input.GetAxis("Vertical");
     
     // transform.Translate(Vector3.right * (Time.deltaTime * _speed * _horizontalInput));
     //
     // transform.TransformDirection(Vector3.forward * (_verticalInput * _speed));
     
     Vector3 movement = new Vector3(_horizontalInput, _verticalInput, 0f);
     transform.position += movement * Time.deltaTime * _speed;
    }
}
