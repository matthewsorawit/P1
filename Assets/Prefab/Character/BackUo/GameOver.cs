using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
