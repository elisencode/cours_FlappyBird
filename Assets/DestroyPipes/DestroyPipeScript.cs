using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestroyPipeScript : MonoBehaviour
{   

    private void OnTriggerEnter2D(Collider2D collision)
    {
         Destroy(collision.gameObject);
        GameObject.Find("Canvas").GetComponent<GameManager>().AddOnePoint();
    }
}
