using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController1 : MonoBehaviour
{
    public AudioSource audioSourceMusicaDeFundo1;
    public AudioClip[] musicasDeFundo1;

    void Start()
    {
        AudioClip musicaDeFundoDessaFase1 = musicasDeFundo1[0];
        audioSourceMusicaDeFundo1.clip = musicaDeFundoDessaFase1;
        audioSourceMusicaDeFundo1.loop = true;
        audioSourceMusicaDeFundo1.Play();
    }

    // Método para alternar a música
    public void ToggleMusic()
    {
        // Se a música está tocando, pause. Se não, retome a reprodução.
        if (audioSourceMusicaDeFundo1.isPlaying)
        {
            audioSourceMusicaDeFundo1.Pause();
        }
        else
        {
            audioSourceMusicaDeFundo1.Play();
        }
    }
}

