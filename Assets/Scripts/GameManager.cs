using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;

    public int P1Life;
    public int P2Life;

    public GameObject p1Wins;
    public GameObject p2Wins;
    public GameObject[] p1Sticks;
    public GameObject[] p2Sticks;

    public AudioSource hurtSound;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(P1Life <= 0)
        {
        player1.SetActive(false);
        p1Wins.SetActive(true);
        //Time.timeScale = 0;
        }

        if(P2Life <= 0)
        {
        player2.SetActive(false);
        p2Wins.SetActive(true);
         //Time.timeScale = 0;
        }
    }
    public void HurtP1()
    {
        P1Life -= 1;
        for(int i =0; i< p1Sticks.Length; i++)
        {
            if(P1Life > i)
            {
                p1Sticks[i].SetActive(true);
            }else{
                p1Sticks[i].SetActive(false);
            }
        }
        hurtSound.Play();
    }
    public void HurtP2()
    {
        P2Life -= 1;

        for(int i =0; i< p2Sticks.Length; i++)
        {
            if(P2Life > i)
            {
                p2Sticks[i].SetActive(true);
            }else{
                p2Sticks[i].SetActive(false);
            }
        }
        hurtSound.Play();
    }
}
