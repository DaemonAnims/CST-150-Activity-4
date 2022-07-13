namespace Activity_4
{
    public partial class TimeCalculator : Form
    {
        public TimeCalculator()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int daysConsecutive = 0, hoursConsecutive = 0, minutesConsecutive = 0;
            double daysTotal = 0, hoursTotal = 0, minutesTotal = 0;


            //Try parsing input, if failed to parse into integer, show failure message
            if (int.TryParse(secondsEntryTextbox.Text, out int seconds))
            {

                //check for positive value, if negative show message box
                if (seconds > 0)
                {
                    //if more than or equal to 60 seconds, get total minutes
                    if (seconds >= 60)
                    {
                        minutesTotal = seconds / 60.0;
                        minutesTotalTextbox.Text = minutesTotal.ToString("n");
                        
                        //if more than or equal to 3600 seconds, get total hours
                        if (seconds >= 3600)
                        {
                            hoursTotal = seconds / 3600.0;
                            hoursTotalTextbox.Text = hoursTotal.ToString("n");

                            //if more than or equal to 86400 seconds, get total days
                            if (seconds >= 86400)
                            {
                                daysTotal = seconds / 86400.0;
                                daysTotalTextbox.Text = daysTotal.ToString("n");
                            }
                            else
                            {
                                daysTotalTextbox.Text = "N/A";
                            }
                        }
                        else
                        {
                            hoursTotalTextbox.Text = "N/A";
                            daysTotalTextbox.Text = "N/A";
                        }
                    }
                    else
                    {
                        minutesTotalTextbox.Text = "N/A";
                        hoursTotalTextbox.Text = "N/A";
                        daysTotalTextbox.Text = "N/A";
                    }

                    //check if number entered is greater than or equal to amount of seconds in a day
                    if (seconds >= 86400)
                    {
                        daysConsecutive = seconds / 86400; //get number of days from amount of seconds
                        seconds %= 86400; //update seconds to leftover from amount of days
                    }

                    //check if number entered (or leftover from days conversion) is greater than or equal to amount of seconds in an hour
                    if (seconds >= 3600)
                    {
                        hoursConsecutive = seconds / 3600; //get number of hours from amount of seconds (either leftover or original)
                        seconds %= 3600; //updates seconds to leftover from amount of hours
                    }


                    //check if number entered (or leftover from previous conversions) is greater than or equal to amount of seconds in a minute
                    if (seconds >= 60)
                    {
                        minutesConsecutive = seconds / 60; //get number of minutes from amount of seconds (either leftover or original)
                        seconds %= 60; //updates seconds to leftover from amount of minutes
                    }

                    string answer = ""; //initialize string to return for answerLabel

                    //if amount of days is higher than 0, add day line to answer
                    if (daysConsecutive > 0)
                    {
                        answer = "Days: " + daysConsecutive + System.Environment.NewLine;
                    }

                    //if amount of hours is higher than 0, add hour line to answer
                    if (hoursConsecutive > 0)
                    {
                        answer = answer + "Hours: " + hoursConsecutive + System.Environment.NewLine;
                    }

                    //if amount of minutes is higher than 0, add minute line to answer
                    if (minutesConsecutive > 0)
                    {
                        answer = answer + "Minutes: " + minutesConsecutive + System.Environment.NewLine;
                    }

                    //if any leftover seconds, display them on another line
                    if (seconds > 0)
                    {
                        answer = answer + "Seconds: " + seconds;
                    }

                    consecutiveAnswerLabel.Text = answer;
                }

                else
                {
                    MessageBox.Show("Please input a positive integer!");
                }

                

            }
            else
            {
                MessageBox.Show("That is not an integer! Please enter an amount of seconds in integers only!");
            }
        }
    }
}