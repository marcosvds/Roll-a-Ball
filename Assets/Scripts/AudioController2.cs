using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController2 : MonoBehaviour
{
    public AudioSource audioSourceMusicaDeFundo2;
    public AudioSource audioSourceSoundCoin;
    public AudioClip[] musicasDeFundo2;

    // Start is called before the first frame update
    void Start()
    {
        int IndexDaMusicaDeFundo2 = Random.Range(0, musicasDeFundo2.Length);
        AudioClip musicaDeFundoDessaFase2 = musicasDeFundo2[IndexDaMusicaDeFundo2];
        audioSourceMusicaDeFundo2.clip = musicaDeFundoDessaFase2;
        audioSourceMusicaDeFundo2.loop = true;
        audioSourceMusicaDeFundo2.Play();
    }

    public void ToqueSoundCoin(AudioClip clip)
    {
        audioSourceSoundCoin.PlayOneShot(clip);
    }
}
