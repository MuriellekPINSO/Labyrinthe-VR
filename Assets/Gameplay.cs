using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEditor;
public class Gameplay : MonoBehaviour
{
    public int[] password;
    public int findBomb=0;
    public Text found;
    public Text help;
    public AudioClip collectSnd;
    public AudioClip ticTac;
    public GameObject objBomb;

    void Start()
    {
        password = GeneratePassord();
    }

    private void OnTriggerEnter(Collider other)
    {
       

        if (other.CompareTag("Bomb"))
        {
            
                GetComponent<AudioSource>().PlayOneShot(collectSnd);
                other.gameObject.SetActive(false);
                findBomb++;
            
            
        }
    }

    

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Start"))
        {
            help.gameObject.SetActive(false);
        }
    }
    int[] GeneratePassord()
    {
        int[] arr= new int[4];

        for (int i = 0; i < 4; i++) 
        {
            arr[i] = Random.Range(0, 9);
        }

        return arr;
    }
}

    
