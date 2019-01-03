namespace WilliamsChallenges.TestCases
{
    public class Problem1 : TestCase
    {
        public string[][] GetInputs()
        {
            return new string[][]
            {
                new string[]{ "Leo" },
                new string[]{ "Leo", "Jason" },
                new string[]{ "Leo", "Jason", "Julie" },
                new string[]{ "Leo", "Leo", "Jason", "Jason", "PJ" },
                new string[]{ "Julie", "Leo" },
                new string[]{ "Chris", "Jason", "Chris" },
                new string[]{ "Chris" },
                new string[]{ "PJ", "PJ" },
                new string[]{ "Matt", "Leo", "PJ", "Jason", "Julie", "Chris" },
                new string[]{ "PJ", "Matt" },
                new string[]{ "Matt", "Matt", "Matt", "Matt", "Matt" },
                new string[]{ "Leo", "" },
                new string[]{ "Leo", "Matt", "", "", "Leo", "Matt", "PJ" }
            };
        }

        public string[] GetOutputs()
        {
            return new string[]
            {
                "Hello Grand Shaman!",
                "Hello Grand Shaman and Thiudis!",
                "Hello Grand Shaman, Thiudis, and Amythest Unicorn Tamer!",
                "Hello Grand Shaman, Thiudis, and PJ!",
                "Hello Amythest Unicorn Tamer and Grand Shaman!",
                "Hello McNutty and Thiudis!",
                "Hello McNutty!",
                "Hello PJ!",
                "Hello TheGib, Grand Shaman, PJ, Thiudis, Amythest Unicorn Tamer, and McNutty!",
                "Hello PJ and TheGib!",
                "Hello TheGib!",
                "Hello Grand Shaman!",
                "Hello Grand Shaman, TheGib, and PJ!"
            };
        }
    }
}