using UnityEngine;

namespace JakubKrizanovsky.SimpleSoundSystem
{
	[CreateAssetMenu(fileName="SoundEffect", menuName="ScriptableObjects/SFX/SoundEffectDefinition")]
	public class SoundEffectDefinition : ASoundEffectDefinition
	{
		[field: SerializeField]
		public AudioClip AudioClip {get; private set;}

		[field: SerializeField]
		public float Volume {get; private set;} = 0.5f;

		[field: SerializeField]
		public float MinPitch {get; private set;} = 0.9f;

		[field: SerializeField]
		public float MaxPitch {get; private set;} = 1.1f;

        internal override void InitializeSoundEffect(SoundEffect soundEffect, SoundPlayParameters parameters) {
            AudioSource audioSource = soundEffect.AudioSource;
			audioSource.clip = AudioClip;

			audioSource.volume = parameters.VolumeMultiplier * Volume;
			audioSource.pitch = parameters.PitchMultiplier * Random.Range(MinPitch, MaxPitch);
        }
    }
}
