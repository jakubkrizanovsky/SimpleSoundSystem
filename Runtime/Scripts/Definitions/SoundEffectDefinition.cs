using UnityEngine;

namespace JakubKrizanovsky.SimpleSoundSystem
{
	[CreateAssetMenu(fileName="SoundEffect", menuName="ScriptableObjects/SFX/SoundEffectDefinition")]
	public class SoundEffectDefinition : ASoundEffectDefinition
	{
		[field: SerializeField]
		public string Name {get; private set;}

		[field: SerializeField]
		public AudioClip AudioClip {get; private set;}

		[field: SerializeField]
		public float MinPitch {get; private set;} = 0.9f;

		[field: SerializeField]
		public float MaxPitch {get; private set;} = 1.1f;

        public override void InitializeSoundEffect(SoundEffect soundEffect, float pitchMultiplier) {
            AudioSource audioSource = soundEffect.AudioSource;
			audioSource.clip = AudioClip;
			audioSource.pitch = pitchMultiplier * Random.Range(MinPitch, MaxPitch);
        }
    }
}
