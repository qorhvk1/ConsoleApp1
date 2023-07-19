using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    internal class Q02
    {
        Examples.Service.BoardService boardService;

        public void Run()
        {
            Examples.Model.Board board = new Examples.Model.Board();
            board.Number = 2;
            Console.WriteLine("제목을 입력하세요 :");
            board.Title = Console.ReadLine();
            Console.WriteLine("내용을 입력하세요:");
            board.Contents = Console.ReadLine();
            Console.WriteLine("작성자 이름을 입력하세요 : ");
            board.Writer = Console.ReadLine();

            boardService = new Examples.Service.BoardService(board);

            boardService.Read();
        }
    }
}