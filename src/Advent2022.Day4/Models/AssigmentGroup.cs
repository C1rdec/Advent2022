namespace Advent2022.Day4.Models
{
    internal class AssigmentGroup
    {
        private Assigment _firstAssigment;
        private Assigment _secondAssigment;

        public AssigmentGroup(string value)
        {
            var values = value.Split(",");

            _firstAssigment = new Assigment(values[0]);
            _secondAssigment = new Assigment(values[1]);
        }

        public bool IsFullyContained()
        {
            IEnumerable<int> difference;
            if (_firstAssigment.Count < _secondAssigment.Count)
            {
                difference = _firstAssigment.Except(_secondAssigment);
            }
            else
            {
                difference = _secondAssigment.Except(_firstAssigment);
            }

            return !difference.Any();
        }

        public bool AnyOverlap()
        {
            IEnumerable<int> difference;
            if (_firstAssigment.Count > _secondAssigment.Count)
            {
                difference = _firstAssigment.Intersect(_secondAssigment);
            }
            else
            {
                difference = _secondAssigment.Intersect(_firstAssigment);
            }

            return difference.Any();
        }
    }
}
