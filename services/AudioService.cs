using System;
using System.Collections;
using System.Collections.Generic;
using Event;
using Godot;


namespace Service
{
    // service responsible for music playback
    public partial class AudioService: Resource, IEventPublisher
    {


        [Export(PropertyHint.Range, "-80,0,1")]
        public float SfxVolume {get {return sfxVolume;} set {sfxVolume = value;}}
        private float sfxVolume;
        private int SfxBusIndex = AudioServer.GetBusIndex("SFX");

        [Export(PropertyHint.Range, "-80,0,1")]
        public float MusicVolume {get {return _musicVolume;} set {_musicVolume = value;}}
        private float _musicVolume;
        private int MusicBusIndex = AudioServer.GetBusIndex("Music");

        [Export]
        public AudioStream CurrentTrack {get {return currentTrack;} set{currentTrack = value;}}

        public Dictionary<int, ArrayList> Subscriptions { get; set; }

        private AudioStream currentTrack;


        public void SetSfxVolume(float volume)
        {
            sfxVolume = volume;
            AudioServer.SetBusVolumeDb(SfxBusIndex, Mathf.LinearToDb(volume));
        }

        public void SetMusicVolume(float volume)
        {

            MusicVolume = volume;
            AudioServer.SetBusVolumeDb(MusicBusIndex, Mathf.LinearToDb(volume));
        }

        // TODO: implement
        public void StopMusic()
        {   
        }

        // TODO: implement
        public void PlayMusic()
        {
        }

        // TODO: implement
        public void Publish()
        {
        
            //AudioStreamChangeEvent e = new AudioStreamChangeEvent(this.CurrentTrack);
        }
    }   
}