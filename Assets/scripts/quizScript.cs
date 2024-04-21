using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class quizScript : MonoBehaviour
{
    public GameObject loadScreen;
    public GameObject quizScreen;
    public GameObject aScreen;
    public GameObject bScreen;
    public GameObject cScreen;
    public GameObject buttons;
    public GameObject blocker;//so player can't click anything after choosing an answer
  

    // Start is called before the first frame update
    void Start()
    {
        quizScreen.SetActive(false);
        aScreen.SetActive(false);
        bScreen.SetActive(false);
        cScreen.SetActive(false);
        buttons.SetActive(false);
        blocker.SetActive(false);

        StartCoroutine(FakeLoad());
    }
    IEnumerator BackToMenu()
    {
        //Wait for 4 seconds
        blocker.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("MainMenu");
    }
    IEnumerator FakeLoad()
    {
        //Wait for 4 seconds
        yield return new WaitForSeconds(1);
        loadScreen.SetActive(false);
        quizScreen.SetActive(true);
        buttons.SetActive(true);
    }
    public void ChoiceA()
    {
        quizScreen.SetActive(false);
        aScreen.SetActive(true);
        StartCoroutine(BackToMenu());
    }

    public void ChoiceB()
    {
        quizScreen.SetActive(false);
        bScreen.SetActive(true);
        StartCoroutine(BackToMenu());
    }

    public void ChoiceC()
    {
        quizScreen.SetActive(false);
        cScreen.SetActive(true);
        StartCoroutine(BackToMenu());
    }
}
