using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5.0f;
    public float shiftspeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float movevertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, movevertical);
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += movement * shiftspeed * Time.deltaTime;
        }
        else
        {
            transform.position += movement * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightShift))
        {
            transform.position += movement * shiftspeed * Time.deltaTime;
        }
        else
        {
            transform.position += movement * speed * Time.deltaTime;
        }
    }
}
