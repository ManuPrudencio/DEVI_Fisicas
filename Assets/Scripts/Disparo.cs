using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    [SerializeField]
    private float force = 1000;
    public GameObject ammo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            GameObject newBullet = Instantiate(ammo, this.transform.position, this.transform.rotation);
            newBullet.GetComponent<Rigidbody>().AddForce(this.transform.forward * force);


            
        }


    }
}
