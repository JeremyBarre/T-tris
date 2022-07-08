using UnityEngine;
using UnityEngine.Tilemaps;

// lettre représente une pièces de tetris

public enum Tetromino
{
    I,
    O,
    T,
    L,
    J,
    Z,
    S,
}

// permet de reconnaitre le code dans unity et qu'il soit pris en compte

[System.Serializable]


public struct TetrominoData
{
    public  Tetromino Tetromino;
    public  Tile Tile;
    public  Vector2Int[] cells { get; private set; }

    public void Initialize()
    {
        this.cells = Data.Cells[this.Tetromino];
    }
}