using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    private string collName;
    // total score
    private int score=0;
    // fruit scores
    private int strawberryScore = 5;
    private int cherryScore = 10;
    private int appleScore = 5;
    private int bananaScore = 10;
    private int kiwiScore = 15;
    private int melonScore = 15;
    private int orangeScore = 20;
    private int pineappleScore = 25;

    // fruit count
    private int strawberryCount = 0;
    private int cherryCount = 0;
    private int appleCount = 0;
    private int bananaCount = 0;
    private int kiwiCount = 0;
    private int melonCount = 0;
    private int orangeCount = 0;
    private int pineappleCount = 0;


    // poison fruit count
    private int poisonStrawberryCount = 0;
    private int poisonCherryCount = 0;
    private int poisonApplecount = 0;
    private int poisonBananaCount = 0;
    private int poisonKiwiCount = 0;
    private int poisonMelonCount = 0;
    private int poisonOrangeCount = 0;
    private int poisonPineappleCount = 0;

    // object fields;
    private Animator anim;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private AudioSource collectSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collName = collision.gameObject.name;
        if (collision.gameObject.CompareTag("Fruit"))
        {
            collectSoundEffect.Play();
            anim = collision.gameObject.GetComponent<Animator>();
            anim.SetBool("isCollected", true);
            if (collName == "Strawberry")
            {
                strawberryCount++;
                score += strawberryScore;
            }
            else if (collName == "Cherry")
            {cherryCount++; score += cherryScore; }
            else if (collName == "Apple")
            { appleCount++; score += appleScore; }
            else if (collName == "Banana")
            { bananaCount++; score += bananaScore; }
            else if (collName == "Kiwi")
            { kiwiCount++; score += kiwiScore; }
            else if (collName == "Melon")
            { melonCount++; score += melonScore; }
            else if (collName == "Orange")
            { orangeCount++; score += orangeScore; }
            else if (collName == "Pineapple")
            { pineappleCount++; score += pineappleScore; }
            scoreText.text = "Score: " + score;
        }

        else if (collision.gameObject.CompareTag("PoisonFruit"))
        {
            collectSoundEffect.Play();
            anim = collision.gameObject.GetComponent<Animator>();
            anim.SetBool("isCollected", true);
            // poison strawberry
            if (collName == "PoisonStrawberry" && poisonStrawberryCount < 6)
            { poisonStrawberryCount++; score -= strawberryScore; }
            else if (collName == "PoisonStrawberry" && poisonStrawberryCount >= 6)
            { score += strawberryScore; }

            // poison cherry
            else if (collName == "PoisonCherry" && poisonCherryCount < 6)
            { poisonCherryCount++; score -= cherryScore; }
            else if (collName == "PoisonCherry" && poisonCherryCount >= 6)
            { poisonCherryCount++; score += cherryScore; }

            // poison apple
            else if (collName == "PoisonApple" && poisonApplecount < 6)
            { poisonApplecount++; score -= appleScore; }
            else if (collName == "PoisonApple" && poisonApplecount >= 6)
            { poisonApplecount++; score += appleScore; }

            // poison banana
            else if (collName == "PoisonBanana" && poisonBananaCount < 6)
            { poisonBananaCount++; score -= bananaScore; }
            else if (collName == "PoisonBanana" && poisonBananaCount >= 6)
            { poisonBananaCount++; score += bananaScore; }
            // poison kiwi
            else if (collName == "PoisonKiwi" && poisonKiwiCount < 6)
            { poisonKiwiCount++; score -= kiwiScore; }
            else if (collName == "PoisonKiwi" && poisonKiwiCount >= 6)
            { poisonKiwiCount++; score += kiwiScore; }

            // poison melon
            else if (collName == "PoisonMelon" && poisonMelonCount < 6)
            { poisonMelonCount++; score -= melonScore; }
            else if (collName == "PoisonMelon" && poisonMelonCount >= 6)
            { poisonMelonCount++; score += melonScore; }

            // poison orange
            else if (collName == "PoisonOrange" && poisonOrangeCount < 6)
            { poisonOrangeCount++; score -= orangeScore; }
            else if (collName == "PoisonOrange" && poisonOrangeCount >= 6)
            { poisonOrangeCount++; score += orangeScore; }

            // poison pineapple
            else if (collName == "PoisonPineapple" && poisonPineappleCount < 6)
            { poisonPineappleCount++; score -= pineappleScore; }
            else if (collName == "PoisonPineapple" && poisonPineappleCount >= 6)
            { poisonPineappleCount++; score += pineappleScore; }

            // update score
            scoreText.text = "Score: " + score;
        }
    }
}
