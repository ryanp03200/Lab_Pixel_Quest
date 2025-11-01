using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumppower;
    private Rigidbody2D _rb;
    private void Start()
   
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            _rb.velocity = new Vector2(_rb.velocity.x, jumppower);
        }
    }





}