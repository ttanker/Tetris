﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


partial class Block
{
    List<List<string[][]>> AllBlock = new List<List<string[][]>>();
    void DataInit()
    {
        for (int BT = 0; BT < (int)BLOCKTYPE.BT_MAX; ++BT)
        {
            AllBlock.Add(new List<string[][]>());
            for (int BD = 0; BD < (int)BLOCKDIR.BD_MAX; ++BD)
            {
                AllBlock[BT].Add(null);
            }
        }


        #region I
        AllBlock[(int)BLOCKTYPE.BT_I][(int)BLOCKDIR.BD_T] = new string[][]
        {
            new string[] { "■", "□", "□", "□" },
            new string[] { "■", "□", "□", "□" },
            new string[] { "■", "□", "□", "□" },
            new string[] { "■", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_I][(int)BLOCKDIR.BD_R] = new string[][]
        {
            new string[] { "■", "■", "■", "■" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_I][(int)BLOCKDIR.BD_B] = new string[][]
        {
            new string[] { "■", "□", "□", "□" },
            new string[] { "■", "□", "□", "□" },
            new string[] { "■", "□", "□", "□" },
            new string[] { "■", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_I][(int)BLOCKDIR.BD_L] = new string[][]
        {
            new string[] { "■", "■", "■", "■" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };
        #endregion

        #region T
        AllBlock[(int)BLOCKTYPE.BT_T][(int)BLOCKDIR.BD_T] = new string[][]
         {
            new string[] { "□", "■", "□", "□" },
            new string[] { "■", "■", "■", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_T][(int)BLOCKDIR.BD_R] = new string[][]
        {
            new string[] { "□", "■", "□", "□" },
            new string[] { "□", "■", "■", "□" },
            new string[] { "□", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_T][(int)BLOCKDIR.BD_B] = new string[][]
        {
            new string[] { "□", "□", "□", "□" },
            new string[] { "■", "■", "■", "□" },
            new string[] { "□", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_T][(int)BLOCKDIR.BD_L] = new string[][]
        {
            new string[] { "□", "■", "□", "□" },
            new string[] { "■", "■", "□", "□" },
            new string[] { "□", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };
        #endregion

        #region J
        AllBlock[(int)BLOCKTYPE.BT_J][(int)BLOCKDIR.BD_T] = new string[][]
         {
            new string[] { "■", "□", "□", "□" },
            new string[] { "■", "■", "■", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_J][(int)BLOCKDIR.BD_R] = new string[][]
        {
            new string[] { "□", "■", "□", "□" },
            new string[] { "□", "■", "□", "□" },
            new string[] { "■", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_J][(int)BLOCKDIR.BD_B] = new string[][]
        {
            new string[] { "■", "■", "■", "□" },
            new string[] { "□", "□", "■", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_J][(int)BLOCKDIR.BD_L] = new string[][]
        {
            new string[] { "■", "■", "□", "□" },
            new string[] { "■", "□", "□", "□" },
            new string[] { "■", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };
        #endregion

        #region L
        AllBlock[(int)BLOCKTYPE.BT_L][(int)BLOCKDIR.BD_T] = new string[][]
         {
            new string[] { "□", "□", "■", "□" },
            new string[] { "■", "■", "■", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_L][(int)BLOCKDIR.BD_R] = new string[][]
        {
            new string[] { "■", "■", "□", "□" },
            new string[] { "□", "■", "□", "□" },
            new string[] { "□", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_L][(int)BLOCKDIR.BD_B] = new string[][]
        {
            new string[] { "■", "■", "■", "□" },
            new string[] { "■", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_L][(int)BLOCKDIR.BD_L] = new string[][]
        {
            new string[] { "■", "□", "□", "□" },
            new string[] { "■", "□", "□", "□" },
            new string[] { "■", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };
        #endregion

        #region Z
        AllBlock[(int)BLOCKTYPE.BT_Z][(int)BLOCKDIR.BD_T] = new string[][]
         {
            new string[] { "■", "■", "□", "□" },
            new string[] { "□", "■", "■", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_Z][(int)BLOCKDIR.BD_R] = new string[][]
        {
            new string[] { "□", "■", "□", "□" },
            new string[] { "■", "■", "□", "□" },
            new string[] { "■", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_Z][(int)BLOCKDIR.BD_B] = new string[][]
        {
            new string[] { "■", "■", "□", "□" },
            new string[] { "□", "■", "■", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_Z][(int)BLOCKDIR.BD_L] = new string[][]
        {
            new string[] { "□", "■", "□", "□" },
            new string[] { "■", "■", "□", "□" },
            new string[] { "■", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };
        #endregion

        #region S
        AllBlock[(int)BLOCKTYPE.BT_S][(int)BLOCKDIR.BD_T] = new string[][]
         {
            new string[] { "□", "■", "■", "□" },
            new string[] { "■", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_S][(int)BLOCKDIR.BD_R] = new string[][]
        {
            new string[] { "■", "□", "□", "□" },
            new string[] { "■", "■", "□", "□" },
            new string[] { "□", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_S][(int)BLOCKDIR.BD_B] = new string[][]
        {
            new string[] { "□", "■", "■", "□" },
            new string[] { "■", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_S][(int)BLOCKDIR.BD_L] = new string[][]
        {
            new string[] { "■", "□", "□", "□" },
            new string[] { "■", "■", "□", "□" },
            new string[] { "□", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };
        #endregion

        #region O
        AllBlock[(int)BLOCKTYPE.BT_O][(int)BLOCKDIR.BD_T] = new string[][]
         {
            new string[] { "■", "■", "□", "□" },
            new string[] { "■", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_O][(int)BLOCKDIR.BD_R] = new string[][]
        {
            new string[] { "■", "■", "□", "□" },
            new string[] { "■", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_O][(int)BLOCKDIR.BD_B] = new string[][]
        {
            new string[] { "■", "■", "□", "□" },
            new string[] { "■", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_O][(int)BLOCKDIR.BD_L] = new string[][]
        {
            new string[] { "■", "■", "□", "□" },
            new string[] { "■", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };
        #endregion


    }
}