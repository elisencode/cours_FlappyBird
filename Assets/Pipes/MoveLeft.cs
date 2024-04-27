using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField]
    int speed = 5;
    [SerializeField]
    float range = 2f;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;

        transform.position = new Vector2(transform.position.x,transform.position.y *  range * Random.value);
    }

    public void DestroyPipes()
    {
        Destroy(gameObject);
    }

    
}
