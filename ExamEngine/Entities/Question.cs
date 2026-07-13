namespace ExamFactory.Entities
{
    public class Question
    {
        public int Id { get; private set; }

        public string Context { get; private set; }

        public List<string> Answers { get; private set; }

        public int CorrectAnswerIndex { get; private set; }

        public int Value { get; private set; }

        public Question(
            string context,
            string answer1,
            string answer2,
            string answer3,
            string answer4,
            int correctAnswerIndex,
            int value)
        {
            Context = context;

            Answers = new List<string>
        {
            answer1,
            answer2,
            answer3,
            answer4
        };

            CorrectAnswerIndex = correctAnswerIndex;
            Value = value;
        }

        public bool IsCorrect(int selectedAnswerIndex)
        {
            return selectedAnswerIndex == CorrectAnswerIndex;
        }
    }
}
