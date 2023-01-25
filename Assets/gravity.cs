using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{

    public Transform player;
    Rigidbody2D playerBody;
    public float influenceRange;
    public float intensity;
    public float distanceToPlayer;
    Vector2 pullForce;

    // Start is called before the first frame update
    void Start()
    {
        playerBody = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        distanceToPlayer = Vector2.Distance(player.position, transform.position);
        if (distanceToPlayer <= influenceRange)
        {
            pullForce = (transform.position - player.position).normalized / distanceToPlayer * intensity;
            playerBody.AddForce(pullForce, ForceMode2D.Force);
        }
    }
}
