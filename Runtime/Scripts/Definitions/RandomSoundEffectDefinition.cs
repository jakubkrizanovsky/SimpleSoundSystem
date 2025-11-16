using UnityEngine;

namespace JakubKrizanovsky.SimpleSoundSystem
{
	[CreateAssetMenu(fileName="SoundEffect", menuName="ScriptableObjects/SFX/RandomSoundEffectDefinition")]
    public class RandomSoundEffectDefinition : ASoundEffectDefinition
    {
		[SerializeField]
		private ASoundEffectDefinition[] _definitions;

        internal override void InitializeSoundEffect(SoundEffect soundEffect, SoundPlayParameters parameters) {
            ASoundEffectDefinition definition = _definitions[Random.Range(0, _definitions.Length)];
			definition.InitializeSoundEffect(soundEffect, parameters);
        }
    }
}
