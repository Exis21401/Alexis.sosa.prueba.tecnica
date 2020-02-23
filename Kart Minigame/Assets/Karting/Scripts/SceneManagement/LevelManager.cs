using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void OpenLevel(string level) // Función genérica para poder abrir cualquier escena mediante un string.
	{
		SceneManager.LoadScene(level);
	}

	public void QuitGame() // Esta función cerrará el juego desde donde se le llame.
	{
		Application.Quit();
	}
}
