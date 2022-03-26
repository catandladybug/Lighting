using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float moveSpeed = 10f;


    private float vInput;
    private float hInput;

    void Update()
    {

        vInput = Input.GetAxis("Vertical") * moveSpeed;
        hInput = Input.GetAxis("Horizontal") * moveSpeed;

        this.transform.Translate(Vector3.back * vInput * Time.deltaTime);
        this.transform.Translate(Vector3.left * hInput * Time.deltaTime);
    }

    private void FixedUpdate()
    {



    }
}
