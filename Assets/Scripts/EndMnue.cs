using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMnue : MonoBehaviour
{
    public void Quit()
    {
    Application.Quit();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        CompleyeLevel();
    }
    private void CompleyeLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
