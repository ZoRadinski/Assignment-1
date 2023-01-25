using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDamage : MonoBehaviour
{
    public float damage;
    public float damageRate;
 

    float nextDamage;

    // Start is called before the first frame update
    void Start()
    {
        nextDamage = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag=="Player" && nextDamage < Time.time)
        {
            healthygrl thePlayerHealth = other.gameObject.GetComponent<healthygrl>();
            thePlayerHealth.addDamage(damage);
            nextDamage = Time.time + damageRate;

         
        }
    }

 



}
