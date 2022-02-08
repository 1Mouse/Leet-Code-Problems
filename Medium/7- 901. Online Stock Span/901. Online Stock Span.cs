    public class StockSpanner
    {
        public Stack<KeyValuePair<int,int>> stock = new Stack<KeyValuePair<int, int>>();
        public StockSpanner()
        {

        }

        public int Next(int price)
        {
            int span = 1;

            while(stock.Count!=0 && stock.Peek().Key <= price)
            {
                span += stock.Pop().Value;
            }

            stock.Push(new KeyValuePair<int, int>(price, span));

            return span;
        }
    }