using System.Collections.Generic;

namespace WilliamsChallenges.Problems
{
    /*
     * Problem 1 - Hello World on Steroids
     */
    public class Problem1 : Runnable
    {
        /*
         * Dustin Graham was on his last rope. A Tribe Called Rest had just lost the great Bryan Barbour
         * to madness, and the team was falling apart before his eyes.  The impending Authentication Fire
         * gave Dustin nightmares, and he would often wake up in a cold sweat. Leo was going rogue, cowboying
         * in unsupervised fixes to last minute bugs without leadership approval.  It was a bomb waiting to exlode,
         * in more ways than one.  Team morale was at an all time low, and no team member was doing anything to fix
         * what was sure to be a doomed future.
         *
         * That is where you come in, William.  You are tasked with joining A Tribe Called Rest
         * and Making ATCR Great Again.  However, none of the teammates even respond to your greetings.
         * In order to make them acknowledge you, you must call them by their pretentious nicknames.
         *
         * Pretentious nicknames [Leo: "Grand Shaman", Julie: "Amythest Unicorn Tamer", Jason: "Thiudis", Chris: "McNutty", Matt: "TheGib", PJ: "PJ"]
         *
         * Your input is a list of team member names, such as ["Leo"]. Your output should be a string in the format of
         * "Hello Grand Shaman!"
         *
         * Test Cases:
         * Input: ["Leo"]
         * Edge case: None
         * Output "Hello Grand Shaman!"
         *
         * Input: ["Leo", "Leo"]
         * Edge case: Duplicate input name
         * Output "Hello Grand Shaman!"
         *
         * Input ["Leo", "Jason"]
         * Edge case: 2 names
         * Output: "Hello Grand Shaman and Thiudis!"
         *
         * Input ["Leo", "Jason", "Julie"]
         * Edge case: more than 2 names
         * Output: "Hello Grand Shaman, Thiudis, and Amythest Unicorn Tamer!"
         *
         * Input ["Leo", "Kane", "Julie"]
         * Edge case: Kane is not on ATCR
         * Output: "Hello Grand Shaman and Amythest Unicorn Tamer!"
         *
         * Input ["Leo", "Julie", "Leo", "Julie", "Matt", "Leo"]
         * Edge case: Names should be displayed in the order they come in the input, even if there are later duplicates.
         * Output: "Hello Grand Shaman, Amythest Unicorn Tamer, and TheGib!"
         */
        public string Run(string[] input)
        {
            throw new System.NotImplementedException();
        }
    }
}