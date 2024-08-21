using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Rigidbody rb;

    int EnemyHP = 30;

    // Start is called before the first frame update
    void Start()
    {
        EnemyHP = 30;

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Sword")
        {


            if (EnemyHP <= 0)
            {
                Destroy(other.gameObject);
                Destroy(this.gameObject);
            }
        }
    }
}
