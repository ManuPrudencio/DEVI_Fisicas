using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Destruible"))
        {
            Debug.Log("Se ha acertado el disparo");
            Destroy(collision.gameObject);
              Debug.Log("Se ha acertado el disparo");
        }
        if (collision.gameObject.layer == LayerMask.NameToLayer("Destruible"))
        {
            Destroy(collision.gameObject);
        }
    }
}
