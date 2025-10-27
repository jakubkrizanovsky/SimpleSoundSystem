using UnityEngine;

namespace JakubKrizanovsky.SimpleSoundSystem
{
	public abstract class ASoundEffectDefinition : ScriptableObject
	{
		public abstract void InitializeSoundEffect(SoundEffect soundEffect, float pitchMultiplier);
	}
}
