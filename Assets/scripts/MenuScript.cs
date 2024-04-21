using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject backround;
    public GameObject loadingPlane;
    public GameObject loadingWheel;
    public GameObject loadingLeverOne;
    public GameObject loadingLeverTwo;
    public GameObject loadingLeverThree;
    public GameObject loadingScrew;
    public GameObject loadingShovel;
    public GameObject loadingPulley;
    public GameObject quitButton;
    public GameObject dropDown;
    public GameObject generalLever;

    public void Start()
    {
        loadingPlane.SetActive(false);
        loadingWheel.SetActive(false);
        loadingLeverOne.SetActive(false);
        loadingLeverTwo.SetActive(false);
        loadingLeverThree.SetActive(false);
        loadingScrew.SetActive(false);
        loadingShovel.SetActive(false);
        loadingPulley.SetActive(false);
        dropDown.SetActive(false);
    }
    IEnumerator Waiter(string loadScene)
    {
        //Wait for 4 seconds
        quitButton.SetActive(false);
        dropDown.SetActive(false);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(loadScene);
    }
    public void InclinedPlane()
    {
        backround.SetActive(false);
        loadingPlane.SetActive(true);
        StartCoroutine(Waiter("InclinedPlaneScene"));
    }
    public void Bike()
    {
        backround.SetActive(false);
        loadingWheel.SetActive(true);
        StartCoroutine(Waiter("BikeScene"));
    }
    public void Screw()
    {
        backround.SetActive(false);
        loadingScrew.SetActive(true);
        StartCoroutine(Waiter("ScrewScene"));
    }

    public void Back()
    {
        dropDown.SetActive(false);
        generalLever.SetActive(true);
    }
    public void DropDownMenu()
    {
        generalLever.SetActive(false);
        dropDown.SetActive(true);
    }
    public void LeverOne()
    {
        backround.SetActive(false);
        loadingLeverOne.SetActive(true);
        StartCoroutine(Waiter("CrowbarScene"));
    }
    public void LeverTwo()
    {
        backround.SetActive(false);
        loadingLeverTwo.SetActive(true);
        StartCoroutine(Waiter("DoorScene"));
    }
    public void LeverThree()
    {
        backround.SetActive(false);
        loadingLeverThree.SetActive(true);
        StartCoroutine(Waiter("BroomScene"));
    }
    public void Pulley()
    {
        backround.SetActive(false);
        loadingPulley.SetActive(true);
        StartCoroutine(Waiter("PulleyScene"));
    }
    public void Wedge()
    {
        backround.SetActive(false);
        loadingShovel.SetActive(true);
        StartCoroutine(Waiter("ShovelScene"));
    }
    public void Quit()
    {
        Application.Quit();
    }
}
