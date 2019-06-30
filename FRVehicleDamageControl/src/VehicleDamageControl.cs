﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FRCarDamageUtils.src;
using Rocket.API;
using Rocket.Core.Plugins;
using SDG.Unturned;
using Steamworks;

namespace FRCarDamageUtils
{
    public class Plugin : RocketPlugin<VehicleDamageControlConfiguration>
    {
        public static Plugin Instance;

        protected override void Load()
        {
            Instance = this;
            VehicleManager.onDamageVehicleRequested += new DamageVehicleRequestHandler(this.onCarGetDamage);
        }

        public void onCarGetDamage(CSteamID instigatorSteamID, InteractableVehicle vehicle, ref ushort pendingTotalDamage, ref bool canRepair, ref bool shouldAllow, EDamageOrigin damageOrigin)
        {
            switch (damageOrigin)
            {
                case EDamageOrigin.Bullet_Explosion:
                    pendingTotalDamage = (ushort)(pendingTotalDamage * Plugin.Instance.Configuration.Instance.DamageFromBulletExplosion);
                    break;
                case EDamageOrigin.Animal_Attack:
                    pendingTotalDamage = (ushort)(pendingTotalDamage * Plugin.Instance.Configuration.Instance.DamageFromAnimalAttack);
                    break;
                case EDamageOrigin.Flamable_Zombie_Explosion:
                    pendingTotalDamage = (ushort)(pendingTotalDamage * Plugin.Instance.Configuration.Instance.DamageFromFlamableZombieExplosion);
                    break;
                case EDamageOrigin.Food_Explosion:
                    pendingTotalDamage = (ushort)(pendingTotalDamage * Plugin.Instance.Configuration.Instance.DamageFromFoodExplosion);
                    break;
                case EDamageOrigin.Mega_Zombie_Boulder:
                    pendingTotalDamage = (ushort)(pendingTotalDamage * Plugin.Instance.Configuration.Instance.DamageFromMegaZombieBoulder);
                    break;
                case EDamageOrigin.Punch:
                    pendingTotalDamage = (ushort)(pendingTotalDamage * Plugin.Instance.Configuration.Instance.DamageFromPunch);
                    break;
                case EDamageOrigin.Radioactive_Zombie_Explosion:
                    pendingTotalDamage = (ushort)(pendingTotalDamage * Plugin.Instance.Configuration.Instance.DamageFromRadioactiveZombieExplosion);
                    break;
                case EDamageOrigin.Rocket_Explosion:
                    pendingTotalDamage = (ushort)(pendingTotalDamage * Plugin.Instance.Configuration.Instance.DamageFromRocketExplosion);
                    break;
                case EDamageOrigin.Sentry:
                    pendingTotalDamage = (ushort)(pendingTotalDamage * Plugin.Instance.Configuration.Instance.DamageFromSentry);
                    break;
                case EDamageOrigin.Trap_Explosion:
                    pendingTotalDamage = (ushort)(pendingTotalDamage * Plugin.Instance.Configuration.Instance.DamageFromTrapExplosion);
                    break;
                case EDamageOrigin.Useable_Gun:
                    pendingTotalDamage = (ushort)(pendingTotalDamage * Plugin.Instance.Configuration.Instance.DamageFromUseableGun);
                    break;
                case EDamageOrigin.Useable_Melee:
                    pendingTotalDamage = (ushort)(pendingTotalDamage * Plugin.Instance.Configuration.Instance.DamageFromUseableMelee);
                    break;
                case EDamageOrigin.Vehicle_Bumper:
                    pendingTotalDamage = (ushort)(pendingTotalDamage * Plugin.Instance.Configuration.Instance.DamageFromVehicleBumper);
                    break;
                case EDamageOrigin.Vehicle_Explosion:
                    pendingTotalDamage = (ushort)(pendingTotalDamage * Plugin.Instance.Configuration.Instance.DamageFromVehicleExplosion);
                    break;
                case EDamageOrigin.Zombie_Electric_Shock:
                    pendingTotalDamage = (ushort)(pendingTotalDamage * Plugin.Instance.Configuration.Instance.DamageFromZombieElectricShock);
                    break;
                case EDamageOrigin.Zombie_Fire_Breath:
                    pendingTotalDamage = (ushort)(pendingTotalDamage * Plugin.Instance.Configuration.Instance.DamageFromZombieFireBreath);
                    break;
                case EDamageOrigin.Zombie_Stomp:
                    pendingTotalDamage = (ushort)(pendingTotalDamage * Plugin.Instance.Configuration.Instance.DamageFromZombieStomp);
                    break;
                case EDamageOrigin.Zombie_Swipe:
                    pendingTotalDamage = (ushort)(pendingTotalDamage * Plugin.Instance.Configuration.Instance.DamageFromZombieSwipe);
                    break;
            }
        }
    }
}