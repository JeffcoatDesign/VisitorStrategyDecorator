using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void LoadTen() {
        SceneManager.LoadScene("Chapter10");
    }
    public void LoadEleven() {
        SceneManager.LoadScene("Chapter11");
    }
    public void LoadTwelve() {
        SceneManager.LoadScene("Chapter12");
    }
}
