using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum BLOCKDIR
{
    BD_T,
    BD_R,
    BD_B,
    BD_L,
    BD_MAX
}

enum BLOCKTYPE
{
    BT_I, 
    BT_L,  
    BT_J, 
    BT_Z, 
    BT_S,
    BT_T,
    BT_O,
    BT_MAX,
}

partial class Block
{
    int X = 0;
    int Y = 0;
    //BLOCKDIR Dir = BLOCKDIR.BD_T;
    string[][] Arr = null;
    //List<List<string>> BlockData = new List<List<string>>();

    BLOCKTYPE CurBlockType =  BLOCKTYPE.BT_T;
    BLOCKDIR CurDirType =  BLOCKDIR.BD_T;
    TETRISSCREEN Screen = null;

    public Block(TETRISSCREEN _Screen)
    {
        Screen = _Screen;
        DataInit();

        SettingBlock(CurBlockType, CurDirType);
    }

    private void SettingBlock(BLOCKTYPE _Type, BLOCKDIR _Dir)
    {
        Arr = AllBlock[(int)_Type][(int)_Dir];
    }

    private void Input()
    {
        if (false == Console.KeyAvailable)
        {
            return;
        }

        
        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.A:
                X -= 1;
                break;
            case ConsoleKey.D:
                X += 1;
                break;
            case ConsoleKey.Q://Left
                --CurDirType;
                if ( 0 > CurDirType)
                {
                    CurDirType = BLOCKDIR.BD_L;
                }
                SettingBlock(CurBlockType, CurDirType);
                break;
            case ConsoleKey.E://Right
                ++CurDirType;
                if (BLOCKDIR.BD_MAX == CurDirType)
                {
                    CurDirType = BLOCKDIR.BD_T;
                }
                SettingBlock(CurBlockType, CurDirType);
                break;
            case ConsoleKey.S:
                Y += 1;
                break;
            default:
                break;
        }
    }

    public void Move()
    {
        Input();

        for (int y = 0; y < 4; ++y)
        {
            for (int x = 0; x < 4; ++x)
            {
                if (Arr[y][x] == "□")
                {
                    continue;
                }
                Screen.SetBlock(Y + y, X + x, Arr[y][x]);
            }
        }

        //Screen.SetBlock(Y, X, BlockType);
    }
}