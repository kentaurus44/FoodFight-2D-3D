﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Asg2_6262732
{
    public enum Direction
    {
        North,
        East,
        South,
        West,
        NorthEast,
        SouthEast,
        SouthWest,
        NorthWest
    }
    enum GameState
    {
        Empty,
        MainMenu,
        Options,
        Playing,
        Hotkeys,
        Instructions,
        GameOver,
        Counting,
        NextLevel,
        Credits
    }
    public enum FoodStatus
    {
        Held,
        Thrown,
        Hit,
        OutOfScreen
    }
    public enum EnemyStatus
    {
        Alive,
        Spawning,
        Dead
    }
}
