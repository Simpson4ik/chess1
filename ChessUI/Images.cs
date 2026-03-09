using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using ChessLogic;

namespace ChessUI
{
    public class Images
    {
        private static readonly Dictionary<PieceType, ImageSource> whiteSources = new()
        {
            {PieceType.King, LoadImage("Assets/KingW.png")},
            {PieceType.Queen, LoadImage("Assets/QueenW.png")},
            {PieceType.Rook, LoadImage("Assets/RookW.png")},
            {PieceType.Pawn, LoadImage("Assets/PawnW.png")},
            {PieceType.Bishop, LoadImage("Assets/BishopW.png")},
            {PieceType.Knight, LoadImage("Assets/KnightW.png")}
        };
        private static readonly Dictionary<PieceType, ImageSource> blackSources = new()
        {
            {PieceType.King, LoadImage("Assets/KingB.png")},
            {PieceType.Queen, LoadImage("Assets/QueenB.png")},
            {PieceType.Rook, LoadImage("Assets/RookB.png")},
            {PieceType.Pawn, LoadImage("Assets/PawnB.png")},
            {PieceType.Bishop, LoadImage("Assets/BishopB.png")},
            {PieceType.Knight, LoadImage("Assets/KnightB.png")}
        };

        private static ImageSource LoadImage (string filePath)
        {
            return new BitmapImage(new Uri(filePath, UriKind.Relative));
        }

        public static ImageSource GetImage(Player color,PieceType type)
        {
                return color switch
                {
                    Player.White => whiteSources[type],
                    Player.Black => blackSources[type],
                    _ => null
                };
        }

        public static ImageSource GetImage(Piece piece)
        {
            if (piece == null)
            {
                return null;
            }
            return GetImage(piece.Color, piece.Type);
        }
    }
}
