using UnityEngine;

public class Piece : MonoBehaviour
{
    public Board board { get; private set; }
    public TetrominoData data { get; private set; }
    public Vector3int[] cells { get; private set; }
    public Vector3int position {get; private set; }

    // fonction qui permet avoir une position de spawn des pièces 
    public void Initialize(Board board, Vector3int position, TetrominoData data)
    {
        this.board = board;
        this.position = position;
        this.data = data;

        //a modifier si on rajoute des pieces a plus que 4 cellule (petit carrée)
        if (this.cells == null){
            this.cells = new Vector3int[data.cells.Length];
        }

        for (int i = 0; i < data.cells.Lentgh; i++) {
            this.cells[i] = (Vector3int)data.cells[i];
        }
    }


}
