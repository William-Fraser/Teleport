using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGetAxisRaw : MonoBehaviour
{
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        this.transform.Translate(x * speed * Time.deltaTime, 0.0f, y * speed * Time.deltaTime);
        if (Input.GetKeyDown("space")) {

            this.transform.Translate(Vector3.up);
        }
    }
}
