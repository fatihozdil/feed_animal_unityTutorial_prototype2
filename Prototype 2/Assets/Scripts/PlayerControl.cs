using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float horizontalInput;
    private float speed = 25.0f;
    private float boundary = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (transform.position.x < -boundary)
        {
            transform.position = new Vector3(-boundary, pos.y, pos.z);
        }
        else if (transform.position.x > boundary)
        {
            transform.position = new Vector3(boundary, pos.y, pos.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

    }
}
