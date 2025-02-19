using UnityEngine;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.Collections;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Victory : MonoBehaviour
{
    public Text leftTextUI;

    public float basechrono = 180;
    float chrono;
    /*public float chrono1 = 60;
    public float chrono2 = 90;
    public float chrono3 = 120;*/
    bool active = true;
    //public Text sc;
    public Text gameOver;
    public Text finish;
    public GameObject player;
    public Text help;
    bool isPaused = false;

    void Start()
    {
        chrono= basechrono;
    }
    void Update()
    {

        if (active)
        {

            /*if (isPaused) 
                return; 
            else
            {*/
                if ((chrono >= 0))
                {
                     chrono -= Time.deltaTime;
                     leftTextUI.text = Mathf.Round(chrono).ToString() + " s";
                }
                else { 
                     active = false;
                     gameOver.gameObject.SetActive(true);
                    StartCoroutine(waitScene(0));
                }
            //}
            
        }

    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Finish"))
        {
            finish.gameObject.SetActive(true);
            StartCoroutine(waitScene(0));
        }
    }



    public void quitgame()
    {
        Debug.Log("Quitter le jeu !"); // Affiche un message dans la console
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif
    }


    IEnumerator waitScene(int scene)
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(scene);
    }

}
