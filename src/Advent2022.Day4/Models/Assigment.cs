namespace Advent2022.Day4.Models
{
    internal class Assigment
    {
        private int _min;
        private int _max;

        private IEnumerable<int> _values;

        public Assigment(string value)
        {
            var stringValues = value.Split("-");

            _min = int.Parse(stringValues[0]);
            _max = int.Parse(stringValues[1]);


            if (_min == _max)
            {
                _values = new List<int>() { _min };
            }
            else 
            {
                _values = Enumerable.Range(_min, _max - _min + 1);
            }
        }

        public int Count => _values.Count();

        public IEnumerable<int> Values => _values;

        public IEnumerable<int> Except(Assigment assigment)
            => _values.Except(assigment.Values);

        public IEnumerable<int> Intersect(Assigment assigment)
            => _values.Intersect(assigment.Values);
    }
}
