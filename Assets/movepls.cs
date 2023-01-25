using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movepls : MonoBehaviour
{
    private Rigidbody2D _rb;
    [SerializeField] private float speed = 2f;
    private void start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        _rb.MovePosition(transform.TransformPoint(Vector3.right * speed * Time.deltaTime));
    }
}
