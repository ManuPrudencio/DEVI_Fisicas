using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptFisicas : MonoBehaviour
{
    [SerializeField]
    public int jumpForce = 1000;

    [SerializeField]
    public bool canJump;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Espacio pulsado");
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0,0,5) * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -5) * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-5, 0, 0) * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(5, 0, 0) * Time.deltaTime);

        }



    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Muro"))
        {
           

        }
        canJump = true;


    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Suelo"))
        {
            Destroy(gameObject);

        }


    }

    void OnCollisionExit(Collision collision)
    {
        canJump = false;

    }

}