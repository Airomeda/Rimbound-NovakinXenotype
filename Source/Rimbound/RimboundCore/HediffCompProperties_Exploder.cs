﻿using Verse;

namespace RimboundCore
{
    public class HediffCompProperties_Exploder : HediffCompProperties
    {
        public float radius = 5.9f;

        public DamageDef damageDef;

        public int damageAmount = 0;

        public float damagePenetration = 0f;

        public SoundDef soundCreated = null;

        public ThingDef thingCreated = null;

        public float thingCreatedChance = 0f;

        public float chanceToStartFire = 0f;

        public bool damageUser = true;

        public HediffCompProperties_Exploder()
        {
            compClass = typeof(HediffComp_Exploder);
        }
    }
}
