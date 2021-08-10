using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartOver : MonoBehaviour
{
    public GameObject HomePanel, Settings, HelpPanel;
    public void Back()
    {
        HelpPanel.SetActive(false);
        HomePanel.SetActive(true);
        Settings.SetActive(false);
    }
    // Start is called before the first frame update
    public void StartGame()
    {

        SceneManager.LoadScene(1);
    }

    public void HelpGame()
    {

        HelpPanel.SetActive(true);
    }
    public void SettingsGame()
    {

        Settings.SetActive(true);
        

    }
    public void settingsback()
    {
        HelpPanel.SetActive(false);
      
        HomePanel.SetActive(true);
        Settings.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
