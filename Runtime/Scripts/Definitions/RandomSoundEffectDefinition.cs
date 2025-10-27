using UnityEngine;

namespace JakubKrizanovsky.SimpleSoundSystem
{
	[CreateAssetMenu(fileName="SoundEffect", menuName="ScriptableObjects/SFX/RandomSoundEffectDefinition")]
    public class RandomSoundEffectDefinition : ASoundEffectDefinition
    {
		[SerializeField]
		private ASoundEffectDefinition[] _definitions;

        public override void InitializeSoundEffect(SoundEffect soundEffect, float pitchMultiplier) {
            ASoundEffectDefinition definition = _definitions[Random.Range(0, _definitions.Length)];
			definition.InitializeSoundEffect(soundEffect, pitchMultiplier);
        }
    }
}
