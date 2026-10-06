namespace Library
{
    internal class Member
    {
        private int memberId;
        private string name;
        private string address;
        private string phone;

        public int MemberId
        {
            get { return memberId; }
            private set             //private set makes it read-only
            { 
                if(value > 0)
                {
                    memberId = value;
                }
                else
                {
                    Console.WriteLine("Error: Member ID must be greater tham zero.");
                }
            } 
        }
        public string Name
        {
            get { return name; }
            set
            {
                //Ensure name does not contain any numbers
                if(!value.Any(char.IsDigit) && value != "")
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Error: Member name cannot be blank or contain numbers.");
                }
            }
        }
        public string Address
        {
            get { return address; }
            set {  address = value; }
        }
        public string Phone
        {
            get { return phone; }
            set {  phone = value; }
        }

        public Member(int memberId, string name, string address, string phone)
        {
            this.MemberId = memberId; //assigns the camelCase parameter to the PascalCase property
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {MemberId}");
            Console.WriteLine($"Member name: {Name}");
            Console.WriteLine($"Member address: {Address}");
            Console.WriteLine($"Member phone number: {Phone}");
            Console.WriteLine();
        }
    }
}
