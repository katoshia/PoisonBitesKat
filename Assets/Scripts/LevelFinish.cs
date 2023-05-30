using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFinish : MonoBehaviour
{
    private AudioSource levelFinish;
    private Animator anim;
    private bool levelCompleted = false;

    // Start is called before the first frame update
    private void Start()
    {
        levelFinish = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name=="Player" && !levelCompleted)
        {
            levelCompleted = true;
            levelFinish.Play();
            Invoke("CompleteLevel", 1f);
            //CompleteLevel();
        }

    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
