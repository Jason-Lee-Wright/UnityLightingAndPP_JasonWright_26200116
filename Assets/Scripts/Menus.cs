using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && SceneManager.GetActiveScene() != SceneManager.GetSceneByBuildIndex(0))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void DayB()
    {
        SceneManager.LoadScene("Day");
    }

    public void NightB()
    {
        SceneManager.LoadScene("Night");
    }

    public void LeaveB()
    {
        Application.Quit();
    }
}
