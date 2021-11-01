﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;
using UnityEngine;
using HarmonyLib;

namespace PokeWorld
{
    [HarmonyPatch(typeof(StockGenerator_Animals))]
    [HarmonyPatch("PawnKindAllowed")]
    class StockGenerator_Animals_PawnKindAllowed_Patch
    {
        public static bool Prefix(PawnKindDef __0, ref bool __result)
        {
            if (PokeWorldSettings.minSelected() && __0.race.HasComp(typeof(CompPokemon)))
            {
                __result = false;
                return false;
            }
            else if(PokeWorldSettings.maxSelected() && !__0.race.HasComp(typeof(CompPokemon)))
            {
                __result = false;
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
