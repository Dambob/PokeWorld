﻿using Verse;

namespace PokeWorld
{
    public class Evolution
    {
        public PawnKindDef pawnKind;

        public EvolutionRequirement requirement;

        public OtherEvolutionRequirement otherRequirement;

        public ThingDef item;

        public int level;

        public int friendship;

        public TimeOfDay timeOfDay;

        public Gender gender;

        public Evolution()
        {
        }
    }

    public enum EvolutionRequirement
    {
        level = 0,
        item = 1
    }

    public enum OtherEvolutionRequirement
    {
        none = 0,
        attack = 1,
        defense = 2,
        balanced = 3
    }
}
