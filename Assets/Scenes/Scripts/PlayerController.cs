using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    private float speed = 20.0f;
    private float turnspeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Mover o veículo para a frente
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rodar o veículo para os lados
        transform.Rotate(Vector3.up, turnspeed * horizontalInput * Time.deltaTime);

    }
}
