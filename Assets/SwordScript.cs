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

        //���ƓG1�̓����蔻��
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);

            Sword_Particle = true;
        }

        //���ƓG�Q�̓����蔻��

    }
}
