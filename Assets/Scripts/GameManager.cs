using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject rain;
    public Text timeText;
    public GameObject panel;

    public static GameManager I;

    public Animator anim;
    public GameObject balloon;

    void Awake()
    {
        I = this;
    }


    float limit = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeRain", 0.0f, 0.5f);
        
    }

    void makeRain()
    {
        Instantiate(rain);
    }


    // Update is called once per frame
    void Update()
    {
        limit += Time.deltaTime;
        timeText.text = limit.ToString("N2");

     
    }

    public void GameOver()
    {
        anim.SetBool("isDie", true);
        panel.SetActive(true);
        Invoke("dead", 0.5f);
    }

    void dead()
    {
        Time.timeScale = 0.0f;
        Destroy(balloon);
    }

}
