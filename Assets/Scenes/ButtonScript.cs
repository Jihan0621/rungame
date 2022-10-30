using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void Title() {SceneManager.LoadScene(0);
}
    public void Game()  {SceneManager.LoadScene(1);}
}
