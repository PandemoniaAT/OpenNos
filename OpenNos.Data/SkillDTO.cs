﻿/*
 * This file is part of the OpenNos Emulator Project. See AUTHORS file for Copyright information
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 */

namespace OpenNos.Data
{
    public class SkillDTO
    {
        #region Properties

        public short SkillVNum { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public byte LevelMinimum { get; set; }
        public byte Class { get; set; }
        public byte MinimumAdventurerLevel { get; set; }
        public byte MinimumSwordmanLevel { get; set; }
        public byte MinimumArcherLevel { get; set; }
        public byte MinimumMagicianLevel { get; set; }
        public short Effect { get; set; }
        public byte Level { get; set; }
        public short MpCost { get; set; }
        public byte CPCost { get; set; }
        public short Cooldown { get; set; }
        public short CastAnimation { get; set; }
        public short AttackAnimation { get; set; }
        public short CastEffect { get; set; }
        public byte Distance { get; set; }
        public short Duration { get; set; }
        public short Damage { get; set; }
        public short ElementalDamage { get; set; }
        public byte Element { get; set; }
        public short CastId { get; set; }
        public byte UpgradeType { get; set; }
        public byte Type { get; set; }
        public byte Range { get; set; }
        public short VNumRequired { get; set; }
        public short UpgradeSkill { get; set; }

        #endregion
    }
}