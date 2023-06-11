using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    public GameObject[] menu;

    public GameObject mainMenu;
    public GameObject einstellungen;
    public GameObject spielStarten;

    void Start()
    {
        Auswahl(mainMenu);
    }
    
    public void SpielStarten()
    {
        SceneManager.LoadScene(1);
    }

    public void Einstellungen()
    {
        Auswahl(einstellungen);
    }

    public void SpielBeenden()
    {
        Application.Quit();
    }

    public void Back()
    {
        Auswahl(mainMenu);
    }
    
    
    
    void Auswahl(GameObject show)
    {
        foreach (GameObject o in menu)
        {
            if(o == show) o.SetActive(true);
            else o.SetActive(false);
        }
    }

}
