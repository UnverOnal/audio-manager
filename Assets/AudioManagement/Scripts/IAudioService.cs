using AudioManagement.Scripts.ResourceManagement;
using AudioManagement.Scripts.Sound;

namespace AudioManagement.Scripts
{
    public interface IAudioService
    {
        public void Play(AudioClipEnum clip);
        public void Mute(AudioClipEnum clip, bool mute);
        public void MuteType(SoundType type, bool mute);
        public void MuteAll(bool mute);
        public bool GetMuteStatus(SoundType type);
        public void Stop(AudioClipEnum clip);
        public void StopType(SoundType type);
        public void StopAll();
    }
}