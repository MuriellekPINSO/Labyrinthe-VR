using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public AudioSource audioSource; // Source audio attach�e � l�objet 3D
    public Transform player; // R�f�rence au joueur
    public float activationDistance = 5f; // Distance d�activation du son

    private bool isPlaying = false; // Permet de savoir si le son est en train de jouer

    void Update()
    {
        if (player == null || audioSource == null)
            return; // S�curit� pour �viter des erreurs

        float distance = Vector3.Distance(transform.position, player.position);

        if (distance <= activationDistance && !isPlaying)
        {
            audioSource.Play();
            isPlaying = true;
        }
        else if (distance > activationDistance && isPlaying)
        {
            audioSource.Stop();
            isPlaying = false;
        }
    }
}
