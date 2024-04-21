using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ARScreenButtonsScript : MonoBehaviour
{
    public GameObject tapButton;
    public GameObject formulaButton;
    public GameObject explanationPage;
    public GameObject placeText;//"tap to place object" text
    public GameObject formulaText;//"click for formula" text
    public Animator mAnimator;
    public string animationName;
    public string quizName;


    // Start is called before the first frame update
    public void Start()
    {
        formulaButton.SetActive(false);
        explanationPage.SetActive(false);
        formulaText.SetActive(false);
    }
    public void Home()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ShowFormula()
    {
        tapButton.SetActive(false);
        formulaButton.SetActive(true);
        placeText.SetActive(false);
        formulaText.SetActive(true);
    }

    public void ShowExplanation()//formula button clicked
    {
        formulaButton.SetActive(false);
        explanationPage.SetActive(true);
        formulaText.SetActive(false);
    }

    public void CloseExplanation()
    {
        SceneManager.LoadScene(quizName);
    }

    public void PlayAnimation()
    {
        mAnimator.Play(animationName);
    }
}
