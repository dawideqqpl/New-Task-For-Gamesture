using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Skrypty : MonoBehaviour
{

    public Image porscheImage;
    public Sprite porscheOption1;
    public Sprite porscheOption2;
    public Sprite porscheOption3;
    public float timerPorsche;
    public bool timerPorscheBool;
    public int porscheOptionInt;
    public Image task1Background;
    public Image task2Background;
    public int sound1;
    public int sound2;
    public int sound3;
    public Image soundImage1;
    public Image soundImage2;
    public Image soundImage3;
    public Image soundImageRandom;
    public int soundRandom;
    public int randomOfSound;
    public AudioSource soundPorshe;
    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3;
    public bool soundBool;
    public float soundTimer;

    void Start()
    {
        timerPorscheBool = true;
        porscheOptionInt = 1;
        soundImage1.color = new Color(1, 1, 1, 0.25f);
        soundImage2.color = new Color(1, 1, 1, 0.25f);
        soundImage3.color = new Color(1, 1, 1, 0.25f);
        soundImageRandom.color = new Color(1, 1, 1, 0.25f);
    }

    // Update is called once per frame
    void Update()
    {

        if (soundBool)
        {
            soundTimer += Time.deltaTime;

            if(soundTimer >= 5)
            {
                soundBool = false;
                soundTimer = 0;
                soundPorshe.Stop();
            }
        }

      

        if(soundRandom == 1)
        {
            soundImageRandom.color = new Color(1, 1, 1, 1);
            soundImage1.color = new Color(1, 1, 1, 0.25f);
            soundImage2.color = new Color(1, 1, 1, 0.25f);
            soundImage3.color = new Color(1, 1, 1, 0.25f);
          
          
        }

        if (sound1 == 1)
        {
            soundImageRandom.color = new Color(1, 1, 1, 0.25F);
            soundImage1.color = new Color(1, 1, 1, 1f);
            soundImage2.color = new Color(1, 1, 1, 0.25f);
            soundImage3.color = new Color(1, 1, 1, 0.25f);
            soundPorshe.clip = clip1;
        }
        if (sound2 == 1)
        {
            soundImageRandom.color = new Color(1, 1, 1, 0.25F);
            soundImage2.color = new Color(1, 1, 1, 1f);
            soundImage1.color = new Color(1, 1, 1, 0.25f);
            soundImage3.color = new Color(1, 1, 1, 0.25f);
            soundPorshe.clip = clip2;
        }
        if (sound3 == 1)
        {
            soundImageRandom.color = new Color(1, 1, 1, 0.25F);
            soundImage3.color = new Color(1, 1, 1, 1f);
            soundImage1.color = new Color(1, 1, 1, 0.25f);
            soundImage2.color = new Color(1, 1, 1, 0.25f);
            soundPorshe.clip = clip3;
        }
        if (task1Background.color.a == 0)
        {
            task1Background.raycastTarget = false;
        }
        if (task1Background.color.a > 0.0)
        {
            task1Background.raycastTarget = true;
        }

        if (task2Background.color.a == 0)
        {
            task2Background.raycastTarget = false;
        }
        if (task2Background.color.a > 0.0)
        {
            task2Background.raycastTarget = true;
        }
        if (timerPorscheBool)
        {
            timerPorsche += Time.deltaTime;

            if(timerPorsche >= 2)
            {
                timerPorsche = 0;

                porscheOptionInt += 1;
            }
        }

        if(porscheOptionInt >= 4)
        {
            porscheOptionInt = 1;
        }

        switch(porscheOptionInt)
        {
            case 1:
                porscheImage.sprite = porscheOption1;
                break;

            case 2:
                porscheImage.sprite = porscheOption2;
                break;

            case 3:
                porscheImage.sprite = porscheOption3;
                break;


                
        }
    }

    public void googlePlay()
    {
        Application.OpenURL("https://play.google.com/store/apps/developer?id=Dawid+Zieli%C5%84ski");
    }

    public void playSound()
    {
        if (soundRandom == 1)
        {


            randomOfSound = Random.Range(1, 4);
            if (randomOfSound == 1)
            {
                soundPorshe.clip = clip1;
            }
            if (randomOfSound == 2)
            {
                soundPorshe.clip = clip2;
            }
            if (randomOfSound == 3)
            {
                soundPorshe.clip = clip3;
            }
        }
        soundPorshe.Play();
        soundTimer = 0;
        soundBool = true;
       
    }
    public void chooseOption1()
    {
        sound1 = 1;
        sound2 = 0;
        sound3 = 0;
        soundRandom = 0;
    }

    public void chooseOption2()
    {
        sound2 = 1;
        sound1 = 0;
        sound3 = 0;
        soundRandom = 0;
    }
    public void chooseOption3()
    {
        sound3 = 1;
        sound1 = 0;
        sound2 = 0;
        soundRandom = 0;
    }

    public void chooseRandom()
    {
        sound3 = 0;
        sound1 = 0;
        sound2 = 0;
        soundRandom = 1;
    }
}
