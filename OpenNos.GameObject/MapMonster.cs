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

using System;
using AutoMapper;
using OpenNos.Data;
using System.Linq;
using System.Collections.Generic;

namespace OpenNos.GameObject
{
    public class MapMonster : MapMonsterDTO
    {
        #region Instantiation
        public short firstX
        {
            get; set;
        }
        public short firstY
        {
            get; set;
        }

        public MapMonster()
        {
            Mapper.CreateMap<MapMonsterDTO, MapMonster>();
            Mapper.CreateMap<MapMonster, MapMonsterDTO>();
            LastEffect = LastMove = DateTime.Now;
        }


        public DateTime LastMove { get; private set; }
        public DateTime LastEffect { get; private set; }

        public static int generateMapMonsterId()
        {
            Random rnd = new Random();
            List<int> test = new List<int>();

            foreach (MapMonster mons in ServerManager.Monsters)
            {
                    test.Add(mons.MapMonsterId);
            }

            for (int i = 20000; i < int.MaxValue; i++)
                if (!test.Contains(i))
                    return i;
           return -1;
        }
        internal void MonsterLife()
        {
            NpcMonster monster = ServerManager.GetNpc(this.MonsterVNum);
            if (monster == null)
                return;

            double time = (DateTime.Now - LastMove).TotalSeconds;
            if (Move && time > 2.2)
            {
                Random r = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
                int oldx = this.MapX;
                int oldy = this.MapY;

                // test.x += (((int)(r.Next(0, 6000)/1000)%2) == 0 )?(-((int)(r.Next(0, 10000)/1000)/2)):((int)(r.Next(0, 10000)/1000)/2);
                // test.y += (((int)(r.Next(0, 6000) / 1000) % 2) == 0) ? (-((int)(r.Next(0, 10000) / 1000) / 2)) : ((int)(r.Next(0, 10000) / 1000) / 2);

                short MapX = (short)r.Next(-2 + this.firstX, 3 + this.firstX);
                short MapY = (short)r.Next(-2 + this.firstY, 3 + this.firstY);
                bool ok = true;
                if (MapX > firstX)
                {
                    for (int i = 0; i < MapX - firstX; i++)
                    {
                        if (ServerManager.GetMap(MapId).IsBlockedZone(firstX + i, firstY))
                        {
                            ok = false;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < firstX - MapX ; i++)
                    {
                        if (ServerManager.GetMap(MapId).IsBlockedZone(MapX + i, MapY))
                        {
                            ok = false;
                        }
                    }
                }


                if (MapY > firstY)
                {
                    for (int i = 0; i < MapY - firstY; i++)
                    {
                        if (ServerManager.GetMap(MapId).IsBlockedZone(firstX, firstY + i))
                        {
                            ok = false;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < firstX - MapX; i++)
                    {
                        if (ServerManager.GetMap(MapId).IsBlockedZone(MapX, MapY + i))
                        {
                            ok = false;
                        }
                    }
                }
                if (ok)
                {
                    this.MapX = MapX;
                    this.MapY = MapY;
                    LastMove = DateTime.Now;

                    string movepacket = $"mv 3 {this.MapMonsterId} {this.MapX} {this.MapY} {monster.Speed}";
                    ClientLinkManager.Instance.RequiereBroadcastFromMap(MapId, movepacket);
                }
            }
        }

        public string GenerateIn3()
        {
            return $"in 3 {MonsterVNum} {MapMonsterId} {MapX} {MapY} {Position} 100 100 0 0 0 -1 1 0 -1 - 0 -1 0 0 0 0 0 0 0 0";
        }

        #endregion
    }
}