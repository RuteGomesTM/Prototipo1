using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    public float speed = 5.0f;
    void Update()
    {
        // Mover o ve�culo para a frente
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
