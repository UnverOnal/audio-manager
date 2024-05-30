using UnityEngine;

namespace AudioManagement.Scripts.Sound
{
    public class SaveLoadSound
    {
        public void SaveMuteStatus(SoundType type, bool isMute)
        {
            var isMuteInt = isMute ? 1 : 0;
            PlayerPrefs.SetInt(type.ToString(), isMuteInt);
            PlayerPrefs.Save();
        }

        public bool LoadMuteStatus(SoundType type)
        {
            var isMuteInt = PlayerPrefs.GetInt(type.ToString(), 0);
            var isMute = isMuteInt == 1 ? true : false;
            return isMute;
        }
    }
}