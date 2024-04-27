using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]


public class BirdDead : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pipes"))
        {
            GetComponent<AudioSource>().Play();
            GetComponent<BoxCollider2D>().enabled = false;

            GameObject[] GoPipes = GameObject.FindGameObjectsWithTag("Pipes");

            foreach (GameObject g in GoPipes)
            {
                if(g.GetComponent<Rigidbody2D>() !=null)
                g.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            }

            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<BirdController>().BirdIsDead = true;

            GameObject.Find("SpawnerManager").GetComponent<SpawnerManager>().StopSpawn();

            GameManager Gm = GameObject.Find("Canvas").GetComponent<GameManager>();

            if (Gm.Score > Gm.BestScore)
            {
                PlayerPrefs.SetInt("BestScore", Gm.Score);
                Gm.BestScore = Gm.Score;
            }

            if(GameObject.Find("TxtReplay")!=null)
            GameObject.Find("TxtReplay").GetComponent<Text>().enabled = true;

            
        }
    }
}
