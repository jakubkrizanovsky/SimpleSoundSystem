using System;
using System.Collections;
using UnityEngine;

namespace JakubKrizanovsky.SimpleSoundSystem
{
	[RequireComponent(typeof(AudioSource))]
	public class SoundEffect : MonoBehaviour
	{
		public event Action<SoundEffect> OnFinishedPlaying;
		public AudioSource AudioSource {get; private set;}

		private void Awake() {
			AudioSource = GetComponent<AudioSource>();
		}

		public void Play(ASoundEffectDefinition sfxDefinition, Vector3 position) {
			transform.position = position;
			AudioSource.Play();
			StartCoroutine(WaitForEnd_Coroutine());
		}

		private IEnumerator WaitForEnd_Coroutine() {
			while(AudioSource.isPlaying) {
				yield return null;
			}
			OnFinishedPlaying?.Invoke(this);
		}
	}
}
