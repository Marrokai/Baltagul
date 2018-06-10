using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class SoundLevels : MonoBehaviour {
    public AudioMixer MasterVolume;
    public AudioMixer MusicVolume;
    public AudioMixer DialogueVolume;
    public AudioMixer EnvironmentVolume;
    public void SetMasterVolume(float MasterSoundLevel)
    {
        MasterVolume.SetFloat("MasterVolume",MasterSoundLevel);
    }
    public void SetMusicVolume(float MusicSoundLevel)
    {
        MusicVolume.SetFloat("MusicVolume", MusicSoundLevel);
    }
    public void SetDialogueVolume(float DialogueSoundLevel)
    {
        DialogueVolume.SetFloat("DialogueVolume", DialogueSoundLevel);
    }
    public void SetEnvironmentVolume(float EnvironmentSoundLevel)
    {
        EnvironmentVolume.SetFloat("EnvironmentVolume", EnvironmentSoundLevel);
    }
}
