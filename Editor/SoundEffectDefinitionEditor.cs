using UnityEngine;
using UnityEditor;

namespace JakubKrizanovsky.SimpleSoundSystem.EditorTools
{
    [CustomEditor(typeof(SoundEffectDefinition))]
    public class SoundEffectDefinitionEditor : Editor
    {
        public override void OnInspectorGUI() {
            DrawDefaultInspector();

            if(GUILayout.Button("Play")) {
                EditorAudioUtil.PreviewSFXDefinition((ASoundEffectDefinition) target);
            }

            if(GUILayout.Button("Stop")) {
                EditorAudioUtil.StopPlayback();
            }
        }
    }
}
