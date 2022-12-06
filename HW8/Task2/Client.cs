
namespace HW8.Task2
{
    public class Client
    {
        private int _experience;
        private string? _nation;
        private int _age;
        private string _name;
        public string Name { get; set; }
        public int Experience
        {
            get => _experience;
            set
            {
                if (value < 2)
                    throw new ArgumentException($"Car is forbidden due to the driving expirience: {value}");
                else
                    _experience = value;
            }
        }
        public string Nation
        {
            get => _nation;
            set
            {
                if (value == "Russian")
                    throw new ClientException(value);
                else
                    _nation = value;
            }
        }
        public int Age
        {
            get => _age;
            set
            {
                if (value > 70)
                    throw new ClientException(value);
                else
                    _age = value;
            }
        }
    }
}
