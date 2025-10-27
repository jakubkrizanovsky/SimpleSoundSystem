using UnityEngine;
using UnityEngine.Pool;

namespace JakubKrizanovsky.SimpleSoundSystem
{
	public class SoundEffectPlayer : MonoBehaviour
	{
		[SerializeField]
		private SoundEffect _soundEffectPrefab;

		private void OnValidate() {
			if(_soundEffectPrefab == null) Debug.LogError("[SoundEffectPlayer] _soundEffectPrefab is null", this);
		}

		private ObjectPool<SoundEffect> _sfxPool;

		public static SoundEffectPlayer Instance {get; private set;}
		protected virtual void Awake()
		{
			if(Instance != null) {
				Destroy(this);
				return;
			} else {
				Instance = this;
			}

			_sfxPool = new ObjectPool<SoundEffect>(
					() => Instantiate(_soundEffectPrefab),
					sfx => sfx.gameObject.SetActive(true),
					sfx => sfx.gameObject.SetActive(false),
					sfx => Destroy(sfx.gameObject),
					false, 100, 100
			);
		}

		public void PlaySoundEffect(ASoundEffectDefinition sfxDefinition, Vector3 position, float pitchMultiplier) {
			SoundEffect soundEffect = _sfxPool.Get();
			sfxDefinition.InitializeSoundEffect(soundEffect, pitchMultiplier);
			soundEffect.OnFinishedPlaying += OnSoundFinishedPlaying;
			soundEffect.Play(sfxDefinition, position);
		}

		private void OnSoundFinishedPlaying(SoundEffect soundEffect) {
			soundEffect.OnFinishedPlaying -= OnSoundFinishedPlaying;
			_sfxPool.Release(soundEffect);
		}
	}
}
