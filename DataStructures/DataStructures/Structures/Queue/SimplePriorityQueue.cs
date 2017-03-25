namespace DataStructures.Structures.Queue
{
    public class SimplePriorityQueue : IPriorityQueue<int>
    {
        private int[] _queue = new int[50];
        private int _index;
        private int _minIndex = -1;

        public void Insert(int element)
        {
            _queue[_index] = element;
            _index++;
            _minIndex = -1;
        }

        public int FindMin()
        {
            if (_minIndex != -1)
            {
                return _queue[_minIndex];
            }

            var j = _queue[0];
            _minIndex = 0;

            for (var i = 1; i < _index; i++)
            {
                if (_queue[i] < j)
                {
                    j = _queue[i];
                    _minIndex = i;
                }
            }

            return _queue[_minIndex];
        }

        public void DeleteMin()
        {
            FindMin();
            var newList = new int[50];
            for (var i = 0; i < _minIndex; i++)
            {
                newList[i] = _queue[i];
            }

            for (var j = _index; j > _minIndex; j--)
            {
                newList[j] = _queue[j];
            }
            _queue = newList;
            _index--;
            _minIndex = -1;
        }
    }
}