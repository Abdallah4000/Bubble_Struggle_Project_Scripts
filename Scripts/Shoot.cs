using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shoot : MonoBehaviour
{
    public static Shoot instanc;
    public bool IsShooted;
    public int score = 0;
    public TMP_Text ScoreText;
    [SerializeField] float speed = 2f;
    [SerializeField] Transform player;

    private Vector3 limit = new Vector3(1f,3f,1f);

     void Awake()
    {
        if(instanc == null)
            instanc = this;
        else
            GameObject.Destroy(this);
    }
    void Start()
    {
        IsShooted = false; 
        score = 0;
    }

    public void ScoreAdd()
    {
        score++;
        ScoreText.text = score.ToString();
        if(score > GameManager.gm.highScore1)
        {
            GameManager.gm.highScore1 = score;
            GameManager.gm.SaveHihgScore();
        }
    }

    void Update()
    {

        if(IsShooted)
        {

            transform.localScale = transform.localScale + Vector3.up * Time.deltaTime * speed;

        }
        else{

            transform.position = player.position;
            transform.localScale = new Vector3(1f,0f,1f);

        }

        
    }
}
