using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Stella_Nova.Classes.Enums;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Managers
{
    public class SoundManager : GameComponent
    {
        public SoundManager(Game game) : base(game)
        {
            SoundEffects = new List<SoundEffectInstance>();
            MasterVolume = 1f;
            MusicVolume = 0.1f;
            EffectsVolume = 0.1f;
            SoundScale = 0.01f;

            #region SoundEffects Loading
            LaserShoot0 = game.Content.Load<SoundEffect>("Sounds/Weapons/Laser/Shoot_0");
            LaserShoot1 = game.Content.Load<SoundEffect>("Sounds/Weapons/Laser/Shoot_1");
            LaserShoot2 = game.Content.Load<SoundEffect>("Sounds/Weapons/Laser/Shoot_2");
            LaserReload0 = game.Content.Load<SoundEffect>("Sounds/Weapons/Laser/Reload_0");
            LaserReload1 = game.Content.Load<SoundEffect>("Sounds/Weapons/Laser/Reload_1");
            LaserReload2 = game.Content.Load<SoundEffect>("Sounds/Weapons/Laser/Reload_2");
            LaserEmpty0 = game.Content.Load<SoundEffect>("Sounds/Weapons/Laser/Empty_0");
            LaserEmpty1 = game.Content.Load<SoundEffect>("Sounds/Weapons/Laser/Empty_1");
            LaserEmpty2 = game.Content.Load<SoundEffect>("Sounds/Weapons/Laser/Empty_2");
            LaserImpact0 = game.Content.Load<SoundEffect>("Sounds/Impacts/Electric/Impact_0");
            LaserImpact1 = game.Content.Load<SoundEffect>("Sounds/Impacts/Electric/Impact_1");
            LaserImpact2 = game.Content.Load<SoundEffect>("Sounds/Impacts/Electric/Impact_2");
            LaserImpact3 = game.Content.Load<SoundEffect>("Sounds/Impacts/Electric/Impact_3");
            LaserImpact4 = game.Content.Load<SoundEffect>("Sounds/Impacts/Electric/Impact_4");

            PlasmaShoot0 = game.Content.Load<SoundEffect>("Sounds/Weapons/Plasma/Shoot_0");
            PlasmaShoot1 = game.Content.Load<SoundEffect>("Sounds/Weapons/Plasma/Shoot_1");
            PlasmaShoot2 = game.Content.Load<SoundEffect>("Sounds/Weapons/Plasma/Shoot_2");
            PlasmaReload0 = game.Content.Load<SoundEffect>("Sounds/Weapons/Plasma/Reload_0");
            PlasmaReload1 = game.Content.Load<SoundEffect>("Sounds/Weapons/Plasma/Reload_1");
            PlasmaReload2 = game.Content.Load<SoundEffect>("Sounds/Weapons/Plasma/Reload_2");
            PlasmaEmpty0 = game.Content.Load<SoundEffect>("Sounds/Weapons/Plasma/Empty_0");
            PlasmaEmpty1 = game.Content.Load<SoundEffect>("Sounds/Weapons/Plasma/Empty_1");
            PlasmaEmpty2 = game.Content.Load<SoundEffect>("Sounds/Weapons/Plasma/Empty_2");
            PlasmaImpact0 = game.Content.Load<SoundEffect>("Sounds/Impacts/Glitch/Impact_0");
            PlasmaImpact1 = game.Content.Load<SoundEffect>("Sounds/Impacts/Glitch/Impact_1");
            PlasmaImpact2 = game.Content.Load<SoundEffect>("Sounds/Impacts/Glitch/Impact_2");
            PlasmaImpact3 = game.Content.Load<SoundEffect>("Sounds/Impacts/Glitch/Impact_3");
            #endregion
        }

        public static List<SoundEffectInstance> SoundEffects;

        public static float MasterVolume;
        public static float MusicVolume;
        public static float EffectsVolume;
        public static float SoundScale;

        #region SoundEffects Library
        public static SoundEffect LaserShoot0;
        public static SoundEffect LaserShoot1;
        public static SoundEffect LaserShoot2;
        public static SoundEffect LaserReload0;
        public static SoundEffect LaserReload1;
        public static SoundEffect LaserReload2;
        public static SoundEffect LaserEmpty0;
        public static SoundEffect LaserEmpty1;
        public static SoundEffect LaserEmpty2;
        public static SoundEffect LaserImpact0;
        public static SoundEffect LaserImpact1;
        public static SoundEffect LaserImpact2;
        public static SoundEffect LaserImpact3;
        public static SoundEffect LaserImpact4;

        public static SoundEffect PlasmaShoot0;
        public static SoundEffect PlasmaShoot1;
        public static SoundEffect PlasmaShoot2;
        public static SoundEffect PlasmaReload0;
        public static SoundEffect PlasmaReload1;
        public static SoundEffect PlasmaReload2;
        public static SoundEffect PlasmaEmpty0;
        public static SoundEffect PlasmaEmpty1;
        public static SoundEffect PlasmaEmpty2;
        public static SoundEffect PlasmaImpact0;
        public static SoundEffect PlasmaImpact1;
        public static SoundEffect PlasmaImpact2;
        public static SoundEffect PlasmaImpact3;
        public static SoundEffect PlasmaImpact4;
        #endregion

        public override void Update(GameTime gameTime)
        {
            for (int i = SoundEffects.Count - 1; i >= 0; i--)
            {
                if (SoundEffects[i].State == SoundState.Stopped)
                {
                    SoundEffects[i].Dispose();
                    SoundEffects.RemoveAt(i);
                }
            }

            base.Update(gameTime);
        }

        public static void PlaySound(SoundEffect soundEffect)
        {
            SoundEffectInstance soundEffectInstance = soundEffect.CreateInstance();
            soundEffectInstance.Play();
            soundEffectInstance.Volume = EffectsVolume * MasterVolume;

            SoundEffects.Add(soundEffectInstance);
        }
        public static void PlaySound3D(SoundEffect soundEffect, Vector2 position, Vector2 velocity)
        {
            SoundEffectInstance soundEffectInstance = soundEffect.CreateInstance();
            SoundEffects.Add(soundEffectInstance);
            soundEffectInstance.Play();

            AudioEmitter soundEffectEmitter = new AudioEmitter();
            soundEffectEmitter.Position = new Vector3(position.X * SoundScale, position.Y * SoundScale, 0);
            soundEffectEmitter.Velocity = new Vector3(velocity.X * SoundScale, velocity.Y * SoundScale, 0);

            switch (Main.gameStage)
            {
                case GameStage.Menu:
                    AudioListener audioListener = new AudioListener();
                    audioListener.Position = new Vector3(UIManager.menuCinematicTarget.Position, 0);
                    audioListener.Velocity = new Vector3(UIManager.menuCinematicTarget.Velocity, 0);
                    soundEffectInstance.Apply3D(audioListener, soundEffectEmitter);
                    break;
                case GameStage.Playing:
                    soundEffectInstance.Apply3D(PlayerManager.player.AudioListener, soundEffectEmitter);
                    break;
                case GameStage.Paused:
                    soundEffectInstance.Apply3D(PlayerManager.player.AudioListener, soundEffectEmitter);
                    break;
            }
            soundEffectInstance.Volume = EffectsVolume * MasterVolume;

        }
        public static void StopAll()
        {
            foreach (SoundEffectInstance instance in SoundEffects)
            {
                instance.Play();
                instance.Stop();
            }
            SoundEffects.Clear();
        }
        public static void PauseAll()
        {
            foreach (SoundEffectInstance instance in SoundEffects)
                instance.Pause();
        }
        public static void ResumeAll()
        {
            foreach (SoundEffectInstance instance in SoundEffects)
                instance.Resume();
        }
        public static void SetVolume(float volume)
        {
            foreach (SoundEffectInstance instance in SoundEffects)
                instance.Volume = volume;
        }
        public SoundEffect LoadSound(string file)
        {
            return Game.Content.Load<SoundEffect>(file);
        }
    }
}