# SimpleSoundSystem
Simple sound system package for 3D Unity projects

## Features
- Spatialized sound playback - play sound effects at specific positions in 3D space
- Variable pitch - define a min/max pitch range per sound effect for variation
- Object pooling - reuses `AudioSource` GameObjects in scene

## Instalation

Add the following line to the dependencies section of your project's manifest.json file. Replace 1.0.0 with the version you want to install.
```
"com.jakubkrizanovsky.simplesoundsystem": "git+https://github.com/jakubkrizanovsky/SimpleSoundSystem#1.0.0"
```

Alternatively, you can add the Git URL directly through Unity’s Package Manager → Add package from Git URL.

## Usage

- Find a sound file you want to use and add it to your project
- Create a `SoundEffectDefinition` for your sound - In the Unity Editor, go to: `Create` → `ScriptableObjects` → `SFX` → `SoundEffectDefinition`
- Add the `SoundEffectPlayer` prefab to a scene, which will be loaded when playing sounds
- Play sounds in your scripts by calling:
```
SoundEffectPlayer.PlaySoundEffect(sfxDefinition, worldPosition)
```
&emsp; passing in your `SoundEffectDefinition` asset and the world space position of the sound as parameters.
