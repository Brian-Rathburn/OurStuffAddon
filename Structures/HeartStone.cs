﻿using Terraria;
using Terraria.ID;

namespace OurStuffAddon.Structures
{
    public class HeartStone
    {
        private static readonly int[,] _HeartStoneBig = new int[,]
{
            { 0,1,1,0,1,1,0},
            { 1,1,1,1,1,1,1},
            { 1,1,1,1,1,1,1},
            { 0,1,1,1,1,1,0},
            { 0,1,1,1,1,0,0},
            { 0,0,0,1,0,0,0},



};
        private static readonly int[,] _HeartStoneMed = new int[,]
{
            { 0,1,1,0,1,1,0},
            { 1,1,1,1,1,1,1},
            { 1,1,1,1,1,1,1},
            { 0,1,1,1,1,1,0},
            { 0,1,1,1,1,0,0},
            { 0,0,0,1,0,0,0},



};
        private static readonly int[,] _HeartStoneSmall = new int[,]
        {
            { 0,1,1,0,1,1,0},
            { 1,1,1,1,1,1,1},
            { 1,1,1,1,1,1,1},
            { 0,1,1,1,1,1,0},
            { 0,1,1,1,1,0,0},
            { 0,0,0,1,0,0,0},



        };
        /**
         * 0 = Do Nothing
         * 1 = Heart Stone
         * */
        public static void StructureGenBig(int xPosO, int yPosO)
        {
            for (int i = 0; i < _HeartStoneBig.GetLength(1); i++)
            {
                for (int j = 0; j < _HeartStoneBig.GetLength(0); j++)
                {
                    if (TileCheckSafe((int)(xPosO + i), (int)(yPosO + j)))
                    {
                        if (_HeartStoneBig[j, i] == 1)
                        {
                            WorldGen.KillTile(xPosO + i, yPosO + j);
                            WorldGen.PlaceTile(xPosO + i, yPosO + j, OurStuffAddon.instance.TileType("HeartStone"), true, true);
                        }
                    }
                }
            }
        }

        public static void StructureGenMed(int xPosO, int yPosO)
        {
            for (int i = 0; i < _HeartStoneMed.GetLength(1); i++)
            {
                for (int j = 0; j < _HeartStoneMed.GetLength(0); j++)
                {
                    if (TileCheckSafe((int)(xPosO + i), (int)(yPosO + j)))
                    {
                        if (_HeartStoneMed[j, i] == 1)
                        {
                            WorldGen.KillTile(xPosO + i, yPosO + j);
                            WorldGen.PlaceTile(xPosO + i, yPosO + j, OurStuffAddon.instance.TileType("HeartStone"), true, true);
                        }
                    }
                }
            }
        }

        public static void StructureGenSmall(int xPosO, int yPosO)
        {
            for (int i = 0; i < _HeartStoneSmall.GetLength(1); i++)
            {
                for (int j = 0; j < _HeartStoneSmall.GetLength(0); j++)
                {
                    if (TileCheckSafe((int)(xPosO + i), (int)(yPosO + j)))
                    {
                        if (_HeartStoneSmall[j, i] == 1)
                        {
                            WorldGen.KillTile(xPosO + i, yPosO + j);
                            WorldGen.PlaceTile(xPosO + i, yPosO + j, OurStuffAddon.instance.TileType("HeartStone"), true, true);
                        }
                    }
                }
            }
        }

        private static bool TileCheckSafe(int i, int j)
        {
            int type = Main.tile[i, j].type;
            if (i > 0 && i < Main.maxTilesX - 1 && j > 0 && j < Main.maxTilesY - 1 && (type == TileID.Stone ))
                return true;
            return false;
        }
    }
}