using UnityEngine;
using System.Collections;

/*
 * 3. Sound 관련 옵션 저장
 * 변수
 * bool bgm
 * bool effect
 * 함수
 */
public class SoundManager : MonoBehaviour {
    static AudioSource audBGM;
    static AudioSource audBGM2;
    static AudioSource audEffect_button;
    static AudioSource audEffect_menu;
    static AudioSource audEffect_assemble;
    static AudioSource audEffect4;
    static AudioSource audEffect5;
    static AudioSource audEffect6;


    public AudioClip bgm1;
    public AudioClip bgm2;
    public AudioClip button;
    public AudioClip menu;
    public AudioClip assemble;
    public AudioClip effect4;
    public AudioClip effect5;
    public AudioClip effect6;


    static bool bgm = true;
    static bool sound = true;

    void Awake()
    {
        DontDestroyOnLoad(this);
    }
    // Use this for initialization
    void Start () {
        // 오디오 소스 추가 ( 오디오 재생 도구 )
        audBGM = gameObject.AddComponent<AudioSource>();
        audBGM2 = gameObject.AddComponent<AudioSource>();

        audEffect_button = gameObject.AddComponent<AudioSource>();
        audEffect_menu = gameObject.AddComponent<AudioSource>();
        audEffect_assemble = gameObject.AddComponent<AudioSource>();
        audEffect4 = gameObject.AddComponent<AudioSource>();
        audEffect5 = gameObject.AddComponent<AudioSource>();
        audEffect6 = gameObject.AddComponent<AudioSource>();


        // bgm 등록
        audBGM.clip = bgm1;
        audBGM.loop = true;
        audBGM.playOnAwake = false;
        audBGM.rolloffMode = AudioRolloffMode.Linear;

        audBGM2.clip = bgm2;
        audBGM2.loop = true;
        audBGM2.playOnAwake = false;
        audBGM2.rolloffMode = AudioRolloffMode.Linear;

        // 효과음 등록
        audEffect_button.clip = button;
        audEffect_button.playOnAwake = false;
        audEffect_button.rolloffMode = AudioRolloffMode.Linear;

        audEffect_menu.clip = menu;
        audEffect_menu.playOnAwake = false;
        audEffect_menu.rolloffMode = AudioRolloffMode.Linear;

        audEffect_assemble.clip = assemble;
        audEffect_assemble.playOnAwake = false;
        audEffect_assemble.rolloffMode = AudioRolloffMode.Linear;

        audEffect4.clip = effect4;
        audEffect4.playOnAwake = false;
        audEffect4.rolloffMode = AudioRolloffMode.Linear;

        audEffect5.clip = effect5;
        audEffect5.playOnAwake = false;
        audEffect5.rolloffMode = AudioRolloffMode.Linear;

        audEffect6.clip = effect6;
        audEffect6.playOnAwake = false;
        audEffect6.rolloffMode = AudioRolloffMode.Linear;
    }

    // Update is called once per frame
    void Update () {
       
	}

    public static void ButtonSound()
    {
        if (sound) PlaySound(audEffect_button);
    }

    public static void MenuSound()
    {
        if(sound) PlaySound(audEffect_menu);
    }

    public static void AssembleSound()
    {
        if (sound) PlaySound(audEffect_assemble);
    }

    // 등록된 사운드 제어
    static void PlayBGM(AudioSource aud)
    {
        aud.Play();
    }
    static void StopBGM(AudioSource aud)
    {
        aud.Stop();
    }
    static void PlaySound( AudioSource aud)
    {
        aud.Play();
    }
   

    // 3. Sound 옵션 관련 함수
    public static void ToggleBGM()
    {
        if (bgm == true) bgm = false;
        else bgm = true;
        ButtonSound();
    }
    public static bool IsOnBGM()
    {
        return bgm;
    }
    public static void ToggleEffect()
    {
        if (sound == true) sound = false;
        else sound = true;
        ButtonSound();
    }
    public static bool IsOnEffect()
    {
        return sound;
    }
}
