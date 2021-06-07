using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoModel
{
    public class BingoNumber
    {
        public int value { get; set; }
        public bool isSelected { get; set; }
    }
    public class BingoGenerator
    {
        private int min { get; set; }
        private int max { get; set; }
        public  List<BingoNumber> bingoNumbers = new List<BingoNumber>();

        public BingoGenerator(int _min, int _max)
        {
           
        }

        private void init()
        {
           
        }
        
        public bool Generate()
        {
            return true;
        }
        #region here is the answer , please do it your own first
        //public BingoGenerator(int _min, int _max)
        //{
        //    min = _min;
        //    max = _max;
        //    init();
        //}

        //private void init()
        //{
        //    bingoNumbers = Enumerable.Range(min, max).Select(c => new BingoNumber() { value = c, isSelected = false })
        //        .ToList();
        //}
        //Random rnd = new Random();
        ////return true when there are number , false then there are no number
        //public bool Generate()
        //{
        //    var result = bingoNumbers.Where(x => !x.isSelected).ToList();
        //    if (result.Any())
        //    {
        //        var bingo = result[rnd.Next(result.Count)];
        //        bingo.isSelected = true;
        //        bingoNumbers[bingo.value - 1] = bingo;
        //        return true;
        //    }
        //    return false;
        //}

        #endregion



    }
}
