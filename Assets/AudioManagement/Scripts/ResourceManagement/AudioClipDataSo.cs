using System;
using AudioManagement.Scripts.Sound;
using UnityEngine;

namespace AudioManagement.Scripts.ResourceManagement
{
    public class AudioClipDataSo : ScriptableObject
    {
        [Serializable]
        public struct AudioClipData
        {
            public AudioClip audioClip;
            [Range(0f, 3f)] public float pitch;
            [Range(0f, 1f)] public float volume;
            public bool loop;
            public SoundType type;
            public float infrequency;
        }

        public AudioClipData data;
    }
}