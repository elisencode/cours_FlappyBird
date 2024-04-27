using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpaceToReplay : MonoBehaviour
{
    Text txt;

    private void Start()
    {
        txt = GetComponent<Text>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(GameObject.Find("FlappyBird").GetComponent<BirdController>().BirdIsDead)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                
        }
    }
}
