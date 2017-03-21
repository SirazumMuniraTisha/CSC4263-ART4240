using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameWinAndGameOver : MonoBehaviour {

    public float timeIncrease = 2;
    public bool timeElapsed = false;
    public Text winText;
    public Text finishText;
    public float timeLeft = 30.0f;
    public int itemsRemaining;

    void Start () {
        GameObject[] items = GameObject.FindGameObjectsWithTag("Enemy");
        itemsRemaining = items.Length;
        winText = GameObject.FindGameObjectWithTag("winText").GetComponent<Text>();
        finishText = GameObject.FindGameObjectWithTag("finishText").GetComponent<Text>();

    }

    float currCountdownValue;
    public IEnumerator StartCountdown(float countdownValue = 10)
    {
        currCountdownValue = countdownValue;
        while (currCountdownValue > 0)
        {
            Debug.Log("Countdown: " + currCountdownValue);
            yield return new WaitForSeconds(1.0f);
            currCountdownValue--;
        }
    }


    void Update () {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            if (itemsRemaining == 0)
            {
                //you win
                winText.text = "Congratulations! You Win.";
                winText.gameObject.SetActive(true);
                //Won this level: EndOfThisLevel()
            }
            else
            {
                //Game over
                finishText.text = "Sorry, the game is over.";
                finishText.gameObject.SetActive(true);
                //Lost this level: EndOfThisLevel()
            }
        }
        else if (itemsRemaining == 0)
        {
            //you win
            winText.text = "Congratulations! You Win.";
            winText.gameObject.SetActive(true);
            //Won this level: EndOfThisLevel()
        }
    }


}
