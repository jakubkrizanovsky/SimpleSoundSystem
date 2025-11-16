using UnityEngine;

namespace JakubKrizanovsky.SimpleSoundSystem
{
	public abstract class ASoundEffectDefinition : ScriptableObject
	{
		internal abstract void InitializeSoundEffect(SoundEffect soundEffect, SoundPlayParameters parameters);
	}
}
