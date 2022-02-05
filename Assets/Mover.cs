using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float jumpSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        // Need to look up correct GetKey input for spacebar for jump function
        float yValue = Input.GetKeyDown(KeyCode.Space) * Time.deltaTime;
        transform.Translate(xValue,yValue,zValue);
    }
}
