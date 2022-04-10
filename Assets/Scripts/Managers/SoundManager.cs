using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : LocalManager<SoundManager>
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip tongueShoot;
    [SerializeField] AudioClip jumpSound;
    [SerializeField] AudioClip moucheDeathSound;
    [SerializeField] AudioClip powerGet;
    [SerializeField] AudioClip deathSound;
    [SerializeField] AudioClip powerUpEndAlarm;

    private void PlaySound(AudioClip clip, float volume)
    {
        audioSource.PlayOneShot(clip, volume);
    }

    public void TongueShootSound()
    {
        PlaySound(tongueShoot, 1f);
    }

    public void JumpSound()
    {
        PlaySound(jumpSound, 1f);
    }

    public void MoucheDeathSound()
    {
        PlaySound(moucheDeathSound, 1f);
    }

    public void PowerGet()
    {
        PlaySound(powerGet, 1f);
    }

    public void DeathSound()
    {
        PlaySound(deathSound, 1f);
    }

    public void PowerUpEndAlarm()
    {
        PlaySound(powerUpEndAlarm, 1f);
    }

}
