using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public AudioSource audioSource; // Source audio attachée à l’objet 3D
    public Transform player; // Référence au joueur
    public float activationDistance = 5f; // Distance d’activation du son

    private bool isPlaying = false; // Permet de savoir si le son est en train de jouer

    void Update()
    {
        if (player == null || audioSource == null)
            return; // Sécurité pour éviter des erreurs

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
