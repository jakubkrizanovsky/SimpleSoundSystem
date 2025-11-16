using UnityEngine;

namespace JakubKrizanovsky.SimpleSoundSystem.EditorTools
{
    public static class EditorAudioUtil
    {
        private static SoundEffect _previewSoundEffect;

        public static void PreviewSFXDefinition(ASoundEffectDefinition sfxDefinition) {
            if(_previewSoundEffect == null) {
                GameObject previewSoundEffectGO = new("PreviewSoundEffect") {
                    hideFlags = HideFlags.HideAndDontSave
                };

                previewSoundEffectGO.AddComponent<AudioSource>();
                _previewSoundEffect = previewSoundEffectGO.AddComponent<SoundEffect>();
                _previewSoundEffect.Awake();
            }

            _previewSoundEffect.Play(sfxDefinition);
        }

        public static void StopPlayback() {
            if(_previewSoundEffect != null) {
                _previewSoundEffect.AudioSource.Stop();
            }
        }
    }
}
