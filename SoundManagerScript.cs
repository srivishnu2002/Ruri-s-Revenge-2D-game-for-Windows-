using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip FireSound, JumpSound, PlayerDeath, SuperOrb, Collect, HitSound, TrueOrb, ExtraLife, Bounce;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        FireSound = Resources.Load<AudioClip>("fire");
        JumpSound = Resources.Load<AudioClip>("jump");
        PlayerDeath = Resources.Load<AudioClip>("playerdie");
        SuperOrb = Resources.Load<AudioClip>("orb");
        Collect = Resources.Load<AudioClip>("collect");
        HitSound = Resources.Load<AudioClip>("hitsolid");
        TrueOrb = Resources.Load<AudioClip>("trueorb");
        ExtraLife = Resources.Load<AudioClip>("extralife");
        Bounce = Resources.Load<AudioClip>("bounce");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "fire":
                audioSrc.PlayOneShot(FireSound);
                break;

            case "jump":
                audioSrc.PlayOneShot(JumpSound);
                break;

            case "playerdie":
                audioSrc.PlayOneShot(PlayerDeath);
                break;

            case "orb":
                audioSrc.PlayOneShot(SuperOrb);
                break;

            case "collect":
                audioSrc.PlayOneShot(Collect);
                break;

            case "hitsolid":
                audioSrc.PlayOneShot(HitSound);
                break;

            case "trueorb":
                audioSrc.PlayOneShot(TrueOrb);
                break;

            case "extralife":
                audioSrc.PlayOneShot(ExtraLife);
                break;

            case "bounce":
                audioSrc.PlayOneShot(Bounce);
                break;
        }
    }
}
