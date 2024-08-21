using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordScript : MonoBehaviour
{
    [SerializeField] int SwordDamage = 5;

    public GameObject SwordParticle;

    bool Sword_Particle = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {

        //Œ•‚Æ“G1‚Ì“–‚½‚è”»’è
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);

            Sword_Particle = true;
        }

        //Œ•‚Æ“G‚Q‚Ì“–‚½‚è”»’è

    }
}
