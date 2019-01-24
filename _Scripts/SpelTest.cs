using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpelTest : MonoBehaviour
{
    public GameObject options;
    public GameObject mainPause; //objekt för pausmenyerna
    public GameObject pauseMenu;

    private bool paused = false; //bool för om spelet är pausat eller ej
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false); //ser till att spelet inte är pausat när man börjar
        mainPause.SetActive(false);
        options.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape) && paused == false) //om man klickar på escape och spelet inte är pausat
        {
            PauseGame();
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && paused == true) //om man klickar på escape och spelet är pausat
        {
            Continue();
        }
    }
    public void PauseGame() //Pausar spelet
    {
        paused = true; //visar att tiden är pausad
        pauseMenu.SetActive(true); //sätter på pausmenyn
        mainPause.SetActive(true);
        Time.timeScale = 0f; //tiden stannar
    }
    public void Continue()
    {
        Time.timeScale = 1f; //sätter på tiden till normal fart
        pauseMenu.SetActive(false); //stänger av hela pausmenyn
        mainPause.SetActive(false);
        options.SetActive(false);
        paused = false; //visar att spelet inte längre är pausat
    }
    public void Options() //för att gå in i optionsmenyn från pausmenyn
    {
        options.SetActive(true); //sätter på options och stänger av huvudpausmenyn
        mainPause.SetActive(false);
    }
    public void MainPaused() //när man går in i huvudpausmenyn från optionsmenyn
    {
        mainPause.SetActive(true); //stänger av optionsmenyn och sätter på huvudpausmenyn
        options.SetActive(false);
    }
}
