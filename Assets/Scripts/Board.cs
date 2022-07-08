using UnityEngine;
using UnityEngine.Tilemaps;

public class Board : MonoBehaviour

{
    //permet d'appeler une pièce sur notre grille
    public Tilemap Tilemap { get; private set; }
    public TetrominoData[] tetrominoes;

//permet d'appeler les pieces a un endroit quand elle sont initializé

    private void Awake()
    {
        this.Tilemap = GetComponentInChildren<Tilemap>();

        for (int i = 0; i < this.tetrominoes.Length; i++) {
            this.tetrominoes[i].Initialize();
        }
    }

    //fonction de démarrage du jeu
    //en rajoutant la fonction SpawnPiece() dans la fonction Start() cela permet que quand le jeu démarre 
    //il fasse apparaitre une pièces

    private void Start()
    {
        SpawnPiece();
    }

    //fonction pour faire spawn un pièce tétris
    public void SpawnPiece()
    {
        //fonction random pour faire appairatre aléatoirement la piece de tétris
        int random = Random.Range(0, this.tetrominoes.Length);
        TetrominoData data = this.tetrominoes[random];

    }

    public void Set(Piece piece)
    {
        for (int i = 0; i <)

    }
}
