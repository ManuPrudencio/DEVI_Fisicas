using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptFisicas : MonoBehaviour
{
    [SerializeField]
    public int jumpForce = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetKeyDown( KeyCode.Space ) )
            {
                Debug.Log("Espacio pulsado");
                this.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
            }
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.localPosition += Vector3.forward;

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.localPosition += Vector3.back;

        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.localPosition += Vector3.left;

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.localPosition += Vector3.right;

        }



    }
}