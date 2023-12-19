using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CountdownTime : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float remainingTime;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {

        if (remainingTime > 0){
            remainingTime -= Time.deltaTime;

        }
        else{
            SceneManager.LoadScene("LoseScene");

        }
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
