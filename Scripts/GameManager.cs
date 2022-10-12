using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using TMPro;


public class GameManager : MonoBehaviour
{
    public static GameManager gm;
    public int highScore1 = 0 ;
    public TMP_Text ScoreText1;
    
    void Awake()
    {
        if(gm == null)
            gm = this;
        else
            GameObject.Destroy(this);
    }

    public void gamestart ()
    {
        SceneManager.LoadScene("SampleScene");
    }
    void Start()
    {
        LoadPlayerScore();
        ScoreText1.text = highScore1.ToString();
    }


    [System.Serializable]
    class HighScore
    {
        public int Score;
    }

    public void SaveHihgScore()
    {
        HighScore PlayerScore = new HighScore ();

        PlayerScore.Score = highScore1;

        string json = JsonUtility.ToJson(PlayerScore);
        File.WriteAllText(Application.persistentDataPath +"/bubble.json",json);
    }

    public void LoadPlayerScore()
    {
        string path = Application.persistentDataPath + "/bubble.json";
        if(File.Exists(path))
        { 
            string json = File.ReadAllText(path);
            HighScore PlayerScore = JsonUtility.FromJson<HighScore>(json);
            highScore1 = PlayerScore.Score;
        }
    }

}
